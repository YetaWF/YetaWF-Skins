/* Copyright © 2019 Softel vdm, Inc. - https://yetawf.com/Documentation/YetaWF/Licensing */

using System.Reflection;
using System.Runtime.InteropServices;
using YetaWF.Core.Packages;
using YetaWF.PackageAttributes;

[assembly: AssemblyTitle("BootstrapSkin")]
[assembly: AssemblyDescription("BootstrapSkin for YetaWF")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("Softel vdm, Inc.")]
[assembly: AssemblyProduct("BootstrapSkin")]
[assembly: AssemblyCopyright("Copyright © 2019 - Softel vdm, Inc.")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]
[assembly: ComVisible(false)]

[assembly: AssemblyVersion("4.2.0.0")]

[assembly: Package(PackageTypeEnum.Skin, "YetaWF")]
[assembly: PackageInfo("https://YetaWF.com/UpdateServer",
    "https://yetawf.com/Documentation/YetaWF/BootstrapSkin",
    "https://yetawf.com/Documentation/YetaWF/BootstrapSkin/Support",
    "https://yetawf.com/Documentation/YetaWF/BootstrapSkin#Release%20Notice",
    "https://yetawf.com/Documentation/YetaWF/BootstrapSkin#License")]

[assembly: RequiresPackage("YetaWF.Menus")]
[assembly: RequiresPackage("YetaWF.PageEdit")]
[assembly: RequiresPackage("YetaWF.SiteProperties")]
[assembly: RequiresPackage("YetaWF.Text")]
[assembly: RequiresPackage("YetaWF.TinyLogin")]
[assembly: RequiresPackage("YetaWF.TinyLanguage")]
