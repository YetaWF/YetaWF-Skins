/* Copyright © 2017 Softel vdm, Inc. - https://yetawf.com/Documentation/YetaWF/Licensing */

using System.Reflection;
using System.Runtime.InteropServices;
using YetaWF.Core.Packages;
using YetaWF.PackageAttributes;

[assembly: AssemblyTitle("YetaWFSkin")]
[assembly: AssemblyDescription("YetaWF skin")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("Softel vdm, Inc.")]
[assembly: AssemblyProduct("YetaWFSkin")]
[assembly: AssemblyCopyright("Copyright © 2017 - Softel vdm, Inc.")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]
[assembly: ComVisible(false)]

[assembly: AssemblyVersion("2.0.2.0")]

[assembly: RequiresAddOnGlobal("getbootstrap.com", "bootstrap-less")]

[assembly: Package(PackageTypeEnum.Module, "YetaWF")]
[assembly: PackageInfo("https://softelvdm.com/UpdateServer",
    "https://softelvdm.com/Documentation/YetaWF/YetaWFSkin",
    "https://softelvdm.com/Documentation/YetaWF/Support",
    "https://softelvdm.com/Documentation/YetaWF/YetaWFSkin#Release%20Notice",
    "https://softelvdm.com/Documentation/YetaWF/YetaWFSkin#License")]
