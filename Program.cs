
using ABSTRACT1.abstract1;

namespace ABSTRACT1
{
    internal class Program
    {
        public static void process(User user, decimal price, int quantity)
        {
            Discount discount = user.GetDiscount();
            decimal discountAmount = discount?.CalculateDiscount(price, quantity) ?? 0;

            Console.WriteLine($"{user.username}'s discount: {discountAmount:C}");
        }
        static void Main(string[] args)
        {
            #region Question1
            #region 2
            //D3point P= new D3point(10,10,10);
            // Console.WriteLine(P);
            #endregion
            #region 3
            //D3point P= new D3point(10,10,10);
            // Console.WriteLine(P);
            #endregion
            #region 4
            //Console.Write(" enter frist number:");
            //int x = int.Parse(Console.ReadLine());
            //Console.Write(" enter second number:");
            //bool result;
            //int y;
            //do
            //{
            //    result = int.TryParse(Console.ReadLine(), out y);
            //}
            //while (!result);
            //Console.Write(" enter third number:");
            //int z = Convert.ToInt32(Console.ReadLine());
            //D3point P2 = new D3point(x, y, z);
            //Console.WriteLine(P2);
            #endregion
            #region 5
            //D3point P1 = new D3point(20, 80, 90);
            //D3point P2 = new D3point(20, 80, 90);

            //if (P1 == P2)
            //{
            //    Console.WriteLine("p1==p2");
            //}
            //else Console.WriteLine("p1!=p2");

            #endregion
            #region 6
            //D3point[] arr = 
            // {
            //    new D3point(5,9,7),
            //    new D3point(4,3,6),
            //    new D3point(7,9,8),
            //};
            //Array.Sort(arr);
            //foreach (D3point p in arr) 
            //{
            //    Console.WriteLine(p.ToString());
            //}

            #endregion
            #region 7
            //D3point P1 = new D3point(2,3,6);
            //D3point P2 = new D3point(5,6,7);
            //P2= (D3point)P1.Clone();
            //Console.WriteLine(P2);

            #endregion
            #endregion

            #region Question2
            //Calculator_maths cal = new Calculator_maths();
            //Console.WriteLine(cal.Add(8, 2));
            //Console.WriteLine(cal.Divide(8, 2));
            //Console.WriteLine(cal.Multiply(8, 2));
            //Console.WriteLine(cal.Subtract(8, 2));
            ////Class_Maths reference = new Class_Maths();// invaild Cannot create an instance of the abstract type or interface 'Class_Maths'

            //Class_Maths reference = new Calculator_maths();


            //Other sulation
            //Console.WriteLine(Math1.Add(20,50));
            //Console.WriteLine(Math1.Multiply(20,50));
            //Console.WriteLine(Math1.Divide(20,50));
            //Console.WriteLine(Math1.Subtract(20,50));

            #endregion
            #region Question3

            //Discount discount = new PercentageDiscount(20);

            //Discount discount2 = new FlatDiscount();
            //Discount discount3 = new BuyOneGetOneDiscount();
            //Console.WriteLine(discount.CalculateDiscount(5, 5));
            //Console.WriteLine(discount2.CalculateDiscount(5, 5));
            //Console.WriteLine(discount3.CalculateDiscount(5, 5));
            //User regularUser = new RegularUser("Ahmed");
            //User premiumUser = new PremiumUser("ali");
            //User guestUser = new GuestUser("mostafa");
            //decimal price = 400m;
            //int quantity = 6;
            //process(regularUser, price, quantity);
            //process(premiumUser, price, quantity);
            //process(guestUser, price, quantity);
            #endregion





        }
    }
}
