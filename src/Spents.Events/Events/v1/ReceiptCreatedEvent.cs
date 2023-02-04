using Spents.Domain.Entities;
using Spents.Events.Events.Body;

namespace Spents.Events.Events.v1
{
    public record ReceiptCreatedEvent
    {
        public ReceiptCreatedEvent(MessageBody<Receipt> body, string messageKey)
        {
            EventName = nameof(ReceiptCreatedEvent);
            CreatedDate = DateTime.UtcNow;
            Version = "v1";
            MessageKey = messageKey;
            Body = body;
        }

        public string EventName { get; set; }
        public string MessageKey { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Version { get; set; }
        public MessageBody<Receipt> Body { get; set; }
    }
}
