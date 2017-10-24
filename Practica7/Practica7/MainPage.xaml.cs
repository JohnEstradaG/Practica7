using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using SQLite;
using System.Collections.ObjectModel;

namespace Practica7
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<DBPractica> Items { get; set; }
        SQLiteConnection database;
        public MainPage()
        {
            InitializeComponent();
            string db = DependencyService.Get<SQLI>().GetLocalFilePath("Practica7.db3");
            database = new SQLiteConnection(db);
            database.CreateTable<DBPractica>();

            Items = new ObservableCollection<DBPractica>(database.Table<DBPractica>());
            BindingContext = this;
        }

        async void Handle_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;
                await Navigation.PushAsync(new UpdatePage(e.SelectedItem as DBPractica));
        }

        private void Insertar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new InsertPage());
        }
    }
}
