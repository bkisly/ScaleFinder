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
    public partial class FinderPage : ContentPage
    {
        public FinderPage()
        {
            InitializeComponent();
            viewModel.UpdateScales();
        }

        private void SoundButton_Toggled(object sender, ToggledEventArgs e)
        {
            ToggleButton senderButton = sender as ToggleButton;

            if (int.TryParse(senderButton.CommandParameter.ToString(), out int parameter))
            {
                Models.Sound parameterSound = (Models.Sound)parameter;

                if (e.Value) viewModel.SelectedSounds.Add(parameterSound);
                else viewModel.SelectedSounds.Remove(parameterSound);
            }

            viewModel.UpdateScales();
        }
    }
}