using Microsoft.EntityFrameworkCore;
using VivaSoftPractice.Data;
using Newtonsoft.Json.Serialization;
using VivaSoftPractice.Model;
using VivaSoftPractice.AuthServices;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<ApplicationDBContext>(options=>options.UseSqlServer(builder.Configuration.GetConnectionString("Viva_Connection")));
builder.Services.Configure<ApplicationSettings>(builder.Configuration.GetSection("ApplicationSettings"));
builder.Services.AddScoped<IJwtUtils,JwtUtils>();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers().AddNewtonsoftJson(options =>
{
    options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;    // For refference loop handle in serialization setting
    options.SerializerSettings.ContractResolver = new DefaultContractResolver(); //By passing the defaule  camel case response behaviour
}).AddJsonOptions(opt => opt.JsonSerializerOptions.PropertyNamingPolicy = null);


var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseSwagger();
app.UseSwaggerUI();
app.UseCors(co => co.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
app.UseAuthorization();
app.UseMiddleware<JwtMiddleware>();



app.MapControllers();

app.Run();
