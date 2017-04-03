/* Copyright © 2017 Softel vdm, Inc. - http://yetawf.com/Documentation/YetaWF/Licensing */

using System.Reflection;
using System.Runtime.InteropServices;
using YetaWF.Core.Packages;
using YetaWF.PackageAttributes;

[assembly: AssemblyTitle("BootstrapSample Skin")]
[assembly: AssemblyDescription("Bootstrap sample skin")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("YetaWF")]
[assembly: AssemblyProduct("BootstrapSample")]
[assembly: AssemblyCopyright("Copyright © 2017 - Softel vdm, Inc.")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]
[assembly: ComVisible(false)]

[assembly: AssemblyVersion("2.0.1.0")]

[assembly: RequiresAddOnGlobal("getbootstrap.com", "bootstrap-less")]

[assembly: Package(PackageTypeEnum.Skin, "YetaWF")]
[assembly: PackageInfo("http://YetaWF.com/UpdateServer",
    "http://yetawf.com/Documentation/YetaWF/BootstrapSample",
    "http://YetaWF.com/Documentation/YetaWF/Support",
    "http://yetawf.com/Documentation/YetaWF/BootstrapSample#Release%20Notice",
    "http://yetawf.com/Documentation/YetaWF/BootstrapSample#License")]
