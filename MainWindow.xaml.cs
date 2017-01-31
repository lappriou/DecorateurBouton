using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DecorateurBouton
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        IBouton superBouton = new Bouton(30, 80, 1, 100);
        public MainWindow()
        {
            InitializeComponent();
            RegenererBouton();

            
        }


        public void RegenererBouton()
        {
           
            SuperBouton.Height = superBouton.GetHauteur();
            SuperBouton.Width = superBouton.GetLargeur();
            SuperBouton.Opacity = superBouton.GetOpacite();
            SuperBouton.BorderThickness =  new Thickness(superBouton.GetBouclier());

        }

        private void BoutonDisparait_Click(object sender, RoutedEventArgs e)
        {
            superBouton = new EffetOpacite(superBouton);
            RegenererBouton();
            
        }

        private void BoutonGrossis_Click(object sender, RoutedEventArgs e)
        {
            superBouton = new EffetGrossir(superBouton);
            RegenererBouton();
        }

        private void BoutonClignote_Click(object sender, RoutedEventArgs e)
        {
            
            superBouton = new EffetBouclier(superBouton);
            RegenererBouton();
        }
    }
}
