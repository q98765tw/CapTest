using DotNetCore.CAP;

namespace CapTest;
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
        await _capPublisher.PublishAsync("your-event-name", yourEvent);
    }
}

