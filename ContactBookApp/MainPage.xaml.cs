using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ContactBookApp
{
    
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        private List<string> ContactList = new List<string>()
        {
            "James",
            "Bobo",
            "Steve"
        };
        
        
        public MainPage()
        {
            InitializeComponent();

            Contacts.ItemsSource = ContactList;
        }
    }
}
