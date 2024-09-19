using System;
using System.Diagnostics;

namespace Intent.RoslynWeaver.Attributes
{
    // By making this conditional upon a compilation symbol which should never be set, code using
    // this attribute will never include the attribute when compiled, and thus, it will not be
    // available through reflection at runtime.
    //
    // Without this, if anything had this attribute applied and any runtime code was reflecting any
    // kind of attribute (EG: DescriptionAttribute on a class, or assembly attributes), then you
    // would need to ensure that Intent.RoslynWeaver.Attributes.dll of at least the same version
    // which the module was compiled against is also included, otherwise an exception would be
    // thrown that Intent.RoslynWeaver.Attributes.dll version x.x.x was not found.
    //
    // For modules which generate C# code this wasn't normally a problem as the RoslynWeaver module
    // would ship with the latest version of the NuGet package, but for other language modules
    // (EG: Java, TypeScript), they didn't have the RoslynWeaverModule installed and this error
    // would occur unless they're running a version of Intent which includes the required version
    // of the NuGet package.
    [Conditional("INTENT_ROSLYN_WEAVER_ATTRIBUTES")]
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Constructor | AttributeTargets.Delegate | AttributeTargets.Enum | AttributeTargets.Event | AttributeTargets.Field | AttributeTargets.GenericParameter | AttributeTargets.Interface | AttributeTargets.Method | AttributeTargets.Parameter | AttributeTargets.Property | AttributeTargets.ReturnValue | AttributeTargets.Struct , AllowMultiple=true)]
    public class IntentManagedAttribute : Attribute
    {
        public IntentManagedAttribute(Mode elementMode)
        {
        }

        public Mode Signature { get; set; }
        public Mode Body { get; set; }
        public Mode Comments { get; set; }
        public Mode Attributes { get; set; }
    }
}
