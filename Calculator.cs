using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public abstract class PackageRate
    {

        public float RailRate { get; private set; } = 0.5f;
        public float AirRate { get; private set; } = 0.6f;
        public float SeaRate { get; private set; } = 0.7f;
        public abstract string CalculateShippingCost(float orderAmount, float weight);
    }

    public class PackageByRail : PackageRate
    {
        public override string CalculateShippingCost(float orderAmount, float weight)
        {

            return "The shipping cost for rail package is " + (orderAmount + (weight * RailRate));
        }
    }
    public class PackageBySea : PackageRate
    {
        public override string CalculateShippingCost(float orderAmount, float weight)
        {
            return "The shipping cost for sea package is " + (orderAmount + (weight * SeaRate));
        }
    }

    public class PackageByAir : PackageRate
    {
        public override string CalculateShippingCost(float orderAmount, float weight)
        {
            return "The shipping cost for air package is " + (orderAmount + (weight * AirRate));
        }
    }




}