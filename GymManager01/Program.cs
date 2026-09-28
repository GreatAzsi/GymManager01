namespace GymManager01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Member member1 = new Member("John Doe", 16, true);
            Member member2 = new Member("Jane Smith", 30, true);
            Member member3 = new Member("Alice Johnson", 22, false);
            Member member4 = new Member("Bob Brown", 28, true);
            
            member1.CheckIn();
            member2.CheckIn();
            member3.CheckIn();
            member4.CheckIn();
            member2.CheckIn();
            member3.CheckIn();
            member3.CheckIn();
            member1.Describe();
            member2.Describe();
            member3.Describe();

            Membership membership1 = new Membership(member1, 50, 3);
            Membership membership2 = new Membership(member2, 60, 6);
            membership2.Extend(3);
            Console.WriteLine($"Membership 1 total price: {membership1.TotalPrice()}");
            Console.WriteLine($"Membership 2 total price: {membership2.TotalPrice()}");
            Console.WriteLine($"Membership 1 price per visit: {membership1.PricePerVisit()}");
            Console.WriteLine($"Membership 2 price per visit: {membership2.PricePerVisit()}");

            Membership membership3 = new Membership(member3, 70, 12);
            Membership membership4 = new Membership(member4, 80, 0); 

            Gym gym = new Gym("nemtom gym");
            gym.AddMembership(membership1);
            gym.AddMembership(membership2);
            gym.AddMembership(membership3);
            gym.AddMembership(membership4);

            Console.WriteLine(gym.TotalIncome());
            
            gym.MostActive().Describe();
            gym.BestValue().Owner.Describe();
            gym.BestValue().PricePerVisit();
        }
    }
}
