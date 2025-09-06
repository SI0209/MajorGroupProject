using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DrivingSchoolWebsite.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Configuration;
using DrivingSchoolWebsite.Admin;

namespace DrivingSchoolWebsite.Logic
{
    internal class RoleActions


    {
        public const string Role_Admin = "adminRole";
        public const string Role_Client = "clientRole";
        public const string Role_Instructor = "instructorRole";


        internal void AddUserAndRole()
        {
            Models.ApplicationDbContext context = new ApplicationDbContext();



            // Create a RoleStore object by using the ApplicationDbContext object. 
            // The RoleStore is only allowed to contain IdentityRole objects.
            var roleStore = new RoleStore<IdentityRole>(context);

            // Create a RoleManager object that is only allowed to contain IdentityRole objects.
            // When creating the RoleManager object, you pass in (as a parameter) a new RoleStore object. 
            var roleMgr = new RoleManager<IdentityRole>(roleStore);



            CreateRole(Role_Admin);
            CreateRole(Role_Client);
            CreateRole(Role_Instructor);

            void CreateRole(string roleName)
            {
                if (!roleMgr.RoleExists(roleName))
                {
                    roleMgr.Create(new IdentityRole { Name = roleName });
                }
            }

            // Create a UserManager object based on the UserStore object and the ApplicationDbContext  
            // object. Note that you can create new objects and use them as parameters in
            // a single line of code, rather than using multiple lines of code, as you did
            // for the RoleManager object.
            var userMgr = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
            CreateUser(Role_Admin, "adminRoleUser@arafdrivingschool.com");
            CreateUser(Role_Client, "clientRoleUser@arafdrivingschool.com");
            CreateUser(Role_Instructor, "InstructorRoleUser@arafdrivingschool.com");
            CreateUser(Role_Instructor, "Eva@gmail.com");
            CreateUser(Role_Instructor, "billy@gmail.com");
            CreateUser(Role_Instructor, "jane@gmail.com");



            void CreateUser(string role, string email, string username = null)
            {
                if (username is null)
                {
                    username = email;
                }

                var appUser = new ApplicationUser { UserName = username, Email = email };
                userMgr.Create(appUser, ConfigurationManager.AppSettings["AppUserPasswordKey"]);

                // If the new "adminRole" user was successfully created, 
                // add the "adminRole" user to the "adminRole" role. 
                if (!userMgr.IsInRole(userMgr.FindByEmail(email).Id, role))
                {
                    userMgr.AddToRole(userMgr.FindByEmail(email).Id, role);
                }
            }

        }

    }
}