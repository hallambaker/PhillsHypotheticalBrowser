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


using Goedel.Mesh;
using Goedel.Phb.Locate;
using Goedel.Utilities;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
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
public partial class MainWindow : Window, IBrowserTab {

    #region Properties
    public History History { get; }
    public HistoryTab HistoryTab { get; }

    Locate Locate { get; }


    IMeshMachine MeshMachine { get; }
    MeshHost MeshHost { get; }

    ContextUser? ContextUser { get; }

    ///<inheritdoc/>
    public string Description { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    ///<inheritdoc/>
    public string Favicon { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    #endregion
    #region Constructor
    public MainWindow() {

        MeshMachine = new MeshMachineCore();
        MeshHost = MeshHost.GetCatalogHost(MeshMachine);
        ContextUser = MeshHost.GetContextMesh() as ContextUser;




        History = new History();
        HistoryTab = new HistoryTab(History);

        Locate = new() {
            BrowserTab = this
            };


        InitializeComponent();
        InitializeCore(webView);

        //webView.NavigationStarting += AddHistory;


        //var coreWebView2Environment = new CoreWebView2Environment() {
        //    }


        } 
    #endregion

    async void InitializeCore(WebView2 webView2) {
        await webView2.EnsureCoreWebView2Async();

        var core = webView2.CoreWebView2;
        //core.AddWebResourceRequestedFilter("*", CoreWebView2WebResourceContext.Document);

        core.AddWebResourceRequestedFilter("*", CoreWebView2WebResourceContext.All) ;

        core.WebResourceRequested += Locate.ProcessLocate;

        core.SourceChanged += Locate.SourceChanged;
        core.WebResourceResponseReceived += Locate.WebResourceResponseReceived;
        core.NavigationCompleted += Locate.ProcessNavigateComplete;
        Locate.Environment = core.Environment;
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
    #region Implement IBrowserTab methods

    public void ContentLoadingBegin() {
        throw new NotImplementedException();
        }

    public void ContentLoadingEnd() {
        throw new NotImplementedException();
        }

    public void QueueDownload(string Uri) {
        throw new NotImplementedException();
        }

    public Stream DecodeDare(HttpResponseMessage response) {
        var ciphertext = new MemoryStream();
        var plaintext = new MemoryStream();

        response.Content.CopyToAsync(ciphertext).Wait();


        var ciphertextArray = ciphertext.ToArray();
        ciphertext.Position = 0;



        var length = DareEnvelope.Decode(ciphertext, plaintext, keyCollection:ContextUser);

        var text = plaintext.ToArray().ToUTF8();

        Console.WriteLine($"   Stream read {plaintext.Length} out of {response.Content.Headers.ContentLength}");
        Console.WriteLine(text);

        response.Content.Headers.Remove("Content-Type");
        response.Content.Headers.Add("Content-Type", "text/html");
        response.Content.Headers.Remove("Content-Length");
        response.Content.Headers.Add("Content-Length", plaintext.Length.ToString());



        plaintext.Position = 0;
        return plaintext;
        }
    #endregion
    }
