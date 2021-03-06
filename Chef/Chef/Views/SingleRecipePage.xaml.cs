﻿using Chef.Models;
using Chef.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Chef.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SingleRecipePage : ContentPage
    {
        public SingleRecipePage(Recipe recipe)
        {
            InitializeComponent();
            BindingContext = new SingleRecipeViewModel(recipe);
        }
    }
}