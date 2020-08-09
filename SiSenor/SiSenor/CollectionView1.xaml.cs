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
            Ilist.Add(new Product { ProductName = "Laptop", Description = "This is description", ImageURL = "tacos1.jpg" });
            Ilist.Add(new Product { ProductName = "Laptop1", Description = "This is description", ImageURL = "tacos2.jpg" });
            Ilist.Add(new Product { ProductName = "Laptop2", Description = "This is description", ImageURL = "tacos1.jpg" });
            Ilist.Add(new Product { ProductName = "Laptop3", Description = "This is description", ImageURL = "tacos2.jpg" });
            Ilist.Add(new Product { ProductName = "Laptop4", Description = "This is description", ImageURL = "tacos1.jpg" });
            Ilist.Add(new Product { ProductName = "Laptop5", Description = "This is description", ImageURL = "tacos2.jpg" });
            Ilist.Add(new Product { ProductName = "Laptop6", Description = "This is description", ImageURL = "tacos1.jpg" });
            Ilist.Add(new Product { ProductName = "Laptop7", Description = "This is description", ImageURL = "tacos2.jpg" });
            Ilist.Add(new Product { ProductName = "Laptop8", Description = "This is description", ImageURL = "tacos1.jpg" });
            BindingContext = this;
        }
    }

    public class Product
    {
        public string ProductName { get; set; }
        public string Description { get; set; }
        public string ImageURL { get; set; }
    }
}