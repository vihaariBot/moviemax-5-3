namespace moviemax_5_3
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    public class database : DbContext
    {
        // Your context has been configured to use a 'database' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'moviemax_5_3.database' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'database' 
        // connection string in the application configuration file.
        public database()
            : base("database")
        {
            Database.SetInitializer<database>(new DropCreateDatabaseIfModelChanges<database>());
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<movie> movies { get; set; }
        public virtual DbSet<multiplex> multiplexs { get; set; }

    }

    public class movie
    {
        [Key]
        public int mid { get; set; }
        public string mname { get; set; }
        public string genre { get; set; }
    
        public List<multiplex> multiplex { get; set; }


    }
    public class multiplex
    {
        [Key]
        public int mulid { get; set; }
        public string mulname { get; set; }
        public string screens { get; set; }
        public string location { get; set; }
 

        public List<movie> movie { get; set; }

    }
}