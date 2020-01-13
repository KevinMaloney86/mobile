using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace mobileapppro
{
    public partial class MainPage : ContentPage
    {
        int counter = 0;
        Label l = new Label();

        public MainPage()
        {
            InitializeComponent();

            Countlabel();

           

        }
        public void BtnCount_Clicked(object sender, EventArgs e)
        {
            ++counter;
            string s = counter.ToString();
            l.Text = s;
            

           
        }

        public void Countlabel()
        {
            l.Text = "0";
            Clicker.Children.Add(l);
        }
    }
}
