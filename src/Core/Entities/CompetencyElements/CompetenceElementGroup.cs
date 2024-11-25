using SteelDonkey.Core.Entities.People;

namespace SteelDonkey.Core.Entities.CompetencyElements
{
    public class CompetenceElementGroup : BaseEntity<int>
    {
#pragma warning disable CS8618
        private CompetenceElementGroup() { }

        public CompetenceElementGroup(string label, int ownerId, short viewOrder)
        {
            Label = label;
            OwnerId = ownerId;
            ViewOrder = viewOrder;
        }

        public string Label { get; private set; }
        public int OwnerId { get; private set; }
        public short ViewOrder { get; private set; }
        public Person Owner { get; private set; }
        public List<CompetenceElement> CompetenceElements { get; private set; }
    }
}
