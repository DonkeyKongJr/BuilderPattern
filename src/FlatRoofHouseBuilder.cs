using BuilderPattern;

namespace src
{
    public class FlatRoofHouseBuilder : IHouseBuilder
    {
        private House _house = default(House);

        public void BuildHouse()
        {
            _house = new House("white", "flat", 1, false);
        }

        public House GetHouse()
        {
            return _house;
        }
    }
}