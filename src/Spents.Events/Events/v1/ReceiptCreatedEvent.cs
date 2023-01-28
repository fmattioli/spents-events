namespace Spents.Events.Events.v1
{

    public record ReceiptCreatedEvent
    {
        public ReceiptCreatedEvent(ReceiptCreated body, string messageKey)
        {
            CreatedDate = DateTime.UtcNow;
            Version = "v1";
            Body = body;
            MessageKey = messageKey;
        }

        public string MessageKey { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Version { get; set; }
        public ReceiptCreated Body { get; set; }
    }

    public record ReceiptCreated
    {
        public Guid Id { get; set; }
        public string EstablishmentName { get; set; } = null!;
        public DateTime ReceiptDate { get; set; }
        public IEnumerable<ReceiptItemsDetail> ReceiptItems { get; set; } = null!;
    }

    public record ReceiptItemsDetail
    {
        public string Name { get; set; } = null!;
        public short Quantity { get; set; }
        public decimal ItemPrice { get; set; }
        public string Observation { get; set; } = null!;
    }
}
