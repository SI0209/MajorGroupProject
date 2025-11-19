<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Review.aspx.cs" Inherits="DrivingSchoolWebsite.Public_Pages.Review" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
 

    <section style="padding: 50px; background-color: #000; color: #fff;">
        <h2 style="text-align: center; margin-bottom: 40px;">Customer Reviews</h2>

        <!-- Reviews Section -->
        <div style="max-width: 800px; margin: auto;">
            <!-- Review 1 -->
            <div class="review-container">
                <img src='<%= ResolveUrl("~/Images/AnonPic.png") %>' alt="Anonymous Icon" class="anon-icon">
                <div class="review-content">
                    <h4>Yusuf</h4>
                    <p>"Araf's Driving School is amazing! The instructors were very patient, and I gained a lot of confidence behind the wheel. Highly recommended!"</p>
                    <p style="text-align: right; font-style: italic;">Rating: ★★★★★</p>
                </div>
            </div>

            <!-- Review 2 -->
            <div class="review-container">
                <img src='<%= ResolveUrl("~/Images/AnonPic.png") %>' alt="Anonymous Icon" class="anon-icon">
                <div class="review-content">
                    <h4>Moosa</h4>
                    <p>"I had a great experience. The lessons were well-structured and the instructors made sure to address all my concerns. I passed my driving test on the first try!"</p>
                    <p style="text-align: right; font-style: italic;">Rating: ★★★★☆</p>
                </div>
            </div>

            <!-- Review 3 -->
            <div class="review-container">
                <img src='<%= ResolveUrl("~/Images/AnonPic.png") %>' alt="Anonymous Icon" class="anon-icon">
                <div class="review-content">
                    <h4>Anonymous</h4>
                    <p>"Great service and great value! I found the booking process easy, and the instructors are very professional. I’m really happy with my results."</p>
                    <p style="text-align: right; font-style: italic;">Rating: ★★★★★</p>
                </div>
            </div>

            <div class="review-container">
                <img src='<%= ResolveUrl("~/Images/AnonPic.png") %>' alt="Anonymous Icon" class="anon-icon">
                <div class="review-content">
                    <h4>Kiaan</h4>
                    <p>"Araf's Driving School is amazing! The instructors were very patient, and I gained a lot of confidence behind the wheel. Highly recommended!"</</p>
                    <p style="text-align: right; font-style: italic;">Rating: ★★★★★</p>
                </div>
            </div>

            <asp:Repeater ID="rptReviews" runat="server">
    <ItemTemplate>
        <div class="review-card">
            <h4><%# Eval("UserName") %></h4>
            <p class="rating">Rating: <%# Eval("Rating") %> / 5</p>
            <p class="comment"><%# Eval("Comment") %></p>
            <span class="date"><%# Eval("ReviewDate", "{0:dd MMM yyyy}") %></span>
        </div>
    </ItemTemplate>
</asp:Repeater>
            <!-- Add Review Button -->
            <div style="text-align: center; margin-top: 40px;">
                <button type="button" onclick="redirectToLogin()" style="padding: 10px 20px; background-color: #3498db; color: #fff; border: none; cursor: pointer;">Add Your Review</button>
            </div>
        </div>
    </section>

    <script type="text/javascript">
        function redirectToLogin() {
            window.location.href = 'Login.aspx'; // Redirect to the Login page
        }
    </script>

    <style>
        /* Container for each review with image on the left and text on the right */
        .review-container {
            display: flex;
            align-items: center;
            padding: 20px;
            border-bottom: 1px solid #999;
            margin-bottom: 20px;
        }

        /* Style for the anonymous icon */
        .anon-icon {
            width: 110px; /* Large size */
            height: 110px;
            margin-right: 40px; /* Increased space between image and text */
            margin-top: -45px; /* Moves the image upwards slightly */
            object-fit: cover;
        }

        /* Review text content styling */
        .review-content {
            flex: 1;
            color: #fff;
        }

        .review-content h4 {
            margin-bottom: 10px;
        }

        .review-content p {
            margin-bottom: 10px;
        }

    .review-card {
    background: #f8f8f8;
    padding: 15px;
    margin-bottom: 15px;
    border-radius: 8px;
    box-shadow: 0 1px 3px rgba(0,0,0,.15);
    }
    .rating {
    font-weight: bold;
    color: #ff9900;
    }
    .date {
    font-size: 12px;
    color: #777;
    }
    </style>
</asp:Content>

