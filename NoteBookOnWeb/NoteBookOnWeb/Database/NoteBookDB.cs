namespace NoteBookOnWeb.Database
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class NoteBookDB : DbContext
    {
        // Контекст настроен для использования строки подключения "NoteBookDB" из файла конфигурации  
        // приложения (App.config или Web.config). По умолчанию эта строка подключения указывает на базу данных 
        // "NoteBookOnWeb.Database.NoteBookDB" в экземпляре LocalDb. 
        // 
        // Если требуется выбрать другую базу данных или поставщик базы данных, измените строку подключения "NoteBookDB" 
        // в файле конфигурации приложения.
        public NoteBookDB()
            : base("name=NoteBookDB")
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<NoteBookDB>());
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<NoteBookDB>());
        }

        // Добавьте DbSet для каждого типа сущности, который требуется включить в модель. Дополнительные сведения 
        // о настройке и использовании модели Code First см. в статье http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }

        public virtual DbSet<Note> Notes { get; set; }
    }

}