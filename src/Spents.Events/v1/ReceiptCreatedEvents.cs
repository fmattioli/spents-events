using Spents.Domain.Entities;
using Spents.Events.v1.ValueObjects;

namespace Spents.Events.v1
{
    public class ReceiptEventCreated
    {
        public ReceiptEventCreated()
        {
            Version = "V1";
            CreatedDate = DateTime.Now;
        }

        public ReceiptEventType ReceiptStatus { get; set; }
        public string MessageKey { get; set; } = null!;
        public DateTime CreatedDate { get; private set; }
        public string Version { get; private set; }
        public Receipt Receipt { get; set; } = null!;
    }
}
