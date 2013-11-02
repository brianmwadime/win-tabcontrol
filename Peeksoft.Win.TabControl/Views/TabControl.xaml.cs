using Peeksoft.Win.TabControl.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace Peeksoft.Win.TabControl
{
    public sealed partial class TabControl : UserControl
    {
        private readonly TabControlViewModel _viewModel;

        public TabControl()
        {
            this.InitializeComponent();

            _viewModel = new TabControlViewModel();
            
            this.Loaded += TabControl_Loaded;
        }

        public void AddTab(Tab tab)
        {
            // TODO: make label configurable
            TextBlock label = new TextBlock();
            label.Text = tab.Name;
            label.FontSize = 36;
            label.Margin = new Thickness(20);
            label.Foreground = new SolidColorBrush(Colors.DimGray);
            label.Tapped += label_Tapped;
            ButtonPanel.Children.Add(label);

            if (_viewModel.Tabs.Count == 0)
            {
                label.Foreground = new SolidColorBrush(Colors.White);
            }

            _viewModel.Tabs.Add(tab);
        }
        
        private void TabControl_Loaded(object sender, RoutedEventArgs e)
        {
            this.DataContext = _viewModel;
        }

        private void label_Tapped(object sender, TappedRoutedEventArgs e)
        {
            TextBlock label = sender as TextBlock;
            if (label != null)
            {
                int index = ButtonPanel.Children.IndexOf(label);
                if (index != -1 &&
                    index != FlipView.SelectedIndex)
                {
                    FlipView.SelectedIndex = index;
                }
            }
        }

        private void HighlightIndex()
        {
            foreach (var item in ButtonPanel.Children)
            {
                TextBlock text = item as TextBlock;
                if (text != null)
                {
                    text.Foreground = new SolidColorBrush(Colors.DimGray);
                }
            }

            TextBlock label = ButtonPanel.Children[FlipView.SelectedIndex] as TextBlock;
            if (label != null)
            {
                label.Foreground = new SolidColorBrush(Colors.White);
            }

            // TODO: animate label on screen if it is off screen
        }

        private void FlipView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            HighlightIndex();
        }
    }
}
