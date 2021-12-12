

namespace Goedel.Phb.LanguagePhb;

public class LanguagePhb : Language {

    #region // Boilerplate

    ///<inheritdoc/>
    protected override string DefaultNamespace => "Goedel.Phb.Language";

    ///<summary>If specified, specifies one or more alternative resources overriding those
    ///in this specification.</summary>  
    public LanguagePhb? Culture { get; set; } = null;

    ////<inheritdoc/>
    public override Dictionary<string, Stream?> DictionaryStreams { get; }



    #endregion
    #region // Constructor.

    public LanguagePhb() {
        DictionaryStreams = new() {
                { "AccessDenied", AccessDenied }


            };
        }


    #endregion
    #region // Properties mapping resource files to streams.

    ///<summary>Resource file Access denied.</summary> 
    public virtual Stream? AccessDenied => Culture?.AccessDenied ??
        ExecutingAssembly.GetManifestResourceStream(ResourceName("AccessDenied.html"));



    #endregion
    }
