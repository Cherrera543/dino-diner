using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Drinks
{
    public class JurassicJavaTest
    {
        [Theory]
        [InlineData("Size")]
        [InlineData("Price")]
        [InlineData("Calories")]
        public void NotifyofPropertyChange(string prop)
        {
            JurassicJava j = new JurassicJava();
            Assert.PropertyChanged(j, prop, () =>
            {
                j.Size = Size.Medium;
            });
        }
        [Fact]
        public void ShouldHaveSpecialDescription()
        { 
            JurassicJava j = new JurassicJava();
            j.AddIce();
            Assert.Collection<string>(j.Special, item=>
            {
                Assert.Equal("Add Ice",item);
            });
            j.Ice = false;
            j.MakeDecaf();
            Assert.Collection(j.Special, item =>
            {
                Assert.Equal("Make Decaf", item);
            });
            j.Decaf = false;
            j.LeaveRoomForCream();
            Assert.Collection(j.Special, item =>
            {
                Assert.Equal("Leave Room For Cream", item);
            });
            j.AddIce();
            j.MakeDecaf();
            string[] specials = new string[] { "Leave Room For Cream", "Add Ice", "Make Decaf" };
            Assert.Equal(j.Special, specials);
        }
        [Fact]
        public void ShouldHaveEmptySpecialDefault()
        {
            JurassicJava j = new JurassicJava();
            Assert.Empty(j.Special);
        }
        [Theory]
        [InlineData(Size.Small, false)]
        [InlineData(Size.Medium, false)]
        [InlineData(Size.Large, false)]
        [InlineData(Size.Small, true)]
        [InlineData(Size.Medium, true)]
        [InlineData(Size.Large, true)]
        public void ShouldHaveCorrectDescription(Size size, bool decaf)
        {
            JurassicJava java = new JurassicJava();
            java.Size = size;
            java.Decaf = decaf;
            if (decaf) Assert.Equal($"{size} Decaf Jurassic Java", java.Description);
            else Assert.Equal($"{size} Jurassic Java", java.Description);
        }
        //Correct default size
        [Fact]
        public void CorrectDefaultSize()
        {
            JurassicJava java = new JurassicJava();
            Assert.Equal<Size>(Size.Small, java.Size);
        }
        //Correct default calories
        [Fact]
        public void CorrectDefaultCalories()
        {
            JurassicJava java = new JurassicJava();
            Assert.Equal<uint>(2, java.Calories);
        }
        //Correct default price
        [Fact]
        public void CorrectDefaultPrice()
        {
            JurassicJava java = new JurassicJava();
            Assert.Equal(.59, java.Price);
        }
        //Correct default Ice boolean
        [Fact]
        public void CorrectDefaultIce()
        {
            JurassicJava java = new JurassicJava();
            Assert.False(java.Ice);
        }
        //Correct defaul SpaceForCream boolean
        [Fact]
        public void CorrectDefaultRoomForCream()
        {
            JurassicJava java = new JurassicJava();
            Assert.False(java.RoomForCream);
        }
        //Correct size after setting to small
        [Fact]
        public void CorrectSizeAfterSettingSmall()
        {
            JurassicJava java = new JurassicJava();
            java.Size = Size.Medium;
            java.Size = Size.Small;
            Assert.Equal<Size>(Size.Small, java.Size);
        }
        //Correct price after setting to small
        [Fact]
        public void CorrectPriceAfterSettingSmall()
        {
            JurassicJava java = new JurassicJava();
            java.Size = Size.Medium;
            java.Size = Size.Small;
            Assert.Equal(.59, java.Price);
        }
        //Correct calories after setting to small
        [Fact]
        public void CorrectCaloriesAfterSettingSmall()
        {
            JurassicJava java = new JurassicJava();
            java.Size = Size.Medium;
            java.Size = Size.Small;
            Assert.Equal<uint>(2, java.Calories);
        }
        //Correct size after setting to medium
        [Fact]
        public void CorrectSizeAfterSettingMedium()
        {
            JurassicJava java = new JurassicJava();
            java.Size = Size.Medium;
            Assert.Equal<Size>(Size.Medium, java.Size);
        }
        //Correct price after setting to medium
        [Fact]
        public void CorrectPriceAfterSettingMedium()
        {
            JurassicJava java = new JurassicJava();
            java.Size = Size.Medium;
            Assert.Equal(.99, java.Price);
        }
        //Correct calories after setting to medium
        [Fact]
        public void CorrectCaloriesAfterSettingMedium()
        {
            JurassicJava java = new JurassicJava();
            java.Size = Size.Medium;
            Assert.Equal<uint>(4, java.Calories);
        }
        //Correct size after setting to large
        [Fact]
        public void CorrectSizeAfterSettingLarge()
        {
            JurassicJava java = new JurassicJava();
            java.Size = Size.Large;
            Assert.Equal<Size>(Size.Large, java.Size);
        }
        //Correct price after setting to large
        [Fact]
        public void CorrectPriceAfterSettingLarge()
        {
            JurassicJava java = new JurassicJava();
            java.Size = Size.Large;
            Assert.Equal(1.49, java.Price);
        }
        //Correct calories after setting to large
        [Fact]
        public void CorrectCaloriesAfterSettingLarge()
        {
            JurassicJava java = new JurassicJava();
            java.Size = Size.Large;
            Assert.Equal<uint>(8, java.Calories);
        }
        //Correct Ice boolean after AddIce()
        [Fact]
        public void CorrectIceAfterAddIce()
        {
            JurassicJava java = new JurassicJava();
            java.AddIce();
            Assert.True(java.Ice);
        }
        //Correct Cream boolean after LeaveSpaceForCream()
        [Fact]
        public void CorrectRoomForCream()
        {
            JurassicJava java = new JurassicJava();
            java.LeaveRoomForCream();
            Assert.True(java.RoomForCream);
        }
        //Correct Ingredients
        [Fact]
        public void CorrectIngredients()
        {
            JurassicJava java = new JurassicJava();
            List<string> ingredients = java.Ingredients;
            Assert.Contains<string>("Water", ingredients);
            Assert.Contains<string>("Coffee", ingredients);
            Assert.Equal<int>(2, ingredients.Count);
        }
    }
}
