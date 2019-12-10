using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace VisualBooking
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        int img1count = 0, img2count = 0, img3count = 0, img4count = 0,
            img5count = 0, img6count = 0, img7count = 0, img8count = 0,
            img9count = 0, img10count = 0, img11count = 0, img12count = 0,
            img13count = 0, img14count = 0, img15count = 0, img16count = 0;

        private void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                DisplayAlert("eFACiLiTY - Room Booking", "Your seat booked succesfully", "Ok");
                img1.Source = "chair_avaiable.png";
                img2.Source = "chair_avaiable.png";
                img3.Source = "chair_avaiable.png";
                img4.Source = "chair_avaiable.png";
                img5.Source = "chair_avaiable.png";
                img6.Source = "chair_avaiable.png";
                img7.Source = "chair_avaiable.png";
                img8.Source = "chair_avaiable.png";
                img9.Source = "chair_avaiable.png";
                img10.Source = "chair_avaiable.png";
                img11.Source = "chair_avaiable.png";
                img12.Source = "chair_avaiable.png";
                img13.Source = "chair_avaiable.png";
                img14.Source = "chair_avaiable.png";
                img15.Source = "chair_avaiable.png";
                img16.Source = "chair_avaiable.png";
            }
            catch (Exception)
            {

            }
        }

        public MainPage()
        {
            InitializeComponent();

            img1count = img2count = img3count = img4count = img5count = img6count = img7count = img8count =
            img9count = img10count = img11count = img12count = img13count = img14count = img15count = img16count = 0;
        }

        private void OnTapGestureRecognizerTapped1(object sender, EventArgs e)
        {
            try
            {
                if (img1count % 2 == 0)
                    img1.Source = "chair_unavaiable.png";
                else
                    img1.Source = "chair_avaiable.png";

                img1count++;
            }
            catch (Exception)
            {
            }
        }

        private void OnTapGestureRecognizerTapped2(object sender, EventArgs e)
        {
            try
            {
                if (img2count % 2 == 0)
                    img2.Source = "chair_unavaiable.png";
                else
                    img2.Source = "chair_avaiable.png";

                img2count++;
            }
            catch (Exception)
            {
            }
        }

        private void OnTapGestureRecognizerTapped3(object sender, EventArgs e)
        {
            try
            {
                if (img3count % 2 == 0)
                    img3.Source = "chair_unavaiable.png";
                else
                    img3.Source = "chair_avaiable.png";

                img3count++;
            }
            catch (Exception)
            {
            }
        }

        private void OnTapGestureRecognizerTapped4(object sender, EventArgs e)
        {
            try
            {
                if (img4count % 2 == 0)
                    img4.Source = "chair_unavaiable.png";
                else
                    img4.Source = "chair_avaiable.png";

                img4count++;
            }
            catch (Exception)
            {
            }
        }

        private void OnTapGestureRecognizerTapped5(object sender, EventArgs e)
        {
            try
            {
                if (img5count % 2 == 0)
                    img5.Source = "chair_unavaiable.png";
                else
                    img5.Source = "chair_avaiable.png";

                img5count++;
            }
            catch (Exception)
            {
            }
        }

        private void OnTapGestureRecognizerTapped6(object sender, EventArgs e)
        {
            try
            {
                if (img6count % 2 == 0)
                    img6.Source = "chair_unavaiable.png";
                else
                    img6.Source = "chair_avaiable.png";

                img6count++;
            }
            catch (Exception)
            {
            }
        }

        private void OnTapGestureRecognizerTapped7(object sender, EventArgs e)
        {
            try
            {
                if (img7count % 2 == 0)
                    img7.Source = "chair_unavaiable.png";
                else
                    img7.Source = "chair_avaiable.png";

                img7count++;
            }
            catch (Exception)
            {
            }
        }

        private void OnTapGestureRecognizerTapped8(object sender, EventArgs e)
        {
            try
            {
                if (img8count % 2 == 0)
                    img8.Source = "chair_unavaiable.png";
                else
                    img8.Source = "chair_avaiable.png";

                img8count++;
            }
            catch (Exception)
            {
            }
        }

        private void OnTapGestureRecognizerTapped9(object sender, EventArgs e)
        {
            try
            {
                if (img9count % 2 == 0)
                    img9.Source = "chair_unavaiable.png";
                else
                    img9.Source = "chair_avaiable.png";

                img9count++;
            }
            catch (Exception)
            {
            }
        }

        private void OnTapGestureRecognizerTapped10(object sender, EventArgs e)
        {
            try
            {
                if (img10count % 2 == 0)
                    img10.Source = "chair_unavaiable.png";
                else
                    img10.Source = "chair_avaiable.png";

                img10count++;
            }
            catch (Exception)
            {
            }
        }

        private void OnTapGestureRecognizerTapped11(object sender, EventArgs e)
        {
            try
            {
                if (img11count % 2 == 0)
                    img11.Source = "chair_unavaiable.png";
                else
                    img11.Source = "chair_avaiable.png";

                img11count++;
            }
            catch (Exception)
            {
            }
        }

        private void OnTapGestureRecognizerTapped12(object sender, EventArgs e)
        {
            try
            {
                if (img12count % 2 == 0)
                    img12.Source = "chair_unavaiable.png";
                else
                    img12.Source = "chair_avaiable.png";

                img12count++;
            }
            catch (Exception)
            {
            }
        }

        private void OnTapGestureRecognizerTapped13(object sender, EventArgs e)
        {
            try
            {
                if (img13count % 2 == 0)
                    img13.Source = "chair_unavaiable.png";
                else
                    img13.Source = "chair_avaiable.png";

                img13count++;
            }
            catch (Exception)
            {
            }
        }

        private void OnTapGestureRecognizerTapped14(object sender, EventArgs e)
        {
            try
            {
                if (img14count % 2 == 0)
                    img14.Source = "chair_unavaiable.png";
                else
                    img14.Source = "chair_avaiable.png";

                img14count++;
            }
            catch (Exception)
            {
            }
        }

        private void OnTapGestureRecognizerTapped15(object sender, EventArgs e)
        {
            try
            {
                if (img15count % 2 == 0)
                    img15.Source = "chair_unavaiable.png";
                else
                    img15.Source = "chair_avaiable.png";

                img15count++;
            }
            catch (Exception)
            {
            }
        }

        private void OnTapGestureRecognizerTapped16(object sender, EventArgs e)
        {
            try
            {
                if (img16count % 2 == 0)
                    img16.Source = "chair_unavaiable.png";
                else
                    img16.Source = "chair_avaiable.png";

                img16count++;
            }
            catch (Exception)
            {
            }
        }

    }
}
