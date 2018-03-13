using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Search
{
	public partial class MainPage : ContentPage
	{
        List<ListProduct> ListP;

        public MainPage()
		{
			InitializeComponent();
            ListP = new List<ListProduct>
            {
                new ListProduct{Image="bag.png", Name="Gucci Hand Bag Light Brown", Type="Almost New", Price="3000.00 SAR"},
                new ListProduct{Image="bag2.png", Name="Andre Hand Bag Light Brown", Type="Almost New", Price="3000.00 SAR"},
                new ListProduct{Image="bag3.png", Name="Prada Hand Bag Light Brown", Type="Almost New", Price="3000.00 SAR"}
            };
            List1.ItemsSource = ListP;

        }
        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            //thats all you need to make a search  

            if (string.IsNullOrEmpty(e.NewTextValue))
            {
                List1.ItemsSource = ListP;
            }

            else
            {
                List1.ItemsSource = ListP.Where(x => x.Name.ToLower().StartsWith(e.NewTextValue.ToLower()));
            }
        }
    }
}
