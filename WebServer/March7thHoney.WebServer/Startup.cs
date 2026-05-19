using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace March7thHoney.WebServer;

public class Startup
{
	public void ConfigureServices(IServiceCollection services)
	{
		services.Configure(delegate(ForwardedHeadersOptions options)
		{
			options.ForwardedHeaders = ForwardedHeaders.XForwardedFor | ForwardedHeaders.XForwardedHost | ForwardedHeaders.XForwardedProto;
			options.KnownIPNetworks.Clear();
			options.KnownProxies.Clear();
		});
		services.AddCors(delegate(CorsOptions options)
		{
			options.AddPolicy("AllowAll", delegate(CorsPolicyBuilder builder)
			{
				builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
			});
		});
		services.AddControllers();
	}

	public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
	{
		if (env.IsDevelopment())
		{
			app.UseDeveloperExceptionPage();
		}
		app.UseForwardedHeaders();
		app.Use(async delegate(HttpContext context, Func<Task> next)
		{
			using MemoryStream buffer = new MemoryStream();
			_ = context.Request;
			HttpResponse response = context.Response;
			Stream bodyStream = response.Body;
			response.Body = buffer;
			await next();
			buffer.Position = 0L;
			context.Response.Headers["Content-Length"] = (response.ContentLength ?? buffer.Length).ToString();
			context.Response.Headers.Remove("Transfer-Encoding");
			await buffer.CopyToAsync(bodyStream);
		});
		app.UseHttpsRedirection();
		app.UseRouting();
		app.UseCors("AllowAll");
		app.UseAuthorization();
		app.UseEndpoints(delegate(IEndpointRouteBuilder endpoints)
		{
			endpoints.MapControllers();
		});
	}
}
