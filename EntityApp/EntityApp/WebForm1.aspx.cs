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


        }

        private void FillddlBlogs()
        {
            using (var db = new BlogsContext())
            {
                var query = db.Blogs.OrderBy(b => b.Name);

                ddlBlogs.Items.Clear();

                foreach (var item in query)
                {
                    ddlBlogs.Items.Add(item.Name);
                }
            }
            FillPosts();

        }

        private void FillPosts()
        {
            using (var db = new BlogsContext())
            {

                var q1 = db.Posts.Where(p => p.Blog.Name ==
                      ddlBlogs.SelectedValue).OrderBy(p => p.Title);

                string str = "";
                foreach (var item in q1)
                {
                    str += $"{item.Blog.Name} {item.Title} {item.Content} ";
                }

                Label1.Text = str;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            using (var db = new BlogsContext())
            {
                var blog = new Blog {Name=blogName.Text};

                db.Blogs.Add(blog);
                db.SaveChanges();

                //// Display all Blogs from the database 
                //var query = from b in db.Blogs
                //            orderby b.Name
                //            select b;

                //ddlBlogs.Items.Clear();

                //foreach (var item in query)
                //{
                //    ddlBlogs.Items.Add(item.Name);
                //}

            }

            FillddlBlogs();


        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            using (var db = new BlogsContext())
            {

                var blog = db.Blogs.Where(b => 
                        b.Name == ddlBlogs.SelectedValue).First();

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
    }
}