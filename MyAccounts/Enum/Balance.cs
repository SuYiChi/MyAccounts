using System.ComponentModel.DataAnnotations;

namespace MyAccounts.Enum
{
    public enum Balance
    {
        [Display(Name = "支出")]
        Expend = 1,
        [Display(Name = "收入")]
        Income = 2
    }
}