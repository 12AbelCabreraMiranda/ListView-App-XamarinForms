using MyListView.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyListView.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HumanPage : ContentPage
    {
        public HumanPage()
        {
            InitializeComponent();
            BindingContext = new HumanViewModels();
        }
    }
}