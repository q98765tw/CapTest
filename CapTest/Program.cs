using CapTest;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCap(x =>
{
    x.UseInMemoryStorage();
    x.UseRabbitMQ("amqp://your_username:your_password@localhost:5672"); // 修改為你的 RabbitMQ 連接資訊
    x.UseDashboard();   
});
// 注册CAP的事件处理程序
builder.Services.AddTransient<YourEventHandler>(); // 替换为你的事件处理程序
builder.Services.AddTransient<YourService>();

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
