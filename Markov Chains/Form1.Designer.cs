namespace Markov_Chains
{
    partial class FrmMain
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pbClose = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelEdit = new System.Windows.Forms.Panel();
            this.btnEditMatrix = new System.Windows.Forms.Button();
            this.brnEditData = new System.Windows.Forms.Button();
            this.panelCalc = new System.Windows.Forms.Panel();
            this.btnProbAbs = new System.Windows.Forms.Button();
            this.btnTimeAbs = new System.Windows.Forms.Button();
            this.btnNumberPass = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.panelTools = new System.Windows.Forms.Panel();
            this.btnDataSave = new System.Windows.Forms.Button();
            this.btnDataEdit = new System.Windows.Forms.Button();
            this.btnMatrixSave = new System.Windows.Forms.Button();
            this.btnMatrixSub = new System.Windows.Forms.Button();
            this.btnMatrixAdd = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblException = new System.Windows.Forms.Label();
            this.dgvDataResult = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblWarning = new System.Windows.Forms.Label();
            this.dgvDataMatrix = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            this.panelEdit.SuspendLayout();
            this.panelCalc.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panelTools.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataResult)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataMatrix)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(210)))));
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pbClose);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(250, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(505, 50);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 49);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(505, 1);
            this.panel3.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(144, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "Markov Chains";
            // 
            // pbClose
            // 
            this.pbClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbClose.BackgroundImage = global::Markov_Chains.Properties.Resources.Close_32;
            this.pbClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbClose.Location = new System.Drawing.Point(471, 6);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(25, 25);
            this.pbClose.TabIndex = 0;
            this.pbClose.TabStop = false;
            this.pbClose.Click += new System.EventHandler(this.PbClose_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 50);
            this.panel1.TabIndex = 0;
            // 
            // panelEdit
            // 
            this.panelEdit.Controls.Add(this.btnEditMatrix);
            this.panelEdit.Controls.Add(this.brnEditData);
            this.panelEdit.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEdit.Location = new System.Drawing.Point(0, 170);
            this.panelEdit.Name = "panelEdit";
            this.panelEdit.Size = new System.Drawing.Size(250, 100);
            this.panelEdit.TabIndex = 5;
            // 
            // btnEditMatrix
            // 
            this.btnEditMatrix.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(210)))));
            this.btnEditMatrix.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEditMatrix.FlatAppearance.BorderSize = 0;
            this.btnEditMatrix.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(150)))));
            this.btnEditMatrix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditMatrix.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditMatrix.ForeColor = System.Drawing.Color.White;
            this.btnEditMatrix.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditMatrix.Location = new System.Drawing.Point(0, 50);
            this.btnEditMatrix.Name = "btnEditMatrix";
            this.btnEditMatrix.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnEditMatrix.Size = new System.Drawing.Size(250, 50);
            this.btnEditMatrix.TabIndex = 6;
            this.btnEditMatrix.Text = "Tamanho da matriz";
            this.btnEditMatrix.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditMatrix.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditMatrix.UseVisualStyleBackColor = false;
            this.btnEditMatrix.Click += new System.EventHandler(this.BtnEditMatrix_Click);
            // 
            // brnEditData
            // 
            this.brnEditData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(210)))));
            this.brnEditData.Dock = System.Windows.Forms.DockStyle.Top;
            this.brnEditData.FlatAppearance.BorderSize = 0;
            this.brnEditData.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(150)))));
            this.brnEditData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.brnEditData.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brnEditData.ForeColor = System.Drawing.Color.White;
            this.brnEditData.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.brnEditData.Location = new System.Drawing.Point(0, 0);
            this.brnEditData.Name = "brnEditData";
            this.brnEditData.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.brnEditData.Size = new System.Drawing.Size(250, 50);
            this.brnEditData.TabIndex = 5;
            this.brnEditData.Text = "Dados de entrada";
            this.brnEditData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.brnEditData.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.brnEditData.UseVisualStyleBackColor = false;
            this.brnEditData.Click += new System.EventHandler(this.BrnEditData_Click);
            // 
            // panelCalc
            // 
            this.panelCalc.Controls.Add(this.btnProbAbs);
            this.panelCalc.Controls.Add(this.btnTimeAbs);
            this.panelCalc.Controls.Add(this.btnNumberPass);
            this.panelCalc.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCalc.Location = new System.Drawing.Point(0, 330);
            this.panelCalc.Name = "panelCalc";
            this.panelCalc.Size = new System.Drawing.Size(250, 150);
            this.panelCalc.TabIndex = 7;
            // 
            // btnProbAbs
            // 
            this.btnProbAbs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(210)))));
            this.btnProbAbs.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProbAbs.FlatAppearance.BorderSize = 0;
            this.btnProbAbs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(150)))));
            this.btnProbAbs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProbAbs.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProbAbs.ForeColor = System.Drawing.Color.White;
            this.btnProbAbs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProbAbs.Location = new System.Drawing.Point(0, 100);
            this.btnProbAbs.Name = "btnProbAbs";
            this.btnProbAbs.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnProbAbs.Size = new System.Drawing.Size(250, 50);
            this.btnProbAbs.TabIndex = 7;
            this.btnProbAbs.Text = "Probabilidade de absorção";
            this.btnProbAbs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProbAbs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProbAbs.UseVisualStyleBackColor = false;
            this.btnProbAbs.Click += new System.EventHandler(this.BtnProbAbs_Click);
            // 
            // btnTimeAbs
            // 
            this.btnTimeAbs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(210)))));
            this.btnTimeAbs.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTimeAbs.FlatAppearance.BorderSize = 0;
            this.btnTimeAbs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(150)))));
            this.btnTimeAbs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimeAbs.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimeAbs.ForeColor = System.Drawing.Color.White;
            this.btnTimeAbs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimeAbs.Location = new System.Drawing.Point(0, 50);
            this.btnTimeAbs.Name = "btnTimeAbs";
            this.btnTimeAbs.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnTimeAbs.Size = new System.Drawing.Size(250, 50);
            this.btnTimeAbs.TabIndex = 6;
            this.btnTimeAbs.Text = "Tempo para absorção";
            this.btnTimeAbs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimeAbs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTimeAbs.UseVisualStyleBackColor = false;
            this.btnTimeAbs.Click += new System.EventHandler(this.BtnTimeAbs_Click);
            // 
            // btnNumberPass
            // 
            this.btnNumberPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(210)))));
            this.btnNumberPass.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNumberPass.FlatAppearance.BorderSize = 0;
            this.btnNumberPass.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(150)))));
            this.btnNumberPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNumberPass.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNumberPass.ForeColor = System.Drawing.Color.White;
            this.btnNumberPass.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNumberPass.Location = new System.Drawing.Point(0, 0);
            this.btnNumberPass.Name = "btnNumberPass";
            this.btnNumberPass.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnNumberPass.Size = new System.Drawing.Size(250, 50);
            this.btnNumberPass.TabIndex = 5;
            this.btnNumberPass.Text = "Número médio de passagens";
            this.btnNumberPass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNumberPass.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNumberPass.UseVisualStyleBackColor = false;
            this.btnNumberPass.Click += new System.EventHandler(this.BtnNumberPass_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Location = new System.Drawing.Point(0, 777);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 10);
            this.label2.Size = new System.Drawing.Size(94, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "by Rodrigo Lusa";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(210)))));
            this.panelMenu.Controls.Add(this.label2);
            this.panelMenu.Controls.Add(this.panelCalc);
            this.panelMenu.Controls.Add(this.btnCalc);
            this.panelMenu.Controls.Add(this.panelEdit);
            this.panelMenu.Controls.Add(this.btnEdit);
            this.panelMenu.Controls.Add(this.btnNew);
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(250, 800);
            this.panelMenu.TabIndex = 0;
            // 
            // btnCalc
            // 
            this.btnCalc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(210)))));
            this.btnCalc.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCalc.FlatAppearance.BorderSize = 0;
            this.btnCalc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(150)))));
            this.btnCalc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalc.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalc.ForeColor = System.Drawing.Color.White;
            this.btnCalc.Image = global::Markov_Chains.Properties.Resources.Calculator_48;
            this.btnCalc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalc.Location = new System.Drawing.Point(0, 270);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(250, 60);
            this.btnCalc.TabIndex = 6;
            this.btnCalc.Text = "Calcular";
            this.btnCalc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCalc.UseVisualStyleBackColor = false;
            this.btnCalc.Click += new System.EventHandler(this.BtnCalc_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(210)))));
            this.btnEdit.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(150)))));
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Image = global::Markov_Chains.Properties.Resources.Document_Edit_48;
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Location = new System.Drawing.Point(0, 110);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(250, 60);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "Editar";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(210)))));
            this.btnNew.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNew.FlatAppearance.BorderSize = 0;
            this.btnNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(150)))));
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.Color.White;
            this.btnNew.Image = global::Markov_Chains.Properties.Resources.Item_New_48;
            this.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNew.Location = new System.Drawing.Point(0, 50);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(250, 60);
            this.btnNew.TabIndex = 3;
            this.btnNew.Text = "Novo";
            this.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // panelTools
            // 
            this.panelTools.BackColor = System.Drawing.Color.DimGray;
            this.panelTools.Controls.Add(this.btnDataSave);
            this.panelTools.Controls.Add(this.btnDataEdit);
            this.panelTools.Controls.Add(this.btnMatrixSave);
            this.panelTools.Controls.Add(this.btnMatrixSub);
            this.panelTools.Controls.Add(this.btnMatrixAdd);
            this.panelTools.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTools.Location = new System.Drawing.Point(250, 50);
            this.panelTools.Name = "panelTools";
            this.panelTools.Size = new System.Drawing.Size(505, 40);
            this.panelTools.TabIndex = 2;
            // 
            // btnDataSave
            // 
            this.btnDataSave.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDataSave.Enabled = false;
            this.btnDataSave.FlatAppearance.BorderSize = 0;
            this.btnDataSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(150)))));
            this.btnDataSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDataSave.Image = global::Markov_Chains.Properties.Resources.Floppy_48;
            this.btnDataSave.Location = new System.Drawing.Point(200, 0);
            this.btnDataSave.Name = "btnDataSave";
            this.btnDataSave.Size = new System.Drawing.Size(50, 40);
            this.btnDataSave.TabIndex = 5;
            this.btnDataSave.UseVisualStyleBackColor = true;
            this.btnDataSave.Click += new System.EventHandler(this.BtnDataSave_Click);
            // 
            // btnDataEdit
            // 
            this.btnDataEdit.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDataEdit.FlatAppearance.BorderSize = 0;
            this.btnDataEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(150)))));
            this.btnDataEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDataEdit.Image = global::Markov_Chains.Properties.Resources.Data_Edit_48;
            this.btnDataEdit.Location = new System.Drawing.Point(150, 0);
            this.btnDataEdit.Name = "btnDataEdit";
            this.btnDataEdit.Size = new System.Drawing.Size(50, 40);
            this.btnDataEdit.TabIndex = 3;
            this.btnDataEdit.UseVisualStyleBackColor = true;
            this.btnDataEdit.Click += new System.EventHandler(this.BtnDataEdit_Click);
            // 
            // btnMatrixSave
            // 
            this.btnMatrixSave.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnMatrixSave.FlatAppearance.BorderSize = 0;
            this.btnMatrixSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(150)))));
            this.btnMatrixSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMatrixSave.Image = global::Markov_Chains.Properties.Resources.Check_48;
            this.btnMatrixSave.Location = new System.Drawing.Point(100, 0);
            this.btnMatrixSave.Name = "btnMatrixSave";
            this.btnMatrixSave.Size = new System.Drawing.Size(50, 40);
            this.btnMatrixSave.TabIndex = 2;
            this.btnMatrixSave.UseVisualStyleBackColor = true;
            this.btnMatrixSave.Click += new System.EventHandler(this.BtnMatrixSave_Click);
            // 
            // btnMatrixSub
            // 
            this.btnMatrixSub.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnMatrixSub.FlatAppearance.BorderSize = 0;
            this.btnMatrixSub.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(150)))));
            this.btnMatrixSub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMatrixSub.Image = global::Markov_Chains.Properties.Resources.Minus_48;
            this.btnMatrixSub.Location = new System.Drawing.Point(50, 0);
            this.btnMatrixSub.Name = "btnMatrixSub";
            this.btnMatrixSub.Size = new System.Drawing.Size(50, 40);
            this.btnMatrixSub.TabIndex = 1;
            this.btnMatrixSub.UseVisualStyleBackColor = true;
            this.btnMatrixSub.Click += new System.EventHandler(this.BtnMatrixSub_Click);
            // 
            // btnMatrixAdd
            // 
            this.btnMatrixAdd.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnMatrixAdd.FlatAppearance.BorderSize = 0;
            this.btnMatrixAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(150)))));
            this.btnMatrixAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMatrixAdd.Image = global::Markov_Chains.Properties.Resources.Add_New_48;
            this.btnMatrixAdd.Location = new System.Drawing.Point(0, 0);
            this.btnMatrixAdd.Name = "btnMatrixAdd";
            this.btnMatrixAdd.Size = new System.Drawing.Size(50, 40);
            this.btnMatrixAdd.TabIndex = 0;
            this.btnMatrixAdd.UseVisualStyleBackColor = true;
            this.btnMatrixAdd.Click += new System.EventHandler(this.BtnMatrixAdd_Click);
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.panel5);
            this.panelMain.Controls.Add(this.dgvDataResult);
            this.panelMain.Controls.Add(this.panel4);
            this.panelMain.Controls.Add(this.dgvDataMatrix);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(250, 90);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(505, 710);
            this.panelMain.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DarkGray;
            this.panel5.Controls.Add(this.lblException);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 680);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(505, 30);
            this.panel5.TabIndex = 3;
            // 
            // lblException
            // 
            this.lblException.AutoSize = true;
            this.lblException.Location = new System.Drawing.Point(6, 8);
            this.lblException.Name = "lblException";
            this.lblException.Size = new System.Drawing.Size(94, 13);
            this.lblException.TabIndex = 2;
            this.lblException.Text = "Texto da Exceção";
            // 
            // dgvDataResult
            // 
            this.dgvDataResult.AllowUserToAddRows = false;
            this.dgvDataResult.AllowUserToDeleteRows = false;
            this.dgvDataResult.AllowUserToResizeColumns = false;
            this.dgvDataResult.AllowUserToResizeRows = false;
            this.dgvDataResult.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.dgvDataResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDataResult.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDataResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDataResult.ColumnHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(210)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDataResult.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDataResult.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvDataResult.EnableHeadersVisualStyles = false;
            this.dgvDataResult.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(210)))));
            this.dgvDataResult.Location = new System.Drawing.Point(0, 360);
            this.dgvDataResult.MultiSelect = false;
            this.dgvDataResult.Name = "dgvDataResult";
            this.dgvDataResult.RowHeadersVisible = false;
            this.dgvDataResult.Size = new System.Drawing.Size(505, 320);
            this.dgvDataResult.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(210)))));
            this.panel4.Controls.Add(this.lblWarning);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 320);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(505, 40);
            this.panel4.TabIndex = 1;
            // 
            // lblWarning
            // 
            this.lblWarning.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWarning.AutoSize = true;
            this.lblWarning.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarning.ForeColor = System.Drawing.Color.Gold;
            this.lblWarning.Location = new System.Drawing.Point(162, 9);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(184, 22);
            this.lblWarning.TabIndex = 0;
            this.lblWarning.Text = "Impossivel Calcular";
            // 
            // dgvDataMatrix
            // 
            this.dgvDataMatrix.AllowUserToAddRows = false;
            this.dgvDataMatrix.AllowUserToDeleteRows = false;
            this.dgvDataMatrix.AllowUserToResizeColumns = false;
            this.dgvDataMatrix.AllowUserToResizeRows = false;
            this.dgvDataMatrix.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.dgvDataMatrix.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDataMatrix.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDataMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDataMatrix.ColumnHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(210)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDataMatrix.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDataMatrix.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvDataMatrix.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(210)))));
            this.dgvDataMatrix.Location = new System.Drawing.Point(0, 0);
            this.dgvDataMatrix.MultiSelect = false;
            this.dgvDataMatrix.Name = "dgvDataMatrix";
            this.dgvDataMatrix.RowHeadersVisible = false;
            this.dgvDataMatrix.Size = new System.Drawing.Size(505, 320);
            this.dgvDataMatrix.TabIndex = 0;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.ClientSize = new System.Drawing.Size(755, 800);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelTools);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            this.panelEdit.ResumeLayout(false);
            this.panelCalc.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.panelTools.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataResult)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataMatrix)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pbClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Panel panelEdit;
        private System.Windows.Forms.Button btnEditMatrix;
        private System.Windows.Forms.Button brnEditData;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Panel panelCalc;
        private System.Windows.Forms.Button btnProbAbs;
        private System.Windows.Forms.Button btnTimeAbs;
        private System.Windows.Forms.Button btnNumberPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelTools;
        private System.Windows.Forms.Button btnMatrixSub;
        private System.Windows.Forms.Button btnMatrixAdd;
        private System.Windows.Forms.Button btnMatrixSave;
        private System.Windows.Forms.Button btnDataEdit;
        private System.Windows.Forms.Button btnDataSave;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.DataGridView dgvDataMatrix;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgvDataResult;
        private System.Windows.Forms.Label lblWarning;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblException;
    }
}

