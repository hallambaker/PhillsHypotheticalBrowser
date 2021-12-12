namespace Goedel.Phb.Locate;

public partial class Locate {
    
    
    // Constructor
    public Locate() {
        }



    public void ProcessLocate(object? sender, CoreWebView2WebResourceRequestedEventArgs args) {



        try {
            var uri = new Uri(args?.Request?.Uri);
            switch (uri.Scheme) {
                case "earl": {
                        ProcessEarl(sender, args);
                        break;
                        }
                case "httpm": {
                        ProcessHttp(sender, args);
                        break;
                        }
                }
            }
        catch {
            // Ignore exceptions for now.
            }
        }


    public void ProcessEarl (object? sender, CoreWebView2WebResourceRequestedEventArgs args) {

        }

    public void ProcessHttp(object? sender, CoreWebView2WebResourceRequestedEventArgs args) {

        }





    }
