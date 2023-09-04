using System;

namespace Intent.RoslynWeaver.Attributes
{
    [Flags]
    public enum Targets
    {
        Classes = 0x0000_0001,
        Methods = 0x0000_0002,
        Constructors = 0x0000_0004,
        Fields = 0x0000_0008,
        Properties = 0x0000_0010,
        Interfaces = 0x0000_0020,
        Enums = 0x0000_0040,
        Namespaces = 0x0000_0080,
        Usings = 0x0000_0100,
        Operators = 0x0000_0200,
        OperatorConversions = 0x0000_0400,
        Structs = 0x0000_0800,
        Records = 0x0000_1000,
        EnumMembers = 0x0000_2000,
        Delegates = 0x0000_4000,
        TopLevelStatements = 0x0000_8000,
        EventField = 0x0001_0000
    }
}
