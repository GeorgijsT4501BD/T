namespace Ecrypt_Serialize_BD.DataModel
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class AccModelContext : DbContext
    {
        // Your context has been configured to use a 'AccModelContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Ecrypt_Serialize_BD.DataModel.AccModelContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'AccModelContext' 
        // connection string in the application configuration file.
        public AccModelContext()
            : base("name=AccModelContext")
        {
        }

        public DbSet<Acc> Accounts { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}