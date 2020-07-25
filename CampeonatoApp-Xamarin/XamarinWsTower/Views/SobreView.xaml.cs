﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinWsTower.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SobreView : ContentPage
    {
        public SobreView()
        {
            InitializeComponent();

            // Remove App Bar
            NavigationPage.SetHasNavigationBar(this, true);
        }
    }
}