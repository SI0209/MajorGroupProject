<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="DrivingSchoolWebsite.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <section class="about-section">
        <div class="about-container">
            <div class="about-text">
                <h2>ABOUT US</h2>
                <p>
                    At Wyebank Driving School, our goal is to provide top-notch driving education while simplifying administrative processes. We aim to create a seamless experience for both staff and students, where scheduling lessons is convenient and record-keeping is efficient.
                </p>
                <p>
                    We envision Wyebank Driving School as a leader in driving education, where technology and tradition combine to provide an unparalleled learning experience. By implementing this digital solution, we are ensuring that the school stays competitive and continues to drive student success into the future.
                </p>
                <p>
                    Wyebank Driving School, located at 1 Zinnia Road, is dedicated to helping students obtain their licenses. Offering lessons seven days a week, the school provides the flexibility needed for today's busy schedules. The school is owned and managed by Ernest Govender, who is committed to ensuring each student receives the best possible instruction.
                </p>
            </div>
        </div>
    </section>

    <style>
        /* Fade In Animation */
        @keyframes fadeIn {
            from {
                opacity: 0;
                transform: translateY(20px); /* Optional: slight upward movement */
            }
            to {
                opacity: 1;
                transform: translateY(0);
            }
        }

        .fade-in {
            animation: fadeIn 1s ease-in; /* Adjust duration and easing as needed */
            opacity: 1; /* Ensure it becomes visible */
        }

        /* About Us Section */
        .about-section {
            width: 100%; /* Ensures it fills the entire container width */
            padding: 50px 0; /* Adjust padding for vertical space without shrinking width */
            background-color: #1a1a1a;
            color: #fff;
            display: flex;
            align-items: center;
            justify-content: center;
            background-image: url('../Images/aboutus.png'); /* Set the background image */
            background-size: cover; /* Cover the entire section */
            background-position: center; /* Center the image */
        }

        .about-container {
            max-width: 1000px;
            display: flex;
            gap: 20px;
            background-color: rgba(0, 0, 0, 0.5); /* Optional: Add a semi-transparent background for text readability */
            padding: 20px; /* Optional: Add padding for text */
            border-radius: 10px; /* Optional: Add border radius */
        }

        .about-text {
            flex: 1; /* Allows the text to use the remaining space */
            max-width: 100%; /* Ensure text doesn't exceed 50% of the container */
            opacity: 0;
        }

        .about-text h2 {
            text-align: center;
            margin-bottom: 30px;
        }

        .about-text p {
            font-size: 20px; /* Increased font size */
            line-height: 1.8; /* Adjusted line height for readability */
            text-align: justify;
        }
    </style>

    <script>
        // Add fade-in effect when the page loads
        window.onload = function () {
            const aboutText = document.querySelector('.about-text');
            aboutText.classList.add('fade-in');
            aboutText.style.opacity = 1; // Ensure it becomes visible
        };
    </script>
</asp:Content>