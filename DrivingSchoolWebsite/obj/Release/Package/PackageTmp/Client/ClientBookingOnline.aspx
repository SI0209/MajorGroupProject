<%@ Page Title="Booking Form" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ClientBookingOnline.aspx.cs" Inherits="DrivingSchoolWebsite.Client.ClientBookingOnline" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <section style="padding: 50px; background-color: #333; color: #fff;">
        <h2 style="text-align: center; margin-bottom: 40px;">Make a Booking</h2>
        <div style="max-width: 800px; margin: auto;">
            
            <!-- Date field -->
            <div class="form-group">
                <label for="bookingDate">Select Date</label>
                <asp:TextBox ID="bookingDate" runat="server" TextMode="Date" Placeholder="Select Date" 
                             style="width: 100%; padding: 10px; margin-bottom: 20px;" required="required" AutoPostBack="True" OnTextChanged="bookingDate_TextChanged"></asp:TextBox>
                <asp:Label ID="lblDateError" runat="server" Text="" ForeColor="White"></asp:Label>
                </div>

            <!-- Start time field -->
            <div class="form-group">
                <label for="startTime">Start Time</label>
                <asp:DropDownList ID="TimeSlotDropDown" runat="server"  style="width: 100%; padding: 10px; margin-bottom: 20px;" AutoPostBack="True" OnSelectedIndexChanged="TimeSlotDropDown_SelectedIndexChanged">
                    <asp:ListItem Value="11:00">11:00</asp:ListItem>
                    <asp:ListItem Value="12:00">12:00</asp:ListItem>
                    <asp:ListItem Value="13:00">13:00</asp:ListItem>
                    <asp:ListItem Value="14:00">14:00</asp:ListItem>
                    <asp:ListItem Value="15:00">15:00</asp:ListItem>
                    <asp:ListItem Value="16:00">16:00</asp:ListItem>
                   
                </asp:DropDownList>
                
                <asp:Label ID="lblStartTimeError" runat="server" Text="" ForeColor="White"></asp:Label>
            </div>

            <!-- End time field -->
            <div class="form-group">
                <label for="endTime">End Time</label>
                <asp:DropDownList ID="DropDownList1" runat="server"  style="width: 100%; padding: 10px; margin-bottom: 20px;" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                     <asp:ListItem Value="12:00">12:00</asp:ListItem>
                     <asp:ListItem Value="13:00">13:00</asp:ListItem>
                     <asp:ListItem Value="14:00">14:00</asp:ListItem>
                     <asp:ListItem Value="15:00">15:00</asp:ListItem>
                     <asp:ListItem Value="16:00">16:00</asp:ListItem>
                    <asp:ListItem Value="17:00">17:00 </asp:ListItem>
    
                </asp:DropDownList>
                
                <asp:Label ID="lblEndTimeError" runat="server" ForeColor="White"></asp:Label>
            </div>

            <!-- Code type field (read-only) -->
            <div class="form-group">
                <label for="codeType">Code Type</label>
                <asp:TextBox ID="txtCodeType" runat="server" TextMode="SingleLine"  
                             style="width: 100%; padding: 10px; margin-bottom: 20px;" 
                             ReadOnly="true" OnTextChanged="txtCodeType_TextChanged"></asp:TextBox>
            </div>

            <!-- Instructor dropdown -->
            <div class="form-group">
                <label for="instructor">Select Instructor</label>
                <asp:DropDownList ID="instructorDropDownList" runat="server" CssClass="form-control" style="width: 100%; padding: 10px; margin-bottom: 20px;" DataSourceID="SqlDataSource1" DataTextField="Employee_Name" DataValueField="EmployeeID" AutoPostBack="True" OnSelectedIndexChanged="instructorDropDownList_SelectedIndexChanged">
                </asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:DefaultConnection %>" SelectCommand="SELECT * 
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
  );">
                    <SelectParameters>
                        <asp:ControlParameter ControlID="txtCodeType" Name="Code_Type" PropertyName="Text" Type="Int32" />
                        <asp:Parameter DefaultValue="Instructor" Name="Employee_Type" Type="String" />
                        <asp:ControlParameter ControlID="bookingDate" Name="Booking_Date" PropertyName="Text" />
                        <asp:ControlParameter ControlID="DropDownList1" Name="Booking_EndTime" PropertyName="SelectedValue" />
                        <asp:ControlParameter ControlID="TimeSlotDropDown" Name="Booking_StartTime" PropertyName="SelectedValue" />
                    </SelectParameters>
                </asp:SqlDataSource>
            </div>

            <div class="form-group">
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource2" Width="809px">
                    <Columns>
                        <asp:BoundField DataField="Employee_Surname" HeaderText="Employee_Surname" SortExpression="Employee_Surname" />
                        <asp:BoundField DataField="Employee_Name" HeaderText="Employee_Name" SortExpression="Employee_Name" />
                        <asp:BoundField DataField="Employee_Age" HeaderText="Employee_Age" SortExpression="Employee_Age" />
                        <asp:BoundField DataField="Employee_Gender" HeaderText="Employee_Gender" SortExpression="Employee_Gender" />
                        <asp:BoundField DataField="Employee_Race" HeaderText="Employee_Race" SortExpression="Employee_Race" />
                    </Columns>
                </asp:GridView>
                <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:DefaultConnection %>" SelectCommand="SELECT [Employee_Surname], [Employee_Name], [Employee_Age], [Employee_Gender], [Employee_Race] FROM [tblEmployee] WHERE ([EmployeeID] = @EmployeeID)">
                    <SelectParameters>
                        <asp:ControlParameter ControlID="instructorDropDownList" Name="EmployeeID" PropertyName="SelectedValue" Type="Int32" />
                    </SelectParameters>
                </asp:SqlDataSource>
            </div>

            <!-- Vehicle dropdown -->
            <div class="form-group">
                <label for="vehicle">Select Vehicle</label>
                <asp:DropDownList ID="vehicleDropDownList" runat="server" CssClass="form-control" style="width: 100%; padding: 10px; margin-bottom: 20px;" DataSourceID="SqlDataSource3" DataTextField="Vehicle_Model" DataValueField="VehicleID">
                    <asp:ListItem Text="" Value="" />
                </asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:DefaultConnection %>" SelectCommand="SELECT * 
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
 );">
                    <SelectParameters>
                        <asp:Parameter DefaultValue="Available" Name="Vehicle_Status" />
                        <asp:Parameter Name="Vehicle_Size" />
                        <asp:ControlParameter ControlID="bookingDate" DefaultValue="" Name="Booking_Date" PropertyName="Text" />
                        <asp:ControlParameter ControlID="DropDownList1" Name="Booking_EndTime" PropertyName="SelectedValue" />
                        <asp:ControlParameter ControlID="TimeSlotDropDown" Name="Booking_StartTime" PropertyName="SelectedValue" />
                    </SelectParameters>
                </asp:SqlDataSource>
            </div>

            <!-- Booking cost (read-only) -->
            <div class="form-group">
                <label for="bookingCost">Booking Cost</label>
                <asp:TextBox ID="bookingCost" runat="server" TextMode="SingleLine" 
                             style="width: 100%; padding: 10px; margin-bottom: 20px;" 
                             ReadOnly="true" Text="R0.00"></asp:TextBox>
            </div>

            <!-- Submit button -->
            <asp:Button ID="submitButton" runat="server" Text="Submit" CssClass="submit-button" 
                      OnClick="SubmitButton_Click"  OnClientClick ="return ConfirmMessage()"
                        style="width: 100%; padding: 15px; background-color: #4CAF50; color: #fff; border: none; cursor: pointer;" />
      
          <script>
              function ConfirmMessage() {
                  if (confirm("Confirm Booking?"))
                      return true;
                  else
                      return false;
              }
          </script>
