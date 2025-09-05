<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ReportTwo.aspx.cs" Inherits="DrivingSchoolWebsite.Admin.ReportTwo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
       <style>
        /* Modern Grey and White Theme */
        body {
            background-color: #f9f9f9;
            font-family: 'Segoe UI', Arial, sans-serif;
            margin: 0;
            padding: 0;
            color: #333;
        }

        .container {
            max-width: 1200px;
            margin: 0 auto;
            padding: 20px;
        }

        .card {
            background-color: #ffffff;
            border: 1px solid #e0e0e0;
            border-radius: 10px;
            box-shadow: 0 4px 8px rgba(0, 0, 0, 0.1);
            margin-bottom: 20px;
            padding: 20px;
        }

        .header-title {
            font-size: 24px;
            font-weight: bold;
            color: #555;
            margin-bottom: 20px;
            text-align: center;
        }

        .row {
            display: flex;
            flex-wrap: wrap;
            gap: 20px;
            justify-content: space-between;
        }

        .counter {
            text-align: center;
            padding: 20px;
            flex: 1;
        }

        .counter-title {
            font-size: 16px;
            color: #777;
        }

        .counter-value {
            font-size: 36px;
            font-weight: bold;
            color: #333;
            margin-top: 10px;
        }

        .chart-container {
            text-align: center;
        }

        .chart-title {
            font-size: 18px;
            font-weight: bold;
            color: #555;
            margin-bottom: 20px;
        }

        table {
            width: 100%;
            border-collapse: collapse;
        }

        td {
            padding: 10px;
            font-size: 14px;
            border-bottom: 1px solid #e0e0e0;
        }

        tr:hover {
            background-color: #f5f5f5;
        }

        .dropdown {
            margin-top: 10px;
               top: 0px;
               left: 0px;
           }

        @media (max-width: 768px) {
            .row {
                flex-direction: column;
            }

            .counter {
                margin-bottom: 20px;
            }
        }
           .auto-style1 {
               height: 40px;
           }
    </style>

    <div class="container">
        <div class="header-title">Analytics Report</div>

        <!-- Counters Section -->
        <div class="row">
            <div class="card counter">
                <div class="counter-title">Number Of Bookings</div>
                <asp:Label ID="LblBookings" runat="server" Text="1000" CssClass="counter-value"></asp:Label>
            </div>
            <div class="card counter">
                <div class="counter-title">Total Revenue Gained</div>
                <asp:Label ID="LblRev" runat="server" Text="9999" CssClass="counter-value"></asp:Label>
            </div>
        </div>

        <!-- Year Selection Dropdown -->
        <div class="card">
            <div class="chart-title">Select Year</div>
            <asp:DropDownList ID="ddlYear" runat="server" CssClass="dropdown form-control" AutoPostBack="True" OnSelectedIndexChanged="ddlYear_SelectedIndexChanged" Height="40px" Width="200px"></asp:DropDownList>
        </div>

        <!-- Charts Section -->
        <div class="card chart-container">
            <!-- Bar Chart -->
            <div class="chart-title">Monthly Bookings</div>
            <asp:Chart ID="chartMonthlyBookings" runat="server" Width="700px" Height="400px">
                <ChartAreas>
                    <asp:ChartArea Name="ChartArea1">
                        <AxisX Title="Month" Interval="1"></AxisX>
                        <AxisY Title="Total Bookings"></AxisY>
                    </asp:ChartArea>
                </ChartAreas>
                <Series>
                    <asp:Series Name="MonthlyBookings" ChartType="Column" XValueType="String" YValueType="Int32">
                    </asp:Series>
                </Series>
                <Titles>
                    <asp:Title Text="Monthly Bookings for the Selected Year" Font="Arial, 14pt, style=Bold" />
                </Titles>
            </asp:Chart>
        </div>

        <!-- Pie Chart -->
        <div class="card chart-container">
            <div class="chart-title">Instructor Distribution</div>
           <asp:Chart ID="pieChartInstructor" runat="server" Width="500px" Height="300px">
    <Series>
        <asp:Series Name="InstructorBookings" ChartType="Pie" />
    </Series>
</asp:Chart>
        </div>

        <!-- Total Counters Section -->
        <div class="card">
            <div class="chart-title">Total Counters</div>
            <table>
                <tr>
                    <td class="auto-style1">Number Of Bookings:</td>
                    <td class="auto-style1"><asp:Label ID="Label1" runat="server" Text="0"></asp:Label></td>
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
    </div>
</asp:Content>
