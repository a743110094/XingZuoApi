using DAL;
using DAL.DAO;
using System.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
///
//builder.Services.AddDbContext<DataContext>(options => options.userMySQL("server=localhost;user id=root;password=haosql;persistsecurityinfo=True;database=xingzuo;SslMode=none"));
//builder.Services.AddScoped<IAccountDAO,AccountDAO> ();
///
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseAuthorization();

app.MapControllers();

app.Run();
