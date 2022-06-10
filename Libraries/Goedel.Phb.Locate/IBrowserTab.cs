namespace Goedel.Phb.Locate;

/// <summary>
/// Interface for interacting with the browser window/tab.
/// </summary>
public interface IBrowserTab {

    ///<summary>When true, the window is visible.</summary> 
    bool IsVisible { get; }

    ///<summary>The tab description text.</summary> 
    string Description { get; set; }

    ///<summary>The favicon icon URI.</summary> 
    string Favicon { get; set; }


    /// <summary>
    /// Called when content loading begins.
    /// </summary>
    void ContentLoadingBegin();

    /// <summary>
    /// Called when content loading ends.
    /// </summary>
    void ContentLoadingEnd();

    /// <summary>
    /// Queue the content at the URI <paramref name="Uri"/> for download
    /// according to the download manager settings.
    /// </summary>
    /// <param name="Uri"></param>
    void QueueDownload(string Uri);


    public Stream DecodeDare(HttpResponseMessage source);



    }
