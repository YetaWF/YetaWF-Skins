/* Copyright © 2019 Softel vdm, Inc. - https://yetawf.com/Documentation/YetaWF/Licensing */

using System.Collections.Generic;
using System.Threading.Tasks;
using YetaWF.Core;
using YetaWF.Core.Components;
using YetaWF.Core.Modules;
using YetaWF.Core.Packages;
using YetaWF.Core.Support;
using YetaWF.Modules.DefaultSkin.Controllers;

namespace YetaWF.Skins.DefaultSkin.Pages {

    /// <summary>
    /// Implements the Plain page.
    /// </summary>
    public class PlainPage : YetaWFPageBase, IYetaWFPage {

        /// <summary>
        /// Returns the name of the page.
        /// </summary>
        /// <returns>Returns the name of the page.</returns>
        public override string GetPageName() { return "Plain"; }

        /// <summary>
        /// Returns the package implementing the page.
        /// </summary>
        /// <returns>Returns the package implementing the page.</returns>
        public override Package GetPackage() { return AreaRegistration.CurrentPackage; }

        /// <summary>
        /// Returns the names of all panes available in this page.
        /// </summary>
        /// <returns>Returns a collection of pane names available in this page.</returns>
        public List<string> GetPanes() {
            return new List<string> { Globals.MainPane };
        }

        /// <summary>
        /// Renders the page.
        /// </summary>
        /// <returns>The HTML representing the page.</returns>
        public async Task<YHtmlString> RenderPageAsync() {

            HtmlBuilder hb = new HtmlBuilder();

            string favIcon = Manager.CurrentPage.FavIconLink;
            if (string.IsNullOrEmpty(favIcon))
                favIcon = Manager.CurrentSite.FavIconLink;

            string copyright = Manager.CurrentPage.CopyrightEvaluated;
            if (string.IsNullOrEmpty(copyright))
                copyright = Manager.CurrentSite.CopyrightEvaluated;

            hb.Append($@"
<!DOCTYPE html>
<html lang='{Manager.CurrentPage.GetPageLanguageId()}'>
<head>
    <meta http-equiv='Content-Type' content='text/html; charset=UTF-8' />
    <meta http-equiv='X-UA-Compatible' content='IE=edge' />
    <meta name='viewport' content='width=device-width, initial-scale=1'>
    {Manager.MetatagsHtml}
    {Manager.PageTitleHtml}
    {favIcon}
    {Manager.CurrentPage.CanonicalUrlLink}
    {Manager.CurrentPage.HrefLangHtml}
</head>
<body class='{Manager.PageCss()}'>
    <noscript><div class='yDivWarning' style='height:100px;text-align:center;vertical-align:middle'>This site requires Javascript</div></noscript>
    {await HtmlHelper.RenderEditControlAsync<YetaWF.Modules.PageEdit.Modules.EditModeModule>()}
    {await HtmlHelper.RenderPageControlAsync<YetaWF.Modules.PageEdit.Modules.PageControlModule>()}
    <div class='MainPane'>
        {await RenderPaneAsync(Globals.MainPane, "MainPane AnyPane", Unified: true)}
    </div>
    <div class='pageFooter'>{HE(copyright)}</div>
    {await HtmlHelper.RenderUniqueModuleAddOnsAsync()}
</body>
</html>");

            return hb.ToYHtmlString();
        }
    }
}
