using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS325_broadSword_flowerProject
{
    public class deleteUserController
    {
        private List<User> currUsers = new List<User>();

        internal List<User> populateList()
        {
            currUsers = DatabaseManager.getUsers();

            return currUsers;
        }
        
        //Function to delete users from database
        public bool delUsers(int id)
        {
            //call DBM and pass selected userID to it
            return DatabaseManager.deleteUser(id);
        }

        //Function to edit users in database
        public bool editUser(ref User userToEdit)
        {
            //call DBM and pass a reference to a userobject with updated data.
            return DatabaseManager.editUserData(ref userToEdit);
        }

        //function to create a new user object to be used by editUser function
        internal bool editUsers(int id)
        {
            editUserDialog editAUser = new editUserDialog();
            editAUser.setId(id);
            editAUser.setRef(this);
            editAUser.onLoad();
            editAUser.ShowDialog();

            return true;
        }
    }
}
