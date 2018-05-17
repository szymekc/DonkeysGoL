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

namespace DonkeysGOL.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();

            int size = 50, seed = rand.Next();

            game.Space = new Core.Models.Space(size, seed);

            seedBox.Text = seed.ToString();
            spaceSize.Text = size.ToString();
            iterationCount.Text = "1";

            Draw();
        }

        private Core.Models.Game game = new Core.Models.Game();
        private Random rand = new Random();

        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            if (!Int32.TryParse(seedBox.Text, out int seed))
                seed = rand.Next();
            seedBox.Text = seed.ToString();
            if (!Int32.TryParse(spaceSize.Text, out int size))
                size = game.Space.SpaceArray.GetLength(0);
            spaceSize.Text = size.ToString();
            game.Space = new Core.Models.Space(size, seed);

            Draw();
        }

        private void RunButton_Click(object sender, RoutedEventArgs e)
        {
            if (!Int32.TryParse(iterationCount.Text, out int n))
                n = 0;
            iterationCount.Text = n.ToString();
            //TODO run iterations
            for (; n > 0; n--)
                ;// game.Run();
            Draw();
        }

        private void Draw()
        {
            double width = canvas.ActualWidth, height = canvas.ActualHeight;
            double dx = width / game.Space.SpaceArray.GetLength(0), dy = height / game.Space.SpaceArray.GetLength(1);
            for (int iy = 0; iy < game.Space.SpaceArray.GetLength(1); iy++)
                for (int ix = 0; ix < game.Space.SpaceArray.GetLength(0); ix++)
                {
                    Rectangle rect = new Rectangle
                    {
                        Fill = new SolidColorBrush(game.Space.SpaceArray[ix, iy] ? Colors.Black : Colors.LightGray),
                        Width = dx,
                        Height = dy
                    };
                    Canvas.SetLeft(rect, ix * dx);
                    Canvas.SetTop(rect, iy * dy);
                    canvas.Children.Add(rect);
                }
        }
    }
}
