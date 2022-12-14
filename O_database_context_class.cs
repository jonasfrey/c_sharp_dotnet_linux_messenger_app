
    //{"s_msg":"this file was automatically generated","s_by":"f_create_csharp_database_context_class.module.js","s_ts_created":"Mon Dec 05 2022 23:28:14 GMT+0100 (Central European Standard Time)","n_ts_created":1670279294682}
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Collections.Generic;

    public class O_database_context_class : DbContext
    {

        public DbSet<O_person> O_persons {get;set;}
        public DbSet<O_message> O_messages {get;set;}

        public string s_path_database { get; }

        public O_database_context_class()
        {
            var s_folder = Environment.SpecialFolder.LocalApplicationData;
            var s_path = Environment.GetFolderPath(s_folder);
            s_path_database = System.IO.Path.Join(s_path, "database.db");
        }

        // The following configures EF to create a Sqlite database file in the
        // special "local" folder for your platform.
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={s_path_database}");
    }
    