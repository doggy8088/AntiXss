﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.Security.Application.SecurityRuntimeEngine.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.Security.Application.SecurityRuntimeEngine.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot convert plug-in to specified target..
        /// </summary>
        internal static string CannotConvertPluginExceptionMessage {
            get {
                return ResourceManager.GetString("CannotConvertPluginExceptionMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An exception occurred, but Cassini&apos;s pipeline behavior does not behave identically to the IIS pipeline&lt;br /&gt; The exception message is {0}&lt;br /&gt;To see the exception please run under IIS, or debug within Visual Studio where the exception will be caught by VS.&lt;br /&gt;.
        /// </summary>
        internal static string CassiniWarning {
            get {
                return ResourceManager.GetString("CassiniWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Too many suspect results during Page inspection..
        /// </summary>
        internal static string PageInspectionStoppedMessage {
            get {
                return ResourceManager.GetString("PageInspectionStoppedMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} Page Inspectors found..
        /// </summary>
        internal static string PageInspectorsFound {
            get {
                return ResourceManager.GetString("PageInspectorsFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} Request Inspectors found..
        /// </summary>
        internal static string RequestInspectorsFound {
            get {
                return ResourceManager.GetString("RequestInspectorsFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Too many suspect results during Request inspection..
        /// </summary>
        internal static string RequestStoppedMessage {
            get {
                return ResourceManager.GetString("RequestStoppedMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Too many suspect results during Response Header inspection..
        /// </summary>
        internal static string ResponseHeaderInspectionStoppedMessage {
            get {
                return ResourceManager.GetString("ResponseHeaderInspectionStoppedMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} Response Header Inspectors found..
        /// </summary>
        internal static string ResponseHeaderInspectorsFound {
            get {
                return ResourceManager.GetString("ResponseHeaderInspectorsFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Too many suspect results during Response inspection..
        /// </summary>
        internal static string ResponseInspectionStoppedMessage {
            get {
                return ResourceManager.GetString("ResponseInspectionStoppedMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} Response Inspectors found..
        /// </summary>
        internal static string ResponseInspectorsFound {
            get {
                return ResourceManager.GetString("ResponseInspectorsFound", resourceCulture);
            }
        }
    }
}
