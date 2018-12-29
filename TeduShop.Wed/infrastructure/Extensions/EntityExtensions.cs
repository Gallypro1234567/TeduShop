using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TeduShop.Model.Model;
using TeduShop.Wed.Models;

namespace TeduShop.Wed.infrastructure.Extensions
{
    public  static class EntityExtensions
    {
        public static void UpdatePostCategory(this PostCategory postCategory, PostCategoryViewModel postVM)
        {
             
            postCategory.ID = postVM.ID;
            postCategory.Name = postVM.Name;
            postCategory.Alias = postVM.Alias;
            postCategory.ParentID = postVM.ParentID;
            postCategory.Description = postVM.Description;
            postCategory.DisplayOrder = postVM.DisplayOrder;
            postCategory.Image = postVM.Image;
            postCategory.HomeFlag = postVM.HomeFlag;
            postCategory.CreatedDate = postVM.CreatedDate;
            postCategory.CreatedBy = postVM.CreatedBy;
            postCategory.MetaKeyword = postVM.MetaKeyword;
            postCategory.MetaDescription = postVM.MetaDescription;
            postCategory.UpdateBy = postVM.UpdateBy;
            postCategory.Status = postVM.Status;

        
    }
        public static void UpDatePost(this Post post, PostViewModel postVM)
        {
            post.ID = postVM.ID;
            post.Name = postVM.Name;
            post.Alias = postVM.Alias;
            post.CategoryID = postVM.CategoryID;
            post.Image = postVM.Image;
            post.Description = postVM.Description;
            post.Content = postVM.Content;
          
            post.HomeFlag = postVM.HomeFlag;
            post.HotFlag = postVM.HotFlag;
            post.ViewCount = postVM.ViewCount;
            post.CreatedDate = postVM.CreatedDate;
            post.CreatedBy = postVM.CreatedBy;
            post.MetaKeyword = postVM.MetaKeyword;
            post.MetaDescription = postVM.MetaDescription;
            post.UpdateBy = postVM.UpdateBy;
            post.Status = postVM.Status;

        }
    }
}