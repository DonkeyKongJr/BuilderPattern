using System;
using src;
using Xunit;
using FluentAssertions;

namespace BuilderPattern
{
    public class BuilderPatternTest
    {
        [Fact]
        public void ShouldBuildFlatHouse()
        {
            var flatHouseBuilder = new FlatRoofHouseBuilder();
            var houseBuildDirector = new HouseBuildDirector(flatHouseBuilder);

            houseBuildDirector.Construct();

            var house = flatHouseBuilder.GetHouse();

            house.HasCellar.Should().BeFalse();
            house.PaintingColor.Should().Be("white");
            house.RoofType.Should().Be("flat");
            house.NumbersOfFloors.Should().Be(1);
        }

        [Fact]
        public void ShouldBuildHippedHouse()
        {
            var hippedRoofHouseBuilder = new HippedRoofHouseBuilder();
            var houseBuildDirector = new HouseBuildDirector(hippedRoofHouseBuilder);

            houseBuildDirector.Construct();

            var house = hippedRoofHouseBuilder.GetHouse();

            house.HasCellar.Should().BeTrue();
            house.PaintingColor.Should().Be("gray");
            house.RoofType.Should().Be("hipped");
            house.NumbersOfFloors.Should().Be(2);
        }
    }
}