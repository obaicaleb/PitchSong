using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PitchSong.DataModels;
using Xamarin.Forms;


namespace PitchSong
{
    public partial class MainPage : ContentPage
    {
        ObservableCollection<SongInfo> mylist;
        public MainPage()
        {
            InitializeComponent();
            mylist = new ObservableCollection<SongInfo>
            {
                new SongInfo{Name="Indescribable", Status="C"},
                new SongInfo{Name="If we Ever", Status="C#"},
                new SongInfo{Name="All we ask", Status="F"},
                new SongInfo{Name="Judgement Day", Status="D"},
                new SongInfo{Name="Truth on Us", Status="G"},

            };
            myListView.ItemsSource = mylist;
        }

        private void myListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
         {
             //  var song = e.SelectedItem as SongInfo;
            //   DisplayAlert("Selected", $"{song.Name}/n {song.Status}", "OK");
         }
        

        private void myListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            //var song = e.Item as SongInfo;
            //DisplayAlert("Tapped", $"{song.Name}/n{song.Status}", "OK");
        }

        private void MenuItem_Delete(object sender, EventArgs e)
        {
            var menuItem = sender as MenuItem;
            var song = menuItem.CommandParameter as SongInfo;
            mylist.Remove(song);
        }
        private void MenuItem_Edit(object sender, EventArgs e)
        {
            var menuItem = sender as MenuItem;
            var song = menuItem.CommandParameter as SongInfo;
            //DisplayAlert(song.Name, song.Status, "OK");
            foreach (var item in mylist.Where(i=>i.Name == song.Name))
            {
                item.Status = "Z";
            }
        }

        private void myListView_Refreshing(object sender, System.EventArgs e)
        {
            myListView.ItemsSource = null;
            myListView.ItemsSource = mylist;
            myListView.EndRefresh();
        }
    }

    
}
