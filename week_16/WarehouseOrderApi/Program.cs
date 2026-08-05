using WarehouseOrderApi.Repositories;
using WarehouseOrderApi.Services;
using WarehouseOrderApi.Middleware;

var builder = WebApplication.CreateBuilder(args);

// הוספת שירותים למיכל
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// רישום מאגרים כ-Singleton (נתונים בזיכרון נשמרים)
builder.Services.AddSingleton<IProductRepository, ProductRepository>();
builder.Services.AddSingleton<IOrderRepository, OrderRepository>();

// רישום שירותים כ-Scoped (מופע אחד לכל בקשת HTTP)
builder.Services.AddScoped<IOrderService, OrderService>();

var app = builder.Build();

// הגדרת צינור בקשות ה-HTTP
// חשוב: מטפל השגיאות חייב להיות ראשון בצינור!
app.UseMiddleware<ExceptionHandlingMiddleware>();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();