using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goedel.Utilities;

/// <summary>
/// Base class for language resources.
/// </summary>
public abstract class Language {

    public delegate Stream? GetStreamDelegate();


    #region // Properties and fields

    public abstract Dictionary <string, Stream?> DictionaryStreams { get; }


    ///<summary>Resource name prefix for files.</summary> 
    protected abstract string DefaultNamespace { get; }

    ///<summary>Return the executing assembly.</summary> 
    protected Assembly ExecutingAssembly = Assembly.GetExecutingAssembly();

    #endregion
    #region // Protected methods

    /// <summary>
    /// Return the resource name of the file <paramref name="resource"/>.
    /// </summary>
    /// <param name="resource">The file name.</param>
    /// <returns>The resource name.</returns>
    protected string ResourceName(string resource) => $"{DefaultNamespace}.{resource}";

    #endregion

    }
