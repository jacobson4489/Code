using Microsoft.EntityFrameworkCore;
using MyGolfStats.Data;
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<MyGolfStatsContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("MyGolfStatsContext")));

builder.Services.AddCors(options =>
{
	options.AddDefaultPolicy(builder =>
	{
		builder.WithOrigins("*")
			.AllowAnyHeader()
			.AllowAnyMethod();
	});
});

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseCors();
app.UseAuthorization();
app.MapControllers();
app.Run();