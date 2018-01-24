using System;
using System.Reflection;
using Xamarin.Forms;

namespace XF_SampleApp
{
    public partial class MainPage : ContentPage
    {
        private int count = 0;
        private int maxCount = 10;

        public MainPage()
        {
            InitializeComponent();
            logo.Source = ImageSource.FromResource("XF_SampleApp.Resources.tagayas-logo-t_tp.png",Assembly.GetExecutingAssembly());
            Button1.Clicked += Button1_Clicked;
        }

        private void Button1_Clicked(object sender, EventArgs e)
        {
            count += 1;
            Label1.Text = String.Format("こんにちは Xamarin.Forms! \n {0} 回目",count);
            double progress = count / (double)maxCount;
            ProgressBar1.ProgressTo(progress, 500, Easing.SpringIn);

            if (count >= maxCount)
            {
                count = 0;
            }
        }
    }
}
