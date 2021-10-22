<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="InsertTour.ascx.cs" Inherits="AnTour.cms.admin.Tour.InsertTour" %>
<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>
<div class="container" style="font-size: 1rem;">
    <form>
        <asp:Literal ID="LtlMsg" runat="server"></asp:Literal>
        <div class="form-group row">
            <label for="txtTenTour" class="col-sm-2 col-form-label">Tên Tour: </label>
            <div class="col-sm-10">
                <asp:TextBox ID="txtTenTour" CssClass="form-control" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="txtTenTour" runat="server" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
            </div>
        </div>
        <div class="form-group row">
            <label for="fileUrl" class="col-sm-2 col-form-label">Ảnh Tour: </label>
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

        <div class="form-group">
            <div class="form-check form-check-inline">
                <asp:CheckBox ID="cbAdd" CssClass="form-check-input" runat="server" />
                <label class="form-check-label" for="cbAdd">
                    Tiếp Tục Thêm Mới Một Tour Khác?
                </label>
            </div>
        </div>
        <div class="form-group row">
            <asp:Button ID="btnHuyTour" CssClass="btn btn-danger mr-4 ml-2" runat="server" Text="Hủy" CausesValidation="false" OnClick="btnHuyTour_Click" />
            <asp:Button ID="btnLuu" CssClass="btn btn-primary" runat="server" Text="Lưu" OnClick="btnLuu_Click" />
        </div>

    </form>
</div>
