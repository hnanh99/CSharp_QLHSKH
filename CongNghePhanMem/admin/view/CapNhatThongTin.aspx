<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CapNhatThongTin.aspx.cs" Inherits="CongNghePhanMem.admin.view.CapNhatThongTin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <style>
        #MainContent {
            display: flex;
            justify-content: center;
            align-items: center;
            height: 100vh;
        }

        .update-container {
            width: 50%;
            background-color: #0ff;
            padding: 20px;
            border-radius: 8px;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
            margin: auto;
            color:aqua;
        }

        .centered-text1 {
            text-align: center;
            color: #0f18b5;
            font-size: x-large;
            margin-bottom: 5px;
        }

        .form-group {
            text-align: center;
            margin-bottom: 15px;
        }

        label {
            display: block;
            margin-bottom: 5px;
            color:black;
        }

        input, select {
            width: 100%;
            padding: 8px;
            box-sizing: border-box;
            border: 1px solid #ccc;
            border-radius: 4px;
        }

        .button-container {
            display: flex;
            align-items: center;
            text-align: center;
            justify-content: center;
            color: #ccc;
        }

        .error-message {
            text-align: center;
            margin-top: 5px;
        }

        .centered-button {
            text-align: center;
            color: #0f18b5;
        }
    </style>

    <div class="update-container">
        <p class="centered-text1">
            <strong>Cập nhật thông tin</strong>
        </p>
        <div class="form-group">
            <label for="txtHoVaTen">Họ và tên:</label>
            <asp:TextBox ID="txtHoVaTen" runat="server"></asp:TextBox>
            <p class="error-message">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" ForeColor="Red" ControlToValidate="txtHoVaTen" runat="server" Display="Dynamic" ErrorMessage="Vui lòng nhập họ và tên"></asp:RequiredFieldValidator>
            </p>
        </div>
        <div class="form-group">
            <label for="txtSDT">Số điện thoại:</label>
            <asp:TextBox ID="txtSDT" runat="server"></asp:TextBox>
            <p class="error-message">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" ForeColor="Red" ControlToValidate="txtSDT" runat="server" Display="Dynamic" ErrorMessage="Vui lòng nhập số điện thoại"></asp:RequiredFieldValidator>
            </p>
        </div>
        <div class="form-group">
            <label for="DropDownListTinhThanh">Tỉnh (Thành):</label>
             <asp:DropDownList ID="DropDownListTinhThanh" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownListtinhThanh_SelectedIndexChanged" Width="592px">
                    <asp:ListItem></asp:ListItem>
                </asp:DropDownList>
        </div>
        <div class="form-group">
            <label for="DropDownListQuanHuyen">Quận (Huyện):</label>
           <asp:DropDownList ID="DropDownListQuanHuyen" runat="server" OnSelectedIndexChanged="DropDownListquanHuyen_SelectedIndexChanged" Width="592px" AutoPostBack="True">
                    <asp:ListItem></asp:ListItem>
            </asp:DropDownList>
        </div>
        <div class="form-group">
            <label for="DropDownListXaPhuong">Xã (Phường):</label>
           <asp:DropDownList ID="DropDownListXaPhuong" runat="server"  Width="592px" AutoPostBack="True">
                    <asp:ListItem></asp:ListItem>
                </asp:DropDownList>
        </div>
        <div class="form-group">
            <label for="DropDownListGioiTinh">Giới tính:</label>
           <asp:DropDownList ID="DropDownListGioiTinh" runat="server"  Width="592px" AutoPostBack="True">
                    <asp:ListItem></asp:ListItem>
                </asp:DropDownList>
        </div>
        <div class="form-group">
            <label for="">Năm sinh:</label>
            <asp:TextBox ID="txtNamsinh" runat="server"></asp:TextBox>
            <p class="error-message">
                 <asp:RequiredFieldValidator ID="RequiredFieldValidator6" ForeColor="Red" ControlToValidate="txtNamsinh" runat="server" Display="Dynamic" ErrorMessage="Vui lòng nhập năm sinh"></asp:RequiredFieldValidator> </p>
        </div>
         <div class="form-group">
            <label for="DropDownListHocVi">Học vị:</label>
           <asp:DropDownList ID="DropDownListHocVi" runat="server"  Width="592px" AutoPostBack="True">
                    <asp:ListItem></asp:ListItem>
                </asp:DropDownList>
        </div>
        <!-- Thêm các trường thông tin khác tương tự như trên -->
        <div class="button-container">
            <asp:Button ID="Button1" runat="server" Text="Cập nhật" OnClientClick="return ValidateForm();" OnClick="Button1_Click" CssClass="centered-button" />
        </div>
    </div>

    <script type="text/javascript">
        function ValidateForm() {
            // Add client-side validation logic if needed
            return true;
        }
    </script>
</asp:Content>


