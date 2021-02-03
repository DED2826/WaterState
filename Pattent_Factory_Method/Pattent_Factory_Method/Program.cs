using System;

namespace Pattent_Factory_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            //Car 1
            Factory fac = new FactoryCar("");
            Car toyota = fac.Create();

            fac = new Model1("");
            Car camry30 = fac.Create();

            fac = new FactoryEngine1("");
            Car eng24 = fac.Create();

            fac = new FactoriyEquipmentcs1("");
            Car camrylux = fac.Create();
            Console.WriteLine();


            //Car 2
            fac = new FactoryCar("");
            Car toyota2 = fac.Create();

            fac = new Model2("");
            Car camry40 = fac.Create();

            fac = new FactoryEngine2("");
            Car eng30 = fac.Create();

            fac = new FactoriyEquipmentcs2("");
            Car camryst = fac.Create();
            Console.WriteLine();


            //Car 3
            fac = new FactoryCar1("");
            Car mers1 = fac.Create();

            fac = new Model3("");
            Car slk1 = fac.Create();

            fac = new FactoryEngine3("");
            Car eng1_2 = fac.Create();

            fac = new FactoriyEquipmentcs2("");
            Car mersst = fac.Create();
            Console.WriteLine();

            //Car 4
            fac = new FactoryCar1("");
            Car mers2 = fac.Create();

            fac = new Model3("");
            Car slk2 = fac.Create();

            fac = new FactoryEngine2("");
            Car eng2_3 = fac.Create();

            fac = new FactoriyEquipmentcs1("");
            Car merslux2 = fac.Create();
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
