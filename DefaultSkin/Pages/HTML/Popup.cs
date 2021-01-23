/* Copyright © 2021 Softel vdm, Inc. - https://yetawf.com/Documentation/YetaWF/Licensing */

using YetaWF.Core.Components;
using YetaWF.Core.Packages;
using YetaWF.Core.Skins;

namespace YetaWF.Skins.DefaultSkin.Pages {

    /// <summary>
    /// Implements the Popup page.
    /// </summary>
    public class PopupPage : PopupPageBase {
        /// <summary>
        /// Returns the package implementing the page.
        /// </summary>
        /// <returns>Returns the package implementing the page.</returns>
        public override Package GetPackage() { return AreaRegistration.CurrentPackage; }
        /// <summary>
        /// Returns the name of the page.
        /// </summary>
        /// <returns>Returns the name of the page.</returns>
        public override string GetPageName() { return SkinAccess.POPUP_VIEW_DEFAULT; }
    }
    /// <summary>
    /// Implements the PopupSmall page.
    /// </summary>
    public class PopupSmallPage : PopupPageBase {
        /// <summary>
        /// Returns the package implementing the page.
        /// </summary>
        /// <returns>Returns the package implementing the page.</returns>
        public override Package GetPackage() { return AreaRegistration.CurrentPackage; }
        /// <summary>
        /// Returns the name of the page.
        /// </summary>
        /// <returns>Returns the name of the page.</returns>
        public override string GetPageName() { return SkinAccess.POPUP_VIEW_SMALL; }
    }
    /// <summary>
    /// Implements the PopupMedium page.
    /// </summary>
    public class PopupMediumPage : PopupPageBase {
        /// <summary>
        /// Returns the package implementing the page.
        /// </summary>
        /// <returns>Returns the package implementing the page.</returns>
        public override Package GetPackage() { return AreaRegistration.CurrentPackage; }
        /// <summary>
        /// Returns the name of the page.
        /// </summary>
        /// <returns>Returns the name of the page.</returns>
        public override string GetPageName() { return SkinAccess.POPUP_VIEW_MEDIUM; }
    }
}
