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
                            <asp:TextBox ID="Editar_Perfil_Usuario" runat="server" CssClass="mdl-textfield__input"></asp:TextBox>
                            <label class="mdl-textfield__label" for="ContentPlaceHolder1_Editar_Perfil_Usuario"></label>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidatorUserName" runat="server" ControlToValidate="Editar_Perfil_Usuario" ErrorMessage="Introduce el nombre de usuario" CssClass="mdl-textfield__error"></asp:RequiredFieldValidator>
                            <asp:RegularExpressionValidator ID="RegExUsuario" runat="server" ErrorMessage="No se admiten caracteres especiales o nombres muy largos o cortos" ControlToValidate="Editar_Perfil_Usuario" ValidationExpression="\w{4,30}" CssClass="mdl-textfield__error"></asp:RegularExpressionValidator>
                        </span>
                    </span>
                </li>
                <li class="mdl-list__item">
                    <span class="mdl-list__item-primary-content">
                        <label class="etiqueta-editar-perfil">Email:</label>
                        <span class="mdl-textfield mdl-js-textfield">
                            <asp:TextBox ID="Editar_Perfil_Correo" runat="server" CssClass="mdl-textfield__input"></asp:TextBox>
                            <label class="mdl-textfield__label" for="ContentPlaceHolder1_Editar_Perfil_Correo"></label>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidatorcorreo" runat="server" ControlToValidate="Editar_Perfil_Correo" ErrorMessage="Introduce el email" CssClass="mdl-textfield__error"></asp:RequiredFieldValidator>
                            <asp:RegularExpressionValidator ID="RegularExpressionValidatorEmail" runat="server" ControlToValidate="Editar_Perfil_Correo" ErrorMessage="Esto no es un email" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" CssClass="mdl-textfield__error"></asp:RegularExpressionValidator>
                        </span>
                    </span>
                </li>
                <li class="mdl-list__item">
                    <span class="mdl-list__item-primary-content">
                        <label class="etiqueta-editar-perfil">Contraseña:</label>
                        <span class="mdl-textfield mdl-js-textfield">
                            <asp:TextBox ID="Editar_Perfil_Contrasena" runat="server" TextMode="Password" CssClass="mdl-textfield__input"></asp:TextBox>
                            <label class="mdl-textfield__label" for="ContentPlaceHolder1_Editar_Perfil_Contrasena"></label>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidatorcontraseña1" runat="server" ErrorMessage="Introduce la contraseña" ControlToValidate="Editar_Perfil_Contrasena" CssClass="mdl-textfield__error"></asp:RequiredFieldValidator>
                            <asp:RegularExpressionValidator ID="RegExLongitudContraseña" runat="server" ErrorMessage="Debe de tener entre 4 y 30 caracteres" ControlToValidate="Editar_Perfil_Contrasena" ValidationExpression="\S{4,30}" CssClass="mdl-textfield__error"></asp:RegularExpressionValidator>
                        </span>
                    </span>
                </li>
                <li class="mdl-list__item">
                    <span class="mdl-list__item-primary-content">
                        <label class="etiqueta-editar-perfil">Edad:</label>
                        <span class="mdl-textfield mdl-js-textfield">
                            <asp:TextBox ID="Editar_Perfil_Edad" runat="server" TextMode="Number" CssClass="mdl-textfield__input"></asp:TextBox>
                            <label class="mdl-textfield__label" for="ContentPlaceHolder1_Editar_Perfil_Edad"></label>
                        </span>
                    </span>
                </li>
                <li class="mdl-list__item">
                    <span class="mdl-list__item-primary-content" id="Editar_Perfil_Genero">
                        <label class="etiqueta-editar-perfil">Género:</label>
                        <label class="mdl-radio mdl-js-radio mdl-js-ripple-effect" for="ContentPlaceHolder1_Editar_Perfil_Hombre">
                            <asp:RadioButton ID="Editar_Perfil_Hombre" runat="server" CssClass="mdl-radio__button" />
                            <span class="mdl-radio__label">Hombre</span>
                        </label>
                        <label class="mdl-radio mdl-js-radio mdl-js-ripple-effect" for="ContentPlaceHolder1_Editar_Perfil_Mujer">
                            <asp:RadioButton ID="Editar_Perfil_Mujer" runat="server" CssClass="mdl-radio__button" />
                            <span class="mdl-radio__label">Mujer</span>
                        </label>
                        <label class="mdl-radio mdl-js-radio mdl-js-ripple-effect" for="ContentPlaceHolder1_Editar_Perfil_NoMostrar">
                            <asp:RadioButton ID="Editar_Perfil_NoMostrar" runat="server" CssClass="mdl-radio__button" />
                            <span class="mdl-radio__label">No mostrar</span>
                        </label>
                    </span>
                </li>
                <li class="mdl-list__item">
                    <span class="mdl-list__item-primary-content">
                        <label class="etiqueta-editar-perfil">Localidad:</label>
                        <span class="mdl-textfield mdl-js-textfield">
                            <asp:TextBox ID="Edtiar_Perfil_Localidad" runat="server" CssClass="mdl-textfield__input"></asp:TextBox>
                            <label class="mdl-textfield__label" for="ContentPlaceHolder1_Editar_Pefil_Localidad"></label>
                        </span>
                    </span>
                </li>
                <li class="mdl-list__item">
                    <span class="mdl-list__item-primary-content">
                        <label class="etiqueta-editar-perfil">Visibilidad de perfil:</label>
                        <label class="mdl-switch mdl-js-switch mdl-js-ripple-effect" for="ContentPlaceHolder1_Editar_Perfil_Visibilidad">
                            <asp:CheckBox ID="Editar_Perfil_Visibilidad" runat="server" CssClass="mdl-switch__input" />
                            <span class="mdl-switch__label">Pública</span>
                        </label>
                    </span>
                </li>
            </ul>
        </div>
        <div class="mdl-card__actions mdl-card--border">
            <asp:LinkButton ID="Editar_Perfil_Editar" runat="server" CssClass="mdl-button mdl-js-button mdl-button--primary">
                <i class="material-icons">edit</i>
                Editar Datos
            </asp:LinkButton>
            <asp:LinkButton ID="Editar_Perfil_Guardar" runat="server" CssClass="mdl-button mdl-js-button mdl-button--primary">
                <i class="material-icons">save</i>
                Guardar Cambios
            </asp:LinkButton>
        </div>
    </div>
</asp:Content>
