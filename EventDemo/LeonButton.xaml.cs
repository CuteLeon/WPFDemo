using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace EventDemo
{
    /// <summary>
    /// LeonButton.xaml 的交互逻辑
    /// </summary>
    public partial class LeonButton : UserControl
    {
        /// <summary>
        /// 冒泡点击事件
        /// </summary>
        public static readonly RoutedEvent ClickBubbleEvent = EventManager.RegisterRoutedEvent("ClickBubble", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(LeonButton));

        /// <summary>
        /// 隧道点击事件
        /// </summary>
        public static readonly RoutedEvent ClickTunnelEvent = EventManager.RegisterRoutedEvent("ClickTunnel", RoutingStrategy.Tunnel, typeof(RoutedEventHandler), typeof(LeonButton));

        /// <summary>
        /// 直达点击事件
        /// </summary>
        public static readonly RoutedEvent ClickDirectEvent = EventManager.RegisterRoutedEvent("ClickDirect", RoutingStrategy.Direct, typeof(RoutedEventHandler), typeof(LeonButton));

        public event RoutedEventHandler ClickBubble
        {
            add { this.AddHandler(ClickBubbleEvent, value); }
            remove { this.RemoveHandler(ClickBubbleEvent, value); }
        }

        public event RoutedEventHandler ClickTunnel
        {
            add { this.AddHandler(ClickTunnelEvent, value); }
            remove { this.RemoveHandler(ClickTunnelEvent, value); }
        }

        public event RoutedEventHandler ClickDirect
        {
            add { this.AddHandler(ClickDirectEvent, value); }
            remove { this.RemoveHandler(ClickDirectEvent, value); }
        }

        public LeonButton() : base()
        {
            this.InitializeComponent();
        }

        protected override void OnMouseLeftButtonUp(MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonUp(e);

            this.RaiseEvent(new RoutedEventArgs(ClickBubbleEvent, this));
            // this.RaiseEvent(new RoutedEventArgs(ClickDirectEvent, this));
        }

        protected override void OnMouseRightButtonUp(MouseButtonEventArgs e)
        {
            base.OnMouseRightButtonUp(e);

            this.RaiseEvent(new RoutedEventArgs(ClickTunnelEvent, this));
            // this.RaiseEvent(new RoutedEventArgs(ClickDirectEvent, this));
        }
    }
}
