using System;
using System.Collections.Generic;
using System.Linq;
using EntityApp.Models;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EntityApp
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                FillddlBlogs();
               
            }
            lvPosts.DataBind();

        }

        private void FillddlBlogs()
        {
            using (var db = new BlogsContext())
            {
                var query = db.Blogs.OrderBy(b => b.Name);

                ddlBlogs.Items.Clear();

                foreach (var item in query)
                {
                    ddlBlogs.Items.Add(new ListItem(item.Name,item.BlogID.ToString()));
                }
            }
            FillPosts();

        }

        private void FillPosts()
        {
            using (var db = new BlogsContext())
            {
                int blogID = int.Parse(ddlBlogs.SelectedValue);
                var q1 = db.Posts.Where(p => p.Blog.BlogID == blogID).
                    OrderBy(p => p.Title);

                string str = "";
                foreach (var item in q1)
                {
                    str += $"{item.Blog.Name} {item.Title} {item.Content} ";
                }
                
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
         
            using (var db = new BlogsContext())
            {
                var blog = new Blog {Name=blogName.Text};
                if(db.Blogs.Where(b => b.Name == blog.Name).Count() == 0)
                    db.Blogs.Add(blog);
                db.SaveChanges();
            }

            FillddlBlogs();


        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            using (var db = new BlogsContext())
            {
                int blogID = int.Parse(ddlBlogs.SelectedValue);
                var blog = db.Blogs.Where(b => 
                        b.BlogID == blogID).First();

                Post post = new Post()
                {
                    Title = txtTitle.Text,
                    Content = txtContent.Text,
                    Blog = blog
                };

                db.Posts.Add(post);
                db.SaveChanges();
                
            }
        }

        protected void ddlBlogs_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillPosts();            
        }

        // Возвращаемый тип можно изменить на IEnumerable, однако для обеспечения поддержки
   //     постраничного просмотра и сортировки // необходимо добавить следующие параметры:
//     int maximumRows
//     int startRowIndex
//     out int totalRowCount
//     string sortByExpression
        public IQueryable lvPosts_GetData()
        {
            int blogID = int.Parse(ddlBlogs.SelectedValue);
            var db = new BlogsContext();
            return db.Posts.Where(p=>p.Blog.BlogID==blogID);
        }

        // Имя параметра идентификатора должно быть таким же, как значение DataKeyNames, заданное в панели управления
        public void lvPosts_DeleteItem(int id)
        {

        }

        // Имя параметра идентификатора должно быть таким же, как значение DataKeyNames, заданное в панели управления
        public void lvPosts_UpdateItem(int PostId)
        {


        }

        protected void lvPosts_ItemUpdating(object sender, ListViewUpdateEventArgs e)
        {
           
        }
    }
}