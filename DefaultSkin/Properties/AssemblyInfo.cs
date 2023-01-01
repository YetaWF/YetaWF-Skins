/* Copyright © 2023 Softel vdm, Inc. - https://yetawf.com/Documentation/YetaWF/Licensing */

using System.Reflection;
using System.Runtime.InteropServices;
using YetaWF.Core.Packages;
using YetaWF.PackageAttributes;

[assembly: AssemblyTitle("DefaultSkin")]
[assembly: AssemblyDescription("DefaultSkin for YetaWF")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("Softel vdm, Inc.")]
[assembly: AssemblyProduct("DefaultSkin")]
[assembly: AssemblyCopyright("Copyright © 2023 - Softel vdm, Inc.")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]
[assembly: ComVisible(false)]

[assembly: AssemblyVersion("5.5.0.0")]

[assembly: Package(PackageTypeEnum.Skin, "YetaWF")]
[assembly: PackageInfo("https://YetaWF.com/UpdateServer",
    "https://yetawf.com/Documentation/YetaWFDefaultSkin",
    "https://yetawf.com/Documentation/YetaWFDefaultSkin#Support",
    "https://yetawf.com/Documentation/YetaWFDefaultSkin#Release%20Notice",
    "https://yetawf.com/Documentation/YetaWFDefaultSkin#License")]

[assembly: RequiresPackage("YetaWF.Menus")]
[assembly: RequiresPackage("YetaWF.Text")]
[assembly: RequiresPackage("YetaWF.TinyLogin")]
[assembly: RequiresPackage("YetaWF.TinyLanguage")]
