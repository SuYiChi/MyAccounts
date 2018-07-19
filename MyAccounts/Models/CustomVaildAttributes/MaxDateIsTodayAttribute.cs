using System;
using System.ComponentModel.DataAnnotations;

namespace MyAccounts.Models.CustomVaildAttributes
{
    public class MaxDateIsTodayAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            var compareDate = value as DateTime?;
            if (compareDate.HasValue)
            {
                compareDate = compareDate.Value.Date;
                return compareDate.Value <= DateTime.Today.Date;
            }
            return false;
        }
    }
}