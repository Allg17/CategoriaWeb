using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Category.UI.Consulta
{
    public partial class cCategoria : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        BLL.RepositorioBase<Categorias> repositorio = new BLL.RepositorioBase<Categorias>();
        bool paso = false;
        Expression<Func<Categorias, bool>> filtrar = x => true;
        List<Categorias> List = new List<Categorias>();

        protected void DatosGridView_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            DatosGridView.DataSource = repositorio.GetList(filtrar);
            DatosGridView.PageIndex = e.NewPageIndex;
            DatosGridView.DataBind();
        }

        protected void BuscarButton_Click(object sender, EventArgs e)
        {
            int id = 0;

            switch (FiltroComboBox.SelectedIndex)
            {
                // Todo
                case 0:
                    

                    filtrar = t =>true;

                    break;

                // ID
                case 1:
                    id = int.Parse(CriterioTextBox.Text);

                    filtrar = t => t.Idcategoria.Equals(id);

                    break;
                
                  //Descripcion
                case 2:
                    if (paso)
                        return;
                   

                    filtrar = t => t.Descripcion.Equals(CriterioTextBox.Text);

                    break;
                //Presupuesto
                case 3:

                    var presuspuesto = Convert.ToDecimal(CriterioTextBox.Text);
                    filtrar = t => t.Presupuesto.Equals(presuspuesto);

                    break;
            }
            List = repositorio.GetList(filtrar);
            DatosGridView.DataSource = List;
            BLL.Utilidades.ListCategorias = List;
            DatosGridView.DataBind();
        }

        protected void ImprimirButton_Click(object sender, EventArgs e)
        {
           
            Response.Redirect("Reporte.aspx");
        }
    }
}