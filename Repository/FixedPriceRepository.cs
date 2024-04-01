using System.Linq;
using AccommodationManagerApp.Model;

namespace AccommodationManagerApp.Repository {
    public class FixedPriceRepository : Repository<FixedPrice> {
        public FixedPriceRepository(AccommodationManagerAppContext context) : base(context) { }

        public FixedPrice GetWaterPrice() {
            return Context.Set<FixedPrice>().FirstOrDefault(f => f.Type == FixedPriceType.Water);
        }
        
        public FixedPrice GetElectricityPrice() {
            return Context.Set<FixedPrice>().FirstOrDefault(f => f.Type == FixedPriceType.Electricity);
        }
        
        public FixedPrice GetInternetPrice() {
            return Context.Set<FixedPrice>().FirstOrDefault(f => f.Type == FixedPriceType.Internet);
        }
    }
}