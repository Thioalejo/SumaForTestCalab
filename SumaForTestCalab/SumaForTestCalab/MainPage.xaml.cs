using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SumaForTestCalab
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            btnSumar.Clicked += BtnSumar_Clicked;
        }

        private void BtnSumar_Clicked(object sender, EventArgs e)
        {
            try
            {
                int num1 = Convert.ToInt32(txtNumero1.Text);
                int num2 = Convert.ToInt32(txtNumero1.Text);
                txtResultado.Text = Sumar(num1, num2).ToString();
            }
            catch (Exception)
            {
                DisplayAlert("Alert", "Ingreso un dato invalido", "OK");
            }
            
            
        }


        public int Sumar(int a, int b)
        {
            int suma = a + b;
            return suma;
        }
    }

}
