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

namespace MatchGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            SetUpGame();
            //Referencia o Método SetUpGame
        }

        private void SetUpGame() // Cria o Método SetUpGame
        {   
            List<string> animalEmoji = new List<string>() //Cria uma lista de oito pares de emoji
            {
                "🐼","🐼",
                "🐶","🐶",
                "🦁","🦁",
                "🐭","🐭",
                "🐷","🐷",
                "🐮","🐮",
                "🐨","🐨",
                "😺","😺",
            };

            Random random = new Random(); //Cria um novo gerador de numeros aleatórios

            foreach(TextBlock textBlock in mainGrid.Children.OfType<TextBlock>()) // Localiza cada TextBlock na grade principal e repete as declarações seguintes para cada um
            {
                int index = random.Next(animalEmoji.Count);
                string nextEmoji = animalEmoji[index];
                textBlock.Text = nextEmoji;
                animalEmoji.RemoveAt(index);
            } 
        }
    }
}