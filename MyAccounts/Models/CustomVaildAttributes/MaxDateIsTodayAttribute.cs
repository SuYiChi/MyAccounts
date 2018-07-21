using System;
using System.ComponentModel.DataAnnotations;

namespace MyAccounts.Models.CustomVaildAttributes
{
    public sealed class MaxDateIsTodayAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            // 權責分清楚，沒輸入在這個驗證中不算錯。
            if (value == null)
            {
                return true;
            }

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