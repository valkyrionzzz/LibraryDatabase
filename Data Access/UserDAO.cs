using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Data_Access.UserDSTableAdapters;

namespace Data_Access
{
    //user data access object
    public class UserDAO
    {
        private UserDS userDataSet; //connects to db, maps tables to DataTables
        private TabUserTableAdapter tabUserTableAdapter; //uses sql to talk to db tables and DataTables

        public UserDAO()
        {
            //build objs to reference of these types
            userDataSet = new UserDS();
            tabUserTableAdapter = new TabUserTableAdapter();
        }

        //get all of the users in our users table
        public UserDS.TabUserDataTable GetUserDataTable()
        {
            try
            {
                //use adapter to fill in user data sets data table (calls our select sql in the adapter, maps to DS)
                tabUserTableAdapter.FillAll(userDataSet.TabUser);
                return userDataSet.TabUser; //give table of data to whoever wanted it
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        //get all users with matching username and password
        public UserDS.TabUserDataTable GetUserByUserNamePassword(string username, string password)
        {
            try
            {
                tabUserTableAdapter.FillByUserNamePassword(userDataSet.TabUser, username, password);
                return userDataSet.TabUser;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        //-------------------------NEW---------------------------------------
        public int InsertNewUser(string userName, string password, int userLevel, string email)
        {
            //return number of rows affected (1 good, 0 didn't insert)
            return tabUserTableAdapter.InsertNewUser(userName, password, userLevel, email);
        }
        public int UpdatePassword(string password, int userID)
        {
            //returns number of rows affected again( (0 nothing changed, 1+ entires changed)
            return tabUserTableAdapter.UpdateUserPassword(password, userID);
        }
        public int DeleteUserByUserID(int userID)
        {
            return tabUserTableAdapter.DeleteUserByUserID(userID);
        }










    }
}
