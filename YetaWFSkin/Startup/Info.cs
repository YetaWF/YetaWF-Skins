/* Copyright © 2016 Softel vdm, Inc. - http://yetawf.com/Documentation/YetaWF/Licensing */

using YetaWF.Core.Addons;
using YetaWF.Core.Localize;
using YetaWF.Core.Packages;
using YetaWF.Core.Pages;
using YetaWF.Core.Support;
using YetaWF.Modules.YetaWFSkin.Controllers;

namespace YetaWF.Modules.YetaWFSkin.Addons {

    public class Info : IAddOnSupport {

        public void AddSupport(YetaWFManager manager) {

            //ScriptManager scripts = manager.ScriptManager;
            //string areaName = AreaRegistration.CurrentPackage.AreaName;

            //scripts.AddConfigOption(areaName, "something", Something);

            //scripts.AddLocalization(areaName, "something", this.__ResStr("something", "something"));
        }
    }
}