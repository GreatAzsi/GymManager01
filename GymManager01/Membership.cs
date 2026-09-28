using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager01
{
    internal class Membership
    {
        private Member _owner;
        private int _monthlyPrice;
        private int _months;
        public Member Owner
        {
            get { return _owner; }
            set { _owner = value; }
        }
        public int MonthlyPrice
        {
            get { return _monthlyPrice; }
            set { _monthlyPrice = value; }
        }
        public int Months
        {
            get { return _months; }
            set { _months = value; }
        }
        public Membership(Member owner, int monthlyPrice, int months)
        {
            _owner = owner;
            _monthlyPrice = monthlyPrice;
            _months = months;
        } 
        public int TotalPrice()
        {
            if (_owner.IsStudent)
            {
                return (int)(_monthlyPrice * _months * 0.8);
            }
            return _monthlyPrice * _months;
        }
        public void Extend(int additionalMonths)
        {
            _months += additionalMonths;
        }
        public int PricePerVisit()
        {
            if (_owner.Visits == 0)
            {
                return TotalPrice();
            }
            return TotalPrice() / _owner.Visits;
        }
    }
}
