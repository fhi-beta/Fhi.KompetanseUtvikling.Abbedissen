using AutoMapper;
using Fhi.Abbedissen.KompetanseAPI.Profile;
using Fhi.Abbedissen.KompetanseAPI.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddTransient<IKompetanseService, KompetanseService>();


KonfigurerAutomapper(builder.Services);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();


 void KonfigurerAutomapper(IServiceCollection services)
{
    var mapperConfig = new MapperConfiguration(cfg =>
    {
        cfg.AddProfile<KompetanseProfile>();
        

    });
    var mapper = new Mapper(mapperConfig);
    services.AddSingleton<IMapper>(mapper);
}
