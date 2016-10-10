/* Copyright © 2016 Softel vdm, Inc. - http://yetawf.com/Documentation/YetaWF/Licensing */

using System.Reflection;
using System.Runtime.InteropServices;
using YetaWF.Core.Packages;
using YetaWF.PackageAttributes;

[assembly: AssemblyTitle("BusinessCasualSkin")]
[assembly: AssemblyDescription("BusinessCasual skin as seen on https://startbootstrap.com/template-categories/all/")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("Softel vdm, Inc.")]
[assembly: AssemblyProduct("BusinessCasualSkin")]
[assembly: AssemblyCopyright("Copyright © 2016 - Softel vdm, Inc.")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]
[assembly: ComVisible(false)]

[assembly: AssemblyVersion("1.0.8.0")]

[assembly: RequiresAddOnGlobal("getbootstrap.com", "bootstrap-less")]

[assembly: Package(PackageTypeEnum.Skin, "YetaWF")]
[assembly: PackageInfo("http://YetaWF.com/UpdateServer",
    "http://yetawf.com/Documentation/YetaWF/BusinessCasualSkin",
    "http://yetawf.com/Documentation/YetaWF/BusinessCasualSkin/Support",
    "http://yetawf.com/Documentation/YetaWF/BusinessCasualSkin#Release%20Notice",
    "http://yetawf.com/Documentation/YetaWF/BusinessCasualSkin#License")]
