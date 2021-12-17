﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace DBapplication
{
    public class Controller
    {
        DBManager dbMan;
        public Controller()
        {
            dbMan = new DBManager();
        }

      
        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }
        //public DataTable SelectAllEmp()
        //{
        //    string query = "SELECT * FROM Employee;";
        //    return dbMan.ExecuteReader(query);
        //}

        public DataTable SelectPassword(string UserName)
        {
            string query = "Select Pass from Accounts where UserName = '" + UserName + "';";
            return dbMan.ExecuteReader(query);
        }

        public int GetID()
        {
            string query = "Select Max(ID) from Accounts"+";";
            
            //in case there are no accounts in the DB 
            if(dbMan.ExecuteScalar(query) == DBNull.Value) 
            {
               return 0; 
            }

              return Convert.ToInt16(dbMan.ExecuteScalar(query));
        }


        public int InsertAccount(int ID, string UserName, string Password, string FName, string Lname, char JobCode, int Age, char Gender)
        {
            string query;
            if (JobCode == 50) { //50 =2+48 
                //Instructor
              query = "INSERT INTO Accounts (ID, UserName, Pass, F_Name, L_Name, Job_Code, Age, Gender,Account_Status)" +
                                "Values ('" + ID + "','" + UserName + "','" + Password +
                                "','" + FName + "','" + Lname + "','" + JobCode + "'," + Age +
                                ",'" + Gender + "'," + '0' + ");";
            }
            else
            { //Applicant
                query = "INSERT INTO Accounts (ID, UserName, Pass, F_Name, L_Name, Job_Code, Age, Gender,Account_Status)" +
                            "Values ('" + ID + "','" + UserName + "','" + Password +
                            "','" + FName + "','" + Lname + "','" + JobCode + "'," + Age +
                            ",'" + Gender + "'," + '1' + ");";

            }
            return dbMan.ExecuteNonQuery(query);
        }

        //public DataTable SelectDepNum()
        //{
        //    string query= "SELECT Dnumber FROM Department;";
        //    return dbMan.ExecuteReader(query);
        //}
        //public DataTable SelectDepLoc()
        //{
        //    string query = "SELECT DISTINCT Dlocation FROM Dept_Locations;";
        //    return dbMan.ExecuteReader(query);
        //}

        //public DataTable SelectProject(string location)
        //{
        //    string query = "SELECT Pname,Dname FROM Department D, Project P, Dept_Locations L"
        //     +" where P.Dnum=D.Dnumber and L.Dnumber=D.Dnumber and L.Dlocation='"+location+"';"; 

        //    return dbMan.ExecuteReader(query);
        //}
    }
}
