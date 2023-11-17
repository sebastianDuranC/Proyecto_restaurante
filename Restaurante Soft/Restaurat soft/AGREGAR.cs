using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurat_soft
{
    public partial class AGREGAR : Form

    {
        private MENÚ menuForm;
        public AGREGAR()
        {
            InitializeComponent();
        }
        string filePath;
          public void SetMenuForm(MENÚ form)
        {
            menuForm = form;
        }
        public class Comida
        {
            public string Nombre { get; set; }
            public double Costo { get; set; }
            public string Categoria { get; set; }
            public string RutaImagen { get; set; }
        }

        //private void agregar_comida_Click(object sender, EventArgs e)
        //{
        //    OpenFileDialog ofd = new OpenFileDialog();
        //    ofd.Filter = "Imágenes (.jpg, .png)|*.jpg;*.png";

        //    if (ofd.ShowDialog() == DialogResult.OK)
        //    {
        //        ////Obtén la ruta de la imagen seleccionada
        //        string sourceImagePath = ofd.FileName;

        //        //Especifica la ruta de destino(C: \Users\FABIO\Desktop\restaurante gif\Restaurante Soft\Restaurat soft\icons)
        //        string destinationPath = @"C:\Users\FABIO\Desktop\restaurante gif\Restaurante Soft\Restaurat soft\icons\";

        //        //Verifica si el directorio de destino existe
        //        if (!Directory.Exists(destinationPath))
        //        {
        //            Directory.CreateDirectory(destinationPath); // Crea el directorio si no existe
        //        }

        //        try
        //        {
        //            //Copia la imagen a la ubicación de destino
        //            File.Copy(sourceImagePath, Path.Combine(destinationPath, Path.GetFileName(sourceImagePath)));
        //        }
        //        catch (Exception ex)
        //        {
        //            //Maneja cualquier excepción que ocurra
        //            MessageBox.Show($"Error al copiar la imagen: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }

        //        //Actualiza la variable filePath con la nueva ruta
        //        filePath = Path.Combine(destinationPath, Path.GetFileName(sourceImagePath));

        //        //Muestra la imagen en tu control
        //        txtImage.Image = new Bitmap(filePath);

        //        //filePath =ofd.FileName;
        //        //txtImage.Image = new Bitmap(filePath);   


        //    }

        //}

        private void agregar_comida_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Imágenes (.jpg, .png)|*.jpg;*.png";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                // Obtén la ruta de la imagen seleccionada
                string sourceImagePath = ofd.FileName;

                // Especifica la ruta de destino
                string destinationPath = @"C:\Users\FABIO\Desktop\restaurante gif\Restaurante Soft\Restaurat soft\icons\";

                // Verifica si el directorio de destino existe
                if (!Directory.Exists(destinationPath))
                {
                    Directory.CreateDirectory(destinationPath); // Crea el directorio si no existe
                }

                try
                {
                    // Genera un nombre único para el archivo de destino usando el timestamp actual
                    string uniqueFileName = $"{DateTime.Now:yyyyMMddHHmmssfff}_{Path.GetFileName(sourceImagePath)}";

                    // Combina la ruta de destino con el nombre único del archivo
                    string destinationFilePath = Path.Combine(destinationPath, uniqueFileName);

                    // Copia la imagen a la ubicación de destino
                    File.Copy(sourceImagePath, destinationFilePath);

                    // Actualiza la variable filePath con la nueva ruta
                    filePath = destinationFilePath;

                    // Muestra la imagen en tu control
                    txtImage.Image = new Bitmap(filePath);
                }
                catch (Exception ex)
                {
                    // Maneja cualquier excepción que ocurra
                    MessageBox.Show($"Error al copiar la imagen: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }






        public int id = 0;

       Byte[] imagenByteArray;
        private void guardar_Click(object sender, EventArgs e)
        {
            // Validar los datos ingresados
            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtprecio.Text) || string.IsNullOrEmpty(cb_categoria.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ////// Validar que la imagen no sea nula ni esté vacía
            ////if (imagenByteArray == null || imagenByteArray.Length == 0)
            ////{
            ////    MessageBox.Show("La imagen es nula o está vacía. No se puede guardar en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            ////    return;
            ////}
            ////try
            ////{
            ////    // Conexión a la base de datos (reemplaza con tus propios valores de conexión)
            ////    string connectionString = "server=LAPTOP-NHM1I0G4\\SQLEXPRESS;database=SoftRESTAURANT;integrated security=true";
            ////    using (SqlConnection connection = new SqlConnection(connectionString))
            ////    {
            ////        connection.Open();

            ////        // Consulta SQL para insertar una nueva comida
            ////        string query = "INSERT INTO comidas (Nombre, Costo, Categoria, Imagen) VALUES (@Nombre, @Costo, @Categoria, @Imagen)";

            ////        using (SqlCommand cmd = new SqlCommand(query, connection))
            ////        {
            ////            cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text);
            ////            cmd.Parameters.AddWithValue("@Costo", double.Parse(txtprecio.Text));
            ////            cmd.Parameters.AddWithValue("@Categoria", cb_categoria.Text);
            ////            if (imagenByteArray != null && imagenByteArray.Length > 0)
            ////            {
            ////                cmd.Parameters.Add("@Imagen", SqlDbType.VarBinary, -1).Value = imagenByteArray;
            ////            }

            ////            cmd.ExecuteNonQuery();
            ////        }
            ////    }

            ////    MessageBox.Show("Comida guardada en la base de datos.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ////}
            ////catch (Exception ex)
            ////{
            ////    MessageBox.Show("Error al guardar la comida en la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            ////}


            //// Crear un objeto Comida con los datos ingresados
            Comida nuevaComida = new Comida
            {
                Nombre = txtNombre.Text,
                Costo = double.Parse(txtprecio.Text),
                Categoria = cb_categoria.Text,
                RutaImagen = filePath
            };


            if (menuForm != null)
            {
                menuForm.AgregarComida(nuevaComida);
            }
            txtNombre.Text="";
            txtprecio.Text = "";
            cb_categoria.Text = " SELECCIONE LA CATEGORIA ";
            MessageBox.Show(" Se Agrego con Exito ","GUARDADO",MessageBoxButtons.OK);
            Close();




        }

       
        private void AGREGAR_Load(object sender, EventArgs e)
        {
          
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            Close();  
        }
    }
    
}
