using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Forgoracs
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
        class Fracs
        {
            public char[,] Titkositott;
            public char[,] Kodlemez;
            public readonly string Titkositando;

            public Fracs(char[,] titkositott, char[,] kodlemez, string titkositando)
            {
                titkositott = new char[8, 8];
                kodlemez = new char[8, 8];

                string[] file = File.ReadAllLines("kodlemez.txt");

                for (int i = 0; i < 8; i++)
                {
                    string[] line = file[i].Split(' ');
                    for (int j = 0; j < 8; j++)
                    {
                        kodlemez[i, j] = line[j][0];
                    }
                }

                atalakit(titkositando);

                this.Titkositott = titkositott;
                this.Kodlemez = kodlemez;
                this.Titkositando = titkositando;

            }
            private void atalakit(string titkositando)
            {
                titkositando.ToString().Replace(" ", "").Replace(",", "").Replace(".", "");
                if (titkositando.Length > 64)
                {
                    throw new Exception("Maximum 64 betű!");
                }
                titkositando.PadRight(64, 'X');
            }

        }

    }
}