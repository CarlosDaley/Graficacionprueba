using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Design_Dashboard_Modern
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void Maximizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            Maximizar.Visible = false;
            Restaurar.Visible = true;
        }


        private void MenuSidebar_Click(object sender, EventArgs e)
        {
            if (Sidebar.Width == 270)
            {
                Sidebar.Visible = false;
                Sidebar.Width = 68;
                SidebarWrapper.Width = 90;
                LineaSidebar.Width = 52;
                AnimacionSidebar.Show(Sidebar);
            }
            else
            {
                Sidebar.Visible = false;
                Sidebar.Width = 270;
                SidebarWrapper.Width = 300;
                LineaSidebar.Width = 252;
                AnimacionSidebarBack.Show(Sidebar);
            }
        }

        private void Temporizador_Tick(object sender, EventArgs e)
        {
            /* Temporizador.Stop();

             this.PintarPicturebox.Series["ChartLinea"].Points.AddXY("LUNES", 10);
             this.PintarPicturebox.Series["ChartLinea"].Points.AddXY("MARTES", 20);
             this.PintarPicturebox.Series["ChartLinea"].Points.AddXY("MIERCOLES", 30);
             this.PintarPicturebox.Series["ChartLinea"].Points.AddXY("JUEVES", 40);
             this.PintarPicturebox.Series["ChartLinea"].Points.AddXY("VIERNES", 50);
             this.PintarPicturebox.Series["ChartLinea"].Points.AddXY("SABADO", 40);
             this.PintarPicturebox.Series["ChartLinea"].Points.AddXY("DOMINGO", 20);*/
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Graphics g;
            g = PintarPicturebox.CreateGraphics();
            Pen lapiz = new Pen(Color.Red);
            Pen L = new Pen(Color.Aqua);
            Pen La = new Pen(Color.Azure);

            g.DrawRectangle(lapiz, 10, 10, 500, 200);
            g.DrawLine(L, 20, 10, 40, 100);

        }

        private void bunifuFlatButton2_Click_1(object sender, EventArgs e)
        {
            Graphics g;
            g = PintarPicturebox.CreateGraphics();
            Pen lapiz = new Pen(Color.Red);
            Pen L = new Pen(Color.Aqua);
            Pen La = new Pen(Color.Azure);
            g.DrawRectangle(lapiz, 10, 10, 500, 200);
            g.DrawLine(La, 150, 10, 40, 100);
            // g.DrawLine(La, 40, 10, 40, 100);
        }

        private void bunifuFlatButton3_Click_1(object sender, EventArgs e)
        {
            Graphics g;
            g = PintarPicturebox.CreateGraphics();
            Pen lapiz = new Pen(Color.Red);
            Pen L = new Pen(Color.Aqua);
            Pen La = new Pen(Color.BlueViolet);
            g.DrawRectangle(lapiz, 10, 10, 500, 200);
            g.DrawLine(La, 200, 200, 40, 100);
        }

        private void bunifuFlatButton4_Click_1(object sender, EventArgs e)
        {
            Graphics g;
            g = PintarPicturebox.CreateGraphics();
            Pen lapiz = new Pen(Color.Red);
            Pen L = new Pen(Color.Aqua);
            Pen La = new Pen(Color.Chocolate);
            g.DrawRectangle(lapiz, 10, 10, 500, 200);
            g.DrawLine(La, 10, 100, 40, 100);
        }

        private void bunifuFlatButton7_Click_1(object sender, EventArgs e)
        {
            foreach (var series in PintarPicturebox.Series)
            {
                series.Points.Clear();
            }
        }

        private void Minimizar_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Restaurar_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            Restaurar.Visible = false;
            Maximizar.Visible = true;
        }

        private void Salir_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Maximizar_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            Maximizar.Visible = false;
            Restaurar.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
