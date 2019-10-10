namespace WritingPlatform.DL.Entity
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class WPContent : DbContext
    {
        // Контекст настроен для использования строки подключения "WPContent" из файла конфигурации  
        // приложения (App.config или Web.config). По умолчанию эта строка подключения указывает на базу данных 
        // "WritingPlatform.DL.Entity.WPContent" в экземпляре LocalDb. 
        // 
        // Если требуется выбрать другую базу данных или поставщик базы данных, измените строку подключения "WPContent" 
        // в файле конфигурации приложения.
        public WPContent()
            : base("name=WPContent")
        {
        }
        public WPContent(string connectionString):base(connectionString)
        {
        }

        // Добавьте DbSet для каждого типа сущности, который требуется включить в модель. Дополнительные сведения 
        // о настройке и использовании модели Code First см. в статье http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
        public virtual DbSet<Composition> Compositions { get; set; }
        public virtual DbSet<Genre> Genres { get; set; }
        public virtual DbSet<Message> Messages { get; set; }

    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}