﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Park_and_Company.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("//div[@class=\'k-grid-content\']")]
        public string ClaimDataGrid {
            get {
                return ((string)(this["ClaimDataGrid"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("//div[@id=\'UserGroupsGrid\']")]
        public string UserGroupGrid {
            get {
                return ((string)(this["UserGroupGrid"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("//div[@id=\'allUsersGrid\']")]
        public string AllUserGrid {
            get {
                return ((string)(this["AllUserGrid"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("//div[@id=\'RolesGrid\']")]
        public string ManageRolesGrid {
            get {
                return ((string)(this["ManageRolesGrid"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("//div[@id=\'PartnerGroupsGrid\']")]
        public string PartenrGrpGrid {
            get {
                return ((string)(this["PartenrGrpGrid"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("//div[@id=\'CustomAttributeGrid\']")]
        public string CustomAttGrid {
            get {
                return ((string)(this["CustomAttGrid"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("//div[@id=\'ManualPointAdjustmentGrid\']")]
        public string ManualPointAdjustmentGrid {
            get {
                return ((string)(this["ManualPointAdjustmentGrid"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("//div[@id=\'ManageIncentiveProgramsGrid\']")]
        public string ManageIncentiveProgramsGrid {
            get {
                return ((string)(this["ManageIncentiveProgramsGrid"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("//div[@id=\'ManualApprovalGrid\']")]
        public string ManualApprovalGrid {
            get {
                return ((string)(this["ManualApprovalGrid"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("//div[@kendo-grid=\'myOrdersGrid\']")]
        public string MyOrdersGrid {
            get {
                return ((string)(this["MyOrdersGrid"]));
            }
            set {
                this["MyOrdersGrid"] = value;
            }
        }
    }
}
