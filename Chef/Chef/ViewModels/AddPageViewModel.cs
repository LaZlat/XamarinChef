using Chef.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Chef.ViewModels
{
    class AddPageViewModel : DefaultViewMode
    {
        private ObservableCollection<Ingridient> ingridients = new ObservableCollection<Ingridient>();
        public AddPageViewModel()
        {
            AddCommand = new Command(AddIngridient);
            SubmitCommand = new Command(SubmitRecipe);
            FindCommand = new Command(PickImage);
        }
        public ICommand AddCommand { get; set; }
        public ICommand SubmitCommand { get; set; }
        public ICommand FindCommand { get; set; }
        public string TheName { get; set; }
        public string TheImage { get; set; }
        public string TheHowToMake { get; set; }
        public string TheTitle { get; set; }
        public ImageSource Rec { get; set; }
        public ObservableCollection<Ingridient> TheIngridients { get { return ingridients; } }
        public ObservableCollection<Recipe> TheRecipes { get { return recipes; } }
        public void AddIngridient()
        {
            TheIngridients.Add(new Ingridient { Name = TheName });
            OnPropertyChanged("TheIngridients");
            TheName = "";
            OnPropertyChanged("TheName");
        }
        public void SubmitRecipe()
        {
            TheRecipes.Add(new Recipe { Title = "aa" });
            OnPropertyChanged("TheRecipes");
        }
        public async void PickImage()
        {
            var pickResult = await FilePicker.PickAsync(new PickOptions
            {
                FileTypes = FilePickerFileType.Images,
                PickerTitle = "Pick an Image"
            });
            if (pickResult != null)
            {
                var stream = await pickResult.OpenReadAsync();
                //TheImage = stream;
                Rec = ImageSource.FromStream(() => stream);
                OnPropertyChanged("Rec");
            }
        }
    }
}
