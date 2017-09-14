using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace HelloWorld
{

    public class ContactMethod 
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public partial class PickerPage : ContentPage
    {
        private IList<ContactMethod> _contactMethods;

        void Handle_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            var name = contactMethods.Items[contactMethods.SelectedIndex];
            var contactMethod = _contactMethods.Single(cm => cm.Name == name);

            DisplayAlert("Selection", name, "OK");
        }

        public PickerPage()
        {
            InitializeComponent();

            _contactMethods = GetContactMethods();

            foreach (var method in _contactMethods)
                contactMethods.Items.Add(method.Name);
        }

        private IList<ContactMethod> GetContactMethods()
        {
            return new List<ContactMethod>
            {
                new ContactMethod{ Id = 1, Name = "SMS"},
                new ContactMethod{ Id = 2, Name = "Email"}
            };
        }
    }
}