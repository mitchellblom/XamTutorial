using System;
using System.Collections.Generic;
using HelloWorld.Models;

using Xamarin.Forms;

namespace HelloWorld
{
    public partial class ListPage : ContentPage
    {
        public ListPage()
        {
            InitializeComponent();

            listView.ItemsSource = new List<Contact>{
                new Contact { Name = "Mosh", ImageUrl = "http://placekitten.com.s3.amazonaws.com/homepage-samples/96/139.jpg"},
                new Contact { Name = "John", ImageUrl = "http://placekitten.com.s3.amazonaws.com/homepage-samples/96/140.jpg", Status="Yo dude"},
                new Contact { Name = "Bob", ImageUrl = "http://placekitten.com.s3.amazonaws.com/homepage-samples/96/139.jpg", Status="Hey, let's talk!"}
               
            };
        }
    }
}
