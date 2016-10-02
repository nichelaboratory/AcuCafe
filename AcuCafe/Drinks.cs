using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcuCafe
{

    public abstract class Drink
    {
        protected string _description = "Unknown Drink";
        protected Exception _exception = null;

        public virtual string Description
        {
            get { return _description; }
        }

        public virtual Exception Exception
        {
            get { return _exception; }
        }

        public abstract double Cost();
    }

    public abstract class CondimentDecorator : Drink
    {
    }

    public class Espresso : Drink
    {
        public Espresso()
        {
            _description = "Espresso";
        }

        public override double Cost()
        {
            return 1.8;
        }
    }

    public class HotTea : Drink
    {
        public HotTea()
        {
            _description = "Hot Tea";
        }

        public override double Cost()
        {
            return 1.0;
        }
    }

    public class IcedTea : Drink
    {
        public IcedTea()
        {
            _description = "Iced Tea";
        }

        public override double Cost()
        {
            return 1.5;
        }
    }

    public class Milk : CondimentDecorator
    {
        Drink _drink;

        public Milk(Drink drink)
        {
            this._drink = drink;

            if (drink.GetType() == typeof(IcedTea))
            {
                _exception = new Exception("Cannot add milk to iced tea!");
            }

        }

        public override string Description
        {
            get
            {
                return " + Milk";
            }
        }

        public override double Cost()
        {
            return 0.5;
        }
    }

    public class Sugar : CondimentDecorator
    {
        Drink _drink;

        public Sugar(Drink drink)
        {
            this._drink = drink;
        }

        public override string Description
        {
            get
            {
                return " + Sugar";
            }
        }

        public override double Cost()
        {
            return 0.5;
        }
    }

    public class ChocoateTopping : CondimentDecorator
    {
        Drink _drink;

        public ChocoateTopping(Drink drink)
        {
            this._drink = drink;
        }

        public override string Description
        {
            get
            {
                return " + Chocolate Topping";
            }
        }

        public override double Cost()
        {
            return 0.2;
        }
    }

}
