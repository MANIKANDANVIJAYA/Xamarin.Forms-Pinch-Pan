using System;
using System.Collections.Generic;
using System.Text;
using FreshMvvm;
using Xamarin.Forms;

namespace VisualBooking
{
    public class MainPageModel : FreshBasePageModel
    {
        public override void Init(object initData)
        {
            base.Init(initData);
        }

        public Command OnTapGestureRecognizerTapped
        {
            get
            {
                return new Command(() =>
                {
                    try
                    {

                    }
                    catch (Exception)
                    {
                    }
                });
            }
        }
    }
}
