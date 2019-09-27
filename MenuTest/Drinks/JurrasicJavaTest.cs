/* JurrasicJavaTest.cs
 * Author: Brenden Levi
 */

using Xunit;
using DinoDiner.Menu.Drinks;
using DinoDiner.Menu;
using System.Collections.Generic;

namespace MenuTest.Drinks
{
    public class JurrasicJavaTest
    {
        // The correct default price, calories, ice, size, and SpaceForCream properties.
        [Fact]
        public void ShouldhaveCorrectDefaultPrice()
        {
            JurrasicJava java = new JurrasicJava();
            Assert.Equal<double>(.59, java.Price);
        }

        [Fact]
        public void ShouldhaveCorrectDefaultCalories()
        {
            JurrasicJava java = new JurrasicJava();
            Assert.Equal<uint>(2, java.Calories);
        }

        [Fact]
        public void ShouldhaveCorrectDefaultIce()
        {
            JurrasicJava java = new JurrasicJava();
            Assert.False(java.Ice);
        }

        [Fact]
        public void ShouldhaveCorrectDefaultSize()
        {
            JurrasicJava java = new JurrasicJava();
            Assert.Equal<Size>(Size.Small, java.Size);
        }

        [Fact]
        public void ShouldhaveCorrectSpaceForCream()
        {
            JurrasicJava java = new JurrasicJava();
            Assert.False(java.SpaceForCream);
        }

        // The correct price and calories after changing to small, medium, and large sizes.
        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingSmall()
        {
            JurrasicJava java = new JurrasicJava();
            java.Size = Size.Medium;
            java.Size = Size.Small;
            Assert.Equal<double>(.59, java.Price);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingSmall()
        {
            JurrasicJava java = new JurrasicJava();
            java.Size = Size.Medium;
            java.Size = Size.Small;
            Assert.Equal<uint>(2, java.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingMedium()
        {
            JurrasicJava java = new JurrasicJava();
            java.Size = Size.Medium;
            Assert.Equal<double>(.99, java.Price);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingMedium()
        {
            JurrasicJava java = new JurrasicJava();
            java.Size = Size.Medium;
            Assert.Equal<uint>(4, java.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingLarge()
        {
            JurrasicJava java = new JurrasicJava();
            java.Size = Size.Large;
            Assert.Equal<double>(1.49, java.Price);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingLarge()
        {
            JurrasicJava java = new JurrasicJava();
            java.Size = Size.Large;
            Assert.Equal<uint>(8, java.Calories);
        }

        // That invoking AddIce() results in the Ice property being true
        [Fact]
        public void ShouldHaveTrueIceAfterAddIce()
        {
            JurrasicJava java = new JurrasicJava();
            java.AddIce();
            Assert.True(java.Ice);
        }

        // That invoking LeaveSpaceForCream() results 
        // in the SpaceForCream property being true.

        [Fact]
        public void ShouldHaveTrueSpaceForCreamAfterLeaveSpaceForCream()
        {
            JurrasicJava java = new JurrasicJava();
            java.LeaveSpaceForCream();
            Assert.True(java.SpaceForCream);
        }

        // The correct ingredients are given.

        [Fact]
        public void ShouldHaveCorrectDefaultIngredients()
        {
            JurrasicJava java = new JurrasicJava();
            List<string> ingredients = java.Ingredients;
            Assert.Contains<string>("Water", ingredients);
            Assert.Contains<string>("Coffee", ingredients);
            Assert.Equal<int>(2, ingredients.Count);
        }
    }
}
