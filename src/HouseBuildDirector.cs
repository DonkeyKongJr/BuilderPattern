using BuilderPattern;

namespace src
{
    public class HouseBuildDirector : IDirector
    {
        private readonly IHouseBuilder _houseBuilder;

        public HouseBuildDirector(IHouseBuilder houseBuilder)
        {
            _houseBuilder = houseBuilder;
        }

        public void Construct()
        {
            _houseBuilder.BuildHouse();
        }
    }
}