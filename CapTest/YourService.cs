using DotNetCore.CAP;

namespace CapTest;
// 创建一个事件类
public class YourEvent
{
    public string Message { get; set; }
    // 其他事件属性
}
public class YourService
{
    private readonly ICapPublisher _capPublisher;

    public YourService(ICapPublisher capPublisher)
    {
        _capPublisher = capPublisher;
    }

    public async Task PublishEvent()
    {
        var yourEvent = new YourEvent { Message = "Hello, CAP!" };
        // 发布事件
        await _capPublisher.PublishAsync("event", yourEvent);
        await _capPublisher.PublishAsync("event2", yourEvent);
    }
}

