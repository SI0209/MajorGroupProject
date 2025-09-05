<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Services.aspx.cs" Inherits="DrivingSchoolWebsite.Public_Pages.Services" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <section class="services-section">
        <h2>OUR SERVICES</h2>
        <div class="service-icons">
            <!-- Code 8 Service Block -->
            <div class="service-block">
                <img src='<%= ResolveUrl("~/Images/code8Icon.png") %>' alt="Code 8 Icon" class="vehicle-image">
                <p>Code 8 (Light Motor Vehicles)</p>
                <p>Learn to drive light motor vehicles with our expert instructors. Perfect for new drivers aiming for their Code 8 license.</p>
            </div>

            <!-- Vertical Divider -->
            <div class="divider"></div>

            <!-- Code 10 Service Block -->
            <div class="service-block">
                <img src='<%= ResolveUrl("~/Images/Code10Icon.png") %>' alt="Code 10 Icon" class="vehicle-image">
                <p>Code 10 (Medium Motor Vehicles)</p>
                <p>Get your Code 10 license with our comprehensive training. Ideal for those looking to drive medium-sized vehicles like minibuses and trucks.</p>
            </div>

            <!-- Vertical Divider -->
            <div class="divider"></div>

            <!-- Code 14 Service Block -->
            <div class="service-block">
                <img src='<%= ResolveUrl("~/Images/Code14Icon.png") %>' alt="Code 14 Icon" class="vehicle-image">
                <p>Code 14 (Heavy Motor Vehicles)</p>
                <p>Master the skills needed to drive heavy vehicles with our specialized Code 14 lessons. Suitable for aspiring truck and bus drivers.</p>
            </div>
        </div>
    </section>

    <style>
        /* Style for the services section */
        .services-section {
            background-color: #1a1a1a;
            color: #fff;
            padding: 50px 0;
        }

        .services-section h2 {
            text-align: center;
            margin-bottom: 30px;
        }

        .service-icons {
            display: flex;
            justify-content: space-between;
            align-items: center;
            max-width: 1200px;
            margin: 0 auto;
        }

        /* Style for each service block */
        .service-block {
            flex: 1;
            text-align: center;
            padding: 0 5px; /* Reduced padding */
        }

        .service-block img {
            width: 150px;
            margin-bottom: 10px; /* Reduced margin */
        }

        .service-block p {
            font-size: 16px;
        }

        /* Style for the vertical divider */
        .divider {
            width: 1px; /* Narrower divider */
            background-color: white;
            height: 100%;
            margin: 0 10px; /* Less margin between blocks */
        }

        /* Reduced spacing around the icons */
        .service-block img {
            margin-bottom: 15px; /* Slightly reduced margin */
        }
    </style>
</asp:Content>
