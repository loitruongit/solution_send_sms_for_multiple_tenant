using solution_send_sms_for_multiple_tenant.DesignPatterns.Builder.TenantA;
using solution_send_sms_for_multiple_tenant.Interfaces;
using solution_send_sms_for_multiple_tenant.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddTransient<ISMSServiceResolver, SMSServiceResolver>();
builder.Services.AddTransient<ISMSParamsBuilder, BuildOTPParamsForTenantA>();

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
