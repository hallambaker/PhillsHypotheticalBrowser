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
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HypotheticalBrowser;
/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window {
    public MainWindow() {
        InitializeComponent();
        }

    private void ButtonGo_Click(object sender, RoutedEventArgs e) {
        if (webView != null && webView.CoreWebView2 != null) {
            webView.CoreWebView2.Navigate(addressBar.Text);
            }
        }

    private void ButtonForward_Click(object sender, RoutedEventArgs e) {

        }

    private void ButtonAutofill_Click(object sender, RoutedEventArgs e) {

        }

    private void ButtonReload_Click(object sender, RoutedEventArgs e) {

        }

    private void ButtonHome_Click(object sender, RoutedEventArgs e) {

        }

    private void ButtonSecure_Click(object sender, RoutedEventArgs e) {

        }

    private void ButtonDownload_Click(object sender, RoutedEventArgs e) {

        }

    private void ButtonBookmark_Click(object sender, RoutedEventArgs e) {

        }

    private void ButtonSettings_Click(object sender, RoutedEventArgs e) {

        }
    }
