<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm4.aspx.cs" Inherits="Bai1.WebForm4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <%
                string name = Request.Form["name"];
                TextBox tage = (TextBox)PreviousPage.FindControl("age");
                RadioButtonList rgender = (RadioButtonList)PreviousPage.FindControl("gender");
                DropDownList ddladdress = (DropDownList)PreviousPage.FindControl("address");
                CheckBoxList chksubject = (CheckBoxList)PreviousPage.FindControl("subject");
                %>
            Name : <%= name %><br />
            Ade : <%= tage.Text %><br />
            Gender : <%= rgender.Text %><br />
            Address : <%= ddladdress.Text %><br />
            Subject : <%= chksubject.Text %><br />
        </div>
    </form>
</body>
</html>
