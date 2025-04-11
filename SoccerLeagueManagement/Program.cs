using Microsoft.EntityFrameworkCore;
using SoccerLeagueManagement;
using SoccerLeagueManagement.Utilities;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//connection string
builder.Services.AddDbContext<SoccerLeagueDbContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

//AutoMapper
//builder.Services.AddAutoMapper(typeof(Program));

//AutoMapper
builder.Services.AddAutoMapper(config => config.AddProfile<AutoMapperProfiles>());

// Add a CORS policy for the client
builder.Services.AddCors(
    options => options.AddPolicy(
        "wasm",
        policy => policy.WithOrigins("http://localhost:4200") // frontend Angular
              .AllowAnyHeader()
              .AllowAnyMethod()));



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
app.UseCors("wasm");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
