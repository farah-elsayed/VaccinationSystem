using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vacc
{
    public class User:IComparable<User>
    {
       
        public string name;
        public long NationalID;
        public string password;
        public string gender;
        public int age;
        public string governorate;
        public bool vaccinated;
        public int dosagesNum;
        public int priorityDegree;
        public string email;
        public string category;

        public User(string name, long nationalID, string password, string gender, int age, string governorate, bool vaccinated, int dosagesNum, int priorityDegree, string email, string category)
        {
            this.name = name;
            NationalID = nationalID;
            this.password = password;
            this.gender = gender;
            this.age = age;
            this.governorate = governorate;
            this.vaccinated = vaccinated;
            this.dosagesNum = dosagesNum;
            this.priorityDegree = priorityDegree;
            this.email = email;
            this.category = category;
        }


        //public Queue<User> waitingQueue = new Queue<User>();


        public User()
        {
            name = "";
            NationalID = 0;
            password = "";
            gender = "";
            age = 0;
            governorate = "";
            vaccinated = false;
            dosagesNum = 0;
        }
        public int CompareTo(User other)
        {
            if (this.priorityDegree > other.priorityDegree) return 1;
            if (this.priorityDegree < other.priorityDegree) return -1;
            return 0;
        }

        //setting the priority as the user enters data
        //if the priority degree is 6, then that is a emergency 
        //the other numbers are set according how severe the case is
        public int settingPriority()
        {
            //age and category-wise assignment
            if (age > 100)
                priorityDegree = 4;
            else if ((age >= 60 && age <= 100)|| String.Compare(category, "Medical Sector") == 0|| String.Compare(category, "Chronic Disease") == 0)
                priorityDegree = 3;
            else if (age >= 40 && age < 60)
                priorityDegree = 2;
            else if (age >= 18 && age < 40)
                priorityDegree = 1;
           
            return priorityDegree;
        }
        public static void updateUser(User user)
        {
            UserData.allUsers[UserData.index].name = user.name;
            UserData.allUsers[UserData.index].gender = user.gender;
            UserData.allUsers[UserData.index].governorate = user.governorate;
            UserData.allUsers[UserData.index].email = user.email;
            UserData.allUsers[UserData.index].age = user.age;
        }
    }
}
