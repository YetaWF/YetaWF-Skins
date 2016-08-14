/* Copyright © 2016 Softel vdm, Inc. - http://yetawf.com/Documentation/YetaWF/Licensing */

using System.Reflection;
using System.Runtime.InteropServices;
using YetaWF.Core.Packages;
using YetaWF.PackageAttributes;

[assembly: AssemblyTitle("YetaWFSkin")]
[assembly: AssemblyDescription("YetaWFSkin description")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("Softel vdm, Inc.")]
[assembly: AssemblyProduct("YetaWFSkin")]
[assembly: AssemblyCopyright("Copyright © 2016 - Softel vdm, Inc.")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]
[assembly: ComVisible(false)]

[assembly: AssemblyVersion("1.0.4.0")]

[assembly: RequiresAddOnGlobal("getbootstrap.com", "bootstrap-less")]

[assembly: Package(PackageTypeEnum.Module, "YetaWF")]
[assembly: PackageInfo("http://softelvdm.com/UpdateServer",
    "http://softelvdm.com/Documentation/YetaWF/YetaWFSkin",
    "http://softelvdm.com/Documentation/YetaWF/Support",
    "http://softelvdm.com/Documentation/YetaWF/YetaWFSkin#Release%20Notice",
    "http://softelvdm.com/Documentation/YetaWF/YetaWFSkin#License")]
