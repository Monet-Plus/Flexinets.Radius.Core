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
