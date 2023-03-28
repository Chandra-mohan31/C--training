using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class LambdaEx
    {
        
     public  LambdaEx() {
            List<User> l = new List<User>();
            l.Add(new User(1, "cm", "cse", "Tup"));

            l.Add(new User(2, "ab", "cse", "Chennai"));


            l.Add(new User(3, "gh", "cse", "Cbe"));


            //foreach (var item in l.OrderBy(x => x.Name).ToList())
            //{
            //    Console.WriteLine($"Id : {item.Id} , Name : {item.Name} , Dept : {item.Dept} , Place : {item.Place}");
            //}
            //l.Sort((s1, s2) => s1.Place.CompareTo(s2.Place));// sort using Sort() method based on place
            //l.ForEach(user => user.Id = user.Id + 1);
            //foreach (var item in l)
            //{
            //    Console.WriteLine($"Id : {item.Id} , Name : {item.Name} , Dept : {item.Dept} , Place : {item.Place}");
            //}


            //foreach (User user in l.FindAll(user => user.Name == "ab"))
            //{
            //    Console.WriteLine(user.Id);
            //}

            l.Sort((user1, user2) => user1.Name.CompareTo(user2.Name));
            foreach (var item in l)
            {
                Console.WriteLine($"Id : {item.Id} , Name : {item.Name} , Dept : {item.Dept} , Place : {item.Place}");
            }
        }

    }

    public class User
    {
       
        public int Id
        {
            get;
            set;
        }
        public string Name
        {
            get;
            set;
        }

        public string Place
        {
            get;
            set;
        }
        public string Dept
        {
            get;
            set;
        }
        public User(int Id,string Name,string Dept,string Place)
        {
            this.Id = Id;
            this.Name = Name;
            this.Dept = Dept;
            this.Place = Place; 
        }

    }

}
   

