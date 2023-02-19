using Spents.Events.v1.ValueObjects;

namespace Spents.Events.v1
{
    public class ReceiptEvent<T> : EventBody<T> where T : class
    {
        public ReceiptEvent(Guid id, T Body, EventType eventType, string eventName)
        {
            Id = id;
            Version = "V1";
            CreatedDate = DateTime.Now;
            MessageKey = Guid.NewGuid().ToString();
            EventType = eventType;
            EventName = eventName;
            base.Body = Body;
        }

        public Guid Id { get; set; }
        public string EventName { get; private set; }
        public EventType EventType { get; private set; }
        public string MessageKey { get; private set; }
        public DateTime CreatedDate { get; private set; }
        public string Version { get; private set; }
    }
}
