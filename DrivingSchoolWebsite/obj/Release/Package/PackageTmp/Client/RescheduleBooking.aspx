<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RescheduleBooking.aspx.cs" Inherits="DrivingSchoolWebsite.Client.ResceduleBooking" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <section style="padding: 50px; background-color: #333; color: #fff;">
        <h2 style="text-align: center; margin-bottom: 40px;">Reschedule a Booking</h2>
        
        <!-- Booking List Section -->
        <div class="text-center">
            <asp:Label ID="Label1" runat="server" Text="Booking List" Font-Bold="True" Font-Size="Large"></asp:Label>
        </div>
        
        <!-- Container for centralized and scrollable GridView -->
        <div class="container">
            <div class="grid-container">
                <asp:GridView 
                    ID="gvBookingDetails" 
                    runat="server" 
                    AutoGenerateColumns="False" 
                    DataSourceID="SqlDataSource1" 
                    DataKeyNames="BookingID" 
                    OnSelectedIndexChanged="gvBookingDetails_SelectedIndexChanged" 
                    CssClass="gv-with-scroll table table-bordered" 
                    HorizontalAlign="Center">
                    <Columns>
                        <asp:CommandField ShowSelectButton="True" />
                        <asp:BoundField DataField="BookingID" HeaderText="BookingID" InsertVisible="False" ReadOnly="True" SortExpression="BookingID" />
                        <asp:BoundField DataField="Booking_Date" DataFormatString="{0:d}" HeaderText="Booking_Date" SortExpression="Booking_Date" />
                        <asp:BoundField DataField="Booking_StartTime" HeaderText="Booking_StartTime" SortExpression="Booking_StartTime" />
                        <asp:BoundField DataField="Booking_EndTime" HeaderText="Booking_EndTime" SortExpression="Booking_EndTime" />
                        <asp:BoundField DataField="Booking_TotalCost" HeaderText="Booking_TotalCost" SortExpression="Booking_TotalCost" />
                        <asp:BoundField DataField="Booking_FeeDue" HeaderText="Booking_FeeDue" SortExpression="Booking_FeeDue" />
                        <asp:BoundField DataField="Employee_Name" HeaderText="Employee_Name" SortExpression="Employee_Name" />
                        <asp:BoundField DataField="Employee_Surname" HeaderText="Employee_Surname" SortExpression="Employee_Surname" />
                        <asp:BoundField DataField="Vehicle_Make" HeaderText="Vehicle_Make" SortExpression="Vehicle_Make" />
                        <asp:BoundField DataField="Vehicle_Model" HeaderText="Vehicle_Model" SortExpression="Vehicle_Model" />
                    </Columns>
                </asp:GridView>
            </div>
        </div>

        <!-- SqlDataSource for Booking Details -->
        <asp:SqlDataSource 
            ID="SqlDataSource1" 
            runat="server" 
            ConnectionString="<%$ ConnectionStrings:DefaultConnection %>" 
            SelectCommand="SELECT tblBooking.BookingID, tblBooking.Booking_Date, tblBooking.Booking_StartTime, tblBooking.Booking_EndTime, tblEmployee.Employee_Name, tblEmployee.Employee_Surname, tblVehicle.Vehicle_Make, tblVehicle.Vehicle_Model FROM tblBooking INNER JOIN tblEmployee ON tblBooking.EmployeeID = tblEmployee.EmployeeID INNER JOIN tblLessonCode ON tblBooking.Code_Type = tblLessonCode.Code_Type INNER JOIN tblVehicle ON tblBooking.VehicleID = tblVehicle.VehicleID WHERE (tblBooking.LearnerID = @LearnerID) AND (tblBooking.Booking_Status = @BookingStatus)" 
            OnUpdated="SqlDataSource1_Updated">
            <SelectParameters>
                <asp:Parameter Name="LearnerID" DefaultValue="" />
                <asp:Parameter Name="BookingStatus" DefaultValue="Incomplete" />
            </SelectParameters>
        </asp:SqlDataSource>

        <!-- Booking Details and Rescheduling Form -->
        <div>
            <asp:Label ID="lblBookingID" runat="server" Text="" CssClass="center-label"></asp:Label>
        </div>
        <br />
        <div style="max-width: 800px; margin: auto;">
            
            <!-- Date Field -->
            <div class="form-group">
                <label for="bookingDate">Select Date</label>
                <asp:TextBox 
                    ID="bookingDate" 
                    runat="server" 
                    TextMode="Date" 
                    Placeholder="Select Date" 
                    style="width: 100%; padding: 10px; margin-bottom: 20px;" 
                    required="required" 
                    AutoPostBack="True" 
                    OnTextChanged="bookingDate_TextChanged">
                </asp:TextBox>
                <asp:Label ID="lblDateError" runat="server" Text="" ForeColor="White"></asp:Label>
            </div>

            <!-- Start Time Field -->
            <div class="form-group">
                <label for="startTime">Start Time</label>
                <asp:DropDownList 
                    ID="TimeSlotDropDown" 
                    runat="server"  
                    style="width: 100%; padding: 10px; margin-bottom: 20px;" 
                    AutoPostBack="True" 
                    OnSelectedIndexChanged="TimeSlotDropDown_SelectedIndexChanged">
                    <asp:ListItem Value="11:00">11:00</asp:ListItem>
                    <asp:ListItem Value="12:00">12:00</asp:ListItem>
                    <asp:ListItem Value="13:00">13:00</asp:ListItem>
                    <asp:ListItem Value="14:00">14:00</asp:ListItem>
                    <asp:ListItem Value="15:00">15:00</asp:ListItem>
                    <asp:ListItem Value="16:00">16:00</asp:ListItem>
                </asp:DropDownList>
                <asp:Label ID="lblStartTimeError" runat="server" Text="" ForeColor="White"></asp:Label>
            </div>

            <!-- End Time Field -->
            <div class="form-group">
                <label for="endTime">End Time</label>
                <asp:DropDownList 
                    ID="DropDownList1" 
                    runat="server"  
                    style="width: 100%; padding: 10px; margin-bottom: 20px;" 
                    AutoPostBack="True" 
                    OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                    <asp:ListItem Value="12:00">12:00</asp:ListItem>
                    <asp:ListItem Value="13:00">13:00</asp:ListItem>
                    <asp:ListItem Value="14:00">14:00</asp:ListItem>
                    <asp:ListItem Value="15:00">15:00</asp:ListItem>
                    <asp:ListItem Value="16:00">16:00</asp:ListItem>
                    <asp:ListItem Value="17:00">17:00</asp:ListItem>
                </asp:DropDownList>
                <asp:Label ID="lblEndTimeError" runat="server" ForeColor="White"></asp:Label>
            </div>

            <!-- Code Type Field (Read-Only) -->
            <div class="form-group">
                <label for="codeType">Code Type</label>
                <asp:TextBox 
                    ID="txtCodeType" 
                    runat="server" 
                    TextMode="SingleLine"  
                    style="width: 100%; padding: 10px; margin-bottom: 20px;" 
                    ReadOnly="true">
                </asp:TextBox>
            </div>

            <!-- Instructor Dropdown -->
            <div class="form-group">
                <label for="instructor">Select Instructor</label>
                <asp:DropDownList 
                    ID="instructorDropDownList" 
                    runat="server" 
                    CssClass="form-control" 
                    style="width: 100%; padding: 10px; margin-bottom: 20px" 
                    DataSourceID="SqlDataSource2" 
                    DataTextField="Employee_Name" 
                    DataValueField="EmployeeID">
                </asp:DropDownList>
                <asp:SqlDataSource 
                    ID="SqlDataSource2" 
                    runat="server" 
                    ConnectionString="<%$ ConnectionStrings:DefaultConnection %>" 
                    SelectCommand="
                        SELECT * 
                        FROM [tblEmployee] e
                        WHERE 
                            e.[Code_Type] = @Code_Type 
                            AND e.[Employee_Type] = @Employee_Type 
                            AND e.[EmployeeID] NOT IN (
                                SELECT b.[EmployeeID]
                                FROM [tblBooking] b
                                WHERE 
                                    b.[Booking_Date] = @Booking_Date
                                    AND (
                                        (b.[Booking_StartTime] &lt; @Booking_EndTime AND b.[Booking_EndTime] &gt; @Booking_StartTime)
                                    )
                                    AND b.[BookingID] &lt;&gt; @BookingID
                            );">
                    <SelectParameters>
                        <asp:ControlParameter ControlID="txtCodeType" Name="Code_Type" PropertyName="Text" />
                        <asp:Parameter DefaultValue="Instructor" Name="Employee_Type" />
                        <asp:ControlParameter ControlID="bookingDate" Name="Booking_Date" PropertyName="Text" />
                        <asp:ControlParameter ControlID="DropDownList1" Name="Booking_EndTime" PropertyName="SelectedValue" />
                        <asp:ControlParameter ControlID="TimeSlotDropDown" Name="Booking_StartTime" PropertyName="SelectedValue" />
                        <asp:Parameter Name="BookingID" />
                    </SelectParameters>
                </asp:SqlDataSource>
            </div>

            <!-- Vehicle Dropdown -->
            <div class="form-group">
                <label for="vehicle">Select Vehicle</label>
                <asp:DropDownList 
                    ID="vehicleDropDownList" 
                    runat="server" 
                    CssClass="form-control" 
                    style="width: 100%; padding: 10px; margin-bottom: 20px" 
                    DataSourceID="SqlDataSource3" 
                    DataTextField="Vehicle_Model" 
                    DataValueField="VehicleID">
                    <asp:ListItem Text="" Value="" />
                </asp:DropDownList>
                <asp:SqlDataSource 
                    ID="SqlDataSource3" 
                    runat="server" 
                    ConnectionString="<%$ ConnectionStrings:DefaultConnection %>" 
                    SelectCommand="
                        SELECT * 
                        FROM [tblVehicle] AS v
                        WHERE 
                            v.[Vehicle_Status] = @Vehicle_Status 
                            AND v.[Vehicle_Size] = @Vehicle_Size 
                            AND v.[VehicleID] NOT IN (
                                SELECT b.[VehicleID]
                                FROM [tblBooking] AS b
                                WHERE 
                                    b.[Booking_Date] = @Booking_Date
                                    AND (
                                        b.[Booking_StartTime] &lt; @Booking_EndTime 
                                        AND b.[Booking_EndTime] &gt; @Booking_StartTime
                                    )
                                    AND b.[BookingID] &lt;&gt; @BookingID
                            );">
                    <SelectParameters>
                        <asp:Parameter DefaultValue="Available" Name="Vehicle_Status" />
                        <asp:Parameter DefaultValue="" Name="Vehicle_Size" />
                        <asp:ControlParameter ControlID="bookingDate" Name="Booking_Date" PropertyName="Text" />
                        <asp:ControlParameter ControlID="DropDownList1" Name="Booking_EndTime" PropertyName="SelectedValue" />
                        <asp:ControlParameter ControlID="TimeSlotDropDown" Name="Booking_StartTime" PropertyName="SelectedValue" />
                        <asp:Parameter Name="BookingID" />
                    </SelectParameters>
                </asp:SqlDataSource>
            </div>

            <!-- Booking Cost (Read-Only) -->
            <div class="form-group">
                <label for="bookingCost">Booking Cost</label>
                <asp:TextBox 
                    ID="bookingCost" 
                    runat="server" 
                    TextMode="SingleLine" 
                    style="width: 100%; padding: 10px; margin-bottom: 20px;" 
                    ReadOnly="true" 
                    Text="R0.00">
                </asp:TextBox>
            </div>

            <!-- Submit Button -->
            <asp:Button 
                ID="submitButton" 
                runat="server" 
                Text="Submit" 
                CssClass="submit-button" 
                OnClientClick="return confirmationMessage();" 
                OnClick="SubmitButton_Click" 
                style="width: 100%; padding: 15px; background-color: #4CAF50; color: #fff; border: none; cursor: pointer;" />
            <script>
                function confirmationMessage() {
                    return confirm("Confirm booking reschedule");
                }
            </script>

            <!-- SqlDataSource for Update Operations -->
            <asp:SqlDataSource 
                ID="SqlDSUpdate" 
                runat="server" 
                ConnectionString="<%$ ConnectionStrings:DefaultConnection %>" 
                DeleteCommand="DELETE FROM tblBooking WHERE (BookingID = @BookingID)" 
                InsertCommand="INSERT INTO [tblBooking] ([Booking_Date], [Booking_StartTime], [Booking_EndTime], [Booking_Status], [LearnerID], [Code_Type], [VehicleID], [EmployeeID]) VALUES (@Booking_Date, @Booking_StartTime, @Booking_EndTime, @Booking_Status, @Booking_TotalCost, @Booking_FeeDue, @LearnerID, @Code_Type, @VehicleID, @EmployeeID)" 
                OldValuesParameterFormatString="original_{0}" 
                SelectCommand="SELECT * FROM [tblBooking]" 
                UpdateCommand="UPDATE tblBooking SET Booking_Date = @Booking_Date, Booking_StartTime = @Booking_StartTime, Booking_EndTime = @Booking_EndTime, VehicleID = @VehicleID, EmployeeID = @Employee_ID WHERE (BookingID = @BookingID)">
                <DeleteParameters>
                    <asp:Parameter Name="BookingID" />
                </DeleteParameters>
                <InsertParameters>
                    <asp:Parameter DbType="Date" Name="Booking_Date" />
                    <asp:Parameter DbType="Time" Name="Booking_StartTime" />
                    <asp:Parameter DbType="Time" Name="Booking_EndTime" />
                    <asp:Parameter Name="Booking_Status" Type="String" />
                    <asp:Parameter Name="Booking_TotalCost" Type="Decimal" />
                    <asp:Parameter Name="Booking_FeeDue" Type="Decimal" />
                    <asp:Parameter Name="LearnerID" Type="String" />
                    <asp:Parameter Name="Code_Type" Type="Int32" />
                    <asp:Parameter Name="VehicleID" Type="Int32" />
                    <asp:Parameter Name="EmployeeID" Type="Int32" />
                </InsertParameters>
                <UpdateParameters>
                    <asp:ControlParameter ControlID="bookingDate" Name="Booking_Date" PropertyName="Text" />
                    <asp:Parameter Name="Booking_StartTime" />
                    <asp:Parameter Name="Booking_EndTime" />
                    <asp:Parameter Name="Booking_TotalCost" />
                    <asp:Parameter Name="Booking_FeeDue" />
                    <asp:ControlParameter ControlID="vehicleDropDownList" Name="VehicleID" PropertyName="SelectedValue" />
                    <asp:ControlParameter ControlID="instructorDropDownList" Name="Employee_ID" PropertyName="SelectedValue" />
                    <asp:Parameter Name="BookingID" />
                </UpdateParameters>
            </asp:SqlDataSource>

        </div>
        <br />

        <!-- Cancel Booking Button -->
        <div>
            <asp:Button 
                ID="Button1" 
                runat="server" 
                Text="Cancel Booking" 
                OnClientClick="return confirmationDeletion();" 
                OnClick="Button1_Click" BackColor="Red" ForeColor="White" Height="50px" Width="251px" />
            <script>
                function confirmationDeletion() {
                    return confirm("Confirm cancellation of booking selected");
                }
            </script>
            <asp:SqlDataSource 
                ID="SqlDataSource4" 
                runat="server" 
                ConnectionString="<%$ ConnectionStrings:DefaultConnection %>" 
                DeleteCommand="DELETE FROM [tblBooking] WHERE [BookingID] = @BookingID" 
                InsertCommand="INSERT INTO [tblBooking] ([Booking_Date], [Booking_StartTime], [Booking_EndTime], [Booking_Status], [LearnerID], [Code_Type], [VehicleID], [EmployeeID]) VALUES (@Booking_Date, @Booking_StartTime, @Booking_EndTime, @Booking_Status, @Booking_TotalCost, @Booking_FeeDue, @LearnerID, @Code_Type, @VehicleID, @EmployeeID)" 
                OldValuesParameterFormatString="original_{0}" 
                SelectCommand="SELECT * FROM [tblBooking]" 
                UpdateCommand="UPDATE [tblBooking] SET [Booking_Date] = @Booking_Date, [Booking_StartTime] = @Booking_StartTime, [Booking_EndTime] = @Booking_EndTime, [Booking_Status] = @Booking_Status, [LearnerID] = @LearnerID, [Code_Type] = @Code_Type, [VehicleID] = @VehicleID, [EmployeeID] = @EmployeeID WHERE [BookingID] = @original_BookingID AND [Booking_Date] = @original_Booking_Date AND [Booking_StartTime] = @original_Booking_StartTime AND [Booking_EndTime] = @original_Booking_EndTime AND [Booking_Status] = @original_Booking_Status AND [Booking_TotalCost] = @original_Booking_TotalCost AND [Booking_FeeDue] = @original_Booking_FeeDue AND [LearnerID] = @original_LearnerID AND [Code_Type] = @original_Code_Type AND [VehicleID] = @original_VehicleID AND [EmployeeID] = @original_EmployeeID">
                <DeleteParameters>
                    <asp:ControlParameter ControlID="gvBookingDetails" Name="BookingID" PropertyName="SelectedValue" />
                </DeleteParameters>
                <InsertParameters>
                    <asp:Parameter DbType="Date" Name="Booking_Date" />
                    <asp:Parameter DbType="Time" Name="Booking_StartTime" />
                    <asp:Parameter DbType="Time" Name="Booking_EndTime" />
                    <asp:Parameter Name="Booking_Status" Type="String" />
                    <asp:Parameter Name="Booking_TotalCost" Type="Decimal" />
                    <asp:Parameter Name="Booking_FeeDue" Type="Decimal" />
                    <asp:Parameter Name="LearnerID" Type="String" />
                    <asp:Parameter Name="Code_Type" Type="Int32" />
                    <asp:Parameter Name="VehicleID" Type="Int32" />
                    <asp:Parameter Name="EmployeeID" Type="Int32" />
                </InsertParameters>
                <UpdateParameters>
                    <asp:Parameter DbType="Date" Name="Booking_Date" />
                    <asp:Parameter DbType="Time" Name="Booking_StartTime" />
                    <asp:Parameter DbType="Time" Name="Booking_EndTime" />
                    <asp:Parameter Name="Booking_Status" Type="String" />
                    <asp:Parameter Name="Booking_TotalCost" Type="Decimal" />
                    <asp:Parameter Name="Booking_FeeDue" Type="Decimal" />
                    <asp:Parameter Name="LearnerID" Type="String" />
                    <asp:Parameter Name="Code_Type" Type="Int32" />
                    <asp:Parameter Name="VehicleID" Type="Int32" />
                    <asp:Parameter Name="EmployeeID" Type="Int32" />
                    <asp:Parameter Name="original_BookingID" Type="Int32" />
                    <asp:Parameter DbType="Date" Name="original_Booking_Date" />
                    <asp:Parameter DbType="Time" Name="original_Booking_StartTime" />
                    <asp:Parameter DbType="Time" Name="original_Booking_EndTime" />
                    <asp:Parameter Name="original_Booking_Status" Type="String" />
                    <asp:Parameter Name="original_Booking_TotalCost" Type="Decimal" />
                    <asp:Parameter Name="original_Booking_FeeDue" Type="Decimal" />
                    <asp:Parameter Name="original_LearnerID" Type="String" />
                    <asp:Parameter Name="original_Code_Type" Type="Int32" />
                    <asp:Parameter Name="original_VehicleID" Type="Int32" />
                    <asp:Parameter Name="original_EmployeeID" Type="Int32" />
                </UpdateParameters>
            </asp:SqlDataSource>
        </div>
    </section>

    <!-- CSS Styles -->
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
            width: 100%;
        }

        .gv-with-scroll td {
            padding: 10px;
        }

        .gv-with-scroll {
            border-spacing: 5px;
        }

        /* Form element styling */
        .center-label {
            text-align: center;
            display: block;
            width: 100%;
        }

        .form-group {
            margin-bottom: 15px;
        }

        .form-group label {
            display: block;
            margin-bottom: 5px;
            font-weight: bold;
        }

        .form-group input,
        .form-group select {
            width: 100%;
            padding: 8px;
            font-size: 16px;
            border: 1px solid #ccc;
            border-radius: 4px;
        }

        .form-group input[readonly] {
            background-color: #e9e9e9;
        }

        /* Button styling */
        .submit-button {
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

        .submit-button:hover {
            background-color: #45a049;
        }

        /* Additional Styles */
        body {
            background-image: url('/Images/Home_Page_Background.png'); /* Replace with your image path */
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

        /* Table Styling (Optional Enhancements) */
        .table {
            width: 100%;
            border-collapse: collapse;
        }

        .table-bordered th, .table-bordered td {
            border: 1px solid #ddd;
            padding: 8px;
        }

        .table-bordered th {
            background-color: #1C5E55;
            color: white;
            text-align: left;
        }

        .table-bordered tr:nth-child(even) {
            background-color: #f2f2f2;
        }

        .table-bordered tr:hover {
            background-color: #ddd;
        }

    </style>

    
</asp:Content>



