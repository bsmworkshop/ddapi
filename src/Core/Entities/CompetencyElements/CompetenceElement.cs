namespace SteelDonkey.Core.Entities.CompetencyElements
{
    public class CompetenceElement : BaseEntity<int>, IAggregateRoot
    {
#pragma warning disable CS8618
        private CompetenceElement()
        {
        }

        public CompetenceElement(string label, int competenceElementGroupId, short viewOrder)
        {
            Label = label;
            CompetenceElementGroupId = competenceElementGroupId;
            ViewOrder = viewOrder;
        }

        public string Label { get; private set; }
        public short ViewOrder { get;private set; }
        public int CompetenceElementGroupId { get; private set; }
        public CompetenceElementGroup CompetenceElementGroup { get; private set; }
    }
}
