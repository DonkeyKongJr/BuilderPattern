using System;
using src;

namespace BuilderPattern
{
    public interface IHouseBuilder
    {
        void BuildHouse();
        House GetHouse();
    }
}
