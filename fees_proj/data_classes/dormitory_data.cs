using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fees_proj.data_classes
{
    class dormitory_data
    {
        public dormitory_data(
                   String dormitory_type,

                   String room_price_currency,
                   String room_price_currency_symbol,
                   String dormitory_address,
                   String gender_allocation_EN,
                   String rooms_payment_period_EN,
                   String dormitory_name_EN,
                   String gender_allocation_TR,
                   String rooms_payment_period_TR,
                   String dormitory_name_TR)
        {

            this.dormitory_type = dormitory_type;

            this.room_price_currency = room_price_currency;
            this.room_price_currency_symbol = room_price_currency_symbol;
            this.dormitory_address = dormitory_address;
            this.gender_allocation_EN = gender_allocation_EN;
            this.rooms_payment_period_EN = rooms_payment_period_EN;
            this.dormitory_name_EN = dormitory_name_EN;
            this.gender_allocation_TR = gender_allocation_TR;
            this.rooms_payment_period_TR = rooms_payment_period_TR;
            this.dormitory_name_TR = dormitory_name_TR;
        }



        public String dormitory_type { get; set; }
        public String room_price_currency { get; set; }
        public String room_price_currency_symbol { get; set; }
        public String dormitory_address { get; set; }
        public String gender_allocation_EN { get; set; }
        public String rooms_payment_period_EN { get; set; }
        public String dormitory_name_EN { get; set; }

        public String gender_allocation_TR { get; set; }
        public String rooms_payment_period_TR { get; set; }
        public String dormitory_name_TR { get; set; }

    }
}
