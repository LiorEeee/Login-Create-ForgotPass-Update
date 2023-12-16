<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateAccount.aspx.cs" Inherits="Mid_Project.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="UpdateAccount.css" />
    <script src="https://code.jquery.com/jquery-3.6.4.min.js"></script>
    <script src="UpdateInfo.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Title_Label" class="container" runat="server" Text="Account Info"></asp:Label>
        
        <asp:Label ID="LastName_Label" class="container" runat="server" Text="Last Name"></asp:Label>
        <asp:Label ID="FirstName_Label" class="container" runat="server" Text="First Name"></asp:Label>
        <asp:TextBox ID="LastName_TextBox" Text="" class="container" runat="server" TabIndex="2" autocomplete="off" ReadOnly="true"></asp:TextBox>
        <asp:TextBox ID="FirstName_TextBox" Text="" class="container" runat="server" TabIndex="1" autocomplete="off" ReadOnly="true"></asp:TextBox>
        <asp:RequiredFieldValidator ID="LastName_RequiredValidator" runat="server" ControlToValidate="LastName_TextBox" ErrorMessage="This field is required." Display="Dynamic" Class="Error" />
        <asp:RegularExpressionValidator ID="LastName_Validator" runat="server" class="Error" ControlToValidate="LastName_TextBox" ValidationExpression="^.{2,}$" ErrorMessage= "Must be at least 2 characters long." Display="Dynamic" />
        <asp:RequiredFieldValidator ID="FirstName_RequiredValidator" runat="server" ControlToValidate="FirstName_TextBox" ErrorMessage="This field is required." Display="Dynamic" Class="Error" />
        <asp:RegularExpressionValidator ID="FirstName_Validator" runat="server" class="Error" ControlToValidate="FirstName_TextBox" ValidationExpression="^.{2,}$" ErrorMessage="Must be at least 2 characters long." Display="Dynamic" />
        <div style="clear:both;"></div>

        <asp:Label ID="ID_Label" class="container" runat="server" Text="ID"></asp:Label>
        <asp:Label ID="UserName_Label" class="container" runat="server" Text="UserName"></asp:Label>
        <asp:TextBox ID="ID_TextBox" Text="" class="container" runat="server" TabIndex="4" autocomplete="off" ReadOnly="true"></asp:TextBox>
        <asp:TextBox ID="UserName_TextBox" Text="" class="container" runat="server" TabIndex="3" autocomplete="off" ReadOnly="true"></asp:TextBox>
        <asp:RequiredFieldValidator ID="ID_RequiredValidator" runat="server" ControlToValidate="ID_TextBox" ErrorMessage="This field is required." Display="Dynamic" Class="Error" />
        <asp:RegularExpressionValidator ID="ID_Validator" runat="server" class="Error" ControlToValidate="ID_TextBox" ValidationExpression="^\d{8,10}$" ErrorMessage="Must be between 8 to 10 numbers." Display="Dynamic" />
        <asp:RequiredFieldValidator ID="UserName_RequiredValidator" runat="server" ControlToValidate="UserName_TextBox" ErrorMessage="This field is required." Display="Dynamic" Class="Error" />
        <asp:RegularExpressionValidator ID="UserName_Validator" runat="server" class="Error" ControlToValidate="UserName_TextBox" ValidationExpression="^.{5,}$" ErrorMessage="Must be at least 5 characters long." Display="Dynamic" />
        <div style="clear:both;"></div>

        <asp:Label ID="PhoneNumber_Label" class="container" runat="server" Text="Phone Number"></asp:Label>
        <asp:Label ID="Gmail_Label" class="container" runat="server" Text="Gmail"></asp:Label>
        <asp:TextBox ID="PhoneNumber_TextBox" Text="" class="container" runat="server" TabIndex="6" autocomplete="off" ReadOnly="true"></asp:TextBox>
        <asp:TextBox ID="Gmail_TextBox" Text="" class="container" runat="server" TabIndex="5" autocomplete="off" ReadOnly="true"></asp:TextBox>
        <asp:RequiredFieldValidator ID="PhoneNumber_RequiredValidator" runat="server" ControlToValidate="PhoneNumber_TextBox" ErrorMessage="This field is required." Display="Dynamic" Class="Error" />
        <asp:RegularExpressionValidator ID="PhoneNumber_Validator" runat="server" class="Error" ControlToValidate="PhoneNumber_TextBox" ValidationExpression="^\d{10}$" ErrorMessage="Must be 10 numbers." Display="Dynamic" />
        <asp:RequiredFieldValidator ID="Gmail_RequiredValidator" runat="server" ControlToValidate="Gmail_TextBox" ErrorMessage="This field is required." Display="Dynamic" Class="Error" />
        <asp:RegularExpressionValidator ID="Gmail_Validator" runat="server" class="Error" ControlToValidate="Gmail_TextBox" ValidationExpression="^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$" ErrorMessage="Enter a valid Gmail address." Display="Dynamic" />
        <div style="clear:both;"></div>

        <asp:Label ID="Password_Label" class="container" runat="server" Text="Password"></asp:Label>
        <asp:TextBox ID="Password_TextBox" Text="" class="container" runat="server" TabIndex="7" autocomplete="off" ReadOnly="true"></asp:TextBox>
        <asp:RequiredFieldValidator ID="Password_RequiredValidator" runat="server" ControlToValidate="Password_TextBox" ErrorMessage="This field is required." Display="Dynamic" Class="Error" />
        <asp:RegularExpressionValidator ID="Password_Validator" runat="server" class="Error" ControlToValidate="Password_TextBox" ValidationExpression="^.{4,}$" ErrorMessage="Must be at least 4 characters long." Display="Dynamic" />
        <div style="clear:both;"></div>

        <br/>
        <asp:Label ID="IsGood_Label" class="container" runat="server" Text=""></asp:Label>
        <a href="Login.aspx">
            <asp:Label ID="Back_Label" runat="server" Text="Back"></asp:Label>
        </a>
        <asp:LinkButton ID="Edit_LinkButton" runat="server" Text="Edit" OnClick="Edit_LinkButton_Click"></asp:LinkButton>

        <asp:Button ID="UpdateInfo_Button" class="container" runat="server" OnClick="UpdateInfo_Button_Click" Text="Update Account" />

    </form>

</body>
</html>