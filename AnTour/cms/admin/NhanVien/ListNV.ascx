<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ListNV.ascx.cs" Inherits="AnTour.cms.admin.NhanVien.ListNV" %>
<div id="table-wrapper">
    <div class="table-responsive" id="table-scroll">
        <table class="table table-bordered table-hover">
            <thead>
                <tr>
                    <th scope="col">Mã NV</th>
                    <th scope="col">Họ Tên</th>
                    <th scope="col">Giới Tính</th>
                    <th scope="col">CMTND</th>
                    <th scope="col">SDT</th>
                    <th scope="col">Email</th>
                    <th scope="col">Địa Chỉ</th>
                    <th scope="col">Tài Khoản</th>
                    <th scope="col">Quyền</th>
                    <th scope="col">Trạng Thái</th>
                    <th scope="col">Tác Vụ</th>
                </tr>
            </thead>
            <tbody>
                <asp:Literal ID="ltlLoadListNV" runat="server"></asp:Literal>

            </tbody>
        </table>
    </div>
</div>
