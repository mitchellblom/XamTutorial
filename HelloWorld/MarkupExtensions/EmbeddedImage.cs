using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld.MarkupExtensions
{
	[ContentProperty("ResourceId")]
    public class EmbeddedImage : IMarkupExtension
    {

        public string ResourceId { get; set; }
        public object ProvideValue(IServiceProvider serviceProvider)
        {
            return ImageSource.FromResource("HelloWorld.Images.mountain.png");
        }
    }
}
