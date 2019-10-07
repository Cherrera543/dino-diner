using System;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest
{
    public class ImmutableIngredientsTest
    {
        [Theory]
        [InlineData(typeof(Brontowurst))]
        [InlineData(typeof(DinoNuggets))]
        [InlineData(typeof(PrehistoricPBJ))]
        [InlineData(typeof(PterodactylWings))]
        [InlineData(typeof(SteakosaurusBurger))]
        [InlineData(typeof(TRexKingBurger))]
        [InlineData(typeof(VelociWrap))]
        [InlineData(typeof(Fryceritops))]
        [InlineData(typeof(Triceritots))]
        [InlineData(typeof(MeteorMacAndCheese))]
        [InlineData(typeof(MezzorellaSticks))]
        [InlineData(typeof(Tyrannotea))]
        [InlineData(typeof(Sodasaurus))]
        [InlineData(typeof(JurrasicJava))]
        [InlineData(typeof(Water))]
        public void IngredientsShouldBeImmutable(Type type)
        {
            MenuItem item = (MenuItem)Activator.CreateInstance(type);
            item.Ingredients.Clear();
            Assert.NotEmpty(item.Ingredients);
        }
    }
}