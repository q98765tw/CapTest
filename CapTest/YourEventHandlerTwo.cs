using DotNetCore.CAP;

namespace CapTest;

public class YourEventHandlerTwo : ICapSubscribe
{
    [CapSubscribe("same_event_topic")]
    public void HandleTwo(YourEvent @event)
    {
        // 处理事件逻辑
        Console.WriteLine($"Three user event: {@event.Message}");
    }
}
