using fees_proj.data_classes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fees_proj
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello World");
            languageInitiate();
            dormitories_types_initiate();
            dormitories_initiate();
            facilities_and_options_data();
            rooms_initiate();
            room_facility_combo_initiate();
            dormitory_bank_account_details_initiate();
            // printFunction();

            Console.WriteLine("Done processing, Adding changes");
            Console.Read();
        }

        
        static void dormitory_bank_account_details_initiate()
        {
            using (fees_and_facilitiesEntities4 context = new fees_and_facilitiesEntities4())
            {
                ArrayList dormitory_bank_det = new ArrayList();


                dormitory_bank_det.Add(new dormitory_bank_details_data
                {
                    dormitory_name = "Alfam",
                    bank_name = "İş Bankası (Gazimağusa  Branch | Şubesi)",
                    bank_currency = "USD",
                    account_parameter_en = "Account No",
                    account_parameter_TR = "Hesap No",
                    account_parameter_value_en = "6820-57259",
                    account_parameter_value_tr = "6820-57259"
                });
                dormitory_bank_det.Add(new dormitory_bank_details_data
                {
                    dormitory_name = "Alfam",
                    bank_name = "İş Bankası (Gazimağusa Şubesi)",
                    bank_currency = "USD",
                    account_parameter_en = "IBAN",
                    account_parameter_TR = "IBAN",
                    account_parameter_value_en = "TR04 0006 4000 0026 8200 057259",
                    account_parameter_value_tr = "TR04 0006 4000 0026 8200 057259"
                });
                dormitory_bank_det.Add(new dormitory_bank_details_data
                {
                    dormitory_name = "Uğursal",
                    bank_name = "Garanti Bankası (Gazimağusa  Branch | Şubesi)",
                    bank_currency = "USD",
                    account_parameter_en = "IBAN",
                    account_parameter_TR = "IBAN",
                    account_parameter_value_en = " TR62 0006 2001 2890 0009 0899 17",
                    account_parameter_value_tr = " TR62 0006 2001 2890 0009 0899 17"
                });
                dormitory_bank_det.Add(new dormitory_bank_details_data
                {
                    dormitory_name = "Akdeniz",
                    bank_name = "İş Bankası (Gazimağusa  Branch | Şubesi)",
                    bank_currency = "USD",
                    account_parameter_en = "Swift Code",
                    account_parameter_TR = "IBAN",
                    account_parameter_value_en = "TGBATRIS",
                    account_parameter_value_tr = "TR 16 0006 4000 002 6820 0694818"
                });
                dormitory_bank_det.Add(new dormitory_bank_details_data
                {
                    dormitory_name = "Akdeniz",
                    bank_name = "Halk Bankası (Gazimağusa  Branch | Şubesi)",
                    bank_currency = "USD",
                    account_parameter_en = "IBAN",
                    account_parameter_TR = "IBAN",
                    account_parameter_value_en = "TR 16 0006 4000 002 6820 0694818",
                    account_parameter_value_tr = "TR 43 0001 2009 8990 0053 000003"
                });
                dormitory_bank_det.Add(new dormitory_bank_details_data
                {
                    dormitory_name = "Longson",
                    bank_name = "Garanti Bankası",
                    bank_currency = "USD",
                    account_parameter_en = "IBAN",
                    account_parameter_TR = "Hesap No",
                    account_parameter_value_en = "TR 43 0001 2009 8990 0053 000003",
                    account_parameter_value_tr = "493-9098092"
                });
                dormitory_bank_det.Add(new dormitory_bank_details_data
                {
                    dormitory_name = "Longson",
                    bank_name = "Garanti Bankası",
                    bank_currency = "USD",
                    account_parameter_en = "Account No",
                    account_parameter_TR = "IBAN",
                    account_parameter_value_en = "493-9098092",
                    account_parameter_value_tr = "TR 93 0006 2000 4930 0009 098092"
                });
                dormitory_bank_det.Add(new dormitory_bank_details_data
                {
                    dormitory_name = "Marmara",
                    bank_name = "İş Bankası (Gazimağusa  Branch | Şubesi)",
                    bank_currency = "USD",
                    account_parameter_en = "IBAN",
                    account_parameter_TR = "IBAN",
                    account_parameter_value_en = "TR 93 0006 2000 4930 0009 098092",
                    account_parameter_value_tr = " TR 04 0006 4000 0026 8210 118778"
                });
                dormitory_bank_det.Add(new dormitory_bank_details_data
                {
                    dormitory_name = "Marmara",
                    bank_name = "Garanti Bankası (Gazimağusa  Branch | Şubesi)",
                    bank_currency = "USD",
                    account_parameter_en = "IBAN",
                    account_parameter_TR = "IBAN",
                    account_parameter_value_en = " TR 04 0006 4000 0026 8210 118778",
                    account_parameter_value_tr = " TR 78 0006 2001 2890 0009 095934"
                });
                dormitory_bank_det.Add(new dormitory_bank_details_data
                {
                    dormitory_name = "Marmara",
                    bank_name = "Ziraat Bankası (Gazimağusa  Branch | Şubesi)",
                    bank_currency = "USD",
                    account_parameter_en = "IBAN",
                    account_parameter_TR = "IBAN",
                    account_parameter_value_en = " TR 78 0006 2001 2890 0009 095934",
                    account_parameter_value_tr = " TR 19 0001 0008 6164 5171 675002"
                });
                dormitory_bank_det.Add(new dormitory_bank_details_data
                {
                    dormitory_name = "Homedorm",
                    bank_name = "Is Bank",
                    bank_currency = "USD",
                    account_parameter_en = "IBAN",
                    account_parameter_TR = "Hesap No ",
                    account_parameter_value_en = " TR 19 0001 0008 6164 5171 675002",
                    account_parameter_value_tr = "6820-0950229"
                });
                dormitory_bank_det.Add(new dormitory_bank_details_data
                {
                    dormitory_name = "Homedorm",
                    bank_name = "Is Bank",
                    bank_currency = "USD",
                    account_parameter_en = "Account No ",
                    account_parameter_TR = "IBAN",
                    account_parameter_value_en = "6820-0950229",
                    account_parameter_value_tr = "TR37 0006 4000 0026 8200 9502 29"
                });
                dormitory_bank_det.Add(new dormitory_bank_details_data
                {
                    dormitory_name = "Ramen",
                    bank_name = "İş Bankası",
                    bank_currency = "USD",
                    account_parameter_en = "IBAN",
                    account_parameter_TR = "Hesap No",
                    account_parameter_value_en = "TR37 0006 4000 0026 8200 9502 29",
                    account_parameter_value_tr = "6820-0948822"
                });
                dormitory_bank_det.Add(new dormitory_bank_details_data
                {
                    dormitory_name = "Ramen",
                    bank_name = "İş Bankası",
                    bank_currency = "USD",
                    account_parameter_en = "Account No",
                    account_parameter_TR = "IBAN",
                    account_parameter_value_en = "6820-0948822",
                    account_parameter_value_tr = "TR02 0006 4000 0026 8200 9488 22"
                });
                dormitory_bank_det.Add(new dormitory_bank_details_data
                {
                    dormitory_name = "Ramen",
                    bank_name = "Garanti Bankası",
                    bank_currency = "USD",
                    account_parameter_en = "IBAN",
                    account_parameter_TR = "Hesap No",
                    account_parameter_value_en = "TR02 0006 4000 0026 8200 9488 22",
                    account_parameter_value_tr = "1289/9098709"
                });
                dormitory_bank_det.Add(new dormitory_bank_details_data
                {
                    dormitory_name = "Ramen",
                    bank_name = "Garanti Bankası",
                    bank_currency = "USD",
                    account_parameter_en = "Account No",
                    account_parameter_TR = "IBAN",
                    account_parameter_value_en = "1289/9098709",
                    account_parameter_value_tr = "TR37 0006 2001 2890 0009 0987 09"
                });
                dormitory_bank_det.Add(new dormitory_bank_details_data
                {
                    dormitory_name = "Prime Living",
                    bank_name = "İş Bankası",
                    bank_currency = "USD",
                    account_parameter_en = "IBAN",
                    account_parameter_TR = "IBAN",
                    account_parameter_value_en = "TR37 0006 2001 2890 0009 0987 09",
                    account_parameter_value_tr = "TR53 0006 4000 0026 8040 0635 10"
                });
                dormitory_bank_det.Add(new dormitory_bank_details_data
                {
                    dormitory_name = "Prime Living",
                    bank_name = "İş Bankası",
                    bank_currency = "USD",
                    account_parameter_en = "IBAN",
                    account_parameter_TR = "Account No",
                    account_parameter_value_en = "TR53 0006 4000 0026 8040 0635 10",
                    account_parameter_value_tr = "0063510"
                });
                dormitory_bank_det.Add(new dormitory_bank_details_data
                {
                    dormitory_name = "Prime Living",
                    bank_name = "İş Bankası",
                    bank_currency = "USD",
                    account_parameter_en = "Account No",
                    account_parameter_TR = "Branch Code",
                    account_parameter_value_en = "0063510",
                    account_parameter_value_tr = "6804"
                });





                //dormitory_bank_det.Add(new dormitory_bank_details_data
                //{
                //    dormitory_name = "EMU 1",
                //    bank_name = "İs Bankasi(Magusa  Branch | Şubesi)",
                //    bank_currency = "USD",
                //    account_parameter_en = "Branch Code",
                //    account_parameter_TR = "Şube Kodu",
                //    account_parameter_value_en = "6804",
                //    account_parameter_value_tr = "6804"
                //});


                       dormitory_bank_det.Add(new dormitory_bank_details_data
                {
                    dormitory_name = "EMU 1",
                    bank_name = "İs Bankasi(Magusa  Branch | Şubesi)",
                    bank_currency = "USD",
                    account_parameter_en = "IBAN",
                    account_parameter_TR = "IBAN",
                    account_parameter_value_en = "TR 16 0006 4000 002  6820 0760487 ",
                    account_parameter_value_tr = "TR 16 0006 4000 002  6820 0760487 "
                });




                //dormitory_bank_det.Add(new dormitory_bank_details_data
                //{
                //    dormitory_name = "EMU 2",
                //    bank_name = "İs Bankasi(Magusa  Branch | Şubesi)",
                //    bank_currency = "USD",
                //    account_parameter_en = "Branch Code",
                //    account_parameter_TR = "Şube Kodu",
                //    account_parameter_value_en = "6804",
                //    account_parameter_value_tr = "6804"
                //});

                dormitory_bank_det.Add(new dormitory_bank_details_data
                {
                    dormitory_name = "EMU 2",
                    bank_name = "İs Bankasi(Magusa  Branch | Şubesi)",
                    bank_currency = "USD",
                    account_parameter_en = "IBAN",
                    account_parameter_TR = "IBAN",
                    account_parameter_value_en = "TR 16 0006 4000 002  6820 0760487 ",
                    account_parameter_value_tr = "TR 16 0006 4000 002  6820 0760487 "
                });


                //dormitory_bank_det.Add(new dormitory_bank_details_data
                //{
                //    dormitory_name = "EMU 3",
                //    bank_name = "İs Bankasi(Magusa  Branch | Şubesi)",
                //    bank_currency = "USD",
                //    account_parameter_en = "Branch Code",
                //    account_parameter_TR = "Şube Kodu",
                //    account_parameter_value_en = "6804",
                //    account_parameter_value_tr = "6804"
                //});

                dormitory_bank_det.Add(new dormitory_bank_details_data
                {
                    dormitory_name = "EMU 3",
                    bank_name = "İs Bankasi(Magusa  Branch | Şubesi)",
                    bank_currency = "USD",
                    account_parameter_en = "IBAN",
                    account_parameter_TR = "IBAN",
                    account_parameter_value_en = "TR 16 0006 4000 002  6820 0760487 ",
                    account_parameter_value_tr = "TR 16 0006 4000 002  6820 0760487 "
                });


                //dormitory_bank_det.Add(new dormitory_bank_details_data
                //{
                //    dormitory_name = "EMU 4",
                //    bank_name = "İs Bankasi(Magusa  Branch | Şubesi)",
                //    bank_currency = "USD",
                //    account_parameter_en = "Branch Code",
                //    account_parameter_TR = "Şube Kodu",
                //    account_parameter_value_en = "6804",
                //    account_parameter_value_tr = "6804"
                //});


                  dormitory_bank_det.Add(new dormitory_bank_details_data
                {
                    dormitory_name = "EMU 4",
                    bank_name = "İs Bankasi(Magusa  Branch | Şubesi)",
                    bank_currency = "USD",
                    account_parameter_en = "IBAN",
                    account_parameter_TR = "IBAN",
                    account_parameter_value_en = "TR 16 0006 4000 002  6820 0760487 ",
                    account_parameter_value_tr = "TR 16 0006 4000 002  6820 0760487 "
                });



                //dormitory_bank_det.Add(new dormitory_bank_details_data
                //{
                //    dormitory_name = "EMU Sabanci ",
                //    bank_name = "İs Bankasi(Magusa  Branch | Şubesi)",
                //    bank_currency = "USD",
                //    account_parameter_en = "Branch Code",
                //    account_parameter_TR = "Şube Kodu",
                //    account_parameter_value_en = "6804",
                //    account_parameter_value_tr = "6804"
                //});
                
                dormitory_bank_det.Add(new dormitory_bank_details_data
                {
                    dormitory_name = "EMU Sabanci ",
                    bank_name = "İs Bankasi(Magusa  Branch | Şubesi)",
                    bank_currency = "USD",
                    account_parameter_en = "IBAN",
                    account_parameter_TR = "IBAN",
                    account_parameter_value_en = "TR 16 0006 4000 002  6820 0760487 ",
                    account_parameter_value_tr = "TR 16 0006 4000 002  6820 0760487 "
                });





                dormitory_bank_det.Add(new dormitory_bank_details_data
                {
                    dormitory_name = "Alfam",
                    bank_name = "İş Bankası (Gazimağusa Branch | Şubesi)",
                    bank_currency = "TL",
                    account_parameter_en = "Account No",
                    account_parameter_TR = "Hesap No",
                    account_parameter_value_en = "6820-174392",
                    account_parameter_value_tr = "6820-174392"
                });
                dormitory_bank_det.Add(new dormitory_bank_details_data
                {
                    dormitory_name = "Alfam",
                    bank_name = "İş Bankası (Gazimağusa  Branch | Şubesi)",
                    bank_currency = "TL",
                    account_parameter_en = "IBAN",
                    account_parameter_TR = "IBAN",
                    account_parameter_value_en = "TR39 0006 4000 0016 8200 174392",
                    account_parameter_value_tr = "TR39 0006 4000 0016 8200 174392"
                });
                dormitory_bank_det.Add(new dormitory_bank_details_data
                {
                    dormitory_name = "Uğursal",
                    bank_name = "Garanti Bankası (Gazimağusa  Branch | Şubesi)",
                    bank_currency = "TL",
                    account_parameter_en = "IBAN",
                    account_parameter_TR = "IBAN",
                    account_parameter_value_en = "TR81 0006 2001 2890 0006 2984 00",
                    account_parameter_value_tr = "TR81 0006 2001 2890 0006 2984 00"
                });
                dormitory_bank_det.Add(new dormitory_bank_details_data
                {
                    dormitory_name = "Marmara",
                    bank_name = "İş Bankası (Gazimağusa  Branch | Şubesi)",
                    bank_currency = "TL",
                    account_parameter_en = "IBAN",
                    account_parameter_TR = "IBAN",
                    account_parameter_value_en = " TR 69 0006 4000 0016 8210 072023",
                    account_parameter_value_tr = " TR 69 0006 4000 0016 8210 072023"
                });
                dormitory_bank_det.Add(new dormitory_bank_details_data
                {
                    dormitory_name = "Marmara",
                    bank_name = "Garanti Bankası (Gazimağusa  Branch | Şubesi)",
                    bank_currency = "TL",
                    account_parameter_en = "IBAN",
                    account_parameter_TR = "IBAN",
                    account_parameter_value_en = " TR 56 0006 2001 2890 0006 299238",
                    account_parameter_value_tr = " TR 56 0006 2001 2890 0006 299238"
                });
                dormitory_bank_det.Add(new dormitory_bank_details_data
                {
                    dormitory_name = "Marmara",
                    bank_name = "Ziraat Bankası (Gazimağusa  Branch | Şubesi)",
                    bank_currency = "TL",
                    account_parameter_en = "IBAN",
                    account_parameter_TR = "IBAN",
                    account_parameter_value_en = " TR 46 0001 0008 6164 5171 675001",
                    account_parameter_value_tr = " TR 46 0001 0008 6164 5171 675001"
                });
                dormitory_bank_det.Add(new dormitory_bank_details_data
                {
                    dormitory_name = "Homedorm",
                    bank_name = "Is Bank",
                    bank_currency = "TL",
                    account_parameter_en = "Account No ",
                    account_parameter_TR = "Hesap No ",
                    account_parameter_value_en = "6820-0950229",
                    account_parameter_value_tr = "6820-0950229"
                });
                dormitory_bank_det.Add(new dormitory_bank_details_data
                {
                    dormitory_name = "Homedorm",
                    bank_name = "Is Bank",
                    bank_currency = "TL",
                    account_parameter_en = "IBAN",
                    account_parameter_TR = "IBAN",
                    account_parameter_value_en = "TR37 0006 4000 0026 8200 9502 29",
                    account_parameter_value_tr = "TR37 0006 4000 0026 8200 9502 29"
                });
                dormitory_bank_det.Add(new dormitory_bank_details_data
                {
                    dormitory_name = "Prime Living",
                    bank_name = "İş Bankası",
                    bank_currency = "TL",
                    account_parameter_en = "IBAN",
                    account_parameter_TR = "IBAN",
                    account_parameter_value_en = "TR57 0006 4000 0016 8040 0771 20",
                    account_parameter_value_tr = "TR57 0006 4000 0016 8040 0771 20"
                });
                dormitory_bank_det.Add(new dormitory_bank_details_data
                {
                    dormitory_name = "Prime Living",
                    bank_name = "İş Bankası",
                    bank_currency = "TL",
                    account_parameter_en = "Account No",
                    account_parameter_TR = "Hesap No",
                    account_parameter_value_en = "0077120",
                    account_parameter_value_tr = "0077120"
                });
                dormitory_bank_det.Add(new dormitory_bank_details_data
                {
                    dormitory_name = "Prime Living",
                    bank_name = "İş Bankası",
                    bank_currency = "TL",
                    account_parameter_en = "Branch Code",
                    account_parameter_TR = "Branch Code",
                    account_parameter_value_en = "6804",
                    account_parameter_value_tr = "6804"
                });
                dormitory_bank_det.Add(new dormitory_bank_details_data
                {
                    dormitory_name = "EMU 1",
                    bank_name = "İs Bankasi(Magusa  Branch | Şubesi)",
                    bank_currency = "TL",
                    account_parameter_en = "IBAN",
                    account_parameter_TR = "IBAN",
                    account_parameter_value_en = "TR42-0006 4000 001 6820 0275509",
                    account_parameter_value_tr = "TR42-0006 4000 001 6820 0275509"
                });
                dormitory_bank_det.Add(new dormitory_bank_details_data
                {
                    dormitory_name = "EMU 2",
                    bank_name = "İs Bankasi(Magusa  Branch | Şubesi)",
                    bank_currency = "TL",
                    account_parameter_en = "IBAN",
                    account_parameter_TR = "IBAN",
                    account_parameter_value_en = "TR42-0006 4000 001 6820 0275509",
                    account_parameter_value_tr = "TR42-0006 4000 001 6820 0275509"
                });
                dormitory_bank_det.Add(new dormitory_bank_details_data
                {
                    dormitory_name = "EMU 3",
                    bank_name = "İs Bankasi(Magusa  Branch | Şubesi)",
                    bank_currency = "TL",
                    account_parameter_en = "IBAN",
                    account_parameter_TR = "IBAN",
                    account_parameter_value_en = "TR42-0006 4000 001 6820 0275509",
                    account_parameter_value_tr = "TR42-0006 4000 001 6820 0275509"
                });
                dormitory_bank_det.Add(new dormitory_bank_details_data
                {
                    dormitory_name = "EMU 4",
                    bank_name = "İs Bankasi(Magusa  Branch | Şubesi)",
                    bank_currency = "TL",
                    account_parameter_en = "IBAN",
                    account_parameter_TR = "IBAN",
                    account_parameter_value_en = "TR42-0006 4000 001 6820 0275509",
                    account_parameter_value_tr = "TR42-0006 4000 001 6820 0275509"
                });
                dormitory_bank_det.Add(new dormitory_bank_details_data
                {
                    dormitory_name = "EMU Sabanci ",
                    bank_name = "İs Bankasi(Magusa  Branch | Şubesi)",
                    bank_currency = "TL",
                    account_parameter_en = "IBAN",
                    account_parameter_TR = "IBAN",
                    account_parameter_value_en = "TR42-0006 4000 001 6820 0275509",
                    account_parameter_value_tr = "TR42-0006 4000 001 6820 0275509"
                });




                foreach (dormitory_bank_details_data ddt in dormitory_bank_det)
                {

                    language_table language_Table_EN = context.language_table.FirstOrDefault(l => l.language_code == "EN");
                    language_table language_Table_TR = context.language_table.FirstOrDefault(l => l.language_code == "TR");
                    //query language ids


                    dormitories_table dormitory = context.dormitories_table
                    .FirstOrDefault(d => d.id == d.dormitories_table_translation
                    .FirstOrDefault(c => c.dormitory_name == ddt.dormitory_name)
                    .dormitories_table_non_trans_id);
                    //this brings back dormitory id.

                    //********************** dormitory_bank_account_table & bank_currency_table
                    dormitory_bank_account_table dormitory_Bank_Account = new dormitory_bank_account_table
                    {
                        bank_name = ddt.bank_name,
                        dormitory_id = dormitory.id
                    };

                    context.dormitory_bank_account_table.Add(dormitory_Bank_Account);
                    context.SaveChanges();
                    //  dormitory_Bank_Account.id;

                    bank_currency_table bank_Currency = new bank_currency_table
                    {
                        bank_id = dormitory_Bank_Account.id,
                        currency_name = ddt.bank_currency
                    };

                    context.bank_currency_table.Add(bank_Currency);
                    context.SaveChanges();


                    //************************ account_information_parameter & account_paratermeter_translation
                    account_information_parameter account_Information_Param = new account_information_parameter
                    {
                    };
                    context.account_information_parameter.Add(account_Information_Param);
                    context.SaveChanges();
                    //account_Information_Param.id;


                    //english_translation
                    context.account_information_parameter_translation.Add(new account_information_parameter_translation
                    {
                        account_info_non_trans_id = account_Information_Param.id,
                        language_id = language_Table_EN.id,
                        parameter = ddt.account_parameter_en
                    }); context.SaveChanges();

                    //turkish_translation
                    context.account_information_parameter_translation.Add(new account_information_parameter_translation
                    {
                        account_info_non_trans_id = account_Information_Param.id,
                        language_id = language_Table_TR.id,
                        parameter = ddt.account_parameter_TR
                    }); context.SaveChanges();



                    //********************* accoung_parater_values & translation_table
                    account_parameter_values account_Parameter_Val = new account_parameter_values
                    {
                        currency_id = bank_Currency.id,
                        parameter_id = account_Information_Param.id

                    };
                    context.account_parameter_values.Add(account_Parameter_Val);
                    context.SaveChanges();


                    //english_translation
                    context.account_parameter_values_translation.Add(new account_parameter_values_translation
                    {
                        value = ddt.account_parameter_value_en,
                        language_id = language_Table_EN.id,
                        account_params_values_non_trans_id = account_Parameter_Val.id
                    });
                    context.SaveChanges();


                    //turkish_translation
                    context.account_parameter_values_translation.Add(new account_parameter_values_translation
                    {
                        value = ddt.account_parameter_value_tr,
                        language_id = language_Table_TR.id,
                        account_params_values_non_trans_id = account_Parameter_Val.id
                    });
                    context.SaveChanges();

                }
            }

        }

        static void print_all_dormitories_and_bank_accounts()
        {

            using (fees_and_facilitiesEntities4 context = new fees_and_facilitiesEntities4())
            {
                context.dormitories_table.ToList().ForEach(dormitory =>
                {

                    dormitory.dormitories_table_translation.Where(dorm => dorm.language_id == 1).ToList().ForEach(dormitory_trans =>
                    {
                        Console.WriteLine(dormitory_trans.dormitory_name);
                        dormitory.dormitory_bank_account_table.ToList().ForEach(f =>
                        {
                            Console.Write("   " + f.bank_name);
                            f.bank_currency_table.ToList().ForEach(dormitory_bank_curr_tab =>
                            {
                                Console.WriteLine(":" + dormitory_bank_curr_tab.currency_name);


                                dormitory_bank_curr_tab.account_parameter_values.ToList().ForEach(bk_cur_t_account_param_val =>
                                {

                                    bk_cur_t_account_param_val.account_information_parameter.account_information_parameter_translation.Where(c => c.language_id == 1).ToList().ForEach(acc_info_trans =>
                                    {
                                        Console.Write("      " + acc_info_trans.parameter);

                                        bk_cur_t_account_param_val.account_parameter_values_translation.Where(c => c.language_id == 1).ToList().ForEach(acc_param_vals_trans =>
                                        {
                                            Console.WriteLine(": " + acc_param_vals_trans.value);


                                        });

                                    });





                                });
                            });
                        });
                        Console.WriteLine();
                        Console.WriteLine();
                    });
                });
            }

        }

        static void printFunction()
        {
            using (fees_and_facilitiesEntities4 context = new fees_and_facilitiesEntities4())
            {
                //Console.WriteLine("Starting to read from database");
                //context.room_table.ToList().ForEach(r =>
                //{
                //    Console.WriteLine("Room: " + r.id);
                //    r.room_table_translation.Where(rw => rw.language_id ==1).ToList().ForEach(rr =>
                //    {
                //        Console.WriteLine("room title" + rr.room_title);
                //    });
                //});

                //context.room_table_translation.Where(room => room.language_id == 1).ToList().ForEach(room =>
                //{
                //    Console.WriteLine("Room ID: " + room.room_table_non_trans_id);
                //    Console.WriteLine("Room Name: " + room.room_title);
                //});

                List<int> room_ar = new List<int>();
                List<String> dorm_type_ = new List<String>();
                int langID = 2;
                context.dormitories_table.ToList().ForEach(dormitory =>
                {
                    dormitory.dormitory_type.dormitory_type_translation.Where(c => c.language_id == langID).ToList().ForEach(d =>
                    {
                        Console.WriteLine(d.type_name);
                        dorm_type_.Add(d.type_name);

                    });
                    dormitory.dormitories_table_translation.Where(dorm => dorm.language_id == langID).ToList().ForEach(dormitory_trans =>
                    {
                         Console.WriteLine("<option>"+ dormitory_trans.dormitory_name+ "</option>");
                        dormitory.room_table.ToList().ForEach(dorm_room =>
                        {
                            dorm_room.room_table_translation.Where(dorm_room_lang => dorm_room_lang.language_id == langID).ToList().ForEach(dorm_room_eng =>
                            {
                                // Console.WriteLine(" " + dorm_room_eng.room_title dorm_room.room_area);
                                 Console.WriteLine( dorm_room.room_area);
                                room_ar.Add(dorm_room.room_area);

                                dorm_room.room_facility.ToList().ForEach(dorm_room_facility =>
                                {
                                    dorm_room_facility.facility_table.facility_table_translation.Where(drf => drf.language_id == langID).ToList().ForEach(dorm_room_facility_facility =>
                                    {
                                          Console.WriteLine("   " + dorm_room_facility_facility.facility_title);
                                        dorm_room_facility.facility_table.facility_option.ToList().ForEach(dorm_room_facility_facility_option =>
                                        {
                                            dorm_room_facility_facility_option.facility_option_translation.Where(drffo => drffo.language_id == langID).ToList().ForEach(dorm_room_facility_facility_option_eng =>
                                            {
                                                   Console.WriteLine("    " + dorm_room_facility_facility.facility_title+" | "+ dorm_room_facility_facility_option_eng.facility_option);
                                            });




                                        });
                                    });
                                });
                            });
                        });

                    });

                    //  Console.WriteLine("===================================================================");
                    //    Console.WriteLine();

                });

                //  room_ar.Sort();
                // foreach (int i in room_ar.Distinct().ToList())
                // Console.WriteLine("<option value=\""+i+"\"> "+i+" m<sup style=\"vertical-align: super; font-size: smaller; \">2</sup> </option>");

                //foreach (var dt in dorm_type_.Distinct())
                //{
                //    Console.WriteLine("<option value=\"\">" + dt + "</option>");
                //}
            }



        }

        static void sampleFunc()
        {
            Console.WriteLine("I have been called");
        }

        static void print_list_of_english_and_turkish_dormitories()
        {

            using (fees_and_facilitiesEntities4 context = new fees_and_facilitiesEntities4())
            {
                Console.WriteLine("Starting to read from database");
                context.dormitories_table_translation.ToList().Where(dormitoryx => dormitoryx.language_id == 1).ToList().ForEach(dormitory =>
                {
                    Console.WriteLine("ID: " + dormitory.dormitories_table_non_trans_id);
                    Console.WriteLine("Dormitory name: " + dormitory.dormitory_name);

                });
                Console.WriteLine("===========================================");

                Console.WriteLine("Starting to read from database");
                context.dormitories_table_translation.ToList().Where(dormitoryx => dormitoryx.language_id == 2).ToList().ForEach(dormitory =>
                {
                    Console.WriteLine("ID: " + dormitory.dormitories_table_non_trans_id);
                    Console.WriteLine("Dormitory name: " + dormitory.dormitory_name);

                });





            }


        }

        static void room_facility_combo_initiate()
        {
            ArrayList roomFacilityList = new ArrayList();
            int facility_option_int_id;

            roomFacilityList.Add(new room_facility_data("Alfam", "C Block single room", "TV", "In room"));
             roomFacilityList.Add(new room_facility_data("Alfam", "C Block double room", "TV", "In room"));
             roomFacilityList.Add(new room_facility_data("Alfam", "Vista double room(Balcony)", "TV", "In room"));
             roomFacilityList.Add(new room_facility_data("Uğursal", "Single room", "TV", "In room"));

            roomFacilityList.Add(new room_facility_data("Uğursal", "Double room", "TV", "In room"));
            
              roomFacilityList.Add(new room_facility_data("Marmara", "Single room", "TV", "In room"));
              roomFacilityList.Add(new room_facility_data("Marmara", "Double room", "TV", "In room"));
              roomFacilityList.Add(new room_facility_data("Akdeniz", "Single room", "TV", "In room"));
              roomFacilityList.Add(new room_facility_data("Akdeniz", "Double room", "TV", "In room"));
              roomFacilityList.Add(new room_facility_data("Longson", "Single room", "TV", "In room"));
              roomFacilityList.Add(new room_facility_data("Longson", "Double room", "TV", "In room"));
              roomFacilityList.Add(new room_facility_data("Homedorm", "Single room", "TV", "In room"));
              roomFacilityList.Add(new room_facility_data("Homedorm", "Double room", "TV", "In room"));
              roomFacilityList.Add(new room_facility_data("Ramen", "Single room", "TV", "In room"));
              roomFacilityList.Add(new room_facility_data("Ramen", "Double room", "TV", "In room"));
              roomFacilityList.Add(new room_facility_data("Prime Living", "1 + 1 Suite", "TV", "In room"));
              roomFacilityList.Add(new room_facility_data("Prime Living", "Double room", "TV", "In room"));
              roomFacilityList.Add(new room_facility_data("Golden Plus", "Single room with balcony", "TV", "In room"));
              roomFacilityList.Add(new room_facility_data("Golden Plus", "Double room with balcony", "TV", "In room"));
              roomFacilityList.Add(new room_facility_data("Kamacıoğlu", "Single room", "TV", "In room"));
              roomFacilityList.Add(new room_facility_data("Kamacıoğlu", "Double room", "TV", "In room"));

              roomFacilityList.Add(new room_facility_data("EMU 1", "Triple room", "TV", "In Hall"));
              roomFacilityList.Add(new room_facility_data("EMU 1", "Quadruple room", "TV", "In Hall"));
              roomFacilityList.Add(new room_facility_data("EMU Sabanci ", "Triple room", "TV", "In Hall"));
              roomFacilityList.Add(new room_facility_data("EMU 2", "Special Double room", "TV", "In Hall"));
              roomFacilityList.Add(new room_facility_data("EMU 2", "Triple room", "TV", "In Hall"));
              roomFacilityList.Add(new room_facility_data("EMU 3", "Normal double room", "TV", "In Hall"));
              roomFacilityList.Add(new room_facility_data("EMU 3", "Corner single room", "TV", "In Hall"));
              roomFacilityList.Add(new room_facility_data("EMU 3", "Corner double room", "TV", "In Hall"));
              roomFacilityList.Add(new room_facility_data("EMU 4", "Quadruple room", "TV", "In Hall"));

              roomFacilityList.Add(new room_facility_data("EMU 4", "Quadruple room", "WC-shower", "In room"));
              roomFacilityList.Add(new room_facility_data("Alfam", "C Block single room", "WC-shower", "In room"));
              roomFacilityList.Add(new room_facility_data("Alfam", "C Block double room", "WC-shower", "In room"));
              roomFacilityList.Add(new room_facility_data("Alfam", "Vista double room(Balcony)", "WC-shower", "In room"));
              roomFacilityList.Add(new room_facility_data("Uğursal", "Single room", "WC-shower", "In room")); 

            roomFacilityList.Add(new room_facility_data("Uğursal", "Double room", "WC-shower", "In room"));

            roomFacilityList.Add(new room_facility_data("Marmara", "Single room", "WC-shower", "In room"));
            roomFacilityList.Add(new room_facility_data("Marmara", "Double room", "WC-shower", "In room"));
            roomFacilityList.Add(new room_facility_data("Akdeniz", "Single room", "WC-shower", "In room"));
            roomFacilityList.Add(new room_facility_data("Akdeniz", "Double room", "WC-shower", "In room"));
            roomFacilityList.Add(new room_facility_data("Longson", "Single room", "WC-shower", "In room"));
            roomFacilityList.Add(new room_facility_data("Longson", "Double room", "WC-shower", "In room"));
            roomFacilityList.Add(new room_facility_data("Homedorm", "Single room", "WC-shower", "In room"));
            roomFacilityList.Add(new room_facility_data("Homedorm", "Double room", "WC-shower", "In room"));
            roomFacilityList.Add(new room_facility_data("Ramen", "Single room", "WC-shower", "In room"));
            roomFacilityList.Add(new room_facility_data("Ramen", "Double room", "WC-shower", "In room"));
            roomFacilityList.Add(new room_facility_data("Prime Living", "1 + 1 Suite", "WC-shower", "In room"));
            roomFacilityList.Add(new room_facility_data("Prime Living", "Double room", "WC-shower", "In room"));
            roomFacilityList.Add(new room_facility_data("Golden Plus", "Single room with balcony", "WC-shower", "In room"));
            roomFacilityList.Add(new room_facility_data("Golden Plus", "Double room with balcony", "WC-shower", "In room"));
            roomFacilityList.Add(new room_facility_data("Kamacıoğlu", "Single room", "WC-shower", "In room"));
            roomFacilityList.Add(new room_facility_data("Kamacıoğlu", "Double room", "WC-shower", "In room"));
            roomFacilityList.Add(new room_facility_data("EMU 2", "Special Double room", "WC-shower", "In room"));
            roomFacilityList.Add(new room_facility_data("EMU 1", "Quadruple room", "WC-shower", "In room"));

            roomFacilityList.Add(new room_facility_data("EMU 2", "Triple room", "WC-shower", "Common"));
            roomFacilityList.Add(new room_facility_data("EMU 3", "Normal double room", "WC-shower", "Common"));
            roomFacilityList.Add(new room_facility_data("EMU 3", "Corner single room", "WC-shower", "Common"));
            roomFacilityList.Add(new room_facility_data("EMU 3", "Corner double room", "WC-shower", "Common"));

            roomFacilityList.Add(new room_facility_data("EMU 1", "Triple room", "WC-shower", "Flats"));
            roomFacilityList.Add(new room_facility_data("EMU Sabanci ", "Triple room", "WC-shower", "Flats"));

            roomFacilityList.Add(new room_facility_data("EMU 1", "Quadruple room", "Kitchenette", "In room"));
            roomFacilityList.Add(new room_facility_data("Alfam", "C Block double room", "Kitchenette", "In room"));
            roomFacilityList.Add(new room_facility_data("Alfam", "Vista double room(Balcony)", "Kitchenette", "In room"));
            roomFacilityList.Add(new room_facility_data("Marmara", "Single room", "Kitchenette", "In room"));
            roomFacilityList.Add(new room_facility_data("Marmara", "Double room", "Kitchenette", "In room"));
            roomFacilityList.Add(new room_facility_data("Ramen", "Single room", "Kitchenette", "In room"));
            roomFacilityList.Add(new room_facility_data("Ramen", "Double room", "Kitchenette", "In room"));
            roomFacilityList.Add(new room_facility_data("Prime Living", "1 + 1 Suite", "Kitchenette", "In room"));
            roomFacilityList.Add(new room_facility_data("Golden Plus", "Single room with balcony", "Kitchenette", "In room"));
            roomFacilityList.Add(new room_facility_data("Golden Plus", "Double room with balcony", "Kitchenette", "In room"));

            roomFacilityList.Add(new room_facility_data("EMU 1", "Triple room", "Kitchenette", "Flats"));
            roomFacilityList.Add(new room_facility_data("EMU Sabanci ", "Triple room", "Kitchenette", "Flats"));
            roomFacilityList.Add(new room_facility_data("EMU 2", "Special Double room", "Kitchenette", "Flats"));
            roomFacilityList.Add(new room_facility_data("EMU 2", "Triple room", "Kitchenette", "Flats"));
            roomFacilityList.Add(new room_facility_data("EMU 3", "Normal double room", "Kitchenette", "Flats"));
            roomFacilityList.Add(new room_facility_data("EMU 3", "Corner single room", "Kitchenette", "Flats"));
            roomFacilityList.Add(new room_facility_data("EMU 3", "Corner double room", "Kitchenette", "Flats"));
            roomFacilityList.Add(new room_facility_data("EMU 4", "Quadruple room", "Kitchenette", "Flats"));
            roomFacilityList.Add(new room_facility_data("Alfam", "C Block single room", "Kitchenette", "Flats"));
            roomFacilityList.Add(new room_facility_data("Alfam", "C Block double room", "Kitchenette", "Flats"));
            roomFacilityList.Add(new room_facility_data("Uğursal", "Single room", "Kitchenette", "Flats")); 

     roomFacilityList.Add(new room_facility_data("Uğursal", "Double room", "Kitchenette", "Flats"));

            roomFacilityList.Add(new room_facility_data("Akdeniz", "Single room", "Kitchenette", "Flats"));
            roomFacilityList.Add(new room_facility_data("Akdeniz", "Double room", "Kitchenette", "Flats"));
            roomFacilityList.Add(new room_facility_data("Longson", "Single room", "Kitchenette", "Flats"));
            roomFacilityList.Add(new room_facility_data("Longson", "Double room", "Kitchenette", "Flats"));
            roomFacilityList.Add(new room_facility_data("Homedorm", "Single room", "Kitchenette", "Flats"));
            roomFacilityList.Add(new room_facility_data("Homedorm", "Double room", "Kitchenette", "Flats"));
            roomFacilityList.Add(new room_facility_data("Prime Living", "Double room", "Kitchenette", "Flats"));
            roomFacilityList.Add(new room_facility_data("Kamacıoğlu", "Single room", "Kitchenette", "Flats"));
            roomFacilityList.Add(new room_facility_data("Kamacıoğlu", "Double room", "Kitchenette", "Flats"));

            roomFacilityList.Add(new room_facility_data("EMU 1", "Triple room", "Refrigerator", "null"));
            roomFacilityList.Add(new room_facility_data("EMU 1", "Quadruple room", "Refrigerator", "null"));
            roomFacilityList.Add(new room_facility_data("EMU Sabanci ", "Triple room", "Refrigerator", "null"));
            roomFacilityList.Add(new room_facility_data("EMU 2", "Special Double room", "Refrigerator", "null"));
            roomFacilityList.Add(new room_facility_data("EMU 2", "Triple room", "Refrigerator", "null"));
            roomFacilityList.Add(new room_facility_data("EMU 3", "Normal double room", "Refrigerator", "null"));
            roomFacilityList.Add(new room_facility_data("EMU 3", "Corner single room", "Refrigerator", "null"));
            roomFacilityList.Add(new room_facility_data("EMU 3", "Corner double room", "Refrigerator", "null"));
            roomFacilityList.Add(new room_facility_data("EMU 4", "Quadruple room", "Refrigerator", "null"));
            roomFacilityList.Add(new room_facility_data("Alfam", "C Block single room", "Refrigerator", "null"));
            roomFacilityList.Add(new room_facility_data("Alfam", "C Block double room", "Refrigerator", "null"));
            roomFacilityList.Add(new room_facility_data("Alfam", "Vista double room(Balcony)", "Refrigerator", "null"));

            roomFacilityList.Add(new room_facility_data("Uğursal", "Single room", "Refrigerator", "null"));

            roomFacilityList.Add(new room_facility_data("Uğursal", "Double room", "Refrigerator", "null"));


            roomFacilityList.Add(new room_facility_data("Marmara", "Single room", "Refrigerator", "null"));
            roomFacilityList.Add(new room_facility_data("Marmara", "Double room", "Refrigerator", "null"));
            roomFacilityList.Add(new room_facility_data("Akdeniz", "Single room", "Refrigerator", "null"));
            roomFacilityList.Add(new room_facility_data("Akdeniz", "Double room", "Refrigerator", "null"));
            roomFacilityList.Add(new room_facility_data("Longson", "Single room", "Refrigerator", "null"));
            roomFacilityList.Add(new room_facility_data("Longson", "Double room", "Refrigerator", "null"));
            roomFacilityList.Add(new room_facility_data("Homedorm", "Single room", "Refrigerator", "null"));
            roomFacilityList.Add(new room_facility_data("Homedorm", "Double room", "Refrigerator", "null"));
            roomFacilityList.Add(new room_facility_data("Ramen", "Single room", "Refrigerator", "null"));
            roomFacilityList.Add(new room_facility_data("Ramen", "Double room", "Refrigerator", "null"));
            roomFacilityList.Add(new room_facility_data("Prime Living", "1 + 1 Suite", "Refrigerator", "null"));
            roomFacilityList.Add(new room_facility_data("Prime Living", "Double room", "Refrigerator", "null"));
            roomFacilityList.Add(new room_facility_data("Golden Plus", "Single room with balcony", "Refrigerator", "null"));
            roomFacilityList.Add(new room_facility_data("Golden Plus", "Double room with balcony", "Refrigerator", "null"));
            roomFacilityList.Add(new room_facility_data("Kamacıoğlu", "Single room", "Refrigerator", "null"));
            roomFacilityList.Add(new room_facility_data("Kamacıoğlu", "Double room", "Refrigerator", "null"));



            roomFacilityList.Add(new room_facility_data("EMU 1", "Triple room", "Internet", "Cable"));
            roomFacilityList.Add(new room_facility_data("EMU 1", "Quadruple room", "Internet", "Cable"));
            roomFacilityList.Add(new room_facility_data("EMU Sabanci ", "Triple room", "Internet", "Cable"));
            roomFacilityList.Add(new room_facility_data("EMU 2", "Special Double room", "Internet", "Cable"));
            roomFacilityList.Add(new room_facility_data("EMU 2", "Triple room", "Internet", "Cable"));
            roomFacilityList.Add(new room_facility_data("EMU 3", "Normal double room", "Internet", "Cable"));
            roomFacilityList.Add(new room_facility_data("EMU 3", "Corner single room", "Internet", "Cable"));
            roomFacilityList.Add(new room_facility_data("EMU 3", "Corner double room", "Internet", "Cable"));
            roomFacilityList.Add(new room_facility_data("EMU 4", "Quadruple room", "Internet", "Cable"));
            roomFacilityList.Add(new room_facility_data("Alfam", "C Block single room", "Internet", "Cable"));
            roomFacilityList.Add(new room_facility_data("Alfam", "C Block double room", "Internet", "Cable"));
            roomFacilityList.Add(new room_facility_data("Alfam", "Vista double room(Balcony)", "Internet", "Cable"));

            roomFacilityList.Add(new room_facility_data("Uğursal", "Single room", "Internet", "Cable"));

            roomFacilityList.Add(new room_facility_data("Uğursal", "Double room", "Internet", "Cable"));

            roomFacilityList.Add(new room_facility_data("Marmara", "Single room", "Internet", "Cable"));
            roomFacilityList.Add(new room_facility_data("Marmara", "Double room", "Internet", "Cable"));
            roomFacilityList.Add(new room_facility_data("Akdeniz", "Single room", "Internet", "Cable"));
            roomFacilityList.Add(new room_facility_data("Akdeniz", "Double room", "Internet", "Cable"));
            roomFacilityList.Add(new room_facility_data("Longson", "Single room", "Internet", "Cable"));
            roomFacilityList.Add(new room_facility_data("Longson", "Double room", "Internet", "Cable"));
            roomFacilityList.Add(new room_facility_data("Homedorm", "Single room", "Internet", "Cable"));
            roomFacilityList.Add(new room_facility_data("Homedorm", "Double room", "Internet", "Cable"));
            roomFacilityList.Add(new room_facility_data("Ramen", "Single room", "Internet", "Cable"));
            roomFacilityList.Add(new room_facility_data("Ramen", "Double room", "Internet", "Cable"));
            roomFacilityList.Add(new room_facility_data("Prime Living", "1 + 1 Suite", "Internet", "Cable"));
            roomFacilityList.Add(new room_facility_data("Prime Living", "Double room", "Internet", "Cable"));
            roomFacilityList.Add(new room_facility_data("Golden Plus", "Single room with balcony", "Internet", "Cable"));
            roomFacilityList.Add(new room_facility_data("Golden Plus", "Double room with balcony", "Internet", "Cable"));
            roomFacilityList.Add(new room_facility_data("Kamacıoğlu", "Single room", "Internet", "Cable"));
            roomFacilityList.Add(new room_facility_data("Kamacıoğlu", "Double room", "Internet", "Cable"));


            roomFacilityList.Add(new room_facility_data("EMU 2", "Special Double room", "Internet", "Wireless"));
            roomFacilityList.Add(new room_facility_data("EMU 2", "Triple room", "Internet", "Wireless"));
            roomFacilityList.Add(new room_facility_data("EMU 3", "Normal double room", "Internet", "Wireless"));
            roomFacilityList.Add(new room_facility_data("EMU 3", "Corner single room", "Internet", "Wireless"));
            roomFacilityList.Add(new room_facility_data("EMU 3", "Corner double room", "Internet", "Wireless"));
            roomFacilityList.Add(new room_facility_data("EMU 4", "Quadruple room", "Internet", "Wireless"));
            roomFacilityList.Add(new room_facility_data("Alfam", "C Block single room", "Internet", "Wireless"));
            roomFacilityList.Add(new room_facility_data("Alfam", "C Block double room", "Internet", "Wireless"));
            roomFacilityList.Add(new room_facility_data("Alfam", "Vista double room(Balcony)", "Internet", "Wireless"));
            roomFacilityList.Add(new room_facility_data("Uğursal", "Single room", "Internet", "Wireless"));

            roomFacilityList.Add(new room_facility_data("Uğursal", "Double room", "Internet", "Wireless"));

            roomFacilityList.Add(new room_facility_data("Marmara", "Single room", "Internet", "Wireless"));
            roomFacilityList.Add(new room_facility_data("Marmara", "Double room", "Internet", "Wireless"));
            roomFacilityList.Add(new room_facility_data("Akdeniz", "Single room", "Internet", "Wireless"));
            roomFacilityList.Add(new room_facility_data("Akdeniz", "Double room", "Internet", "Wireless"));
            roomFacilityList.Add(new room_facility_data("Longson", "Single room", "Internet", "Wireless"));
            roomFacilityList.Add(new room_facility_data("Longson", "Double room", "Internet", "Wireless"));
            roomFacilityList.Add(new room_facility_data("Homedorm", "Single room", "Internet", "Wireless"));
            roomFacilityList.Add(new room_facility_data("Homedorm", "Double room", "Internet", "Wireless"));
            roomFacilityList.Add(new room_facility_data("Ramen", "Single room", "Internet", "Wireless"));
            roomFacilityList.Add(new room_facility_data("Ramen", "Double room", "Internet", "Wireless"));
            roomFacilityList.Add(new room_facility_data("Prime Living", "1 + 1 Suite", "Internet", "Wireless"));
            roomFacilityList.Add(new room_facility_data("Prime Living", "Double room", "Internet", "Wireless"));
            roomFacilityList.Add(new room_facility_data("Golden Plus", "Single room with balcony", "Internet", "Wireless"));
            roomFacilityList.Add(new room_facility_data("Golden Plus", "Double room with balcony", "Internet", "Wireless"));
            roomFacilityList.Add(new room_facility_data("Kamacıoğlu", "Single room", "Internet", "Wireless"));
            roomFacilityList.Add(new room_facility_data("Kamacıoğlu", "Double room", "Internet", "Wireless"));


            roomFacilityList.Add(new room_facility_data("EMU 1", "Triple room", "Air-condition", "null"));
            roomFacilityList.Add(new room_facility_data("EMU 1", "Quadruple room", "Air-condition", "null"));
            roomFacilityList.Add(new room_facility_data("EMU Sabanci ", "Triple room", "Air-condition", "null"));
            roomFacilityList.Add(new room_facility_data("EMU 2", "Special Double room", "Air-condition", "null"));
            roomFacilityList.Add(new room_facility_data("EMU 2", "Triple room", "Air-condition", "null"));
            roomFacilityList.Add(new room_facility_data("EMU 3", "Normal double room", "Air-condition", "null"));
            roomFacilityList.Add(new room_facility_data("EMU 3", "Corner single room", "Air-condition", "null"));
            roomFacilityList.Add(new room_facility_data("EMU 3", "Corner double room", "Air-condition", "null"));
            roomFacilityList.Add(new room_facility_data("EMU 4", "Quadruple room", "Air-condition", "null"));
            roomFacilityList.Add(new room_facility_data("Alfam", "C Block single room", "Air-condition", "null"));
            roomFacilityList.Add(new room_facility_data("Alfam", "C Block double room", "Air-condition", "null"));
            roomFacilityList.Add(new room_facility_data("Alfam", "Vista double room(Balcony)", "Air-condition", "null"));

            roomFacilityList.Add(new room_facility_data("Uğursal", "Single room", "Air-condition", "null"));

            roomFacilityList.Add(new room_facility_data("Uğursal", "Double room", "Air-condition", "null"));

            roomFacilityList.Add(new room_facility_data("Marmara", "Single room", "Air-condition", "null"));
            roomFacilityList.Add(new room_facility_data("Marmara", "Double room", "Air-condition", "null"));
            roomFacilityList.Add(new room_facility_data("Longson", "Single room", "Air-condition", "null"));
            roomFacilityList.Add(new room_facility_data("Longson", "Double room", "Air-condition", "null"));
            roomFacilityList.Add(new room_facility_data("Homedorm", "Single room", "Air-condition", "null"));
            roomFacilityList.Add(new room_facility_data("Homedorm", "Double room", "Air-condition", "null"));
            roomFacilityList.Add(new room_facility_data("Ramen", "Single room", "Air-condition", "null"));
            roomFacilityList.Add(new room_facility_data("Ramen", "Double room", "Air-condition", "null"));
            roomFacilityList.Add(new room_facility_data("Golden Plus", "Single room with balcony", "Air-condition", "null"));
            roomFacilityList.Add(new room_facility_data("Golden Plus", "Double room with balcony", "Air-condition", "null"));
            roomFacilityList.Add(new room_facility_data("Kamacıoğlu", "Single room", "Air-condition", "null"));
            roomFacilityList.Add(new room_facility_data("Kamacıoğlu", "Double room", "Air-condition", "null"));


            roomFacilityList.Add(new room_facility_data("Akdeniz", "Single room", "Central conditioning system", "Heating"));
            roomFacilityList.Add(new room_facility_data("Akdeniz", "Double room", "Central conditioning system", "Heating"));
            roomFacilityList.Add(new room_facility_data("Prime Living", "1 + 1 Suite", "Central conditioning system", "Heating"));
            roomFacilityList.Add(new room_facility_data("Prime Living", "Double room", "Central conditioning system", "Heating"));

            roomFacilityList.Add(new room_facility_data("Akdeniz", "Single room", "Central conditioning system", "Cooling"));
            roomFacilityList.Add(new room_facility_data("Akdeniz", "Double room", "Central conditioning system", "Cooling"));
            roomFacilityList.Add(new room_facility_data("Prime Living", "1 + 1 Suite", "Central conditioning system", "Cooling"));
            roomFacilityList.Add(new room_facility_data("Prime Living", "Double room", "Central conditioning system", "Cooling"));

            roomFacilityList.Add(new room_facility_data("EMU 1", "Triple room", "Room tel.", "null"));
            roomFacilityList.Add(new room_facility_data("EMU 1", "Quadruple room", "Room tel.", "null"));
            roomFacilityList.Add(new room_facility_data("EMU Sabanci ", "Triple room", "Room tel.", "null"));
            roomFacilityList.Add(new room_facility_data("EMU 2", "Special Double room", "Room tel.", "null"));
            roomFacilityList.Add(new room_facility_data("EMU 2", "Triple room", "Room tel.", "null"));
            roomFacilityList.Add(new room_facility_data("EMU 3", "Normal double room", "Room tel.", "null"));
            roomFacilityList.Add(new room_facility_data("EMU 3", "Corner single room", "Room tel.", "null"));
            roomFacilityList.Add(new room_facility_data("EMU 3", "Corner double room", "Room tel.", "null"));
            roomFacilityList.Add(new room_facility_data("EMU 4", "Quadruple room", "Room tel.", "null"));
            roomFacilityList.Add(new room_facility_data("Uğursal", "Single room", "Room tel.", "null"));

            roomFacilityList.Add(new room_facility_data("Uğursal", "Double room", "Room tel.", "null"));

            roomFacilityList.Add(new room_facility_data("Marmara", "Single room", "Room tel.", "null"));
            roomFacilityList.Add(new room_facility_data("Marmara", "Double room", "Room tel.", "null"));
            roomFacilityList.Add(new room_facility_data("Akdeniz", "Single room", "Room tel.", "null"));
            roomFacilityList.Add(new room_facility_data("Akdeniz", "Double room", "Room tel.", "null"));
            roomFacilityList.Add(new room_facility_data("Longson", "Single room", "Room tel.", "null"));
            roomFacilityList.Add(new room_facility_data("Longson", "Double room", "Room tel.", "null"));
            roomFacilityList.Add(new room_facility_data("Homedorm", "Single room", "Room tel.", "null"));
            roomFacilityList.Add(new room_facility_data("Homedorm", "Double room", "Room tel.", "null"));
            roomFacilityList.Add(new room_facility_data("Ramen", "Single room", "Room tel.", "null"));
            roomFacilityList.Add(new room_facility_data("Ramen", "Double room", "Room tel.", "null"));
            roomFacilityList.Add(new room_facility_data("Prime Living", "1 + 1 Suite", "Room tel.", "null"));
            roomFacilityList.Add(new room_facility_data("Prime Living", "Double room", "Room tel.", "null"));
            roomFacilityList.Add(new room_facility_data("Kamacıoğlu", "Single room", "Room tel.", "null"));
            roomFacilityList.Add(new room_facility_data("Kamacıoğlu", "Double room", "Room tel.", "null"));


            roomFacilityList.Add(new room_facility_data("EMU 1", "Triple room", "Generator", "null"));
            roomFacilityList.Add(new room_facility_data("EMU 1", "Quadruple room", "Generator", "null"));
            roomFacilityList.Add(new room_facility_data("EMU Sabanci ", "Triple room", "Generator", "null"));
            roomFacilityList.Add(new room_facility_data("EMU 2", "Special Double room", "Generator", "null"));
            roomFacilityList.Add(new room_facility_data("EMU 2", "Triple room", "Generator", "null"));
            roomFacilityList.Add(new room_facility_data("EMU 3", "Normal double room", "Generator", "null"));
            roomFacilityList.Add(new room_facility_data("EMU 3", "Corner single room", "Generator", "null"));
            roomFacilityList.Add(new room_facility_data("EMU 3", "Corner double room", "Generator", "null"));
            roomFacilityList.Add(new room_facility_data("EMU 4", "Quadruple room", "Generator", "null"));
            roomFacilityList.Add(new room_facility_data("Alfam", "C Block single room", "Generator", "null"));
            roomFacilityList.Add(new room_facility_data("Alfam", "C Block double room", "Generator", "null"));
            roomFacilityList.Add(new room_facility_data("Alfam", "Vista double room(Balcony)", "Generator", "null"));
            roomFacilityList.Add(new room_facility_data("Uğursal", "Single room", "Generator", "null"));

            roomFacilityList.Add(new room_facility_data("Uğursal", "Double room", "Generator", "null"));

            roomFacilityList.Add(new room_facility_data("Marmara", "Single room", "Generator", "null"));
            roomFacilityList.Add(new room_facility_data("Marmara", "Double room", "Generator", "null"));
            roomFacilityList.Add(new room_facility_data("Akdeniz", "Single room", "Generator", "null"));
            roomFacilityList.Add(new room_facility_data("Akdeniz", "Double room", "Generator", "null"));
            roomFacilityList.Add(new room_facility_data("Longson", "Single room", "Generator", "null"));
            roomFacilityList.Add(new room_facility_data("Longson", "Double room", "Generator", "null"));
            roomFacilityList.Add(new room_facility_data("Homedorm", "Single room", "Generator", "null"));
            roomFacilityList.Add(new room_facility_data("Homedorm", "Double room", "Generator", "null"));
            roomFacilityList.Add(new room_facility_data("Ramen", "Single room", "Generator", "null"));
            roomFacilityList.Add(new room_facility_data("Ramen", "Double room", "Generator", "null"));
            roomFacilityList.Add(new room_facility_data("Prime Living", "1 + 1 Suite", "Generator", "null"));
            roomFacilityList.Add(new room_facility_data("Prime Living", "Double room", "Generator", "null"));
            roomFacilityList.Add(new room_facility_data("Golden Plus", "Single room with balcony", "Generator", "null"));
            roomFacilityList.Add(new room_facility_data("Golden Plus", "Double room with balcony", "Generator", "null"));
            roomFacilityList.Add(new room_facility_data("Kamacıoğlu", "Single room", "Generator", "null"));
            roomFacilityList.Add(new room_facility_data("Kamacıoğlu", "Double room", "Generator", "null"));

            roomFacilityList.Add(new room_facility_data("EMU 1", "Triple room", "Cafeteria", "null"));
            roomFacilityList.Add(new room_facility_data("EMU 1", "Quadruple room", "Cafeteria", "null"));
            roomFacilityList.Add(new room_facility_data("EMU Sabanci ", "Triple room", "Cafeteria", "null"));
            roomFacilityList.Add(new room_facility_data("Alfam", "C Block single room", "Cafeteria", "null"));
            roomFacilityList.Add(new room_facility_data("Alfam", "C Block double room", "Cafeteria", "null"));
            roomFacilityList.Add(new room_facility_data("Alfam", "Vista double room(Balcony)", "Cafeteria", "null"));
            roomFacilityList.Add(new room_facility_data("Uğursal", "Single room", "Cafeteria", "null"));

            roomFacilityList.Add(new room_facility_data("Uğursal", "Double room", "Cafeteria", "null"));

            roomFacilityList.Add(new room_facility_data("Marmara", "Single room", "Cafeteria", "null"));
            roomFacilityList.Add(new room_facility_data("Marmara", "Double room", "Cafeteria", "null"));
            roomFacilityList.Add(new room_facility_data("Longson", "Single room", "Cafeteria", "null"));
            roomFacilityList.Add(new room_facility_data("Longson", "Double room", "Cafeteria", "null"));
            roomFacilityList.Add(new room_facility_data("Homedorm", "Single room", "Cafeteria", "null"));
            roomFacilityList.Add(new room_facility_data("Homedorm", "Double room", "Cafeteria", "null"));
            roomFacilityList.Add(new room_facility_data("Ramen", "Single room", "Cafeteria", "null"));
            roomFacilityList.Add(new room_facility_data("Ramen", "Double room", "Cafeteria", "null"));
            roomFacilityList.Add(new room_facility_data("Prime Living", "1 + 1 Suite", "Cafeteria", "null"));
            roomFacilityList.Add(new room_facility_data("Prime Living", "Double room", "Cafeteria", "null"));
            roomFacilityList.Add(new room_facility_data("Golden Plus", "Single room with balcony", "Cafeteria", "null"));
            roomFacilityList.Add(new room_facility_data("Golden Plus", "Double room with balcony", "Cafeteria", "null"));
            roomFacilityList.Add(new room_facility_data("Kamacıoğlu", "Single room", "Cafeteria", "null"));
            roomFacilityList.Add(new room_facility_data("Kamacıoğlu", "Double room", "Cafeteria", "null"));


            roomFacilityList.Add(new room_facility_data("EMU 1", "Triple room", "Laundry", "null"));
            roomFacilityList.Add(new room_facility_data("EMU 1", "Quadruple room", "Laundry", "null"));
            roomFacilityList.Add(new room_facility_data("EMU 2", "Special Double room", "Laundry", "null"));
            roomFacilityList.Add(new room_facility_data("EMU 2", "Triple room", "Laundry", "null"));
            roomFacilityList.Add(new room_facility_data("EMU 4", "Quadruple room", "Laundry", "null"));
            roomFacilityList.Add(new room_facility_data("Alfam", "C Block single room", "Laundry", "null"));
            roomFacilityList.Add(new room_facility_data("Alfam", "C Block double room", "Laundry", "null"));
            roomFacilityList.Add(new room_facility_data("Alfam", "Vista double room(Balcony)", "Laundry", "null"));
            roomFacilityList.Add(new room_facility_data("Uğursal", "Single room", "Laundry", "null"));

            roomFacilityList.Add(new room_facility_data("Uğursal", "Double room", "Laundry", "null"));

            roomFacilityList.Add(new room_facility_data("Marmara", "Single room", "Laundry", "null"));
            roomFacilityList.Add(new room_facility_data("Marmara", "Double room", "Laundry", "null"));
            roomFacilityList.Add(new room_facility_data("Akdeniz", "Single room", "Laundry", "null"));
            roomFacilityList.Add(new room_facility_data("Akdeniz", "Double room", "Laundry", "null"));
            roomFacilityList.Add(new room_facility_data("Longson", "Single room", "Laundry", "null"));
            roomFacilityList.Add(new room_facility_data("Longson", "Double room", "Laundry", "null"));
            roomFacilityList.Add(new room_facility_data("Homedorm", "Single room", "Laundry", "null"));
            roomFacilityList.Add(new room_facility_data("Homedorm", "Double room", "Laundry", "null"));
            roomFacilityList.Add(new room_facility_data("Ramen", "Single room", "Laundry", "null"));
            roomFacilityList.Add(new room_facility_data("Ramen", "Double room", "Laundry", "null"));
            roomFacilityList.Add(new room_facility_data("Prime Living", "1 + 1 Suite", "Laundry", "null"));
            roomFacilityList.Add(new room_facility_data("Prime Living", "Double room", "Laundry", "null"));
            roomFacilityList.Add(new room_facility_data("Golden Plus", "Single room with balcony", "Laundry", "null"));
            roomFacilityList.Add(new room_facility_data("Golden Plus", "Double room with balcony", "Laundry", "null"));
            roomFacilityList.Add(new room_facility_data("Kamacıoğlu", "Single room", "Laundry", "null"));
            roomFacilityList.Add(new room_facility_data("Kamacıoğlu", "Double room", "Laundry", "null"));

            roomFacilityList.Add(new room_facility_data("EMU 1", "Triple room", "Bed", "Bunk"));
            roomFacilityList.Add(new room_facility_data("EMU 1", "Quadruple room", "Bed", "Bunk"));
            roomFacilityList.Add(new room_facility_data("EMU Sabanci ", "Triple room", "Bed", "Bunk"));
            roomFacilityList.Add(new room_facility_data("EMU 2", "Special Double room", "Bed", "Bunk"));
            roomFacilityList.Add(new room_facility_data("EMU 2", "Triple room", "Bed", "Bunk"));
            roomFacilityList.Add(new room_facility_data("EMU 3", "Normal double room", "Bed", "Bunk"));
            roomFacilityList.Add(new room_facility_data("EMU 3", "Corner single room", "Bed", "Bunk"));
            roomFacilityList.Add(new room_facility_data("EMU 3", "Corner double room", "Bed", "Bunk"));
            roomFacilityList.Add(new room_facility_data("EMU 4", "Quadruple room", "Bed", "Bunk"));

            roomFacilityList.Add(new room_facility_data("Alfam", "C Block single room", "Bed", "Normal"));
            roomFacilityList.Add(new room_facility_data("Alfam", "C Block double room", "Bed", "Normal"));
            roomFacilityList.Add(new room_facility_data("Alfam", "Vista double room(Balcony)", "Bed", "Normal"));
            roomFacilityList.Add(new room_facility_data("Uğursal", "Single room", "Bed", "Normal"));

            roomFacilityList.Add(new room_facility_data("Uğursal", "Double room", "Bed", "Normal"));

            roomFacilityList.Add(new room_facility_data("Marmara", "Single room", "Bed", "Normal"));
            roomFacilityList.Add(new room_facility_data("Marmara", "Double room", "Bed", "Normal"));
            roomFacilityList.Add(new room_facility_data("Akdeniz", "Single room", "Bed", "Normal"));
            roomFacilityList.Add(new room_facility_data("Akdeniz", "Double room", "Bed", "Normal"));
            roomFacilityList.Add(new room_facility_data("Longson", "Single room", "Bed", "Normal"));
            roomFacilityList.Add(new room_facility_data("Longson", "Double room", "Bed", "Normal"));
            roomFacilityList.Add(new room_facility_data("Homedorm", "Single room", "Bed", "Normal"));
            roomFacilityList.Add(new room_facility_data("Homedorm", "Double room", "Bed", "Normal"));
            roomFacilityList.Add(new room_facility_data("Ramen", "Single room", "Bed", "Normal"));
            roomFacilityList.Add(new room_facility_data("Ramen", "Double room", "Bed", "Normal"));
            roomFacilityList.Add(new room_facility_data("Prime Living", "1 + 1 Suite", "Bed", "Normal"));
            roomFacilityList.Add(new room_facility_data("Prime Living", "Double room", "Bed", "Normal"));
            roomFacilityList.Add(new room_facility_data("Golden Plus", "Single room with balcony", "Bed", "Normal"));
            roomFacilityList.Add(new room_facility_data("Golden Plus", "Double room with balcony", "Bed", "Normal"));
            roomFacilityList.Add(new room_facility_data("Kamacıoğlu", "Single room", "Bed", "Normal"));
            roomFacilityList.Add(new room_facility_data("Kamacıoğlu", "Double room", "Bed", "Normal"));




            using (fees_and_facilitiesEntities4 context = new fees_and_facilitiesEntities4())
            {

                foreach (room_facility_data data in roomFacilityList)
                {
                    facility_table facility = context.facility_table
                        .FirstOrDefault(f => f.id == f.facility_table_translation
                        .FirstOrDefault(k => k.facility_title == data.facility_title).facility_table_non_trans_id);


                    dormitories_table dormitory = context.dormitories_table
                        .FirstOrDefault(d => d.id == d.dormitories_table_translation
                        .FirstOrDefault(t => t.dormitory_name == data.dormitory_name).dormitories_table_non_trans_id);

                    room_table room = context.room_table
                        .FirstOrDefault(r => r.dormitory_id == dormitory.id && r.room_table_translation
                        .FirstOrDefault(n => n.room_type == data.room_type).room_table_non_trans_id == r.id);



                    if (data.facility_option == "null")
                        facility_option_int_id = 0;
                    else
                    {
                        facility_option facility_Option = context.facility_option
                            .FirstOrDefault(o => o.facility_id == facility.id && o.facility_option_translation
                            .FirstOrDefault(ot => ot.facility_option == data.facility_option).facility_option_non_trans_id == o.id);

                        //if option is null;
                        facility_option_int_id = facility_Option.id;

                    }

                    //facility_option_id ==0
                    context.room_facility.Add(new room_facility { facility_id = facility.id, room_id = room.id, facility_option_id = facility_option_int_id });
                    context.SaveChanges();
                }
            }
        }
        static void rooms_initiate()
        {
            ArrayList rooms = new ArrayList();

            rooms.Add(new room_data(
                "https://dormitories.emu.edu.tr/PhotoGalleries/dormitories/2016/ugursal/IMG_1220.JPG?RenditionID=7",
               "Uğursal",
               2500,
               2700,
               25,
               "Double room",
               "Iki KiŞilik",
                "Double room",
               "Iki KiŞilik"

        ));


            rooms.Add(new room_data(
                "https://dormitories.emu.edu.tr/PhotoGalleries/dormitories/2016/dau-1/img_0868.jpg?RenditionID=7",
            "EMU 1",
            2200,
            2400,
            15,
            "Triple room",
            "ÜÇ Kişilik",
            "Triple room",
            "ÜÇ Kişilik"

             ));


            rooms.Add(new room_data(
                "https://dormitories.emu.edu.tr/PhotoGalleries/dormitories/2016/dau-1/img_0919.jpg?RenditionID=7",
           "EMU 1",
           2640,
           2840,
           28,
           "Quadruple room",
           "Dört Kişilik Stüdyo",
           "Quadruple room",
           "Dört Kişilik Stüdyo"


             ));

            rooms.Add(new room_data(
                "https://dormitories.emu.edu.tr/PhotoGalleries/dormitories/2016/sabanci/img_0851.jpg?RenditionID=7",
                "EMU Sabanci",
                2200,
                2400,
                15,
                "Triple room",
                "ÜÇ Kişilik",
                "Triple room",
                "ÜÇ Kişilik"


             ));

            rooms.Add(new room_data(
                "https://dormitories.emu.edu.tr/PhotoGalleries/dormitories/2016/dau-2/img_0790.jpg?RenditionID=7",
                "EMU 2",
                3160,
                3400,
                20,
                "Special Double room",
                "Özel lki Kişilik",
                "Special Double room",
                "Özel lki Kişilik"


             ));


            rooms.Add(new room_data(
                "https://dormitories.emu.edu.tr/PhotoGalleries/dormitories/2016/dau-2/img_0795.jpg?RenditionID=7",
                "EMU 2",
                2300,
                2480,
                27,
                "Triple room",
                "ÜÇ Kişilik",
                "Triple room",
                "ÜÇ Kişilik"


             ));


            rooms.Add(new room_data(
                "https://dormitories.emu.edu.tr/PhotoGalleries/dormitories/2016/dau-3/img_1049.jpg?RenditionID=7",
                "EMU 3",
                2700,
                2920,
                12,
                "Normal double room",
                "Normal İki Kişilik",
                "Normal double room",
                "Normal İki Kişilik"


             ));


            rooms.Add(new room_data(
                "https://dormitories.emu.edu.tr/PhotoGalleries/dormitories/2016/dau-3/img_1047.jpg?RenditionID=7",
                "EMU 3",
                4500,
                4840,
                10,
                "Corner single room",
                "Köşe Oda Tek Kişilik",
                "Corner single room",
                "Köşe Oda Tek Kişilik"




             ));



            rooms.Add(new room_data(
                "https://dormitories.emu.edu.tr/PhotoGalleries/dormitories/2016/dau-3/img_1040.jpg?RenditionID=7",
               "EMU 3",
               2500,
               2880,
               10,
               "Corner double room",
               "Köşe Oda İki Kişilik",
               "Corner double room",
               "Köşe Oda İki Kişilik"



            ));


            rooms.Add(new room_data(
                "https://dormitories.emu.edu.tr/PhotoGalleries/dormitories/2016/dau-4/img_1014.jpg?RenditionID=7",
                "EMU 4",
                2040,
                2200,
                30,
                "Quadruple room",
                "Dört Kişilik",
                "Quadruple room",
                "Dört Kişilik"


             ));


            rooms.Add(new room_data(
                "https://en.alfamcyprus.com/thumbnail.php?file=pics/pics_rooms/Room_2/bcb0b91c806d560dceaa9b051b8bcfb7.jpg&pwidth=475&pheight=313&pw=570.0000&ph=375.0000&px=0.0000&py=3.0000&pscale=0.2969&pangle=0.0000&force=y",
                "Alfam",
                3500,
                3675,
                13,
                "C Block single room",
                "C Blok Tek Kişilik",
                "C Block single room",
                "C Blok Tek Kişilik"


             ));


            rooms.Add(new room_data(
                "https://dormitories.emu.edu.tr//PublishingImages/Dormitories/alfam/8.jpg?RenditionID=4",
                "Alfam",
                2300,
                2415,
                21,
                "C Block double room",
                "C Blok Iki Kişilik",
                "C Block double room",
                "C Blok Iki Kişilik"


             ));


            rooms.Add(new room_data(
                "https://dormitories.emu.edu.tr//PhotoGalleries/dormitories/2016/alfam-vista/dsc_3852.jpg?RenditionID=4",
                "Alfam",
                3600,
                3780,
                30,
                "Vista double room(Balcony)",
                "Vista Iki KiŞilik(Balkonlu)",
                "Vista double room(Balcony)",
                "Vista Iki KiŞilik(Balkonlu)"

             ));

            rooms.Add(new room_data(
                "https://dormitories.emu.edu.tr/PhotoGalleries/dormitories/2016/ugursal/img_1224.jpg?RenditionID=7",
                "Uğursal",
                4600,
                4900,
                25,
                "Single room",
                "Tek KiŞilik",
                "Single room",
                "Tek KiŞilik"



         ));
            


            rooms.Add(new room_data(
                "https://dormitories.emu.edu.tr/PhotoGalleries/dormitories/2016/marmara/img_1298.jpg?RenditionID=7",
            "Marmara",
            4600,
            4900,
            29,
            "Single room",
            "Tek KiŞilik",
            "Single room",
            "Tek KiŞilik"

         ));



            rooms.Add(new room_data(
                "https://dormitories.emu.edu.tr/PhotoGalleries/dormitories/2016/marmara/img_1304.jpg?RenditionID=7",
        "Marmara",
        2500,
        2700,
        29,
        "Double room",
        "Iki KiŞilik",
        "Double room",
        "Iki KiŞilik"

         ));

            rooms.Add(new room_data(
                "https://dormitories.emu.edu.tr/PhotoGalleries/dormitories/2016/akdeniz/img_1260.jpg?RenditionID=7",
                "Akdeniz",
                4500,
                4850,
                24,
                "Single room",
                "Tek KiŞilik",
                "Single room",
                "Tek KiŞilik"

         ));

            rooms.Add(new room_data(
                "https://dormitories.emu.edu.tr/PhotoGalleries/dormitories/2016/akdeniz/img_1268.jpg?RenditionID=7",
            "Akdeniz",
            2500,
            2750,
            24,
            "Double room",
            "Iki KiŞilik",
            "Double room",
            "Iki KiŞilik"


         ));


            rooms.Add(new room_data(
                "https://dormitories.emu.edu.tr/PhotoGalleries/dormitories/2016/longson/IMG_4820.jpg?RenditionID=7",
                "Longson",
                4600,
                4850,
                21,
                "Single room",
                "Tek KiŞilik",
                "Single room",
                "Tek KiŞilik"


         ));


            rooms.Add(new room_data(
                "https://dormitories.emu.edu.tr/PhotoGalleries/dormitories/2016/longson/IMG_1916.jpg?RenditionID=7",
                "Longson",
                2500,
                2750,
                21,
                "Double room",
                "Iki KiŞilik",
                "Double room",
                "Iki KiŞilik"

         ));

            rooms.Add(new room_data(
                "https://dormitories.emu.edu.tr/PhotoGalleries/dormitories/2016/homedorm/img_1403.jpg?RenditionID=7",
                "Homedorm",
                4850,
                5100,
                24,
                "Single room",
                "Tek KiŞilik",
                "Single room",
                "Tek KiŞilik"

         ));

            rooms.Add(new room_data(
                "https://dormitories.emu.edu.tr/PhotoGalleries/dormitories/2016/homedorm/img_1398.jpg?RenditionID=7",
                "Homedorm",
                2850,
                3100,
                24,
                "Double room",
                "Iki KiŞilik",
                "Double room",
                "Iki KiŞilik"

         ));

            rooms.Add(new room_data(
                "https://dormitories.emu.edu.tr/PhotoGalleries/dormitories/2016/ramen/IMGL7923.jpg?RenditionID=7",
                "Ramen",
                5000,
                5250,
                22,
                "Single room",
                "Tek KiŞilik",
                "Single room",
                "Tek KiŞilik"

        ));

            rooms.Add(new room_data(
                "https://dormitories.emu.edu.tr/PhotoGalleries/dormitories/2016/ramen/IMGL7903.jpg?RenditionID=7",
                "Ramen",
                2950,
                3150,
                22,
                "Double room",
                "Iki KiŞilik",
                "Double room",
                "Iki KiŞilik"

        ));

            rooms.Add(new room_data(
                "https://dormitories.emu.edu.tr/PhotoGalleries/dormitories/2016/prime-living/DSC01418_.jpg?RenditionID=7",
                "Prime Living",
                4290,
                4690,
                55,
                "1 + 1 Suite",
                "1 + 1 Suit",
                "1 + 1 Suite",
                "1 + 1 Suit"


        ));

            rooms.Add(new room_data(
                "https://dormitories.emu.edu.tr/PhotoGalleries/dormitories/2016/prime-living/image-0-02-01-ad033a534acfbb02f9c4c226a5273c5a884bb8984535896319766bfcf2016459-V.jpg?RenditionID=7",
                "Prime Living",
                2990,
                3290,
                27,
                "Double room",
                "Iki KiŞilik",
                "Double room",
                "Iki KiŞilik"

        ));

            rooms.Add(new room_data(
                "https://dormitories.emu.edu.tr/PhotoGalleries/dormitories/2017/golden-plus/oda-ici-3.PNG?RenditionID=7",
                "Golden Plus",
                5200,
                5600,
                24,
                "Single room with balcony",
                "Tek KiŞilik Balkonlu",
                "Single room with balcony",
                "Tek KiŞilik Balkonlu"

        ));

            rooms.Add(new room_data(
                "https://dormitories.emu.edu.tr/PhotoGalleries/dormitories/2017/golden-plus/oda-ici-2.PNG?RenditionID=7",
                "Golden Plus",
                2950,
                3200,
                30,
                "Double room with balcony",
                "Iki KiŞilik Balkonlu",
                "Double room with balcony",
                "Iki KiŞilik Balkonlu"

        ));

            rooms.Add(new room_data(
                "https://dormitories.emu.edu.tr/PhotoGalleries/dormitories/2017/kamacioglu/STANDART_1.jpg?RenditionID=7",
                "Kamacıoğlu",
                4400,
                4500,
                22,
                "Single room",
                "Tek KiŞilik",
                "Single room",
                "Tek KiŞilik"

        ));

            rooms.Add(new room_data(
                "https://dormitories.emu.edu.tr/PhotoGalleries/dormitories/2017/kamacioglu/S%C3%9C%C4%B0T_1.jpg?RenditionID=7",
                "Kamacıoğlu",
                2400,
                2500,
                22,
                "Double room",
                "Iki KiŞilik",
                "Double room",
                "Iki KiŞilik"


        ));




            using (fees_and_facilitiesEntities4 context = new fees_and_facilitiesEntities4())
            {


                language_table language_Table_EN = context.language_table.FirstOrDefault(l => l.language_code == "EN");
                language_table language_Table_TR = context.language_table.FirstOrDefault(l => l.language_code == "TR");


                foreach (room_data data in rooms)
                {
                    //we have to query dormitory_id.

                    dormitories_table dormitory = context.dormitories_table
                    .FirstOrDefault(d => d.id == d.dormitories_table_translation
                    .FirstOrDefault(c => c.dormitory_name == data.dormitory_name)
                    .dormitories_table_non_trans_id);

                    room_table room = new room_table
                    {
                        dormitory_id = dormitory.id,
                        room_picture_url = data.room_picture_url,
                        room_price = data.room_price,
                        room_price_installment = data.room_price_installment,
                        room_area = data.room_area
                    };

                    context.room_table.Add(room);
                    context.SaveChanges();

                    //English
                    context.room_table_translation.Add(new room_table_translation
                    {
                        language_id = language_Table_EN.id,
                        room_table_non_trans_id = room.id,
                        room_type = data.room_type_EN,
                        room_title = data.room_title_EN
                    });
                    context.SaveChanges();

                    //Turkish
                    context.room_table_translation.Add(new room_table_translation
                    {
                        language_id = language_Table_TR.id,
                        room_table_non_trans_id = room.id,
                        room_type = data.room_type_TR,
                        room_title = data.room_title_TR
                    });

                    context.SaveChanges();


                }

            }

        }

        static void facilities_and_options_data()
        {

            ArrayList facilityList = new ArrayList();
            ArrayList option_list;

            option_list = new ArrayList();
            option_list.Add(new facility_options("Heating", "Isıtma"));
            option_list.Add(new facility_options("Cooling", "Soğutma"));
            facilityList.Add(new facility_data(
                                "../../Content/Dormitories_files/airCondition.png",
                                "Central conditioning system",
                                "Merkezi Isıtma",
                               option_list));


            option_list = new ArrayList();
            facilityList.Add(new facility_data(
                                   "../../Content/Dormitories_files/refridgerator.png",
                                "Refrigerator",
                                "Buzdolabı",
                               option_list));

            option_list = new ArrayList();
            facilityList.Add(new facility_data(
                                  "../../Content/Dormitories_files/airCondition.png",
                                "Air-condition",
                                "Klima",
                               option_list));

            option_list = new ArrayList();
            facilityList.Add(new facility_data(
                                "../../Content/Dormitories_files/room_tel.png",
                                "Room tel.",
                                "Oda Telefonmu",
                               option_list));


            option_list = new ArrayList();
            facilityList.Add(new facility_data(
                                "../../Content/Dormitories_files/generator.png",
                                "Generator",
                                "Jeneratör",
                               option_list));

            option_list = new ArrayList();
            facilityList.Add(new facility_data(
                                 "../../Content/Dormitories_files/cafeteria.png",
                                "Cafeteria",
                                "Kafeterya",
                               option_list));


            option_list = new ArrayList();
            facilityList.Add(new facility_data(
                              "../../Content/Dormitories_files/laundry.png",
                                "Laundry",
                                "Çamaşırhane",
                               option_list));


            option_list = new ArrayList();
            option_list.Add(new facility_options("Cable", "Kablolu"));
            option_list.Add(new facility_options("Wireless", "Kablosuz"));
            facilityList.Add(new facility_data(
                                 "../../Content/Dormitories_files/internet_wifi.png",
                               "Internet",
                                "Internet",
                               option_list));


            option_list = new ArrayList();
            option_list.Add(new facility_options("Bunk", "Ranza"));
            option_list.Add(new facility_options("Normal", "Normal"));
            facilityList.Add(new facility_data(
                                "../../Content/Dormitories_files/bed.png",
                                   "Bed",
                                "Yatak Türü",

                               option_list));

            option_list = new ArrayList();
            option_list.Add(new facility_options("In room", "Odada"));
            option_list.Add(new facility_options("Flats", "Katta"));
            facilityList.Add(new facility_data(
                                "../../Content/Dormitories_files/stove.png",
                               "Kitchenette",
                                "Mutfak",
                               option_list));



            option_list = new ArrayList();
            option_list.Add(new facility_options("In room", "Odada"));
            option_list.Add(new facility_options("Common", "Ortak"));
            option_list.Add(new facility_options("Flats", "Katta"));
            facilityList.Add(new facility_data(
                                 "../../Content/Dormitories_files/wc-shower.png",
                               "WC-shower",
                                "WC - Duş",
                               option_list));

            option_list = new ArrayList();
            option_list.Add(new facility_options("In room", "Odada"));
            option_list.Add(new facility_options("In Hall", "Salonda"));
            facilityList.Add(new facility_data(
                                  "../../Content/Dormitories_files/tv.png",
                               "TV",
                                "TV",
                               option_list));




            using (fees_and_facilitiesEntities4 context = new fees_and_facilitiesEntities4())
            {

                foreach (facility_data data in facilityList)
                {

                    language_table language_Table_EN = context.language_table.FirstOrDefault(l => l.language_code == "EN");
                    language_table language_Table_TR = context.language_table.FirstOrDefault(l => l.language_code == "TR");

                    facility_table facility = new facility_table { facility_icon_url = data.facility_icon_url };
                    context.facility_table.Add(facility);
                    context.SaveChanges();




                    //English


                    context.facility_table_translation.Add(new facility_table_translation
                    {
                        facility_table_non_trans_id = facility.id,
                        facility_title = data.facility_title_en,
                        language_id = language_Table_EN.id,
                        facility_description = ""
                    });
                    context.SaveChanges();


                    //Turkish

                    context.facility_table_translation.Add(new facility_table_translation
                    {
                        facility_table_non_trans_id = facility.id,
                        facility_title = data.facility_title_tr,
                        language_id = language_Table_TR.id,
                        facility_description = ""
                    });
                    context.SaveChanges();



                    //down here insert in facility_option, then translate, repeat for all elements
                    foreach (facility_options dataOptions in data.facility_options_list)
                    {

                        facility_option facility_Option = new facility_option { facility_id = facility.id };


                        context.facility_option.Add(facility_Option);
                        context.SaveChanges();


                        context.facility_option_translation.Add(new facility_option_translation
                        {
                            facility_option_non_trans_id = facility_Option.id,
                            language_id = language_Table_EN.id,
                            facility_option = dataOptions.facility_option_EN,
                            facility_option_description = ""

                        });
                        context.SaveChanges();


                        context.facility_option_translation.Add(new facility_option_translation
                        {
                            facility_option_non_trans_id = facility_Option.id,
                            language_id = language_Table_TR.id,
                            facility_option = dataOptions.facility_option_TR,
                            facility_option_description = ""

                        });
                        context.SaveChanges();

                    }




                }


            }



        }


        static void languageInitiate()
        {
            using (fees_and_facilitiesEntities4 context = new fees_and_facilitiesEntities4())
            {

                //   Adding the two languages done
                context.language_table.Add(new language_table { name = "English Language", language_code = "EN" });
                context.language_table.Add(new language_table { name = "Turkish Language", language_code = "TR" });
                context.SaveChanges();
            }

        }

        static void dormitories_types_initiate()
        { //dormitories_types_initiate done


            using (fees_and_facilitiesEntities4 context = new fees_and_facilitiesEntities4())
            {
                context.dormitory_type.Add(new dormitory_type { });
                context.SaveChanges();
                dormitory_type dormitory_Type = context.dormitory_type.FirstOrDefault(l => l.id > 0);
                language_table language_Table_EN = context.language_table.FirstOrDefault(l => l.language_code == "EN");
                context.dormitory_type_translation.Add(new dormitory_type_translation
                { language_id = language_Table_EN.id, dormitory_type_non_trans_id = dormitory_Type.id, type_name = "Eastern Mediterranean University Dormitories on Campus Residence" });
                //   context.SaveChanges();

                language_table language_Table_TR = context.language_table.FirstOrDefault(l => l.language_code == "TR");
                //context.dormitory_type_translation.Add(new dormitory_type_translation
                //{ language_id = language_Table_TR.id, dormitory_type_non_trans_id = dormitory_Type.id, type_name = "DAÜ Yurtları (DAÜ Yutlarında Kayıtlar Dönemlik Yapılmaktadır)" });
                //context.SaveChanges();


                context.dormitory_type.Add(new dormitory_type { });
                context.SaveChanges();

                dormitory_type dormitory_Type1 = context.dormitory_type.FirstOrDefault(l => l.id > 1);


                context.dormitory_type_translation.Add(new dormitory_type_translation
                { language_id = language_Table_EN.id, dormitory_type_non_trans_id = dormitory_Type1.id, type_name = "EMU BOT (build-operate-transfer) Dormitories on Campus Residence" });

                context.dormitory_type_translation.Add(new dormitory_type_translation
                { language_id = language_Table_TR.id, dormitory_type_non_trans_id = dormitory_Type1.id, type_name = "DAÜ Yap - İşlet - Devret Yurtları (YİD Yurtlarına Kayıtlar Yıllık" });
                context.SaveChanges();

            }



        }

        static void dormitories_initiate()
        {
            using (fees_and_facilitiesEntities4 context = new fees_and_facilitiesEntities4())
            {
                ArrayList dormitoriesList = new ArrayList();
                dormitoriesList.Add(new dormitory_data(
                    "Eastern Mediterranean University Dormitories on Campus Residence",

                    "TL",
                    "&#8378;",
                    "",
                    "for male Students",
                    "Per semester",
                    "EMU 1",

                    "Erkek Yurdu",
                    "Dönemlik",
                    "DAÜ 1"));

                dormitoriesList.Add(new dormitory_data(
                         "Eastern Mediterranean University Dormitories on Campus Residence",

                         "TL",
                         "&#8378;",
                         "",
                         "For female",
                         "Per semester",
                         "EMU Sabanci",
                          "Kız Yurdu",
                         "Dönemlik",
                         "DAÜ Sabancı Yurdu"
                         ));

                dormitoriesList.Add(new dormitory_data(
                   "Eastern Mediterranean University Dormitories on Campus Residence",

                   "TL",
                   "&#8378;",
                   "",
                   "for male students",
                   "Per semester",
                   "EMU 2",
                   "Erkek Yurdu",
                   "Dönemlik",
                   "DAÜ 2"));


                dormitoriesList.Add(new dormitory_data(
                   "Eastern Mediterranean University Dormitories on Campus Residence",

                   "TL",
                   "&#8378;",
                   "",
                   "separate blocks for female and male students",
                   "Per semester",
                   "EMU 3",
                    "Kız/Erkek Bloklan",
                   "Dönemlik",
                   "DAÜ 3"));

                dormitoriesList.Add(new dormitory_data(
                   "Eastern Mediterranean University Dormitories on Campus Residence",

                   "TL",
                   "&#8378;",
                   "",
                   "for female students",
                   "Per semester",
                   "EMU 4",
                   "Kız Yurdu",
                   "Dönemlik",
                   "DAÜ 4 Yurdu"));

                dormitoriesList.Add(new dormitory_data(
                   "EMU BOT (build-operate-transfer) Dormitories on Campus Residence",

                   "USD",
                   "&#36;",
                   "",
                   "For female and male students on separate floors",
                   "Academic Year",
                   "Alfam",
                   "Kız/Erkek Katları",
                   "Akademik Yıl",
                   "Alfam Öğrenci Yurdu"));


                dormitoriesList.Add(new dormitory_data(
                   "EMU BOT (build-operate-transfer) Dormitories on Campus Residence",

                   "USD",
                   "&#36;",
                   "",
                   "For female and male students on separate floors",
                   "Academic Year",
                   "Uğursal",
                   "Kız/Erkek Katları",
                   "Akademik Yıl",
                   "Uğursal  Öğrenci Yurdu"));


                dormitoriesList.Add(new dormitory_data(
                   "EMU BOT (build-operate-transfer) Dormitories on Campus Residence",

                   "USD",
                   "&#36;",
                   "",
                   "For female and male students on separate floors",
                   "Academic Year",
                   "Marmara",
                   "Kız/Erkek Katları",
                   "Akademik Yıl",
                   "Marmara  Öğrenci Yurdu"));


                dormitoriesList.Add(new dormitory_data(
                   "EMU BOT (build-operate-transfer) Dormitories on Campus Residence",

                   "USD",
                   "&#36;",
                   "",
                   "For female and male students in separate blocks",
                   "Academic Year",
                   "Akdeniz",
                   "Kız/Erkek Blokları",
                   "Akademik Yıl",
                   "Akdeniz  Öğrenci Yurdu"));

                dormitoriesList.Add(new dormitory_data(
                   "EMU BOT (build-operate-transfer) Dormitories on Campus Residence",

                   "USD",
                   "&#36;",
                   "",
                   "For female and male students on separate blocks",
                   "Academic Year",
                   "Longson",
                   "Kız/Erkek Blokları",
                   "Akademik Yıl",
                   "Longson  Öğrenci Yurdu"));


                dormitoriesList.Add(new dormitory_data(
                   "EMU BOT (build-operate-transfer) Dormitories on Campus Residence",

                   "USD",
                   "&#36;",
                   "",
                   "For female and male students in separate blocks",
                   "Academic Year",
                   "Homedorm",
                   "Kız/Erkek Blokları",
                   "Akademik Yıl",
                   "Homedorm  Öğrenci Yurdu"));


                dormitoriesList.Add(new dormitory_data(
                   "EMU BOT (build-operate-transfer) Dormitories on Campus Residence",

                   "USD",
                   "&#36;",
                   "",
                   "For female and male students",
                   "Academic Year",
                   "Ramen",
                   "Kız/Erkek Blokları",
                   "Akademik Yıl",
                   "Ramen  Öğrenci Yurdu"));

                dormitoriesList.Add(new dormitory_data(
                   "EMU BOT (build-operate-transfer) Dormitories on Campus Residence",

                   "USD",
                   "&#36;",
                   "",
                   "For female and male students on separate blocks",
                   "Academic Year",
                   "Prime Living",
                   "Kız/Erkek Blokları",
                   "Akademik Yıl",
                   "Prime Living  Öğrenci Yurdu"));

                dormitoriesList.Add(new dormitory_data(
                   "EMU BOT (build-operate-transfer) Dormitories on Campus Residence",

                   "USD",
                   "&#36;",
                   "",
                   "For female and male students on separate blocks",
                   "Academic Year",
                   "Golden Plus",
                   "Kız/Erkek Blokları",
                   "Akademik Yıl",
                   "Golden Plus  Öğrenci Yurdu"));

                dormitoriesList.Add(new dormitory_data(
                   "EMU BOT (build-operate-transfer) Dormitories on Campus Residence",

                   "USD",
                   "&#36;",
                   "",
                   "For female and male students on separate blocks",
                   "Academic Year",
                   "Kamacıoğlu",
                   "Kız/Erkek Katları",
                   "Akademik Yıl",
                   "Kamacıoğlu Öğrenci Yurdu"));

                dormitories_table dormitory;

                foreach (dormitory_data data in dormitoriesList)
                {


                    dormitory_type dormitory_Type = context.dormitory_type
                        .FirstOrDefault(l => l.id == l.dormitory_type_translation
                        .FirstOrDefault(x => x.type_name == data.dormitory_type)
                        .dormitory_type_non_trans_id);

                    dormitory = new dormitories_table
                    {
                        dormitory_type_id = dormitory_Type.id,
                        room_price_currency = data.room_price_currency,
                        room_price_currency_symbol = data.room_price_currency_symbol
                    };

                    context.dormitories_table.Add(dormitory);
                    context.SaveChanges();

                    //English

                    language_table language_Table_EN = context.language_table.FirstOrDefault(l => l.language_code == "EN");
                    context.dormitories_table_translation.Add(new dormitories_table_translation
                    {
                        language_id = language_Table_EN.id,
                        dormitories_table_non_trans_id = dormitory.id,
                        dormitory_address = data.dormitory_address,
                        gender_allocation = data.gender_allocation_EN,
                        rooms_payment_period = data.rooms_payment_period_EN,
                        dormitory_name = data.dormitory_name_EN
                    });
                    //Turkish
                    language_table language_Table_TR = context.language_table.FirstOrDefault(l => l.language_code == "TR");
                    context.dormitories_table_translation.Add(new dormitories_table_translation
                    {
                        language_id = language_Table_TR.id,
                        dormitories_table_non_trans_id = dormitory.id,
                        dormitory_address = data.dormitory_address,
                        gender_allocation = data.gender_allocation_TR,
                        rooms_payment_period = data.rooms_payment_period_TR,
                        dormitory_name = data.dormitory_name_TR
                    });


                    context.SaveChanges();

                }
            }
        }


    }
}
