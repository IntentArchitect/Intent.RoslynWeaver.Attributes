using System;

namespace Intent.RoslynWeaver.Attributes
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface | AttributeTargets.Constructor | AttributeTargets.Field | AttributeTargets.Property | AttributeTargets.Method | AttributeTargets.Enum | AttributeTargets.Struct , AllowMultiple=true)]
    public class IntentManagedAttribute : Attribute
    {
        public IntentManagedAttribute(Mode elementMode)
        {
        }

        public Mode Signature { get; set; }
        public Mode Body { get; set; }
    }
}
