<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ReportThree.aspx.cs" Inherits="DrivingSchoolWebsite.Admin.ReportThree" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
<div class="container mt-5">
        <div class="row">
            <!-- Report Header Section -->
            <div class="col-md-12 text-center mb-4">
                <h2 class="display-4 font-weight-bold">Learner and Suburb Report</h2>
            </div>

            <!-- Dashboard Information -->
            <div class="col-md-12 mb-5">
                <div class="row text-center">
                    <!-- Learner Count -->
                    <div class="col-md-4 mb-3">
                        <div class="card shadow-lg p-3">
                            <h4 class="card-title">Total Learners</h4>
                            <p class="card-text">
                                <asp:Label ID="LblTotalLearners" runat="server" Text="Total Learners: " Font-Bold="true" Font-Size="Large" ForeColor="black" />
                            </p>
                        </div>
                    </div>

                    <!-- Most Popular Suburb -->
                    <div class="col-md-4 mb-3">
                        <div class="card shadow-lg p-3">
                            <h4 class="card-title">Most Popular Suburb</h4>
                            <p class="card-text">
                                <asp:Label ID="LblMostPopularSuburb" runat="server" Text="Most Popular Suburb: " Font-Bold="true" Font-Size="Large" ForeColor="black" />
                            </p>
                        </div>
                    </div>

                    <!-- Learners in Most Popular Suburb -->
                    <div class="col-md-4 mb-3">
                        <div class="card shadow-lg p-3">
                            <h4 class="card-title">Learners in Most Popular Suburb</h4>
                            <p class="card-text">
                                <asp:Label ID="LblLearnersInMostPopularSuburb" runat="server" Text="Learners in Most Popular Suburb: " Font-Bold="true" Font-Size="Large" ForeColor="black" />
                            </p>
                        </div>
                    </div>
                </div>
            </div>

            <!-- Bookings Completed Section -->
            <div class="col-md-12 mb-4 text-center">
                <h3 class="text-primary">Bookings Completed</h3>
            </div>

            <!-- Chart for Top 5 Most Popular Suburbs -->
            <div class="col-md-12 mb-5">
                <div class="card shadow-lg p-3">
                    <h4 class="card-title text-center">Top 5 Most Popular Suburbs</h4>
                   <asp:Chart ID="Chart2" runat="server" Width="800px" Height="400px" class="mt-3">
    <Series>
        <asp:Series Name="SuburbBookings" />
    </Series>
    <ChartAreas>
        <asp:ChartArea Name="ChartArea1" />
    </ChartAreas>
</asp:Chart>

                </div>
            </div>
        </div>
    </div>


</asp:Content>
