/* Copyright � 2019 Softel vdm, Inc. - https://yetawf.com/Documentation/YetaWF/Licensing */

using YetaWF.Core.Packages;

namespace YetaWF.Skins.DefaultSkin.Controllers {
    /// <summary>
    /// MVC area registration class.
    /// </summary>
    /// <remarks>
    /// An instance of this class is instantiated and initialized during application startup in order to define the MVC area used by this package.
    /// Each package defines its own MVC area. The name is derived from
    /// the YetaWF.PackageAttributes.PackageAttribute (for the domain portion) and the <see cref="System.Reflection.AssemblyProductAttribute"/> (for the product name),
    /// defined in the package's AssemblyInfo.cs source file.
    ///
    /// The area name is the concatenation of the domain, followed by an underscore and the product name (e.g., YetaWF_Text).
    ///
    /// Applications can reference the current package using the static CurrentPackage property.
    ///
    /// Applications do not instantiate this class.
    /// </remarks>
    public class AreaRegistration : YetaWF.Core.Controllers.AreaRegistrationBase {
        /// <summary>
        /// Constructor.
        /// </summary>
        public AreaRegistration() : base() { CurrentPackage = this.GetCurrentPackage(); }
        /// <summary>
        /// Defines the current package, used by applications that need access to the YetaWF.Core.Packages.Package instance.
        /// </summary>
        public static Package CurrentPackage;
    }
}
