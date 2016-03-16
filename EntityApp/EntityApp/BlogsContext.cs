namespace EntityApp
{
    using System;
    using System.Data.Entity;
    using EntityApp.Models;
    using System.Linq;

    public class BlogsContext : DbContext
    {
        // Контекст настроен для использования строки подключения "BlogsContext" из файла конфигурации  
        // приложения (App.config или Web.config). По умолчанию эта строка подключения указывает на базу данных 
        // "EntityApp.BlogsContext" в экземпляре LocalDb. 
        // 
        // Если требуется выбрать другую базу данных или поставщик базы данных, измените строку подключения "BlogsContext" 
        // в файле конфигурации приложения.
        public BlogsContext()
            : base("name=BlogsContext")
        {
        }

        // Добавьте DbSet для каждого типа сущности, который требуется включить в модель. Дополнительные сведения 
        // о настройке и использовании модели Code First см. в статье http://go.microsoft.com/fwlink/?LinkId=390109.

         public virtual DbSet<Blog> Blogs { get; set; }
         public virtual DbSet<Post> Posts { get; set; }

    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}