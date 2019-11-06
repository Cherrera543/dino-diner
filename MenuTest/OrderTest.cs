using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest
{
    public class OrderTest
    {
        [Theory]
        [InlineData(typeof(Brontowurst))]
        [InlineData(typeof(PrehistoricPBJ))]
        [InlineData(typeof(PterodactylWings))]
        [InlineData(typeof(SteakosaurusBurger))]
        [InlineData(typeof(TRexKingBurger))]
        [InlineData(typeof(VelociWrap))]
        public void CorrectTotalPrice(Type t)
        {
            Entree e = (Entree)Activator.CreateInstance(t);
            Order o = new Order();
            o.Add(e);
            Assert.Equal<double>(o.SubtotalCost, e.Price);
            Assert.Equal<double>(o.SalesTaxCosts, e.Price * .1);
            Assert.Equal<double>(o.TotalCost, (e.Price + (e.Price * .1)));
        }
        [Fact]
        public void NoNegativePrice()
        {
            Order o = new Order();
            DinoNuggets d = new DinoNuggets();
            d.AddNugget();
            o.Add(d);
            Assert.Equal<double>(o.TotalCost, (d.Price + (d.Price * .1)));
            d.Price = -15;
            Assert.Equal<double>(0, o.TotalCost);
            o.Remove(d);
            Assert.Equal<double>(0,o.TotalCost);
        }

    }
}
