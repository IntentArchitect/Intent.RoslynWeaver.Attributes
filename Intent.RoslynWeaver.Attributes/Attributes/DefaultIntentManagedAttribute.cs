using System;

namespace Intent.RoslynWeaver.Attributes
{
    [AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Interface | AttributeTargets.Struct, AllowMultiple = true)]
    public class DefaultIntentManagedAttribute : Attribute
    {
        public DefaultIntentManagedAttribute(Mode elementMode)
        {
        }

        public AccessModifiers AccessModifiers { get; set; }
        public Targets Targets { get; set; }
        public Mode Signature { get; set; }
        public Mode Body { get; set; }
        public Mode Comments { get; set; }
        public Mode Attributes { get; set; }
    }
}
