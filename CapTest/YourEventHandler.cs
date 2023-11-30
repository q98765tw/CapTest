using DotNetCore.CAP;

namespace CapTest
{
    public class YourEventHandler : ICapSubscribe
    {
        [CapSubscribe("same_event_topic")]
        public void Handle(YourEvent @event)
        {
            // 处理事件逻辑
            Console.WriteLine($"One user event: {@event.Message}");
        }
        [CapSubscribe("Two_topic")]
        public void HandleTwo(YourEvent @event)
        {
            // 处理事件逻辑
            Console.WriteLine($"Two user event: {@event.Message}");
        }
    }

    
}
