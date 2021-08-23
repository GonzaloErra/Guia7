using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Guia7
{
    public partial class Form1 : Form
    {
        List<Alumno> Alumnos = new List<Alumno>();
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string NroRegistro = TxNroDeRegistro.Text;
            string Nombre = TxNombre.Text;
            string Apellido = TxApellido.Text;
            string MateriasAprobadas = TxMatAprobadas.Text;
            string MateriasRestantes = TxMatRestantes.Text;
            string Promedio = TxPromedio.Text;
            bool flag = false;
            flag = ValidarDatos(NroRegistro, Nombre, Apellido, MateriasAprobadas, MateriasRestantes, Promedio);

            if (flag) //  IF TRUE
            {
                //AGREGAR 
                Alumno A = new Alumno(Convert.ToInt32(NroRegistro), Nombre, Apellido, Convert.ToInt32(MateriasAprobadas), Convert.ToInt32(MateriasRestantes), Convert.ToSingle(Promedio));

                Alumnos.Add(A);
                MessageBox.Show("Se agrego el Alumno");
                TxNroDeRegistro.Clear();
                TxNombre.Clear();
                TxApellido.Clear();
                TxMatAprobadas.Clear();
                TxMatRestantes.Clear();
                TxPromedio.Clear();
                
                ListaMostrar.Items.Add((A.Nombre, A.Apellido, A.MateriasAprobadas, A.MateriasRestantes, A.Promedio));
                ;
            }

        } 
        public bool ValidarDatos(string Registro, string Nombre, string Apellido, string MatAprobadas, string MatRestantes, string Promedios)
        {
            bool Flag = true;
            string Msj = "";

            Msj += ValidarNumero(Registro, "Registro");
            Msj += ValidarVacio(Nombre, "Nombre");
            Msj += ValidarVacio(Apellido, "Apellido");
            Msj += ValidarNumero(MatAprobadas, "Materias Aprobadas");
            Msj += ValidarNumero(MatRestantes, "Materias Desaprobadas");
            Msj += ValidarPromedio(Promedios, "Promedio");

            if (!string.IsNullOrEmpty(Msj))
            {
                Flag = false;
                MessageBox.Show(Msj, "Error en los datos");
            }
            return Flag;
        }
        public string ValidarNumero(string Numero, string Campo)
        {
            int Salida;
            string Msj = "";
             
            if (!int.TryParse(Numero, out Salida))
            {
                Msj = "El Campo " + Campo + "No es numerico." + System.Environment.NewLine;
            }
            else if (Salida < 0)
            {
                Msj = "El Campo " + Campo + "debe ser Positivo." + System.Environment.NewLine;
            }
            else
            {
                Msj = "";
            }
            return Msj;
        }
        public string ValidarPromedio(string Numero, string Campo)
        {
            float Salida;
            string Msj = "";

            if (!float.TryParse(Numero, out Salida))
            {
                Msj = "El Campo " + Campo + "No es numerico." + System.Environment.NewLine;
            }
            else if (Salida <= 1 && Salida >= 10)
            {
                Msj = "El Campo " + Campo + "debe estar ser del 1 al 10." + System.Environment.NewLine;
            }
            else
            {
                Msj = "";
            }
            return Msj;
        }
        public string ValidarVacio(string valor, string campo)
        {
            string Msj;

            if (string.IsNullOrEmpty(valor))
            {
                Msj = ("El campo " + campo + "no debe ser vacio.");
            }
            else
            {
                Msj = "";
            }

            return Msj;
        }
        private Alumno BuscarAlumno(int registro)
        {
            return Alumnos.Find(A => A.NroRegistro == registro);
        }
        private void BtnMostrar_Click(object sender, EventArgs e)
        {
            string Acumulador = "";
            foreach (Alumno A in Alumnos)
            {
                Acumulador += A.ToString() + System.Environment.NewLine;
            }
            MessageBox.Show(Acumulador);
        }
        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (ListaMostrar.Items.Count == 0)
            {
                MessageBox.Show("No hay items en la lista.", "Error");
            }
            else if (ListaMostrar.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un item para eliminar.", "Error");
            }
            else
            {
                string[] item = ListaMostrar.SelectedItem.ToString().Split('-'); //Elimino de mi lista
                int Registro = Convert.ToInt32(item[0]);
                Alumno A = BuscarAlumno(Registro);
                Alumnos.Remove(A);


                ListaMostrar.Items.Remove(ListaMostrar.SelectedItem); //Elimino del ListBox
                MessageBox.Show("Se eliminó la fruta con id " + A.NroRegistro + ".", "Exito");
            }
        }
        private void BtnMost_Click(object sender, EventArgs e)
        {
            string Registro = TxtRegistroBuscar.Text;
            string Msj = "";

            Msj = ValidarNumero(Registro, "Id");

            if (string.IsNullOrEmpty(Msj))
            {
                Alumno A = BuscarAlumno(Convert.ToInt32(Registro));
                if (A == null)
                {
                    TxtRegistroBuscar.Clear();
                    MessageBox.Show("No se encuentra el alumno con el Numero de Registro " + Registro + ".", "Error");
                }
                else
                {
                    MessageBox.Show("Se encontro el alumno" + A.Nombre + " " + A.Apellido + " .");
                    TxtRegistroBuscar.Clear();
                }
            }
        }

        private void BtnMostrarDistinciones_Click(object sender, EventArgs e)
        {

            string Msj = " ";
            if (RbDistincion1.Checked)
            {
                List<Alumno> Listas = BuscarProme9y10();
                foreach (Alumno A in Listas)
                {
                    Msj += A.NroRegistro + System.Environment.NewLine;
                }
                if (string.IsNullOrEmpty(Msj))
                {
                    MessageBox.Show("No hay alumnos con esa distinccion. ", "Distinciones");
                }
                else
                {
                    MessageBox.Show("Alumno con promedios 9 y 10 son :" + System.Environment.NewLine + Msj, "Distinciones");
                }
            }

            else if (RbDistincion2.Checked)
            {
                List<Alumno> Listas = BuscarProme8y9();
                foreach (Alumno A in Listas)
                {
                    Msj += A.NroRegistro + System.Environment.NewLine;
                }
                if (string.IsNullOrEmpty(Msj))
                {
                    MessageBox.Show("No hay alumnos con esa distinccion. ", "Distinciones");
                }
                else
                {
                    MessageBox.Show("Alumno con promedios 8 y 9 son :" + System.Environment.NewLine + Msj, "Distinciones");
                }
            }
            else if (RbDistincion3.Checked)
            {
                List<Alumno> Listas = BuscarProme7y8();
                foreach (Alumno A in Listas)
                {
                    Msj += A.NroRegistro + System.Environment.NewLine;
                }
                if (string.IsNullOrEmpty(Msj))
                {
                    MessageBox.Show("No hay alumnos con esa distinccion. ", "Distinciones");
                }
                else
                {
                    MessageBox.Show("Alumno con promedios 7 y 8 son :" + System.Environment.NewLine + Msj, "Distinciones");
                }
            }
            else if (string.IsNullOrEmpty(Msj))
            {
                MessageBox.Show("No hay alumnos con distinciones.", "Distinciones");
            }
            else
            {
                MessageBox.Show("Usted no seleccionó nada.", "Distinciones");
            }
        }



    

        private List<Alumno> BuscarProme9y10()
        {
            return Alumnos.FindAll(A => A.Promedio >= 9).ToList();
        }
        private List<Alumno> BuscarProme8y9()
        {
            return Alumnos.FindAll(A => (A.Promedio >= 8 && A.Promedio < 9)).ToList();
        }
        private List<Alumno> BuscarProme7y8()
        {
            return Alumnos.FindAll(A => (A.Promedio >= 7 && A.Promedio < 8)).ToList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {string path = "D:\\Facultad 2021\\TLYA\\Visual Studio\\SEGUNDA PARTE DE MATERIA\\guia7.txt";
         FileInfo FI = new FileInfo(path);
         if (!FI.Exists)
            {
                MessageBox.Show("No existe el archivo " + path, "Error");
            }
         else
            {
                StreamReader SR = FI.OpenText()  ;
                // MIENTRAS EL CURSOR NO ESTE AL FINAL DEL ARCHIVO
                while(!SR.EndOfStream)
                {
                    string linea = SR.ReadLine();
                    string[] Vector = linea.Split('-');
                    Alumno A = new Alumno(Convert.ToInt32(Vector[0]), Vector[1], Vector[2], Convert.ToInt32(Vector[3]), Convert.ToInt32(Vector[4]), Convert.ToSingle(Vector[5]));
                    Alumnos.Add(A);
                    ListaMostrar.Items.Add(linea);
                }
                SR.Close();

                MessageBox.Show("Bienvenido! Se cargo correctamente el Archivo");
            }
             
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            string path = "D:\\Facultad 2021\\TLYA\\Visual Studio\\SEGUNDA PARTE DE MATERIA\\guia7.txt";
            FileInfo FI = new FileInfo(path);

            StreamWriter SW = new StreamWriter(path);
            foreach(Alumno A in Alumnos)
            {
                SW.WriteLine(A.ToString());

            }
            SW.Close();
            MessageBox.Show("Hasta Luego! " + System.Environment.NewLine + "Se Guardo Correctamente el archivo");
        }
    }

}


