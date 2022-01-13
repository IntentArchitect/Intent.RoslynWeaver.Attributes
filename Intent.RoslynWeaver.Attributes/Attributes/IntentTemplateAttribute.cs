using System;

namespace Intent.RoslynWeaver.Attributes
{
    [AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
    public class IntentTemplateAttribute : Attribute
    {
        public IntentTemplateAttribute(string name)
        {
        }

        public string Version { get; set; }
    }
}
