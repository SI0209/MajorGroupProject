<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ClientPage.aspx.cs" Inherits="DrivingSchoolWebsite.Client.ClientPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <section style="padding: 50px; background-color: #333; color: #000;">
        <div class="form-container" style="max-width: 500px; margin: auto; padding: 20px; background-color: rgba(249, 249, 249, 0.9); border-radius: 8px; box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);">
            <h2 style="text-align: center; margin-bottom: 20px; color: #000;"><%: Title %></h2>
            <p class="text-danger">
                <asp:Literal runat="server" ID="ErrorMessage" />
            </p>
            <h4 style="color: #000;">Update your profile</h4>
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
            <asp:Button ID="btnUpdateProfile" runat="server" Text="Update Profile" CssClass="btn" style="width: 100%; padding: 10px; margin-top: 20px;" OnClientClick="return ConfirmMessage()" OnClick="btnUpdateProfile_Click" BackColor="Lime" />
            <script>
                function ConfirmMessage() {
                    if (confirm("Confirm Update"))
                        return true;
                    else
                        return false;
                }
            </script>
            <asp:SqlDataSource ID="SqlDSUpdateProfile" runat="server" ConnectionString="<%$ ConnectionStrings:DefaultConnection %>" DeleteCommand="DELETE FROM [AspNetUsers] WHERE [Id] = @original_Id AND (([Email] = @original_Email) OR ([Email] IS NULL AND @original_Email IS NULL)) AND [EmailConfirmed] = @original_EmailConfirmed AND (([PasswordHash] = @original_PasswordHash) OR ([PasswordHash] IS NULL AND @original_PasswordHash IS NULL)) AND (([SecurityStamp] = @original_SecurityStamp) OR ([SecurityStamp] IS NULL AND @original_SecurityStamp IS NULL)) AND (([PhoneNumber] = @original_PhoneNumber) OR ([PhoneNumber] IS NULL AND @original_PhoneNumber IS NULL)) AND [PhoneNumberConfirmed] = @original_PhoneNumberConfirmed AND [TwoFactorEnabled] = @original_TwoFactorEnabled AND (([LockoutEndDateUtc] = @original_LockoutEndDateUtc) OR ([LockoutEndDateUtc] IS NULL AND @original_LockoutEndDateUtc IS NULL)) AND [LockoutEnabled] = @original_LockoutEnabled AND [AccessFailedCount] = @original_AccessFailedCount AND [UserName] = @original_UserName AND (([FirstName] = @original_FirstName) OR ([FirstName] IS NULL AND @original_FirstName IS NULL)) AND (([LastName] = @original_LastName) OR ([LastName] IS NULL AND @original_LastName IS NULL)) AND (([IDNumber] = @original_IDNumber) OR ([IDNumber] IS NULL AND @original_IDNumber IS NULL)) AND (([StreetAddress] = @original_StreetAddress) OR ([StreetAddress] IS NULL AND @original_StreetAddress IS NULL)) AND (([Suburb] = @original_Suburb) OR ([Suburb] IS NULL AND @original_Suburb IS NULL)) AND (([Race] = @original_Race) OR ([Race] IS NULL AND @original_Race IS NULL)) AND (([Gender] = @original_Gender) OR ([Gender] IS NULL AND @original_Gender IS NULL)) AND [Age] = @original_Age AND (([LessonCode] = @original_LessonCode) OR ([LessonCode] IS NULL AND @original_LessonCode IS NULL)) AND (([LearnerLicenseIssueDate] = @original_LearnerLicenseIssueDate) OR ([LearnerLicenseIssueDate] IS NULL AND @original_LearnerLicenseIssueDate IS NULL)) AND (([LearnerLicenseExpiryDate] = @original_LearnerLicenseExpiryDate) OR ([LearnerLicenseExpiryDate] IS NULL AND @original_LearnerLicenseExpiryDate IS NULL))" InsertCommand="INSERT INTO [AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName], [FirstName], [LastName], [IDNumber], [StreetAddress], [Suburb], [Race], [Gender], [Age], [LessonCode], [LearnerLicenseIssueDate], [LearnerLicenseExpiryDate]) VALUES (@Id, @Email, @EmailConfirmed, @PasswordHash, @SecurityStamp, @PhoneNumber, @PhoneNumberConfirmed, @TwoFactorEnabled, @LockoutEndDateUtc, @LockoutEnabled, @AccessFailedCount, @UserName, @FirstName, @LastName, @IDNumber, @StreetAddress, @Suburb, @Race, @Gender, @Age, @LessonCode, @LearnerLicenseIssueDate, @LearnerLicenseExpiryDate)" OldValuesParameterFormatString="original_{0}" SelectCommand="SELECT * FROM [AspNetUsers]" UpdateCommand="UPDATE AspNetUsers SET PhoneNumber = @PhoneNumber, FirstName = @FirstName, LastName = @LastName, StreetAddress = @StreetAddress, Suburb = @Suburb WHERE (Email = @Email)">
                <DeleteParameters>
                    <asp:Parameter Name="original_Id" Type="String" />
                    <asp:Parameter Name="original_Email" Type="String" />
                    <asp:Parameter Name="original_EmailConfirmed" Type="Boolean" />
                    <asp:Parameter Name="original_PasswordHash" Type="String" />
                    <asp:Parameter Name="original_SecurityStamp" Type="String" />
                    <asp:Parameter Name="original_PhoneNumber" Type="String" />
                    <asp:Parameter Name="original_PhoneNumberConfirmed" Type="Boolean" />
                    <asp:Parameter Name="original_TwoFactorEnabled" Type="Boolean" />
                    <asp:Parameter Name="original_LockoutEndDateUtc" Type="DateTime" />
                    <asp:Parameter Name="original_LockoutEnabled" Type="Boolean" />
                    <asp:Parameter Name="original_AccessFailedCount" Type="Int32" />
                    <asp:Parameter Name="original_UserName" Type="String" />
                    <asp:Parameter Name="original_FirstName" Type="String" />
                    <asp:Parameter Name="original_LastName" Type="String" />
                    <asp:Parameter Name="original_IDNumber" Type="String" />
                    <asp:Parameter Name="original_StreetAddress" Type="String" />
                    <asp:Parameter Name="original_Suburb" Type="String" />
                    <asp:Parameter Name="original_Race" Type="String" />
                    <asp:Parameter Name="original_Gender" Type="String" />
                    <asp:Parameter Name="original_Age" Type="Int32" />
                    <asp:Parameter Name="original_LessonCode" Type="String" />
                    <asp:Parameter Name="original_LearnerLicenseIssueDate" Type="DateTime" />
                    <asp:Parameter Name="original_LearnerLicenseExpiryDate" Type="DateTime" />
                </DeleteParameters>
                <InsertParameters>
                    <asp:Parameter Name="Id" Type="String" />
                    <asp:Parameter Name="Email" Type="String" />
                    <asp:Parameter Name="EmailConfirmed" Type="Boolean" />
                    <asp:Parameter Name="PasswordHash" Type="String" />
                    <asp:Parameter Name="SecurityStamp" Type="String" />
                    <asp:Parameter Name="PhoneNumber" Type="String" />
                    <asp:Parameter Name="PhoneNumberConfirmed" Type="Boolean" />
                    <asp:Parameter Name="TwoFactorEnabled" Type="Boolean" />
                    <asp:Parameter Name="LockoutEndDateUtc" Type="DateTime" />
                    <asp:Parameter Name="LockoutEnabled" Type="Boolean" />
                    <asp:Parameter Name="AccessFailedCount" Type="Int32" />
                    <asp:Parameter Name="UserName" Type="String" />
                    <asp:Parameter Name="FirstName" Type="String" />
                    <asp:Parameter Name="LastName" Type="String" />
                    <asp:Parameter Name="IDNumber" Type="String" />
                    <asp:Parameter Name="StreetAddress" Type="String" />
                    <asp:Parameter Name="Suburb" Type="String" />
                    <asp:Parameter Name="Race" Type="String" />
                    <asp:Parameter Name="Gender" Type="String" />
                    <asp:Parameter Name="Age" Type="Int32" />
                    <asp:Parameter Name="LessonCode" Type="String" />
                    <asp:Parameter Name="LearnerLicenseIssueDate" Type="DateTime" />
                    <asp:Parameter Name="LearnerLicenseExpiryDate" Type="DateTime" />
                </InsertParameters>
                <UpdateParameters>
                    <asp:ControlParameter ControlID="PhoneNumber" Name="PhoneNumber" PropertyName="Text" />
                    <asp:ControlParameter ControlID="FirstName" Name="FirstName" PropertyName="Text" />
                    <asp:ControlParameter ControlID="LastName" Name="LastName" PropertyName="Text" />
                    <asp:ControlParameter ControlID="StreetAddress" Name="StreetAddress" PropertyName="Text" />
                    <asp:ControlParameter ControlID="Suburb" Name="Suburb" PropertyName="Text" />
                    <asp:Parameter Name="Email" />
                </UpdateParameters>
            </asp:SqlDataSource>
        </div>
    </section>
</asp:Content>
