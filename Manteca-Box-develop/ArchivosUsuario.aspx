<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="ArchivosUsuario.aspx.cs" Inherits="Manteca_Box_develop.WebForm1" EnableEventValidation ="false"%>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="demo-card-wide mdl-card mdl-shadow--2dp">
        <div class="mdl-card__title">
            <h1 class="mdl-card__title-text">¡Mis archivos!</h1>            
        </div>
    <asp:GridView ID="GridViewMostrarArchivos" runat="server" AutoGenerateColumns="False"
        CssClass="mdl-data-table mdl-js-data-table mdl-shadow--2dp">
        <Columns>
            <asp:BoundField DataField="Nombre" HeaderText="Nombre Archivo" />
            <asp:BoundField DataField="Fecha_creacion" HeaderText="Fecha Creación" />
            <asp:BoundField DataField="Propietario" HeaderText="Propietario" />
            <asp:BoundField DataField="Version" HeaderText="Version" />

            <asp:TemplateField HeaderText="Descargar">
                <ItemTemplate>
                    <asp:Button ID="Download" Text="Descargar" runat="server" OnClick="Descargar_Click" />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Borrar">
                <ItemTemplate>
                    <asp:Button ID="Delete" Text="Borrar" runat="server" OnClick="Borrar_Click" />
                </ItemTemplate>
            </asp:TemplateField>

        </Columns>
        <RowStyle CssClass="mdl-data-table__cell--non-numeric" />
    </asp:GridView>
    <!--<asp:Button ID="Descargar" runat="server" Text="Descargar" OnClick="Descargar_Click" CssClass="mdl-button mdl-button--colored mdl-js-button mdl-js-ripple-effect"/>-->
    </div>
</asp:Content>
