using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio__7
{
    public partial class MostrarD : Form
    {
        List<Propietario> p = new List<Propietario>();
        List<Casas> c = new List<Casas>();
        List<dF> f = new List<dF>();
        public MostrarD()
        {
            InitializeComponent();
        }

        private void MostrarD_Load(object sender, EventArgs e)
        {
            leerP("Propietario.txt"); leerC("Casas.txt");
            llDatos(); mostD();
        }

        private void leerP(string fileName)
        {
            FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            while (reader.Peek() > -1)
            {
                Propietario pp = new Propietario();
                pp.Dpi = reader.ReadLine();
                pp.Nombre = reader.ReadLine();
                pp.Apellido = reader.ReadLine();

                p.Add(pp);
            }

            reader.Close();
        }

        private void leerC(string fileName)
        {
            FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            while (reader.Peek() > -1)
            {
                Casas cc = new Casas();
                cc.NCasa = Convert.ToInt32(reader.ReadLine());
                cc.Dpi = reader.ReadLine();
                cc.Cuota_de_Matenimiento = Convert.ToDouble(reader.ReadLine());

                c.Add(cc);
            }

            reader.Close();
        }

        private void llDatos()
        {
            for (int i = 0; i < c.Count; i++)
            {
                for (int j = 0; j < p.Count; j++)
                {
                    if (c[i].Dpi.Equals(p[j].Dpi))
                    {
                        dF df = new dF();
                        df.Nombre = p[j].Nombre;
                        df.Apellido = p[j].Apellido;
                        df.NCasa = c[i].NCasa;
                        df.Cuota_de_Matenimiento = c[i].Cuota_de_Matenimiento;

                        f.Add(df);
                    }
                }
            }
        }

        private void mostD()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = f;
            dataGridView1.Refresh();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hide();
            Form1 f = new Form1(); f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            f = f.OrderBy(x => x.Cuota_de_Matenimiento).ToList();
            MessageBox.Show("Datos ordenados exitosamente"); mostD();
        }
    }
}
