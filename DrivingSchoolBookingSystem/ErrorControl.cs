using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrivingSchoolBookingSystem
{
    internal class ErrorControl
    {
        public ErrorControl() { }

        public string ValidateNumberPlate(string numPlate)
        {

            string message = null;
            string pattern = @"[^a-zA-Z0-9]";
            if (numPlate.Length > 9 || Regex.IsMatch(numPlate, pattern))
            {
                message = "Invalid Number Plate!";
            }
            return message;
        }

        public string ValidateRegNum(string numPlate)
        {
            string message = null;
            string pattern = @"[^a-zA-Z0-9]";
            if (numPlate.Length != 7 || Regex.IsMatch(numPlate, pattern))
            {
                message = "Invalid Registration Number!";
            }
            return message;
        }
        public string ValidateEngineNum(string engineNum)
        {
            string message = null;
            string pattern = @"[^a-zA-Z0-9]";
            if (engineNum.Length != 5 || Regex.IsMatch(engineNum, pattern))
            {
                message = "Invalid Engine Number!";
            }
            return message;
        }

        public string ValidateMake(string make)
        {
            string message = null;
            string pattern = @"^[a-zA-Z]+$";
            if (!Regex.IsMatch(make, pattern))
                message = "Invalid Make!,Enter only letters";
            return message;

        }

        public string ValidateModel(string model)
        {
            string message = null;
            string pattern = @"^[a-zA-Z0-9\s\-\.]+$";
            if (!Regex.IsMatch(model, pattern))
                message = "Invalid Model!,No specials characters other than '.' & '-'";
            return message;
        }

        public string ValidateTimes(int startTime, int endTime)
        {
            string message = null;
            if (endTime - startTime < 0)
                message = "Booking end time has to be greater than the start time!";
            if (endTime - startTime == 0)
                message = "Booking end time cannot be the same as the start time!";
            return message;

        }

        public string ValidateBookingDate(DateTime date)
        {
            string message = null;
            if (date < DateTime.Now.Date)
                message = "Booking date cannot be before todays date!";
            return message;
        }


        public string ValidateUnavailableSlotStartDate(DateTime date)
        {
            string message = null;
            if (date < DateTime.Now.Date)
                message = "Unavailable slot start date cannot be before todays date!";
            return message;

        }
        public string ValidateCodeType(string codeType)
        {
            string message = null;
            if (!Regex.IsMatch(codeType, @"^\d+$"))
                message = "Invalid Code Type, Only enter numbers!";
            return message;
        }

        public string ValidatePricePerHour(string pricePerHour)
        {
            string message = null;
            if (!Regex.IsMatch(pricePerHour, @"^\d+(\,\d+)?$"))
                message = "Invalid Price, Only enter numbers and/or ',' for seperating rands and cents!";
            return message;

        }

        public string ValidatePaymentMethod(string paymentMethod)
        {
            string message = null;
            string pattern = @"^[a-zA-Z]+$";
            if (!Regex.IsMatch(paymentMethod, pattern))
                message = "Invalid payment method,select an option provided!";
            return message;
        }

        public string ValidatepaymentAmount(string pricePerHour)
        {
            string message = null;
            if (!Regex.IsMatch(pricePerHour, @"^\d+(\,\d+)?$"))
                message = "Invalid payment amount, only enter numbers  and/or ',' for seperating rands and cents!";
            return message;
        }

        public string validateUnavailbleSlotDates(DateTime startDate, DateTime endDate)
        {
            string message = null;
            if (endDate < startDate)
                message = "Invalid dates, Unavailable end date cannot be before the start date!";
            return message;
        }

        public string ValidateUnavailableSlotTimes(int startTime, int endTime)
        {
            string message = null;
            if (endTime - startTime < 0)
                message = "Unavailable slot end time has to be greater than the start time!";
            if (endTime - startTime == 0)
                message = "Unavailable slot end time cannot be the same as the start time!";
            return message;

        }

        public string ValidateUnavailableSlotReason(string reason)
        {
            string message = null;
            string pattern = @"^[a-zA-Z0-9\s\-\.]+$";
            if (!Regex.IsMatch(reason, pattern))
                message = "Invalid Reason!Please enter only letters";
            return message;

        }
    }
}
