/* WaterTest.cs
 * Author: Brenden Levi
 */

using Xunit;
using DinoDiner.Menu;
using System.Collections.Generic;

namespace MenuTest.Drinks
{
    public class WaterTest
    {
        // The correct default price, calories, ice, size, and lemon properties.
        [Fact]
        public void ShouldhaveCorrectDefaultPrice()
        {
            Water water = new Water();
            Assert.Equal<double>(.10, water.Price);
        }

        [Fact]
        public void ShouldhaveCorrectDefaultCalories()
        {
            Water water = new Water();
            Assert.Equal<uint>(0, water.Calories);
        }

        [Fact]
        public void ShouldhaveCorrectDefaultIce()
        {
            Water water = new Water();
            Assert.True(water.Ice);
        }

        [Fact]
        public void ShouldhaveCorrectDefaultSize()
        {
            Water water = new Water();
            Assert.Equal<Size>(Size.Small, water.Size);
        }

        [Fact]
        public void ShouldhaveCorrectDefaultLemon()
        {
            Water water = new Water();
            Assert.False(water.Lemon);
        }

        // The correct price and calories after changing to small, medium, and large sizes.
        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingSmall()
        {
            Water water = new Water();
            water.Size = Size.Medium;
            water.Size = Size.Small;
            Assert.Equal<double>(.10, water.Price);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingSmall()
        {
            Water water = new Water();
            water.Size = Size.Medium;
            water.Size = Size.Small;
            Assert.Equal<uint>(0, water.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingMedium()
        {
            Water water = new Water();
            water.Size = Size.Medium;
            Assert.Equal<double>(.10, water.Price);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingMedium()
        {
            Water water = new Water();
            water.Size = Size.Medium;
            Assert.Equal<uint>(0, water.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingLarge()
        {
            Water water = new Water();
            water.Size = Size.Large;
            Assert.Equal<double>(.10, water.Price);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingLarge()
        {
            Water water = new Water();
            water.Size = Size.Large;
            Assert.Equal<uint>(0, water.Calories);
        }

        // That invoking HoldIce() results in the Ice property being false.
        [Fact]
        public void ShouldHaveFalseIceAfterHoldIce()
        {
            Water water = new Water();
            water.HoldIce();
            Assert.False(water.Ice);
        }

        // That invoking AddLemon() sets results in the Lemon property being true.
        [Fact]
        public void ShouldHaveTrueLemonAfterAddLemon()
        {
            Water water = new Water();
            water.AddLemon();
            Assert.True(water.Lemon);
        }

        // The correct ingredients are given
        [Fact]
        public void ShouldHaveCorrectDefaultIngredients()
        {
            Water water = new Water();
            List<string> ingredients = water.Ingredients;
            Assert.Contains<string>("Water", ingredients);
            Assert.Equal<int>(1, ingredients.Count);
        }
    }
}
