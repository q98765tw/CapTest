using CapTest.Services;
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
            Console.WriteLine($"last event SaveChanges: {@event.Message}");
            //最後一個，_context.SaveChanges();
        }
    }

    
}
