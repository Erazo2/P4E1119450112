using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SQLite;
using P4E1119450112.Controllesr;
using P4E1119450112.Models;
using System.IO;

namespace P4E1119450112
{
    public partial class App : Application
    {
        static Controllesr.ubicaControllers database;

        public static Controllesr.ubicaControllers Database
        {
            get
            {
                if (database == null)
                {
                    var pathdatabase = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                    var dbname = "examen.1";
                    var fullpath = Path.Combine(pathdatabase, dbname);
                    database = new Controllesr.ubicaControllers(fullpath);
                }
                return database;
            }

        }

             

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new PagePrincipal());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
