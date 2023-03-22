using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Data;
using WinFormsCRUD.Data;
using WinFormsCRUD.Interfaces;
using WinFormsCRUD.Repositories;

namespace WinFormsCRUD;

internal static class Program
{
	/// <summary>
	///  The main entry point for the application.
	/// </summary>
	[STAThread]
	static void Main()
	{
		// To customize application configuration such as set high DPI settings or default font,
		// see https://aka.ms/applicationconfiguration.
		//ApplicationConfiguration.Initialize();

		var host = CreateHostBuilder().Build();
		ServiceProvider = host.Services;

		ApplicationConfiguration.Initialize();

		Application.Run(ServiceProvider.GetRequiredService<Form1>());

		// Application.Run(new Form1());
	}

	public static IServiceProvider ServiceProvider { get; set; }
	static IHostBuilder CreateHostBuilder()
	{
		return Host.CreateDefaultBuilder()
			.ConfigureAppConfiguration((context, config) =>
			{
				config.SetBasePath(Directory.GetCurrentDirectory());
				config.AddJsonFile("C:\\Users\\joao\\Documents\\Desenvolvimento\\TempCode\\WinFormsCRUD\\appsettings.json", optional: false, reloadOnChange: true);
			})
			.ConfigureServices((context, services) =>
			{
				services.AddScoped<IPessoaRepository, PessoaRepository>();
				services.AddDbContext<AppDbContext>(options => options.UseSqlServer(context.Configuration.GetConnectionString("Default")));
				services.AddScoped<IDbConnection>((x) => new SqlConnection(context.Configuration.GetConnectionString("Default")));
				services.AddTransient<Form1>();
			});
	}
}