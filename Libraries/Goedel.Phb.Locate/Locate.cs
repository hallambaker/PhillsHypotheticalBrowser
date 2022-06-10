using Goedel.Phb.Language.En.Gb;

namespace Goedel.Phb.Locate;



public class SiteProfile {


    public string Name { get; set; } = "Sites";

    public bool IsMuted { get; set; } = true;

    public void Apply (CoreWebView2 webview) {

        webview.IsMuted = true;
        }
    }


public partial class Locate {

    public IBrowserTab BrowserTab { get; init; }

    public SiteProfile DefaultSiteProfile { get; set; } = new SiteProfile() {
        Name = "Default" };


    public SiteProfile AduioSiteProfile { get; set; } = new SiteProfile() {
        Name = "Audio",
        IsMuted = false };



    public Dictionary<string, string> DictionarySiteToProfileName { get; } = new();

    public Dictionary<string, SiteProfile> DictionaryProfileNameToProfile { get; } = new();

    public CoreWebView2Environment Environment { get; set; }

    public SiteProfile GetSiteProfile(Uri uri) {



        return DefaultSiteProfile;
        }



    public LanguagePhb LanguagePhb { get; set; } = new();



    // Constructor
    public Locate() {

        // hard code the default audio config for now.
        // This should all be user configurable of course.
        DictionaryProfileNameToProfile.Add(DefaultSiteProfile.Name, DefaultSiteProfile);
        DictionaryProfileNameToProfile.Add(AduioSiteProfile.Name, AduioSiteProfile);

        DictionarySiteToProfileName.Add("netflix.com", AduioSiteProfile.Name);
        DictionarySiteToProfileName.Add("youtube.com", AduioSiteProfile.Name);
        DictionarySiteToProfileName.Add("vimeo.com", AduioSiteProfile.Name);


        //Resolver = new() {
        //    LanguagePhb = LanguagePhb
        //    };
        }



    public void SourceChanged(object? sender, CoreWebView2SourceChangedEventArgs args) {

        CoreWebView2 webview = (sender as CoreWebView2)!;


        //Console.WriteLine($"Source changed {args.IsNewDocument}");

        }

    public void WebResourceResponseReceived(object? sender, CoreWebView2WebResourceResponseReceivedEventArgs args) {

        CoreWebView2 webview = (sender as CoreWebView2)!;


        //Console.WriteLine($"Response received");

        }



    public void ProcessLocate(object? sender, CoreWebView2WebResourceRequestedEventArgs args) {

        CoreWebView2 webview = (sender as CoreWebView2)!;
        Console.WriteLine($"Get {args?.Request?.Uri}");
        try {
            var uri = new Uri(args?.Request?.Uri ?? "");
            switch (uri.Scheme) {
                case "earl": {
                        ProcessEarl(webview, args);
                        break;
                        }
                case "https":
                case "http": {
                        ProcessHttp(webview, uri, args);
                        break;
                        }
                }
            }
        catch {
            // Ignore exceptions for now.
            }
        }


    public void ProcessEarl (CoreWebView2 sender, CoreWebView2WebResourceRequestedEventArgs? args) {

        var stream = LanguagePhb.AccessDenied;

        //CreateWebResourceResponse(Stream, Int32, String, String)

        }

    public void ProcessHttp(
                CoreWebView2 webview, 
                Uri uri, 
                CoreWebView2WebResourceRequestedEventArgs args) {
        //if (args.ResourceContext == CoreWebView2WebResourceContext.Document) {

        //    }
        //var siteProfile = GetSiteProfile(uri);
        //siteProfile.Apply(webview);


        var request = args.Request;

        //Console.WriteLine($"Test {uri}, {request.Method} ");
        //foreach (var header in request.Headers) {
        //    Console.WriteLine($"    {header.Key}, {header.Value}");
        //    }
        args.Response = WebResourceRequest(uri, args.Request, args.ResourceContext);


        }


    public void ProcessNavigateComplete(object? sender, CoreWebView2NavigationCompletedEventArgs? args) {
        var webview = sender as CoreWebView2;
        webview!.IsMuted = true;
        }


    }
