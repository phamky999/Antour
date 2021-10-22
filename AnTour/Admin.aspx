<%@ Page Language="C#" EnableEventValidation="false" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="AnTour.Admin" %>


<!doctype html>
<html lang="en">
<head>
    <title>AdminPage</title>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">

    <link href="https://fonts.googleapis.com/css?family=Poppins:300,400,500,600,700,800,900" rel="stylesheet">
    <%--<link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css">
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.15.2/css/all.min.css">--%>
    <link href="assets/css/all.min.css" rel="stylesheet" />
    <link href="assets/css/StyleAdmin.css" rel="stylesheet" />
    <link href="assets/css/StyleAdmin_1.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">

        <%-- left panel --%>
        <div class="wrapper d-flex align-items-stretch" >
            <nav id="sidebar" >
                <div class="p-3 pt-5">
                    <a href="#" class="img logo rounded-circle mb-5" style="background-image: url(assets/imgs/logo.jpg);"></a>
                    <ul class="list-unstyled components mb-5">
                        <li>
                            <a href="#profile" data-toggle="collapse" aria-expanded="false" class="dropdown-toggle"><i class="fas fa-user-cog mr-2"></i>Cá Nhân</a>
                            <ul class="collapse list-unstyled" id="profile">
                                <li>
                                    <a href="#"><i class="far fa-user mr-2"></i>Hồ Sơ</a>
                                </li>
                                
                                <li>
                                    <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click1"><i class="fas fa-power-off mr-2"></i>Đăng Xuất</asp:LinkButton>

                                </li>
                            </ul>
                        </li>
                        <li>
                            <a href="#bookingtour" data-toggle="collapse" aria-expanded="false" class="dropdown-toggle"><i class="fas fa-file-invoice-dollar mr-2"></i>Phiếu Đặt</a>
                            <ul class="collapse list-unstyled" id="bookingtour">
                                <li>
                                    <a href="Admin.aspx?modul=PhieuDat&thaotac=HienThi"><i class="fas fa-list mr-2"></i>Danh Sách</a>
                                </li>

                            </ul>
                        </li>
                        <li>
                            <a href="#tour" data-toggle="collapse" aria-expanded="false" class="dropdown-toggle"><i class="fab fa-product-hunt mr-2"></i>Tour</a>
                            <ul class="collapse list-unstyled" id="tour">
                                <li>
                                    <a href="Admin.aspx?modul=Tour&thaotac=HienThi"><i class="fas fa-list mr-2"></i>Danh Sách</a>
                                </li>
                                
                                <li>
                                    <a href="Admin.aspx?modul=Tour&thaotac=ThemMoi"><i class="fas fa-plus-circle mr-2"></i>Thêm Mới</a>
                                </li>
                                <li>
                                    <a href="Admin.aspx?modul=Tour&thaotac=ChinhSua"><i class="fas fa-edit mr-2"></i>Chỉnh Sửa</a>
                                </li>
                            </ul>
                        </li>
                        <li>
                            <a href="Admin.aspx?modul=KhachHang"><i class="fas fa-users mr-2"></i>Khách Hàng</a>
                        </li>
                        <li>
                            <a href="#nhanvien" data-toggle="collapse" aria-expanded="false" class="dropdown-toggle"><i class="fas fa-house-user mr-2"></i>Nhân Viên</a>
                            <ul class="collapse list-unstyled" id="nhanvien">
                                <li>
                                    <a href="Admin.aspx?modul=NhanVien&thaotac=HienThi"><i class="fas fa-list mr-2"></i>Danh Sách</a>
                                </li>
                                <li>
                                    <a href="Admin.aspx?modul=NhanVien&thaotac=ThemMoi"><i class="fas fa-plus-circle mr-2"></i>Thêm Mới</a>
                                </li>
                                <li>
                                    <a href="Admin.aspx?modul=NhanVien&thaotac=AdEdit"><i class="fas fa-user-edit mr-2"></i>Chỉnh Sửa</a>
                                </li>

                            </ul>
                        </li>
                        <li>
                            <a href="#resport" data-toggle="collapse" aria-expanded="false" class="dropdown-toggle"><i class="fas fa-chart-bar mr-2"></i> Thống Kê</a>
                            <ul class="collapse list-unstyled" id="resport">
                                <li>
                                    <a href="Admin.aspx?modul=Report&modulphu=DoanhThu&thaotac=HienThi"><i class="fas fa-file-invoice-dollar mr-2"></i>Doanh Thu</a>
                                </li>
                                

                            </ul>
                        </li>
                        <li>
                            <a href="Default.aspx"><i class="fas fa-home mr-2"></i>Trang Chủ</a>
                        </li>
                    </ul>

                    <div class="footer">
                        <p>
                            <!-- Link back to Colorlib can't be removed. Template is licensed under CC BY 3.0. -->
                            Copyright &copy;<script>document.write(new Date().getFullYear());</script>
                            All rights reserved 
						  <!-- Link back to Colorlib can't be removed. Template is licensed under CC BY 3.0. -->
                        </p>
                    </div>

                </div>
            </nav>

            <!-- Page Content  -->
            <div id="content" class="p-2 p-md-3">

                <nav class="navbar navbar-expand-lg navbar-light bg-light">
                    <div class="container-fluid">
                        <button type="button" id="sidebarCollapse" class="btn btn-primary">
                            <i class="fa fa-bars"></i>
                            <span class="sr-only">Toggle Menu</span>
                        </button>
                        <button class="btn btn-dark d-inline-block d-lg-none ml-auto" type="button" data-toggle="collapse" data-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
                            <i class="fa fa-bars"></i>
                        </button>
                        <div class="collapse navbar-collapse" id="navbarSupportedContent">
                            <ul class="nav navbar-nav ml-auto">
                                <li class="nav-item">
                                    <a class="nav-link" href="#">Xin Chào: <asp:Literal ID="ltlName" runat="server"></asp:Literal></a>
                                </li>
                            </ul>
                        </div>
                    </div>
                </nav>

                <%-- Main Content --%>
                <asp:Literal ID="ltlTitle" runat="server"><h2 class="mb-4">Trang Admin</h2></asp:Literal>

                <asp:PlaceHolder ID="plLoadControl" runat="server"></asp:PlaceHolder>
            </div>

        </div>
    </form>
    <!-- Optional JavaScript -->
    <!-- jQuery first, then Popper.js, then Bootstrap JS -->
    <script src="assets/js/all.min.js"></script>
    <script src="assets/js/jquery-3.1.1.min.js"></script>
    <script src="assets/js/popper.min.js"></script>
    <script src="assets/js/bootstrap.min.js"></script>
    <%--<script src="https://code.jquery.com/jquery-3.3.1.slim.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/4.6.0/js/bootstrap.min.js"></script>--%>
    <script src="assets/js/main.js"></script>
</body>
</html>
