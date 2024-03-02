using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Modelos;
using Datos;

namespace WebApplication1
{
    public partial class AddBooks : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIsbn.Text))
            {
                lblMsgIsbn.Text = "El isbn no debe estar vacio";
                lblMsgIsbn.ForeColor = System.Drawing.Color.Red;
                return;
            }
            else {
                lblMsgIsbn.Text = "";
            }

            if (string.IsNullOrEmpty(txtTitulo.Text))
            {
                lblMsgTitulo.Text = "El titulo no debe estar vacio";
                lblMsgTitulo.ForeColor = System.Drawing.Color.Red;
                return;
            }
            else
            {
                lblMsgTitulo.Text = "";
            }

            if (string.IsNullOrEmpty(txtNumEd.Text) || !int.TryParse(txtNumEd.Text, out int numeroEntero))
            {
                lblMsgEdicion.Text = "La edicion debe ser un numero";
                lblMsgEdicion.ForeColor = System.Drawing.Color.Red;
                return;
            }
            else
            {
                lblMsgEdicion.Text = "";
            }

            if (string.IsNullOrEmpty(txtYearPub.Text) || !int.TryParse(txtYearPub.Text, out int numero) )
            {
                lblMsgPublicacion.Text = "El año de publicacion debe ser un numero";
                lblMsgPublicacion.ForeColor = System.Drawing.Color.Red;
                return;
            }
            else
            {
                lblMsgPublicacion.Text = "";
            }

            if (string.IsNullOrEmpty(txtAutores.Text))
            {
                lblMsgAutores.Text = "Los autores no deben estar vacios";
                lblMsgAutores.ForeColor = System.Drawing.Color.Red;
                return;
            }
            else
            {
                lblMsgAutores.Text = "";
            }

            if (string.IsNullOrEmpty(txtPais.Text))
            {
                lblMsgPais.Text = "El pais no debe estar vacio";
                lblMsgPais.ForeColor = System.Drawing.Color.Red;
                return;
            }
            else
            {
                lblMsgPais.Text = "";
            }

            if (string.IsNullOrEmpty(txtSinopsis.Text))
            {
                lblMsgSinopsis.Text = "La sinopsis no debe estar vacia";
                lblMsgSinopsis.ForeColor = System.Drawing.Color.Red;
                return;
            }
            else
            {
                lblMsgSinopsis.Text = "";
            }

            if (string.IsNullOrEmpty(txtCarrera.Text))
            {
                lblMsgCarrera.Text = "La carrera no debe estar vacia";
                lblMsgCarrera.ForeColor = System.Drawing.Color.Red;
                return;
            }
            else
            {
                lblMsgCarrera.Text = "";
            }

            if (string.IsNullOrEmpty(txtMateria.Text))
            {
                lblMsgMateria.Text = "La materia no debe estar vacia";
                lblMsgMateria.ForeColor = System.Drawing.Color.Red;
                return;
            }
            else
            {
                lblMsgMateria.Text = "";
            }
            Libros book = new Libros()
            {
                //ID = Convert.ToInt32(fila["ID"]),
                isbn = txtIsbn.Text,
                titulo = txtTitulo.Text,
                edicion = Convert.ToInt32(txtNumEd.Text),
                publicacion = Convert.ToInt32(txtYearPub.Text),
                autores = txtAutores.Text,
                pais = txtPais.Text,
                sinopsis = txtSinopsis.Text,    
                carrera = txtCarrera.Text,
                materia = txtMateria.Text

            };
            
                
            if (new LibrosDAO().insert(book))
            {
               
            }
            else
            {
               
            }
            Response.Redirect("seeBooks.aspx");


        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("seeBooks.aspx");
        }
    }
}