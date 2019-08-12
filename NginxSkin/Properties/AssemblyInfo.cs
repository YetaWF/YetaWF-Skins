/* Copyright © 2019 Softel vdm, Inc. - https://yetawf.com/Documentation/YetaWF/Licensing */

using System.Reflection;
using System.Runtime.InteropServices;
using YetaWF.Core.Packages;
using YetaWF.PackageAttributes;

[assembly: AssemblyTitle("NginxSkin")]
[assembly: AssemblyDescription("NginxSkin for YetaWF")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("Softel vdm, Inc.")]
[assembly: AssemblyProduct("NginxSkin")]
[assembly: AssemblyCopyright("Copyright © 2019 - Softel vdm, Inc.")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]
[assembly: ComVisible(false)]

[assembly: AssemblyVersion("5.0.0.0")]

[assembly: Package(PackageTypeEnum.Skin, "YetaWF")]
[assembly: PackageInfo("https://YetaWF.com/UpdateServer",
    "https://yetawf.com/Documentation/YetaWF/NginxSkin",
    "https://yetawf.com/Documentation/YetaWF/NginxSkin/Support",
    "https://yetawf.com/Documentation/YetaWF/NginxSkin#Release%20Notice",
    "https://yetawf.com/Documentation/YetaWF/NginxSkin#License")]

[assembly: RequiresPackage("YetaWF.Menus")]
[assembly: RequiresPackage("YetaWF.PageEdit")]
[assembly: RequiresPackage("YetaWF.SiteProperties")]
[assembly: RequiresPackage("YetaWF.Text")]
[assembly: RequiresPackage("YetaWF.TinyLogin")]
[assembly: RequiresPackage("YetaWF.TinyLanguage")]

[assembly: RequiresPackage("Softelvdm.NginxControl")] // logo from config
