<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Bai1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Thông tin nhân viên</title>
    <style type="text/css">
        label{
            width: 120px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" action="WebForm2.aspx">
        <div>
            <h2>Thông tin nhân viên</h2>
            <p>
                <label>Mã nhân viên</label>
                <input type ="text" name="manv" />
            </p>
            <p>
                <label>Họ tên</label>
                <input type ="text" name="hoten" />
            </p>
            <p>
                <label>Giới tính</label>
                <input type ="radio" name="gender" value="nam" />Nam
                <input type ="radio" name="gender" value="nu"/>Nữ
            </p>
             <p>
                <label>Ngoại ngữ</label>
                <input type ="checkbox" name="subject" value="anh" />Anh
                <input type ="checkbox" name="subject" value="phap"/>Phap
                <input type ="checkbox" name="subject" value="nga"/>Nga
            </p>
            <p>
                <label>Bậc lương</label>
                <input type ="text" name="luong" />
            </p>
            <p>
                <label>Số ngày công</label>
                <input type ="text" name="ngaycong" />
            </p>
            <p>
                <label>Chức vụ</label>
                <select name="role">
                    <option value="tp">Trưởng phòng</option>
                    <option value="pp">Phó phòng</option>
                    <option value="nv">Nhân viên</option>
                </select>
            </p>
            <p>
                <input style="margin-left:120px" type="submit" value="Tính lương" />
                <input type="reset" value="Nhập lại" />
            </p>

        </div>
    </form>
</body>
</html>
