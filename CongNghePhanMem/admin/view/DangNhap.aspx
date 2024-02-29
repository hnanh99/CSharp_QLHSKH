<%@ Page Title="" Language="C#" MasterPageFile="/admin/view/Site.Master" AutoEventWireup="true" CodeBehind="DangNhap.aspx.cs" Inherits="CongNghePhanMem.admin.view.DangNhap" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
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
            <strong>Đây website của quản trị viên</strong>
        </p>
        <p class="centered-text1">
            <strong>Đăng nhập</strong>
             <p class="error-message">
            <asp:CustomValidator ID="CustomValidator2" ForeColor="Red" runat="server" ControlToValidate="txtUserName1" ErrorMessage="Tên đăng nhập và mật khẩu không khớp" OnServerValidate="CustomValidator1_ServerValidate"></asp:CustomValidator>
            </p>
        </p>
        <div class="form-group">
            <label for="txtUserName1">Email:</label>
            <asp:TextBox ID="txtUserName1" runat="server" Width="100%" Placeholder="Nhập địa chỉ email"></asp:TextBox>
          <p class="error-message">
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" ForeColor="Red" ControlToValidate="txtUserName1" runat="server" Display="Dynamic" ErrorMessage="Vui lòng nhập Email"></asp:RequiredFieldValidator>
        </p> 
       </div>
        

        <div class="form-group">
            <label for="PW1">Mật khẩu:</label>
            <asp:TextBox ID="PW1" runat="server" Width="100%" TextMode="Password" Placeholder="Nhập mật khẩu"></asp:TextBox>
            <p class="error-message">
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" ForeColor="Red" ControlToValidate="PW1" runat="server" Display="Dynamic" ErrorMessage="Vui lòng nhập Mật khẩu"></asp:RequiredFieldValidator>
             </p> 
        </div>

        <div class="button-container">
            <asp:Button ID="Button2" runat="server" Text="Đăng nhập" OnClientClick="return ValidateForm1();" OnClick="Button1_Click" CssClass="centered-button" />
        </div>
       
        
    </div>

    <script type="text/javascript">
        function ValidateForm1() {
            // Add client-side validation logic if needed
            return true;
        }
    </script>
</asp:Content>
