using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CONTROL_ESTANQUE_IA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            lblCaudal.Text = "0 [m3/s]";
            lblAltura.Text = " ";
            txtCaudal.Text = "0,0";
        }

        private void chkIDTAPIA_CheckedChanged(object sender, EventArgs e)
        {


        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {

            panel2.Visible = true;

            if (chkIDTAPIA.Checked == true)
            {
                if (txtClave.Text == "1234")
                {


                    panel2.Visible = true;



                }
            }

            if (chkIDRAMIREZ.Checked == true)
            {
                if (txtClave.Text == "1234")
                {

                    panel2.Visible = true;


                }
            }

            if (chkIDSAAVEDRA.Checked == true)
            {
                if (txtClave.Text == "1234")
                {

                    panel2.Visible = true;



                }
            }
            if (chkIDBUSTOS.Checked == true)
            {
                if (txtClave.Text == "1234")
                {

                    panel2.Visible = true;


                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private static double r;
        private void btbAceptar__Click(object sender, EventArgs e)
        {
           
        }

        private void btnGrafica_Click(object sender, EventArgs e)
        {
            

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
            panel2.Visible = true;
            btnGrafica.Visible = true;

        }

        private void chkIDRAMIREZ_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkIDSAAVEDRA_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkIDBUSTOS_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblCaudal.Text = "0 [m3/s]";
            lblAltura.Text = " ";
            txtCaudal.Text = "0,0";

        }

        private void txtClave_TextChanged(object sender, EventArgs e)
        {

        }

        private void btbAceptar__Click_1(object sender, EventArgs e)
        {
            double r;
            double Qs = Convert.ToDouble(txtCaudal.Text);
            lblCaudal.Text = Qs.ToString() + " [m3/s]";


            r = Math.Pow(((Qs) / (0.05 * 0.5 * Math.Sqrt(2 * 9.8))), 2);
            r = Math.Round(r, 2);
            lblAltura.Text = r.ToString() + " [m]";
        }

        private void btnGrafica_Click_1(object sender, EventArgs e)
        {
            panel3.Visible = true;
            btnGrafica.Visible = false;
            double h_real = 1.5; // ALTURA INICIAL
            double valvula_real = 0.5; //posicion inicial valvula


            double Qs = Convert.ToDouble(txtCaudal.Text);
            lblCaudal.Text = Qs.ToString() + " [m3/s]";
            r = Math.Pow(((Qs) / (0.05 * 0.5 * Math.Sqrt(2 * 9.8))), 2);
            r = Math.Round(r, 2);
            //lbllabel8.Text = r.ToString();

            /////////////////////////////////////////////
            // FUNCIONES DE PERTENENCIA
            //PARA MUY BAJO

            double pertenencia_sb = 0;
            if (h_real < (r - 2))
            {
                pertenencia_sb = 1;
            }
            if (h_real >= (r - 2) & h_real < (r - 1.3))
            {
                double m;
                double b;
                m = r - 2;
                b = r - 1.3;
                pertenencia_sb = (b - h_real) / (b - m);
            }

            lblPertenenciamb.Text = pertenencia_sb.ToString();

            //PARA BAJO
            double pertenencia_b;
            pertenencia_b = 0;

            if (h_real < (r - 0.3) & h_real > (r - 1.7))
            {
                double a;
                double m;
                double b;
                a = (r - 1.7);
                b = (r - 0.3);
                m = (r - 1);
                if (h_real > a & h_real <= m)
                {
                    pertenencia_b = (h_real - a) / (m - a);
                }
                else if (h_real > m & h_real < b)
                {
                    pertenencia_b = (b - h_real) / (b - m);
                }
            }
            else pertenencia_b = 0;
            lblPertenenciab.Text = pertenencia_b.ToString();


            //PARA NOMINAL

            double pertenencia_ideal;
            pertenencia_ideal = 0;

            if (h_real > (r - 0.7) & h_real < (r + 1.7))
            {
                double a;
                double m;
                double b;
                a = r - 0.7;
                b = r + 0.7;
                m = r;
                if (h_real > a & h_real <= m)
                {
                    pertenencia_ideal = (h_real - a) / (m - a);
                }
                else if (h_real > m & h_real < b)
                {
                    pertenencia_ideal = (b - h_real) / (b - m);
                }
            }
            else pertenencia_ideal = 0;
            lblPertenencianm.Text = pertenencia_ideal.ToString();


            //PARA ALTO
            double pertenencia_al;
            pertenencia_al = 0;
            if (h_real > (r + 0.3) & h_real < (r + 1.7))
            {
                double a;
                double b;
                double m;

                a = r + 0.3;
                b = r + 1.7;
                m = r + 2;
                if (h_real > a & h_real <= m)
                {
                    pertenencia_al = (h_real - a) / (m - a);
                }
                else if (h_real > m & h_real > b)
                {
                    pertenencia_al = (b - h_real) / (b - m);
                }
            }
            else pertenencia_al = 0;
            lblPertenenciaal.Text = pertenencia_al.ToString();

            //PERTENENIA MUY ALTO
            double pertenencia_ma;
            pertenencia_ma = 0;
            if (h_real > (r + 2))
            {
                pertenencia_ma = 1;
            }
            else if (h_real > (r + 1.3) & h_real <= (r + 2))
            {
                double a = r + 1.3;
                double m = r + 2;
                pertenencia_ma = (h_real - a) / (m - a);
            }

            lblPertenenciama.Text = pertenencia_ma.ToString();

            // PUNTOS PARA DEFUSIFICACION

            // MUY BAJO

            double k = r + (2.5 - r);
            double punto_sb1 = k - 2.5;
            double punto_sb2 = k - 2;
            double punto_sb3 = k - 1.3;
            //BAJO
            double punto_b1 = k - 1.7;
            double punto_b2 = k - 1;
            double punto_b3 = k - 0.3;
            //IDEAL
            double punto_ideal1 = k - 0.7;
            double punto_ideal2 = k;
            double punto_ideal3 = k + 0.7;
            //ALTO
            double punto_al1 = k + 0.3;
            double punto_al2 = k + 1;
            double punto_al3 = k + 1.7;
            //MUY ALTO      
            double punto_ma1 = k + 1.3;
            double punto_ma2 = k + 2;
            double punto_ma3 = k + 2.5;


            // CALCULAR CENTROIDES
            double centroide = 0;
            double h_desplazado = h_real + (2.5 - r);
            if (h_desplazado >= punto_b1 & h_desplazado <= punto_sb3)
            {
                centroide = (punto_sb1 * pertenencia_sb + punto_sb2 * pertenencia_sb + punto_sb3 * pertenencia_b + punto_b1 * pertenencia_sb + punto_b2 * pertenencia_b + punto_b3 * 0) / (2 * pertenencia_b + 3 * pertenencia_sb);
            }
            if (h_desplazado >= punto_ideal1 & h_desplazado <= punto_b3)
            {
                centroide = (punto_b1 * 0 + punto_b2 * pertenencia_b + punto_b3 * pertenencia_ideal + punto_ideal1 * pertenencia_b + punto_ideal2 * pertenencia_ideal + punto_ideal3 * 0) / (2 * pertenencia_ideal + 2 * pertenencia_b);
            }
            if (h_desplazado >= punto_al1 & h_desplazado <= punto_ideal3)
            {
                centroide = (punto_ideal1 * 0 + punto_ideal2 * pertenencia_ideal + punto_ideal3 * pertenencia_al + punto_al1 * pertenencia_ideal + punto_al2 * pertenencia_al + punto_al3 * 0) / (2 * pertenencia_al + 2 * pertenencia_ideal);
            }
            if (h_desplazado >= punto_ma1 & h_desplazado <= punto_al3)
            {
                centroide = (punto_al1 * 0 + punto_al2 * pertenencia_al + punto_al3 * pertenencia_ma + punto_ma1 * pertenencia_al + punto_ma2 * pertenencia_ma + punto_ma3 * pertenencia_ma) / (3 * pertenencia_ma + 2 * pertenencia_al);
            }

            if ((h_desplazado <= punto_b1)) { centroide = (punto_sb1 + punto_sb2) / 2; }
            if (h_desplazado > punto_sb3 & h_desplazado < punto_ideal1) { centroide = punto_b2; }
            if (h_desplazado > punto_b3 & h_desplazado < punto_al1) { centroide = punto_ideal2; }
            if (h_desplazado > punto_ideal3 & h_desplazado < punto_ma1) { centroide = punto_al2; }
            if (h_desplazado >= punto_al3) { centroide = (punto_ma2 + punto_ma3) / 2; }




            // ECUACION DE LA RECTA PARA TRANSFORMAR EN PORCENTAJE DE ABERTURA O CERRADO DE LA VALVULA
            double pendiente = 0.4;
            double valvula = (-pendiente * centroide + 1);
            valvula = Math.Round(valvula, 3); //arreglado
            lblValvula.Text = valvula.ToString();


            valvula_real = valvula_real + valvula;
            if (valvula_real > 1) { valvula_real = 1; } //LIMITANDO LA VALVULA A RANGO 0-1
            if (valvula_real < 0) { valvula_real = 0; }

            lblValvulaReal.Text = valvula_real.ToString();



            // h_real = h_real + valvula_real * 0.248; //variacion en progress bar
        }

        private void btnVolver_Click_1(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel3.Visible = false;
        }
    }
}
