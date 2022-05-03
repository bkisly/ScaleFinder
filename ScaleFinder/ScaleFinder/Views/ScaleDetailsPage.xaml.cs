using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ScaleFinder.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ScaleDetailsPage : ContentPage
    {
        public ScaleDetailsPage(Models.Scale scale)
        {
            InitializeComponent();
            BindingContext = scale;
            Title = $"Details of {scale.Name}";

            foreach(Models.Sound sound in scale.Sounds)
            {
                soundsLabel.Text += sound.ToString();
                if (sound != scale.Sounds.Last()) soundsLabel.Text += ", ";
            }
        }
    }
}