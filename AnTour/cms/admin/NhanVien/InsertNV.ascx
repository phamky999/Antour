<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="InsertNV.ascx.cs" Inherits="AnTour.cms.admin.NhanVien.InsertNV" %>
<div>
    <asp:Literal ID="ltlMsg" runat="server"></asp:Literal>
    <div class="form-row mb-3 mt-3">

        <div class="col-9">
            <asp:TextBox ID="txtHoten" type="text" CssClass="form-control" placeholder="Họ Tên" runat="server"></asp:TextBox>
        </div>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ControlToValidate="txtHoten" ForeColor="Red" runat="server" ErrorMessage="*"></asp:RequiredFieldValidator>
        <div class="col pr-3">
            <asp:DropDownList ID="ddlGioitinh" CssClass="form-control mr-3" runat="server"></asp:DropDownList>

        </div>
    </div>
    <div class="form-row mb-3">
        <div class="col">
            <asp:TextBox ID="txtSdt" type="text" CssClass="form-control" placeholder="Số Điện Thoại" runat="server"></asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" ControlToValidate="txtSdt" ValidationExpression="^[0-9]{10}$" runat="server" ErrorMessage="Số Điện Thoại Di Động Có 10 số" ForeColor="Red"></asp:RegularExpressionValidator>
        </div>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" ControlToValidate="txtSdt" ForeColor="Red" runat="server" ErrorMessage="*"></asp:RequiredFieldValidator>
        <div class="col">
            <asp:TextBox ID="txtCmtnd" type="text" CssClass="form-control" placeholder="Số Chứng Minh Thư" runat="server"></asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" ControlToValidate="txtCmtnd" ValidationExpression="^[0-9]{9}$" runat="server" ErrorMessage="*" ForeColor="Red"></asp:RegularExpressionValidator>
        </div>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" ControlToValidate="txtCmtnd" ForeColor="Red" runat="server" ErrorMessage="*"></asp:RequiredFieldValidator>
    </div>
    <div class="form-row mb-3">
        <div class="col">
            <asp:TextBox ID="txtEmail" type="email" CssClass="form-control" placeholder="Email" runat="server"></asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator3" ControlToValidate="txtEmail" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" runat="server" ErrorMessage="Email sai định dạng" ForeColor="Red"></asp:RegularExpressionValidator>
        </div>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" ControlToValidate="txtEmail" ForeColor="Red" runat="server" ErrorMessage="*"></asp:RequiredFieldValidator>
    </div>
    <div class="form-row mb-3">
        <div class="col">
            <asp:TextBox ID="txtAddr" type="text" CssClass="form-control" placeholder="Địa Chỉ" runat="server"></asp:TextBox>

        </div>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator7" ControlToValidate="txtAddr" ForeColor="Red" runat="server" ErrorMessage="*"></asp:RequiredFieldValidator>
    </div>
    <div class="form-row mb-3">
        <div class="col">
            <asp:TextBox ID="txtTK" type="text" CssClass="form-control" placeholder="Tài Khoản" runat="server"></asp:TextBox>

        </div>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" ControlToValidate="txtTK" ForeColor="Red" runat="server" ErrorMessage="*"></asp:RequiredFieldValidator>
    </div>
    <div class="form-row mb-3">
        <div class="col">
            <asp:TextBox ID="txtPass" type="password" CssClass="form-control" placeholder="Mật Khẩu" runat="server"></asp:TextBox>

        </div>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="txtPass" ForeColor="Red" runat="server" ErrorMessage="*"></asp:RequiredFieldValidator>
    </div>
    <div class="form-check form-check-inline mb-3">
        <asp:CheckBox ID="cbCtn" CssClass="form-check-input" Checked="true" runat="server" />
        <label class="form-check-label" for="cbCtn">Tiếp tục thêm mới một nhân viên khác</label>

    </div>
    <div class="form-row mb-3">
        <asp:Button ID="btnHuy" CssClass="btn btn-danger mr-3" runat="server" Text="Hủy" OnClick="btnHuy_Click" CausesValidation="false" />
        <asp:Button ID="btnReset" CssClass="btn btn-secondary mr-3" runat="server" Text="Đặt Lại" OnClick="btnReset_Click" CausesValidation="false" />
        <asp:Button ID="btnInsert" CssClass="btn btn-primary" runat="server" Text="Thêm" OnClick="btnInsert_Click" />
    </div>
</div>

