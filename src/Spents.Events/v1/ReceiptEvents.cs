using Spents.Domain.Entities;
using Spents.Events.v1.ValueObjects;

namespace Spents.Events.v1
{
    public record ReceiptEvents
    {
        public ReceiptEvents()
        {
            CreatedDate = DateTime.UtcNow;
            Version = "V1";
        }

        public ReceiptEventType ReceiptStatus { get; set; }
        public string MessageKey { get; set; } = null!;
        public DateTime CreatedDate { get; private set; }
        public string Version { get; private set; }
        public Receipt Receipt { get; set; } = new Receipt();
    }
}
