using System.ComponentModel;

namespace lab2.Models.Enums
{
    public enum ConstructionStatusType
    {
        [Description("Planning")]
        Planning = 0,

        [Description("In progress")]
        InProgress = 1,

        [Description("Built")]
        Built = 2,

        [Description("In operation")]
        InOperation = 3
    }
}
