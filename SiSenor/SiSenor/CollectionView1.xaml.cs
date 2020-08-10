using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SiSenor
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CollectionView1 : ContentPage
    {
        public IList<Product> Ilist { get; set; }
        public CollectionView1()
        {
            InitializeComponent();
            Ilist = new List<Product>();
            Ilist.Add(new Product { ProductName = "Tacos", Description = "This is description", ImageURL = "tacos1.jpg" });
            Ilist.Add(new Product { ProductName = "Hamburguesas", Description = "This is description", ImageURL = "tacos2.jpg" });
            Ilist.Add(new Product { ProductName = "Pastas", Description = "This is description", ImageURL = "tacos1.jpg" });
            Ilist.Add(new Product { ProductName = "Pizza", Description = "This is description", ImageURL = "tacos2.jpg" });
            Ilist.Add(new Product { ProductName = "Pasteles", Description = "This is description", ImageURL = "tacos1.jpg" });
            Ilist.Add(new Product { ProductName = "Snacks", Description = "This is description", ImageURL = "tacos2.jpg" });
            Ilist.Add(new Product { ProductName = "Carnes", Description = "This is description", ImageURL = "tacos1.jpg" });
            Ilist.Add(new Product { ProductName = "Ensaladas", Description = "This is description", ImageURL = "tacos2.jpg" });
            Ilist.Add(new Product { ProductName = "Postres", Description = "This is description", ImageURL = "tacos1.jpg" });
            BindingContext = this;
        }

        private void Search1_TextChanged(object sender, TextChangedEventArgs e)
        {
            var searchresult = Ilist.Where(c => c.ProductName.ToLower().Contains(Search1.Text.ToLower()));
            Coll1.ItemsSource = searchresult;
        }
    }

    public class Product
    {
        public string ProductName { get; set; }
        public string Description { get; set; }
        public string ImageURL { get; set; }
    }
}