<%@ Page Title="Register" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="wyebankwebsite.Account.Register" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <div style="display: flex; justify-content: center; align-items: center; height: 100vh; background-color: #000;">
        <div style="width: 400px; padding: 20px; border-radius: 10px; background-color: #1a1a1a; color: #fff; box-shadow: 0 0 10px rgba(0, 0, 0, 0.5);">
            <div style="max-height: 80vh; overflow-y: auto;"> <!-- Scrollable container -->
                <main aria-labelledby="title">
                    <h2 id="title" style="color: #fff;"><%: Title %></h2>
                    <p class="text-danger">
                        <asp:Literal runat="server" ID="ErrorMessage" />
                    </p>
                    <h4 style="color: #fff;">Create a new account</h4>
                    <hr style="border-color: #444;" />
                    <asp:ValidationSummary runat="server" CssClass="text-danger" />

                    <!-- First Name -->
                    <div class="form-group">
                        <label for="FirstName" style="color: #fff;">First Name</label>
                        <asp:TextBox ID="FirstName" runat="server" CssClass="form-control"></asp:TextBox>
                        <asp:RequiredFieldValidator ControlToValidate="FirstName" runat="server" 
                            ErrorMessage="First Name is required" CssClass="text-danger"></asp:RequiredFieldValidator>
                    </div>

                    <!-- Last Name -->
                    <div class="form-group">
                        <label for="LastName" style="color: #fff;">Last Name</label>
                        <asp:TextBox ID="LastName" runat="server" CssClass="form-control"></asp:TextBox>
                        <asp:RequiredFieldValidator ControlToValidate="LastName" runat="server" 
                            ErrorMessage="Last Name is required" CssClass="text-danger"></asp:RequiredFieldValidator>
                    </div>

                    <!-- ID Number -->
                    <div class="form-group">
                        <label for="IDNumber" style="color: #fff;">ID Number</label>
                        <asp:TextBox ID="IDNumber" runat="server" CssClass="form-control" onkeyup="calculateAgeAndGender()"></asp:TextBox>
                        <asp:RequiredFieldValidator ControlToValidate="IDNumber" runat="server" 
                            ErrorMessage="ID Number is required" CssClass="text-danger"></asp:RequiredFieldValidator>
                    </div>

                    <!-- Phone Number -->
                    <div class="form-group">
                        <label for="PhoneNumber" style="color: #fff;">Phone Number</label>
                        <asp:TextBox ID="PhoneNumber" runat="server" CssClass="form-control"></asp:TextBox>
                        <asp:RequiredFieldValidator ControlToValidate="PhoneNumber" runat="server" 
                            ErrorMessage="Phone Number is required" CssClass="text-danger"></asp:RequiredFieldValidator>
                    </div>

                    <!-- Street Address -->
                    <div class="form-group">
                        <label for="StreetAddress" style="color: #fff;">Street Address</label>
                        <asp:TextBox ID="StreetAddress" runat="server" CssClass="form-control"></asp:TextBox>
                        <asp:RequiredFieldValidator ControlToValidate="StreetAddress" runat="server" 
                            ErrorMessage="Street Address is required" CssClass="text-danger"></asp:RequiredFieldValidator>
                    </div>

                    <!-- Suburb -->
                    <div class="form-group">
                        <label for="Suburb" style="color: #fff;">Suburb</label>
                        <asp:TextBox ID="Suburb" runat="server" CssClass="form-control"></asp:TextBox>
                        <asp:RequiredFieldValidator ControlToValidate="Suburb" runat="server" 
                            ErrorMessage="Suburb is required" CssClass="text-danger"></asp:RequiredFieldValidator>
                    </div>

                    <!-- Race DropDownList -->
                    <div class="form-group">
                        <label for="Race" style="color: #fff;">Race</label>
                        <asp:DropDownList ID="Race" runat="server" CssClass="form-control">
                            <asp:ListItem Value="">Select Race</asp:ListItem>
                            <asp:ListItem Value="Black">Black</asp:ListItem>
                            <asp:ListItem Value="White">White</asp:ListItem>
                            <asp:ListItem Value="Indian">Indian</asp:ListItem>
                            <asp:ListItem Value="Coloured">Coloured</asp:ListItem>
                        </asp:DropDownList>
                        <asp:RequiredFieldValidator ControlToValidate="Race" runat="server" 
                            ErrorMessage="Race is required" CssClass="text-danger"></asp:RequiredFieldValidator>
                    </div>

                    <!-- Gender (Automatically filled from ID) -->
                    <div class="form-group">
                        <label for="Gender" style="color: #fff;">Gender</label>
                        <asp:TextBox ID="Gender" runat="server" CssClass="form-control" ReadOnly="true"></asp:TextBox>
                    </div>

                    <!-- Derived Age (Automatically filled from ID) -->
                    <div class="form-group">
                        <label for="Age" style="color: #fff;">Age (Derived from ID Number)</label>
                        <asp:TextBox ID="Age" runat="server" CssClass="form-control" ReadOnly="true"></asp:TextBox>
                    </div>

                    <!-- Lesson Code DropDownList -->
                    <div class="form-group">
                        <label for="LessonCode" style="color: #fff;">Lesson Code</label>
                        <asp:DropDownList ID="LessonCode" runat="server" CssClass="form-control">
                            <asp:ListItem Value="">Select Lesson Code</asp:ListItem>
                            <asp:ListItem Value="Code1">Code 8</asp:ListItem>
                            <asp:ListItem Value="Code2">Code 10</asp:ListItem>
                            <asp:ListItem Value="Code3">Code 14</asp:ListItem>
                        </asp:DropDownList>
                        <asp:RequiredFieldValidator ControlToValidate="LessonCode" runat="server" 
                            ErrorMessage="Lesson Code is required" CssClass="text-danger"></asp:RequiredFieldValidator>
                    </div>

                    <!-- Learner License Issue Date -->
                    <div class="form-group">
                        <label for="LearnerLicenseIssueDate" style="color: #fff;">Learner License Issue Date</label>
                        <asp:TextBox ID="LearnerLicenseIssueDate" runat="server" CssClass="form-control" TextMode="Date" OnChange="validateIssueDate()"></asp:TextBox>
                        <asp:RequiredFieldValidator ControlToValidate="LearnerLicenseIssueDate" runat="server" 
                            ErrorMessage="Learner License Issue Date is required" CssClass="text-danger"></asp:RequiredFieldValidator>
                    </div>

                    <!-- Learner License Expiry Date -->
                    <div class="form-group">
                        <label for="LearnerLicenseExpiryDate" style="color: #fff;">Learner License Expiry Date</label>
                        <asp:TextBox ID="LearnerLicenseExpiryDate" runat="server" CssClass="form-control" TextMode="Date" ReadOnly="true"></asp:TextBox>
                    </div>

                    <!-- Email Field -->
                    <div class="form-group">
                        <label for="Email" style="color: #fff;">Email Address</label>
                        <asp:TextBox ID="Email" runat="server" CssClass="form-control"></asp:TextBox>
                        <asp:RequiredFieldValidator ControlToValidate="Email" runat="server" 
                            ErrorMessage="Email is required" CssClass="text-danger"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ControlToValidate="Email" runat="server" 
                            ErrorMessage="Invalid email format" CssClass="text-danger" 
                            ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                    </div>

                    <!-- Password Field -->
                    <div class="form-group">
                        <label for="Password" style="color: #fff;">Password</label>
                        <div class="input-group">
                            <asp:TextBox runat="server" ID="Password" TextMode="Password" CssClass="form-control" ClientIDMode="Static" />
                            <div class="input-group-append">
                                <button type="button" class="btn btn-outline-secondary" onclick="togglePasswordVisibility('Password')" tabindex="-1">
                                    <i class="fa fa-eye" id="eyePassword"></i>
                                </button>
                            </div>
                        </div>
                        <asp:RequiredFieldValidator runat="server" ControlToValidate="Password"
                            CssClass="text-danger" ErrorMessage="The password field is required." />
                    </div>

                    <!-- Confirm Password Field -->
                    <div class="form-group">
                        <label for="ConfirmPassword" style="color: #fff;">Confirm password</label>
                        <div class="input-group">
                            <asp:TextBox runat="server" ID="ConfirmPassword" TextMode="Password" CssClass="form-control" ClientIDMode="Static" />
                            <div class="input-group-append">
                                <button type="button" class="btn btn-outline-secondary" onclick="togglePasswordVisibility('ConfirmPassword')" tabindex="-1">
                                    <i class="fa fa-eye" id="eyeConfirmPassword"></i>
                                </button>
                            </div>
                        </div>
                        <asp:RequiredFieldValidator runat="server" ControlToValidate="ConfirmPassword"
                            CssClass="text-danger" Display="Dynamic" ErrorMessage="The confirm password field is required." />
                        <asp:CompareValidator runat="server" ControlToCompare="Password" ControlToValidate="ConfirmPassword"
                            CssClass="text-danger" Display="Dynamic" ErrorMessage="The password and confirmation password do not match." />
                    </div>

                    <!-- Register Button -->
                    <div class="form-group">
                        <asp:Button runat="server" OnClick="CreateUser_Click" Text="Register" CssClass="btn btn-outline-light" />
                    </div>
                </main>
            </div> <!-- End of scrollable container -->
        </div>
    </div>

    <!-- Add Font Awesome CSS -->
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.15.4/css/all.min.css">

    <script>
        function calculateAgeAndGender() {
            var idNumber = document.getElementById('<%= IDNumber.ClientID %>').value;
            var ageField = document.getElementById('<%= Age.ClientID %>');
            var genderField = document.getElementById('<%= Gender.ClientID %>');

            if (idNumber.length === 13) {
                // Extract birthdate from ID number
                var birthYear = idNumber.substring(0, 2);
                var birthMonth = idNumber.substring(2, 4);
                var birthDay = idNumber.substring(4, 6);

                // Adjust for century (assuming 1900s for now)
                var currentYear = new Date().getFullYear();
                birthYear = (birthYear <= (currentYear % 100)) ? "20" + birthYear : "19" + birthYear;

                // Calculate age
                var birthDate = new Date(birthYear, birthMonth - 1, birthDay);
                var age = new Date().getFullYear() - birthDate.getFullYear();
                var m = new Date().getMonth() - birthDate.getMonth();
                if (m < 0 || (m === 0 && new Date().getDate() < birthDate.getDate())) {
                    age--;
                }

                // Set the age in the field
                ageField.value = age;

                // Extract gender from the 7th digit of the ID number
                var genderDigit = idNumber.charAt(6);
                var gender = (genderDigit >= 5) ? "Male" : "Female";

                // Set the gender in the field
                genderField.value = gender;
            }
        }

        function validateIssueDate() {
            var issueDateField = document.getElementById('<%= LearnerLicenseIssueDate.ClientID %>');
            var expiryDateField = document.getElementById('<%= LearnerLicenseExpiryDate.ClientID %>');
            var today = new Date();
            var issueDate = new Date(issueDateField.value);

            // Calculate the two-year-old date limit
            var twoYearsAgo = new Date();
            twoYearsAgo.setFullYear(today.getFullYear() - 2);

            // Check if the issue date is valid
            if (issueDate < twoYearsAgo) {
                alert("The Learner License Issue Date cannot be older than 2 years.");
                issueDateField.value = ""; // Clear the field
                expiryDateField.value = ""; // Clear expiry date if issue date is invalid
                return;
            }

            // Check if the issue date is in the future
            if (issueDate > today) {
                alert("The Learner License Issue Date cannot be in the future.");
                issueDateField.value = ""; // Clear the field
                expiryDateField.value = ""; // Clear expiry date if issue date is invalid
                return;
            }

            // Calculate expiry date (2 years from issue date)
            var expiryDate = new Date(issueDate);
            expiryDate.setFullYear(issueDate.getFullYear() + 2);
            expiryDateField.value = expiryDate.toISOString().split('T')[0]; // Format to YYYY-MM-DD
        }

        function togglePasswordVisibility(fieldId) {
            var passwordField = document.getElementById(fieldId);
            var toggleIcon = document.getElementById('eye' + fieldId);

            if (passwordField.type === "password") {
                passwordField.type = "text";
                toggleIcon.classList.remove("fa-eye");
                toggleIcon.classList.add("fa-eye-slash");
            } else {
                passwordField.type = "password";
                toggleIcon.classList.remove("fa-eye-slash");
                toggleIcon.classList.add("fa-eye");
            }
        }
    </script>
</asp:Content>