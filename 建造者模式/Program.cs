using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 建造者模式
{
    class Program
    {
        static void Main(string[] args)
        {
            new JG().GetOrder();
        }

    }

    public class Order
    {

        public string CK { get; set; }
        public string YD { get; set; }
    }

    public abstract  class Builder
    {
        public abstract void BLD(Order od);
    }

    public class BuilderCK : Builder
    {
        public override void BLD(Order od)
        {
            od.CK = "仓库";
      
        }
    }
    public class BuilderYD : Builder
    {
        public override void BLD(Order od)
        {
            od.YD = "邮递";
        }
    }

    public class JG
    {
        List<Builder> list = new List<Builder>();
        public JG()
        {
            list.Add(new BuilderCK());
            list.Add(new BuilderYD());
        }

        public Order GetOrder()
        {
            Order order = new Order();
            foreach(var item in list)
            {
                item.BLD(order);
            }
            return order;
        }
    }
}
