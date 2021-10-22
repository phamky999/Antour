<%@ Page Language="C#" EnableEventValidation="false" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="AnTour.Default" %>

<%@ Register Src="~/cms/display/DisplayLoad.ascx" TagPrefix="uc1" TagName="DisplayLoad" %>




<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" class="no-js" lang="en">
<head>
    <!-- META DATA -->
    <meta charset="utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <!-- The above 3 meta tags *must* come first in the head; any other head content must come *after* these tags -->

    <!--font-family-->
    <link href="https://fonts.googleapis.com/css?family=Rufina:400,700" rel="stylesheet" />

    <link href="https://fonts.googleapis.com/css?family=Poppins:100,200,300,400,500,600,700,800,900" rel="stylesheet" />
    <link rel="preconnect" href="https://fonts.gstatic.com" />
    <link href="https://fonts.googleapis.com/css2?family=Roboto:wght@300;400;500;700&display=swap" rel="stylesheet" />
    <!-- TITLE OF SITE -->
    <title>AnTour</title>


    <!--bootstrap.min.css-->

    <%--<link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.15.2/css/all.min.css" />
    
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" />--%>
    <link href="assets/css/all.min.css" rel="stylesheet" />
    <link href="assets/css/bootstrap.min.css" rel="stylesheet" />
    <link href="assets/css/default.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <!-- main-menu Start -->
            <nav class="navbar fixed-top navbar-expand-md navbar-light bg-light">
                <div class="container">
                    <a class="navbar-brand" href="#">
                        <h3>An<span class="text-success">Tour.</span></h3>
                    </a>
                    <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarNav">
                        <span class="navbar-toggler-icon"></span>
                    </button>
                    <div class="collapse navbar-collapse" id="navbarNav">
                        <ul class="navbar-nav mr-auto">
                            <li class="nav-item">
                                <a class="nav-link" href="Default.aspx?modul=Home">Trang Chủ</a>
                            </li>
                            <li class="nav-item">
                                <asp:LinkButton ID="lbtnAdmin" CssClass="nav-link" runat="server" Visible="false" OnClick="lbtnAdmin_Click">Trang Quản Trị</asp:LinkButton>

                            </li>
                            <li class="nav-item">
                                <a class="nav-link" href="Default.aspx?modul=Tours&modulphu=List">Tour</a>
                            </li>

                        </ul>
                        <ul class="navbar-nav ml-auto">
                            <li class="nav-item">
                                <asp:LinkButton ID="lbtnUser" runat="server" CssClass="nav-link" OnClick="lbtnUser_Click">Cá Nhân</asp:LinkButton>
                            </li>
                            <li class="nav-item">
                                <asp:LinkButton ID="lbtnLogout" runat="server" CssClass="nav-link" OnClick="lbtnLogout_Click">Đăng Xuất</asp:LinkButton>
                            </li>
                            <li class="nav-item">
                                <asp:LinkButton ID="lbtnSignup" runat="server" CssClass="nav-link" OnClick="lbtnSignup_Click">Đăng Ký</asp:LinkButton>
                            </li>
                            <li class="nav-item">
                                <asp:Button ID="btnLogin" CssClass="btn btn-primary" runat="server" Text="Đăng Nhập" OnClick="btnLogin_Click" />
                            </li>
                        </ul>
                    </div>
                </div>
            </nav>
            <!-- main-menu End -->

            <div class="main-content container"></div>
            <uc1:DisplayLoad runat="server" ID="DisplayLoad1" />

            <!-- Footer Start -->
            <footer class=" bg-light">
                <div class="footer-top bg-light">
                    <div class="container">
                        <div class="row">
                            <div class="col-md-3 footer-about wow fadeInUp">
                                <h3>An<span class="text-success">Tour.</span></h3>
                                <p>
                                    Công ty du lịch Việt.
                                </p>
                                <p>&copy; 2021.</p>
                            </div>
                            <div class="col-md-4 offset-md-1 footer-contact wow fadeInDown">
                                <h3>Liên Hệ</h3>
                                <p><i class="fas fa-map-marker-alt"></i>96 Định Công, Phương Liệt, Thanh Xuân, Hà Nội</p>
                                <p><i class="fas fa-phone"></i>Phone: 024 68686868</p>
                                <p><i class="fas fa-envelope"></i>Email: <a href="#<%--mailto:antour@gmail.com--%>">antour@gmail.com</a></p>
                                <p><i class="fab fa-skype"></i>Skype: you_online</p>
                            </div>
                            <div class="col-md-4 footer-links wow fadeInUp">
                                <div class="row">
                                    <div class="col">
                                        <h3>Links</h3>
                                    </div>
                                </div>
                                <div class="row">
                                    <div class="col-md-6">
                                        <p><a class="scroll-link" href="Default.aspx">Home</a></p>
                                        <p><a href="Default.aspx?modul=Tours&modulphu=List">Tour</a></p>
                                    </div>
                                    <div class="col-md-6">
                                        <p><a href="#">Plans &amp; pricing</a></p>
                                        <p><a href="#">Affiliates</a></p>
                                        <p><a href="#">Terms</a></p>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="footer-bottom">
                    <div class="container">
                        <div class="row">
                            <div class="col footer-social">
                                <a href="#"><i class="fab fa-facebook-f"></i></a>
                                <a href="#"><i class="fab fa-twitter"></i></a>
                                <a href="#"><i class="fab fa-google-plus-g"></i></a>
                                <a href="#"><i class="fab fa-instagram"></i></a>
                                <a href="#"><i class="fab fa-pinterest"></i></a>
                            </div>
                        </div>
                    </div>
                </div>
            </footer>
            <!-- Footer End -->
        </div>


    </form>
    <script src="assets/js/all.min.js"></script>
    <script src="assets/js/jquery-3.1.1.min.js"></script>
    <script src="assets/js/popper.min.js"></script>
    <script src="assets/js/bootstrap.min.js"></script>
    <%--<script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.12.9/umd/popper.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js"></script>--%>
</body>
</html>
