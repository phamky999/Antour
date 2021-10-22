<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="EditTour.ascx.cs" Inherits="AnTour.cms.admin.Tour.EditTour" %>

<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>

<div>
    <h4>Thông Tin Tour Cần Chỉnh Sửa:</h4>
</div>
<asp:Literal ID="Literal2" runat="server"></asp:Literal>
<div class="container mb-5" style="font-size: 1rem;">
    <form>
        <asp:Literal ID="LtlMsg" runat="server"></asp:Literal>
        <div class="form-group row">
            <label for="txtMa" class="col-sm-2 col-form-label">Mã Tour: </label>
            <div class="col-sm-10">
                <asp:TextBox ID="txtMa" CssClass="form-control" runat="server" Enabled="false" ></asp:TextBox>
            </div>
        </div>
        <div class="form-group row">
            <label for="txtTenTour" class="col-sm-2 col-form-label">Tên Tour: </label>
            <div class="col-sm-10">
                <asp:TextBox ID="txtTenTour" CssClass="form-control" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="txtTenTour" runat="server" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
            </div>
        </div>
        <div class="form-group row">
            <label for="txtTenTour" class="col-sm-2 col-form-label">Ảnh Cũ: </label>
            <div class="col-sm-10">
                <asp:Literal ID="Literal1" runat="server"></asp:Literal>
                <asp:HiddenField ID="hdTenAnhDaiDienCu" runat="server" />
                <asp:Literal ID="ltrAnhDaiDien" runat="server"></asp:Literal>
            </div>
        </div>
        <div class="form-group row">
            <label for="fileUrl" class="col-sm-2 col-form-label">Ảnh Mới: </label>
            <div class="col-sm-10">
                <asp:FileUpload ID="fileUrl" runat="server" />
            </div>
        </div>
        <div class="form-group row">
            <label for="txtAddr" class="col-sm-2 col-form-label">Điểm Đến: </label>
            <div class="col-sm-10">
                <asp:TextBox ID="txtAddr" CssClass="form-control" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ControlToValidate="txtAddr" runat="server" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
            </div>
        </div>
        <div class="form-group row">
            <label for="txtSoNgay" class="col-sm-2 col-form-label">Số Ngày: </label>
            <div class="col-sm-10">
                <asp:TextBox ID="txtSoNgay" CssClass="form-control" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" ControlToValidate="txtSoNgay" runat="server" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" ControlToValidate="txtSoNgay" ValidationExpression="^[0-9]$" runat="server" ErrorMessage="*" ForeColor="Red"></asp:RegularExpressionValidator>

            </div>
        </div>
        <div class="form-group row">
            <label for="txtSLMax" class="col-sm-2 col-form-label">Số Lượng Khách Tối Đa: </label>
            <div class="col-sm-10">
                <asp:TextBox ID="txtSLMax" CssClass="form-control" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" ControlToValidate="txtSLMax" runat="server" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" ControlToValidate="txtSoNgay" ValidationExpression="^[0-9]$" runat="server" ErrorMessage="*" ForeColor="Red"></asp:RegularExpressionValidator>

            </div>
        </div>
        <div class="form-group row">
            <label for="txtGia" class="col-sm-2 col-form-label">Đơn Giá: </label>
            <div class="col-sm-10">
                <asp:TextBox ID="txtGia" CssClass="form-control" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" ControlToValidate="txtGia" runat="server" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator3" ControlToValidate="txtSoNgay" ValidationExpression="^[0-9]$" runat="server" ErrorMessage="*" ForeColor="Red"></asp:RegularExpressionValidator>

            </div>
        </div>
        <div class="form-group row">
            <label for="txtNgayTao" class="col-sm-2 col-form-label">Ngày Tạo: </label>
            <div class="col-sm-10">
                <asp:TextBox ID="txtNgayTao" CssClass="form-control" runat="server" ReadOnly="true"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" ControlToValidate="txtNgayTao" runat="server" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
            </div>
        </div>
        <div class="form-group row">
            <label for="txtAddr" class="col-sm-2 col-form-label">Giới Thiệu: </label>
            <div class="col-sm-10">
                <CKEditor:CKEditorControl ID="CKEditorControl1" runat="server" FilebrowserImageBrowseUrl="ckeditor/ckfinder/ckfinder.aspx?type=Images&path=pic"></CKEditor:CKEditorControl>

            </div>
        </div>

        <div class="form-group row">
            <div class="col-sm-2">
                <asp:Button ID="Button1" CssClass="btn btn-dark mr-4 ml-2" runat="server" Text="Ngừng Hoạt Động" OnClientClick="return confirm('Bạn có chắc chắn muốn ngừng hoạt động tour này?')" OnClick="Button1_Click" />

            </div>
            <div class="col-sm-10">
                <asp:Button ID="btnHuyTour" CssClass="btn btn-danger mr-4 ml-2" runat="server" Text="Hủy" CausesValidation="false" OnClick="btnHuyTour_Click" />
                <asp:Button ID="btnLuu" CssClass="btn btn-primary" runat="server" Text="Lưu" OnClick="btnLuu_Click" />

            </div>
        </div>

    </form>
</div>
<div class="table-responsive">
    <table class="table table-bordered table-hover" style="overflow-x: scroll;">
        <thead>
            <tr>
                <th scope="col">Mã Tour</th>
                <th scope="col">Tên Tour</th>
                <th scope="col">Ảnh Tour</th>
                <th scope="col">Địa Điểm</th>
                <th scope="col">Số Ngày</th>
                <th scope="col">Số Lượng Khách Tối Đa</th>
                <th scope="col">Đơn Giá </th>
                <th scope="col">Ngày Tạo</th>
                <th scope="col">Thao Tác</th>
            </tr>
        </thead>

        <tbody>
            <asp:Literal ID="ltlTour" runat="server"></asp:Literal>
        </tbody>
    </table>
</div>
