using Comunes.Dto;
using Comunes.Enums;
using Controlador.Interfaces;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.UI;
using Web.ClienteHttp;

namespace Web
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (!IsPostBack)
            //{
            //    string script = "$(document).ready(function () { $('[id*=btnNuevaPartida]').click(); });";
            //    ClientScript.RegisterStartupScript(this.GetType(), "load", script, true);
            //}
        }

        protected void btnNuevaPartida_Click(object sender, EventArgs e)
        {
            //var apodo = txtApodo.Value;
            //if (string.IsNullOrEmpty(apodo))
            //{
            //    ShowMessage("Aww, password is wrong", BootstrapAlertType.Danger);
            //}

            //var usuario = CrearUsuario();
            //if (usuario != null)
            //{
            //    var partida = CrearPartida(usuario);

            //Response.Redirect(string.Format("~/Pages/Partida.aspx?apodo={0}&partida{1}", apodo, partida.PAR_Id));
            Response.Redirect(string.Format("~/Pages/Partida.aspx?apodo={0}&partida{1}", "Cristian", 1));
            //}
            //else
            //{
            //    ShowMessage("Aww, password is wrong", BootstrapAlertType.Danger);
            //}
            //ProgressBarModalPopupExtender.Hide();
        }

        private PartidaDto CrearPartida(UsuarioDto usuario)
        {
            var partidaDto = new PartidaDto()
            {
                usuario = usuario
            };
            return ClienteHttpcontents<PartidaDto>.Create("partidas", partidaDto);
        }

        private UsuarioDto CrearUsuario()
        {
            UsuarioDto usuario = new UsuarioDto();
            usuario.USU_Apodo = txtApodo.Value;

            return ClienteHttpcontents<UsuarioDto>.Create("usuarios", usuario);
        }

        protected void ShowMessage(string Message, BootstrapAlertType type)
        {
            ScriptManager.RegisterStartupScript(this, GetType(), Guid.NewGuid().ToString(), "ShowMessage('" + Message + "','" + type + "');", true);
        }
    }
}