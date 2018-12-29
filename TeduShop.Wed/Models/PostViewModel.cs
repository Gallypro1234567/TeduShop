using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TeduShop.Wed.Models
{
    public class PostViewModel
    {
         
        public int ID { set; get; }

        
        public string Name { set; get; }

        
         
        public string Alias { set; get; }

        
        public int CategoryID { set; get; }

      
        public string Image { set; get; }

         
        public string Description { set; get; }

        public string Content { set; get; }

        public bool? HomeFlag { set; get; }
        public bool? HotFlag { set; get; }
        public int? ViewCount { set; get; }

        public DateTime? CreatedDate { set; get; }

    
        public String CreatedBy { set; get; }

 
        public String MetaKeyword { set; get; }

 
        public String MetaDescription { set; get; }

        public DateTime? UpdateDate { set; get; }

 
        public String UpdateBy { set; get; }

        public bool Status { set; get; }

        public virtual PostViewModel PostCategory { set; get; }
        public virtual IEnumerable<PostTagViewModel> PostTags { set; get; }
    }
}