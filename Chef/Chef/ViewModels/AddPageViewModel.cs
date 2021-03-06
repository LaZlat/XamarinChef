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
    public class AddPageViewModel : DefaultViewMode
    {
        private ObservableCollection<Ingridient> ingridients = new ObservableCollection<Ingridient>();
        private string theName = string.Empty;

        public AddPageViewModel()
        {
            AddCommand = new Command(AddIngridient);
            SubmitCommand = new Command(SubmitRecipe);
            FindCommand = new Command(PickImage);
        }
        public ICommand AddCommand { get; set; }
        public ICommand SubmitCommand { get; set; }
        public ICommand FindCommand { get; set; }
        public string TheName { get => theName; set => theName = value; }
        public string TheImage { get; set; }
        public string TheHowToMake { get; set; }
        public string TheTitle { get; set; }
        public ImageSource TheImgSource { get; set; }
        public ObservableCollection<Ingridient> TheIngridients { get { return ingridients; } set { ingridients = value; } }
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
            Recipe madeRecipe = new Recipe
            {
                Title = TheTitle,
                Image = TheImage,
                ImgSource = TheImgSource,
                HowToMake = TheHowToMake,
                Ingridients = TheIngridients
            };
            TheRecipes.Add(madeRecipe);
            OnPropertyChanged("TheRecipes");
            TheTitle = "";
            TheImage = "";
            TheHowToMake = "";
            TheIngridients = new ObservableCollection<Ingridient>();
            OnPropertyChanged("TheTitle");
            OnPropertyChanged("TheImage");
            OnPropertyChanged("TheHowToMake");
            OnPropertyChanged("TheIngridients");
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
                TheImage = pickResult.FileName;
                OnPropertyChanged("TheImage");

                var stream = await pickResult.OpenReadAsync();
                TheImgSource = ImageSource.FromStream(() => stream);
            }
        }
    }
}
