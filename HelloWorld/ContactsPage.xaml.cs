using System;
using System.Collections.Generic;
using HelloWorld.Models;
using Xamarin.Forms;

namespace HelloWorld
{
    public partial class ContactsPage : ContentPage
    {
        async void Handle_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;
            
            var contact = e.SelectedItem as Contact;
            await Navigation.PushAsync(new ContactDetailPage(contact));
            listView.SelectedItem = null;
        }

        public ContactsPage()
        {
            InitializeComponent();

            listView.ItemsSource = new List<Contact> {
				new Contact { Name = "John", ImageUrl = "http://placekitten.com.s3.amazonaws.com/homepage-samples/96/140.jpg", Status="Yo dude"},
				new Contact { Name = "Jimbo", ImageUrl = "http://placekitten.com.s3.amazonaws.com/homepage-samples/96/139.jpg", Status="Hey, let's talk!"}
			};
        }
    }
}
