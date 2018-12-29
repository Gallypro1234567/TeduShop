using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TeduShop.Wed.Models
{
    public class PostCategoryViewModel
    {
         
        public int ID { set; get; }

    
        public string Name { set; get; }

         
        public string Alias { set; get; }

        
        public string Description { set; get; }

        public int? ParentID { set; get; }
        public int DisplayOrder { set; get; }
 
        public string Image { set; get; }

        public bool? HomeFlag { set; get; }

        public virtual IEnumerable<PostViewModel> Posts { set; get; }
        public DateTime? CreatedDate { set; get; }

 
        public String CreatedBy { set; get; }

  
        public String MetaKeyword { set; get; }

 
        public String MetaDescription { set; get; }

        public DateTime? UpdateDate { set; get; }

  
        public String UpdateBy { set; get; }

        public bool Status { set; get; }
    }
}