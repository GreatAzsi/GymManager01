using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager01
{ 
    internal class Gym
    {
        private string _name;
        private List<Membership> _members;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public List<Membership> Members
        {
            get { return _members; }
            set { _members = value; }
        }
        public Gym(string name)
        {
            Name = name;
            Members = new List<Membership>();
        }
        public void AddMembership(Membership membership)
        {
            Members.Add(membership);
        }
        public int TotalIncome()
        {
            int totalIncome = 0;
            foreach (Membership membership in Members)
            {
                totalIncome += membership.TotalPrice();
            }
            return totalIncome;
        }
        public Member MostActive()
        {
            Member mostActiveMember = null;
            int maxVisits = 0;
            foreach (Membership membership in Members)
            {
                if (membership.Owner.Visits > maxVisits)
                {
                    maxVisits = membership.Owner.Visits;
                    mostActiveMember = membership.Owner;
                }
            }
            return mostActiveMember;
        }
        public Membership BestValue()
        {
            Membership bestValueMembership = Members[0] ;
            foreach (Membership membership in Members)
            {
                
                if (bestValueMembership.PricePerVisit() > membership.PricePerVisit())
                {
                    bestValueMembership = membership;
                }
            }
            return bestValueMembership;
        }

    }
}
