using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Chef.Models
{
    class Recipe
    {
        private ObservableCollection<Ingridient> ingridients;

        public string Title { get; set; }
        public string Image { get; set; }
        public string HowToMake { get; set; }
        public ObservableCollection<Ingridient> Ingridients { get => ingridients; set => ingridients = value; }
    }
}
