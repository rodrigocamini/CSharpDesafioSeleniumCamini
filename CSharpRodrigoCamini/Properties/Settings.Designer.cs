﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CSharpRodrigoCamini.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.9.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("30")]
        public string DEFAULT_TIMEOUT_IN_SECONDS {
            get {
                return ((string)(this["DEFAULT_TIMEOUT_IN_SECONDS"]));
            }
            set {
                this["DEFAULT_TIMEOUT_IN_SECONDS"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("3306")]
        public string DB_PORT {
            get {
                return ((string)(this["DB_PORT"]));
            }
            set {
                this["DB_PORT"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("bugtracker")]
        public string DB_NAME {
            get {
                return ((string)(this["DB_NAME"]));
            }
            set {
                this["DB_NAME"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("root")]
        public string DB_USER {
            get {
                return ((string)(this["DB_USER"]));
            }
            set {
                this["DB_USER"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("root")]
        public string DB_PASSWORD {
            get {
                return ((string)(this["DB_PASSWORD"]));
            }
            set {
                this["DB_PASSWORD"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string DB_CONNECTION_TIMEOUT {
            get {
                return ((string)(this["DB_CONNECTION_TIMEOUT"]));
            }
            set {
                this["DB_CONNECTION_TIMEOUT"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("CSharpSeleniumTemplateReport")]
        public string REPORT_NAME {
            get {
                return ((string)(this["REPORT_NAME"]));
            }
            set {
                this["REPORT_NAME"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("C:\\Users\\Rodrigo Camini\\Documents\\Reports\\")]
        public string REPORT_PATH {
            get {
                return ((string)(this["REPORT_PATH"]));
            }
            set {
                this["REPORT_PATH"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("local")]
        public string EXECUTION {
            get {
                return ((string)(this["EXECUTION"]));
            }
            set {
                this["EXECUTION"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("http://192.168.99.100:4444/wd/hub")]
        public string SELENIUM_HUB {
            get {
                return ((string)(this["SELENIUM_HUB"]));
            }
            set {
                this["SELENIUM_HUB"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("192.168.99.100:8989")]
        public string DEFAUL_APPLICATION_URL {
            get {
                return ((string)(this["DEFAUL_APPLICATION_URL"]));
            }
            set {
                this["DEFAUL_APPLICATION_URL"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("192.168.99.100")]
        public string DB_URL {
            get {
                return ((string)(this["DB_URL"]));
            }
            set {
                this["DB_URL"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("chrome")]
        public string BROWSER {
            get {
                return ((string)(this["BROWSER"]));
            }
            set {
                this["BROWSER"] = value;
            }
        }
    }
}
