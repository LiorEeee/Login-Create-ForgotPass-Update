<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ForgotPassword.aspx.cs" Inherits="Mid_Project.ForgotPassword" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="ForgotPassword.css" />
</head>
<body>

    <form id="form1" runat="server">
        <asp:Label ID="Title_Label" class="container" runat="server" Text="Forgot Password" Visible="true"></asp:Label>
        <asp:Label ID="UserName_Label" class="container" runat="server" Text="UserName" Visible="true"></asp:Label>
        <asp:TextBox ID="UserName_TextBox" class="container" runat="server" Visible="true"></asp:TextBox>
        <asp:Label ID="Email_Label" class="container" runat="server" Text="Email" Visible="true"></asp:Label>
        <asp:TextBox ID="Email_TextBox" class="container" runat="server" Visible="true"></asp:TextBox>
        <asp:Label ID="ChangePassword_Label" class="container" runat="server" Text="Enter New Password" Visible="False"></asp:Label>
        <asp:TextBox ID="ChangePassword_TextBox" class="container" runat="server" Visible="false"></asp:TextBox>
        <asp:Label ID="IsPasswordChanged" class="container" runat="server" Text="" Visible="true"></asp:Label>
        <asp:Button ID="CheckAccount_Button" class="container" runat="server" OnClick="CheckAccount_Button_Click" Text="Check Account"  Visible="true"/>
        <asp:Button ID="ChangePassword_Button" class="container" runat="server" OnClick="ChangePassword_Button_Click" Text="Change Password"  Visible="False"/>

        <a href="Login.aspx">
            <asp:Label ID="BackToLogin_Label" runat="server" Text="Back to Login"></asp:Label>
        </a>
    </form>

</body>
</html>
