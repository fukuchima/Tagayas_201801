using Microsoft.AppCenter.Analytics;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using Xamarin.Forms;

namespace XF_ListView
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        // ListViewに表示する項目
        private ObservableCollection<listItem> _items;
        public ObservableCollection<listItem> Items
        {
            get { return _items; }
            set
            {
                if (_items != value)
                {
                    this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Items)));
                    _items = value;
                }
            }
        }

        // リストから選択された項目
        private listItem _selecteditem;
        public listItem selectedItem
        {
            get { return _selecteditem; }
            set
            {
                if (_selecteditem != value)
                {
                    _selecteditem = value;
                    this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(selectedItem)));
                    Analytics.TrackEvent(String.Format("イベント発生 →【{0}】を選択", selectedItem.title));

                    // RuntimePlatformで判断してプラットフォーム別のログ
                    if (Device.RuntimePlatform == Device.UWP)
                    {
                        Analytics.TrackEvent(String.Format("UWPのみのログ {0}", selectedItem.title));
                    }
                }


            }
        }

        // コンストラクタでデータをリスト化して作成
        public MainViewModel()
        {
            Items = new ObservableCollection<listItem>();

            for (int i = 0; i < 30; i++)
            {
                var item = new listItem();
                item.time = DateTime.Now;
                item.title = String.Format("項目：{0}", i);
                Items.Add(item);
            }

        }

    }
}
