var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.Forum>("forum");

builder.Build().Run();
