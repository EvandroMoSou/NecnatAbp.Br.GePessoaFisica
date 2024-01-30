﻿using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace NecnatAbp.Br.GePessoaFisica.EntityFrameworkCore;

public class GePessoaFisicaHttpApiHostMigrationsDbContextFactory : IDesignTimeDbContextFactory<GePessoaFisicaHttpApiHostMigrationsDbContext>
{
    public GePessoaFisicaHttpApiHostMigrationsDbContext CreateDbContext(string[] args)
    {
        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<GePessoaFisicaHttpApiHostMigrationsDbContext>()
            .UseSqlServer(configuration.GetConnectionString("GePessoaFisica"));

        return new GePessoaFisicaHttpApiHostMigrationsDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
