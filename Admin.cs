using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vacc
{
    class Admin
    {
        

        #region Fields
        private const string username = "Admin";
        private const int password = 12345;
        private static List<User> allUsers = new List<User>();
        private static PriorityQueue1<User> pq = new PriorityQueue1<User>();
        private static int index;

        #endregion

        #region Constructor
        public Admin()
        {
            User user = new User("Ahmed", 12345678945612, "123", "F", 45, "Cairo", false, 0, 3, "email", "None");
            User user1 = new User("Ahmed", 15487562458912, "321", "F", 70, "Cairo", true, 1, 5, "email2", "Medical Sector");
            allUsers.Add(user);
            allUsers.Add(user1);
            pq.enqueue(user);
            pq.enqueue(user1);
        }
        #endregion


        #region Functions

       
        public bool login(string name, int pass)
        {
            if(name == username && pass == password)
            {
                return true;
            }
            return false;
            
        }
      
        public string getUsername()
        {
            return username;
        }

        public int getPass()
        {
            return password;
        }
        

       
        public static void updateUserFromAdmin(int pos, long nationalID, string category, int dosages)
        {

            UserData.allUsers[pos].NationalID = nationalID;
            UserData.allUsers[pos].category = category;
            UserData.allUsers[pos].dosagesNum = dosages;

            if (dosages == 0)
                UserData.allUsers[pos].vaccinated = false;
            else
                UserData.allUsers[pos].vaccinated = true;

            if (dosages == 2)
                UserData.allUsers[pos].priorityDegree = 0;

            if (category == "Medical Sector" || category == "Chronic Disease")
                UserData.allUsers[pos].priorityDegree = 4;

        }
        #endregion

        public static int FullDosage()
        {

            int Full = 0;
            for (int i = 0; i < UserData.allUsers.Count(); i++)
            {

                if (UserData.allUsers[i].dosagesNum == 2)
                    Full++;
            }
            return Full;
        }
        public static int OneDosage()
        {

            int One = 0;
            for (int i = 0; i < UserData.allUsers.Count(); i++)
            {
                if (UserData.allUsers[i].dosagesNum >= 1)
                    One++;

            }
            return One;
        }


        public static int VaccinatedCairo()
        {
            int vac = 0;
            int count = UserData.allUsers.Count();
            for (int i = 0; i < count; i++)
            {
                if (UserData.allUsers[i].governorate == "Cairo" && UserData.allUsers[i].vaccinated == true)
                   ++vac;
            }

                    return vac;
        }
        public static int UnvaccinatedCairo()
        {
            int unvac = 0;
            int count = UserData.allUsers.Count();
            for (int i = 0; i < count; i++)
            {
                if (UserData.allUsers[i].governorate == "Cairo" && UserData.allUsers[i].vaccinated == false)
                    ++unvac;
            }

            return unvac;
        }

        public static int Cairo()
        {
            int Cairo = 0;
            for (int i = 0; i < UserData.allUsers.Count(); i++)
            {
                if (UserData.allUsers[i].governorate == "Cairo")
                    Cairo++;
            }
            return Cairo;
        }



        public static int Eighteen()
        {
            int eighteen = 0;
            for (int i = 0; i < UserData.allUsers.Count(); i++)
            {
                if (UserData.allUsers[i].age >=18 && UserData.allUsers[i].age < 65)
                
                    eighteen++;
                
            }
            return eighteen;
        }

        public static int AboveSixty()
        {
            int sixty = 0;
            for (int i = 0; i < UserData.allUsers.Count(); i++)
            {
                if (UserData.allUsers[i].age >= 65 )

                    sixty++;

            }
            return sixty;
        }
    }
}
