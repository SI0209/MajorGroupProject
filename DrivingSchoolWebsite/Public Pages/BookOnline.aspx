<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="BookOnline.aspx.cs" Inherits="DrivingSchoolWebsite.Public_Pages.BookOnline" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <style>
        .book-now-button {
            padding: 10px 20px;
            background-color: #4CAF50;
            color: white;
            border: none;
            cursor: pointer;
        }
        .vehicle-container {
            display: flex;
            justify-content: space-between;
            margin-bottom: 20px;
            background-color: #333;
            padding: 15px;
        }
        .vehicle-image {
            width: 45%;
            height: auto;
        }
        .vehicle-info {
            flex-basis: 50%;
            padding: 10px;
            color: white;
        }
        .read-more-link {
            color: #fff;
            text-decoration: underline;
            cursor: pointer;
        }
        /* Modal styles */
        .modal {
            display: none;
            position: fixed;
            z-index: 1;
            left: 0;
            top: 0;
            width: 100%;
            height: 100%;
            overflow: auto;
            background-color: rgb(0,0,0);
            background-color: rgba(0,0,0,0.4);
            padding-top: 60px;
        }
        .modal-content {
            background-color: #fefefe;
            margin: 5% auto;
            padding: 20px;
            border: 1px solid #888;
            width: 80%;
        }
        .close {
            color: #aaa;
            float: right;
            font-size: 28px;
            font-weight: bold;
        }
        .close:hover,
        .close:focus {
            color: black;
            text-decoration: none;
            cursor: pointer;
        }
    </style>

    <section style="padding: 50px; background-color: #2c2c2c; color: white;">
        <h2 style="text-align: center; margin-bottom: 30px;">BOOK ONLINE</h2>
        <div style="max-width: 1200px; margin: auto;">
            <!-- First Vehicle (Code 8) -->
            <div class="vehicle-container">
                <img src="../Images/code8.png" alt="Code 8 Vehicle" class="vehicle-image">
                <div class="vehicle-info">
                    <h3>Code 8 (Light Motor Vehicles)</h3>
                    <p><span class="read-more-link" onclick="showModal('modalCode8')">Read More</span></p>
                    <p>1 hr</p>
                    <p>R 200</p>
                    <button type="button" onclick="redirectToLogin()" class="book-now-button">BOOK NOW</button>
                </div>
            </div>

            <!-- Second Vehicle (Code 10) -->
            <div class="vehicle-container">
                <img src="../Images/code10.png" alt="Code 10 Vehicle" class="vehicle-image">
                <div class="vehicle-info">
                    <h3>Code 10 (Medium Motor Vehicles)</h3>
                    <p><span class="read-more-link" onclick="showModal('modalCode10')">Read More</span></p>
                    <p>1 hr</p>
                    <p>R 350</p>
                    <button type="button" onclick="redirectToLogin()" class="book-now-button">BOOK NOW</button>
                </div>
            </div>

            <!-- Third Vehicle (Code 14) -->
            
        </div>
    </section>

    <!-- Modal Code 8 -->
   <!-- Modal Code 8 -->
<div id="modalCode8" class="modal">
    <div class="modal-content" style="background-color: #444; color: white; font-family: Arial, sans-serif;">
        <span class="close" onclick="closeModal('modalCode8')" style="color: #fff; font-size: 24px;">&times;</span>
        <h3 style="font-weight: bold; font-size: 24px;">Code 8 (Light Motor Vehicles)</h3>
        <p><strong>Description:</strong> The Code 8 license is required for driving light motor vehicles, including cars and vans with a gross vehicle mass (GVM) not exceeding 3,500 kg. It is typically suitable for everyday driving and personal use.</p>
        <p><strong>Requirements:</strong></p>
        <ul>
            <li>Minimum age: 18 years.</li>
            <li>Valid learner's license for at least 6 months.</li>
            <li>Completion of a driving test.</li>
        </ul>
        <p><strong>Benefits:</strong></p>
        <ul>
            <li>Ideal for beginners and those seeking a driving license for personal use.</li>
            <li>Allows driving light commercial vehicles, including small trucks.</li>
        </ul>
        <p><strong>Training Duration:</strong> 10 hours of theoretical training and 5 hours of practical driving lessons.</p>
        <p><strong>Pricing:</strong> R 100 for 1 hour of practical lessons.</p>
    </div>
</div>


<!-- Modal Code 10 -->
<div id="modalCode10" class="modal">
    <div class="modal-content" style="background-color: #444; color: white; font-family: Arial, sans-serif;">
        <span class="close" onclick="closeModal('modalCode10')" style="color: #fff; font-size: 24px;">&times;</span>
        <h3 style="font-weight: bold; font-size: 24px;">Code 10 (Medium Motor Vehicles)</h3>
        <p><strong>Description:</strong> The Code 10 license permits the holder to drive medium motor vehicles, including trucks and buses with a GVM exceeding 3,500 kg but not exceeding 16,000 kg.</p>
        <p><strong>Requirements:</strong></p>
        <ul>
            <li>Minimum age: 18 years.</li>
            <li>Valid Code 8 license for at least 1 year.</li>
            <li>Completion of a driving test specific to medium vehicles.</li>
        </ul>
        <p><strong>Benefits:</strong></p>
        <ul>
            <li>Expands job opportunities in transport and logistics.</li>
            <li>Allows driving vehicles used in commercial and industrial sectors.</li>
        </ul>
        <p><strong>Training Duration:</strong> 15 hours of theoretical training and 10 hours of practical driving lessons.</p>
        <p><strong>Pricing:</strong> R 200 for 1 hour of practical lessons.</p>
    </div>
</div>


<!-- Modal Code 14 -->
<div id="modalCode14" class="modal">
    <div class="modal-content" style="background-color: #444; color: white; font-family: Arial, sans-serif;">
        <span class="close" onclick="closeModal('modalCode14')" style="color: #fff; font-size: 24px;">&times;</span>
        <h3 style="font-weight: bold; font-size: 24px;">Code 14 (Heavy Motor Vehicles)</h3>
        <p><strong>Description:</strong> The Code 14 license allows the holder to drive heavy motor vehicles, including articulated trucks and buses with a GVM exceeding 16,000 kg.</p>
        <p><strong>Requirements:</strong></p>
        <ul>
            <li>Minimum age: 21 years.</li>
            <li>Valid Code 10 license for at least 1 year.</li>
            <li>Completion of a specialized driving test for heavy vehicles.</li>
        </ul>
        <p><strong>Benefits:</strong></p>
        <ul>
            <li>High demand for heavy vehicle drivers in various industries.</li>
            <li>Opportunity to earn a higher salary due to the specialized nature of the license.</li>
        </ul>
        <p><strong>Training Duration:</strong> 20 hours of theoretical training and 15 hours of practical driving lessons.</p>
        <p><strong>Pricing:</strong> R 400 for 1 hour of practical lessons.</p>
    </div>
</div>



    <script type="text/javascript">
        function redirectToLogin() {
            alert("You will be redirected to the Register page.");
            window.location.href = '/Account/Register.aspx'; // Redirect to the Register page
        }

        function showModal(modalId) {
            document.getElementById(modalId).style.display = "block";
        }

        function closeModal(modalId) {
            document.getElementById(modalId).style.display = "none";
        }

        // Close modals when clicking outside of the modal content
        window.onclick = function (event) {
            if (event.target.className === "modal") {
                closeModal(event.target.id);
            }
        }
    </script>
</asp:Content>
