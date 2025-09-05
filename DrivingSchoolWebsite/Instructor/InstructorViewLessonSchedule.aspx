<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="InstructorViewLessonSchedule.aspx.cs" Inherits="DrivingSchoolWebsite.Instructor.InstructorViewLessonSchedule" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server"> 

    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:DefaultConnection %>" SelectCommand="SELECT e.Employee_Name, e.Employee_Surname, b.BookingID, b.Booking_Date, b.Booking_StartTime, b.Booking_EndTime, b.Booking_TotalCost, learner.FirstName, learner.LastName, u.Id, b.VehicleID, tblVehicle.Vehicle_NumberPlate, tblVehicle.Vehicle_Make, tblVehicle.Vehicle_Model FROM AspNetUsers AS u INNER JOIN tblEmployee AS e ON u.Email = e.Employee_Username INNER JOIN tblBooking AS b ON e.EmployeeID = b.EmployeeID INNER JOIN tblVehicle ON b.VehicleID = tblVehicle.VehicleID LEFT OUTER JOIN AspNetUsers AS learner ON b.LearnerID = learner.Id WHERE (u.Id = @UserId) AND (@SelectedDate IS NULL) OR (u.Id = @UserId) AND (b.Booking_Date = @SelectedDate) ORDER BY b.Booking_Date DESC">
        <SelectParameters>
            <asp:ControlParameter ControlID="Label1" Name="UserId" PropertyName="Text" />
            <asp:ControlParameter ControlID="Calendar1" Name="SelectedDate" PropertyName="SelectedDate" />
        </SelectParameters>
    </asp:SqlDataSource>

    <div class="text-center">
        <asp:Label ID="Label1" runat="server" Text="Label" Visible="False"></asp:Label>
        <h1>Please select a date</h1>
    </div>
    

    <div class="container"> 
        <div class="calendar-container">
            <asp:Calendar ID="Calendar1" runat="server" OnSelectionChanged="Calendar1_SelectionChanged" CssClass="centered-calendar"></asp:Calendar>         
        </div>
    </div>
  
    <!-- Container for GridView with scroll and centering -->
    <div class="gridview-container">
        <div class="gridview-wrapper">
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" Width="1535px">
                <Columns>
                    <asp:BoundField DataField="Employee_Name" HeaderText="Employee_Name" SortExpression="Employee_Name" />
                    <asp:BoundField DataField="Employee_Surname" HeaderText="Employee_Surname" SortExpression="Employee_Surname" />
                    <asp:BoundField DataField="BookingID" HeaderText="BookingID" InsertVisible="False" ReadOnly="True" SortExpression="BookingID" />
                    <asp:BoundField DataField="Booking_Date" HeaderText="Booking_Date" SortExpression="Booking_Date" />
                    <asp:BoundField DataField="Booking_StartTime" HeaderText="Booking_StartTime" SortExpression="Booking_StartTime" />
                    <asp:BoundField DataField="Booking_EndTime" HeaderText="Booking_EndTime" SortExpression="Booking_EndTime" />
                    <asp:BoundField DataField="Booking_TotalCost" HeaderText="Booking_TotalCost" SortExpression="Booking_TotalCost" />
                    <asp:BoundField DataField="FirstName" HeaderText="FirstName" SortExpression="FirstName" />
                    <asp:BoundField DataField="LastName" HeaderText="LastName" SortExpression="LastName" />
                    <asp:BoundField DataField="Id" HeaderText="Id" SortExpression="Id" />
                    <asp:BoundField DataField="VehicleID" HeaderText="VehicleID" SortExpression="VehicleID" />
                    <asp:BoundField DataField="Vehicle_NumberPlate" HeaderText="Vehicle_NumberPlate" SortExpression="Vehicle_NumberPlate" />
                    <asp:BoundField DataField="Vehicle_Make" HeaderText="Vehicle_Make" SortExpression="Vehicle_Make" />
                    <asp:BoundField DataField="Vehicle_Model" HeaderText="Vehicle_Model" SortExpression="Vehicle_Model" />
                </Columns>
            </asp:GridView>
        </div>
    </div>

    <style>
        .container {
            text-align: center;
            margin: 0 auto;
            padding: 20px;
        }

        .calendar-container {
            display: inline-block;
            text-align: center;
        }

        .centered-calendar {
            display: inline-block;
            border: 1px solid #ccc; /* Optional: Add a border for better visibility */
            padding: 10px; /* Optional: Add padding for spacing */
        }

        /* New Styles for GridView container */
        .gridview-container {
            width: 100%;
            overflow-x: auto; /* Allow horizontal scroll */
            text-align: center;
            margin-top: 20px;
        }

        .gridview-wrapper {
            display: inline-block;
            min-width: 100%; /* Ensures it doesn't shrink smaller than the content */
            max-width: 90%; /* Keeps the GridView from stretching too wide */
            overflow-x: auto; /* Scroll horizontally if content overflows */
        }

        .gridview-container .gridview-wrapper {
            border: 1px solid #ddd;
            padding: 10px;
            box-sizing: border-box;
            overflow-x: scroll;
        }

        .gridview-wrapper table {
            border-collapse: collapse;
        }

        .gridview-wrapper th, .gridview-wrapper td {
            padding: 8px;
            text-align: left;
            border-bottom: 1px solid #ddd;
        }

        .gridview-wrapper th {
            background-color: #f4f4f4;
        }
    </style>

</asp:Content>

