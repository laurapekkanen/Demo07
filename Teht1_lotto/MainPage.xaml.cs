using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Teht1_lotto
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public string TextBox1
        {
            get { return this.Draws.Text; }
            set { this.Draws.Text = value; }
        }
        
        public MainPage()
        {
            this.InitializeComponent();
            //change default start up mode
            ApplicationView.PreferredLaunchWindowingMode = ApplicationViewWindowingMode.PreferredLaunchViewSize;
            // size 800*1000
            ApplicationView.PreferredLaunchViewSize = new Size(800, 1000);
            //disable debugger info
            App.Current.DebugSettings.EnableFrameRateCounter = false;
        }

        private void drawButton_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void clearButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
