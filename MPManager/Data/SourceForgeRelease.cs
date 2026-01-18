using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
using System.Windows.Markup;

namespace SessionManagement.Data
{
    internal class SourceForgeRelease
    {
        //
        //  Vytas Gadliauskas using to deseralize from json
        // https://sourceforge.net/projects/multi-putty-manager-secure/best_release.json
        //

        public int    bytes { get; set; }
        public string date { get; set; }
        public string date_modified { get; set; }
        public string file_type { get; set; }
        public string filename { get; set; }
        public string md5sum { get; set; }
        public string mime_type { get; set; }
        public string release_notes_url { get; set; }
        public string sf_download_label { get; set; }
        public int sf_file_id { get; set; }
        public string sf_package_id { get; set; }
        public string[] sf_platform { get; set; }
        public string[] sf_platform_default { get; set; }
        public string sf_release_id { get; set; }
        public string sf_release_notes_file { get; set; }
        public string sf_type { get; set; }
        public string staged_until { get; set; }
        public string url { get; set; }
        public string vscan { get; set; }
        public string vscan_when { get; set; }

    }
}
