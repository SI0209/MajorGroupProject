<%@ Page Title="Log in" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="DrivingSchoolWebsite.Account.Login" Async="true" %>

<%@ Register Src="~/Account/OpenAuthProviders.ascx" TagPrefix="uc" TagName="OpenAuthProviders" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <style>
        body {
            background-color: #000; /* Black background */
            color: #fff; /* White text for readability */
        }
        #loginForm {
            background-color: #1a1a1a; /* Dark grey background for form */
            padding: 20px;
            border-radius: 8px;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.5);
        }
        h2, h4 {
            color: #fff; /* White text for headings */
        }
        .form-control {
            background-color: #333; /* Dark grey for input fields */
            color: #fff; /* White text for input fields */
            border: 1px solid #555; /* Border for input fields */
        }
        .form-control:focus {
            background-color: #444; /* Slightly lighter grey on focus */
            border-color: #777; /* Lighter border on focus */
            color: #fff; /* Ensure text remains white on focus */
        }
        .btn-outline-dark {
            background-color: #fff; /* White background for button */
            color: #000; /* Black text for button */
            border: 2px solid #fff; /* White border */
            transition: background-color 0.3s, color 0.3s; /* Smooth transition */
        }
        .btn-outline-dark:hover {
            background-color: #f0f0f0; /* Light grey on hover */
            color: #000; /* Black text on hover */
        }
        .checkbox label {
            color: #fff; /* White text for checkbox label */
        }
        a {
            color: #1e90ff; /* Dodger blue for links */
        }
        a:hover {
            color: #63a4ff; /* Lighter blue on hover */
        }
        .form-check-inline {
            display: flex;
            align-items: center;
            justify-content: space-between;
            margin-bottom: 15px;
        }
        .form-check-inline .form-check-label {
            margin-left: 5px;
        }
    </style>

    <script type="text/javascript">
        function togglePasswordVisibility() {
            var passwordField = document.getElementById('<%= Password.ClientID %>');
            if (passwordField.type === "password") {
                passwordField.type = "text";
            } else {
                passwordField.type = "password";
            }
        }

        function clearFields() {
            document.getElementById('<%= Email.ClientID %>').value = '';
            document.getElementById('<%= Password.ClientID %>').value = '';
        }
    </script>

    <main aria-labelledby="title" class="container mt-5">
        <h2 id="title" class="text-center mb-4"><%: Title %></h2>
        <div class="row justify-content-center">
            <div class="col-md-6">
                <section id="loginForm">
                    <h4 class="text-center">Use a local account to log in</h4>
                    <hr />
                    <asp:PlaceHolder runat="server" ID="ErrorMessage" Visible="false">
                        <p class="text-danger text-center">
                            <asp:Literal runat="server" ID="FailureText" />
                        </p>
                    </asp:PlaceHolder>
                    <div class="form-group">
                        <asp:Label runat="server" AssociatedControlID="Email" CssClass="col-form-label">Email</asp:Label>
                        <asp:TextBox runat="server" ID="Email" CssClass="form-control" TextMode="Email" />
                        <asp:RequiredFieldValidator runat="server" ControlToValidate="Email"
                            CssClass="text-danger" ErrorMessage="The email field is required." />
                    </div>
                    <div class="form-group">
                        <asp:Label runat="server" AssociatedControlID="Password" CssClass="col-form-label">Password</asp:Label>
                        <asp:TextBox runat="server" ID="Password" TextMode="Password" CssClass="form-control" />
                        <asp:RequiredFieldValidator runat="server" ControlToValidate="Password" CssClass="text-danger" ErrorMessage="The password field is required." />
                    </div>
                    <div class="form-check-inline">
                        <div class="form-check">
                            <input type="checkbox" id="showPassword" onclick="togglePasswordVisibility()" class="form-check-input" />
                            <label for="showPassword" class="form-check-label">Show Password</label>
                        </div>
                        <div class="form-check">
                            <asp:CheckBox runat="server" ID="RememberMe" CssClass="form-check-input" />
                            <asp:Label runat="server" AssociatedControlID="RememberMe" CssClass="form-check-label">Remember me?</asp:Label>
                        </div>
                    </div>
                    <div class="form-group text-center">
                        <asp:Button runat="server" OnClick="LogIn" Text="Log in" CssClass="btn btn-outline-dark btn-lg" />
                        <button type="button" onclick="clearFields()" class="btn btn-outline-dark btn-lg">Clear</button>
                    </div>
                    <div class="text-center">
                        <asp:HyperLink runat="server" ID="RegisterHyperLink" ViewStateMode="Disabled">Register as a new user</asp:HyperLink>
                        <br />
                        <asp:HyperLink runat="server" ID="ForgotPasswordHyperLink" ViewStateMode="Disabled">Forgot your password?</asp:HyperLink>
                    </div>
                </section>
            </div>
        </div>

        <div class="row justify-content-center mt-4">
            <div class="col-md-6">
                <section id="socialLoginForm" class="text-center">
                    <uc:OpenAuthProviders runat="server" ID="OpenAuthLogin" />
                </section>
            </div>
        </div>
    </main>
</asp:Content>