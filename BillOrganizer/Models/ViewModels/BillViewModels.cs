using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BillOrganizer.Models.ViewModels
{
    public class BillViewModels
    {
        [Key]
        [Display(Name = "ID")]
        public int ID { get; set; }
        [Display(Name = "類別")]
        public string Type { get; set; }
        [Display(Name = "日期")]
        public DateTime CreateDate { get; set; }
        [Display(Name = "金額")]
        public int Money { get; set; }
        [Display(Name = "備註")]
        public string Remark { get; set; }
    }
}