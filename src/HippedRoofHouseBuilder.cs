using BuilderPattern;

namespace src
{
    public class HippedRoofHouseBuilder : IHouseBuilder
    {
        private House _house = default(House);

        public void BuildHouse()
        {
            _house = new House("gray", "hipped", 2, true);
        }

        public House GetHouse()
        {
            return _house;
        }
    }
}