﻿namespace TileMapEditor
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.SplitContainer m_splitContainerVertical;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.m_toolStripContainer = new System.Windows.Forms.ToolStripContainer();
            this.m_splitContainerLeftRight = new System.Windows.Forms.SplitContainer();
            this.m_splitter = new System.Windows.Forms.Splitter();
            this.m_menuStrip = new System.Windows.Forms.MenuStrip();
            this.m_fileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.m_fileNewMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.m_fileOpenMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.m_fileSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.m_fileSaveMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.m_fileSaveAsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.m_fileSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.m_editMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.m_editUndoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.m_editRedoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.m_editMenuSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.m_editCutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.m_editCopyMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.m_editPasteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.m_editMenuSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.m_editSelectAllMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.m_mapMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.m_mapPropertiesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.m_layerMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.m_layerNewMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.m_layerPropertiesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.m_LayerSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.m_layerBringForwardMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.m_layerSendBackwardMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.m_layerDeleteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.m_tileSheetMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.m_tileSheetNewMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.m_tileSheetPropertiesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.m_tileSheetSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.m_tileSheetDeleteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.m_helpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.m_editToolStrip = new System.Windows.Forms.ToolStrip();
            this.m_editSingleTileButton = new System.Windows.Forms.ToolStripButton();
            this.m_editTileBlockButton = new System.Windows.Forms.ToolStripButton();
            this.m_editToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.m_editUndoButton = new System.Windows.Forms.ToolStripButton();
            this.m_editRedoButton = new System.Windows.Forms.ToolStripButton();
            this.m_editToolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.m_editCutButton = new System.Windows.Forms.ToolStripButton();
            this.m_editCopyButton = new System.Windows.Forms.ToolStripButton();
            this.m_editPasteButton = new System.Windows.Forms.ToolStripButton();
            this.m_mapTreeView = new TileMapEditor.Control.MapTreeView();
            this.m_tilePicker = new TileMapEditor.Control.TilePicker();
            this.m_contentPanel = new TileMapEditor.Control.CustomPanel();
            this.m_verticalScrollBar = new System.Windows.Forms.VScrollBar();
            this.m_horizontalScrollBar = new System.Windows.Forms.HScrollBar();
            m_splitContainerVertical = new System.Windows.Forms.SplitContainer();
            m_splitContainerVertical.Panel1.SuspendLayout();
            m_splitContainerVertical.Panel2.SuspendLayout();
            m_splitContainerVertical.SuspendLayout();
            this.m_toolStripContainer.ContentPanel.SuspendLayout();
            this.m_toolStripContainer.TopToolStripPanel.SuspendLayout();
            this.m_toolStripContainer.SuspendLayout();
            this.m_splitContainerLeftRight.Panel1.SuspendLayout();
            this.m_splitContainerLeftRight.Panel2.SuspendLayout();
            this.m_splitContainerLeftRight.SuspendLayout();
            this.m_menuStrip.SuspendLayout();
            this.m_editToolStrip.SuspendLayout();
            this.m_contentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_splitContainerVertical
            // 
            m_splitContainerVertical.Dock = System.Windows.Forms.DockStyle.Fill;
            m_splitContainerVertical.Location = new System.Drawing.Point(0, 0);
            m_splitContainerVertical.Name = "m_splitContainerVertical";
            m_splitContainerVertical.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // m_splitContainerVertical.Panel1
            // 
            m_splitContainerVertical.Panel1.Controls.Add(this.m_mapTreeView);
            // 
            // m_splitContainerVertical.Panel2
            // 
            m_splitContainerVertical.Panel2.Controls.Add(this.m_tilePicker);
            m_splitContainerVertical.Size = new System.Drawing.Size(200, 513);
            m_splitContainerVertical.SplitterDistance = 250;
            m_splitContainerVertical.TabIndex = 1;
            // 
            // m_toolStripContainer
            // 
            // 
            // m_toolStripContainer.ContentPanel
            // 
            this.m_toolStripContainer.ContentPanel.Controls.Add(this.m_splitContainerLeftRight);
            this.m_toolStripContainer.ContentPanel.Controls.Add(this.m_splitter);
            this.m_toolStripContainer.ContentPanel.Size = new System.Drawing.Size(784, 513);
            this.m_toolStripContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_toolStripContainer.Location = new System.Drawing.Point(0, 0);
            this.m_toolStripContainer.Name = "m_toolStripContainer";
            this.m_toolStripContainer.Size = new System.Drawing.Size(784, 562);
            this.m_toolStripContainer.TabIndex = 0;
            this.m_toolStripContainer.Text = "toolStripContainer1";
            // 
            // m_toolStripContainer.TopToolStripPanel
            // 
            this.m_toolStripContainer.TopToolStripPanel.Controls.Add(this.m_menuStrip);
            this.m_toolStripContainer.TopToolStripPanel.Controls.Add(this.m_editToolStrip);
            // 
            // m_splitContainerLeftRight
            // 
            this.m_splitContainerLeftRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_splitContainerLeftRight.Location = new System.Drawing.Point(4, 0);
            this.m_splitContainerLeftRight.Name = "m_splitContainerLeftRight";
            // 
            // m_splitContainerLeftRight.Panel1
            // 
            this.m_splitContainerLeftRight.Panel1.Controls.Add(m_splitContainerVertical);
            // 
            // m_splitContainerLeftRight.Panel2
            // 
            this.m_splitContainerLeftRight.Panel2.Controls.Add(this.m_contentPanel);
            this.m_splitContainerLeftRight.Size = new System.Drawing.Size(780, 513);
            this.m_splitContainerLeftRight.SplitterDistance = 200;
            this.m_splitContainerLeftRight.TabIndex = 3;
            // 
            // m_splitter
            // 
            this.m_splitter.Location = new System.Drawing.Point(0, 0);
            this.m_splitter.Name = "m_splitter";
            this.m_splitter.Size = new System.Drawing.Size(4, 513);
            this.m_splitter.TabIndex = 1;
            this.m_splitter.TabStop = false;
            // 
            // m_menuStrip
            // 
            this.m_menuStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.m_menuStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.m_menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_fileMenuItem,
            this.m_editMenuItem,
            this.m_mapMenuItem,
            this.m_layerMenuItem,
            this.m_tileSheetMenuItem,
            this.m_helpMenuItem});
            this.m_menuStrip.Location = new System.Drawing.Point(0, 0);
            this.m_menuStrip.Name = "m_menuStrip";
            this.m_menuStrip.Size = new System.Drawing.Size(784, 24);
            this.m_menuStrip.TabIndex = 0;
            this.m_menuStrip.Text = "Menu Strip";
            // 
            // m_fileMenuItem
            // 
            this.m_fileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_fileNewMenuItem,
            this.m_fileOpenMenuItem,
            this.m_fileSeparator1,
            this.m_fileSaveMenuItem,
            this.m_fileSaveAsMenuItem,
            this.m_fileSeparator2,
            this.exitToolStripMenuItem});
            this.m_fileMenuItem.Image = global::TileMapEditor.Properties.Resources.File;
            this.m_fileMenuItem.Name = "m_fileMenuItem";
            this.m_fileMenuItem.Size = new System.Drawing.Size(53, 20);
            this.m_fileMenuItem.Text = "&File";
            // 
            // m_fileNewMenuItem
            // 
            this.m_fileNewMenuItem.Image = global::TileMapEditor.Properties.Resources.FileNew;
            this.m_fileNewMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.m_fileNewMenuItem.Name = "m_fileNewMenuItem";
            this.m_fileNewMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.m_fileNewMenuItem.Size = new System.Drawing.Size(146, 22);
            this.m_fileNewMenuItem.Text = "&New";
            this.m_fileNewMenuItem.Click += new System.EventHandler(this.OnFileNew);
            // 
            // m_fileOpenMenuItem
            // 
            this.m_fileOpenMenuItem.Image = global::TileMapEditor.Properties.Resources.FileOpen;
            this.m_fileOpenMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.m_fileOpenMenuItem.Name = "m_fileOpenMenuItem";
            this.m_fileOpenMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.m_fileOpenMenuItem.Size = new System.Drawing.Size(146, 22);
            this.m_fileOpenMenuItem.Text = "&Open";
            // 
            // m_fileSeparator1
            // 
            this.m_fileSeparator1.Name = "m_fileSeparator1";
            this.m_fileSeparator1.Size = new System.Drawing.Size(143, 6);
            // 
            // m_fileSaveMenuItem
            // 
            this.m_fileSaveMenuItem.Image = global::TileMapEditor.Properties.Resources.FileSave;
            this.m_fileSaveMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.m_fileSaveMenuItem.Name = "m_fileSaveMenuItem";
            this.m_fileSaveMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.m_fileSaveMenuItem.Size = new System.Drawing.Size(146, 22);
            this.m_fileSaveMenuItem.Text = "&Save";
            // 
            // m_fileSaveAsMenuItem
            // 
            this.m_fileSaveAsMenuItem.Image = global::TileMapEditor.Properties.Resources.FileSaveAs;
            this.m_fileSaveAsMenuItem.Name = "m_fileSaveAsMenuItem";
            this.m_fileSaveAsMenuItem.Size = new System.Drawing.Size(146, 22);
            this.m_fileSaveAsMenuItem.Text = "Save &As";
            // 
            // m_fileSeparator2
            // 
            this.m_fileSeparator2.Name = "m_fileSeparator2";
            this.m_fileSeparator2.Size = new System.Drawing.Size(143, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // m_editMenuItem
            // 
            this.m_editMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_editUndoMenuItem,
            this.m_editRedoMenuItem,
            this.m_editMenuSeparator1,
            this.m_editCutMenuItem,
            this.m_editCopyMenuItem,
            this.m_editPasteMenuItem,
            this.m_editMenuSeparator2,
            this.m_editSelectAllMenuItem});
            this.m_editMenuItem.Image = global::TileMapEditor.Properties.Resources.Edit;
            this.m_editMenuItem.Name = "m_editMenuItem";
            this.m_editMenuItem.Size = new System.Drawing.Size(55, 20);
            this.m_editMenuItem.Text = "&Edit";
            // 
            // m_editUndoMenuItem
            // 
            this.m_editUndoMenuItem.Image = global::TileMapEditor.Properties.Resources.EditUndo;
            this.m_editUndoMenuItem.Name = "m_editUndoMenuItem";
            this.m_editUndoMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.m_editUndoMenuItem.Size = new System.Drawing.Size(144, 22);
            this.m_editUndoMenuItem.Text = "&Undo";
            // 
            // m_editRedoMenuItem
            // 
            this.m_editRedoMenuItem.Image = global::TileMapEditor.Properties.Resources.EditRedo;
            this.m_editRedoMenuItem.Name = "m_editRedoMenuItem";
            this.m_editRedoMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.m_editRedoMenuItem.Size = new System.Drawing.Size(144, 22);
            this.m_editRedoMenuItem.Text = "&Redo";
            // 
            // m_editMenuSeparator1
            // 
            this.m_editMenuSeparator1.Name = "m_editMenuSeparator1";
            this.m_editMenuSeparator1.Size = new System.Drawing.Size(141, 6);
            // 
            // m_editCutMenuItem
            // 
            this.m_editCutMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("m_editCutMenuItem.Image")));
            this.m_editCutMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.m_editCutMenuItem.Name = "m_editCutMenuItem";
            this.m_editCutMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.m_editCutMenuItem.Size = new System.Drawing.Size(144, 22);
            this.m_editCutMenuItem.Text = "Cu&t";
            // 
            // m_editCopyMenuItem
            // 
            this.m_editCopyMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("m_editCopyMenuItem.Image")));
            this.m_editCopyMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.m_editCopyMenuItem.Name = "m_editCopyMenuItem";
            this.m_editCopyMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.m_editCopyMenuItem.Size = new System.Drawing.Size(144, 22);
            this.m_editCopyMenuItem.Text = "&Copy";
            // 
            // m_editPasteMenuItem
            // 
            this.m_editPasteMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("m_editPasteMenuItem.Image")));
            this.m_editPasteMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.m_editPasteMenuItem.Name = "m_editPasteMenuItem";
            this.m_editPasteMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.m_editPasteMenuItem.Size = new System.Drawing.Size(144, 22);
            this.m_editPasteMenuItem.Text = "&Paste";
            // 
            // m_editMenuSeparator2
            // 
            this.m_editMenuSeparator2.Name = "m_editMenuSeparator2";
            this.m_editMenuSeparator2.Size = new System.Drawing.Size(141, 6);
            // 
            // m_editSelectAllMenuItem
            // 
            this.m_editSelectAllMenuItem.Name = "m_editSelectAllMenuItem";
            this.m_editSelectAllMenuItem.Size = new System.Drawing.Size(144, 22);
            this.m_editSelectAllMenuItem.Text = "Select &All";
            // 
            // m_mapMenuItem
            // 
            this.m_mapMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_mapPropertiesMenuItem});
            this.m_mapMenuItem.Image = global::TileMapEditor.Properties.Resources.Map;
            this.m_mapMenuItem.Name = "m_mapMenuItem";
            this.m_mapMenuItem.Size = new System.Drawing.Size(59, 20);
            this.m_mapMenuItem.Text = "&Map";
            // 
            // m_mapPropertiesMenuItem
            // 
            this.m_mapPropertiesMenuItem.Image = global::TileMapEditor.Properties.Resources.MapProperties;
            this.m_mapPropertiesMenuItem.Name = "m_mapPropertiesMenuItem";
            this.m_mapPropertiesMenuItem.Size = new System.Drawing.Size(136, 22);
            this.m_mapPropertiesMenuItem.Text = "Properties...";
            this.m_mapPropertiesMenuItem.Click += new System.EventHandler(this.OnMapProperties);
            // 
            // m_layerMenuItem
            // 
            this.m_layerMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_layerNewMenuItem,
            this.m_layerPropertiesMenuItem,
            this.m_LayerSeparator1,
            this.m_layerBringForwardMenuItem,
            this.m_layerSendBackwardMenuItem,
            this.toolStripMenuItem1,
            this.m_layerDeleteMenuItem});
            this.m_layerMenuItem.Image = global::TileMapEditor.Properties.Resources.Layer;
            this.m_layerMenuItem.Name = "m_layerMenuItem";
            this.m_layerMenuItem.Size = new System.Drawing.Size(63, 20);
            this.m_layerMenuItem.Text = "&Layer";
            // 
            // m_layerNewMenuItem
            // 
            this.m_layerNewMenuItem.Image = global::TileMapEditor.Properties.Resources.LayerNew;
            this.m_layerNewMenuItem.Name = "m_layerNewMenuItem";
            this.m_layerNewMenuItem.Size = new System.Drawing.Size(154, 22);
            this.m_layerNewMenuItem.Text = "&New...";
            this.m_layerNewMenuItem.Click += new System.EventHandler(this.OnLayerNew);
            // 
            // m_layerPropertiesMenuItem
            // 
            this.m_layerPropertiesMenuItem.Enabled = false;
            this.m_layerPropertiesMenuItem.Image = global::TileMapEditor.Properties.Resources.LayerProperties;
            this.m_layerPropertiesMenuItem.Name = "m_layerPropertiesMenuItem";
            this.m_layerPropertiesMenuItem.Size = new System.Drawing.Size(154, 22);
            this.m_layerPropertiesMenuItem.Text = "Properties...";
            this.m_layerPropertiesMenuItem.Click += new System.EventHandler(this.OnLayerProperties);
            // 
            // m_LayerSeparator1
            // 
            this.m_LayerSeparator1.Name = "m_LayerSeparator1";
            this.m_LayerSeparator1.Size = new System.Drawing.Size(151, 6);
            // 
            // m_layerBringForwardMenuItem
            // 
            this.m_layerBringForwardMenuItem.Enabled = false;
            this.m_layerBringForwardMenuItem.Image = global::TileMapEditor.Properties.Resources.LayerBringForward;
            this.m_layerBringForwardMenuItem.Name = "m_layerBringForwardMenuItem";
            this.m_layerBringForwardMenuItem.Size = new System.Drawing.Size(154, 22);
            this.m_layerBringForwardMenuItem.Text = "Bring Forward";
            this.m_layerBringForwardMenuItem.Click += new System.EventHandler(this.OnLayerBringForward);
            // 
            // m_layerSendBackwardMenuItem
            // 
            this.m_layerSendBackwardMenuItem.Enabled = false;
            this.m_layerSendBackwardMenuItem.Image = global::TileMapEditor.Properties.Resources.LayerSendBackward;
            this.m_layerSendBackwardMenuItem.Name = "m_layerSendBackwardMenuItem";
            this.m_layerSendBackwardMenuItem.Size = new System.Drawing.Size(154, 22);
            this.m_layerSendBackwardMenuItem.Text = "Send Backward";
            this.m_layerSendBackwardMenuItem.Click += new System.EventHandler(this.OnLayerSendBackward);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(151, 6);
            // 
            // m_layerDeleteMenuItem
            // 
            this.m_layerDeleteMenuItem.Enabled = false;
            this.m_layerDeleteMenuItem.Image = global::TileMapEditor.Properties.Resources.LayerDelete;
            this.m_layerDeleteMenuItem.Name = "m_layerDeleteMenuItem";
            this.m_layerDeleteMenuItem.Size = new System.Drawing.Size(154, 22);
            this.m_layerDeleteMenuItem.Text = "Delete";
            this.m_layerDeleteMenuItem.Click += new System.EventHandler(this.OnLayerDelete);
            // 
            // m_tileSheetMenuItem
            // 
            this.m_tileSheetMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_tileSheetNewMenuItem,
            this.m_tileSheetPropertiesMenuItem,
            this.m_tileSheetSeparator1,
            this.m_tileSheetDeleteMenuItem});
            this.m_tileSheetMenuItem.Image = global::TileMapEditor.Properties.Resources.TileSheet;
            this.m_tileSheetMenuItem.Name = "m_tileSheetMenuItem";
            this.m_tileSheetMenuItem.Size = new System.Drawing.Size(86, 20);
            this.m_tileSheetMenuItem.Text = "&Tile Sheet";
            // 
            // m_tileSheetNewMenuItem
            // 
            this.m_tileSheetNewMenuItem.Image = global::TileMapEditor.Properties.Resources.TileSheetNew;
            this.m_tileSheetNewMenuItem.Name = "m_tileSheetNewMenuItem";
            this.m_tileSheetNewMenuItem.Size = new System.Drawing.Size(136, 22);
            this.m_tileSheetNewMenuItem.Text = "New...";
            this.m_tileSheetNewMenuItem.Click += new System.EventHandler(this.OnTileSheetNew);
            // 
            // m_tileSheetPropertiesMenuItem
            // 
            this.m_tileSheetPropertiesMenuItem.Enabled = false;
            this.m_tileSheetPropertiesMenuItem.Image = global::TileMapEditor.Properties.Resources.TileSheetProperties;
            this.m_tileSheetPropertiesMenuItem.Name = "m_tileSheetPropertiesMenuItem";
            this.m_tileSheetPropertiesMenuItem.Size = new System.Drawing.Size(136, 22);
            this.m_tileSheetPropertiesMenuItem.Text = "Properties...";
            this.m_tileSheetPropertiesMenuItem.Click += new System.EventHandler(this.OnTileSheetProperties);
            // 
            // m_tileSheetSeparator1
            // 
            this.m_tileSheetSeparator1.Name = "m_tileSheetSeparator1";
            this.m_tileSheetSeparator1.Size = new System.Drawing.Size(133, 6);
            // 
            // m_tileSheetDeleteMenuItem
            // 
            this.m_tileSheetDeleteMenuItem.Enabled = false;
            this.m_tileSheetDeleteMenuItem.Image = global::TileMapEditor.Properties.Resources.TileSheetDelete;
            this.m_tileSheetDeleteMenuItem.Name = "m_tileSheetDeleteMenuItem";
            this.m_tileSheetDeleteMenuItem.Size = new System.Drawing.Size(136, 22);
            this.m_tileSheetDeleteMenuItem.Text = "Delete";
            this.m_tileSheetDeleteMenuItem.Click += new System.EventHandler(this.OnTileSheetDelete);
            // 
            // m_helpMenuItem
            // 
            this.m_helpMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contentsToolStripMenuItem,
            this.indexToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.toolStripSeparator5,
            this.aboutToolStripMenuItem});
            this.m_helpMenuItem.Image = global::TileMapEditor.Properties.Resources.Help;
            this.m_helpMenuItem.Name = "m_helpMenuItem";
            this.m_helpMenuItem.Size = new System.Drawing.Size(60, 20);
            this.m_helpMenuItem.Text = "&Help";
            // 
            // contentsToolStripMenuItem
            // 
            this.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            this.contentsToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.contentsToolStripMenuItem.Text = "&Contents";
            // 
            // indexToolStripMenuItem
            // 
            this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
            this.indexToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.indexToolStripMenuItem.Text = "&Index";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.searchToolStripMenuItem.Text = "&Search";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(119, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = global::TileMapEditor.Properties.Resources.HelpAbout;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            // 
            // m_editToolStrip
            // 
            this.m_editToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.m_editToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_editSingleTileButton,
            this.m_editTileBlockButton,
            this.m_editToolStripSeparator1,
            this.m_editUndoButton,
            this.m_editRedoButton,
            this.m_editToolStripSeparator2,
            this.m_editCutButton,
            this.m_editCopyButton,
            this.m_editPasteButton});
            this.m_editToolStrip.Location = new System.Drawing.Point(3, 24);
            this.m_editToolStrip.Name = "m_editToolStrip";
            this.m_editToolStrip.Size = new System.Drawing.Size(185, 25);
            this.m_editToolStrip.TabIndex = 1;
            // 
            // m_editSingleTileButton
            // 
            this.m_editSingleTileButton.Checked = true;
            this.m_editSingleTileButton.CheckState = System.Windows.Forms.CheckState.Checked;
            this.m_editSingleTileButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.m_editSingleTileButton.Image = ((System.Drawing.Image)(resources.GetObject("m_editSingleTileButton.Image")));
            this.m_editSingleTileButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.m_editSingleTileButton.Name = "m_editSingleTileButton";
            this.m_editSingleTileButton.Size = new System.Drawing.Size(23, 22);
            this.m_editSingleTileButton.Text = "toolStripButton1";
            this.m_editSingleTileButton.ToolTipText = "Draw a single tile";
            this.m_editSingleTileButton.Click += new System.EventHandler(this.OnSingleTileTool);
            // 
            // m_editTileBlockButton
            // 
            this.m_editTileBlockButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.m_editTileBlockButton.Image = ((System.Drawing.Image)(resources.GetObject("m_editTileBlockButton.Image")));
            this.m_editTileBlockButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.m_editTileBlockButton.Name = "m_editTileBlockButton";
            this.m_editTileBlockButton.Size = new System.Drawing.Size(23, 22);
            this.m_editTileBlockButton.Text = "Draw a block of tiles";
            this.m_editTileBlockButton.Click += new System.EventHandler(this.OnTileBlockTool);
            // 
            // m_editToolStripSeparator1
            // 
            this.m_editToolStripSeparator1.Name = "m_editToolStripSeparator1";
            this.m_editToolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // m_editUndoButton
            // 
            this.m_editUndoButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.m_editUndoButton.Image = global::TileMapEditor.Properties.Resources.EditUndo;
            this.m_editUndoButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.m_editUndoButton.Name = "m_editUndoButton";
            this.m_editUndoButton.Size = new System.Drawing.Size(23, 22);
            this.m_editUndoButton.Text = "Undo last change";
            // 
            // m_editRedoButton
            // 
            this.m_editRedoButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.m_editRedoButton.Image = global::TileMapEditor.Properties.Resources.EditRedo;
            this.m_editRedoButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.m_editRedoButton.Name = "m_editRedoButton";
            this.m_editRedoButton.Size = new System.Drawing.Size(23, 22);
            this.m_editRedoButton.Text = "Redo last change";
            // 
            // m_editToolStripSeparator2
            // 
            this.m_editToolStripSeparator2.Name = "m_editToolStripSeparator2";
            this.m_editToolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // m_editCutButton
            // 
            this.m_editCutButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.m_editCutButton.Image = ((System.Drawing.Image)(resources.GetObject("m_editCutButton.Image")));
            this.m_editCutButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.m_editCutButton.Name = "m_editCutButton";
            this.m_editCutButton.Size = new System.Drawing.Size(23, 22);
            this.m_editCutButton.Text = "C&ut";
            // 
            // m_editCopyButton
            // 
            this.m_editCopyButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.m_editCopyButton.Image = ((System.Drawing.Image)(resources.GetObject("m_editCopyButton.Image")));
            this.m_editCopyButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.m_editCopyButton.Name = "m_editCopyButton";
            this.m_editCopyButton.Size = new System.Drawing.Size(23, 22);
            this.m_editCopyButton.Text = "&Copy";
            // 
            // m_editPasteButton
            // 
            this.m_editPasteButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.m_editPasteButton.Image = ((System.Drawing.Image)(resources.GetObject("m_editPasteButton.Image")));
            this.m_editPasteButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.m_editPasteButton.Name = "m_editPasteButton";
            this.m_editPasteButton.Size = new System.Drawing.Size(23, 22);
            this.m_editPasteButton.Text = "&Paste";
            // 
            // m_mapTreeView
            // 
            this.m_mapTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_mapTreeView.Location = new System.Drawing.Point(0, 0);
            this.m_mapTreeView.Map = null;
            this.m_mapTreeView.Name = "m_mapTreeView";
            this.m_mapTreeView.SelectedComponent = null;
            this.m_mapTreeView.Size = new System.Drawing.Size(200, 250);
            this.m_mapTreeView.TabIndex = 0;
            this.m_mapTreeView.ComponentChanged += new TileMapEditor.Control.MapTreeViewEventHandler(this.OnTreeComponentChanged);
            // 
            // m_tilePicker
            // 
            this.m_tilePicker.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.m_tilePicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_tilePicker.Location = new System.Drawing.Point(0, 0);
            this.m_tilePicker.Map = null;
            this.m_tilePicker.Name = "m_tilePicker";
            this.m_tilePicker.Size = new System.Drawing.Size(200, 259);
            this.m_tilePicker.TabIndex = 0;
            // 
            // m_contentPanel
            // 
            this.m_contentPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.m_contentPanel.Controls.Add(this.m_verticalScrollBar);
            this.m_contentPanel.Controls.Add(this.m_horizontalScrollBar);
            this.m_contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_contentPanel.Location = new System.Drawing.Point(0, 0);
            this.m_contentPanel.Name = "m_contentPanel";
            this.m_contentPanel.Size = new System.Drawing.Size(576, 513);
            this.m_contentPanel.TabIndex = 2;
            this.m_contentPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.OnPaintContentPanel);
            // 
            // m_verticalScrollBar
            // 
            this.m_verticalScrollBar.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_verticalScrollBar.LargeChange = 1;
            this.m_verticalScrollBar.Location = new System.Drawing.Point(557, 0);
            this.m_verticalScrollBar.Maximum = 0;
            this.m_verticalScrollBar.Name = "m_verticalScrollBar";
            this.m_verticalScrollBar.Size = new System.Drawing.Size(17, 494);
            this.m_verticalScrollBar.TabIndex = 1;
            // 
            // m_horizontalScrollBar
            // 
            this.m_horizontalScrollBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.m_horizontalScrollBar.LargeChange = 1;
            this.m_horizontalScrollBar.Location = new System.Drawing.Point(0, 494);
            this.m_horizontalScrollBar.Maximum = 0;
            this.m_horizontalScrollBar.Name = "m_horizontalScrollBar";
            this.m_horizontalScrollBar.Size = new System.Drawing.Size(574, 17);
            this.m_horizontalScrollBar.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.m_toolStripContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.m_menuStrip;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tile Map Editor";
            this.Load += new System.EventHandler(this.MainForm_Load);
            m_splitContainerVertical.Panel1.ResumeLayout(false);
            m_splitContainerVertical.Panel2.ResumeLayout(false);
            m_splitContainerVertical.ResumeLayout(false);
            this.m_toolStripContainer.ContentPanel.ResumeLayout(false);
            this.m_toolStripContainer.TopToolStripPanel.ResumeLayout(false);
            this.m_toolStripContainer.TopToolStripPanel.PerformLayout();
            this.m_toolStripContainer.ResumeLayout(false);
            this.m_toolStripContainer.PerformLayout();
            this.m_splitContainerLeftRight.Panel1.ResumeLayout(false);
            this.m_splitContainerLeftRight.Panel2.ResumeLayout(false);
            this.m_splitContainerLeftRight.ResumeLayout(false);
            this.m_menuStrip.ResumeLayout(false);
            this.m_menuStrip.PerformLayout();
            this.m_editToolStrip.ResumeLayout(false);
            this.m_editToolStrip.PerformLayout();
            this.m_contentPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer m_toolStripContainer;
        private System.Windows.Forms.MenuStrip m_menuStrip;
        private System.Windows.Forms.ToolStripMenuItem m_fileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem m_fileNewMenuItem;
        private System.Windows.Forms.ToolStripMenuItem m_fileOpenMenuItem;
        private System.Windows.Forms.ToolStripSeparator m_fileSeparator1;
        private System.Windows.Forms.ToolStripMenuItem m_fileSaveMenuItem;
        private System.Windows.Forms.ToolStripMenuItem m_fileSaveAsMenuItem;
        private System.Windows.Forms.ToolStripSeparator m_fileSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem m_editMenuItem;
        private System.Windows.Forms.ToolStripMenuItem m_editUndoMenuItem;
        private System.Windows.Forms.ToolStripMenuItem m_editRedoMenuItem;
        private System.Windows.Forms.ToolStripSeparator m_editMenuSeparator1;
        private System.Windows.Forms.ToolStripMenuItem m_editCutMenuItem;
        private System.Windows.Forms.ToolStripMenuItem m_editCopyMenuItem;
        private System.Windows.Forms.ToolStripMenuItem m_editPasteMenuItem;
        private System.Windows.Forms.ToolStripSeparator m_editMenuSeparator2;
        private System.Windows.Forms.ToolStripMenuItem m_editSelectAllMenuItem;
        private System.Windows.Forms.ToolStripMenuItem m_helpMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem m_mapMenuItem;
        private System.Windows.Forms.ToolStripMenuItem m_mapPropertiesMenuItem;
        private System.Windows.Forms.ToolStripMenuItem m_layerMenuItem;
        private System.Windows.Forms.ToolStripMenuItem m_layerNewMenuItem;
        private System.Windows.Forms.ToolStripMenuItem m_layerPropertiesMenuItem;
        private System.Windows.Forms.ToolStripMenuItem m_layerDeleteMenuItem;
        private System.Windows.Forms.ToolStripSeparator m_LayerSeparator1;
        private System.Windows.Forms.ToolStripMenuItem m_tileSheetMenuItem;
        private System.Windows.Forms.ToolStripMenuItem m_tileSheetNewMenuItem;
        private System.Windows.Forms.ToolStripMenuItem m_tileSheetPropertiesMenuItem;
        private System.Windows.Forms.ToolStripMenuItem m_tileSheetDeleteMenuItem;
        private System.Windows.Forms.ToolStripSeparator m_tileSheetSeparator1;
        private System.Windows.Forms.Splitter m_splitter;
        private System.Windows.Forms.ToolStripMenuItem m_layerBringForwardMenuItem;
        private System.Windows.Forms.ToolStripMenuItem m_layerSendBackwardMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private Control.MapTreeView m_mapTreeView;
        private System.Windows.Forms.ToolStrip m_editToolStrip;
        private System.Windows.Forms.ToolStripButton m_editSingleTileButton;
        private System.Windows.Forms.ToolStripButton m_editTileBlockButton;
        private System.Windows.Forms.ToolStripSeparator m_editToolStripSeparator1;
        private System.Windows.Forms.ToolStripButton m_editCutButton;
        private System.Windows.Forms.ToolStripButton m_editCopyButton;
        private System.Windows.Forms.ToolStripButton m_editPasteButton;
        private System.Windows.Forms.ToolStripButton m_editUndoButton;
        private System.Windows.Forms.ToolStripButton m_editRedoButton;
        private System.Windows.Forms.ToolStripSeparator m_editToolStripSeparator2;
        private System.Windows.Forms.VScrollBar m_verticalScrollBar;
        private System.Windows.Forms.HScrollBar m_horizontalScrollBar;
        private TileMapEditor.Control.CustomPanel m_contentPanel;
        private System.Windows.Forms.SplitContainer m_splitContainerLeftRight;
        private TileMapEditor.Control.TilePicker m_tilePicker;
    }
}