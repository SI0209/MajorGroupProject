<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ViewLessonSchedule.aspx.cs" Inherits="DrivingSchoolWebsite.Admin.ViewLessonSchedule" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <section style="padding: 50px; background-color: #f4f4f4;">
        <h2 style="text-align: center; margin-bottom: 40px;">View Lesson Schedule</h2>

        <div style="max-width: 800px; margin: auto;">
            <div class="text-center" style="margin-bottom: 20px;">
                <asp:Label ID="lblStartDate" runat="server" Text="Start Date: "></asp:Label>
                <asp:TextBox ID="txtStartDate" runat="server" TextMode="Date" />

                <asp:Label ID="lblEndDate" runat="server" Text="End Date: "></asp:Label>
                <asp:TextBox ID="txtEndDate" runat="server" TextMode="Date" />

                <asp:DropDownList ID="ddlInstructor" runat="server" style="margin-left: 10px;" AutoPostBack="True" DataSourceID="sqldsInstructorName" DataTextField="Employee_Name" DataValueField="Employee_Name"></asp:DropDownList>
                <asp:SqlDataSource ID="sqldsInstructorName" runat="server" ConnectionString="<%$ ConnectionStrings:WstGrp2ConnectionString %>" SelectCommand="SELECT [Employee_Name] FROM [tblEmployee]"></asp:SqlDataSource>

                <asp:Button ID="btnFilter" runat="server" Text="Filter" OnClick="btnFilter_Click" style="margin-left: 10px;" />
            </div>

            <div class="container">
                <div class="grid-container">
                    <asp:GridView ID="gvLessonSchedule" runat="server" AutoGenerateColumns="False" DataSourceID="dsLessonSchedule" Width="300%" CssClass="gv-with-scroll">
                        <Columns>
                            <asp:BoundField DataField="Booking_TotalCost" HeaderText="Booking_TotalCost" SortExpression="Booking_TotalCost" ItemStyle-Width="1000px" />
                            <asp:BoundField DataField="BookingID" HeaderText="BookingID" SortExpression="BookingID" ItemStyle-Width="1000px" InsertVisible="False" ReadOnly="True"/>
                            <asp:BoundField DataField="Booking_Date" HeaderText="Booking_Date" SortExpression="Booking_Date" ItemStyle-Width="1000px"/>
                            <asp:BoundField DataField="Booking_StartTime" HeaderText="Booking_StartTime" SortExpression="Booking_StartTime" ItemStyle-Width="1000px"/>
                            <asp:BoundField DataField="Booking_EndTime" HeaderText="Booking_EndTime" SortExpression="Booking_EndTime" ItemStyle-Width="1000px"/>
                            <asp:BoundField DataField="Code_Type" HeaderText="Code_Type" SortExpression="Code_Type" ItemStyle-Width="1000px"/>
                            <asp:BoundField DataField="EmployeeID" HeaderText="EmployeeID" SortExpression="EmployeeID" ItemStyle-Width="1000px" InsertVisible="False" ReadOnly="True"/>
                            <asp:BoundField DataField="Employee_Name" HeaderText="Employee_Name" SortExpression="Employee_Name" ItemStyle-Width="1000px"/>
                            <asp:BoundField DataField="Employee_Surname" HeaderText="Employee_Surname" SortExpression="Employee_Surname" ItemStyle-Width="1000px"/>
                            <asp:BoundField DataField="FirstName" HeaderText="FirstName" SortExpression="FirstName" ItemStyle-Width="1000px"/>
                            <asp:BoundField DataField="LastName" HeaderText="LastName" SortExpression="LastName" ItemStyle-Width="1000px"/>
                            <asp:BoundField DataField="IDNumber" HeaderText="IDNumber" SortExpression="IDNumber" ItemStyle-Width="1000px"/>
                            <asp:BoundField DataField="Vehicle_NumberPlate" HeaderText="Vehicle_NumberPlate" SortExpression="Vehicle_NumberPlate" ItemStyle-Width="1000px"/>
                            <asp:BoundField DataField="Vehicle_Make" HeaderText="Vehicle_Make" SortExpression="Vehicle_Make" ItemStyle-Width="1000px"/>
                            <asp:BoundField DataField="Vehicle_Model" HeaderText="Vehicle_Model" SortExpression="Vehicle_Model" />
                        </Columns>
                    </asp:GridView>
                </div>
            </div>

            <asp:SqlDataSource ID="dsLessonSchedule" runat="server" ConnectionString="<%$ ConnectionStrings:WstGrp2ConnectionString %>" SelectCommand="SELECT b.Booking_TotalCost, b.BookingID, b.Booking_Date, b.Booking_StartTime, b.Booking_EndTime, b.Code_Type, e.EmployeeID, e.Employee_Name, e.Employee_Surname, learner.FirstName, learner.LastName, learner.IDNumber, v.Vehicle_NumberPlate, v.Vehicle_Make, v.Vehicle_Model FROM tblBooking AS b INNER JOIN tblEmployee AS e ON b.EmployeeID = e.EmployeeID INNER JOIN tblVehicle AS v ON b.VehicleID = v.VehicleID LEFT OUTER JOIN AspNetUsers AS learner ON b.LearnerID = learner.Id WHERE (e.Employee_Name = @Employee_Name) AND (b.Booking_Date BETWEEN @StartDate AND @EndDate) ORDER BY b.Booking_Date DESC">
                <SelectParameters>
                    <asp:ControlParameter ControlID="ddlInstructor" Name="Employee_Name" PropertyName="SelectedValue" />
                    <asp:ControlParameter ControlID="txtStartDate" Name="StartDate" PropertyName="Text" />
                    <asp:ControlParameter ControlID="txtEndDate" Name="EndDate" PropertyName="Text" />
                </SelectParameters>
            </asp:SqlDataSource>
        </div>
    </section>

    <style>
        /* Add your CSS styles here */
        .container {
            width: 100%;
            max-width: 1200px; /* Adjust max width as needed */
            margin: 0 auto;
        }

        .grid-container {
            overflow-x: auto;
        }

        .gv-with-scroll {
            white-space: nowrap;
        }

        .gv-with-scroll td {
            padding: 10px;
        }

        .gv-with-scroll {
            border-spacing: 5px; /* Adjust the spacing as needed */
        }

    </style>

</asp:Content>

