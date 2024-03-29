using CoinWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinWeb.Test
{
    public class CoinTest
    {
        [Fact]
        public void ChangeCountry()
        {
            //Arrage
            Coin coin = new Coin() { Id = 1, Country = "Italy", Year = 1973, Metal = "Aluminum", Face = "/images/img1.jpg", Denomination = "5   lire" };

            

            //Assert
            Assert.Equal(1973, coin.Year);
        }

        [Fact]
        public void RangeCountry()
        {
            //Arrage
            Coin coin = new Coin() { Id = 1, Country = "Italy", Year = 1973, Metal = "Aluminum", Face = "/images/img1.jpg", Denomination = "5   lire" };

            //Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => coin.Year = 2030);

            Assert.Throws<ArgumentOutOfRangeException>(() => coin.Year = -100);
        }
    }
}
