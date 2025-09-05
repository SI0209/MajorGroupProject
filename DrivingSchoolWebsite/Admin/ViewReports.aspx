<%@ Page Title="Dashboard" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ViewReports.aspx.cs" Inherits="DrivingSchoolWebsite.Admin.ViewReports" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <style>
        /* CSS Styling for Layout */
        body {
            background-color: #f4f4f4; /* Light grey background */
            font-family: Arial, sans-serif;
            margin: 0;
            padding: 20px;
        }

        .header {
            font-size: 16px;
            color: #333; /* Dark grey for text */
            margin-bottom: 5px;
        }

        .header-number {
            font-size: 28px;
            font-weight: bold;
            color: #000; /* Black for important numbers */
        }

        .counter-title {
            font-weight: bold;
            font-size: 18px;
            color: #555; /* Medium grey for titles */
        }

        .container {
            display: flex;
            justify-content: space-around;
            margin: 20px 0;
        }

        .counters, .pie-chart-container {
            background-color: #fff; /* White background for counters */
            border-radius: 8px; /* Rounded corners */
            box-shadow: 0 2px 10px rgba(0, 0, 0, 0.1); /* Subtle shadow */
            padding: 20px;
            flex: 1; /* Equal width for all counters */
            margin: 0 10px; /* Space between elements */
        }

        .pie-chart-container {
            margin-top: 20px; /* Space above pie chart */
        }

        .chart-title {
            font-size: 16px;
            text-align: center;
            color: #333; /* Dark grey for chart title */
            margin-bottom: 15px; /* Space below the title */
        }

        table {
            width: 100%;
            border-collapse: collapse; /* Collapsing borders for table */
        }

        td {
            padding: 8px;
            color: #333; /* Dark grey for table text */
            border-bottom: 1px solid #ddd; /* Light grey border for table rows */
        }

        tr:hover {
            background-color: #f1f1f1; /* Light grey on hover for table rows */
        }

        @media (max-width: 600px) {
            .container {
                flex-direction: column; /* Stack items on small screens */
            }

            .counters {
                margin: 10px 0; /* Reduce margin for smaller screens */
            }
        }
    </style>

    <div class="container">
        <!-- Male Learners Count -->
        <div class="counters">
            <div class="header">Number Of Male Learners</div>
            <asp:Label ID="LblMaleLearners" runat="server" Text="1000" CssClass="header-number"></asp:Label>
        </div>

        <!-- Female Learners Count -->
        <div class="counters">
            <div class="header">Number Of Female Learners</div>
            <asp:Label ID="LblFemaleLearners" runat="server" Text="9999" CssClass="header-number"></asp:Label>
        </div>
    </div>

    <!-- Pie Chart Section -->
    <div class="pie-chart-container">
        <asp:Chart ID="Chart1" runat="server" Width="500px" Height="400px">
            <Series>
                <asp:Series Name="Learners" ChartType="Pie"></asp:Series>
            </Series>
            <ChartAreas>
                <asp:ChartArea Name="ChartArea1"></asp:ChartArea>
            </ChartAreas>
        </asp:Chart>
    </div>

    <!-- Total Counters Section -->
    <div class="counters">
        <div class="counter-title">Total Counters</div>
        <table>
            <tr>
                <td>Number Of Bookings:</td>
                <td><asp:Label ID="lblBookings" runat="server" Text="0"></asp:Label></td>
            </tr>
            <tr>
                <td>Popular Code Type:</td>
                <td><asp:Label ID="lblPopularCode" runat="server" Text=""></asp:Label></td>
            </tr>
            <tr>
                <td>Number Of Vehicles:</td>
                <td><asp:Label ID="lblVehicles" runat="server" Text="0"></asp:Label></td>
            </tr>
            <tr>
                <td>Payments Unpaid:</td>
                <td><asp:Label ID="lblPayments" runat="server" Text="0"></asp:Label></td>
            </tr>
            <tr>
                <td>Male Instructors:</td>
                <td><asp:Label ID="lblMaleInstructors" runat="server" Text="0"></asp:Label></td>
            </tr>
            <tr>
                <td>Female Instructors:</td>
                <td><asp:Label ID="lblFemaleInstructors" runat="server" Text="0"></asp:Label></td>
            </tr>
        </table>
    </div>
</asp:Content>
