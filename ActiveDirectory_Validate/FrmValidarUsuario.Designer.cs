namespace ActiveDirectory_Validate
{
    partial class FrmValidarUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmValidarUsuario));
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnValidar = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDominio = new System.Windows.Forms.TextBox();
            this.txtInformacion = new System.Windows.Forms.TextBox();
            this.btnListarUsuarios = new System.Windows.Forms.Button();
            this.gvUsers = new DevExpress.XtraGrid.GridControl();
            this.viewUsers = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcAccountName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcDisplayName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcLastLogon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAdminPassword = new System.Windows.Forms.TextBox();
            this.txtAdminUser = new System.Windows.Forms.TextBox();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNuevaContraseña = new System.Windows.Forms.TextBox();
            this.btnCambiarContraseña = new System.Windows.Forms.Button();
            this.btnChangeImage = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gvUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUsuario
            // 
            this.txtUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUsuario.Location = new System.Drawing.Point(231, 85);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(169, 20);
            this.txtUsuario.TabIndex = 1;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(231, 111);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(169, 20);
            this.txtContraseña.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(166, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contraseña:";
            // 
            // btnValidar
            // 
            this.btnValidar.Location = new System.Drawing.Point(231, 161);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(83, 23);
            this.btnValidar.TabIndex = 6;
            this.btnValidar.Text = "Validar";
            this.btnValidar.UseVisualStyleBackColor = true;
            this.btnValidar.Click += new System.EventHandler(this.btnValidar_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResultado.Location = new System.Drawing.Point(634, 85);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResultado.Size = new System.Drawing.Size(376, 20);
            this.txtResultado.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Dominio:";
            // 
            // txtDominio
            // 
            this.txtDominio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDominio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDominio.Location = new System.Drawing.Point(78, 32);
            this.txtDominio.Name = "txtDominio";
            this.txtDominio.Size = new System.Drawing.Size(195, 21);
            this.txtDominio.TabIndex = 5;
            this.txtDominio.Text = "GRUPOREYES.ORG";
            this.txtDominio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtInformacion
            // 
            this.txtInformacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInformacion.Location = new System.Drawing.Point(635, 111);
            this.txtInformacion.Multiline = true;
            this.txtInformacion.Name = "txtInformacion";
            this.txtInformacion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtInformacion.Size = new System.Drawing.Size(376, 73);
            this.txtInformacion.TabIndex = 8;
            // 
            // btnListarUsuarios
            // 
            this.btnListarUsuarios.Location = new System.Drawing.Point(12, 344);
            this.btnListarUsuarios.Name = "btnListarUsuarios";
            this.btnListarUsuarios.Size = new System.Drawing.Size(93, 23);
            this.btnListarUsuarios.TabIndex = 9;
            this.btnListarUsuarios.Text = "Listar Usuarios";
            this.btnListarUsuarios.UseVisualStyleBackColor = true;
            this.btnListarUsuarios.Click += new System.EventHandler(this.btnListarUsuarios_Click);
            // 
            // gvUsers
            // 
            this.gvUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvUsers.Location = new System.Drawing.Point(128, 344);
            this.gvUsers.MainView = this.viewUsers;
            this.gvUsers.Name = "gvUsers";
            this.gvUsers.Size = new System.Drawing.Size(884, 213);
            this.gvUsers.TabIndex = 10;
            this.gvUsers.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.viewUsers});
            // 
            // viewUsers
            // 
            this.viewUsers.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcAccountName,
            this.gcDisplayName,
            this.gcEmail,
            this.gcStatus,
            this.gcLastLogon});
            this.viewUsers.GridControl = this.gvUsers;
            this.viewUsers.Name = "viewUsers";
            // 
            // gcAccountName
            // 
            this.gcAccountName.Caption = "Account Name";
            this.gcAccountName.FieldName = "AccountName";
            this.gcAccountName.Name = "gcAccountName";
            this.gcAccountName.Visible = true;
            this.gcAccountName.VisibleIndex = 0;
            // 
            // gcDisplayName
            // 
            this.gcDisplayName.Caption = "Display Name";
            this.gcDisplayName.FieldName = "DisplayName";
            this.gcDisplayName.Name = "gcDisplayName";
            this.gcDisplayName.Visible = true;
            this.gcDisplayName.VisibleIndex = 1;
            // 
            // gcEmail
            // 
            this.gcEmail.Caption = "Email";
            this.gcEmail.FieldName = "Email";
            this.gcEmail.Name = "gcEmail";
            this.gcEmail.Visible = true;
            this.gcEmail.VisibleIndex = 2;
            // 
            // gcStatus
            // 
            this.gcStatus.Caption = "Status";
            this.gcStatus.FieldName = "Status";
            this.gcStatus.Name = "gcStatus";
            this.gcStatus.Visible = true;
            this.gcStatus.VisibleIndex = 3;
            // 
            // gcLastLogon
            // 
            this.gcLastLogon.Caption = "LastLogon";
            this.gcLastLogon.FieldName = "LastLogon";
            this.gcLastLogon.Name = "gcLastLogon";
            this.gcLastLogon.Visible = true;
            this.gcLastLogon.VisibleIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ActiveDirectory_Validate.Properties.Resources.ReportReymaBio;
            this.pictureBox1.Location = new System.Drawing.Point(6, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(545, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Contraseña:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(309, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Usuario:";
            // 
            // txtAdminPassword
            // 
            this.txtAdminPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAdminPassword.Location = new System.Drawing.Point(616, 32);
            this.txtAdminPassword.Name = "txtAdminPassword";
            this.txtAdminPassword.Size = new System.Drawing.Size(217, 21);
            this.txtAdminPassword.TabIndex = 15;
            // 
            // txtAdminUser
            // 
            this.txtAdminUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAdminUser.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAdminUser.Location = new System.Drawing.Point(362, 32);
            this.txtAdminUser.Name = "txtAdminUser";
            this.txtAdminUser.Size = new System.Drawing.Size(169, 21);
            this.txtAdminUser.TabIndex = 13;
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.txtDominio);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.txtAdminUser);
            this.groupControl1.Controls.Add(this.txtAdminPassword);
            this.groupControl1.Location = new System.Drawing.Point(166, 7);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(845, 65);
            this.groupControl1.TabIndex = 16;
            this.groupControl1.Text = "Información de Dominio y Administrador";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(475, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Contraseña Nueva";
            // 
            // txtNuevaContraseña
            // 
            this.txtNuevaContraseña.Location = new System.Drawing.Point(432, 111);
            this.txtNuevaContraseña.Name = "txtNuevaContraseña";
            this.txtNuevaContraseña.Size = new System.Drawing.Size(188, 20);
            this.txtNuevaContraseña.TabIndex = 18;
            // 
            // btnCambiarContraseña
            // 
            this.btnCambiarContraseña.Location = new System.Drawing.Point(472, 161);
            this.btnCambiarContraseña.Name = "btnCambiarContraseña";
            this.btnCambiarContraseña.Size = new System.Drawing.Size(117, 23);
            this.btnCambiarContraseña.TabIndex = 19;
            this.btnCambiarContraseña.Text = "Cambiar Contraseña";
            this.btnCambiarContraseña.UseVisualStyleBackColor = true;
            this.btnCambiarContraseña.Click += new System.EventHandler(this.btnCambiarContraseña_Click);
            // 
            // btnChangeImage
            // 
            this.btnChangeImage.Location = new System.Drawing.Point(6, 534);
            this.btnChangeImage.Name = "btnChangeImage";
            this.btnChangeImage.Size = new System.Drawing.Size(88, 23);
            this.btnChangeImage.TabIndex = 20;
            this.btnChangeImage.Text = "Change Image";
            this.btnChangeImage.UseVisualStyleBackColor = true;
            this.btnChangeImage.Click += new System.EventHandler(this.btnChangeImage_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = global::ActiveDirectory_Validate.Properties.Resources.ReportReymaBio;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1024, 569);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // FrmValidarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 569);
            this.Controls.Add(this.btnChangeImage);
            this.Controls.Add(this.btnCambiarContraseña);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNuevaContraseña);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gvUsers);
            this.Controls.Add(this.btnListarUsuarios);
            this.Controls.Add(this.txtInformacion);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.btnValidar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.pictureBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmValidarUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Validar Usuario ActiveDirectory";
            ((System.ComponentModel.ISupportInitialize)(this.gvUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnValidar;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDominio;
        private System.Windows.Forms.TextBox txtInformacion;
        private System.Windows.Forms.Button btnListarUsuarios;
        private DevExpress.XtraGrid.GridControl gvUsers;
        private DevExpress.XtraGrid.Views.Grid.GridView viewUsers;
        private DevExpress.XtraGrid.Columns.GridColumn gcAccountName;
        private DevExpress.XtraGrid.Columns.GridColumn gcDisplayName;
        private DevExpress.XtraGrid.Columns.GridColumn gcEmail;
        private DevExpress.XtraGrid.Columns.GridColumn gcStatus;
        private DevExpress.XtraGrid.Columns.GridColumn gcLastLogon;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAdminPassword;
        private System.Windows.Forms.TextBox txtAdminUser;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNuevaContraseña;
        private System.Windows.Forms.Button btnCambiarContraseña;
        private System.Windows.Forms.Button btnChangeImage;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

