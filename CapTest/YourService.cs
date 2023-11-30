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
        var message = new YourEvent { Message = "Hello, CAP!" };

        // 使用相同的主题发布相同的事件消息
        await _capPublisher.PublishAsync("same_event_topic", message);
    }
}

