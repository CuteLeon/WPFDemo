using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace PaintAnimationDemo
{
    /// <summary>
    /// AnimationWindow.xaml 的交互逻辑
    /// </summary>
    public partial class AnimationWindow : Window
    {
        public AnimationWindow()
        {
            this.InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            DoubleAnimation xAnimation = new DoubleAnimation()
            {
                To = random.Next(0, 300),
                By = 10d,
                Duration = new Duration(TimeSpan.FromSeconds(0.5)),
            };
            DoubleAnimation yAnimation = new DoubleAnimation()
            {
                To = random.Next(0, 300),
                By = 10d,
                Duration = new Duration(TimeSpan.FromSeconds(0.5)),
            };

            yAnimation.EasingFunction = new BounceEase()
            {
                Bounces = 3,
                Bounciness = 3,
            };

            this.translate1.BeginAnimation(TranslateTransform.XProperty, xAnimation);
            this.translate1.BeginAnimation(TranslateTransform.YProperty, yAnimation);
        }
    }
}
