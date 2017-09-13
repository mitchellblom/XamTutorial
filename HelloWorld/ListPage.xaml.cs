using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using HelloWorld.Models;

using Xamarin.Forms;

namespace HelloWorld
{
    public partial class ListPage : ContentPage
    {
        void Handle_TextChanged(object sender, Xamarin.Forms.TextChangedEventArgs e)
        {
            listView.ItemsSource = GetContacts(e.NewTextValue);
        }

        IEnumerable<Contact> GetContacts(string searchText = null)
        {
			var contacts = new List<Contact>{
					new Contact { Name = "Mary", ImageUrl = "http://placekitten.com.s3.amazonaws.com/homepage-samples/96/140.jpg", Status="Yo dude"},
					new Contact { Name = "Mosh", ImageUrl = "http://placekitten.com.s3.amazonaws.com/homepage-samples/96/139.jpg"},
					new Contact { Name = "John", ImageUrl = "http://placekitten.com.s3.amazonaws.com/homepage-samples/96/140.jpg", Status="Yo dude"},
					new Contact { Name = "Jimbo", ImageUrl = "http://placekitten.com.s3.amazonaws.com/homepage-samples/96/139.jpg", Status="Hey, let's talk!"}
			};

            if (String.IsNullOrWhiteSpace(searchText))
                return contacts;

            return contacts.Where(c => c.Name.StartsWith(searchText));
        }
        void Handle_Refreshing(object sender, System.EventArgs e)
        {
            listView.ItemsSource = GetContacts();
            //listView.IsRefreshing = false; //another option to do same as EndRefresh
            listView.EndRefresh();
        }

        private ObservableCollection<Contact> _contacts;

        void Delete_Clicked(object sender, System.EventArgs e)
        {
            var contact = (sender as MenuItem).CommandParameter as Contact;
            _contacts.Remove(contact);
        }

        void Call_Clicked(object sender, System.EventArgs e)
        {
            var menuItem = sender as MenuItem;
            var contact = menuItem.CommandParameter as Contact;

            DisplayAlert("Call", contact.Name, "OK");
        }

        void Handle_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            listView.SelectedItem = null;
        }

        void Handle_ItemsTapped(object sender, Xamarin.Forms.ItemTappedEventArgs e)
        {
            var contact = e.Item as Contact;
            DisplayAlert("Tapped", contact.Name, "OK");
        }

        public ListPage()
        {
            InitializeComponent();

            _contacts = new ObservableCollection<Contact>{
					new Contact { Name = "Mary", ImageUrl = "http://placekitten.com.s3.amazonaws.com/homepage-samples/96/140.jpg", Status="Yo dude"},
					new Contact { Name = "Mosh", ImageUrl = "http://placekitten.com.s3.amazonaws.com/homepage-samples/96/139.jpg"},
					new Contact { Name = "John", ImageUrl = "http://placekitten.com.s3.amazonaws.com/homepage-samples/96/140.jpg", Status="Yo dude"},
					new Contact { Name = "Jimbo", ImageUrl = "http://placekitten.com.s3.amazonaws.com/homepage-samples/96/139.jpg", Status="Hey, let's talk!"}
            };

            //listView.ItemsSource = _contacts;

            listView.ItemsSource = GetContacts();

        }
    }
}
