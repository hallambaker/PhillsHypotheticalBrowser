using Microsoft.Extensions.Logging;

namespace TestMessageAttribute;

public partial class Class1 {
    /// <summary>
    /// Write an event of type ListenerStart to <paramref name="logger"/> 
    /// </summary>
    /// <param name="logger">The logger to write the output to.</param>
    /// <param name="_exception">Exception (if thrown)</param>
    [LoggerMessage(
        1,
        LogLevel.Information,
       "Starting Listener")]
    public static partial void ListenerStart(
        ILogger logger);
    }
