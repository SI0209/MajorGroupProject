<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ClientViewLessonSchedule.aspx.cs" Inherits="DrivingSchoolWebsite.Client.ClientViewLessonSchedule" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <section style="padding: 50px; background-color: #333; color: #fff;">
        <div style="max-width: 900px; margin: auto;">
            <h2 style="text-align: center;">View Schedule</h2>

            
            <label for="selectedDate">Select Date</label>
            <asp:TextBox ID="selectedDate" runat="server" CssClass="form-control" TextMode="Date" 
                         style="width: 100%; padding: 10px; margin-bottom: 20px;" AutoPostBack="True"></asp:TextBox>
            <asp:Button ID="btnViewSchedule" runat="server" Text="View Schedule" CssClass="btn" 
                        OnClick="btnViewSchedule_Click" style="width: 100%; padding: 15px; margin-bottom: 20px;" />

            
            <div class="container">
                <div class="grid-container">
                    <asp:GridView ID="gridBookings" runat="server" CssClass="table table-bordered gv-with-scroll" 
                                  style="margin-top: 20px;" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="Code_Type" DataSourceID="SqlDataSource1" ForeColor="#333333" GridLines="None" HorizontalAlign="Left">
                        <AlternatingRowStyle BackColor="White" />
                        <Columns>
                            <asp:BoundField DataField="Booking_Date" HeaderText="Booking_Date" DataFormatString="{0:d}" SortExpression="Booking_Date" />
                            <asp:BoundField DataField="Booking_StartTime" HeaderText="Booking_StartTime" SortExpression="Booking_StartTime" />
                            <asp:BoundField DataField="Booking_EndTime" HeaderText="Booking_EndTime" SortExpression="Booking_EndTime" />
                            <asp:BoundField DataField="Booking_Status" HeaderText="Booking_Status" SortExpression="Booking_Status" />
                            <asp:BoundField DataField="Booking_TotalCost" HeaderText="Booking_TotalCost" DataFormatString="{0:c}" SortExpression="Booking_TotalCost" />
                            <asp:BoundField DataField="Booking_FeeDue" HeaderText="Booking_FeeDue" DataFormatString="{0:c}" SortExpression="Booking_FeeDue" />
                            <asp:BoundField DataField="Employee_Name" HeaderText="Employee_Name" SortExpression="Employee_Name" />
                            <asp:BoundField DataField="Employee_Surname" HeaderText="Employee_Surname" SortExpression="Employee_Surname" />
                            <asp:BoundField DataField="Vehicle_Make" HeaderText="Vehicle_Make" SortExpression="Vehicle_Make" />
                            <asp:BoundField DataField="Vehicle_Model" HeaderText="Vehicle_Model" SortExpression="Vehicle_Model" />
                            <asp:BoundField DataField="Code_Type" HeaderText="Code_Type" ReadOnly="True" SortExpression="Code_Type" />
                        </Columns>
                        <EditRowStyle BackColor="#7C6F57" />
                        <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                        <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
                        <RowStyle BackColor="#E3EAEB" />
                        <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
                        <SortedAscendingCellStyle BackColor="#F8FAFA" />
                        <SortedAscendingHeaderStyle BackColor="#246B61" />
                        <SortedDescendingCellStyle BackColor="#D4DFE1" />
                        <SortedDescendingHeaderStyle BackColor="#15524A" />
                    </asp:GridView>
                </div>
            </div>

        </div>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:DefaultConnection %>" 
            SelectCommand="SELECT tblBooking.Booking_Date, tblBooking.Booking_EndTime, tblBooking.Booking_StartTime, tblBooking.Booking_Status, tblBooking.Booking_TotalCost, tblBooking.Booking_FeeDue, tblEmployee.Employee_Name, tblEmployee.Employee_Surname, tblVehicle.Vehicle_Make, tblVehicle.Vehicle_Model, tblLessonCode.Code_Type FROM tblBooking INNER JOIN tblEmployee ON tblBooking.EmployeeID = tblEmployee.EmployeeID INNER JOIN tblLessonCode ON tblBooking.Code_Type = tblLessonCode.Code_Type INNER JOIN tblVehicle ON tblBooking.VehicleID = tblVehicle.VehicleID WHERE (tblBooking.LearnerID = @LearnerID) AND Booking_Date = @Booking_Date">
            <SelectParameters>
                <asp:Parameter Name="LearnerID" />
                <asp:Parameter Name="Booking_Date" />
            </SelectParameters>
        </asp:SqlDataSource>
    </section>

    <style>
        /* Reusing styles for centralized and scrollable grid */
        .container {
            width: 100%;
            max-width: 1200px;
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
            border-spacing: 5px;
        }

        /* Additional styles */
        body {
            background-image: url('/Images/Background.png');
            background-size: cover;
            background-position: center;
            background-repeat: no-repeat;
            margin: 0;
            padding: 0;
            height: 100vh;
        }

        .btn {
            display: block;
            width: 100%;
            padding: 10px;
            font-size: 18px;
            color: white;
            background-color: #4CAF50;
            border: none;
            border-radius: 4px;
            cursor: pointer;
            text-align: center;
        }

        .btn:hover {
            background-color: #45a049;
        }
    </style>



</asp:Content>
