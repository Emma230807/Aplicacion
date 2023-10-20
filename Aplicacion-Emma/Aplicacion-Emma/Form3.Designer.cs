
namespace Aplicacion_Emma
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DTGVv = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clasificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lanzamiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Compañia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Presio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txnombre = new System.Windows.Forms.TextBox();
            this.lbnombre = new System.Windows.Forms.Label();
            this.txclasificacion = new System.Windows.Forms.TextBox();
            this.lbclasificacion = new System.Windows.Forms.Label();
            this.txaño = new System.Windows.Forms.TextBox();
            this.lbaño = new System.Windows.Forms.Label();
            this.txcategoria = new System.Windows.Forms.TextBox();
            this.lbcategoria = new System.Windows.Forms.Label();
            this.txcompañia = new System.Windows.Forms.TextBox();
            this.lbcompañia = new System.Windows.Forms.Label();
            this.txgb = new System.Windows.Forms.TextBox();
            this.lbgb = new System.Windows.Forms.Label();
            this.txprecio = new System.Windows.Forms.TextBox();
            this.lbprecio = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.Pcontainer2 = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.lbcodigo = new System.Windows.Forms.Label();
            this.txcodigo = new System.Windows.Forms.TextBox();
            this.PBcodigo = new System.Windows.Forms.PictureBox();
            this.PBprecio = new System.Windows.Forms.PictureBox();
            this.PBclasificacion = new System.Windows.Forms.PictureBox();
            this.PBcategoria = new System.Windows.Forms.PictureBox();
            this.PBnombre = new System.Windows.Forms.PictureBox();
            this.PBcompañia = new System.Windows.Forms.PictureBox();
            this.PBgb = new System.Windows.Forms.PictureBox();
            this.PBaño = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DTGVv)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.Pcontainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBcodigo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBprecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBclasificacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBcategoria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBnombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBcompañia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBgb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBaño)).BeginInit();
            this.SuspendLayout();
            // 
            // DTGVv
            // 
            this.DTGVv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTGVv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.Clasificacion,
            this.Lanzamiento,
            this.Compañia,
            this.Categoria,
            this.GB,
            this.Presio});
            this.DTGVv.Location = new System.Drawing.Point(28, 27);
            this.DTGVv.Margin = new System.Windows.Forms.Padding(4);
            this.DTGVv.Name = "DTGVv";
            this.DTGVv.RowHeadersWidth = 51;
            this.DTGVv.Size = new System.Drawing.Size(1053, 208);
            this.DTGVv.TabIndex = 0;
            this.DTGVv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DTGVv_CellClick);
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo del juego";
            this.Codigo.MinimumWidth = 6;
            this.Codigo.Name = "Codigo";
            this.Codigo.Width = 125;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre del juego";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 125;
            // 
            // Clasificacion
            // 
            this.Clasificacion.HeaderText = "Clasificacion del juego";
            this.Clasificacion.MinimumWidth = 6;
            this.Clasificacion.Name = "Clasificacion";
            this.Clasificacion.Width = 125;
            // 
            // Lanzamiento
            // 
            this.Lanzamiento.HeaderText = "Año de lanzamiento";
            this.Lanzamiento.MinimumWidth = 6;
            this.Lanzamiento.Name = "Lanzamiento";
            this.Lanzamiento.Width = 125;
            // 
            // Compañia
            // 
            this.Compañia.HeaderText = "Compañia desarroolladora";
            this.Compañia.MinimumWidth = 6;
            this.Compañia.Name = "Compañia";
            this.Compañia.Width = 125;
            // 
            // Categoria
            // 
            this.Categoria.HeaderText = "Categoria del juego ";
            this.Categoria.MinimumWidth = 6;
            this.Categoria.Name = "Categoria";
            this.Categoria.Width = 125;
            // 
            // GB
            // 
            this.GB.HeaderText = "Peso en GB";
            this.GB.MinimumWidth = 6;
            this.GB.Name = "GB";
            this.GB.Width = 125;
            // 
            // Presio
            // 
            this.Presio.HeaderText = "Precio del juego";
            this.Presio.MinimumWidth = 6;
            this.Presio.Name = "Presio";
            this.Presio.Width = 125;
            // 
            // txnombre
            // 
            this.txnombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txnombre.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txnombre.Location = new System.Drawing.Point(243, 322);
            this.txnombre.Margin = new System.Windows.Forms.Padding(4);
            this.txnombre.Name = "txnombre";
            this.txnombre.Size = new System.Drawing.Size(132, 20);
            this.txnombre.TabIndex = 4;
            this.txnombre.Tag = "nombre";
            this.txnombre.Enter += new System.EventHandler(this.txcodigo_Enter);
            this.txnombre.Leave += new System.EventHandler(this.txcodigo_Leave);
            // 
            // lbnombre
            // 
            this.lbnombre.AutoSize = true;
            this.lbnombre.BackColor = System.Drawing.Color.White;
            this.lbnombre.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lbnombre.Location = new System.Drawing.Point(243, 299);
            this.lbnombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbnombre.Name = "lbnombre";
            this.lbnombre.Size = new System.Drawing.Size(77, 23);
            this.lbnombre.TabIndex = 3;
            this.lbnombre.Text = "Nombre";
            // 
            // txclasificacion
            // 
            this.txclasificacion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txclasificacion.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txclasificacion.Location = new System.Drawing.Point(385, 322);
            this.txclasificacion.Margin = new System.Windows.Forms.Padding(4);
            this.txclasificacion.Name = "txclasificacion";
            this.txclasificacion.Size = new System.Drawing.Size(132, 20);
            this.txclasificacion.TabIndex = 6;
            this.txclasificacion.Tag = "clasificacion";
            this.txclasificacion.Enter += new System.EventHandler(this.txcodigo_Enter);
            this.txclasificacion.Leave += new System.EventHandler(this.txcodigo_Leave);
            // 
            // lbclasificacion
            // 
            this.lbclasificacion.AutoSize = true;
            this.lbclasificacion.BackColor = System.Drawing.Color.White;
            this.lbclasificacion.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lbclasificacion.Location = new System.Drawing.Point(385, 299);
            this.lbclasificacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbclasificacion.Name = "lbclasificacion";
            this.lbclasificacion.Size = new System.Drawing.Size(117, 23);
            this.lbclasificacion.TabIndex = 5;
            this.lbclasificacion.Text = "Clasificacion";
            // 
            // txaño
            // 
            this.txaño.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txaño.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txaño.Location = new System.Drawing.Point(531, 322);
            this.txaño.Margin = new System.Windows.Forms.Padding(4);
            this.txaño.Name = "txaño";
            this.txaño.Size = new System.Drawing.Size(132, 20);
            this.txaño.TabIndex = 8;
            this.txaño.Tag = "año";
            this.txaño.Enter += new System.EventHandler(this.txcodigo_Enter);
            this.txaño.Leave += new System.EventHandler(this.txcodigo_Leave);
            // 
            // lbaño
            // 
            this.lbaño.AutoSize = true;
            this.lbaño.BackColor = System.Drawing.Color.White;
            this.lbaño.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lbaño.Location = new System.Drawing.Point(531, 299);
            this.lbaño.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbaño.Name = "lbaño";
            this.lbaño.Size = new System.Drawing.Size(45, 23);
            this.lbaño.TabIndex = 7;
            this.lbaño.Text = "Año";
            this.lbaño.Click += new System.EventHandler(this.lbaño_Click);
            // 
            // txcategoria
            // 
            this.txcategoria.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txcategoria.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txcategoria.Location = new System.Drawing.Point(243, 420);
            this.txcategoria.Margin = new System.Windows.Forms.Padding(4);
            this.txcategoria.Name = "txcategoria";
            this.txcategoria.Size = new System.Drawing.Size(132, 20);
            this.txcategoria.TabIndex = 10;
            this.txcategoria.Tag = "categoria";
            this.txcategoria.Enter += new System.EventHandler(this.txcodigo_Enter);
            this.txcategoria.Leave += new System.EventHandler(this.txcodigo_Leave);
            // 
            // lbcategoria
            // 
            this.lbcategoria.AutoSize = true;
            this.lbcategoria.BackColor = System.Drawing.Color.White;
            this.lbcategoria.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lbcategoria.Location = new System.Drawing.Point(243, 397);
            this.lbcategoria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbcategoria.Name = "lbcategoria";
            this.lbcategoria.Size = new System.Drawing.Size(94, 23);
            this.lbcategoria.TabIndex = 9;
            this.lbcategoria.Text = "Categoria";
            // 
            // txcompañia
            // 
            this.txcompañia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txcompañia.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txcompañia.Location = new System.Drawing.Point(99, 420);
            this.txcompañia.Margin = new System.Windows.Forms.Padding(4);
            this.txcompañia.Name = "txcompañia";
            this.txcompañia.Size = new System.Drawing.Size(132, 20);
            this.txcompañia.TabIndex = 12;
            this.txcompañia.Tag = "compañia";
            this.txcompañia.Enter += new System.EventHandler(this.txcodigo_Enter);
            this.txcompañia.Leave += new System.EventHandler(this.txcodigo_Leave);
            // 
            // lbcompañia
            // 
            this.lbcompañia.AutoSize = true;
            this.lbcompañia.BackColor = System.Drawing.Color.White;
            this.lbcompañia.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lbcompañia.Location = new System.Drawing.Point(99, 397);
            this.lbcompañia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbcompañia.Name = "lbcompañia";
            this.lbcompañia.Size = new System.Drawing.Size(95, 23);
            this.lbcompañia.TabIndex = 11;
            this.lbcompañia.Text = "Compañia";
            // 
            // txgb
            // 
            this.txgb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txgb.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txgb.Location = new System.Drawing.Point(385, 420);
            this.txgb.Margin = new System.Windows.Forms.Padding(4);
            this.txgb.Name = "txgb";
            this.txgb.Size = new System.Drawing.Size(132, 20);
            this.txgb.TabIndex = 14;
            this.txgb.Tag = "gb";
            this.txgb.Enter += new System.EventHandler(this.txcodigo_Enter);
            this.txgb.Leave += new System.EventHandler(this.txcodigo_Leave);
            // 
            // lbgb
            // 
            this.lbgb.AutoSize = true;
            this.lbgb.BackColor = System.Drawing.Color.White;
            this.lbgb.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lbgb.Location = new System.Drawing.Point(385, 397);
            this.lbgb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbgb.Name = "lbgb";
            this.lbgb.Size = new System.Drawing.Size(39, 23);
            this.lbgb.TabIndex = 13;
            this.lbgb.Text = "GB";
            // 
            // txprecio
            // 
            this.txprecio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txprecio.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txprecio.Location = new System.Drawing.Point(531, 420);
            this.txprecio.Margin = new System.Windows.Forms.Padding(4);
            this.txprecio.Name = "txprecio";
            this.txprecio.Size = new System.Drawing.Size(132, 20);
            this.txprecio.TabIndex = 16;
            this.txprecio.Tag = "precio";
            this.txprecio.Enter += new System.EventHandler(this.txcodigo_Enter);
            this.txprecio.Leave += new System.EventHandler(this.txcodigo_Leave);
            // 
            // lbprecio
            // 
            this.lbprecio.AutoSize = true;
            this.lbprecio.BackColor = System.Drawing.Color.White;
            this.lbprecio.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lbprecio.Location = new System.Drawing.Point(531, 397);
            this.lbprecio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbprecio.Name = "lbprecio";
            this.lbprecio.Size = new System.Drawing.Size(64, 23);
            this.lbprecio.TabIndex = 15;
            this.lbprecio.Text = "Precio";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(762, 341);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 18;
            this.button1.Text = "Adicionar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(762, 397);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 19;
            this.button2.Text = "Borrar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1135, 535);
            this.panel1.TabIndex = 20;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(4, 4);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1127, 528);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(4, 4);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1119, 521);
            this.panel3.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Silver;
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Location = new System.Drawing.Point(4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1112, 514);
            this.panel4.TabIndex = 20;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel5.Controls.Add(this.Pcontainer2);
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1106, 508);
            this.panel5.TabIndex = 0;
            // 
            // Pcontainer2
            // 
            this.Pcontainer2.BackColor = System.Drawing.Color.White;
            this.Pcontainer2.Controls.Add(this.button2);
            this.Pcontainer2.Controls.Add(this.txcompañia);
            this.Pcontainer2.Controls.Add(this.button1);
            this.Pcontainer2.Controls.Add(this.checkBox1);
            this.Pcontainer2.Controls.Add(this.txcategoria);
            this.Pcontainer2.Controls.Add(this.lbprecio);
            this.Pcontainer2.Controls.Add(this.lbcodigo);
            this.Pcontainer2.Controls.Add(this.lbclasificacion);
            this.Pcontainer2.Controls.Add(this.lbgb);
            this.Pcontainer2.Controls.Add(this.lbnombre);
            this.Pcontainer2.Controls.Add(this.txcodigo);
            this.Pcontainer2.Controls.Add(this.lbcompañia);
            this.Pcontainer2.Controls.Add(this.PBcodigo);
            this.Pcontainer2.Controls.Add(this.lbcategoria);
            this.Pcontainer2.Controls.Add(this.txnombre);
            this.Pcontainer2.Controls.Add(this.txgb);
            this.Pcontainer2.Controls.Add(this.txclasificacion);
            this.Pcontainer2.Controls.Add(this.txprecio);
            this.Pcontainer2.Controls.Add(this.PBprecio);
            this.Pcontainer2.Controls.Add(this.PBclasificacion);
            this.Pcontainer2.Controls.Add(this.PBcategoria);
            this.Pcontainer2.Controls.Add(this.PBnombre);
            this.Pcontainer2.Controls.Add(this.PBcompañia);
            this.Pcontainer2.Controls.Add(this.PBgb);
            this.Pcontainer2.Controls.Add(this.lbaño);
            this.Pcontainer2.Controls.Add(this.txaño);
            this.Pcontainer2.Controls.Add(this.PBaño);
            this.Pcontainer2.Controls.Add(this.DTGVv);
            this.Pcontainer2.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pcontainer2.Location = new System.Drawing.Point(3, 3);
            this.Pcontainer2.Name = "Pcontainer2";
            this.Pcontainer2.Size = new System.Drawing.Size(1103, 502);
            this.Pcontainer2.TabIndex = 0;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(994, 457);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(88, 21);
            this.checkBox1.TabIndex = 20;
            this.checkBox1.Text = "Finalizar ";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // lbcodigo
            // 
            this.lbcodigo.AutoSize = true;
            this.lbcodigo.BackColor = System.Drawing.Color.White;
            this.lbcodigo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lbcodigo.Location = new System.Drawing.Point(98, 299);
            this.lbcodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbcodigo.Name = "lbcodigo";
            this.lbcodigo.Size = new System.Drawing.Size(69, 23);
            this.lbcodigo.TabIndex = 17;
            this.lbcodigo.Text = "Codigo";
            // 
            // txcodigo
            // 
            this.txcodigo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txcodigo.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txcodigo.Location = new System.Drawing.Point(98, 322);
            this.txcodigo.Margin = new System.Windows.Forms.Padding(4);
            this.txcodigo.Name = "txcodigo";
            this.txcodigo.Size = new System.Drawing.Size(132, 20);
            this.txcodigo.TabIndex = 18;
            this.txcodigo.Tag = "codigo";
            this.txcodigo.Enter += new System.EventHandler(this.txcodigo_Enter);
            this.txcodigo.Leave += new System.EventHandler(this.txcodigo_Leave);
            // 
            // PBcodigo
            // 
            this.PBcodigo.BackColor = System.Drawing.Color.Black;
            this.PBcodigo.Location = new System.Drawing.Point(94, 318);
            this.PBcodigo.Name = "PBcodigo";
            this.PBcodigo.Size = new System.Drawing.Size(140, 29);
            this.PBcodigo.TabIndex = 19;
            this.PBcodigo.TabStop = false;
            // 
            // PBprecio
            // 
            this.PBprecio.BackColor = System.Drawing.Color.Black;
            this.PBprecio.Location = new System.Drawing.Point(527, 416);
            this.PBprecio.Name = "PBprecio";
            this.PBprecio.Size = new System.Drawing.Size(140, 29);
            this.PBprecio.TabIndex = 15;
            this.PBprecio.TabStop = false;
            // 
            // PBclasificacion
            // 
            this.PBclasificacion.BackColor = System.Drawing.Color.Black;
            this.PBclasificacion.Location = new System.Drawing.Point(381, 318);
            this.PBclasificacion.Name = "PBclasificacion";
            this.PBclasificacion.Size = new System.Drawing.Size(140, 29);
            this.PBclasificacion.TabIndex = 14;
            this.PBclasificacion.TabStop = false;
            // 
            // PBcategoria
            // 
            this.PBcategoria.BackColor = System.Drawing.Color.Black;
            this.PBcategoria.Location = new System.Drawing.Point(239, 416);
            this.PBcategoria.Name = "PBcategoria";
            this.PBcategoria.Size = new System.Drawing.Size(140, 29);
            this.PBcategoria.TabIndex = 13;
            this.PBcategoria.TabStop = false;
            // 
            // PBnombre
            // 
            this.PBnombre.BackColor = System.Drawing.Color.Black;
            this.PBnombre.Location = new System.Drawing.Point(239, 318);
            this.PBnombre.Name = "PBnombre";
            this.PBnombre.Size = new System.Drawing.Size(140, 29);
            this.PBnombre.TabIndex = 12;
            this.PBnombre.TabStop = false;
            // 
            // PBcompañia
            // 
            this.PBcompañia.BackColor = System.Drawing.Color.Black;
            this.PBcompañia.Location = new System.Drawing.Point(95, 416);
            this.PBcompañia.Name = "PBcompañia";
            this.PBcompañia.Size = new System.Drawing.Size(140, 29);
            this.PBcompañia.TabIndex = 11;
            this.PBcompañia.TabStop = false;
            // 
            // PBgb
            // 
            this.PBgb.BackColor = System.Drawing.Color.Black;
            this.PBgb.Location = new System.Drawing.Point(381, 416);
            this.PBgb.Name = "PBgb";
            this.PBgb.Size = new System.Drawing.Size(140, 29);
            this.PBgb.TabIndex = 9;
            this.PBgb.TabStop = false;
            this.PBgb.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // PBaño
            // 
            this.PBaño.BackColor = System.Drawing.Color.Black;
            this.PBaño.Location = new System.Drawing.Point(527, 318);
            this.PBaño.Name = "PBaño";
            this.PBaño.Size = new System.Drawing.Size(140, 29);
            this.PBaño.TabIndex = 1;
            this.PBaño.TabStop = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 535);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.DTGVv)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.Pcontainer2.ResumeLayout(false);
            this.Pcontainer2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBcodigo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBprecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBclasificacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBcategoria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBnombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBcompañia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBgb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBaño)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DTGVv;
        private System.Windows.Forms.TextBox txnombre;
        private System.Windows.Forms.Label lbnombre;
        private System.Windows.Forms.TextBox txclasificacion;
        private System.Windows.Forms.Label lbclasificacion;
        private System.Windows.Forms.TextBox txaño;
        private System.Windows.Forms.Label lbaño;
        private System.Windows.Forms.TextBox txcategoria;
        private System.Windows.Forms.Label lbcategoria;
        private System.Windows.Forms.TextBox txcompañia;
        private System.Windows.Forms.Label lbcompañia;
        private System.Windows.Forms.TextBox txgb;
        private System.Windows.Forms.Label lbgb;
        private System.Windows.Forms.TextBox txprecio;
        private System.Windows.Forms.Label lbprecio;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel Pcontainer2;
        private System.Windows.Forms.PictureBox PBaño;
        private System.Windows.Forms.PictureBox PBgb;
        private System.Windows.Forms.PictureBox PBprecio;
        private System.Windows.Forms.PictureBox PBclasificacion;
        private System.Windows.Forms.PictureBox PBcategoria;
        private System.Windows.Forms.PictureBox PBnombre;
        private System.Windows.Forms.PictureBox PBcompañia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clasificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lanzamiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Compañia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn GB;
        private System.Windows.Forms.DataGridViewTextBoxColumn Presio;
        private System.Windows.Forms.Label lbcodigo;
        private System.Windows.Forms.TextBox txcodigo;
        private System.Windows.Forms.PictureBox PBcodigo;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}