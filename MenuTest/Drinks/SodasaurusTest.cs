/* SodasaurusTest.cs
 * Author: Brenden Levi
 */

using Xunit;
using DinoDiner.Menu;
using System.Collections.Generic;

namespace MenuTest.Drinks
{
    public class SodasaurusTest
    {
        // The ability to set each possible flavor.
        [Fact]
        public void ShouldBeAbleToSetFlavorToCola()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Flavor = SodasaurusFlavor.Cola;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Cola, soda.Flavor);
        }

        [Fact]
        public void ShouldBeAbleToSetFlavorToOrange()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Flavor = SodasaurusFlavor.Orange;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Orange, soda.Flavor);
        }

        [Fact]
        public void ShouldBeAbleToSetFlavorToVanilla()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Flavor = SodasaurusFlavor.Orange;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Orange, soda.Flavor);
        }

        [Fact]
        public void ShouldBeAbleToSetFlavorToChocolate()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Flavor = SodasaurusFlavor.Chocolate;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Chocolate, soda.Flavor);
        }

        [Fact]
        public void ShouldBeAbleToSetFlavorToRootBeer()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Flavor = SodasaurusFlavor.RootBeer;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.RootBeer, soda.Flavor);
        }

        [Fact]
        public void ShouldBeAbleToSetFlavorToCherry()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Flavor = SodasaurusFlavor.Cherry;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Cherry, soda.Flavor);
        }

        [Fact]
        public void ShouldBeAbleToSetFlavorToLime()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Flavor = SodasaurusFlavor.Lime;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Lime, soda.Flavor);
        }

        // The correct default price, calories, ice, and size.
        [Fact]
        public void ShouldhaveCorrectDefaultPrice()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.Equal<double>(1.50, soda.Price);
        }

        [Fact]
        public void ShouldhaveCorrectDefaultCalories()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.Equal<uint>(112, soda.Calories);
        }

        [Fact]
        public void ShouldhaveCorrectDefaultIce()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.True(soda.Ice);
        }

        [Fact]
        public void ShouldhaveCorrectDefaultSize()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.Equal<Size>(Size.Small, soda.Size);
        }

        // The correct price and calories after changing to small, medium, and large sizes.
        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingSmall()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Medium;
            soda.Size = Size.Small;
            Assert.Equal<double>(1.50, soda.Price);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingSmall()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Medium;
            soda.Size = Size.Small;
            Assert.Equal<uint>(112, soda.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingMedium()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Medium;
            Assert.Equal<double>(2.00, soda.Price);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingMedium()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Medium;
            Assert.Equal<uint>(156, soda.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingLarge()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Large;
            Assert.Equal<double>(2.50, soda.Price);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingLarge()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Large;
            Assert.Equal<uint>(208, soda.Calories);
        }

        // That invoking HoldIce() results in the Ice property being false.
        [Fact]
        public void ShouldHaveFalseIceAfterHoldIce()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.HoldIce();
            Assert.False(soda.Ice);
        }

        // The correct ingredients are given
        [Fact]
        public void ShouldHaveCorrectDefaultIngredients()
        {
            Sodasaurus soda = new Sodasaurus();
            List<string> ingredients = soda.Ingredients;
            Assert.Contains<string>("Water", ingredients);
            Assert.Contains<string>("Natural Flavors", ingredients);
            Assert.Contains<string>("Cane Sugar", ingredients);
            Assert.Equal<int>(3, ingredients.Count);
        }

        [Fact]
        public void DescriptionShouldBeCorrect()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Flavor = SodasaurusFlavor.Cola;
            Assert.Equal("Small Cola Sodasaurus", soda.Description);
        }

        [Fact]
        public void SpecialShouldBeEmptyByDefault()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.Empty(soda.Special);
        }

        [Fact]
        public void HoldIceShouldAddToSpecial()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.HoldIce();
            Assert.Collection<string>(soda.Special,
                item =>
                {
                    Assert.Equal("Hold Ice", item);
                }
            );
        }
    }
}
