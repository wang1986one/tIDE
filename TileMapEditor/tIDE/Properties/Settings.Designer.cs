﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace tIDE.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        /// <summary>
        /// The recent files opened or saved in tIDE
        /// </summary>
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("The recent files opened or saved in tIDE")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::System.Collections.Specialized.StringCollection RecentFiles {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["RecentFiles"]));
            }
            set {
                this["RecentFiles"] = value;
            }
        }
        
        /// <summary>
        /// The current interface language
        /// </summary>
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("The current interface language")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("(Default)")]
        public global::System.Globalization.CultureInfo Language {
            get {
                return ((global::System.Globalization.CultureInfo)(this["Language"]));
            }
            set {
                this["Language"] = value;
            }
        }
        
        /// <summary>
        /// Maximum number of recent files recalled
        /// </summary>
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("Maximum number of recent files recalled")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("10")]
        public byte RecentFilesMaxCount {
            get {
                return ((byte)(this["RecentFilesMaxCount"]));
            }
            set {
                this["RecentFilesMaxCount"] = value;
            }
        }
        
        /// <summary>
        /// Path to the associated image editor
        /// </summary>
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("Path to the associated image editor")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string ImageEditingTool {
            get {
                return ((string)(this["ImageEditingTool"]));
            }
            set {
                this["ImageEditingTool"] = value;
            }
        }
    }
}
