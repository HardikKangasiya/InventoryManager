//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InventoryManager.Models
{
    using InventoryManager.CustomValidation;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Purchase
    {
        public int Id { get; set; }

        [Display(Name = "Purchase Product")]
        [Required(ErrorMessage = "Purchase Product is required")]
        public string Purchase_prod { get; set; }
        
        [Required(ErrorMessage = "Purchase Quantity is required")]
        [Display(Name = "Purchase Quantity")]
        [IntegerString(ErrorMessage = "Purchase Quantity must be an integer")]
        public string Purchase_qunty { get; set; }

        [Display(Name = "Purchase Date")]
        [Required(ErrorMessage = "Purchase Date is required")]
        [DataType(DataType.DateTime)]
        public System.DateTime Purchase_date { get; set; }
    }
}