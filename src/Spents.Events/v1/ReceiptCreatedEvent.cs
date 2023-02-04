using Spents.Domain.Entities;
using Spents.Events.Body;

namespace Spents.Events.v1
{
    public record ReceiptCreatedEvent
    {
        public ReceiptCreatedEvent(MessageBody<Receipt> receiptCreated, string messageKey)
        {
            EventName = nameof(ReceiptCreatedEvent);
            CreatedDate = DateTime.UtcNow;
            Version = "v1";
            MessageKey = messageKey;
            ReceiptCreated = receiptCreated;
        }

        public string EventName { get; set; }
        public string MessageKey { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Version { get; set; }
        public MessageBody<Receipt> ReceiptCreated { get; set; }
    }
}
