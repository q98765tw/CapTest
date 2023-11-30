using DotNetCore.CAP;

namespace CapTest;

public class YourEventHandler2 : ICapSubscribe
{
    [CapSubscribe("event2")]
    public void Handle2(YourEvent @event)
    {
        // 处理事件逻辑
        Console.WriteLine($"Two user event: {@event.Message}");
    }
}

