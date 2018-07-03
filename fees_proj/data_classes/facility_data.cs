using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fees_proj.data_classes
{
    class facility_data
    {

        public facility_data(
        String facility_icon_url,
        String facility_title_en,
        String facility_title_tr,
        ArrayList facility_options_list
       )
        {
            this.facility_icon_url = facility_icon_url;
            this.facility_title_en = facility_title_en;
            this.facility_title_tr = facility_title_tr;
            this.facility_options_list = facility_options_list;


        }

        public String facility_icon_url { get; set; }
        public String facility_title_en { get; set; }
        public String facility_title_tr { get; set; }
        public ArrayList facility_options_list { get; set; }


    }
}
