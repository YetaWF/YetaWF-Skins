/* Copyright © 2020 Softel vdm, Inc. - https://yetawf.com/Documentation/YetaWF/Licensing */

using YetaWF.Core.Components;
using YetaWF.Core.Packages;

namespace YetaWF.Skins.DefaultSkin.Pages {

    /// <summary>
    /// Implements the Plain page.
    /// </summary>
    public class PlainPage : PlainPageBase {

        /// <summary>
        /// Returns the package implementing the page.
        /// </summary>
        /// <returns>Returns the package implementing the page.</returns>
        public override Package GetPackage() { return AreaRegistration.CurrentPackage; }
    }
}
