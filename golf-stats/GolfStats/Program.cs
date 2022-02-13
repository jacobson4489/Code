namespace GolfStats
{
  public class Program
  {
    public Program() { }
    public static void Main(string[] args)
    {
      var builder = WebApplication.CreateBuilder(args);

      builder.Services.AddControllers();

      // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
      builder.Services.AddEndpointsApiExplorer();
      builder.Services.AddSwaggerGen();

      var app = builder.Build();

      // Configure the HTTP request pipeline.
      if (app.Environment.IsDevelopment())
      {
        app.UseSwagger();
        app.UseSwaggerUI();
      }

      // Disable CORS temporarily
      app.UseCors(cors => cors
        .AllowAnyMethod()
        .AllowAnyHeader()
        .SetIsOriginAllowed(origin => true)
        .WithOrigins("https://localhost:7020")
        .AllowCredentials());

      app.UseHttpsRedirection();
      app.UseAuthorization();
      app.MapControllers();
      app.Run();
    }
  }
}
