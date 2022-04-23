/* Copyright © 2022 Softel vdm, Inc. - https://yetawf.com/Documentation/YetaWF/Licensing */

using System.Threading.Tasks;
using YetaWF.Core.Addons;
using YetaWF.Core.Support;

namespace YetaWF.Skins.DefaultSkin.Addons {

    /// <summary>
    /// Implements the YetaWF.Core.Addons.IAddOnSupport interface, which is called when the framework detects the use of the YetaWF.DefaultSkin package.
    /// The AddSupportAsync method is called so package specific configuration options and localizations can be added to the page.
    /// </summary>
    public class Info : IAddOnSupport {
        /// <summary>
        /// Called by the framework so the package can add package specific client-side configuration options and localizations to the page.
        /// </summary>
        /// <param name="manager">The YetaWF.Core.Support.Manager instance of current HTTP request.</param>
        public Task AddSupportAsync(YetaWFManager manager) {
            return Task.CompletedTask;
        }
    }
}
