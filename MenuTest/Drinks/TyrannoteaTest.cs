using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Drinks
{
    public class TyrannoteaTest
    {
        //Correct default price
        [Fact]
        public void hasCorrectDefaultPrice()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.Equal(.99, tea.Price);
        }
        //Correct default calories
        [Fact]
        public void hasCorrectDefaultCalories()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.Equal<uint>(8, tea.Calories);
        }
        //Correct ice boolean
        [Fact]
        public void hasCorrectDefaultIce()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.True(tea.Ice);
        }
        //Correct default size
        [Fact]
        public void hasCorrectDefaultSize()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.Equal<Size>(Size.Small, tea.Size);
        }
        //Correct default lemon boolean
        [Fact]
        public void hasCorrectDefaultLemon()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.False(tea.Lemon);
        }
        //Correct default sweet boolean
        [Fact]
        public void hasCorrectDefaultSweet()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.False(tea.Sweet);
        }
        //Correct size after setting to small
        [Fact]
        public void ShouldHaveCorrectSize()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Medium;
            tea.Size = Size.Small;
            Assert.Equal<Size>(Size.Small, tea.Size);
        }
        //Correct price after setting to small
        [Fact]
        public void ShouldHaveCorrectPrice()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Medium;
            tea.Size = Size.Small;
            Assert.Equal(.99, tea.Price);
        }
        //Correct calories after setting to small
        [Fact]
        public void ShouldHaveCorrectCalories()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Medium;
            tea.Size = Size.Small;
            Assert.Equal<uint>(8, tea.Calories);
        }
        //Correct size after setting to medium
        [Fact]
        public void ShouldHaveCorrectSizeMedium()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Medium;
            Assert.Equal<Size>(Size.Small, tea.Size);
        }
        //Correct price after setting to medium
        [Fact]
        public void ShouldHaveCorrectPriceMedium()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Medium;
            Assert.Equal(1.49, tea.Price);
        }
        //Correct calories after setting to medium
        [Fact]
        public void ShouldHaveCorrectCaloriesMedium()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Medium;
            Assert.Equal<uint>(16, tea.Calories);
        }
        //Correct size after setting to large
        [Fact]
        public void ShouldHaveCorrectSizeLarge()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Large;
            Assert.Equal<Size>(Size.Large, tea.Size);
        }
        //Correct price after setting to large
        [Fact]
        public void ShouldHaveCorrectPriceLarge()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Large;
            Assert.Equal(1.99, tea.Price);
        }
        //Correct calories after setting to large
        [Fact]
        public void ShouldHaveCorrectCaloriesLarge()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Large;
            Assert.Equal<uint>(32, tea.Calories);
        }
        //HoldIce() correct
        [Fact]
        public void CorrectHoldIce()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.HoldIce();
            Assert.False(tea.Ice);
        }
        //AddLemon() correct
        [Fact]
        public void CorrectAddLemon()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.AddLemon();
            Assert.True(tea.Lemon);
        }
        //Setting to sweet has correct calories for each size
        [Fact]
        public void CorrectCaloriesAfterAddingSweet()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.MakeSweet();
            Assert.Equal<uint>(16, tea.Calories);
            tea.Size = Size.Medium;
            Assert.Equal<uint>(32, tea.Calories);
            tea.Size = Size.Large;
            Assert.Equal<uint>(64, tea.Calories);
        }
        //Setting to unsweet has correct calories for each size
        [Fact]
        public void CorrectCaloriesAfterRemovingSweet()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.MakeSweet();
            tea.Sweet = false;
            Assert.Equal<uint>(8, tea.Calories);
            tea.Size = Size.Medium;
            Assert.Equal<uint>(16, tea.Calories);
            tea.Size = Size.Large;
            Assert.Equal<uint>(32, tea.Calories);
        }
        //Correct Ingredients
        [Fact]
        public void CorrectIngredients()
        {
            Tyrannotea tea = new Tyrannotea();
            List<string> ingredients = tea.Ingredients;
            Assert.Contains<string>("Water", ingredients);
            Assert.Contains<string>("Tea", ingredients);
            Assert.Equal<int>(2, ingredients.Count);
        }
    }
}
