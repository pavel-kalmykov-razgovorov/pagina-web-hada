<%@ Page Title="Login" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Manteca_Box_develop.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="demo-card-wide mdl-card mdl-shadow--2dp">
        <div class="mdl-card__title">
            <h1 class="mdl-card__title-text">¡Bienvenido! Nos alegramos de verte</h1>
        </div>
        <div class="mdl-card__supporting-text">
            <ul class="demo-list-control mdl-list">
                <li class="mdl-list__item">
                    <span class="mdl-list__item-primary-content">
                        <i class="material-icons  mdl-list__item-avatar">person</i>
                        <span class="mdl-textfield mdl-js-textfield mdl-textfield--floating-label">
                            <asp:TextBox ID="username_login_input" runat="server" CssClass="mdl-textfield__input"></asp:TextBox>
                            <!--<input class="mdl-textfield__input" type="text" id="username-login-input">-->
                            <label class="mdl-textfield__label" for="username-login-input">Usuario</label>

                        </span>
                    </span>
                </li>
                <li class="mdl-list__item">
                    <span class="mdl-list__item-primary-content">
                        <i class="material-icons  mdl-list__item-avatar">vpn_key</i>
                        <span class="mdl-textfield mdl-js-textfield mdl-textfield--floating-label">
                            <asp:TextBox ID="password_login_input" runat="server" CssClass="mdl-textfield__input" TextMode="Password"></asp:TextBox>
                            <!--<input class="mdl-textfield__input" type="password" id="userpass-login-input">-->
                            <label class="mdl-textfield__label" for="userpass-login-input">Contraseña</label>
                        </span>
                    </span>
                </li>
            </ul>
        </div>
        <div class="mdl-card__actions mdl-card--border">
            <asp:Button ID="Button_Login" runat="server" Text="Iniciar Sesión" OnClick="Button_Login_Click" CssClass="mdl-button mdl-button--colored mdl-js-button mdl-js-ripple-effect" />
            <!--<button type="submit" class="mdl-button mdl-button--colored mdl-js-button mdl-js-ripple-effect">
                <b>Iniciar Sesión</b>
            </button>-->
        </div>
    </div>
</asp:Content>