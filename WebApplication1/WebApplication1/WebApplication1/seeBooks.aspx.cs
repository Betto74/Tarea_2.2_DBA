using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Datos;
using Modelos;


namespace WebApplication1
{
    public partial class seeBooks : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Libros> books = new LibrosDAO().getAllData();
            gvLibros.DataSource = books;
            gvLibros.DataBind();

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddBooks.aspx");
        }
    }
}