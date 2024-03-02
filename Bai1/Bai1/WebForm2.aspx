<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="Bai1.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            //format : crl + k + d
            <h2>Tính lương nhân viên</h2>
            <%
                string manv = Request.Form["manv"];
                string hoten = Request.Form["hoten"];
                string gender = Request.Form["gender"];
                string ngoaingu = Request.Form["subject"];
                int luongcb = 800000;
                string luong = Request.Form["luong"];
                string ngaycong = Request.Form["ngaycong"];
                string chucvu = Request.Form["role"];
                int phucap;
                if (chucvu == "tp") phucap = 500000;
                else if (chucvu == "pp") phucap = 300000;
                else phucap = 100000;

                int thuong = 0;
                if (int.Parse(ngaycong) > 25) thuong = (30 - int.Parse(ngaycong)) * 200000;

                int tongluong = int.Parse(luong) * luongcb + thuong + phucap;

                %>

                <table>
                    <tr>
                        <td>Mã nhân viên</td>
                        <td><%= manv  %></td>
                    </tr>
                     <tr>
                        <td>Họ tên</td>
                        <td><%= hoten  %></td>
                    </tr>
                     <tr>
                        <td>Giới tính</td>
                        <td><%= gender  %></td>
                    </tr>
                     <tr>
                        <td>Ngoại ngữ</td>
                        <td><%= ngoaingu %></td>
                    </tr>
                     <tr>
                        <td>Bậc lương</td>
                        <td><%= luong  %></td>
                    </tr>
                    <tr>
                        <td>Lương cơ bản</td>
                        <td><%= luongcb %></td>
                    </tr>
                    <tr>
                        <td>Ngày công</td>
                        <td><%= ngaycong  %></td>
                    </tr>
                    <tr>
                        <td>Chức vụ</td>
                        <td><%= chucvu %></td>
                    </tr>
                    <tr>
                        <td>Phụ cấp</td>
                        <td><%= phucap  %></td>
                    </tr>
                    <tr>
                        <td>Thưởng</td>
                        <td><%= thuong  %></td>
                    </tr>
                    <tr>
                        <td>Tổng lương</td>
                        <td><%= tongluong  %></td>
                    </tr>

                </table>
        </div>
    </form>
</body>
</html>
