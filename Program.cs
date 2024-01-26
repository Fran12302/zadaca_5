using DEKORATER;

namespace DEKORATER
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Meal meal1= new Meal();
            meal1.MakeMushroomNoodleSoup();
        }
    }

    
    public interface Ieateble
    {
        public void AddSmthng();
    }

    public class BaseIngridient:Ieateble
    {
        public void AddSmthng()
        {
            Console.WriteLine("Base add");
        }
    }

    public class BaseIngridientDecorater : Ieateble
    {
        Ieateble eatable;
        public BaseIngridientDecorater(Ieateble eatable)
        {
            this.eatable = eatable;
        }
        public virtual void AddSmthng()
        {
            eatable.AddSmthng();
        }
    }
    public class AddNoodlesDec:BaseIngridientDecorater
    {
        public AddNoodlesDec(Ieateble eatable) : base(eatable) { }
        public override void AddSmthng()

        {
            base.AddSmthng();
            Console.WriteLine("Add Noodles");
        }
    }

    public class AddBeefDec:BaseIngridientDecorater
    {
        public AddBeefDec(Ieateble eatable) : base(eatable) { }
        public override void AddSmthng()
        {
            base.AddSmthng();
            Console.WriteLine("Add Beef");
        }
    }

    public class AddMushroomsDec:BaseIngridientDecorater
    {
        public AddMushroomsDec(Ieateble eatable) : base(eatable) { }
        public override void AddSmthng()
        {
            base.AddSmthng();
            Console.WriteLine("Add Mushrooms");
        }
    }

    public class AddWaterDec:BaseIngridientDecorater
    {
        public  AddWaterDec(Ieateble eatable):base(eatable) { }
        public override void AddSmthng()
        {
            base.AddSmthng();
            Console.WriteLine("Add water");
        }

    }

    }

    public class Meal
    {
    Ieateble eateble;
        
        public void MakeMushroomNoodleSoup()
        {
        eateble = new BaseIngridientDecorater(new AddNoodlesDec(new AddMushroomsDec(new AddWaterDec(new BaseIngridient()))));
        eateble.AddSmthng();
           
        }

        
    }

   
