<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegisterPage.aspx.cs" Inherits="AOLSE.View.RegisterPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" type="text/css" href="./StyleSheet.css"/>
</head>
<body>
    <div id="Page-size">
        <div id="Background">
            <div id="Front-page">
                <div id="Detail-page">
                    <div id="Detail-page-text">
                        <p style="width: 372px; margin-left: 15px">Welcome to Ediblee</p>
                        <p style="width: 369px; margin-left: 15px">Ediblee is created to help people around the world provide food recipes based on your available ingredients </p>
                        <p style="width: 379px; margin-left: 15px">Launched in 2023, created by J3 Ediblee is a constantly expanding platform providing information on a range of topics. </p>
                    </div>
                </div>
                <div id="Form-page">
                    <form id="form" runat="server">
                        <img id="logo" src="../Asset/image 2 (1).png"/>
                        <p>Register Page</p>
                        <asp:Label ID="Label1" runat="server" Text="Username"></asp:Label> 
                        <asp:TextBox ID="UsernameTxt" runat="server" ></asp:TextBox>
                        <asp:Label ID="Label2" runat="server" Text="Email Address"></asp:Label>
                        <asp:TextBox ID="EmailTxt" runat="server" ></asp:TextBox>
                        <asp:Label ID="Label3" runat="server" Text="Password"></asp:Label>
                        <asp:TextBox ID="Pw1" runat="server" TextMode="Password" ></asp:TextBox>
                        <asp:Label ID="Label4" runat="server" Text="Confirm Password"></asp:Label>
                        <asp:TextBox ID="Pw2" runat="server" TextMode="Password" ></asp:TextBox>
                        <asp:Button ID="RegButton" runat="server" Text="Confirm" OnClick="RegButton_Click" />
                        <asp:Label ID="StatusLbl" runat="server" Text=""></asp:Label>
                    </form>
                </div>  
            </div>
        </div>
    </div>
</body>
</html>
