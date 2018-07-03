using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fees_proj.data_classes
{
    public class room_facility_data
    {
        public room_facility_data(



        String dormitory_name,
        String room_type,
         String facility_title,
        String facility_option)
        {


            this.facility_title = facility_title;
            this.dormitory_name = dormitory_name;
            this.room_type = room_type;
            this.facility_option = facility_option;
        }
        public String facility_title { get; set; }
        public String dormitory_name { get; set; }
        public String room_type { get; set; }
        public String facility_option { get; set; }
    }
}
