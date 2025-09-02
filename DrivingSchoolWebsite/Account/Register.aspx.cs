using System;
using System.Linq;
using System.Web;
using System.Web.UI;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Owin;
using DrivingSchoolWebsite.Models;

namespace DrivingSchoolWebsite.Account
{
    public partial class Register : Page
    {
        private const int ID_NUMBER_LENGTH = 13; // South African ID number length
        private const int CENTURY_CUTOFF = 100; // Adjust century

        protected void CreateUser_Click(object sender, EventArgs e)
        {
            var manager = Context.GetOwinContext().GetUserManager<ApplicationUserManager>();

            // Attempt to parse the Learner License Issue Date
            DateTime issueDate;
            if (!DateTime.TryParse(LearnerLicenseIssueDate.Text, out issueDate))
            {
                ErrorMessage.Text = "Invalid Learner License Issue Date format.";
                return;
            }

            // Check if the issue date is in the future or older than 2 years
            var twoYearsAgo = DateTime.Now.AddYears(-2);
            if (issueDate > DateTime.Now || issueDate < twoYearsAgo)
            {
                ErrorMessage.Text = "Learner License Issue Date must be within the last 2 years and cannot be in the future.";
                return;
            }

            // Calculate the expiry date
            DateTime expiryDate = issueDate.AddYears(2);

            // Include First Name and Last Name
            var user = new ApplicationUser()
            {
                UserName = Email.Text,
                Email = Email.Text,
                FirstName = FirstName.Text,
                LastName = LastName.Text,
                IDNumber = IDNumber.Text,
                PhoneNumber = PhoneNumber.Text,
                StreetAddress = StreetAddress.Text,
                Suburb = Suburb.Text,
                Race = Race.Text,
                Gender = Gender.Text,
                Age = CalculateAgeFromIDNumber(IDNumber.Text), // Calculate Age
                LessonCode = LessonCode.Text,
                LearnerLicenseIssueDate = issueDate,
                LearnerLicenseExpiryDate = expiryDate // Set the expiry date
            };

            IdentityResult result = manager.Create(user, Password.Text);
            if (result.Succeeded)
            {
                // Redirect to the login page after successful registration
                Response.Redirect("~/Account/Login.aspx");
            }
            else
            {
                ErrorMessage.Text = result.Errors.FirstOrDefault();
            }
        }

        private int CalculateAgeFromIDNumber(string idNumber)
        {
            // Validate the ID number length
            if (idNumber.Length != ID_NUMBER_LENGTH)
            {
                throw new ArgumentException("Invalid ID Number length. It should be 13 digits.");
            }

            // Assuming the first six digits of the ID number represent the birth date (YYMMDD).
            string birthDateString = idNumber.Substring(0, 6);
            DateTime birthDate = DateTime.ParseExact(birthDateString, "yyMMdd", null);

            // Adjust the year to the correct century if needed.
            if (birthDate > DateTime.Now)
            {
                birthDate = birthDate.AddYears(-CENTURY_CUTOFF);
            }

            return DateTime.Now.Year - birthDate.Year;
        }
    }
}