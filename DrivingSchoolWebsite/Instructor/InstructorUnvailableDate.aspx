<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="InstructorUnvailableDate.aspx.cs" Inherits="DrivingSchoolWebsite.Instructor.InstructorUnvailableDate" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <section style="padding: 50px; background-color: #333; color: #fff;">
      <h2 style="text-align: center; margin-bottom: 40px;">Mark Unavailable Slot</h2>

      <div style="max-width: 800px; margin: auto;">
          <!-- Start Date TextBox -->
          <asp:TextBox ID="startDate" runat="server" TextMode="Date" Placeholder="Start Date" style="width: 100%; padding: 10px; margin-bottom: 20px;"></asp:TextBox>
          
          <!-- End Date TextBox -->
          <asp:TextBox ID="endDate" runat="server" TextMode="Date" Placeholder="End Date" style="width: 100%; padding: 10px; margin-bottom: 20px;"></asp:TextBox>
          
          <!-- Start Time TextBox -->
          <asp:TextBox ID="startTime" runat="server" TextMode="Time" Placeholder="Start Time" style="width: 100%; padding: 10px; margin-bottom: 20px;"></asp:TextBox>
          
          <!-- End Time TextBox -->
          <asp:TextBox ID="endTime" runat="server" TextMode="Time" Placeholder="End Time" style="width: 100%; padding: 10px; margin-bottom: 20px;"></asp:TextBox>
          
          <!-- Reason TextBox -->
          <asp:TextBox ID="reason" runat="server" TextMode="MultiLine" Rows="4" Placeholder="Reason" style="width: 100%; padding: 10px; margin-bottom: 20px;"></asp:TextBox>
          
          <!-- Submit Button -->
          <asp:Button ID="submitButton" runat="server" Text="Submit" CssClass="btn-submit" OnClick="SubmitButton_Click"
                      style="width: 100%; padding: 15px; background-color: #3498db; color: #fff; border: none; cursor: pointer;" />
      </div>
  </section>
</asp:Content>
