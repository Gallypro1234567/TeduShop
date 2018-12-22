using System;
using System.ComponentModel.DataAnnotations;

namespace TeduShop.Model.Abstract
{
    public abstract class Auditable : IAuditable
    {
        public DateTime? CreatedDate { set; get; }

        [MaxLength(256)]
        public String CreatedBy { set; get; }

        [MaxLength(256)]
        public String MetaKeyword { set; get; }

        [MaxLength(256)]
        public String MetaDescription { set; get; }

        public DateTime? UpdateDate { set; get; }

        [MaxLength(256)]
        public String UpdateBy { set; get; }

        public bool Status { set; get; }
    }
}