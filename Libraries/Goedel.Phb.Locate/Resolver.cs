

using Goedel.Phb.Language.En.Gb;



namespace Goedel.Phb.Locate;
public partial class Locate {

    //public LanguagePhb LanguagePhb { get; init; }


    //public CoreWebView2Environment CoreWebView2Environment { get; init; }


    //public Resolver() {
    //    }

    // Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/102.0.5005.63 Safari/537.36 Edg/102.0.1245.30

    static readonly HttpClient client = new HttpClient();


    public CoreWebView2WebResourceResponse WebResourceRequest(
                Uri uri,
                CoreWebView2WebResourceRequest request,
                CoreWebView2WebResourceContext resourceContext) {

        // Convert the request
        var requestMessage = new HttpRequestMessage(GetMethod(request.Method), request.Uri);
        foreach (var header in request.Headers) {
            requestMessage.Headers.Add(header.Key, header.Value);
            }
        //requestMessage.Headers.UserAgent = "fred";

        //Console.WriteLine($"  Start");
        // Perform the method
        var result = client.Send(requestMessage, HttpCompletionOption.ResponseHeadersRead);
        //Console.WriteLine($"  End");

        //var stream = new MemoryStream();
        //result.Content.SerializeToStream(stream, null);


        Stream stream;
        if (result.Content.Headers.ContentType?.MediaType == "application/dare") {
            stream = BrowserTab.DecodeDare(result);
            }
        else {

             stream = ReadStream(result);
            }
        // Convert the response
        var response = Environment.CreateWebResourceResponse(
                        stream, 
                        (int)result.StatusCode, 
                        result.ReasonPhrase, "");
        foreach (var header in result.Headers.NonValidated) {
            foreach (var value in header.Value) {
                response.Headers.AppendHeader(header.Key, value);
                }
            }
        foreach (var header in result.Content.Headers.NonValidated) {
            foreach (var value in header.Value) {
                response.Headers.AppendHeader(header.Key, value);
                }
            }

        //Console.WriteLine($"   Result {(int)result.StatusCode} {result.ReasonPhrase}");
        return response;
        }


    Stream ReadStream(HttpResponseMessage response) {
        var stream = new MemoryStream();

        response.Content.CopyToAsync(stream).Wait();


        var text = stream.ToArray().ToUTF8;


        //Console.WriteLine($"   Stream read {stream.Position} out of {response.Content.Headers.ContentLength}");
        //Console.WriteLine(text);

        stream.Position = 0;
        return stream;
        }



    HttpMethod GetMethod(string method) => method switch {
        "GET" => HttpMethod.Get,
        "PUT" => HttpMethod.Put,
        "POST" => HttpMethod.Post,
        "DELETE" => HttpMethod.Delete,
        "OPTIONS" => HttpMethod.Options,
        "PATCH" => HttpMethod.Patch,
        "TRACE" => HttpMethod.Trace,
        _ => HttpMethod.Get
        };



    }

public class BufferedStream : Stream {

    Stream Stream { get; }
    public MemoryStream Buffer { get; }

    public override bool CanRead => true;

    public override bool CanSeek => true;

    public override bool CanWrite => false;

    public override long Length => throw new NotImplementedException();

    public override long Position { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public override void Flush() {
        throw new NotImplementedException();
        }

    public override int Read(byte[] buffer, int offset, int count) {
        throw new NotImplementedException();
        }

    public override long Seek(long offset, SeekOrigin origin) {
        throw new NotImplementedException();
        }

    public override void SetLength(long value) {
        throw new NotImplementedException();
        }

    public override void Write(byte[] buffer, int offset, int count) {
        throw new NotImplementedException();
        }


    public BufferedStream(Stream stream, int length) {
        Stream = stream;
        Buffer = new MemoryStream(length);
        }

    }
