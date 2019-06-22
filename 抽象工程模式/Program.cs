using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 抽象工程模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Shoes s = null;
            Hat h = null;
            SportsShop shop = null;
            shop = new LiningFactory();
            s = shop.SellShoes();
            h = shop.SellHats();
        }


    }
    public abstract class Shoes
    {
    }

    public abstract class Hat
    {
    }

    public abstract class SportsShop
    {
        public abstract Shoes SellShoes();

        public abstract Hat SellHats();
    }

    public class NikeShoes : Shoes
    {

    }

    public class NikeHat : Hat { }

    public class LiningShoes : Shoes { }
    public class LiningHat : Hat { }

    public class NikeFactory : SportsShop
    {
        public override Hat SellHats()
        {
            return new NikeHat();
        }

        public override Shoes SellShoes()
        {
            return new NikeShoes();
        }
    }

    public class LiningFactory : SportsShop
    {
        public override Hat SellHats()
        {
            return new LiningHat();
        }

        public override Shoes SellShoes()
        {
            return new LiningShoes();
        }
    }
}
