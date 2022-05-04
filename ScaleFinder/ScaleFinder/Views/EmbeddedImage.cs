using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ScaleFinder.Views
{
    [ContentProperty(nameof(Source))]
    internal class EmbeddedImage : IMarkupExtension
    {
        public string Source { get; set; }

        public object ProvideValue(IServiceProvider serviceProvider)
        {
            return ImageSource.FromResource(Source);
        }
    }
}
