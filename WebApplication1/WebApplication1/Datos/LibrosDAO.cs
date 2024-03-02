using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;

namespace Datos
{
    public class LibrosDAO
    {
        public List<Libros> getAllData()
        {

            List<Libros> bookList = new List<Libros>();
            if (Conexion.Conectar())
            {
                try
                {

                    string select = "SELECT * FROM BOOKS";

                    //Definir un datatable para que sea llenado
                    DataTable dt = new DataTable();
                    //Crear el dataadapter
                    SqlCommand sentencia = new SqlCommand(select);
                    //Asignar los parámetros

                    sentencia.Connection = Conexion.conexion;

                    SqlDataAdapter da = new SqlDataAdapter(sentencia);

                    //Llenar el datatable
                    da.Fill(dt);

                    //Revisar si hubo resultados
                    if (dt.Rows.Count > 0)
                    {

                        foreach(DataRow fila in dt.Rows)
{
                            Libros book = new Libros()
                            {
                              
                                isbn = fila["ISBN"].ToString(),
                                titulo = fila["TITULO"].ToString(),
                                edicion = Convert.ToInt32(fila["EDICION"]),
                                publicacion = Convert.ToInt32(fila["PUBLICACION"]),
                                autores = fila["AUTORES"].ToString(),
                                pais = fila["PAIS"].ToString(),
                                sinopsis = fila["SINOPSIS"].ToString(),
                                carrera = fila["CARRERA"].ToString(),
                                materia = fila["MATERIA"].ToString(),


                            };
                            bookList.Add(book);
                        }


                    }


                    return bookList;
                }
                finally
                {
                    Conexion.Desconectar();
                }
            }
            else
            {
                return null;
            }
        }
        public Boolean insert(Libros book)
        {

            if (Conexion.Conectar())
            {
                try
                {

                    String select = @"INSERT INTO BOOKS (ISBN, TITULO, EDICION, PUBLICACION, AUTORES, PAIS, SINOPSIS, CARRERA, MATERIA)"
                                    + "VALUES (@ISBN, @TITULO, @EDICION, @PUBLICACION, @AUTORES, @PAIS, @SINOPSIS, @CARRERA, @MATERIA)";

                    //Crear el dataadapter
                    SqlCommand sentencia = new SqlCommand(select);
                    //Asignar los parámetros
                    sentencia.Parameters.AddWithValue("@ISBN", book.isbn);
                    sentencia.Parameters.AddWithValue("@TITULO", book.titulo);
                    sentencia.Parameters.AddWithValue("@EDICION", book.edicion);
                    sentencia.Parameters.AddWithValue("@PUBLICACION", book.publicacion);
                    sentencia.Parameters.AddWithValue("@AUTORES", book.autores);
                    sentencia.Parameters.AddWithValue("@PAIS", book.pais);
                    sentencia.Parameters.AddWithValue("@SINOPSIS", book.sinopsis);
                    sentencia.Parameters.AddWithValue("@CARRERA", book.carrera);
                    sentencia.Parameters.AddWithValue("@MATERIA", book.materia);

                    sentencia.Connection = Conexion.conexion;

                    sentencia.ExecuteNonQuery();
                    return true;
                }
                finally
                {
                    Conexion.Desconectar();
                }
            }
            else
            {
                return false;
            }

        }
    }
}
