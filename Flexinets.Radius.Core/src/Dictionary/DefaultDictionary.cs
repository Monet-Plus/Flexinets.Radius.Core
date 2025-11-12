namespace Flexinets.Radius.Core
{
    /// <summary>
    /// Contains the default dictionary found in radius.dictionary.
    /// </summary>
    public static class DefaultDictionary
    {

        private static string LoadDictionaryFromEmbededResource()
        {
            var assembly = typeof(DefaultDictionary).Assembly;
            using var stream = assembly.GetManifestResourceStream("Flexinets.Radius.Core.Content.radius.dictionary");
            using var reader = new System.IO.StreamReader(stream!);
            return reader.ReadToEnd();
        }

        public static readonly string RadiusDictionary = LoadDictionaryFromEmbededResource();

   }
}