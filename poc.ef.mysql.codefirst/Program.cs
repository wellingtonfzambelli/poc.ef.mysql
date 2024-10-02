// See https://aka.ms/new-console-template for more information
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using poc.ef.mysql.codefirst.Context;

using var host = CreateHostBuilder(args).Build();

static IHostBuilder CreateHostBuilder(string[] args) =>
    Host.CreateDefaultBuilder(args)
        .ConfigureServices((_, services) =>
        {
            // Register MyDbContext with MySQL connection
            services.AddDbContext<MyDbContext>(options =>
                options.UseMySql("Server=localhost;Database=classicmodels;User=root;Password=root;",
                    new MySqlServerVersion(new Version(8, 0, 39))));
        });