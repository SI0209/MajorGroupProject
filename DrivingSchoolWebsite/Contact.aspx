<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="wyebankwebsite.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <section class="contact-section">
        <h2 class="contact-title">CONTACT US</h2>
        <div class="contact-container">
            <div class="contact-info">
                <p><strong>Address:</strong> 1 Zinnia Road, WyeBank</p>
                <p><strong>Email:</strong> <a href="mailto:info@wyebankdrivingschool.com">info@wyebankdrivingschool.com</a></p>
                <p><strong>Contact Number:</strong> 084 5695478</p>
                <h4>OFFICE HOURS:</h4>
                <p>Mon - Sat: 11am - 5pm</p>
                <p>Sunday: Closed</p>
                <p>Public Holidays: Closed</p>
                <h4>Location:</h4>
                <div class="map-container">
                    <iframe src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3301.3997169323585!2d29.89865131521295!3d-26.07275458310067!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x1ef8a70ff73cbb05%3A0x41d1f27b49d0dc2e!2s1%20Zinnia%20Road%2C%20WyeBank!5e0!3m2!1sen!2sza!4v1696114545924!5m2!1sen!2sza" 
                    width="100%" height="100%" style="border:0;" allowfullscreen="" loading="lazy"></iframe>
                </div>
            </div>
            <div class="contact-form">
                <form>
                    <div class="form-group">
                        <label for="firstName">First Name</label>
                        <input type="text" id="firstName" name="firstName" required>
                    </div>
                    <div class="form-group">
                        <label for="lastName">Last Name</label>
                        <input type="text" id="lastName" name="lastName" required>
                    </div>
                    <div class="form-group">
                        <label for="email">Email *</label>
                        <input type="email" id="email" name="email" required>
                    </div>
                    <div class="form-group">
                        <label for="message">Message</label>
                        <textarea id="message" name="message" rows="4" required></textarea>
                    </div>
                    <button type="submit" class="submit-button">Send Message</button>
                </form>
            </div>
        </div>
    </section>

    <style>
        .contact-section {
            padding: 50px;
            background-color: #1a1a1a;
            color: #fff;
        }

        .contact-title {
            text-align: center;
            margin-bottom: 30px;
            font-size: 2em;
            font-weight: bold;
        }

        .contact-container {
            display: flex;
            flex-wrap: wrap;
            justify-content: space-between;
            max-width: 1200px;
            margin: auto;
        }

        .contact-info, .contact-form {
            flex-basis: 100%;
            max-width: 100%;
            padding: 20px;
            box-sizing: border-box;
        }

        @media (min-width: 768px) {
            .contact-info {
                flex-basis: 40%;
            }

            .contact-form {
                flex-basis: 55%;
            }
        }

        .contact-info p, .contact-info h4 {
            margin-bottom: 10px;
        }

        .contact-info a {
            color: #4CAF50;
            text-decoration: none;
        }

        .contact-info a:hover {
            text-decoration: underline;
        }

        .map-container {
            width: 100%;
            height: 200px;
            margin-top: 10px;
            border-radius: 5px;
            overflow: hidden;
        }

        .form-group {
            margin-bottom: 15px;
        }

        .form-group label {
            display: block;
            margin-bottom: 5px;
            font-weight: bold;
        }

        .form-group input, .form-group textarea {
            width: 100%;
            padding: 10px;
            border: 1px solid #ccc;
            border-radius: 5px;
            box-sizing: border-box;
        }

        .form-group input:focus, .form-group textarea:focus {
            border-color: #4CAF50;
            outline: none;
        }

        .submit-button {
            padding: 10px 15px;
            background-color: #4CAF50;
            color: #fff;
            border: none;
            border-radius: 5px;
            cursor: pointer;
            transition: background-color 0.3s ease;
        }

        .submit-button:hover {
            background-color: #45a049;
        }
    </style>
</asp:Content>