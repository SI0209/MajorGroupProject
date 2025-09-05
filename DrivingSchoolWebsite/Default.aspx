<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="DrivingSchoolWebsite._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <style>
        .hero-section {
            position: relative;
            background-image: url(); /* Use a relevant background image */
            background-size: cover;
            background-position: center;
            height: 100vh;
            display: flex;
            align-items: center;
            justify-content: center;
            color: #fff;
            text-align: center;
        }

        .overlay {
            background-color: rgba(0, 0, 0, 0.5); /* Dark overlay for text readability */
            padding: 20px;
            border-radius: 10px;
        }

        .hero-section h1 {
            font-size: 3em;
            margin-bottom: 20px;
            font-weight: bold;
        }

        .hero-section p {
            font-size: 1.5em;
            margin-bottom: 30px;
        }

       

        @media (max-width: 768px) {
            .hero-section h1 {
                font-size: 2.5em;
            }

            .hero-section p {
                font-size: 1.2em;
            }
        }
    </style>

    <div class="hero-section">
        <div class="overlay">
            <h1>ARAF'S DRIVING SCHOOL</h1>
            <p>LEARN TO DRIVE WITH CONFIDENCE</p>
            
        </div>
    </div>
</asp:Content>