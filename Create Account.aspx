<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Create Account.aspx.cs" Inherits="Mid_Project.Create_Account" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="CreateAccount.css" />
</head>
<body>

    <form id="form1" runat="server">
        <asp:Label ID="Title_Label" class="container" runat="server" Text="Create Account"></asp:Label>
        
        <asp:Label ID="LastName_Label" class="container" runat="server" Text="Last Name"></asp:Label>
        <asp:Label ID="FirstName_Label" class="container" runat="server" Text="First Name"></asp:Label>
        <asp:TextBox ID="LastName_TextBox" class="container" runat="server" TabIndex="2" autocomplete="off"></asp:TextBox>
        <asp:TextBox ID="FirstName_TextBox" class="container" runat="server" TabIndex="1" autocomplete="off"></asp:TextBox>
        <asp:RequiredFieldValidator ID="LastName_RequiredValidator" runat="server" ControlToValidate="LastName_TextBox" ErrorMessage="This field is required." Display="Dynamic" Class="Error" />
        <asp:RegularExpressionValidator ID="LastName_Validator" runat="server" class="Error" ControlToValidate="LastName_TextBox" ValidationExpression="^.{2,}$" ErrorMessage= "Must be at least 2 characters long." Display="Dynamic" />
        <asp:RequiredFieldValidator ID="FirstName_RequiredValidator" runat="server" ControlToValidate="FirstName_TextBox" ErrorMessage="This field is required." Display="Dynamic" Class="Error" />
        <asp:RegularExpressionValidator ID="FirstName_Validator" runat="server" class="Error" ControlToValidate="FirstName_TextBox" ValidationExpression="^.{2,}$" ErrorMessage="Must be at least 2 characters long." Display="Dynamic" />
        <div style="clear:both;"></div>

        <asp:Label ID="ID_Label" class="container" runat="server" Text="ID"></asp:Label>
        <asp:Label ID="UserName_Label" class="container" runat="server" Text="UserName"></asp:Label>
        <asp:TextBox ID="ID_TextBox" class="container" runat="server" TabIndex="4" autocomplete="off"></asp:TextBox>
        <asp:TextBox ID="UserName_TextBox" class="container" runat="server" TabIndex="3" autocomplete="off"></asp:TextBox>
        <asp:RequiredFieldValidator ID="ID_RequiredValidator" runat="server" ControlToValidate="ID_TextBox" ErrorMessage="This field is required." Display="Dynamic" Class="Error" />
        <asp:RegularExpressionValidator ID="ID_Validator" runat="server" class="Error" ControlToValidate="ID_TextBox" ValidationExpression="^\d{8,10}$" ErrorMessage="Must be between 8 to 10 numbers." Display="Dynamic" />
        <asp:RequiredFieldValidator ID="UserName_RequiredValidator" runat="server" ControlToValidate="UserName_TextBox" ErrorMessage="This field is required." Display="Dynamic" Class="Error" />
        <asp:RegularExpressionValidator ID="UserName_Validator" runat="server" class="Error" ControlToValidate="UserName_TextBox" ValidationExpression="^.{5,}$" ErrorMessage="Must be at least 5 characters long." Display="Dynamic" />
        <div style="clear:both;"></div>

        <asp:Label ID="PhoneNumber_Label" class="container" runat="server" Text="Phone Number"></asp:Label>
        <asp:Label ID="Gmail_Label" class="container" runat="server" Text="Gmail"></asp:Label>
        <asp:TextBox ID="PhoneNumber_TextBox" class="container" runat="server" TabIndex="6" autocomplete="off"></asp:TextBox>
        <asp:TextBox ID="Gmail_TextBox" class="container" runat="server" TabIndex="5" autocomplete="off"></asp:TextBox>
        <asp:RequiredFieldValidator ID="PhoneNumber_RequiredValidator" runat="server" ControlToValidate="PhoneNumber_TextBox" ErrorMessage="This field is required." Display="Dynamic" Class="Error" />
        <asp:RegularExpressionValidator ID="PhoneNumber_Validator" runat="server" class="Error" ControlToValidate="PhoneNumber_TextBox" ValidationExpression="^\d{10}$" ErrorMessage="Must be 10 numbers." Display="Dynamic" />
        <asp:RequiredFieldValidator ID="Gmail_RequiredValidator" runat="server" ControlToValidate="Gmail_TextBox" ErrorMessage="This field is required." Display="Dynamic" Class="Error" />
        <asp:RegularExpressionValidator ID="Gmail_Validator" runat="server" class="Error" ControlToValidate="Gmail_TextBox" ValidationExpression="^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$" ErrorMessage="Enter a valid Gmail address." Display="Dynamic" />
        <div style="clear:both;"></div>

        <asp:Label ID="Password_Label" class="container" runat="server" Text="Password"></asp:Label>
        <asp:TextBox ID="Password_TextBox" class="container" runat="server" TabIndex="7" autocomplete="off"></asp:TextBox>
         <asp:RequiredFieldValidator ID="Password_RequiredValidator" runat="server" ControlToValidate="Password_TextBox" ErrorMessage="This field is required." Display="Dynamic" Class="Error" />
        <asp:RegularExpressionValidator ID="Password_Validator" runat="server" class="Error" ControlToValidate="Password_TextBox" ValidationExpression="^.{4,}$" ErrorMessage="Must be at least 4 characters long." Display="Dynamic" />
        <div style="clear:both;"></div>
        <asp:Label ID="IsSignUp" class="container" runat="server" Text=""></asp:Label>
        <br />
        <a href="Login.aspx">
            <asp:Label ID="Login_Label" runat="server" Text="Login"></asp:Label>
        </a>

        <asp:Button ID="SignUp_Button" class="container" runat="server" OnClick="SignUp_Button_Click" Text="Sign Up" />
    </form>

</body>
</html>
