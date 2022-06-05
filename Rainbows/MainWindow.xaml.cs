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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Rainbows
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Resources["ToColour"] = colours[1];
        }

        Color[] colours = new Color[] { Colors.Red,
            Colors.Orange,
            Colors.Yellow,
            Colors.Green,
            Colors.Blue,
            Colors.Violet,
            Colors.Indigo };

        int index = 0;

        void CycleColour(object sender, RoutedEventArgs e)
        {
            index++;
            ColorAnimation backgroundTransition = new ColorAnimation();
            backgroundTransition.To = colours[index % colours.Length];
            backgroundTransition.Duration = TimeSpan.FromSeconds(0.3);

            RainbowButton.Background = new SolidColorBrush(colours[(index - 1) % colours.Length]);
            RainbowButton.Background.BeginAnimation(SolidColorBrush.ColorProperty, backgroundTransition);
        }
    }
}
