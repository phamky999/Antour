<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ListKH.ascx.cs" Inherits="AnTour.cms.admin.KhachHang.ListKH" %>
<div class="table-responsive">
    <table class="table table-bordered table-hover">
        <thead>
            <tr>
                <th scope="col">Mã KH</th>
                <th scope="col">Họ Tên</th>
                <th scope="col">Giới Tính</th>
                <th scope="col">CMTND</th>
                <th scope="col">SDT</th>
                <th scope="col">Email</th>
                <th scope="col">Địa Chỉ</th>
                <th scope="col">Tài Khoản</th>
            </tr>
        </thead>
        <tbody>
            <asp:Literal ID="ltlKhachHang" runat="server"></asp:Literal>

        </tbody>
    </table>
</div>