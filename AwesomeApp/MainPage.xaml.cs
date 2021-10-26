using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AwesomeApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        int cont = 0;
        private void Aumentar(object sender, EventArgs e)
        {
            cont++;
            qtd.Text = cont.ToString();
        }

        private void Diminuir(object sender, EventArgs e)
        {
            cont--;
            qtd.Text = cont.ToString();
        }
    }
}
