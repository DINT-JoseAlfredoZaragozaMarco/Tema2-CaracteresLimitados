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

namespace Tema2_CaracteresLimitados
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const int MAXIMO_CARACTERES = 140;
        private int numeroCaracteres = 0;
        public MainWindow()
        {
            InitializeComponent();
            contadorTextBlock.Text = this.numeroCaracteres + contadorTextBlock.Text;
        }

        private void inputChanged(object sender, TextChangedEventArgs e)
        {
            this.numeroCaracteres = inputTextBox.Text.Length;

            if(inputTextBox.Text.Length < MAXIMO_CARACTERES)
            {
                contadorTextBlock.Text = "/140";
                contadorTextBlock.Text = this.numeroCaracteres + contadorTextBlock.Text;
            }
            else if(inputTextBox.Text.Length >= MAXIMO_CARACTERES)
            {
                contadorTextBlock.Text = "/140";
                contadorTextBlock.Text = this.numeroCaracteres + contadorTextBlock.Text;
                inputTextBox.IsReadOnly = true;
            }
        }

        private void IsEnter(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Enter)
            {
                inputTextBox.Text += "\n";
                //inputTextBox.Cursor
            }
        }
    }
}
