using Entidades;
using Microsoft.Reporting.WebForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Category.UI.Consulta
{
    public partial class Reporte : System.Web.UI.Page
    {
        BLL.RepositorioBase<Categorias> repositorio = new BLL.RepositorioBase<Categorias>();

        protected void Page_Load(object sender, EventArgs e)
        {
           

            if (!Page.IsPostBack)
            {
                ReportViewer1.ProcessingMode = Microsoft.Reporting.WebForms.ProcessingMode.Local;
                ReportViewer1.Reset();

                ReportViewer1.LocalReport.ReportPath = Server.MapPath(@"~\UI\Reportes\CategoriaReporte.rdlc");

                ReportViewer1.LocalReport.DataSources.Clear();

                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("CategoriaReport", BLL.Utilidades.ListCategorias));
                ReportViewer1.LocalReport.Refresh();
            }
        }
    }
}