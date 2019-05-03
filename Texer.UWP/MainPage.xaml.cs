using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using Texer.UWP.Models;
using Texer.UWP.ViewModels;
using Windows.ApplicationModel.DataTransfer;
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

namespace Texer.UWP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        MainViewModel ViewModel { get; } = new MainViewModel();
        
        public MainPage()
        {
            this.InitializeComponent();

            this.Loaded += MainPage_Loaded;
        }

        private void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            BackgroundGridShadow.Receivers.Add(PanelShadowCatcher);
        }

        private void BtnCopy_Click(object sender, RoutedEventArgs e)
        {
            ViewModel.ClickedItem = (sender as Button).DataContext as StyleItem;

            ViewModel.CopyStyledText();
        }

        private void BtnCopyHistory_Click(object sender, RoutedEventArgs e)
        {
            ViewModel.ClickedItem = (sender as Button).DataContext as StyleItem;

            ViewModel.CopyHistoryStyledText();
        }
    }
}
