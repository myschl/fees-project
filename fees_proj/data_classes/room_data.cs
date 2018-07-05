using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fees_proj.data_classes
{
    public class room_data
    {
        public room_data(
             String room_picture_url,

        String dormitory_name,

        float room_price,
        float room_price_installment,
        int room_area,
        String room_type_EN,
        String room_type_TR,
         String room_title_EN,
        String room_title_TR,
        int num_rooms_left
            )
        {
            this.dormitory_name = dormitory_name;
            this.room_picture_url =room_picture_url;
            this.room_price = room_price;
            this.room_price_installment = room_price_installment;
            this.room_area = room_area;
            this.room_type_EN = room_type_EN;
            this.room_type_TR = room_type_TR;
            this.room_title_EN = room_title_EN;
            this.room_title_TR = room_title_TR;
            this.num_rooms_left = num_rooms_left;
        }

        public String dormitory_name { get; set; }
        public String room_picture_url { get; set; }
        public float room_price { get; set; }
        public float room_price_installment { get; set; }
        public int room_area { get; set; }
        public String room_type_EN { get; set; }
        public String room_type_TR { get; set; }
        public String room_title_EN { get; set; }
        public String room_title_TR { get; set; }
        public int num_rooms_left { get; set; }
    }
}
