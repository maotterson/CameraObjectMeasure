using CameraObjectMeasure.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace CameraObjectMeasure.Views
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