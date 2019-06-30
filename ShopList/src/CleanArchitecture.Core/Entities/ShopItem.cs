using CleanArchitecture.Core.SharedKernel;

namespace CleanArchitecture.Core.Entities
{
    public class ShopItem : BaseEntity
    {
        public string Description { get; set; }
        public bool Done { get; private set; }

        public void Mark(bool done)
        {
            this.Done = done;
            //TODO event is missing
        }
    }
}