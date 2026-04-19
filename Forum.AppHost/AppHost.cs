var builder = DistributedApplication.CreateBuilder(args);

var db = builder.AddSqlServer("sql")
                .AddDatabase("DefaultConnection");

builder.AddProject<Projects.Forum>("forum")
       .WithReference(db)
       .WaitFor(db);

builder.Build().Run();
