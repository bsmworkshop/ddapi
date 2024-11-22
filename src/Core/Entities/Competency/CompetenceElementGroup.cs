using SteelDonkey.Core.Entities;

namespace SteelDonkey.Core.Entities.Competency
{
    public class CompetenceElementGroup : BaseEntity<int>
    {
#pragma warning disable CS8618
        private CompetenceElementGroup() { }


        public string Label { get; private set; }
    }
}
