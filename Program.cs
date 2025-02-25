using PaymentAPI.Model;
using PaymentAPI.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddControllers();

builder.Services.AddScoped<IPaymentServices, VnPayServices>();
builder.Services.AddScoped<IPaymentServices, MomoServices>();
builder.Services.AddScoped<IPaymentServices, PaypalServices>();

builder.Services.Configure<VnPayConfigFromJson>(builder.Configuration.GetSection("VnpayAPI"));
builder.Services.Configure<MomoConfigFromJSON>(builder.Configuration.GetSection("MomoAPI"));
builder.Services.Configure<PaypalConfigFromJson>(builder.Configuration.GetSection("PaypalAPI"));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapControllers();

app.Run();

