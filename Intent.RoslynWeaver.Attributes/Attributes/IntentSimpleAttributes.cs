using System;
using System.Diagnostics;

namespace Intent.RoslynWeaver.Attributes
{
    // By making these conditional upon a compilation symbol which should never be set, code using
    // these attributes will never include them when compiled, and thus, they will not be
    // available through reflection at runtime.
    //
    // Without this, if anything had any of these attributes applied and any runtime code was reflecting any
    // kind of them (EG: DescriptionAttribute on a class, or assembly attributes), then you
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
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface | AttributeTargets.Constructor | AttributeTargets.Field | AttributeTargets.Property | AttributeTargets.Method | AttributeTargets.Enum | AttributeTargets.Struct)]
    public class IntentFullyAttribute : Attribute { }

    [Conditional("INTENT_ROSLYN_WEAVER_ATTRIBUTES")]
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface | AttributeTargets.Constructor | AttributeTargets.Field | AttributeTargets.Property | AttributeTargets.Method | AttributeTargets.Enum | AttributeTargets.Struct)]
    public class IntentFullyAttributesAttribute : Attribute { }

    [Conditional("INTENT_ROSLYN_WEAVER_ATTRIBUTES")]
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface | AttributeTargets.Constructor | AttributeTargets.Field | AttributeTargets.Property | AttributeTargets.Method | AttributeTargets.Enum | AttributeTargets.Struct)]
    public class IntentFullyBodyAttribute : Attribute { }

    [Conditional("INTENT_ROSLYN_WEAVER_ATTRIBUTES")]
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface | AttributeTargets.Constructor | AttributeTargets.Field | AttributeTargets.Property | AttributeTargets.Method | AttributeTargets.Enum | AttributeTargets.Struct)]
    public class IntentFullyCommentsAttribute : Attribute { }

    [Conditional("INTENT_ROSLYN_WEAVER_ATTRIBUTES")]
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface | AttributeTargets.Constructor | AttributeTargets.Field | AttributeTargets.Property | AttributeTargets.Method | AttributeTargets.Enum | AttributeTargets.Struct)]
    public class IntentFullySignatureAttribute : Attribute { }

    [Conditional("INTENT_ROSLYN_WEAVER_ATTRIBUTES")]
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface | AttributeTargets.Constructor | AttributeTargets.Field | AttributeTargets.Property | AttributeTargets.Method | AttributeTargets.Enum | AttributeTargets.Struct)]
    public class IntentIgnoreAttribute : Attribute { }

    [Conditional("INTENT_ROSLYN_WEAVER_ATTRIBUTES")]
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface | AttributeTargets.Constructor | AttributeTargets.Field | AttributeTargets.Property | AttributeTargets.Method | AttributeTargets.Enum | AttributeTargets.Struct)]
    public class IntentIgnoreAttributesAttribute : Attribute { }

    [Conditional("INTENT_ROSLYN_WEAVER_ATTRIBUTES")]
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface | AttributeTargets.Constructor | AttributeTargets.Field | AttributeTargets.Property | AttributeTargets.Method | AttributeTargets.Enum | AttributeTargets.Struct)]
    public class IntentIgnoreBodyAttribute : Attribute { }

    [Conditional("INTENT_ROSLYN_WEAVER_ATTRIBUTES")]
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface | AttributeTargets.Constructor | AttributeTargets.Field | AttributeTargets.Property | AttributeTargets.Method | AttributeTargets.Enum | AttributeTargets.Struct)]
    public class IntentIgnoreCommentsAttribute : Attribute { }

    [Conditional("INTENT_ROSLYN_WEAVER_ATTRIBUTES")]
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface | AttributeTargets.Constructor | AttributeTargets.Field | AttributeTargets.Property | AttributeTargets.Method | AttributeTargets.Enum | AttributeTargets.Struct)]
    public class IntentIgnoreSignatureAttribute : Attribute { }

    [Conditional("INTENT_ROSLYN_WEAVER_ATTRIBUTES")]
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface | AttributeTargets.Constructor | AttributeTargets.Field | AttributeTargets.Property | AttributeTargets.Method | AttributeTargets.Enum | AttributeTargets.Struct)]
    public class IntentMergeAttribute : Attribute { }

    [Conditional("INTENT_ROSLYN_WEAVER_ATTRIBUTES")]
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface | AttributeTargets.Constructor | AttributeTargets.Field | AttributeTargets.Property | AttributeTargets.Method | AttributeTargets.Enum | AttributeTargets.Struct)]
    public class IntentMergeAttributesAttribute : Attribute { }

    [Conditional("INTENT_ROSLYN_WEAVER_ATTRIBUTES")]
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface | AttributeTargets.Constructor | AttributeTargets.Field | AttributeTargets.Property | AttributeTargets.Method | AttributeTargets.Enum | AttributeTargets.Struct)]
    public class IntentMergeBodyAttribute : Attribute { }

    [Conditional("INTENT_ROSLYN_WEAVER_ATTRIBUTES")]
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface | AttributeTargets.Constructor | AttributeTargets.Field | AttributeTargets.Property | AttributeTargets.Method | AttributeTargets.Enum | AttributeTargets.Struct)]
    public class IntentMergeCommentsAttribute : Attribute { }

    [Conditional("INTENT_ROSLYN_WEAVER_ATTRIBUTES")]
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface | AttributeTargets.Constructor | AttributeTargets.Field | AttributeTargets.Property | AttributeTargets.Method | AttributeTargets.Enum | AttributeTargets.Struct)]
    public class IntentMergeSignatureAttribute : Attribute { }

    [Conditional("INTENT_ROSLYN_WEAVER_ATTRIBUTES")]
    [AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
    public class IntentTagModeExplicitAttribute : Attribute { }

    [Conditional("INTENT_ROSLYN_WEAVER_ATTRIBUTES")]
    [AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
    public class IntentTagModeImplicitAttribute : Attribute { }
}