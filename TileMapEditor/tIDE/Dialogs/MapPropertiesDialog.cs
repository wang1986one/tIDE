﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using XTile;

using TileMapEditor.Commands;
using TileMapEditor.Controls;

namespace TileMapEditor.Dialogs
{
    public partial class MapPropertiesDialog : Form
    {
        #region Private Variables

        private Map m_map;
        private bool m_isNewMap;

        #endregion

        #region Private Methods

        private void MarkAsModified()
        {
            m_buttonApply.Enabled = m_buttonOk.Enabled = true;
            m_buttonCancel.Text = "&Cancel";
            m_buttonCancel.DialogResult = DialogResult.Cancel;
        }

        private void OnDialogLoad(object sender, EventArgs eventArgs)
        {
            m_textBoxId.Text = m_map.Id;
            m_textBoxDescription.Text = m_map.Description;
            m_customPropertyGrid.LoadProperties(m_map);

            if (m_isNewMap)
                MarkAsModified();
            else
            {
                m_buttonApply.Enabled = m_buttonOk.Enabled = false;
                m_buttonCancel.Text = "&Close";
                m_buttonCancel.DialogResult = DialogResult.OK;
            }
        }

        private void OnFieldChanged(object sender, EventArgs eventArgs)
        {
            MarkAsModified();
        }

        private void OnPropertyChangedOrDeleted(object sender,
            CustomPropertyEventArgs customPropertyEventArgs)
        {
            MarkAsModified();
        }

        private void OnDialogOk(object sender, EventArgs eventArgs)
        {
            OnDialogApply(this, eventArgs);
        }

        private void OnDialogApply(object sender, EventArgs e)
        {
            Command command = new MapPropertiesCommand(m_map, m_textBoxId.Text, m_textBoxDescription.Text,
                m_customPropertyGrid.NewProperties);
            CommandHistory.Instance.Do(command);

            m_buttonApply.Enabled = m_buttonOk.Enabled = false;
            m_buttonCancel.Text = "&Close";
            m_buttonCancel.DialogResult = DialogResult.OK;
        }

        #endregion

        #region Public Methods

        public MapPropertiesDialog(Map map, bool isNewMap)
        {
            InitializeComponent();

            m_map = map;
            m_isNewMap = isNewMap;
        }

        #endregion
    }
}