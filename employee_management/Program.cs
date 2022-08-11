using System;
namespace employee_management
{
    class employee
    {
        public string[] name = new string[20];
        public int[] emp_id = new int[20];
        public string[] department = new string[20];
        public string[] job_location = new string[20];
        public int i;
    }

    class emp1 : employee
    {
        public void add_details(int n)
        {
            for (i = 1; i <= n; i++)
            {

                Console.WriteLine("Enter the name of employee");
                name[i] = Console.ReadLine();
                Console.WriteLine("Enter the employee id");
                emp_id[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the department");
                department[i] = Console.ReadLine();
                Console.WriteLine("Enter the joblocation");
                job_location[i] = Console.ReadLine();

                Console.WriteLine("Employee records added");
                Console.WriteLine("---------------------------------------------------------------------------------");
            }
        }
        public void display(int n)
        {
            Console.WriteLine("Display added records");
            Console.WriteLine("---------------------------------------------------------------------------------");
            for(i = 1; i <= n; i++)
            { 
                Console.WriteLine("name of employee" + "\t" + name[i]);

                Console.WriteLine("employee id" + "\t" + "\t" + emp_id[i]);

                Console.WriteLine("department" + "\t" + "\t" + department[i]);

                Console.WriteLine("job location" + "\t" + "\t" + job_location[i]);

                Console.WriteLine("------------------------------------------------------");
            }
        }

        public static void Main(string[] args)
        {

            emp1 e = new emp1();

            

            Console.WriteLine("Enter the number of employees to add the list");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("do you want to add the records");
            string ad = Console.ReadLine();

            if (ad.Equals("yes"))
            {
                e.add_details(n);
            }
            else if (ad.Equals("no"))
            {
                Console.WriteLine("BYEEE");
            }
            Console.WriteLine("do you want to print the records");
            string add = Console.ReadLine();
            if (add.Equals("yes"))
            {
                e.display(n);
            }
            else if (add.Equals("no"))
            {
                Console.WriteLine("BYEEE, Thank you");
            }

        }
    }
}


