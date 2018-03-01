using System;

namespace TradeMeAppTest2
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Program p = new Program();
                Boolean keepGoing = true;
                double[] sizes = new double[3];
                Console.WriteLine("Parse the Parcel 2\n-----------------");

                while (keepGoing)
                {
                    Console.WriteLine("Select an option:");

                    Console.WriteLine("1. Calculate a parcel cost\n2. Change size cost values\n3. Exit");
                    String s = Console.ReadLine();
                    if (s.Equals("1"))
                    {
                        p.enterDetails(sizes);
                    }
                    else if (s.Equals("2"))
                    {
                        sizes = p.changeSize();
                    }
                    else if (s.Equals("3"))
                    {
                        Console.WriteLine("OK, program will now terminate");
                        break;
                    }
                    else
                        Console.WriteLine("Not a valid choice.  Try again.");

                    Console.WriteLine("");

                }
                
            }
        }//main


        void enterDetails(double[] sizes)
        {
            Console.WriteLine("Enter weight in kg (max 25kg):");
            double weight = dataInput();
            Console.WriteLine("Enter length in mm (max 400mm):");
            double length = dataInput();
            Console.WriteLine("Enter breadth in mm (max 600mm):");
            double breadth = dataInput();
            Console.WriteLine("Enter height in mm (max 250mm):");
            double height = dataInput();

            Parcel par = new Parcel(weight, length, breadth, height);
            Console.WriteLine("Calculating size and cost...");

            if (sizes != null)
            {
                par.setSizeCosts(sizes[0], sizes[1], sizes[2]);
                par.setSize();
            }

            String size = par.getSize();
            double cost = par.getCost();

            if (size.Equals("over limit"))
                Console.WriteLine("Package exceeds limits.  ");
            else
            {
                Console.WriteLine("Type of package: " + size);
                Console.WriteLine("Cost of package: $" + cost);
            }
        }

        double[] changeSize()
        {
            double[] sizes = new double[3];
            Console.WriteLine("Enter new cost for small package:");
            sizes[0] = dataInput();
            Console.WriteLine("Enter new cost for medium package:");
            sizes[1] = dataInput();
            Console.WriteLine("Enter new cost for large package:");
            sizes[2] = dataInput();
            return sizes;
        }//changeSize

        double dataInput()
        {
            double value = 0;
            Boolean b = true;
            while (b)
            {
                if (double.TryParse(Console.ReadLine(), out value))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Not a valid entry.  Please enter a number.");
                }
            }
            return value;
        }//dataInput

    }

}

