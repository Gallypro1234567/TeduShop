﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Model.Model
{
    [Table("OrderDetails")]
    public class OrderDetail
    {
        [Key]
        [Column(Order = 1)]
        public int OrderID { set; get; }

        [Key]
        [Column(Order = 2)]
        public int ProductsID { set; get; }

         


        [ForeignKey("OrderID")]
        public virtual Order Order { set; get; }

       
        
        [ForeignKey("ProductsID")]
        public virtual Product Product { set; get; }

        public int Quantily { set; get; }
    }

}
