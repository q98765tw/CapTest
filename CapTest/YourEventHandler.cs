using DotNetCore.CAP;

namespace CapTest;

// 创建一个事件类
public class YourEvent
{
    public string Message { get; set; }
    // 其他事件属性
}
public class YourEventHandler : ICapSubscribe
{
    [CapSubscribe("your-event-name")]
    public void Handle(YourEvent @event)
    {
        // 处理事件逻辑
        Console.WriteLine($"Received event: {@event.Message}");
    }
}

