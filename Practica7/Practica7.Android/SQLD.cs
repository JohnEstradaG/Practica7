﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using SQLite;
using Practica7.Droid;

[assembly: Dependency(typeof(SQLD))]
namespace Practica7.Droid
{
    public class SQLD : SQLI
    {
        public string GetLocalFilePath(string Filename)
        {
            string path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            return Path.Combine(path, Filename);
        }
    }
}