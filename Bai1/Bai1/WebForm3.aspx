<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="Bai1.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server" >
        <div>
            <h2>Student Input</h2>
            <p>
                <label>Name: </label>
                <asp:TextBox ID="name" runat="server"/>
            </p>
            <p>
                <label>Age: </label>
                <asp:TextBox ID="age" runat="server" />
            </p>
            <p>
                <label>Gender: </label>
                <asp:RadioButtonList ID="gender" runat="server">
                    <asp:ListItem Text="Male" Value="male" Selected="True" />
                    <asp:ListItem Text="Female" Value="female" />
                </asp:RadioButtonList>
            </p>
            <p>
                <label>Address: </label>
                <asp:DropDownList ID="address" runat="server">
                    <asp:ListItem Text="Ha Noi" Value="hn" Selected="True" />
                    <asp:ListItem Text="Hai Phong" Value="hp" />
                    <asp:ListItem Text="Quang Ninh" Value="qn" />
                </asp:DropDownList>
            </p>
            <p>
                <label>Subject: </label>
                <asp:CheckboxList ID="subject" runat="server">
                    <asp:ListItem Text="LT PHP" Value="php" Selected="True" />
                    <asp:ListItem Text="LT ASP" Value="asp" />
                    <asp:ListItem Text="CSDL" Value="csdl" />
                </asp:CheckboxList>
            </p>
            <p>
                <asp:Button ID="b1" Text="Send" runat="server" PostBackUrl="~/WebForm4.aspx" />
                <asp:Button ID="b2" Text="Cancel" runat="server" />
            </p>
        </div>
    </form>
</body>
</html>
