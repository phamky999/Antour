<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UserLoad.ascx.cs" Inherits="AnTour.cms.display.CaNhan.UserLoad" %>
<div class="box-user">
    <div class="container">
        <div class="row">
            <div class="col-12 col-sm-4 col-md-3">
                <ul class="nav flex-column box-nav">

                    <li class="nav-item">Quản Lý Tài Khoản:
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="default.aspx?modul=CaNhan&modulphu=TaiKhoan&thaotac=HienThi"><i class="far fa-id-card"></i>&nbsp;Thông Tin Cá Nhân</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="default.aspx?modul=CaNhan&modulphu=TaiKhoan&thaotac=Edit"><i class="fas fa-user-edit"></i>&nbsp;Chỉnh Sửa Hồ Sơ</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="default.aspx?modul=CaNhan&modulphu=TaiKhoan&thaotac=RePass"><i class="far fa-edit"></i>&nbsp;Đổi Mật Khẩu</a>
                    </li>
                    <li class="nav-item mt-5">Quản Lý Đơn Hàng:
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="default.aspx?modul=CaNhan&modulphu=PhieuDat&thaotac=HienThi"><i class="fas fa-file-invoice"></i>&nbsp;Tour Của Tôi</a>
                    </li>

                </ul>
            </div>
            <div class="col-12 col-sm-8 col-md-9">
                <asp:PlaceHolder ID="userloadcontrol" runat="server"></asp:PlaceHolder>
            </div>

        </div>
    </div>
</div>
<style>
    .box-user {
        padding-top: 100px;
        padding-bottom:90px;
    }

    .box-user, .box-nav a {
        font-size: 16px;
        font-family: 'Poppins', sans-serif;
        color:#333;
    }
</style>
