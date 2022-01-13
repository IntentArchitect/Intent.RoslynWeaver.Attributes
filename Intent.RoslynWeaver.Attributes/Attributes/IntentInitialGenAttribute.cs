using System;

namespace Intent.RoslynWeaver.Attributes
{
    [AttributeUsage( AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Field | AttributeTargets.Property)]
    public class IntentInitialGenAttribute : Attribute
    {
    }
}
