<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="Subir-archivo.aspx.cs" Inherits="Manteca_Box_develop.SubirArchivo" %>
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
            background: #26A69A;
            /*background: url('../assets/demos/welcome_card.jpg') center / cover;*/
        }

        .demo-card-wide > .mdl-card__menu {
            color: #fff;
        }

        .boton-examinar {
            margin-left: 40px;
        }

        .text-escoge {
            margin-top: 20px;
            margin-left: 20px;
            font-family:Roboto;
        }

        .botton-subir {
            margin-top: 10px;
        }

    </style>

    <div class="demo-card-wide mdl-card mdl-shadow--2dp">
        <div class="mdl-card__title">
            <h1 class="mdl-card__title-text">Subir archivo</h1>
        </div>
        <div>
            <div class="text-escoge">
                <label>Escoge el archivo a subir:</label>
            </div>
            <div>
                <form action="subir.php" enctype="multipart/form-data" method="post">
                    <ul>
                        <li style="list-style:none">
                            <input type="file" name="fichero">
                        </li>
                        <li class="botton-subir" style="list-style:none">
                             <input type="submit" value="Subir">
                        </li>
                    </ul>
                </form>     
             </div>
        </div>
    </div>
</asp:Content>
