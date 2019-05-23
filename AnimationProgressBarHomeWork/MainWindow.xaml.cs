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

namespace AnimationProgressBarHomeWork
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
           
    public partial class MainWindow : Window
    {
       
        public MainWindow()
        {
            InitializeComponent();
             DoubleAnimation animation = new DoubleAnimation();
             animation.From = progressBarRectangle.Width;
             animation.To = progressBarRectangle.Width + 792;
             animation.Duration = new Duration(TimeSpan.FromSeconds(3));
            
            animation.AutoReverse = false;
             Storyboard storyboard = new Storyboard();
             storyboard.Children.Add(animation);
             Storyboard.SetTargetName(animation, progressBarRectangle.Name);
             Storyboard.SetTargetProperty(animation, new PropertyPath(Rectangle.WidthProperty));
            animation.Completed += new EventHandler(ChangeNameTextBlock);
             storyboard.Begin(this);

          


        }
        private void ChangeNameTextBlock(object sender, EventArgs e)
        {
            textBlock.Text = "Готово";
        }

    }
}
