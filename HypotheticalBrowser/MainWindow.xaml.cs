#region // Copyright - MIT License
//  © 2021 by Phill Hallam-Baker
//  
//  Permission is hereby granted, free of charge, to any person obtaining a copy
//  of this software and associated documentation files (the "Software"), to deal
//  in the Software without restriction, including without limitation the rights
//  to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//  copies of the Software, and to permit persons to whom the Software is
//  furnished to do so, subject to the following conditions:
//  
//  The above copyright notice and this permission notice shall be included in
//  all copies or substantial portions of the Software.
//  
//  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//  AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
//  THE SOFTWARE.
#endregion


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

    public History History { get; }
    public HistoryTab HistoryTab { get; }

    public MainWindow() {

        History = new History();
        HistoryTab = new HistoryTab(History);




        InitializeComponent();


        webView.NavigationStarting += AddHistory;

        }

    void AddHistory(object sender, CoreWebView2NavigationStartingEventArgs args) {
        var uri = args.Uri;


        HistoryTab.AddEntry(uri);

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
