<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="Subir-archivo.aspx.cs" Inherits="Manteca_Box_develop.SubirArchivo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="demo-card-wide mdl-card mdl-shadow--2dp">
        <div class="mdl-card__title">
            <h1 class="mdl-card__title-text">Subir archivo</h1>
        </div>
        <div>
            <div class="text-escoge">
                <label>Escoge el archivo a subir:</label>
            </div>
            <div>
                <ul>
                    <li class="botton-Examinar" style="list-style:none">
                        <asp:FileUpload ID="FileUpload1" runat="server" />
                        <!--<input type="submit" value="Subir">-->
                    </li>
                    <li class="botton-subir" style="list-style:none">
                        <asp:Button ID="Button1" runat="server" Text="Subir" />
                    </li>
                </ul>    
             </div>
        </div>
    </div>
</asp:Content>
