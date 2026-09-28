using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager01
{
    internal class Member
    {  
        private string _name;
        private int _age;
        private bool _isStudent;
        private int _visits;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public bool IsStudent
        {
            get { return _isStudent; }
            set { _isStudent = value; }
        }

        public int Visits
        {
            get { return _visits; }
            set { _visits = value; }
        }
        public Member(string name, int age, bool isStudent)
        {
            Name = name;
            Age = age;
            IsStudent = isStudent;
            Visits = 0;
        }
        public void CheckIn()
        {
            Visits++;
        }
        public string Describe()
        {
            if(IsStudent)
            {
                return $"Name: {Name}, Age: {Age}, Student: Student , Visits: {Visits}";
            }
            else
            {
                return $"Name: {Name}, Age: {Age}, Student: Normal, Visits: {Visits}";
            }
        }
    }
}
