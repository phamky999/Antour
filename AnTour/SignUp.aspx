<%@ Page Language="C#" EnableEventValidation="false" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" Inherits="AnTour.SignUp" %>

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
    <title>Đăng Ký</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="content" style="padding: 4rem 0;">
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
                                            <h3>Đăng Ký:</h3>

                                        </div>
                                        <form action="#" method="post">
                                            <div class="form-group first">
                                                <asp:TextBox ID="txtHoTen" type="text" CssClass="form-control col" placeholder="Họ Tên" runat="server"></asp:TextBox>
                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="txtHoTen" runat="server" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                                            </div>
                                            
                                            <div class="form-group" style="font-size: 14px;">
                                                <asp:DropDownList ID="ddlGioiTinh" CssClass="form-control" runat="server"></asp:DropDownList>

                                            </div>
                                            <div class="form-group ">
                                                <asp:TextBox ID="txtcmtnd" type="text" CssClass="form-control" placeholder="Số Chứng Minh Thư Nhân Dân" runat="server"></asp:TextBox>
                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" ControlToValidate="txtcmtnd" runat="server" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                                                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" ControlToValidate="txtcmtnd" ValidationExpression="^[0-9]{9}$" runat="server" ErrorMessage="*" ForeColor="Red"></asp:RegularExpressionValidator>
                                            </div>
                                            <div class="form-group ">
                                                <asp:TextBox ID="txtSdt" type="text" CssClass="form-control" placeholder="Số Điện Thoại" runat="server"></asp:TextBox>
                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" ControlToValidate="txtSdt" runat="server" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                                                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" ControlToValidate="txtSdt" ValidationExpression="^[0-9]{10}$" runat="server" ErrorMessage="Số Điện Thoại Di Động Có 10 số" ForeColor="Red"></asp:RegularExpressionValidator>
                                            </div>
                                            <div class="form-group ">
                                                <asp:TextBox ID="txtEmail" type="email" CssClass="form-control" placeholder="Email" runat="server"></asp:TextBox>
                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" ControlToValidate="txtEmail" runat="server" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                                                <asp:RegularExpressionValidator ID="RegularExpressionValidator3" ControlToValidate="txtEmail" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" runat="server" ErrorMessage="Email sai định dạng" ForeColor="Red"></asp:RegularExpressionValidator>
                                            </div>
                                            <div class="form-group">
                                                <asp:TextBox ID="txtaddr" type="text" CssClass="form-control" TextMode="multiline" Rows="2" placeholder="Địa Chỉ" runat="server"></asp:TextBox>
                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ControlToValidate="txtaddr" runat="server" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                                            </div>
                                            <div class="form-group ">
                                                <asp:TextBox ID="txtUser" type="text" CssClass="form-control" placeholder="Tài Khoản" runat="server"></asp:TextBox>
                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" ControlToValidate="txtUser" runat="server" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                                                <%--<asp:RegularExpressionValidator ID="RegularExpressionValidator4" ControlToValidate="txtUser" ValidationExpression="^[a-zA-Z][a-zA-Z0-9]{3,9}$" runat="server" ErrorMessage="Tài Khoản Không Hợp Lệ" ForeColor="Red"></asp:RegularExpressionValidator>--%>
                                            </div>
                                            <div class="form-group">
                                                <asp:TextBox ID="txtPass" type="password" CssClass="form-control" placeholder="Mật Khẩu" runat="server"></asp:TextBox>
                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator7" ControlToValidate="txtPass" runat="server" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                                                <%--<asp:RegularExpressionValidator ID="RegularExpressionValidator5" ControlToValidate="txtPass"  ValidationExpression="^[a-zA-Z][a-zA-Z0-9]{5,15}$" runat="server" ErrorMessage="Mật Khẩu Không Hợp Lệ" ForeColor="Red"></asp:RegularExpressionValidator>--%>
                                            </div>
                                            <div class="form-group last mb-4">
                                                <asp:TextBox ID="txtRePass" type="password" CssClass="form-control" placeholder="Nhập Lại Mật Khẩu" runat="server"></asp:TextBox>
                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator8" ControlToValidate="txtRePass" runat="server" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                                                <asp:CompareValidator ID="CompareValidator1" ControlToValidate="txtPass" ControlToCompare="txtRePass" runat="server" ErrorMessage="Mật Khẩu Không Khớp" ForeColor="Red"></asp:CompareValidator>
                                            </div>

                                            <div class="d-flex mb-5 align-items-center">

                                                <span class="ml-auto"><a href="Login.aspx" class="forgot-pass">Hoặc Đăng Nhập?</a></span>
                                            </div>
                                            <asp:Literal ID="ltlMessage" runat="server"></asp:Literal>
                                            <asp:Button ID="btnSignup" runat="server" class="btn btn-pill text-white btn-block btn-primary mt-2" Text="Đăng Ký" OnClick="btnSignup_Click"/>

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




    <!-- Optional JavaScript -->
    <!-- jQuery first, then Popper.js, then Bootstrap JS -->
    <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/4.6.0/js/bootstrap.min.js"></script>

</body>
</html>
