using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Category.UI.Registro
{
    public partial class Rcategorias : System.Web.UI.Page
    {
        BLL.RepositorioBase<Categorias> repositorio = new BLL.RepositorioBase<Categorias>();
        string condicion = "Select One";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {

                LlenaComboBoxId();
            }

        }

        private void LlenaComboBoxId()
        {
            Id_DropDownList.Items.Clear();
            Id_DropDownList.Items.Add(condicion);
            Id_DropDownList.DataSource = repositorio.GetList(x => true);
            Id_DropDownList.DataValueField = "IdCategoria";
            Id_DropDownList.DataTextField = "Descripcion";
            Id_DropDownList.DataBind();
        }

        private Categorias GetCategoria()
        {
            int id = 0;
            if (Id_DropDownList.SelectedValue != condicion)
                id = Convert.ToInt32(Id_DropDownList.SelectedValue);
            Categorias categoria = new Categorias();
            if (id != 0)
            {
                categoria.Idcategoria = id;
            }
            else
                categoria.Idcategoria = 0;

            categoria.Descripcion = DescripcionBox.Text;
            categoria.Presupuesto = Convert.ToDecimal(PresupuestoTextBox.Text);

            return categoria;
        }

        protected void NuevoButton_Click(object sender, EventArgs e)
        {
            LlenaComboBoxId();
            DescripcionBox.Text = string.Empty;
            PresupuestoTextBox.Text = string.Empty;
            Id_DropDownList.Text = condicion;
        }

        protected void GuadarButton_Click(object sender, EventArgs e)
        {

            if (Id_DropDownList.Text.Equals(condicion))
            {
                if (repositorio.Guardar(GetCategoria()))
                {
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script: "toastr['success']('Guardado');", addScriptTags: true);
                    NuevoButton_Click(sender, e);
                }
                else
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script: "toastr['danger']('No se pudo Guardar');", addScriptTags: true);
            }
            else
            {
                if (repositorio.Modificar(GetCategoria()))
                {
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script: "toastr['success']('Modificado');", addScriptTags: true);
                    NuevoButton_Click(sender, e);
                }
                else
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script: "toastr['danger']('No se pudo Guardar');", addScriptTags: true);
            }
        }

        protected void Id_DropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(Id_DropDownList.SelectedValue);
            var Categoria = repositorio.GetList(x => x.Idcategoria.Equals(id)).ElementAt(0);
            DescripcionBox.Text = Categoria.Descripcion;
            PresupuestoTextBox.Text = Categoria.Presupuesto.ToString();

        }

        protected void EliminarButtom_Click(object sender, EventArgs e)
        {
            int id = 0;
            if (Id_DropDownList.SelectedValue != condicion)
                id = Convert.ToInt32(Id_DropDownList.SelectedValue);
            else
                return;
            if (!Id_DropDownList.Text.Equals(condicion))
            {


                if (repositorio.Eliminar(id))
                {
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script: "toastr['success']('Eliminado');", addScriptTags: true);
                    NuevoButton_Click(sender, e);
                }
                else
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script: "toastr['danger']('No se pudo Eliminar');", addScriptTags: true);


            }

        }
    }
}