using System;

namespace Intent.RoslynWeaver.Attributes
{
    public static class Intent
    {
        /// <summary>
        /// This element must be fully managed by the code weaver and any user changes should
        /// be removed.
        /// </summary>
        /// <param name="path">
        /// Optional. Move the element's location from where it was in the generated content based
        /// on the provided <see href="https://intentarchitect.com/redirect/bGkzQ7Pq">path</see>.
        /// </param>
        public static string Fully(string path = null) => string.Empty;

        /// <summary>
        /// The <paramref name="attributes">specified</paramref> attributes of this element must
        /// be fully managed by the code weaver and any user changes should be removed.
        /// </summary>
        /// <param name="attributes">One more attribute names which this instruction applies to.</param>
        public static string FullyAttributes(params string[] attributes) => string.Empty;

        /// <summary>
        /// The body content of this element must be fully managed by the code weaver and any
        /// user changes should be removed.
        /// </summary>
        /// <param name="path">
        /// Optional. Move the element's location from where it was in the generated content based
        /// on the provided <see href="https://intentarchitect.com/redirect/bGkzQ7Pq">path</see>.
        /// </param>
        public static string FullyBody(string path = null) => string.Empty;

        /// <summary>
        /// The signature content of this element must be fully managed by the code weaver and
        /// any user changes should be removed.
        /// </summary>
        /// <param name="path">
        /// Optional. Move the element's location from where it was in the generated content based
        /// on the provided <see href="https://intentarchitect.com/redirect/bGkzQ7Pq">path</see>.
        /// </param>
        public static string FullySignature(string path = null) => string.Empty;

        /// <summary>
        /// This element must be ignored by the code weaver.
        /// </summary>
        /// <param name="path">
        /// Optional. Move the element's location from where it was in the generated content based
        /// on the provided <see href="https://intentarchitect.com/redirect/bGkzQ7Pq">path</see>.
        /// </param>
        public static string Ignore(string path = null) => string.Empty;

        /// <summary>
        /// The specified <paramref name="attributes"/> of this element must be ignored by the code
        /// weaver.
        /// </summary>
        /// <param name="attributes">One more attribute names which this instruction applies to.</param>
        public static string IgnoreAttributes(params string[] attributes) => string.Empty;

        /// <summary>
        /// The body content of this element must be ignored by the code weaver.
        /// </summary>
        /// <param name="path">
        /// Optional. Move the element's location from where it was in the generated content based
        /// on the provided <see href="https://intentarchitect.com/redirect/bGkzQ7Pq">path</see>.
        /// </param>
        public static string IgnoreBody(string path = null) => string.Empty;

        /// <summary>
        /// The signature content of this element must be ignored by the code weaver.
        /// </summary>
        /// <param name="path">
        /// Optional. Move the element's location from where it was in the generated content based on the provided <see href="https://intentarchitect.com/redirect/bGkzQ7Pq">path</see>.
        /// </param>
        public static string IgnoreSignature(string path = null) => string.Empty;

        /// <summary>
        /// This element must be merged by the code weaver, any user changes to it should be ignored
        /// while changes from the template should be applied.
        /// </summary>
        /// <param name="path">
        /// Optional. Move the element's location from where it was in the generated content based
        /// on the provided <see href="https://intentarchitect.com/redirect/bGkzQ7Pq">path</see>.
        /// </param>
        public static string Merge(string path = null) => string.Empty;

        /// <summary>
        /// The specified <paramref name="attributes"/> of this element must be merged by the code
        /// weaver, any user changes to it should be ignored while changes from the template should
        /// be applied.
        /// </summary>
        /// <param name="attributes">One more attribute names which this instruction applies to.</param>
        public static string MergeAttributes(params string[] attributes) => string.Empty;

        /// <summary>
        /// The body content of this element must be merged by the code weaver, any user changes
        /// to it should be ignored while changes from the template should be applied.
        /// </summary>
        /// <param name="path">
        /// Optional. Move the element's location from where it was in the generated content based
        /// on the provided <see href="https://intentarchitect.com/redirect/bGkzQ7Pq">path</see>.
        /// </param>
        public static string MergeBody(string path = null) => string.Empty;

        /// <summary>
        /// The signature content of this element must be merged by the code weaver, any user
        /// changes to it should be ignored while changes from the template should be applied.
        /// </summary>
        /// <param name="path">
        /// Optional. Move the element's location from where it was in the generated content based
        /// on the provided <see href="https://intentarchitect.com/redirect/bGkzQ7Pq">path</see>.
        /// </param>
        public static string MergeSignature(string path = null) => string.Empty;

        /// <summary>
        /// This element's location should be moved from where it was in the generated output as
        /// specified by the provided <paramref name="path"/>.
        /// </summary>
        /// <param name="path">
        /// The original <see href="https://intentarchitect.com/redirect/bGkzQ7Pq">path</see> of the
        /// element in the generated content.
        /// </param>
        public static string MoveHere(string path) => string.Empty;

        /// <summary>
        /// Elements at the specified <paramref name="paths"/> in the generated output are skipped
        /// over and not added to the existing file.
        /// </summary>
        /// <param name="paths">
        /// The <see href="https://intentarchitect.com/redirect/bGkzQ7Pq">paths</see> of the
        /// elements in the generated content to skip over.
        /// </param>
        public static string Skip(params string[] paths) => string.Empty;

        public class SkipAttribute : Attribute
        {
            /// <summary>
            /// Elements at the specified <paramref name="paths"/> in the generated output are skipped
            /// over and not added to the existing file.
            /// </summary>
            /// <param name="paths">
            /// The <see href="https://intentarchitect.com/redirect/bGkzQ7Pq">paths</see> of the
            /// elements in the generated content to skip over.
            /// </param>
            public SkipAttribute(params string[] paths) { }
        }
    }
}
