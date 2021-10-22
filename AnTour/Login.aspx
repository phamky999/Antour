<%@ Page Language="C#" EnableEventValidation="false" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="AnTour.Login" %>

<!DOCTYPE html>

<html lang="en">
<head>
    <!-- Required meta tags -->
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <link rel="preconnect" href="https://fonts.gstatic.com">
    <link href="https://fonts.googleapis.com/css2?family=Lato:wght@300;400&family=Poppins:wght@300;400&family=Roboto:wght@300;400;700&display=swap" rel="stylesheet">
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.15.2/css/all.min.css" />
    <!-- Bootstrap CSS -->
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/4.6.0/css/bootstrap.min.css">
    <!-- Style -->
    <link href="assets/css/StyleLogin.css" rel="stylesheet" />
    <title>Đăng Nhập</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="content">
                <div class="container">
                    <div class="row justify-content-center">
                        <!-- <div class="col-md-6 order-md-2">
          <img src="images/undraw_file_sync_ot38.svg" alt="Image" class="img-fluid">
        </div> -->
                        <div class="col-md-6 contents">
                            <div class="row justify-content-center">
                                <div class="col-md-12">
                                    <div class="form-block">
                                        <div class="mb-4">
                                            <h3>Đăng Nhập <strong>AnTour</strong></h3>

                                        </div>
                                        <form action="#" method="post">
                                            <div class="form-group first">
                                                <asp:TextBox ID="txtUsername" CssClass="form-control" runat="server" placeholder="Tài Khoản"></asp:TextBox>
                                            </div>
                                            <div class="form-group last mb-4">

                                                <asp:TextBox type="password" ID="txtPassword" CssClass="form-control" runat="server" placeholder="Mật Khẩu"></asp:TextBox>
                                            </div>

                                            <div class="d-flex mb-5 align-items-center">

                                                <span class=" ml-0 mb-0"><a href="SignUp.aspx" class="forgot-pass">Đăng Ký</a></span>

                                                <span class="ml-auto"><a href="#" class="forgot-pass">Quên Mật Khẩu?</a></span>
                                            </div>
                                            <asp:Literal ID="ltlMsg" runat="server"></asp:Literal>
                                            <asp:Button ID="btnLogin" runat="server" CssClass="btn btn-pill text-white btn-block btn-primary" Text="Đăng Nhập" OnClientClick="return validateFormLogin();" OnClick="btnLogin_Click"/>
                                            <%--<span class="d-block text-center my-4 text-muted">Hoặc:</span>

                                            <div class="social-login text-center">
                                                <a href="#" class="facebook">
                                                    <span class="icon-facebook mr-3"><i class="fab fa-facebook-f"></i></span>
                                                </a>
                                                <a href="#" class="twitter">
                                                    <span class="icon-twitter mr-3"><i class="fab fa-twitter"></i></span>
                                                </a>
                                                <a href="#" class="google">
                                                    <span class="icon-google mr-3"><i class="fab fa-google"></i></span>
                                                </a>
                                            </div>--%>
                                        </form>
                                    </div>
                                </div>
                            </div>

                        </div>

                    </div>
                </div>
            </div>
        </div>
    </form>
    <script>
        function validateFormLogin() {
            var user = document.getElementById("txtUsername").value;
            var pass = document.getElementById("txtPassword").value;
            if (user.trim() == "") {
                alert("Tên Đăng Nhập Không Được Để Trống!");
                document.getElementById("txtUsername").focus();
            }
            else if (pass.trim() == "") {
                alert("Mật Khẩu Không Được Để Trống!");
                document.getElementById("txtPassword").focus();
            }
        }
    </script>

    <!-- Optional JavaScript -->
    <!-- jQuery first, then Popper.js, then Bootstrap JS -->
    <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/4.6.0/js/bootstrap.min.js"></script>
</body>
</html>
