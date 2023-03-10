using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Navigation
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private Frame myFrame;
        public MainPage()
        {
            this.InitializeComponent();
            myFrame = new Frame();
            myFrame.Navigate(typeof(Page1));
        }

        private void HomeButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Page1));
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            if (Frame.CanGoBack)
            {
                Frame.GoBack();
            }
        }

        private void Forward_Click(object sender, RoutedEventArgs e)
        {
            if (Frame.CanGoForward)
            {
                Frame.GoForward();
            }
        }
    }
}
