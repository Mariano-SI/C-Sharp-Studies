namespace System
{
    static class StringExtensions
    {

        public static string Cut(this string originalString, int cutLength)
        {
            if(originalString.Length <= cutLength)
            {
                return originalString;
            }
            else
            {
                return originalString.Substring(0, cutLength) + "...";
            }
        }
    }
}
