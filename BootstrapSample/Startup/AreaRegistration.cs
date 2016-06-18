using YetaWF.Core.Packages;

namespace YetaWF.Modules.BootstrapSample.Controllers {
    public class AreaRegistration : YetaWF.Core.Controllers.AreaRegistration {
        public AreaRegistration() : base(out CurrentPackage) { }
        public static new Package CurrentPackage;
    }
}
