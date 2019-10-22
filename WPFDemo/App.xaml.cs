using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Navigation;

namespace WPFDemo
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        /// <summary>
        /// 构造 App，相当于程序入口
        /// </summary>
        public App()
        {
            this.Startup += this.App_Startup;
            this.Activated += this.App_Activated;
            this.Exit += this.App_Exit;
            this.DispatcherUnhandledException += this.App_DispatcherUnhandledException;
            AppDomain.CurrentDomain.UnhandledException += this.CurrentDomain_UnhandledException;
            this.Navigating += this.App_Navigating;
        }

        private void App_Navigating(object sender, NavigatingCancelEventArgs e)
        {
            Debug.Print($"转跳到页面：{e?.Uri?.OriginalString}");
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
        }

        private void App_Exit(object sender, ExitEventArgs e)
        {
        }

        private void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
        }

        private void App_Startup(object sender, StartupEventArgs e)
        {
        }

        private void App_DispatcherUnhandledException(object sender, System.Windows.Threading.DispatcherUnhandledExceptionEventArgs e)
        {
        }

        private void App_Activated(object sender, EventArgs e)
        {
        }
    }
}
