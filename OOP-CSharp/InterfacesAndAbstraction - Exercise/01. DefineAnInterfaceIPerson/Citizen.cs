using System;
using System.Collections.Generic;
using System.Text;

namespace PersonInfo
{
    public class Citizen : IPerson//IBirthable,IIdentifiable
    {
        public Citizen(string name,int age)
        {
            Name = name;
            Age = age;
           
        }
        public string Name { get; private set; }

        public int Age { get; private set; }

        
    }
}
