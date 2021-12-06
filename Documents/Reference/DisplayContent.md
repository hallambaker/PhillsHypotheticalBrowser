# Inject content into a window

This is the big goal for being able to display decrypted files, archives, etc.


* Hook the URI handler [AddWebResourceRequestedFilter](https://docs.microsoft.com/en-us/dotnet/api/microsoft.web.webview2.core.corewebview2.addwebresourcerequestedfilter?view=webview2-dotnet-1.0.1054.31#Microsoft_Web_WebView2_Core_CoreWebView2_AddWebResourceRequestedFilter_System_String_Microsoft_Web_WebView2_Core_CoreWebView2WebResourceContext_)

* Add an event handler [CoreWebView2.WebResourceRequested](https://docs.microsoft.com/en-us/dotnet/api/microsoft.web.webview2.core.corewebview2.webresourcerequested?view=webview2-dotnet-1.0.1054.31)

* Event created is [CoreWebView2WebResourceRequestedEventArgs](https://docs.microsoft.com/en-us/dotnet/api/microsoft.web.webview2.core.corewebview2webresourcerequestedeventargs.response?view=webview2-dotnet-1.0.1054.31)

* Generate the response using [CreateWebResourceResponse](https://docs.microsoft.com/en-us/dotnet/api/microsoft.web.webview2.core.corewebview2environment.createwebresourceresponse?view=webview2-dotnet-1.0.1054.31#Microsoft_Web_WebView2_Core_CoreWebView2Environment_CreateWebResourceResponse_System_IO_Stream_System_Int32_System_String_System_String_)


* Set the [Response property](https://docs.microsoft.com/en-us/dotnet/api/microsoft.web.webview2.core.corewebview2webresourceresponse?view=webview2-dotnet-1.0.1054.31) to complete the request


Sample code:

'''

'''

