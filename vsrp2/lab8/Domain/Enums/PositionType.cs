using System.ComponentModel;

namespace Domain.Enums
{
    public enum PositionType
    {
        [Description("Unknown")]
        Unknown = 0,
        [Description("Начальник")]
        Admin = 1,
        [Description("Отдел продаж")]
        Manager = 2,
        [Description("Бухгалтер")]
        Accountant = 3
    }
}
