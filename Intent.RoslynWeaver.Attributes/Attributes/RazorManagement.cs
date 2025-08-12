using System;

namespace Intent.RoslynWeaver.Attributes
{
    public static class Intent
    {
        public static string Fully = string.Empty;
        public static string FullyBody = string.Empty;
        public static string FullySignature = string.Empty;
        public static string Ignore = string.Empty;
        public static string IgnoreBody = string.Empty;
        public static string IgnoreSignature = string.Empty;
        public static string Merge = string.Empty;
        public static string MergeBody = string.Empty;
        public static string MergeSignature = string.Empty;

        /// <summary>
        /// This element is matched against the element at the specified XPath-like <paramref name="path"/>,
        /// see the <see href="https://intentarchitect.com/redirect/bGkzQ7Pq">documentation</see> for
        /// further details.
        /// </summary>
        public static string Match(string path) => string.Empty;

        public static string FullyAttributes(params string[] attributes) => string.Empty;
        public static string IgnoreAttributes(params string[] attributes) => string.Empty;
        public static string MergeAttributes(params string[] attributes) => string.Empty;

        public class SkipAttribute : Attribute
        {
            /// <summary>
            /// Elements at the specified XPath-like <paramref name="paths"/> in the template are
            /// skipped over and not added to the existing file. See the
            /// <see href="https://intentarchitect.com/redirect/bGkzQ7Pq">documentation</see> for
            /// further details.
            /// </summary>
            public SkipAttribute(params string[] paths) { }
        }
    }
}
