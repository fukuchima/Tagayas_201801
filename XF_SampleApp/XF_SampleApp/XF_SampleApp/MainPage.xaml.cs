using System;
using System.Reflection;
using Xamarin.Forms;

namespace XF_SampleApp
{
    public partial class MainPage : ContentPage
    {
        //クリック回数をカウントするための変数
        private int count = 0;
        private int maxCount = 10;

        public MainPage()
        {
            // 初期化処理
            InitializeComponent();

            // Imageにリソースに保存した画像を設定
            logo.Source = ImageSource.FromResource("XF_SampleApp.Resources.tagayas-logo-t_tp.png",Assembly.GetExecutingAssembly());
            // ボタンのクリックイベントを設定
            Button1.Clicked += Button1_Clicked;
        }

        //ボタンクリック時に呼び出されるメソッド
        private void Button1_Clicked(object sender, EventArgs e)
        {
            // クリック回数
            count += 1;
            // ラベルのメッセージを変更
            Label1.Text = String.Format("こんにちは Xamarin.Forms! \n {0} 回目",count);
            // プログレスバーを表示する処理
            double progress = count / (double)maxCount;
            ProgressBar1.ProgressTo(progress, 500, Easing.SpringIn);
            // 最大回数をクリックしたらカウントをクリア
            if (count >= maxCount)
            {
                count = 0;
            }
        }
    }
}
