<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="Editar-Perfil.aspx.cs" Inherits="Manteca_Box_develop.Editar_Perfil" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="demo-card-wide mdl-card mdl-shadow--2dp">
        <div class="mdl-card__title">
            <h1 class="mdl-card__title-text">PERFIL</h1>
        </div>
        <div class="mdl-card__supporting-text">
            <ul class="demo-list-control mdl-list">
                <li class="mdl-list__item">
                    <span class="mdl-list__item-primary-content">
                        <span class="mdl-textfield mdl-js-textfield mdl-textfield--floating-label">
                            <asp:TextBox ID="Usuario" runat="server" CssClass="mdl-textfield__input"></asp:TextBox>
                            <label class="mdl-textfield__label" for="username-profile-input">Usuario</label>
                        </span>
                    </span>
                </li>
                <li class="mdl-list__item">
                    <span class="mdl-list__item-primary-content">
                        <span class="mdl-textfield mdl-js-textfield mdl-textfield--floating-label">
                            <asp:TextBox ID="Contraseña" runat="server" CssClass="mdl-textfield__input"></asp:TextBox>
                            <!--<input class="mdl-textfield__input" type="password" id="userpass-profile-input">-->
                            <label class="mdl-textfield__label" for="userpass-profile-input">Contraseña</label>
                        </span>
                    </span>
                </li>
            </ul>
        </div>
         <div class="mdl-card__actions mdl-card--border">
            <asp:Button ID="Button_Edit_Profile" runat="server" Text="Editar Perfil" OnClick="Button_Edit_Profile_Click" CssClass="mdl-button mdl-button--colored mdl-js-button mdl-js-ripple-effect" />
        </div>
    </div>
</asp:Content>
