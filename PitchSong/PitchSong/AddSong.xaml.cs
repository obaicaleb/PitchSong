using PitchSong.DataModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PitchSong
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddSong : ContentPage
    {
         ObservableCollection<SongInfo> mlist;

      

         public AddSong(ObservableCollection<SongInfo> list)
        {
            InitializeComponent();
            this.mlist = list;
            

        }

        public static object myList { get; private set; }

        async void Button_Clicked(object sender, EventArgs e)
        {
            // AddSong addSong = new AddSong();
            // ObservableCollection<SongInfo> list = new ObservableCollection<SongInfo>() ;
            /*AddSong.myList.Add(addSong);*/
            //await Navigation.PopAsync();
            SongInfo songInfo = new SongInfo();
            songInfo.Name = Sname.Text;
            songInfo.Status = Sstatus.Text;
            this.mlist.Add(songInfo);
            await Navigation.PushAsync(new MainPage(mlist));
        }
    }
}