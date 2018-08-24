<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Partida.aspx.cs" Inherits="Web.Pages.Partida" MasterPageFile="~/Site.Master" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class='col-sm-4 text-center'>
            <asp:Image ImageUrl="~/Asserts/fondo.jpg" runat="server" Height="300px" />
            <h1>¡¡¡¿Qué Tan Nerd Eres?!!!</h1>
        </div>
        <div class='col-sm-8'>
            <div class="row">
                <div class='col-sm-12 text-center'>
                    <h1 id="h1Pregunta" runat="server">Pregunta 1</h1>
                </div>
            </div>
            <div class="row">
                <div class='col-sm-1 text-center'>
                    <h3>A.</h3>
                </div>
                <div class='col-sm-11'>
                    <h3 ID="lblRespuesta1" runat="server">t is a long established fact that a reader will be</h3>
                </div>
            </div>
            <div class="row">
                <div class='col-sm-1 text-center'>
                    <h3>B.</h3>
                </div>
                <div class='col-sm-11'>
                    <h3 ID="lblRespuesta2" runat="server">t is a long established fact that a reader will be</h3>
                </div>
            </div>
            <div class="row">
                <div class='col-sm-1 text-center'>
                    <h3>C.</h3>
                </div>
                <div class='col-sm-11'>
                    <h3 ID="lblRespuesta3" runat="server">t is a long established fact that a reader will be</h3>
                </div>
            </div>
            <div class="row">
                <div class='col-sm-1 text-center'>
                    <h3>D.</h3>
                </div>
                <div class='col-sm-11'>
                    <h3 ID="lblRespuesta4" runat="server">t is a long established fact that a reader will be</h3>
                </div>
            </div>
            <br />
            <div class="row">
                <div class='col-sm-12 text-center'>
                    <asp:Button runat="server" ID="btnResponder" Text="Responder" CssClass="btn btn-lg btn-primary" />
                </div>
            </div>
        </div>
    </div>

</asp:Content>
