using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Prueba
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            InitializeComponent();
            //Definimos nuestra pantalla Master
            Master = new Menu();
            //Definimos nuestra pantalla Detail
            Detail = new NavigationPage(new Inicio());
            App.Modificador = this;
        }

    }
}
