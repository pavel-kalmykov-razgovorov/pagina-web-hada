<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Manteca_Box_develop.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
        .demo-card-wide.mdl-card {
            width: 90%;
            display: block;
            margin: 5em auto;
        }

        .demo-card-wide > .mdl-card__title {
            color: #fff;
            height: 176px;
            background: #26A69A;
            /*background: url('../assets/demos/welcome_card.jpg') center / cover;*/
        }

        .demo-card-wide > .mdl-card__menu {
            color: #fff;
        }
    </style>

    <div class="demo-card-wide mdl-card mdl-shadow--2dp">
        <div class="mdl-card__title">
            <h1 class="mdl-card__title-text">¡Registrate en MantecaBox!</h1>
        </div>
        <div class="mdl-card__supporting-text">
            <ul class="demo-list-control mdl-list">
                <li class="mdl-list__item">
                    <span class="mdl-list__item-primary-content">
                        <i class="material-icons  mdl-list__item-avatar">person</i>
                        <span class="mdl-textfield mdl-js-textfield mdl-textfield--floating-label">
                            <asp:TextBox ID="user_name_register" runat="server" CssClass="mdl-textfield__input"></asp:TextBox>
                            <!--<input class="mdl-textfield__input" type="text" id="username-login-input">-->
                            <label class="mdl-textfield__label" for="username-login-input">Usuario</label>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidatorUserName" runat="server" ControlToValidate="user_name_register" ErrorMessage="Introduce el nombre de usuario" CssClass="mdl-textfield__error"></asp:RequiredFieldValidator>
                        </span>
                    </span>
                </li>
                 <li class="mdl-list__item">
                    <span class="mdl-list__item-primary-content">
                        <i class="material-icons  mdl-list__item-avatar">email</i>
                        <span class="mdl-textfield mdl-js-textfield mdl-textfield--floating-label">
                            <asp:TextBox ID="correo_register" runat="server" CssClass="mdl-textfield__input" ></asp:TextBox>
                            <!--<input class="mdl-textfield__input" type="password" id="userpass-login-input">-->
                            <label class="mdl-textfield__label" for="userpass-login-input">Email</label>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidatorcorreo" runat="server" ControlToValidate="correo_register" ErrorMessage="Introduce el email" CssClass="mdl-textfield__error"></asp:RequiredFieldValidator>
                     <asp:RegularExpressionValidator ID="RegularExpressionValidatorEmail" runat="server" ControlToValidate="correo_register" ErrorMessage="Esto no es un email" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" CssClass="mdl-textfield__error"></asp:RegularExpressionValidator>
                        </span>
                    </span>
                </li>
                <li class="mdl-list__item">
                    <span class="mdl-list__item-primary-content">
                        <i class="material-icons  mdl-list__item-avatar">vpn_key</i>
                        <span class="mdl-textfield mdl-js-textfield mdl-textfield--floating-label">
                            <asp:TextBox ID="password_register1" runat="server" CssClass="mdl-textfield__input" TextMode="Password"></asp:TextBox>
                            <!--<input class="mdl-textfield__input" type="password" id="userpass-login-input">-->
                            <label class="mdl-textfield__label" for="userpass-login-input">Contraseña</label>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidatorcontraseña1" runat="server" ErrorMessage="Introduce la contraseña" ControlToValidate="password_register1" CssClass="mdl-textfield__error"></asp:RequiredFieldValidator>
                        </span>
                    </span>
                </li>
                <li class="mdl-list__item">
                    <span class="mdl-list__item-primary-content">
                        <i class="material-icons  mdl-list__item-avatar">vpn_key</i>
                        <span class="mdl-textfield mdl-js-textfield mdl-textfield--floating-label">
                            <asp:TextBox ID="password_register2" runat="server" CssClass="mdl-textfield__input" TextMode="Password"></asp:TextBox>
                            <!--<input class="mdl-textfield__input" type="password" id="userpass-login-input">-->
                            <label class="mdl-textfield__label" for="userpass-login-input">Repite contraseña</label>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidatorcontraseña2" runat="server" ErrorMessage="Confirma la contraseña" ControlToValidate="password_register2" CssClass="mdl-textfield__error"></asp:RequiredFieldValidator>
                        </span>
                    </span>
                </li>
            </ul>
        </div>
        <div class="mdl-card__actions mdl-card--border">
            <button type="submit" class="mdl-button mdl-button--colored mdl-js-button mdl-js-ripple-effect">
                <b>Iniciar Sesión</b>
            </button>
        </div>
    </div>
</asp:Content>
