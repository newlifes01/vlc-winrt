﻿using VLC_WinRT.ViewModels;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace VLC_WinRT.Views.UserControls
{
    public sealed partial class TopBar : UserControl
    {
        public TopBar()
        {
            this.InitializeComponent();
            this.Loaded += TopBar_Loaded;
        }

        private void TopBar_Loaded(object sender, RoutedEventArgs e)
        {
#if WINDOWS_APP
            VLCHeader.Visibility = Visibility.Collapsed;
#endif
        }

        private void GoBack_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            Locator.NavigationService.GoBack_Specific();
        }
    }
}
