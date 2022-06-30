using System;

namespace Intent.RoslynWeaver.Attributes
{
    [Flags]
    public enum Targets
    {
        Classes = 1,
        Methods = 2,
        Constructors = 4,
        Fields = 8,
        Properties = 16,
        Interfaces = 32,
        Enums = 64,
        Namespaces = 128,
        Usings = 256,
        Operators = 512,
        OperatorConversions = 1024,
        Structs = 2048,
        Records = 4096,
        EnumMembers = 8192,
        Delegates = 16384,
        TopLevelStatements = 32768
    }
}
