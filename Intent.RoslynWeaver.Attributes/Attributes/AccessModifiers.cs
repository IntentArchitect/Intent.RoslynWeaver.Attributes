using System;

namespace Intent.RoslynWeaver.Attributes
{
    [Flags]
    public enum AccessModifiers
    {
        None = 0,
        Private = 1,
        Protected = 2,
        Internal = 4,
        Public = 8,
    }
}
