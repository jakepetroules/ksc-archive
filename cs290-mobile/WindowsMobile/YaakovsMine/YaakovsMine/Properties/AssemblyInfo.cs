using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices;

// General Information about an assembly is controlled through the following
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("Yaakov's Mine")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("Petroules Enterprises")]
[assembly: AssemblyProduct("Yaakov's Mine")]
[assembly: AssemblyCopyright("Copyright © 2010 Petroules Enterprises")]
[assembly: AssemblyTrademark("All Rights Reserved")]
[assembly: AssemblyCulture("")]

// Setting ComVisible to false makes the types in this assembly not visible
// to COM components.  If you need to access a type in this assembly from
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("ada42806-c951-45d1-b2ae-03464e9db265")]

// Version information for an assembly consists of the following four values:
//      Major Version
//      Minor Version
//      Build Number
//      Revision
[assembly: AssemblyVersion("1.0.0.0")]

// Below attribute is to suppress FxCop warning "CA2232 : Microsoft.Usage : Add STAThreadAttribute to assembly"
// as Device app does not support STA thread.
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2232:MarkWindowsFormsEntryPointsWithStaThread")]
[assembly: NeutralResourcesLanguageAttribute("en-US")]
