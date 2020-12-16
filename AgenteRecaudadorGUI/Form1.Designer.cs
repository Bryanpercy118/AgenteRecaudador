
namespace AgenteRecaudadorGUI
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
            this.Btonabrir = new FontAwesome.Sharp.IconButton();
            this.Agentetxt = new System.Windows.Forms.DataGridView();
            this.btonguardar = new FontAwesome.Sharp.IconButton();
            this.agenteBD = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAgente = new System.Windows.Forms.TextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label4 = new System.Windows.Forms.Label();
            this.CmbEstampilla = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CmbVigencia = new System.Windows.Forms.ComboBox();
            this.CmbMes = new System.Windows.Forms.ComboBox();
            this.BtnConsultar = new System.Windows.Forms.Button();
            this.BtnTotal = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtTotal = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Agentetxt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agenteBD)).BeginInit();
            this.SuspendLayout();
            // 
            // Btonabrir
            // 
            this.Btonabrir.BackColor = System.Drawing.Color.DarkGray;
            this.Btonabrir.FlatAppearance.BorderSize = 0;
            this.Btonabrir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btonabrir.ForeColor = System.Drawing.Color.Black;
            this.Btonabrir.IconChar = FontAwesome.Sharp.IconChar.FolderOpen;
            this.Btonabrir.IconColor = System.Drawing.Color.Maroon;
            this.Btonabrir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Btonabrir.IconSize = 20;
            this.Btonabrir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btonabrir.Location = new System.Drawing.Point(14, 65);
            this.Btonabrir.Name = "Btonabrir";
            this.Btonabrir.Size = new System.Drawing.Size(131, 33);
            this.Btonabrir.TabIndex = 0;
            this.Btonabrir.Text = "Abir Txt";
            this.Btonabrir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btonabrir.UseVisualStyleBackColor = false;
            this.Btonabrir.Click += new System.EventHandler(this.Btonabrir_Click);
            // 
            // Agentetxt
            // 
            this.Agentetxt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Agentetxt.Location = new System.Drawing.Point(160, 65);
            this.Agentetxt.Name = "Agentetxt";
            this.Agentetxt.Size = new System.Drawing.Size(498, 203);
            this.Agentetxt.TabIndex = 1;
            // 
            // btonguardar
            // 
            this.btonguardar.BackColor = System.Drawing.Color.DarkGray;
            this.btonguardar.FlatAppearance.BorderSize = 0;
            this.btonguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btonguardar.IconChar = FontAwesome.Sharp.IconChar.FileImport;
            this.btonguardar.IconColor = System.Drawing.Color.Maroon;
            this.btonguardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btonguardar.IconSize = 18;
            this.btonguardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btonguardar.Location = new System.Drawing.Point(14, 104);
            this.btonguardar.Name = "btonguardar";
            this.btonguardar.Size = new System.Drawing.Size(131, 33);
            this.btonguardar.TabIndex = 2;
            this.btonguardar.Text = "Enviar BD";
            this.btonguardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btonguardar.UseVisualStyleBackColor = false;
            this.btonguardar.Click += new System.EventHandler(this.btonguardar_Click);
            // 
            // agenteBD
            // 
            this.agenteBD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.agenteBD.Location = new System.Drawing.Point(729, 65);
            this.agenteBD.Name = "agenteBD";
            this.agenteBD.Size = new System.Drawing.Size(498, 203);
            this.agenteBD.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(257, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "T A B L A  A R C H I V O";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(869, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "T A B L A    B D";
            // 
            // iconButton1
            // 
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 15;
            this.iconButton1.Location = new System.Drawing.Point(220, 350);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(45, 23);
            this.iconButton1.TabIndex = 6;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 336);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "C O N S U L T A R     N I T";
            // 
            // txtAgente
            // 
            this.txtAgente.Location = new System.Drawing.Point(14, 352);
            this.txtAgente.Name = "txtAgente";
            this.txtAgente.Size = new System.Drawing.Size(186, 20);
            this.txtAgente.TabIndex = 9;
            this.txtAgente.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(766, 337);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "TIPO ESTAMPILLA";
            // 
            // CmbEstampilla
            // 
            this.CmbEstampilla.FormattingEnabled = true;
            this.CmbEstampilla.Items.AddRange(new object[] {
            "Adulto Mayor",
            "Pro Cultura",
            "Pro-UPC"});
            this.CmbEstampilla.Location = new System.Drawing.Point(770, 353);
            this.CmbEstampilla.Name = "CmbEstampilla";
            this.CmbEstampilla.Size = new System.Drawing.Size(140, 21);
            this.CmbEstampilla.TabIndex = 15;
            this.CmbEstampilla.SelectedIndexChanged += new System.EventHandler(this.CmbEstampilla_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(577, 336);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "VIGENCIA DEL RECAUDO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(389, 336);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "MES";
            // 
            // CmbVigencia
            // 
            this.CmbVigencia.FormattingEnabled = true;
            this.CmbVigencia.Items.AddRange(new object[] {
            "2020",
            "2019",
            "2018",
            "2017",
            "2016",
            "2015"});
            this.CmbVigencia.Location = new System.Drawing.Point(581, 353);
            this.CmbVigencia.Name = "CmbVigencia";
            this.CmbVigencia.Size = new System.Drawing.Size(140, 21);
            this.CmbVigencia.TabIndex = 12;
            // 
            // CmbMes
            // 
            this.CmbMes.FormattingEnabled = true;
            this.CmbMes.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.CmbMes.Location = new System.Drawing.Point(392, 352);
            this.CmbMes.Name = "CmbMes";
            this.CmbMes.Size = new System.Drawing.Size(140, 21);
            this.CmbMes.TabIndex = 11;
            // 
            // BtnConsultar
            // 
            this.BtnConsultar.Location = new System.Drawing.Point(926, 353);
            this.BtnConsultar.Name = "BtnConsultar";
            this.BtnConsultar.Size = new System.Drawing.Size(95, 23);
            this.BtnConsultar.TabIndex = 17;
            this.BtnConsultar.Text = "CONSULTAR";
            this.BtnConsultar.UseVisualStyleBackColor = true;
            this.BtnConsultar.Click += new System.EventHandler(this.BtnConsultar_Click);
            // 
            // BtnTotal
            // 
            this.BtnTotal.Location = new System.Drawing.Point(593, 480);
            this.BtnTotal.Name = "BtnTotal";
            this.BtnTotal.Size = new System.Drawing.Size(95, 23);
            this.BtnTotal.TabIndex = 20;
            this.BtnTotal.Text = "TOTAL";
            this.BtnTotal.UseVisualStyleBackColor = true;
            this.BtnTotal.Click += new System.EventHandler(this.BtnTotal_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(381, 485);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Total recaudado";
            // 
            // TxtTotal
            // 
            this.TxtTotal.Location = new System.Drawing.Point(487, 482);
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.Size = new System.Drawing.Size(100, 20);
            this.TxtTotal.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1245, 514);
            this.Controls.Add(this.BtnTotal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxtTotal);
            this.Controls.Add(this.BtnConsultar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CmbEstampilla);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CmbVigencia);
            this.Controls.Add(this.CmbMes);
            this.Controls.Add(this.txtAgente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.agenteBD);
            this.Controls.Add(this.btonguardar);
            this.Controls.Add(this.Agentetxt);
            this.Controls.Add(this.Btonabrir);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Agentetxt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agenteBD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton Btonabrir;
        private System.Windows.Forms.DataGridView Agentetxt;
        private FontAwesome.Sharp.IconButton btonguardar;
        private System.Windows.Forms.DataGridView agenteBD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAgente;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CmbEstampilla;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CmbVigencia;
        private System.Windows.Forms.ComboBox CmbMes;
        private System.Windows.Forms.Button BtnConsultar;
        private System.Windows.Forms.Button BtnTotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtTotal;
    }
}

