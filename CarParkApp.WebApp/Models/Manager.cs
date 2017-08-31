using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarParkApp.WebApp.Models
{
    public class Manager
    {
        private int managerID, adminID;
        private char approvalStatus;
        private string firstName, lastName;

        public int ManagerID
        {
            get { return this.managerID; }
            set { this.managerID = value; }
        }
        public int AdminID
        {
            get { return this.adminID; }
            set { this.adminID = value; }
        }
        public char ApprovalStatus
        {
            get { return this.approvalStatus; }
            set { this.approvalStatus = value; }
        }
        public string FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value; }
        }
        public string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }

        public Manager (int managerID, int adminID,
            char approvalStatus, string firstName,
            string lastName)
        {6
            ManagerID = managerID;
            AdminID = adminID;
            ApprovalStatus = approvalStatus;
            FirstName = firstName;
            LastName = lastName;
        }
    }
}