<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Web._Default" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolKit" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class='col-sm-12 text-center'>
            <asp:Image ImageUrl="~/Asserts/fondo.jpg" runat="server" Height="300px" />
            <h1>¡¡¡¿Qué Tan Nerd Eres?!!!</h1>
        </div>
    </div>
    <br />
    <div class="row">
        <div class="col-sm-12 text-center form-inline">
            <input type="text" id="txtApodo" runat="server" class="form-control form-control-lg" placeholder="Ingrese un apodo" />
            <asp:Button ID="btnNuevaPartida" CssClass="btn btn-success" Text="Nueva Partida" OnClick="btnNuevaPartida_Click" runat="server" />
        </div>
    </div>
    <ajaxToolkit:ModalPopupExtender ID="ProgressBarModalPopupExtender" runat="server"
        BackgroundCssClass="ModalBackground" BehaviorID="ProgressBarModalPopupExtender"
        TargetControlID="hiddenField" PopupControlID="Panel1" Enabled="True" />
    <asp:Panel ID="Panel1" runat="server" Style="display: none; background-color: #C0C0C0;">
        <p class="wait">Please wait!</p>
    </asp:Panel>
    <asp:HiddenField ID="hiddenField" runat="server" />
    <script>
        function validateAdd() {
            var myExtender = $find('ProgressBarModalPopupExtender');
            myExtender.show();
            return true;
        }
    </script>
    <script type="text/javascript">
        function ShowMessage(message, messagetype) {
            var cssclass;
            switch (messagetype) {
                case 'Success':
                    cssclass = 'alert-success'
                    break;
                case 'Danger':
                    cssclass = 'alert-danger'
                    break;
                case 'Warning':
                    cssclass = 'alert-warning'
                    break;
                default:
                    cssclass = 'alert-info'
            }
            $('#<%=btnNuevaPartida.ClientID %>').append('<div id="alert_div" style="margin: 0 0.5%; -webkit-box-shadow: 3px 4px 6px #999;" class="alert fade in ' + cssclass + '"><a href="#" class="close" data-dismiss="alert" aria-label="close">&times;</a><strong>' + messagetype + '!</strong> <span>' + message + '</span></div>');
        }
    </script>
</asp:Content>
