using System;
using System.Collections.Generic;
using HelloWorld.Models;

using Xamarin.Forms;

namespace HelloWorld
{
    public partial class ListPage : ContentPage
    {
        void Handle_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            listView.SelectedItem = null;
        }

        void Handle_ItemTapped(object sender, Xamarin.Forms.ItemTappedEventArgs e)
        {
            var contact = e.Item as Contact;
            DisplayAlert("Tapped", contact.Name, "OK");
        }

        public ListPage()
        {
            InitializeComponent();

            listView.ItemsSource = new List<ContactGroup>{

				new ContactGroup("M peeps", "M"){
					new Contact { Name = "Mary", ImageUrl = "http://placekitten.com.s3.amazonaws.com/homepage-samples/96/140.jpg", Status="Yo dude"},
					new Contact { Name = "Mosh", ImageUrl = "http://placekitten.com.s3.amazonaws.com/homepage-samples/96/139.jpg"}
				},

				new ContactGroup("J people", "J"){
					new Contact { Name = "John", ImageUrl = "http://placekitten.com.s3.amazonaws.com/homepage-samples/96/140.jpg", Status="Yo dude"},
					new Contact { Name = "Jimbo", ImageUrl = "http://placekitten.com.s3.amazonaws.com/homepage-samples/96/139.jpg", Status="Hey, let's talk!"}
				}
            };

        }
    }
}
