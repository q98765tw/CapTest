﻿using CapTest;
using Savorboard.CAP.InMemoryMessageQueue;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCap(x =>
{
    x.UseInMemoryStorage();
    x.UseInMemoryMessageQueue();
});
builder.Services.AddLogging(builder =>
{
    builder.AddConsole(); // 将日志输出到控制台
    
});
// 注册CAP的事件处理程序
builder.Services.AddTransient<YourEventHandler>(); // 替换为你的事件处理程序
builder.Services.AddTransient<YourEventHandlerTwo>(); // 替换为你的事件处理程序
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
