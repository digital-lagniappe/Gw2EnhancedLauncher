using System.Text;

namespace Gw2EnhancedLauncher
{
    internal static class StringBuilderExtensions
    {
        public static StringBuilder AppendIf(this StringBuilder sb, string text, bool predicate)
        {
            if (predicate)
            {
                sb.Append(text);
            }

            return sb;
        }
    }
}
