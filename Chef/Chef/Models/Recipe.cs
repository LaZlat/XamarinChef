using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace Chef.Models
{
    public class Recipe
    {
        private ObservableCollection<Ingridient> ingridients;

        public string Title { get; set; }
        public string Image { get; set; }
        public ImageSource ImgSource { get; set; } 
        public string HowToMake { get; set; }
        public ObservableCollection<Ingridient> Ingridients { get => ingridients; set => ingridients = value; }
    }
}
