﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="Manteca_Box_develop.Inicio" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="demo-card-wide mdl-card mdl-shadow--2dp">
        <div class="mdl-card__title">
            <h1 class="mdl-card__title-text">Destacados</h1>            
        </div>
    <asp:GridView ID="GridViewMostrarLikes" runat="server" AutoGenerateColumns="False"
        CssClass="mdl-data-table mdl-js-data-table mdl-shadow--2dp">
        <Columns>
            <asp:BoundField DataField="nombre" HeaderText="Nombre Archivo" />
            <asp:BoundField DataField="ID" HeaderText="likes" />
            <asp:BoundField DataField="descripcion" HeaderText="Propietario" />
        </Columns>
        <RowStyle CssClass="mdl-data-table__cell--non-numeric" />
    </asp:GridView>
    </div>
</asp:Content>