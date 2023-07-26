using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vacc
{
    class UserData
    {
        public static List<User> allUsers = new List<User>();
        public static PriorityQueue1<User> pq = new PriorityQueue1<User>();
        public static HashSet<long> ids = new HashSet<long>();
        public static int index;

        public UserData()
        {
            User user = new User("Ahmed", 12345678945612, "123", "M", 45, "Cairo", false, 0, 2, "email", "None");
            User user1 = new User("Khaled", 30015420004444, "321", "M", 70, "South Sinai", true, 1, 3, "email2", "Medical Sector");

            User user2 = new User("Fayroz", 30014110565656, "123", "F", 102, "Fayom", false, 0, 4, "email", "None");
            User user3 = new User("Tarek", 30010608989898, "321", "M", 70, "Cairo", true, 1, 3, "email2", "Medical Sector");

            User user4 = new User("Hassan", 30040050090011, "123", "M", 50, "Cairo", false, 0, 2, "email", "None");
            User user5 = new User("Mohamed", 12345678901234, "321", "M", 70, "Cairo", true, 1, 3, "email2", "Medical Sector");

            User user6 = new User("Alaa", 300121100200000, "123", "F", 45, "Cairo", false, 0, 2, "email", "None");
            User user7 = new User("Heba", 30021541542020, "321", "F", 25, "Cairo", false, 1, 1, "email2", "None");

            User user8 = new User("Mariam", 26628923333592, "321", "Female", 19, "Cairo", false, 0, 3, "email2", "Chronic Disease");
            User user9 = new User("Radwa", 33501489919923, "321", "Female", 22, "Cairo", true, 2, 3, "email2", "Medical Sector");

            User user10 = new User("Magdi", 14793882499174, "321", "Male", 50, "Assiut", true, 1, 2, "email2", "None");
            User user11 = new User("Mostafa", 25510750754870, "321", "Male", 39, "Red Sea", false, 0, 1, "email2", "None");

            User user12 = new User("Hajar", 15007398278301, "321", "Female", 75, "Faiyum", true, 1, 3, "email2", "None");
            User user13 = new User("Sarah", 25996174751886, "321", "Female", 20, "Cairo", false, 0, 1, "email2", "None");
            User user14 = new User("Menna", 25106472265087, "321", "Female", 42, "Luxor", false, 0, 2, "email2", "None");
            User user15 = new User("Habiba", 32559312821062, "321", "Female", 95, "Cairo", true, 2, 3, "email2", "Chronic Disease");

            User user16 = new User("Omar", 31981549079044, "321", "Male", 65, "Matruh", true, 1, 3, "email2", "Chronic Disease");
            User user17 = new User("Adham", 31705094055601, "321", "Male", 72, "Port Said", false, 0, 3, "email2", "None");
            User user18 = new User("Mahmoud", 20069195591695, "321", "Male", 80, "Cairo", false, 0, 3, "email2", "None");
            User user19 = new User("Saleh", 28909116459226, "321", "Male", 55, "Cairo", true, 2, 3, "email2", "Medical Sector");
            User user20 = new User("Mazen", 17637524790530, "321", "Male", 23, "Qena", false, 0, 1, "email2", "None");
            User user21 = new User("Anas", 14411773128021, "321", "Male", 91, "Cairo", true, 2, 3, "email2", "Chronic Disease");

            User user22 = new User("Lujaina", 31905770049219, "321", "Female", 38, "Alexandria", true, 1, 3, "email2", "Medical Sector");

            User user23 = new User("Marawan", 24020023084236, "321", "Male", 88, "Cairo", true, 1, 3, "email2", "Chronic Disease");
            User user24 = new User("Ahmed", 29643533668140, "321", "Male", 46, "Cairo", false, 0, 2, "email2", "None");
            User user25 = new User("Mohamed", 20286532382845, "321", "Male", 19, "Giza", false, 0, 1, "email2", "None");
            User user26 = new User("Amr", 13165969458975, "321", "Male", 60, "Dakahlia", true, 2, 3, "email2", "Medical Sector");

            User user27 = new User("Yasmeen", 18612593761554, "321", "Female", 53, "Sohag", false, 0, 2, "email2", "None");
            User user28 = new User("Sohaila", 22734409318514, "321", "Female", 25, "Monufia", true, 2, 3, "email2", "Medical Sector");
            User user29 = new User("Nada", 10187120213168, "321", "Female", 37, "Cairo", false, 0, 2, "email2", "None");
            User user30 = new User("Rana", 10601245154974, "321", "Female", 22, "Cairo", false, 0, 1, "email2", "None");


            allUsers.Add(user8);
            allUsers.Add(user9);
            allUsers.Add(user10);
            allUsers.Add(user11);
            allUsers.Add(user12);
            allUsers.Add(user13);
            allUsers.Add(user14);
            allUsers.Add(user15);
            allUsers.Add(user16);
            allUsers.Add(user17);
            allUsers.Add(user18);
            allUsers.Add(user20);
            allUsers.Add(user21);
            allUsers.Add(user22);
            allUsers.Add(user23);
            allUsers.Add(user24);
            allUsers.Add(user25);
            allUsers.Add(user26);
            allUsers.Add(user27);
            allUsers.Add(user28);
            allUsers.Add(user30);


            ids.Add(user8.NationalID);
            ids.Add(user9.NationalID);
            ids.Add(user10.NationalID);
            ids.Add(user11.NationalID);
            ids.Add(user12.NationalID);
            ids.Add(user13.NationalID);
            ids.Add(user14.NationalID);
            ids.Add(user15.NationalID);
            ids.Add(user16.NationalID);
            ids.Add(user17.NationalID);
            ids.Add(user18.NationalID);
            ids.Add(user19.NationalID);
            ids.Add(user20.NationalID);
            ids.Add(user21.NationalID);
            ids.Add(user22.NationalID);
            ids.Add(user23.NationalID);
            ids.Add(user24.NationalID);


            allUsers.Add(user);
            allUsers.Add(user1);
            allUsers.Add(user2);
            allUsers.Add(user3);
            allUsers.Add(user4);
            allUsers.Add(user5);
            allUsers.Add(user6);
            allUsers.Add(user7);

            ids.Add(user.NationalID);
            ids.Add(user1.NationalID);
            ids.Add(user2.NationalID);
            ids.Add(user3.NationalID);
            ids.Add(user4.NationalID);
            ids.Add(user5.NationalID);
            ids.Add(user6.NationalID);
            ids.Add(user7.NationalID);
        }

        public static List<User> getUserlist()
        {
            return allUsers;
        }

        public static PriorityQueue1<User> getWaitinglist()
        {

            return pq;
        }

        public static HashSet<long> getIDs()
        {
            return ids;
        }

        public static User SearchUser(long Nationalid)
        {
            for (int i = 0; i < allUsers.Count(); i++)
            {
                if (allUsers[i].NationalID == Nationalid)
                {
                    index = i;
                    return allUsers[i];
                }
            }
            return null;
        }

        public static PriorityQueue1<User> addtoWaiting()
        {
            for (int i = 0; i < allUsers.Count(); i++)
            {

                if (allUsers[i].vaccinated == false)
                {

                    pq.enqueue(allUsers[i]);

                }
            }
            return pq;

        }

        public static void receiveDate(User user)
        {
            allUsers.Add(user);

        }
        public static bool DeleteUser(long Nationalid)
        {
            User user = SearchUser(Nationalid);
            if (user != null)
            {
                allUsers.Remove(user);
                return true;
            }
            return false;
        }

       

    }
}
