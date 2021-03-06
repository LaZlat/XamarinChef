using Chef.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Chef.ViewModels
{
    public class SingleRecipeViewModel : DefaultViewMode
    {
        public Recipe TheRecipe { get; set; }
        public Image NewImage { get; set; }
        public SingleRecipeViewModel(Recipe recipe)
        {
            this.TheRecipe = recipe;
        }
        public SingleRecipeViewModel()
        {
        }
    }
}
