using Android.App;
using Android.Widget;
using Android.OS;
using System;

namespace BMICalculator
{
    [Activity(Label = "BMICalculator", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
       
        string toast;
        double z;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            Spinner spinner = FindViewById<Spinner>(Resource.Id.spinner);
            Button bt = FindViewById<Button>(Resource.Id.button1);


            spinner.ItemSelected += new EventHandler<AdapterView.ItemSelectedEventArgs>(spinner_ItemSelected);
            var adapter = ArrayAdapter.CreateFromResource(
                    this, Resource.Array.age_array, Android.Resource.Layout.SimpleSpinnerItem);

            adapter.SetDropDownViewResource(Android.Resource.Layout.SimpleSpinnerDropDownItem);
            spinner.Adapter = adapter;

            bt.Click += Bt_Click;
        }
        private void Bt_Click(object sender, EventArgs e)
        {
            EditText et1 = FindViewById<EditText>(Resource.Id.editText1);
            EditText et2 = FindViewById<EditText>(Resource.Id.editText2);
            TextView tv1 = FindViewById<TextView>(Resource.Id.textView14);
            TextView tv2 = FindViewById<TextView>(Resource.Id.textView15);

            if (et1.Text == "" && et2.Text == "" || et1.Text == "" || et2.Text == "")
            {
                tv1.Text = "Please enter valid value";
                tv2.Text = string.Empty;
            }
            else
            {
                double x;
                double.TryParse(et1.Text, out x);
                double y;
                double.TryParse(et2.Text, out y);
                z = Math.Round(y / ((x / 100) * (x / 100)));

                if (toast == "5")
                {
                    tv1.Text = "BMI value is " + z +
                        "\nPlease check BMI value in below table";
                    tv2.Text = "Minor Girls BMI Range is 13 - 17.5" +
                        "\nMinor Boys BMI Range is 14 - 18";
                }
                else if (toast == "6")
                {
                    tv1.Text = "BMI value is " + z +
                        "\nPlease check BMI value in below table";
                    tv2.Text = "Minor Girls BMI Range is 13 - 18" +
                        "\nMinor Boys BMI Range is 14 - 18";
                }
                else if (toast == "7")
                {
                    tv1.Text = "BMI value is " + z +
                        "\nPlease check BMI value in below table";
                    tv2.Text = "Minor Girls BMI Range is 13 - 18.5" +
                        "\nMinor Boys BMI Range is 14 - 18";
                }
                else if (toast == "8")
                {
                    tv1.Text = "BMI value is " + z +
                        "\nPlease check BMI value in below table";
                    tv2.Text = "Minor Girls BMI Range is 13.5 - 19" +
                        "\nMinor Boys BMI Range is 14 - 19";
                }
                else if (toast == "9")
                {
                    tv1.Text = "BMI value is " + z +
                        "\nPlease check BMI value in below table";
                    tv2.Text = "Minor Girls BMI Range is 13.5 - 21" +
                        "\nMinor Boys BMI Range is 14.5 - 19.5";
                }
                else if (toast == "10")
                {
                    tv1.Text = "BMI value is " + z +
                        "\nPlease check BMI value in below table";
                    tv2.Text = "Minor Girls BMI Range is 14.5 - 22" +
                        "\nMinor Boys BMI Range is 14.5 - 20.5";
                }
                else if (toast == "11")
                {
                    tv1.Text = "BMI value is " + z +
                        "\nPlease check BMI value in below table";
                    tv2.Text = "Minor Girls BMI Range is 14.5 - 23" +
                        "\nMinor Boys BMI Range is 15 - 21.5";
                }
                else if (toast == "12")
                {
                    tv1.Text = "BMI value is " + z +
                        "\nPlease check BMI value in below table";
                    tv2.Text = "Minor Girls BMI Range is 15 - 24" +
                        "\nMinor Boys BMI Range is 15.5 - 22.5";
                }
                else if (toast == "13")
                {
                    tv1.Text = "BMI value is " + z +
                        "\nPlease check BMI value in below table";
                    tv2.Text = "Minor Girls BMI Range is 15.5 - 25" +
                        "\nMinor Boys BMI Range is 16 - 23.5";
                }
                else if (toast == "14")
                {
                    tv1.Text = "BMI value is " + z +
                        "\nPlease check BMI value in below table";
                    tv2.Text = "Minor Girls BMI Range is 16 - 25.5" +
                        "\nMinor Boys BMI Range is 16.5 - 24.5";
                }
                else if (toast == "15")
                {
                    tv1.Text = "BMI value is " + z +
                        "\nPlease check BMI value in below table";
                    tv2.Text = "Minor Girls BMI Range is 16.5 - 26" +
                        "\nMinor Boys BMI Range is 17 - 25";
                }
                else if (toast == "16")
                {
                    tv1.Text = "BMI value is " + z +
                        "\nPlease check BMI value in below table";
                    tv2.Text = "Minor Girls BMI Range is 16.5 - 26.5" +
                        "\nMinor Boys BMI Range is 17 - 26.5";
                }
                else if (toast == "17")
                {
                    tv1.Text = "BMI value is " + z +
                        "\nPlease check BMI value in below table";
                    tv2.Text = "Minor Girls BMI Range is 17 - 27" +
                        "\nMinor Boys BMI Range is 17 - 27";
                }
                else if (toast == "18 to 34")
                {
                    tv1.Text = "BMI value is " + z +
                        "\nPlease check BMI value in below table" +
                        "\nStandard BMI Range is 17 - 28" +
                        "\n";

                    tv2.Text = "Under Weight 15 - 16 (Class III)" +
                        "\n" +
                        "\nOver Weight" +
                        "\n29 (Class I)" +
                        "\n30 (Class II)" +
                        "\n31 - 32 (Class III)" +
                        "\n33 - 34 (Class IV)" +
                        "\n35 - 37 (Class V)" +
                        "\n38 - 41 (Class VI)" +
                        "\n42 - 43 (Class VII)";
                }
                else if (toast == "35 to 54")
                {
                    tv1.Text = "BMI value is " + z +
                        "\nPlease check BMI value in below table" +
                        "\nStandard BMI Range is 17 - 29" +
                        "\n";



                    tv2.Text = "Under Weight 15 - 16 (Class II)" +
                        "\n" +
                        "\nOver Weight" +
                        "\n30 - 31 (Class I)" +
                        "\n32 - 33 (Class II)" +
                        "\n34 - 36 (Class III)" +
                        "\n37 - 38 (Class IV)" +
                        "\n39 - 41 (Class V)" +
                        "\n42 - 43 (Class VI)";
                }
                else if (toast == "55 and above")
                {
                    tv1.Text = "BMI value is " + z +
                        "\nPlease check BMI value in below table" +
                        "\nStandard BMI Range is 17 - 30" +
                        "\n";

                    tv2.Text = "Under Weight 15 - 16 (Class I)" +
                       "\n" +
                       "\nOver Weight" +
                       "\n31 - 33 (Class I)" +
                       "\n34 - 36 (Class II)" +
                       "\n37 - 38 (Class III)" +
                       "\n39 - 40 (Class IV)" +
                       "\n41 - 43 (Class V)";
                }
                
            }
           
        }
      
    private void spinner_ItemSelected(object sender, AdapterView.ItemSelectedEventArgs e)
        {
            Spinner spinner = (Spinner)sender;

             toast = string.Format("{0}", spinner.GetItemAtPosition(e.Position));
            //Toast.MakeText(this, toast, ToastLength.Long).Show();
        }
  
    }
  
}

