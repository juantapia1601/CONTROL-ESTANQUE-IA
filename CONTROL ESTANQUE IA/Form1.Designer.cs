
namespace CONTROL_ESTANQUE_IA
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAcceder = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chkIDBUSTOS = new System.Windows.Forms.CheckBox();
            this.chkIDSAAVEDRA = new System.Windows.Forms.CheckBox();
            this.chkIDRAMIREZ = new System.Windows.Forms.CheckBox();
            this.chkIDTAPIA = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnGrafica = new System.Windows.Forms.Button();
            this.btbAceptar_ = new System.Windows.Forms.Button();
            this.txtCaudal = new System.Windows.Forms.TextBox();
            this.lblCaudal = new System.Windows.Forms.Label();
            this.lblAltura = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblPertenenciamb = new System.Windows.Forms.Label();
            this.lblPertenenciab = new System.Windows.Forms.Label();
            this.lblPertenencianm = new System.Windows.Forms.Label();
            this.lblPertenenciaal = new System.Windows.Forms.Label();
            this.lblPertenenciama = new System.Windows.Forms.Label();
            this.lblValvula = new System.Windows.Forms.Label();
            this.lblValvulaReal = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnAcceder);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtClave);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.chkIDBUSTOS);
            this.panel1.Controls.Add(this.chkIDSAAVEDRA);
            this.panel1.Controls.Add(this.chkIDRAMIREZ);
            this.panel1.Controls.Add(this.chkIDTAPIA);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.ForeColor = System.Drawing.Color.Crimson;
            this.button1.Location = new System.Drawing.Point(562, 360);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 33);
            this.button1.TabIndex = 32;
            this.button1.Text = "CERRAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAcceder
            // 
            this.btnAcceder.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAcceder.ForeColor = System.Drawing.Color.Crimson;
            this.btnAcceder.Location = new System.Drawing.Point(562, 290);
            this.btnAcceder.Name = "btnAcceder";
            this.btnAcceder.Size = new System.Drawing.Size(139, 51);
            this.btnAcceder.TabIndex = 31;
            this.btnAcceder.Text = "ACCEDER";
            this.btnAcceder.UseVisualStyleBackColor = false;
            this.btnAcceder.Click += new System.EventHandler(this.btnAcceder_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Azure;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.15F);
            this.label4.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label4.Location = new System.Drawing.Point(271, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(237, 35);
            this.label4.TabIndex = 30;
            this.label4.Text = "DE ESTANQUE";
            // 
            // txtClave
            // 
            this.txtClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.txtClave.Location = new System.Drawing.Point(476, 235);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(183, 28);
            this.txtClave.TabIndex = 29;
            this.txtClave.TextChanged += new System.EventHandler(this.txtClave_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label3.Location = new System.Drawing.Point(472, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 24);
            this.label3.TabIndex = 28;
            this.label3.Text = "CLAVE DE ACCESO";
            // 
            // chkIDBUSTOS
            // 
            this.chkIDBUSTOS.AutoSize = true;
            this.chkIDBUSTOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.chkIDBUSTOS.Location = new System.Drawing.Point(105, 317);
            this.chkIDBUSTOS.Name = "chkIDBUSTOS";
            this.chkIDBUSTOS.Size = new System.Drawing.Size(252, 28);
            this.chkIDBUSTOS.TabIndex = 27;
            this.chkIDBUSTOS.Text = "PROF. SAMUEL BUSTOS";
            this.chkIDBUSTOS.UseVisualStyleBackColor = true;
            this.chkIDBUSTOS.CheckedChanged += new System.EventHandler(this.chkIDBUSTOS_CheckedChanged);
            // 
            // chkIDSAAVEDRA
            // 
            this.chkIDSAAVEDRA.AutoSize = true;
            this.chkIDSAAVEDRA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.chkIDSAAVEDRA.Location = new System.Drawing.Point(105, 290);
            this.chkIDSAAVEDRA.Name = "chkIDSAAVEDRA";
            this.chkIDSAAVEDRA.Size = new System.Drawing.Size(210, 28);
            this.chkIDSAAVEDRA.TabIndex = 26;
            this.chkIDSAAVEDRA.Text = "MATIAS SAAVEDRA";
            this.chkIDSAAVEDRA.UseVisualStyleBackColor = true;
            this.chkIDSAAVEDRA.CheckedChanged += new System.EventHandler(this.chkIDSAAVEDRA_CheckedChanged);
            // 
            // chkIDRAMIREZ
            // 
            this.chkIDRAMIREZ.AutoSize = true;
            this.chkIDRAMIREZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.chkIDRAMIREZ.Location = new System.Drawing.Point(105, 263);
            this.chkIDRAMIREZ.Name = "chkIDRAMIREZ";
            this.chkIDRAMIREZ.Size = new System.Drawing.Size(234, 28);
            this.chkIDRAMIREZ.TabIndex = 25;
            this.chkIDRAMIREZ.Text = "ALEJANDRO RAMIREZ";
            this.chkIDRAMIREZ.UseVisualStyleBackColor = true;
            this.chkIDRAMIREZ.CheckedChanged += new System.EventHandler(this.chkIDRAMIREZ_CheckedChanged);
            // 
            // chkIDTAPIA
            // 
            this.chkIDTAPIA.AutoSize = true;
            this.chkIDTAPIA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.chkIDTAPIA.Location = new System.Drawing.Point(105, 236);
            this.chkIDTAPIA.Name = "chkIDTAPIA";
            this.chkIDTAPIA.Size = new System.Drawing.Size(140, 28);
            this.chkIDTAPIA.TabIndex = 24;
            this.chkIDTAPIA.Text = "JUAN TAPIA";
            this.chkIDTAPIA.UseVisualStyleBackColor = true;
            this.chkIDTAPIA.CheckedChanged += new System.EventHandler(this.chkIDTAPIA_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label2.Location = new System.Drawing.Point(100, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(261, 24);
            this.label2.TabIndex = 23;
            this.label2.Text = "IDENTIFICACION OPERARIO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Azure;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.15F);
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(197, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(398, 35);
            this.label1.TabIndex = 22;
            this.label1.Text = "CONTROL FLUJO Y NIVEL";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.lblAltura);
            this.panel2.Controls.Add(this.lblCaudal);
            this.panel2.Controls.Add(this.btnGrafica);
            this.panel2.Controls.Add(this.btbAceptar_);
            this.panel2.Controls.Add(this.txtCaudal);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 450);
            this.panel2.TabIndex = 33;
            this.panel2.Visible = false;
            // 
            // btnGrafica
            // 
            this.btnGrafica.Location = new System.Drawing.Point(626, 142);
            this.btnGrafica.Name = "btnGrafica";
            this.btnGrafica.Size = new System.Drawing.Size(135, 33);
            this.btnGrafica.TabIndex = 26;
            this.btnGrafica.Text = "GRAFICA";
            this.btnGrafica.UseVisualStyleBackColor = true;
            this.btnGrafica.Click += new System.EventHandler(this.btnGrafica_Click_1);
            // 
            // btbAceptar_
            // 
            this.btbAceptar_.Location = new System.Drawing.Point(626, 77);
            this.btbAceptar_.Name = "btbAceptar_";
            this.btbAceptar_.Size = new System.Drawing.Size(135, 33);
            this.btbAceptar_.TabIndex = 25;
            this.btbAceptar_.Text = "ACEPTAR";
            this.btbAceptar_.UseVisualStyleBackColor = true;
            this.btbAceptar_.Click += new System.EventHandler(this.btbAceptar__Click_1);
            // 
            // txtCaudal
            // 
            this.txtCaudal.Location = new System.Drawing.Point(399, 77);
            this.txtCaudal.Name = "txtCaudal";
            this.txtCaudal.Size = new System.Drawing.Size(221, 22);
            this.txtCaudal.TabIndex = 24;
            // 
            // lblCaudal
            // 
            this.lblCaudal.AutoSize = true;
            this.lblCaudal.Location = new System.Drawing.Point(76, 236);
            this.lblCaudal.Name = "lblCaudal";
            this.lblCaudal.Size = new System.Drawing.Size(68, 17);
            this.lblCaudal.TabIndex = 37;
            this.lblCaudal.Text = " lblcaudal";
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(85, 270);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(59, 17);
            this.lblAltura.TabIndex = 40;
            this.lblAltura.Text = "lblAltura";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblValvulaReal);
            this.panel3.Controls.Add(this.lblValvula);
            this.panel3.Controls.Add(this.lblPertenenciama);
            this.panel3.Controls.Add(this.lblPertenenciaal);
            this.panel3.Controls.Add(this.lblPertenencianm);
            this.panel3.Controls.Add(this.lblPertenenciab);
            this.panel3.Controls.Add(this.lblPertenenciamb);
            this.panel3.Controls.Add(this.btnVolver);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 450);
            this.panel3.TabIndex = 43;
            this.panel3.Visible = false;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(520, 365);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 51;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Visible = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click_1);
            // 
            // lblPertenenciamb
            // 
            this.lblPertenenciamb.AutoSize = true;
            this.lblPertenenciamb.Location = new System.Drawing.Point(58, 142);
            this.lblPertenenciamb.Name = "lblPertenenciamb";
            this.lblPertenenciamb.Size = new System.Drawing.Size(117, 17);
            this.lblPertenenciamb.TabIndex = 52;
            this.lblPertenenciamb.Text = "lblPertenenciamb";
            // 
            // lblPertenenciab
            // 
            this.lblPertenenciab.AutoSize = true;
            this.lblPertenenciab.Location = new System.Drawing.Point(120, 246);
            this.lblPertenenciab.Name = "lblPertenenciab";
            this.lblPertenenciab.Size = new System.Drawing.Size(46, 17);
            this.lblPertenenciab.TabIndex = 53;
            this.lblPertenenciab.Text = "label5";
            // 
            // lblPertenencianm
            // 
            this.lblPertenencianm.AutoSize = true;
            this.lblPertenencianm.Location = new System.Drawing.Point(102, 297);
            this.lblPertenencianm.Name = "lblPertenencianm";
            this.lblPertenencianm.Size = new System.Drawing.Size(46, 17);
            this.lblPertenencianm.TabIndex = 54;
            this.lblPertenencianm.Text = "label5";
            // 
            // lblPertenenciaal
            // 
            this.lblPertenenciaal.AutoSize = true;
            this.lblPertenenciaal.Location = new System.Drawing.Point(120, 270);
            this.lblPertenenciaal.Name = "lblPertenenciaal";
            this.lblPertenenciaal.Size = new System.Drawing.Size(46, 17);
            this.lblPertenenciaal.TabIndex = 55;
            this.lblPertenenciaal.Text = "label5";
            // 
            // lblPertenenciama
            // 
            this.lblPertenenciama.AutoSize = true;
            this.lblPertenenciama.Location = new System.Drawing.Point(101, 324);
            this.lblPertenenciama.Name = "lblPertenenciama";
            this.lblPertenenciama.Size = new System.Drawing.Size(46, 17);
            this.lblPertenenciama.TabIndex = 56;
            this.lblPertenenciama.Text = "label5";
            // 
            // lblValvula
            // 
            this.lblValvula.AutoSize = true;
            this.lblValvula.Location = new System.Drawing.Point(532, 158);
            this.lblValvula.Name = "lblValvula";
            this.lblValvula.Size = new System.Drawing.Size(46, 17);
            this.lblValvula.TabIndex = 57;
            this.lblValvula.Text = "label5";
            // 
            // lblValvulaReal
            // 
            this.lblValvulaReal.AutoSize = true;
            this.lblValvulaReal.Location = new System.Drawing.Point(558, 213);
            this.lblValvulaReal.Name = "lblValvulaReal";
            this.lblValvulaReal.Size = new System.Drawing.Size(46, 17);
            this.lblValvulaReal.TabIndex = 58;
            this.lblValvulaReal.Text = "label5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAcceder;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkIDBUSTOS;
        private System.Windows.Forms.CheckBox chkIDSAAVEDRA;
        private System.Windows.Forms.CheckBox chkIDRAMIREZ;
        private System.Windows.Forms.CheckBox chkIDTAPIA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnGrafica;
        private System.Windows.Forms.Button btbAceptar_;
        private System.Windows.Forms.TextBox txtCaudal;
        private System.Windows.Forms.Label lblCaudal;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lblPertenenciamb;
        private System.Windows.Forms.Label lblPertenencianm;
        private System.Windows.Forms.Label lblPertenenciab;
        private System.Windows.Forms.Label lblPertenenciama;
        private System.Windows.Forms.Label lblPertenenciaal;
        private System.Windows.Forms.Label lblValvula;
        private System.Windows.Forms.Label lblValvulaReal;
    }
}

