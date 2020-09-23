using System.ComponentModel;
using Xamarin.Forms;
using _01DEMO.ViewModels;

namespace _01DEMO.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}