<asp:SqlDataSource ID="sqlDSInsert" runat="server" ConflictDetection="CompareAllValues" ConnectionString="<%$ ConnectionStrings:DefaultConnection %>" DeleteCommand="DELETE FROM [tblBooking] WHERE [BookingID] = @original_BookingID AND [Booking_Date] = @original_Booking_Date AND [Booking_StartTime] = @original_Booking_StartTime AND [Booking_EndTime] = @original_Booking_EndTime AND [Booking_Status] = @original_Booking_Status AND [Booking_TotalCost] = @original_Booking_TotalCost AND [Booking_FeeDue] = @original_Booking_FeeDue AND [LearnerID] = @original_LearnerID AND [Code_Type] = @original_Code_Type AND [VehicleID] = @original_VehicleID AND [EmployeeID] = @original_EmployeeID" InsertCommand="INSERT INTO [tblBooking] ([Booking_Date], [Booking_StartTime], [Booking_EndTime], [Booking_Status], [Booking_TotalCost], [Booking_FeeDue], [LearnerID], [Code_Type], [VehicleID], [EmployeeID]) VALUES (@Booking_Date, @Booking_StartTime, @Booking_EndTime, @Booking_Status, @Booking_TotalCost, @Booking_FeeDue, @LearnerID, @Code_Type, @VehicleID, @EmployeeID)" OldValuesParameterFormatString="original_{0}" SelectCommand="SELECT * FROM [tblBooking]" UpdateCommand="UPDATE [tblBooking] SET [Booking_Date] = @Booking_Date, [Booking_StartTime] = @Booking_StartTime, [Booking_EndTime] = @Booking_EndTime, [Booking_Status] = @Booking_Status, [Booking_TotalCost] = @Booking_TotalCost, [Booking_FeeDue] = @Booking_FeeDue, [LearnerID] = @LearnerID, [Code_Type] = @Code_Type, [VehicleID] = @VehicleID, [EmployeeID] = @EmployeeID WHERE [BookingID] = @original_BookingID AND [Booking_Date] = @original_Booking_Date AND [Booking_StartTime] = @original_Booking_StartTime AND [Booking_EndTime] = @original_Booking_EndTime AND [Booking_Status] = @original_Booking_Status AND [Booking_TotalCost] = @original_Booking_TotalCost AND [Booking_FeeDue] = @original_Booking_FeeDue AND [LearnerID] = @original_LearnerID AND [Code_Type] = @original_Code_Type AND [VehicleID] = @original_VehicleID AND [EmployeeID] = @original_EmployeeID">
    <DeleteParameters>
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
    </DeleteParameters>
    <InsertParameters>
        <asp:ControlParameter ControlID="bookingDate" DbType="Date" Name="Booking_Date" PropertyName="Text" />
        <asp:Parameter DbType="Time" Name="Booking_StartTime" />
        <asp:Parameter Name="Booking_EndTime" DbType="Time" />
        <asp:Parameter DefaultValue="Incomplete" Name="Booking_Status" Type="String" />
        <asp:Parameter Name="Booking_TotalCost" Type="Decimal" DefaultValue="" />
        <asp:Parameter Name="Booking_FeeDue" Type="Decimal" />
        <asp:Parameter Name="LearnerID" Type="String" />
        <asp:ControlParameter ControlID="txtCodeType" Name="Code_Type" PropertyName="Text" Type="Int32" />
        <asp:ControlParameter ControlID="vehicleDropDownList" Name="VehicleID" PropertyName="SelectedValue" Type="Int32" />
        <asp:ControlParameter ControlID="instructorDropDownList" Name="EmployeeID" PropertyName="SelectedValue" Type="Int32" />
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

    <style>
        /* Form element styling */
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
    </style>


</asp:Content>
