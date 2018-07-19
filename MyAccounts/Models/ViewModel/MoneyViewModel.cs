using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using MyAccounts.Enum;
using MyAccounts.Models.CustomVaildAttributes;

namespace MyAccounts.Models.ViewModel
{
    public class MoneyViewModel
    {
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "請選擇{0}")]
        [DisplayName("類別")]
        public Balance Category { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "{0}只能輸入正整數")]
        [DisplayName("金額")]
        public int Amount { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [MaxDateIsToday(ErrorMessage = "日期不能超過今天")]
        [DisplayName("日期")]
        public DateTime Date { get; set; }

        [Required]
        [MaxLength(100, ErrorMessage = "{0}最多輸入100個字元")]
        [DisplayName("備註")]
        public string Description { get; set; }
    }
}