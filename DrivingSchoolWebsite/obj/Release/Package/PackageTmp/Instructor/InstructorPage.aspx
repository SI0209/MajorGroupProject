<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="InstructorPage.aspx.cs" Inherits="DrivingSchoolWebsite.Instructor.InstructorPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <section style="padding: 50px; background-color: #333; color: #000;">
     <div class="form-container" style="max-width: 500px; margin: auto; padding: 20px; background-color: rgba(249, 249, 249, 0.9); border-radius: 8px; box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);">
         <h2 style="text-align: center; margin-bottom: 20px; color: #000;"><%: Title %></h2>
         <p class="text-danger">
             <asp:Literal runat="server" ID="ErrorMessage" />
         </p>
         <h4 style="color: #000;">Update Admin Profile</h4>
         <hr />
         <asp:ValidationSummary runat="server" CssClass="text-danger" />

         <!-- First Name -->
         <div style="display: flex; flex-direction: column; margin-bottom: 15px;">
             <label for="FirstName" style="color: #000;">First Name</label>
             <asp:TextBox ID="FirstName" runat="server" CssClass="form-control"></asp:TextBox>
             <asp:RequiredFieldValidator ControlToValidate="FirstName" runat="server" 
                 ErrorMessage="First Name is required" CssClass="text-danger"></asp:RequiredFieldValidator>
         </div>

         <!-- Last Name -->
         <div style="display: flex; flex-direction: column; margin-bottom: 15px;">
             <label for="LastName" style="color: #000;">Last Name</label>
             <asp:TextBox ID="LastName" runat="server" CssClass="form-control"></asp:TextBox>
             <asp:RequiredFieldValidator ControlToValidate="LastName" runat="server" 
                 ErrorMessage="Last Name is required" CssClass="text-danger"></asp:RequiredFieldValidator>
         </div>

         <!-- Phone Number -->
         <div style="display: flex; flex-direction: column; margin-bottom: 15px;">
             <label for="PhoneNumber" style="color: #000;">Phone Number</label>
             <asp:TextBox ID="PhoneNumber" runat="server" CssClass="form-control"></asp:TextBox>
             <asp:RequiredFieldValidator ControlToValidate="PhoneNumber" runat="server" 
                 ErrorMessage="Phone Number is required" CssClass="text-danger"></asp:RequiredFieldValidator>
         </div>

         <!-- Street Address -->
         <div style="display: flex; flex-direction: column; margin-bottom: 15px;">
             <label for="StreetAddress" style="color: #000;">Street Address</label>
             <asp:TextBox ID="StreetAddress" runat="server" CssClass="form-control"></asp:TextBox>
             <asp:RequiredFieldValidator ControlToValidate="StreetAddress" runat="server" 
                 ErrorMessage="Street Address is required" CssClass="text-danger"></asp:RequiredFieldValidator>
         </div>

         <!-- Suburb -->
         <div style="display: flex; flex-direction: column; margin-bottom: 15px;">
             <label for="Suburb" style="color: #000;">Suburb</label>
             <asp:TextBox ID="Suburb" runat="server" CssClass="form-control"></asp:TextBox>
             <asp:RequiredFieldValidator ControlToValidate="Suburb" runat="server" 
                 ErrorMessage="Suburb is required" CssClass="text-danger"></asp:RequiredFieldValidator>
         </div>

        

         <!-- Submit button -->
         <asp:Button ID="btnUpdateProfile" runat="server" Text="Update Profile" CssClass="btn" style="width: 100%; padding: 10px; margin-top: 20px;" OnClick="btnUpdateProfile_Click" BackColor="Lime" />
         <asp:SqlDataSource ID="sqldsUpdateInstructor" runat="server"></asp:SqlDataSource>
     </div>
 </section>
</asp:Content>
