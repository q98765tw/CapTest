using DotNetCore.CAP;

namespace CapTest;


public class YourEventHandler : ICapSubscribe
{
    [CapSubscribe("event")]
    public void Handle(YourEvent @event)
    {
        // 处理事件逻辑
        Console.WriteLine($"One user event: {@event.Message}");
    }
}

