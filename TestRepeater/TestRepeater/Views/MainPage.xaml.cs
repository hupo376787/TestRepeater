using Microsoft.Toolkit.Uwp.UI.Controls;
using Microsoft.UI.Xaml.Controls;
using Newtonsoft.Json;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using TestRepeater.Core.Models;
using TestRepeater.Helpers;
using Windows.Storage;
using Windows.System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;

namespace TestRepeater.Views
{
    public sealed partial class MainPage : Page, INotifyPropertyChanged
    {

        private ObservableCollection<GridItem> _verticalSource;
        public ObservableCollection<GridItem> verticalSource
        {
            get { return _verticalSource; }
            set { Set(ref _verticalSource, value); }
        }

        public MainPage()
        {
            InitializeComponent();

            this.Loaded += MainPage_Loaded;
        }

        private async void MainPage_Loaded(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            StorageFile file = await StorageFile.GetFileFromApplicationUriAsync(new Uri("ms-appx:///data.json"));
            var text = await FileIO.ReadTextAsync(file);
            var json = JsonConvert.DeserializeObject<HomeModel>(text);

            var verticalTempSource = new ObservableCollection<GridItem>(json.data.grid);

            foreach (var item in verticalTempSource)
            {
                //Pass GridItem's param data_type, type to ProductItem
                //pass params to card item
                foreach (var ite in item.product)
                {
                    ite.data_type = item.data_type;
                    ite.type = item.type;
                }
            }
            verticalSource = new ObservableCollection<GridItem>(verticalTempSource);

            FlipViewBanner.ItemsSource = new ObservableCollection<BannerItem>(json.data.banner);
            VerticalRepeater.ItemsSource = verticalSource;


            if (FlipViewBanner.Items.Count > 0)
            {
                FlipViewBanner.UpdateLayout();
                var current = FlipViewBanner.SelectedItem;
                var ss = FlipViewBanner.ContainerFromItem(current);
                var currentContainer = FlipViewBanner.ContainerFromItem(current) as FlipViewItem;
                if (currentContainer != null)
                {
                    currentContainer.Focus(FocusState.Programmatic);
                    currentContainer.StartBringIntoView();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void Set<T>(ref T storage, T value, [CallerMemberName]string propertyName = null)
        {
            if (Equals(storage, value))
            {
                return;
            }

            storage = value;
            OnPropertyChanged(propertyName);
        }

        private void OnPropertyChanged(string propertyName) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        private void ScrollViewerHome_ViewChanged(object sender, ScrollViewerViewChangedEventArgs e)
        {

        }

        private void ScrollViewerHome_SizeChanged(object sender, Windows.UI.Xaml.SizeChangedEventArgs e)
        {

        }

        private void FlipViewBanner_GotFocus(object sender, RoutedEventArgs e)
        {
            // Scale up a little.
            var current = FlipViewBanner.SelectedItem;
            var currentContainer = FlipViewBanner.ContainerFromItem(current) as FlipViewItem;
            var imageEx = TreeHelper.FindVisualChild<ImageEx>(currentContainer);
            if (imageEx == null)
                return;

            imageEx.Opacity = 1.0;
        }

        private void FlipViewBanner_LostFocus(object sender, RoutedEventArgs e)
        {
            // Scale back down.
            var current = FlipViewBanner.SelectedItem;
            var currentContainer = FlipViewBanner.ContainerFromItem(current) as FlipViewItem;
            var imageEx = TreeHelper.FindVisualChild<ImageEx>(currentContainer);
            if (imageEx == null)
                return;

            imageEx.Opacity = 0.5;
        }

        private void FlipViewBanner_PointerEntered(object sender, Windows.UI.Xaml.Input.PointerRoutedEventArgs e)
        {

        }

        private void FlipViewBanner_PointerExited(object sender, Windows.UI.Xaml.Input.PointerRoutedEventArgs e)
        {

        }

        private void FlipViewBanner_PointerWheelChanged(object sender, Windows.UI.Xaml.Input.PointerRoutedEventArgs e)
        {

        }

        private void FlipViewBanner_Tapped(object sender, Windows.UI.Xaml.Input.TappedRoutedEventArgs e)
        {

        }

        private void FlipViewBanner_PreviewKeyDown(object sender, KeyRoutedEventArgs e)
        {
            FlipViewBanner.UpdateLayout();
            VerticalRepeater.UpdateLayout();

            switch (e.OriginalKey)
            {
                case VirtualKey.GamepadLeftTrigger:

                    e.Handled = true;
                    break;
                case VirtualKey.GamepadRightTrigger:

                    e.Handled = true;
                    break;
                case VirtualKey.Down:
                case VirtualKey.GamepadDPadDown:
                case VirtualKey.GamepadLeftThumbstickDown:
                    {
                        try
                        {
                            var grid = VerticalRepeater.TryGetElement(0) as Grid;
                            if (grid != null)
                            {
                                grid.StartBringIntoView();
                                var horizontalRepeater = TreeHelper.FindVisualChild<ItemsRepeater>(grid);
                                var firstCardItemStackPanel = horizontalRepeater.TryGetElement(0);
                                var buttonCardItem = TreeHelper.FindVisualChild<Button>(firstCardItemStackPanel);
                                if (buttonCardItem != null)
                                {
                                    buttonCardItem.Focus(FocusState.Programmatic);
                                    buttonCardItem.StartBringIntoView();

                                    e.Handled = true;
                                }
                            }
                        }
                        catch
                        {

                        }

                        //e.Handled = true;
                    }


                    break;
                case VirtualKey.Up:
                case VirtualKey.GamepadDPadUp:
                case VirtualKey.GamepadLeftThumbstickUp:
                    //Do nothing

                    e.Handled = true;
                    break;
                case VirtualKey.Left:
                case VirtualKey.GamepadDPadLeft:
                case VirtualKey.GamepadLeftThumbstickLeft:
                    if ((sender as FlipView).SelectedIndex == 0)
                    {
                        ShellPage.shellPage.navigationView.IsPaneOpen = true;
                        e.Handled = true;
                    }
                    break;
                case VirtualKey.Space:
                case VirtualKey.Enter:
                case VirtualKey.GamepadA:
                    

                    break;
                default:
                    break;
            }
        }


        private void ImageExBanner_PointerEntered(object sender, Windows.UI.Xaml.Input.PointerRoutedEventArgs e)
        {

        }

        private void ImageExBanner_PointerExited(object sender, Windows.UI.Xaml.Input.PointerRoutedEventArgs e)
        {

        }

        private void ListBoxIndicators_GotFocus(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {

        }

        private void ListBoxIndicators_GettingFocus(Windows.UI.Xaml.UIElement sender, Windows.UI.Xaml.Input.GettingFocusEventArgs args)
        {

        }

        private void BorderIndicator_PointerEntered(object sender, Windows.UI.Xaml.Input.PointerRoutedEventArgs e)
        {

        }

        private void BorderIndicator_PointerExited(object sender, Windows.UI.Xaml.Input.PointerRoutedEventArgs e)
        {

        }

        private void ButtonRetry_Tapped(object sender, Windows.UI.Xaml.Input.TappedRoutedEventArgs e)
        {

        }

        private void ButtonRetry_PreviewKeyDown(object sender, Windows.UI.Xaml.Input.KeyRoutedEventArgs e)
        {

        }

        private void VerticalRepeater_PreviewKeyDown(object sender, Windows.UI.Xaml.Input.KeyRoutedEventArgs e)
        {

        }

        private async void ButtonCardItem_PreviewKeyDown(object sender, KeyRoutedEventArgs e)
        {
            FlipViewBanner.UpdateLayout();
            VerticalRepeater.UpdateLayout();

            FindNextElementOptions findNextElementOptions = new FindNextElementOptions
            {
                SearchRoot = ScrollViewerHome,
                XYFocusNavigationStrategyOverride = XYFocusNavigationStrategyOverride.NavigationDirectionDistance
            };
            //Before move focus
            //Get current item data context
            var currentItem = (sender as Button).DataContext as ProductItem;
            var currentFocusElement = FocusManager.GetFocusedElement() as Button;
            

            try
            {
                switch (e.OriginalKey)
                {
                    case VirtualKey.Up:
                    case VirtualKey.GamepadDPadUp:
                    case VirtualKey.GamepadLeftThumbstickUp:
                        {
                            BringIntoViewOptions options = new BringIntoViewOptions
                            {
                                VerticalOffset = 50.0,
                                AnimationDesired = true
                            };

                            //var tt = currentFocusElement.TransformToVisual(appWindow.Content);
                            //Point currentFocusLeftTopPoint = tt.TransformPoint(new Point(appWindow.Bounds.Left, appWindow.Bounds.Top));
                            //Rect rect = new Rect(124, currentFocusLeftTopPoint.Y - 500, 1920, 500);
                            //var nextFocus = FocusManager.FindNextFocusableElement(FocusNavigationDirection.Next, rect);


                            var candidate = FocusManager.FindNextElement(FocusNavigationDirection.Up, findNextElementOptions);
                            if (candidate != null && candidate is Button)
                            {

                                (candidate as Control).StartBringIntoView();
                                (candidate as Control).Focus(FocusState.Programmatic);

                                e.Handled = true;
                            }
                            else if(candidate != null)
                            {
                                var current = FlipViewBanner.SelectedItem;
                                var currentContainer = FlipViewBanner.ContainerFromItem(current) as FlipViewItem;
                                var result = await FocusManager.TryFocusAsync(currentContainer, FocusState.Programmatic);
                                currentContainer.StartBringIntoView();
                                e.Handled = true;
                            }
                        }
                        break;
                    case VirtualKey.Down:
                    case VirtualKey.GamepadDPadDown:
                    case VirtualKey.GamepadLeftThumbstickDown:
                        {

                            //Last river
                            BringIntoViewOptions options = new BringIntoViewOptions
                            {
                                VerticalOffset = -50.0,
                                AnimationDesired = true
                            };

                            var candidate = FocusManager.FindNextElement(FocusNavigationDirection.Down, findNextElementOptions);
                            if (candidate != null && candidate is Control)
                            {
                                (candidate as Control).StartBringIntoView();
                                (candidate as Control).Focus(FocusState.Programmatic);

                                e.Handled = true;
                            }
                        }
                        break;
                    case VirtualKey.Left:
                    case VirtualKey.GamepadDPadLeft:
                    case VirtualKey.GamepadLeftThumbstickLeft:
                        {
                            var parent = TreeHelper.FindParentByName<ItemsRepeater>(sender as Button, "HorizontalRepeater");
                            FindNextElementOptions findNextElementOptions1 = new FindNextElementOptions
                            {
                                SearchRoot = parent,
                                XYFocusNavigationStrategyOverride = XYFocusNavigationStrategyOverride.Projection
                            };
                            var candidate = FocusManager.FindNextElement(FocusNavigationDirection.Left, findNextElementOptions1);
                            if (candidate != null && candidate is Control)
                            {
                                (candidate as Control).StartBringIntoView();
                                (candidate as Control).Focus(FocusState.Programmatic);

                                e.Handled = true;
                            }
                            else
                            {
                                ShellPage.shellPage.navigationView.IsPaneOpen = true;
                                e.Handled = true;
                            }

                        }
                        break;
                    case VirtualKey.Right:
                    case VirtualKey.GamepadDPadRight:
                    case VirtualKey.GamepadLeftThumbstickRight:
                        {
                            
                        }
                        break;
                    case VirtualKey.GamepadA:
                    case VirtualKey.Enter:
                    case VirtualKey.Space:
                        {
                            
                        }
                        break;
                    default:
                        break;
                }
            }
            catch { }
            finally
            {
                
            }

            
        }


        private void ButtonCardItem_PointerEntered(object sender, Windows.UI.Xaml.Input.PointerRoutedEventArgs e)
        {

        }

        private void ButtonCardItem_PointerExited(object sender, Windows.UI.Xaml.Input.PointerRoutedEventArgs e)
        {

        }

        private void ButtonCardItem_GotFocus(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {

        }

        private void ButtonCardItem_LostFocus(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {

        }

        private void GridCardItem_Tapped(object sender, Windows.UI.Xaml.Input.TappedRoutedEventArgs e)
        {

        }

        private void Page_Loaded(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {

        }

        private void Page_SizeChanged(object sender, Windows.UI.Xaml.SizeChangedEventArgs e)
        {

        }
    }
}
