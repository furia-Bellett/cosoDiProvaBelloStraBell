using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace provaGruppo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void bottone1_Click(object sender, RoutedEventArgs e)
        {

            Somma somma = new Somma();

            double num1;
            double num2;
            double RisultatoSomma = 0;
            

            num1 = Convert.ToDouble(txtBox1);
            num2 = Convert.ToDouble(txtBox2);


           RisultatoSomma = somma.CalcoloDellaSomma(num1, num2);




            lable3.Content = Convert.ToString(RisultatoSomma);




        }
    }
}
