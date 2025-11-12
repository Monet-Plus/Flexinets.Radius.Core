
namespace System.Runtime.CompilerServices
{

    /// <summary>
    /// Marker class to enable 'init' properties in C# 9.0 when targeting earlier frameworks.
    /// </summary>

#pragma warning disable S2094 // Classes should not be empty
    public class IsExternalInit { }
#pragma warning restore S2094 // Classes should not be empty
}