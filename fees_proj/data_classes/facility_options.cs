using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fees_proj.data_classes
{
    public class facility_options
    {
        public facility_options(String facility_option_EN, String facility_option_TR)
        {
            this.facility_option_EN = facility_option_EN;
            this.facility_option_TR = facility_option_TR;

        }
        public String facility_option_EN { get; set; }
        public String facility_option_TR { get; set; }
    }
}
