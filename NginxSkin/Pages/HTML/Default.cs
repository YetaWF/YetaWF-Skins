﻿/* Copyright © 2019 Softel vdm, Inc. - https://yetawf.com/Documentation/YetaWF/Licensing */

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using YetaWF.Core;
using YetaWF.Core.Components;
using YetaWF.Core.Modules;
using YetaWF.Core.Packages;
using YetaWF.Core.Support;
using YetaWF.Skins.NginxSkin.Controllers;

namespace YetaWF.Skins.NginxSkin.Pages {

    /// <summary>
    /// Implements the Default page.
    /// </summary>
    public class DefaultPage : YetaWFPageBase, IYetaWFPage {

        /// <summary>
        /// Returns the name of the page.
        /// </summary>
        /// <returns>Returns the name of the page.</returns>
        public override string GetPageName() { return "Default"; }

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
            return new List<string> {
                "Header",
                Globals.MainPane,
                "PaneSetL2_LeftPane", "PaneSetL2_MainPane",
                "PaneSetL3_LeftPane", "PaneSetL3_MainPane", "PaneSetL3_RightPane",
                "PaneSetR2_MainPane", "PaneSetR2_RightPane",
                "Footer"
            };
        }

        /// <summary>
        /// Renders the page header (everything before &lt;body&gt;).
        /// </summary>
        /// <returns>The HTML representing the page header.</returns>
        public Task<string> RenderPageHeaderAsync() {

            HtmlBuilder hb = new HtmlBuilder();

            string favIcon = Manager.CurrentPage.FavIconLink;
            if (string.IsNullOrEmpty(favIcon))
                favIcon = Manager.CurrentSite.FavIconLink;

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
</head>");

            return Task.FromResult(hb.ToString());
        }

        /// <summary>
        /// Renders the page body (&lt;body&gt;, contents and &lt;/body&gt;).
        /// </summary>
        /// <returns>The HTML representing the page body.</returns>
        public async Task<string> RenderPageBodyAsync() {

            HtmlBuilder hb = new HtmlBuilder();

            string copyright = Manager.CurrentPage.CopyrightEvaluated;
            if (string.IsNullOrEmpty(copyright))
                copyright = Manager.CurrentSite.CopyrightEvaluated;

            hb.Append($@"
<body class='{Manager.PageCss()}'>
    <noscript><div class='yDivWarning' style='height:100px;text-align:center;vertical-align:middle'>This site requires Javascript</div></noscript>

    {await HtmlHelper.RenderUniqueModuleAsync<YetaWF.Modules.SiteProperties.Modules.LockedStatusModule>(m => {
        m.CssClass = "skinLockedStatus d-print-none";
    })}

    <!-- Main Menu Navbar -->
    <nav class='navbar navbar-expand-lg navbar-dark bg-dark d-print-none mt-3 mt-lg-0'>
        <a class='navbar-brand' href='#'>
            <img src='http://www.statuspie.com/VaultPrivate/Portainer/softel_dc1.png'>
        </a>
        <button type='button' class='navbar-toggler' data-toggle='collapse' data-target='.yPageMenu'>
            <span class='navbar-toggler-icon'></span>
        </button>
        {await HtmlHelper.RenderUniqueModuleAsync<YetaWF.Modules.Menus.Modules.MainMenuModule>(m => {
            m.Name = "Main Menu Module (Skin)";
        })}
        <div class='justify-content-end'>
            {await HtmlHelper.RenderUniqueModuleAsync<YetaWF.Modules.TinyLogin.Modules.TinyLoginModule>(m => {
                m.CssClass = "skinTinyLogin";
            })}
        </div>
    </nav>

    <!-- Jumbotron -->
    <div class='jumbotron'>
        <div class='container'>
            <div class='row'>
                {await RenderPaneAsync("Header", "col-lg-12 HeaderPane AnyPane", Unified: true)}
            </div>
        </div>
    </div>

    <!-- Panes -->
    <div class='container maincontainer'>
        <div class='row'>
            {await RenderPaneAsync("", "col-lg-12 MainPane AnyPane", Unified: true)}
        </div>
        <div class='row'>
            {await RenderPaneAsync("PaneSetL2_LeftPane", "col-lg-4 PaneSetL2_LeftPane AnyPane", Unified: true)}
            {await RenderPaneAsync("PaneSetL2_MainPane", "col-lg-8 PaneSetL2_MainPane AnyPane", Unified: true)}
        </div>
        <div class='row'>
            {await RenderPaneAsync("PaneSet3_LeftPane", "col-lg-3 PaneSet3_LeftPane AnyPane", Unified: true)}
            {await RenderPaneAsync("PaneSet3_MainPane", "col-lg-6 PaneSet3_MainPane AnyPane", Unified: true)}
            {await RenderPaneAsync("PaneSet3_RightPane", "col-lg-3 PaneSet3_RightPane AnyPane", Unified: true)}
        </div>
        <div class='row'>
            {await RenderPaneAsync("PaneSetR2_MainPane", "col-lg-8 PaneSetR2_MainPane AnyPane", Unified: true)}
            {await RenderPaneAsync("PaneSetR2_RightPane", "col-lg-4 PaneSetR2_RightPane AnyPane", Unified: true)}
        </div>
    </div>

    <div class='PaneSetFooter'>
        <div class='container'>
            <div class='row col-lg-12'>
                {await RenderPaneAsync("Footer", "FooterPane AnyPane", Unified: true)}
            </div>
        </div>
    </div>

    <footer>
        <p>{HE(copyright)}</p>
    </footer>

    {await HtmlHelper.RenderEditControlAsync<YetaWF.Modules.PageEdit.Modules.EditModeModule>()}
    {await HtmlHelper.RenderPageControlAsync<YetaWF.Modules.PageEdit.Modules.PageControlModule>()}

    {await HtmlHelper.RenderUniqueModuleAddOnsAsync()}
</body>");

            return hb.ToString();
        }

        /// <summary>
        /// Called by the framework for additional processing to be performed.
        /// </summary>
        /// <remarks>A possible use for this method is to add fonts to a page.</remarks>
        public Task AdditionalProcessingAsync() { return Task.CompletedTask; }
    }
}
