<%@ Page Title="Đổi mật khẩu" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DoiMatKhau.aspx.cs" Inherits="CongNghePhanMem.view.DoiMatKhau" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <style>
        #MainContent {
            display: flex;
            justify-content: center;
            align-items: center;
            height: 100vh;
        }

        .login-container {
            width: 50%;
            background-color: #0ff;
            padding: 20px;
            border-radius: 8px;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
            margin: auto;
        }

        .centered-text {
            text-align: center;
            color: #0000FF;
            font-size: x-large;
            margin-bottom: 20px;
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
        }

        input {
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
    <div class="login-container">
        <p class="centered-text1">
            <strong>Đổi mật khẩu</strong>
        </p>
        <div class="form-group">
            <label for="txtPW">Mật khẩu hiện tại:</label>
            <asp:TextBox ID="txtPW" runat="server" TextMode="Password"></asp:TextBox>
            <p class="error-message">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ForeColor="Red" ControlToValidate="txtPW" runat="server" Display="Dynamic" ErrorMessage="Vui lòng nhập mật khẩu cũ"></asp:RequiredFieldValidator>
            </p>
        </div>
        <div class="form-group">
            <label for="txtMKmoi">Mật khẩu mới:</label>
            <asp:TextBox ID="txtMKmoi" runat="server" TextMode="Password"></asp:TextBox>
            <p class="error-message">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ForeColor="Red" ControlToValidate="txtMKmoi" runat="server" Display="Dynamic" ErrorMessage="Vui lòng nhập mật khẩu mới"></asp:RequiredFieldValidator>
            </p>
        </div>
        <div class="form-group">
            <label for="txtXN">Xác nhận mật khẩu:</label>
            <asp:TextBox ID="txtXN" runat="server" TextMode="Password"></asp:TextBox>
            <p class="error-message">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" ForeColor="Red" ControlToValidate="txtXN" runat="server" Display="Dynamic" ErrorMessage="Vui lòng nhập xác nhận mật khẩu"></asp:RequiredFieldValidator>
            </p>
        </div>
        <div class="button-container">
            <asp:Button ID="Button1" runat="server" Text="Đổi mật khẩu" OnClientClick="return ValidateForm();" OnClick="Button1_Click" CssClass="centered-button" />
        </div>
    </div>

    <script type="text/javascript">
        function ValidateForm() {
            // Add client-side validation logic if needed
            return true;
        }
    </script>
</asp:Content>

