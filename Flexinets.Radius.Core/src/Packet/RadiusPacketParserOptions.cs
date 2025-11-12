namespace Flexinets.Radius.Core
{
    public class RadiusPacketParserOptions
    {
        /// <summary>
        /// Skip BLASTRadius checks when parsing packets
        /// </summary>
        public bool SkipBlastRadiusChecks { get; init; } = false;
    }
}

namespace System.Runtime.CompilerServices
{
#pragma warning disable S2094 // Classes should not be empty
    public class IsExternalInit { }
#pragma warning restore S2094 // Classes should not be empty
}