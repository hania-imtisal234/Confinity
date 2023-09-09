<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm4.aspx.cs" Inherits="db_projectt.WebForm4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br>
            <br>
        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            
            <br>
            <br>
A password TextBox:
<asp:TextBox ID="txtPassword" TextMode="password" runat="server"></asp:TextBox>
            
            <br>
            <br>
A TextBox with text:
<asp:TextBox ID="txtTextValue" Text="Hello World!" runat="server"></asp:TextBox>

            
            <br>
            <br>

A multiline TextBox:
<asp:TextBox ID="txtComment" TextMode="multiline" runat="server"></asp:TextBox>
            
            <br>
            <br>
Checkbox
<asp:CheckBox ID="chkIsStudent" runat="server" />
            
            <br>
            <br>
Radio Button
<asp:RadioButton ID="rdMale" GroupName="Gender" runat="server" />
<asp:RadioButton ID="rdFemale" GroupName="Gender" runat="server" />
            
            <br>
            <br>

Dropdown List
<asp:DropDownList ID="ddlDepartment" runat="server">
<asp:ListItem Text="Select" Value="0"></asp:ListItem>
<asp:ListItem Text="Computer Science" Value="CS"></asp:ListItem>
<asp:ListItem Text="Electrical Engineering" Value="EE"></asp:ListItem>
<asp:ListItem Text="Business Administrator" Value="BBA"></asp:ListItem>
<asp:ListItem Text="Civil Engineering" Value="CV"></asp:ListItem>
</asp:DropDownList>
            
            <br>
            <br>
Button
<asp:Button ID="btnSave" Text="Save Form" runat="server" />
            
            <br>
            <br>
Image
<asp:Image ID="Image2"  ImageUrl="https://auth.gfx.ms/images/ms-logo.png"  runat="server" />



        </div>
    </form>
</body>
</html>
