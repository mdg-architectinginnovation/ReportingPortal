using System.Web;
using System.Web.Optimization;

namespace Reporting.Web.Portal
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/bower_components/jquery/dist/jquery.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bower_components/bootstrap/dist/js/bootstrap.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/chartjs").Include(
                      "~/Scripts/bower_components/Chart.js/dist/Chart.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrapswitch").Include(
                      "~/Scripts/bower_components/bootstrap-switch/dist/js/bootstrap-switch.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/matchheight").Include(
                      "~/Scripts/bower_components/matchHeight/jquery.matchHeight-min.js"));

            bundles.Add(new ScriptBundle("~/bundles/datatables").Include(
                      "~/Scripts/bower_components/DataTables/media/js/jquery.dataTables.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/datatablesbootstrap").Include(
                      "~/Scripts/bower_components/DataTables/media/js/dataTables.bootstrap.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/select2").Include(
                      "~/Scripts/bower_components/select2/dist/js/select2.full.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/ace").Include(
                      "~/Scripts/bower_components/ace-builds/src/ace.js"));

            bundles.Add(new ScriptBundle("~/bundles/modehtml").Include(
                      "~/Scripts/bower_components/ace-builds/src/mode-html.js"));

            bundles.Add(new ScriptBundle("~/bundles/themegithub").Include(
                      "~/Scripts/bower_components/ace-builds/src/theme-github.js"));

            bundles.Add(new ScriptBundle("~/bundles/appjs").Include(
                      "~/Scripts/js/app.js"));

            bundles.Add(new ScriptBundle("~/bundles/indexjs").Include(
                      "~/Scripts/js/index.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Scripts/bower_components/bootstrap/dist/css/bootstrap.min.css"));

            //bower
            bundles.Add(new StyleBundle("~/Content/bowercss").Include(
          "~/Scripts/bower_components/font-awesome/css/font-awesome.min.css",
          "~/Scripts/bower_components/animate.css/animate.min.css",
          "~/Scripts/bower_components/bootstrap-switch/dist/css/bootstrap3/bootstrap-switch.min.css",
          "~/Scripts/bower_components/checkbox3/dist/checkbox3.min.css",
          "~/Scripts/bower_components/DataTables/media/css/jquery.dataTables.min.css",
          "~/Scripts/bower_components/datatables/media/css/dataTables.bootstrap.css",
          "~/Scripts/bower_components/select2/dist/css/select2.min.css"));

            //flat v.2
            bundles.Add(new StyleBundle("~/Content/v2css").Include(
                      "~/Content/css/style.css",
                      "~/Content/css/themes/flat-blue.css"));
        }
    }
}
