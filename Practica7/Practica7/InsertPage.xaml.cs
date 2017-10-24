using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SQLite;

namespace Practica7
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InsertPage : ContentPage
    {
        SQLiteConnection database;
        public InsertPage()
        {
            InitializeComponent();
            string db;
            db = DependencyService.Get<SQLI>().GetLocalFilePath("Practica7.db3");
            database = new SQLiteConnection(db);
        }

        private void Insert_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Matricula.Text))
            {
                DisplayAlert("Importante", "Ingresa Tu Matricula", "Ok");
            }
            else {
                if (string.IsNullOrEmpty(Nombre.Text))
                {
                    DisplayAlert("Importante", "Ingresa Tu Nombre", "Ok");
                }
                else
                {
                    if (string.IsNullOrEmpty(Ape_pat.Text))
                    {
                        DisplayAlert("Importante", "Ingresa Tu Apellido Paterno", "Ok");
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(Ape_mat.Text))
                        {
                            DisplayAlert("Importante", "Ingresa Tu Apellido Materno", "Ok");
                        }
                        else
                        {
                            if (string.IsNullOrEmpty(Direccion.Text))
                            {
                                DisplayAlert("Importante", "Ingresa Tu Direccion", "Ok");
                            }
                            else
                            {
                                if (string.IsNullOrEmpty(Telefono.Text))
                                {
                                    DisplayAlert("Importante", "Ingresa Tu Numero de Telefono", "Ok");
                                }
                                else
                                {
                                    if (string.IsNullOrEmpty(Carrera.Text))
                                    {
                                        DisplayAlert("Importante", "Ingresa Tu Carrera", "Ok");
                                    }
                                    else
                                    {
                                        if (string.IsNullOrEmpty(Semestre.Text))
                                        {
                                            DisplayAlert("Importante", "Ingresa Tu Semestre", "Ok");
                                        }
                                        else
                                        {
                                            if (string.IsNullOrEmpty(Correo.Text))
                                            {
                                                DisplayAlert("Importante", "Ingresa Tu Correo", "Ok");
                                            }
                                            else
                                            {
                                                if (string.IsNullOrEmpty(Github.Text))
                                                {
                                                    DisplayAlert("Importante", "Ingresa Tu Github", "Ok");
                                                }
                                                else
                                                {
                                                    if (Matricula.Text.Length == 8)
                                                    {
                                                        if (Telefono.Text.Length == 10) {

                                                            if (Correo.Text.Contains("@hotmail.com"))
                                                            {
                                                                try
                                                                {
                                                                    var datos = new DBPractica
                                                                    {
                                                                        Matricula = Convert.ToInt32(Matricula.Text),
                                                                        Nombre = Nombre.Text,
                                                                        ApellidoPaterno = Ape_pat.Text,
                                                                        ApellidoMaterno = Ape_mat.Text,
                                                                        Direccion = Direccion.Text,
                                                                        Telefono = Telefono.Text,
                                                                        Carrera = Carrera.Text,
                                                                        Semestre = Semestre.Text,
                                                                        Correo = Correo.Text,
                                                                        Github = Github.Text
                                                                    };
                                                                    database.Insert(datos);
                                                                    Navigation.PushAsync(new MainPage());
                                                                }
                                                                catch (Exception ex)
                                                                {

                                                                    DisplayAlert("Importante", "Ya Existe La matricula", "Ok");

                                                                }
                                                            }
                                                            else
                                                            {

                                                                if (Correo.Text.Contains("@gmail.com"))
                                                                {
                                                                    try
                                                                    {
                                                                        var datos = new DBPractica
                                                                        {
                                                                            Matricula = Convert.ToInt32(Matricula.Text),
                                                                            Nombre = Nombre.Text,
                                                                            ApellidoPaterno = Ape_pat.Text,
                                                                            ApellidoMaterno = Ape_mat.Text,
                                                                            Direccion = Direccion.Text,
                                                                            Telefono = Telefono.Text,
                                                                            Carrera = Carrera.Text,
                                                                            Semestre = Semestre.Text,
                                                                            Correo = Correo.Text,
                                                                            Github = Github.Text
                                                                        };
                                                                        database.Insert(datos);
                                                                        Navigation.PushAsync(new MainPage());
                                                                    }
                                                                    catch (Exception ex)
                                                                    {

                                                                        DisplayAlert("Importante", "Ya Existe La matricula", "Ok");

                                                                    }
                                                                }
                                                                else
                                                                {
                                                                    if (Correo.Text.Contains("@outlook.com"))
                                                                    {
                                                                        try
                                                                        {
                                                                            var datos = new DBPractica
                                                                            {
                                                                                Matricula = Convert.ToInt32(Matricula.Text),
                                                                                Nombre = Nombre.Text,
                                                                                ApellidoPaterno = Ape_pat.Text,
                                                                                ApellidoMaterno = Ape_mat.Text,
                                                                                Direccion = Direccion.Text,
                                                                                Telefono = Telefono.Text,
                                                                                Carrera = Carrera.Text,
                                                                                Semestre = Semestre.Text,
                                                                                Correo = Correo.Text,
                                                                                Github = Github.Text
                                                                            };
                                                                            database.Insert(datos);
                                                                            Navigation.PushAsync(new MainPage());
                                                                        }
                                                                        catch (Exception ex)
                                                                        {

                                                                            DisplayAlert("Importante", "Ya Existe La matricula", "Ok");

                                                                        }
                                                                    }
                                                                    else
                                                                    {
                                                                        DisplayAlert("Importante", "Su Correo debe de contener \n@hotmail.com \n@outlook.com \n@gmail.com", "Ok");
                                                                    }
                                                                }
                                                            }
                                                        }
                                                        else {
                                                            DisplayAlert("Importante","El Numero de telefono debe Tener 10 Digitos","Ok");
                                                        }

                                                    }
                                                    else {
                                                        DisplayAlert("Importante","La Matricula debe tener 8 Digitos","Ok");
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}