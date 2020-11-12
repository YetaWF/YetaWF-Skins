/* Copyright © 2020 Softel vdm, Inc. - https://yetawf.com/Documentation/YetaWF/Licensing */

using System.Reflection;
using System.Runtime.InteropServices;
using YetaWF.Core.Packages;
using YetaWF.PackageAttributes;

[assembly: AssemblyTitle("BootstrapSkin")]
[assembly: AssemblyDescription("BootstrapSkin for YetaWF")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("Softel vdm, Inc.")]
[assembly: AssemblyProduct("BootstrapSkin")]
[assembly: AssemblyCopyright("Copyright © 2020 - Softel vdm, Inc.")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]
[assembly: ComVisible(false)]

[assembly: AssemblyVersion("5.3.0.0")]

[assembly: Package(PackageTypeEnum.Skin, "YetaWF")]
[assembly: PackageInfo("https://YetaWF.com/UpdateServer",
    "https://yetawf.com/Documentation/YetaWFBootstrapSkin",
    "https://yetawf.com/Documentation/YetaWFBootstrapSkin#Support",
    "https://yetawf.com/Documentation/YetaWFBootstrapSkin#Release%20Notice",
    "https://yetawf.com/Documentation/YetaWFBootstrapSkin#License")]

[assembly: RequiresPackage("YetaWF.Menus")]
[assembly: RequiresPackage("YetaWF.Text")]
[assembly: RequiresPackage("YetaWF.TinyLogin")]
[assembly: RequiresPackage("YetaWF.TinyLanguage")]
