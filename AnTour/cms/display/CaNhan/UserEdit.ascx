<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UserEdit.ascx.cs" Inherits="AnTour.cms.display.CaNhan.UserEdit" %>
<div class="container" style="overflow: hidden">
    <h3 class="htitle">Chỉnh Sửa Thông Tin Cá Nhân: </h3>
    <table style="margin-bottom:30px;">
        <tr>
            <td>Họ Tên: 
            </td>
            <td>
                <asp:TextBox ID="txtHoten" cssClass="form-control" runat="server"></asp:TextBox>
                
            </td>
            <td>Giới Tính:
            </td>
            <td>
                <asp:DropDownList ID="ddlGioiTinh" cssClass="form-control" runat="server"></asp:DropDownList>
                
            </td>
        </tr>
  
        <tr>
            <td>Số CMTND: 
            </td>
            <td>
                <asp:TextBox ID="txtCmtnd" type="text" cssClass="form-control" runat="server"></asp:TextBox>
                
            </td>
            <td>Số Điện Thoại:  
            </td>
            <td>
                <asp:TextBox ID="txtSdt" type="text" cssClass="form-control" runat="server"></asp:TextBox>
                
            </td>
        </tr>
        
        <tr>
            <td>Email: 
            </td>
            <td>
                <asp:TextBox ID="txtEmail" type="email" cssClass="form-control" runat="server"></asp:TextBox>
                
            </td>
            <td>Địa Chỉ 
            </td>
            <td>
                <asp:TextBox ID="txtDiachi" type="text" cssClass="form-control" runat="server"></asp:TextBox>
                
            </td>
        </tr>
        
        </table>
    <table>
        <h4 class="htitle">
            Nhập thông tin đăng nhập để xác nhận:
        </h4>
        <tr>
            <td>Tài Khoản:
            </td>
            <td>
                <asp:TextBox ID="txtTenDN" CssClass="form-control" runat="server"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator3" ControlToValidate="txtTenDN" ForeColor="Red" runat="server" ErrorMessage="*"></asp:RequiredFieldValidator>
                
            </td>
        </tr>
        <tr>
            <td>Mật Khẩu: 
            </td>
            <td>
                <asp:TextBox ID="txtMK" type="password" CssClass="form-control" runat="server"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator2" ControlToValidate="txtMK" ForeColor="Red" runat="server" ErrorMessage="*"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>
            </td>
            <td>
                <asp:Button ID="btnHuy" CssClass="btn btn-danger mt-3 mr-5" runat="server" Text="Hủy" CausesValidation="false" OnClick="btnHuy_Click"  />
                <asp:Button ID="btnLuu" CssClass="btn btn-primary mt-3" runat="server" Text="Lưu" OnClick="btnLuu_Click" />
                
            </td>
        </tr>
    </table>
    <asp:Literal ID="ltlMsg" runat="server"></asp:Literal>
</div>

<style>
    .htitle{
        margin-bottom:20px;
    }
    
    div table tr {
        margin-bottom: 10px;
    }

    div table tr td {
        padding-bottom: 10px;
        padding-right: 20px;
    }
    
</style>
