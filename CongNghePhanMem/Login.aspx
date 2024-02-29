<%@ Page Title="Đăng nhập" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="CongNghePhanMem.Login" %>
<asp:Content ID="txtUs" ContentPlaceHolderID="MainContent" runat="server">
    <style type="text/css">
        #MainContent {
            display: flex;
            justify-content: center;
            align-items: center;
            height: 100vh;
        }

        .login-container {
            width: 60%;
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
            justify-content: center;
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

        #Button1,
        a {
            margin-top: 10px;
            display: block;
            text-align: center;
           
        }

        .button-container {
            display: flex;
            align-items: center;
            text-align: center;
            justify-content: center;
            color:#ccc;
            /*height: 100vh;*/
        }
        .error-message {
            text-align: center;
            margin-top: 5px; /* Adjust the margin as needed */
        }
        .centered-button {
        text-align: center;
        color:#0f18b5;
        }
        
    </style>
    <div class="login-container">
        <p class="centered-text">
            <strong>Chào mừng bạn đến với website quản lý hồ sơ khoa học</strong>
        </p>
        <p class="centered-text1">
            <strong>Đăng nhập</strong>
             <p class="error-message">
            <asp:CustomValidator ID="CustomValidator1" ForeColor="Red" runat="server" ControlToValidate="txtUserName" ErrorMessage="Tên đăng nhập và mật khẩu không khớp" OnServerValidate="CustomValidator1_ServerValidate"></asp:CustomValidator>
            </p>
        </p>
        <div class="form-group">
            <label for="txtUserName">Email:</label>
            <asp:TextBox ID="txtUserName" runat="server" Width="100%" Placeholder="Nhập địa chỉ email"></asp:TextBox>
          <p class="error-message">
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ForeColor="Red" ControlToValidate="txtUserName" runat="server" Display="Dynamic" ErrorMessage="Vui lòng nhập Email"></asp:RequiredFieldValidator>
        </p> 
       </div>
        

        <div class="form-group">
            <label for="PW">Mật khẩu:</label>
            <asp:TextBox ID="PW" runat="server" Width="100%" TextMode="Password" Placeholder="Nhập mật khẩu"></asp:TextBox>
            <p class="error-message">
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ForeColor="Red" ControlToValidate="PW" runat="server" Display="Dynamic" ErrorMessage="Vui lòng nhập Mật khẩu"></asp:RequiredFieldValidator>
             </p> 
        </div>

        <div class="button-container">
            <asp:Button ID="Button1" runat="server" Text="Đăng nhập" OnClientClick="return ValidateForm();" OnClick="Button1_Click" CssClass="centered-button" />
        </div>
       
        <p>
            <a href="DangKy">Đăng Kí</a>
        </p>
        
    </div>

    <script type="text/javascript">
        function ValidateForm() {
            // Add client-side validation logic if needed
            return true;
        }
    </script>
</asp:Content>
