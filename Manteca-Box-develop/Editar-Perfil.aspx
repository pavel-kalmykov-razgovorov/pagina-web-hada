<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="Editar-Perfil.aspx.cs" Inherits="Manteca_Box_develop.Formulario_web1" %>
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
                        <label class="etiqueta-editar-perfil">Usuario:</label>
                        <span class="mdl-textfield mdl-js-textfield">
                            <asp:TextBox ID="user_name_profile" runat="server" CssClass="mdl-textfield__input"></asp:TextBox>
                            <label class="mdl-textfield__label" for="ContentPlaceHolder1_user_name_profile"></label>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidatorUserName" runat="server" ControlToValidate="user_name_profile" ErrorMessage="Introduce el nombre de usuario" CssClass="mdl-textfield__error"></asp:RequiredFieldValidator>
                            <asp:RegularExpressionValidator ID="RegExUsuario" runat="server" ErrorMessage="No se admiten caracteres especiales o nombres muy largos o cortos" ControlToValidate="user_name_profile" ValidationExpression="\w{4,30}" CssClass="mdl-textfield__error"></asp:RegularExpressionValidator>
                        </span>
                    </span>
                </li>
                <li class="mdl-list__item">
                    <span class="mdl-list__item-primary-content">
                       <label class="etiqueta-editar-perfil">Email:</label>
                       <span class="mdl-textfield mdl-js-textfield">
                            <asp:TextBox ID="correo_profile" runat="server" CssClass="mdl-textfield__input"></asp:TextBox>
                            <label class="mdl-textfield__label" for="correo_profile"></label>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidatorcorreo" runat="server" ControlToValidate="correo_profile" ErrorMessage="Introduce el email" CssClass="mdl-textfield__error"></asp:RequiredFieldValidator>
                            <asp:RegularExpressionValidator ID="RegularExpressionValidatorEmail" runat="server" ControlToValidate="correo_profile" ErrorMessage="Esto no es un email" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" CssClass="mdl-textfield__error"></asp:RegularExpressionValidator>
                        </span>
                    </span>
                </li>
                <li class="mdl-list__item">
                    <span class="mdl-list__item-primary-content">
                        <label class="etiqueta-editar-perfil">Contraseña:</label>
                        <span class="mdl-textfield mdl-js-textfield">
                            <asp:TextBox ID="password_profile1" runat="server" CssClass="mdl-textfield__input"></asp:TextBox>
                            <label class="mdl-textfield__label" for="password_profile1"></label>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidatorcontraseña1" runat="server" ErrorMessage="Introduce la contraseña" ControlToValidate="password_profile1" CssClass="mdl-textfield__error"></asp:RequiredFieldValidator>
                            <asp:RegularExpressionValidator ID="RegExLongitudContraseña" runat="server" ErrorMessage="Debe de tener entre 4 y 30 caracteres" ControlToValidate="password_profile1" ValidationExpression="\S{4,30}" CssClass="mdl-textfield__error"></asp:RegularExpressionValidator>
                        </span>
                    </span>
                </li>
                <li class="mdl-list__item">
                    <span class="mdl-list__item-primary-content">
                        <label class="etiqueta-editar-perfil">Edad:</label>
                        <span class="mdl-textfield mdl-js-textfield">
                            <asp:TextBox ID="Age" runat="server" CssClass="mdl-textfield__input"></asp:TextBox>
                            <label class="mdl-textfield__label" for="Age"></label>
                        </span>
                    </span>
                </li>
                <li class="mdl-list__item">
                    <span class="mdl-list__item-primary-content">
                        <label class="etiqueta-editar-perfil">Género:</label>
                        <span class="mdl-textfield mdl-js-textfield">
                            <asp:TextBox ID="Gender" runat="server" CssClass="mdl-textfield__input"></asp:TextBox>
                            <label class="mdl-textfield__label" for="Gender"></label>
                        </span>
                    </span>
                </li>
                <li class="mdl-list__item">
                    <span class="mdl-list__item-primary-content">
                        <label class="etiqueta-editar-perfil">Localidad:</label>
                        <span class="mdl-textfield mdl-js-textfield">                  
                            <asp:TextBox ID="Locality" runat="server" CssClass="mdl-textfield__input"></asp:TextBox>
                            <label class="mdl-textfield__label" for="Locality"></label>
                        </span>
                    </span>
                </li>
                <li class="mdl-list__item">
                    <span class="mdl-list__item-primary-content">
                        <label class="etiqueta-editar-perfil">Visibilidad de perfil:</label>
                        <span class="mdl-textfield mdl-js-textfield">
                            <asp:TextBox ID="Visibility_profile" runat="server" CssClass="mdl-textfield__input"></asp:TextBox>
                            <label class="mdl-textfield__label" for="Visibility_profile"></label>
                        </span>
                    </span>
                </li>
            </ul>
        </div>
        <div class="mdl-card__actions mdl-card--border">
            <asp:Button ID="Button_Edit_Profile" runat="server" Text="Guardar cambios" OnClick="Button_Edit_Profile_Click" CssClass="mdl-button mdl-button--colored mdl-js-button mdl-js-ripple-effect" />
        </div>
    </div>
</asp:Content>
