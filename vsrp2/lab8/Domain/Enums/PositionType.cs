using System.ComponentModel;

namespace Domain.Enums
{
    public enum PositionType
    {
        [Description("Unknown")]
        Unknown = 0,
        [Description("Manager")]
        Manager = 1,
        [Description("Accountant")]
        Accountant = 2
    }
}
