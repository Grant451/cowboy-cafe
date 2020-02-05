using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests
{
    public class EntreeTests
    {
        [Theory]
        [InlineData(typeof(CowpokeChili))]
        [InlineData(typeof(RustlersRibs))]
        [InlineData(typeof(PecosPulledPork))]
        [InlineData(typeof(Trailburger))]//I changed the case on this test to match my classname
        //I think it is ok to do this because the case conficts with the firs round of tests released. 
        [InlineData(typeof(DakotaDoubleBurger))]
        [InlineData(typeof(TexasTripleBurger))]
        [InlineData(typeof(AngryChicken))]
        public void TypeShouldBeAnEntree(Type type)
        {
            var entree = Activator.CreateInstance(type);
            Assert.IsAssignableFrom<Entree>(entree);
        }
    }
}
