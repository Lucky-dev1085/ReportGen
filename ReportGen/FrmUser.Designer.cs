namespace ReportGen
{
    partial class FrmUser
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label passLabel;
            System.Windows.Forms.Label userNameLabel;
            System.Windows.Forms.Label jobLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label con_PassLabel;
            System.Windows.Forms.Label is_ActiveLabel;
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label roleLabel;
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton6 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton7 = new DevExpress.XtraEditors.SimpleButton();
            this.ChFraDataSet = new ReportGen.ChFraDataSet();
            this.loginBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loginTableAdapter = new ReportGen.ChFraDataSetTableAdapters.LoginTableAdapter();
            this.tableAdapterManager = new ReportGen.ChFraDataSetTableAdapters.TableAdapterManager();
            this.nameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.passTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.userNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.jobTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.emailTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.con_PassTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.loginGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPass = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCon_Pass = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colJob = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIs_Active = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRole = new DevExpress.XtraGrid.Columns.GridColumn();
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            this.is_ActiveCheckBox = new System.Windows.Forms.CheckBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.roleComboBox = new System.Windows.Forms.ComboBox();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            nameLabel = new System.Windows.Forms.Label();
            passLabel = new System.Windows.Forms.Label();
            userNameLabel = new System.Windows.Forms.Label();
            jobLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            con_PassLabel = new System.Windows.Forms.Label();
            is_ActiveLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            roleLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ChFraDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.con_PassTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            nameLabel.AutoSize = true;
            nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nameLabel.Location = new System.Drawing.Point(41, 19);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(45, 16);
            nameLabel.TabIndex = 49;
            nameLabel.Text = "Name";
            // 
            // passLabel
            // 
            passLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            passLabel.AutoSize = true;
            passLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            passLabel.Location = new System.Drawing.Point(18, 127);
            passLabel.Name = "passLabel";
            passLabel.Size = new System.Drawing.Size(68, 16);
            passLabel.TabIndex = 50;
            passLabel.Text = "Password";
            // 
            // userNameLabel
            // 
            userNameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            userNameLabel.AutoSize = true;
            userNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            userNameLabel.Location = new System.Drawing.Point(9, 75);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new System.Drawing.Size(77, 16);
            userNameLabel.TabIndex = 52;
            userNameLabel.Text = "User Name";
            // 
            // jobLabel
            // 
            jobLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            jobLabel.AutoSize = true;
            jobLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            jobLabel.Location = new System.Drawing.Point(534, 77);
            jobLabel.Name = "jobLabel";
            jobLabel.Size = new System.Drawing.Size(40, 16);
            jobLabel.TabIndex = 53;
            jobLabel.Text = "Work";
            // 
            // emailLabel
            // 
            emailLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            emailLabel.AutoSize = true;
            emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            emailLabel.Location = new System.Drawing.Point(528, 131);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(46, 16);
            emailLabel.TabIndex = 54;
            emailLabel.Text = "E-mail";
            // 
            // con_PassLabel
            // 
            con_PassLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            con_PassLabel.AutoSize = true;
            con_PassLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            con_PassLabel.Location = new System.Drawing.Point(458, 19);
            con_PassLabel.Name = "con_PassLabel";
            con_PassLabel.Size = new System.Drawing.Size(116, 16);
            con_PassLabel.TabIndex = 55;
            con_PassLabel.Text = "Confirm Password";
            // 
            // is_ActiveLabel
            // 
            is_ActiveLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            is_ActiveLabel.AutoSize = true;
            is_ActiveLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            is_ActiveLabel.Location = new System.Drawing.Point(548, 167);
            is_ActiveLabel.Name = "is_ActiveLabel";
            is_ActiveLabel.Size = new System.Drawing.Size(58, 16);
            is_ActiveLabel.TabIndex = 57;
            is_ActiveLabel.Text = "Is Active";
            // 
            // idLabel
            // 
            idLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            idLabel.AutoSize = true;
            idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            idLabel.Location = new System.Drawing.Point(65, 165);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(21, 16);
            idLabel.TabIndex = 58;
            idLabel.Text = "ID";
            // 
            // roleLabel
            // 
            roleLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            roleLabel.AutoSize = true;
            roleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            roleLabel.Location = new System.Drawing.Point(166, 167);
            roleLabel.Name = "roleLabel";
            roleLabel.Size = new System.Drawing.Size(37, 16);
            roleLabel.TabIndex = 59;
            roleLabel.Text = "Role";
            // 
            // simpleButton4
            // 
            this.simpleButton4.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton4.Appearance.Options.UseFont = true;
            this.simpleButton4.Enabled = false;
            this.simpleButton4.Location = new System.Drawing.Point(499, 435);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(134, 36);
            this.simpleButton4.TabIndex = 47;
            this.simpleButton4.Text = "&Save";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // simpleButton5
            // 
            this.simpleButton5.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton5.Appearance.Options.UseFont = true;
            this.simpleButton5.Location = new System.Drawing.Point(43, 435);
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.Size = new System.Drawing.Size(134, 36);
            this.simpleButton5.TabIndex = 44;
            this.simpleButton5.Text = "&Edit";
            this.simpleButton5.Click += new System.EventHandler(this.SimpleButton5_Click);
            // 
            // simpleButton6
            // 
            this.simpleButton6.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton6.Appearance.Options.UseFont = true;
            this.simpleButton6.Location = new System.Drawing.Point(191, 435);
            this.simpleButton6.Name = "simpleButton6";
            this.simpleButton6.Size = new System.Drawing.Size(134, 36);
            this.simpleButton6.TabIndex = 45;
            this.simpleButton6.Text = "&Remove";
            this.simpleButton6.Click += new System.EventHandler(this.simpleButton6_Click);
            // 
            // simpleButton7
            // 
            this.simpleButton7.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton7.Appearance.Options.UseFont = true;
            this.simpleButton7.Location = new System.Drawing.Point(344, 435);
            this.simpleButton7.Name = "simpleButton7";
            this.simpleButton7.Size = new System.Drawing.Size(134, 36);
            this.simpleButton7.TabIndex = 46;
            this.simpleButton7.Text = "&New";
            this.simpleButton7.Click += new System.EventHandler(this.simpleButton7_Click);
            // 
            // ChFraDataSet
            // 
            this.ChFraDataSet.DataSetName = "ChFraDataSet";
            this.ChFraDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // loginBindingSource
            // 
            this.loginBindingSource.DataMember = "Login";
            this.loginBindingSource.DataSource = this.ChFraDataSet;
            // 
            // loginTableAdapter
            // 
            this.loginTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.admAcumuladosTableAdapter = null;
            this.tableAdapterManager.admAcumuladosTiposTableAdapter = null;
            this.tableAdapterManager.admAgentesTableAdapter = null;
            this.tableAdapterManager.admAlmacenesTableAdapter = null;
            this.tableAdapterManager.admAsientosContablesTableAdapter = null;
            this.tableAdapterManager.admAsocAcumConceptosTableAdapter = null;
            this.tableAdapterManager.admAsocCargosAbonosTableAdapter = null;
            this.tableAdapterManager.admBanderasTableAdapter = null;
            this.tableAdapterManager.admBitacorasTableAdapter = null;
            this.tableAdapterManager.admCapasProductoTableAdapter = null;
            this.tableAdapterManager.admCaracteristicasTableAdapter = null;
            this.tableAdapterManager.admCaracteristicasValoresTableAdapter = null;
            this.tableAdapterManager.admClasificacionesTableAdapter = null;
            this.tableAdapterManager.admClasificacionesValoresTableAdapter = null;
            this.tableAdapterManager.admClientesTableAdapter = null;
            this.tableAdapterManager.admComponentesPaqueteTableAdapter = null;
            this.tableAdapterManager.admConceptosBackTableAdapter = null;
            this.tableAdapterManager.admConceptosTableAdapter = null;
            this.tableAdapterManager.admConversionesUnidadTableAdapter = null;
            this.tableAdapterManager.admCostosHistoricosTableAdapter = null;
            this.tableAdapterManager.admCuentasBancariasTableAdapter = null;
            this.tableAdapterManager.admDatosAddendaTableAdapter = null;
            this.tableAdapterManager.admDocumentosModelosBackTableAdapter = null;
            this.tableAdapterManager.admDocumentosModeloTableAdapter = null;
            this.tableAdapterManager.admDocumentosTableAdapter = null;
            this.tableAdapterManager.admDomiciliosTableAdapter = null;
            this.tableAdapterManager.admEjerciciosTableAdapter = null;
            this.tableAdapterManager.admExistenciaCostoTableAdapter = null;
            this.tableAdapterManager.admFoliosDigitalesTableAdapter = null;
            this.tableAdapterManager.admMaximosMinimosTableAdapter = null;
            this.tableAdapterManager.admMonedasTableAdapter = null;
            this.tableAdapterManager.admMovimientosCapasTableAdapter = null;
            this.tableAdapterManager.admMovimientosContablesTableAdapter = null;
            this.tableAdapterManager.admMovimientosPrepolizaTableAdapter = null;
            this.tableAdapterManager.admMovimientosSerieTableAdapter = null;
            this.tableAdapterManager.admMovimientosTableAdapter = null;
            this.tableAdapterManager.admMovtosBancariosTableAdapter = null;
            this.tableAdapterManager.admMovtosCEPsTableAdapter = null;
            this.tableAdapterManager.admMovtosInvFisicoSerieCaTableAdapter = null;
            this.tableAdapterManager.admMovtosInvFisicoTableAdapter = null;
            this.tableAdapterManager.admNumerosSerieTableAdapter = null;
            this.tableAdapterManager.admParametrosBackTableAdapter = null;
            this.tableAdapterManager.admParametrosTableAdapter = null;
            this.tableAdapterManager.admPreciosCompraTableAdapter = null;
            this.tableAdapterManager.admPrepolizasTableAdapter = null;
            this.tableAdapterManager.admProductosDetallesTableAdapter = null;
            this.tableAdapterManager.admProductosFotosTableAdapter = null;
            this.tableAdapterManager.admProductosTableAdapter = null;
            this.tableAdapterManager.admPromocionesTableAdapter = null;
            this.tableAdapterManager.admProyectosTableAdapter = null;
            this.tableAdapterManager.admSATSegmentosTableAdapter = null;
            this.tableAdapterManager.admTiposCambioTableAdapter = null;
            this.tableAdapterManager.admUnidadesMedidaPesoTableAdapter = null;
            this.tableAdapterManager.admVistasCamposTableAdapter = null;
            this.tableAdapterManager.admVistasConsultasTableAdapter = null;
            this.tableAdapterManager.admVistasPorModuloTableAdapter = null;
            this.tableAdapterManager.admVistasRecursosTableAdapter = null;
            this.tableAdapterManager.admVistasRelacionesTableAdapter = null;
            this.tableAdapterManager.admVistasTablasTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.LoginTableAdapter = this.loginTableAdapter;
            this.tableAdapterManager.PaymentTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ReportGen.ChFraDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // nameTextEdit
            // 
            this.nameTextEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.loginBindingSource, "Name", true));
            this.nameTextEdit.Location = new System.Drawing.Point(95, 16);
            this.nameTextEdit.Name = "nameTextEdit";
            this.nameTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextEdit.Properties.Appearance.Options.UseFont = true;
            this.nameTextEdit.Size = new System.Drawing.Size(230, 22);
            this.nameTextEdit.TabIndex = 50;
            // 
            // passTextEdit
            // 
            this.passTextEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.loginBindingSource, "Pass", true));
            this.passTextEdit.Location = new System.Drawing.Point(95, 124);
            this.passTextEdit.Name = "passTextEdit";
            this.passTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passTextEdit.Properties.Appearance.Options.UseFont = true;
            this.passTextEdit.Properties.PasswordChar = '*';
            this.passTextEdit.Properties.UseSystemPasswordChar = true;
            this.passTextEdit.Size = new System.Drawing.Size(230, 22);
            this.passTextEdit.TabIndex = 51;
            // 
            // userNameTextEdit
            // 
            this.userNameTextEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.userNameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.loginBindingSource, "UserName", true));
            this.userNameTextEdit.Location = new System.Drawing.Point(95, 72);
            this.userNameTextEdit.Name = "userNameTextEdit";
            this.userNameTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameTextEdit.Properties.Appearance.Options.UseFont = true;
            this.userNameTextEdit.Size = new System.Drawing.Size(230, 22);
            this.userNameTextEdit.TabIndex = 53;
            // 
            // jobTextEdit
            // 
            this.jobTextEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.jobTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.loginBindingSource, "Job", true));
            this.jobTextEdit.Location = new System.Drawing.Point(580, 74);
            this.jobTextEdit.Name = "jobTextEdit";
            this.jobTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jobTextEdit.Properties.Appearance.Options.UseFont = true;
            this.jobTextEdit.Size = new System.Drawing.Size(230, 22);
            this.jobTextEdit.TabIndex = 54;
            // 
            // emailTextEdit
            // 
            this.emailTextEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.emailTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.loginBindingSource, "Email", true));
            this.emailTextEdit.Location = new System.Drawing.Point(580, 127);
            this.emailTextEdit.Name = "emailTextEdit";
            this.emailTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTextEdit.Properties.Appearance.Options.UseFont = true;
            this.emailTextEdit.Size = new System.Drawing.Size(230, 22);
            this.emailTextEdit.TabIndex = 55;
            // 
            // con_PassTextEdit
            // 
            this.con_PassTextEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.con_PassTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.loginBindingSource, "Con_Pass", true));
            this.con_PassTextEdit.Location = new System.Drawing.Point(580, 16);
            this.con_PassTextEdit.Name = "con_PassTextEdit";
            this.con_PassTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.con_PassTextEdit.Properties.Appearance.Options.UseFont = true;
            this.con_PassTextEdit.Properties.PasswordChar = '*';
            this.con_PassTextEdit.Properties.UseSystemPasswordChar = true;
            this.con_PassTextEdit.Size = new System.Drawing.Size(230, 22);
            this.con_PassTextEdit.TabIndex = 56;
            // 
            // loginGridControl
            // 
            this.loginGridControl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginGridControl.DataSource = this.loginBindingSource;
            this.loginGridControl.Location = new System.Drawing.Point(3, 192);
            this.loginGridControl.MainView = this.gridView1;
            this.loginGridControl.Name = "loginGridControl";
            this.loginGridControl.Size = new System.Drawing.Size(807, 224);
            this.loginGridControl.TabIndex = 56;
            this.loginGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.loginGridControl.Click += new System.EventHandler(this.LoginGridControl_Click);
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName,
            this.colUserName,
            this.colPass,
            this.colCon_Pass,
            this.colJob,
            this.colEmail,
            this.colIs_Active,
            this.colRole});
            this.gridView1.GridControl = this.loginGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.RowHeight = 25;
            // 
            // colName
            // 
            this.colName.Caption = "Name";
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            // 
            // colUserName
            // 
            this.colUserName.Caption = "User Name";
            this.colUserName.FieldName = "UserName";
            this.colUserName.Name = "colUserName";
            this.colUserName.Visible = true;
            this.colUserName.VisibleIndex = 1;
            // 
            // colPass
            // 
            this.colPass.Caption = "Password";
            this.colPass.FieldName = "Pass";
            this.colPass.Name = "colPass";
            this.colPass.Visible = true;
            this.colPass.VisibleIndex = 2;
            // 
            // colCon_Pass
            // 
            this.colCon_Pass.Caption = "Confirm Password";
            this.colCon_Pass.FieldName = "Con_Pass";
            this.colCon_Pass.Name = "colCon_Pass";
            this.colCon_Pass.Visible = true;
            this.colCon_Pass.VisibleIndex = 3;
            // 
            // colJob
            // 
            this.colJob.Caption = "Work";
            this.colJob.FieldName = "Job";
            this.colJob.Name = "colJob";
            this.colJob.Visible = true;
            this.colJob.VisibleIndex = 5;
            // 
            // colEmail
            // 
            this.colEmail.Caption = "Email";
            this.colEmail.FieldName = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.Visible = true;
            this.colEmail.VisibleIndex = 4;
            // 
            // colIs_Active
            // 
            this.colIs_Active.FieldName = "Is_Active";
            this.colIs_Active.Name = "colIs_Active";
            this.colIs_Active.Visible = true;
            this.colIs_Active.VisibleIndex = 6;
            // 
            // colRole
            // 
            this.colRole.FieldName = "Role";
            this.colRole.Name = "colRole";
            this.colRole.Visible = true;
            this.colRole.VisibleIndex = 7;
            // 
            // checkEdit1
            // 
            this.checkEdit1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkEdit1.Location = new System.Drawing.Point(331, 127);
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkEdit1.Properties.Appearance.Options.UseFont = true;
            this.checkEdit1.Properties.Caption = "";
            this.checkEdit1.Size = new System.Drawing.Size(75, 19);
            this.checkEdit1.TabIndex = 57;
            this.checkEdit1.CheckedChanged += new System.EventHandler(this.checkEdit1_CheckedChanged);
            // 
            // is_ActiveCheckBox
            // 
            this.is_ActiveCheckBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.is_ActiveCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.loginBindingSource, "Is_Active", true));
            this.is_ActiveCheckBox.Location = new System.Drawing.Point(612, 162);
            this.is_ActiveCheckBox.Name = "is_ActiveCheckBox";
            this.is_ActiveCheckBox.Size = new System.Drawing.Size(104, 24);
            this.is_ActiveCheckBox.TabIndex = 58;
            this.is_ActiveCheckBox.UseVisualStyleBackColor = true;
            // 
            // idTextBox
            // 
            this.idTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loginBindingSource, "id", true));
            this.idTextBox.Location = new System.Drawing.Point(95, 162);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(53, 20);
            this.idTextBox.TabIndex = 59;
            // 
            // roleComboBox
            // 
            this.roleComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.roleComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loginBindingSource, "Role", true));
            this.roleComboBox.FormattingEnabled = true;
            this.roleComboBox.Items.AddRange(new object[] {
            "ADMIN",
            "MANAGER",
            "PRODUCCION",
            "CAJA",
            "ENTREGAS"});
            this.roleComboBox.Location = new System.Drawing.Point(209, 164);
            this.roleComboBox.Name = "roleComboBox";
            this.roleComboBox.Size = new System.Drawing.Size(116, 21);
            this.roleComboBox.TabIndex = 60;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Enabled = false;
            this.simpleButton1.Location = new System.Drawing.Point(652, 435);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(134, 36);
            this.simpleButton1.TabIndex = 48;
            this.simpleButton1.Text = "&Cancel";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // FrmUser
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 494);
            this.Controls.Add(roleLabel);
            this.Controls.Add(this.roleComboBox);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(is_ActiveLabel);
            this.Controls.Add(this.is_ActiveCheckBox);
            this.Controls.Add(this.checkEdit1);
            this.Controls.Add(this.loginGridControl);
            this.Controls.Add(con_PassLabel);
            this.Controls.Add(this.con_PassTextEdit);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextEdit);
            this.Controls.Add(jobLabel);
            this.Controls.Add(this.jobTextEdit);
            this.Controls.Add(userNameLabel);
            this.Controls.Add(this.userNameTextEdit);
            this.Controls.Add(passLabel);
            this.Controls.Add(this.passTextEdit);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextEdit);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.simpleButton4);
            this.Controls.Add(this.simpleButton5);
            this.Controls.Add(this.simpleButton6);
            this.Controls.Add(this.simpleButton7);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmUser";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Users";
            this.Load += new System.EventHandler(this.FrmUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ChFraDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.con_PassTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.SimpleButton simpleButton5;
        private DevExpress.XtraEditors.SimpleButton simpleButton6;
        private DevExpress.XtraEditors.SimpleButton simpleButton7;
        private ChFraDataSet ChFraDataSet;
        private System.Windows.Forms.BindingSource loginBindingSource;
        private ChFraDataSetTableAdapters.LoginTableAdapter loginTableAdapter;
        private ChFraDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.TextEdit nameTextEdit;
        private DevExpress.XtraEditors.TextEdit passTextEdit;
        private DevExpress.XtraEditors.TextEdit userNameTextEdit;
        private DevExpress.XtraEditors.TextEdit jobTextEdit;
        private DevExpress.XtraEditors.TextEdit emailTextEdit;
        private DevExpress.XtraEditors.TextEdit con_PassTextEdit;
        private DevExpress.XtraGrid.GridControl loginGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colUserName;
        private DevExpress.XtraGrid.Columns.GridColumn colPass;
        private DevExpress.XtraGrid.Columns.GridColumn colCon_Pass;
        private DevExpress.XtraGrid.Columns.GridColumn colJob;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colIs_Active;
        private DevExpress.XtraGrid.Columns.GridColumn colRole;
        private DevExpress.XtraEditors.CheckEdit checkEdit1;
        private System.Windows.Forms.CheckBox is_ActiveCheckBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.ComboBox roleComboBox;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}