/*txtHoTen,txtcmtnd,txtSdt,txtEmail,txtaddr,txtUser,txtPass,txtRePass */
function validateFormSignUp() {
    var hoten = document.getElementById("txtHoTen").value;
    var cmtnd = document.getElementById("txtcmtnd").value;
    var sdt = document.getElementById("txtSdt").value;
    var email = document.getElementById("txtEmail").value;
    var addr = document.getElementById("txtaddr").value;
    var user = document.getElementById("txtUser").value;
    var pass = document.getElementById("txtPass").value;
    var repass = document.getElementById("txtRePass").value;
    if (hoten.trim() == "") {
        alert("Họ Tên Không Được Để Trống!");
    }
    else if (cmtnd.trim() == "") {
        alert("Số CMTND Không Được Để Trống!");
    }
    else if (sdt.trim() == "") {
        alert("Số Điện Thoại Không Được Để Trống!");
    }
    else if (email.trim() == "") {
        alert("Email Không Được Để Trống!");
    }
    else if (addr.trim() == "") {
        alert("Địa Chỉ Không Được Để Trống!");
    }
    else if (user.trim() == "") {
        alert("Tên Đăng Nhập Không Được Để Trống!");
    }
    else if (pass.trim() == "") {
        alert("Mật Khẩu Không Được Để Trống!");
    }
    else if (repass.trim() == "") {
        alert("Mật Khẩu Không Được Để Trống!");
    }

}
