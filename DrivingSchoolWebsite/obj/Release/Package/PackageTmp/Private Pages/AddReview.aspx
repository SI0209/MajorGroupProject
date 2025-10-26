<%@ Page Title="Add Review" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddReview.aspx.cs" Inherits="DrivingSchoolWebsite.Private_Pages.AddReview" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <section style="padding: 50px; background-color: #333; color: #fff; margin-bottom: 0;">
        <h2 style="text-align: center; margin-bottom: 40px;">Add Your Review</h2>

        <div style="max-width: 800px; margin: auto;">
            <!-- Username TextBox -->
            <asp:TextBox ID="txtUsername" runat="server" Placeholder="Your name (optional)" style="width: 100%; padding: 10px; box-sizing: border-box;"></asp:TextBox>
            <br />
            
            <!-- Review TextBox -->
            <asp:TextBox ID="txtReview" runat="server" TextMode="MultiLine" Rows="5" Placeholder="Write your review here..." style="width: 100%; padding: 10px; box-sizing: border-box;"></asp:TextBox>
            <br />
            
            <!-- Rating DropDownList -->
            <asp:DropDownList ID="ddlRating" runat="server" style="width: 100%; padding: 10px; box-sizing: border-box;">
                <asp:ListItem Value="5">★★★★★</asp:ListItem>
                <asp:ListItem Value="4">★★★★☆</asp:ListItem>
                <asp:ListItem Value="3">★★★☆☆</asp:ListItem>
                <asp:ListItem Value="2">★★☆☆☆</asp:ListItem>
                <asp:ListItem Value="1">★☆☆☆☆</asp:ListItem>
            </asp:DropDownList>
            <br />
            
            <!-- Submit Button -->
            <asp:Button ID="btnSubmit" runat="server" Text="Submit Review" OnClick="btnSubmit_Click" style="padding: 10px 20px; background-color: #3498db; color: #fff; border: none; cursor: pointer; box-sizing: border-box;" />
        </div>
    </section>
</asp:Content>
