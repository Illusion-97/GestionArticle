
namespace GestionArticle
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.nameClear = new System.Windows.Forms.Button();
            this.nameSearch = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.numTB = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.numClear = new System.Windows.Forms.Button();
            this.numSearch = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.priceClear = new System.Windows.Forms.Button();
            this.priceSearch = new System.Windows.Forms.Button();
            this.minTB = new System.Windows.Forms.TextBox();
            this.maxTB = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.addNumTB = new System.Windows.Forms.TextBox();
            this.addNomTB = new System.Windows.Forms.TextBox();
            this.addQteTB = new System.Windows.Forms.TextBox();
            this.addPriceTB = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.addClear = new System.Windows.Forms.Button();
            this.addOK = new System.Windows.Forms.Button();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel11 = new System.Windows.Forms.TableLayoutPanel();
            this.delClear = new System.Windows.Forms.Button();
            this.delOK = new System.Windows.Forms.Button();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel12 = new System.Windows.Forms.TableLayoutPanel();
            this.delNumTB = new System.Windows.Forms.TextBox();
            this.afficheList = new System.Windows.Forms.DataGridView();
            this.num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.tableLayoutPanel10.SuspendLayout();
            this.tableLayoutPanel11.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.tableLayoutPanel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.afficheList)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tabControl);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.afficheList);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 266;
            this.splitContainer1.TabIndex = 0;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(266, 450);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(258, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Recherche et Affichage";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(252, 418);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 133);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Recherche par nom";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.nameTB, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(240, 114);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // nameTB
            // 
            this.nameTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nameTB.Location = new System.Drawing.Point(3, 18);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(234, 20);
            this.nameTB.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.nameClear, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.nameSearch, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 60);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(234, 51);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // nameClear
            // 
            this.nameClear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nameClear.Location = new System.Drawing.Point(21, 14);
            this.nameClear.Name = "nameClear";
            this.nameClear.Size = new System.Drawing.Size(75, 23);
            this.nameClear.TabIndex = 0;
            this.nameClear.Text = "X";
            this.nameClear.UseVisualStyleBackColor = true;
            this.nameClear.Click += new System.EventHandler(this.nameClear_Click);
            // 
            // nameSearch
            // 
            this.nameSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nameSearch.Location = new System.Drawing.Point(138, 14);
            this.nameSearch.Name = "nameSearch";
            this.nameSearch.Size = new System.Drawing.Size(75, 23);
            this.nameSearch.TabIndex = 1;
            this.nameSearch.Text = "OK";
            this.nameSearch.UseVisualStyleBackColor = true;
            this.nameSearch.Click += new System.EventHandler(this.nameSearch_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel4);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 142);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(246, 133);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Recherche par numéro";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.numTB, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(240, 114);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // numTB
            // 
            this.numTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.numTB.Location = new System.Drawing.Point(3, 18);
            this.numTB.Name = "numTB";
            this.numTB.Size = new System.Drawing.Size(234, 20);
            this.numTB.TabIndex = 0;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.numClear, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.numSearch, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 60);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(234, 51);
            this.tableLayoutPanel5.TabIndex = 1;
            // 
            // numClear
            // 
            this.numClear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numClear.Location = new System.Drawing.Point(21, 14);
            this.numClear.Name = "numClear";
            this.numClear.Size = new System.Drawing.Size(75, 23);
            this.numClear.TabIndex = 0;
            this.numClear.Text = "X";
            this.numClear.UseVisualStyleBackColor = true;
            this.numClear.Click += new System.EventHandler(this.numClear_Click);
            // 
            // numSearch
            // 
            this.numSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numSearch.Location = new System.Drawing.Point(138, 14);
            this.numSearch.Name = "numSearch";
            this.numSearch.Size = new System.Drawing.Size(75, 23);
            this.numSearch.TabIndex = 1;
            this.numSearch.Text = "OK";
            this.numSearch.UseVisualStyleBackColor = true;
            this.numSearch.Click += new System.EventHandler(this.numSearch_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tableLayoutPanel6);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(3, 281);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(246, 134);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Recherche par prix";
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel6.Controls.Add(this.tableLayoutPanel7, 0, 2);
            this.tableLayoutPanel6.Controls.Add(this.minTB, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.maxTB, 0, 1);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 3;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(240, 115);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Controls.Add(this.priceClear, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.priceSearch, 1, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 79);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(234, 33);
            this.tableLayoutPanel7.TabIndex = 3;
            // 
            // priceClear
            // 
            this.priceClear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.priceClear.Location = new System.Drawing.Point(21, 5);
            this.priceClear.Name = "priceClear";
            this.priceClear.Size = new System.Drawing.Size(75, 23);
            this.priceClear.TabIndex = 0;
            this.priceClear.Text = "X";
            this.priceClear.UseVisualStyleBackColor = true;
            this.priceClear.Click += new System.EventHandler(this.priceClear_Click);
            // 
            // priceSearch
            // 
            this.priceSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.priceSearch.Location = new System.Drawing.Point(138, 5);
            this.priceSearch.Name = "priceSearch";
            this.priceSearch.Size = new System.Drawing.Size(75, 23);
            this.priceSearch.TabIndex = 1;
            this.priceSearch.Text = "OK";
            this.priceSearch.UseVisualStyleBackColor = true;
            this.priceSearch.Click += new System.EventHandler(this.priceSearch_Click);
            // 
            // minTB
            // 
            this.minTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.minTB.Location = new System.Drawing.Point(3, 9);
            this.minTB.Name = "minTB";
            this.minTB.Size = new System.Drawing.Size(234, 20);
            this.minTB.TabIndex = 1;
            // 
            // maxTB
            // 
            this.maxTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.maxTB.Location = new System.Drawing.Point(3, 47);
            this.maxTB.Name = "maxTB";
            this.maxTB.Size = new System.Drawing.Size(234, 20);
            this.maxTB.TabIndex = 2;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.splitContainer2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(258, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Gestion du stock";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.groupBox9);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.groupBox4);
            this.splitContainer2.Size = new System.Drawing.Size(252, 418);
            this.splitContainer2.SplitterDistance = 139;
            this.splitContainer2.TabIndex = 0;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 1;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.Controls.Add(this.tableLayoutPanel9, 0, 4);
            this.tableLayoutPanel8.Controls.Add(this.groupBox8, 0, 3);
            this.tableLayoutPanel8.Controls.Add(this.groupBox7, 0, 2);
            this.tableLayoutPanel8.Controls.Add(this.groupBox6, 0, 1);
            this.tableLayoutPanel8.Controls.Add(this.groupBox5, 0, 0);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 5;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(246, 256);
            this.tableLayoutPanel8.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tableLayoutPanel8);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(0, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(252, 275);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Ajout Article";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.addNumTB);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(3, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(240, 45);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Numero";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.addNomTB);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox6.Location = new System.Drawing.Point(3, 54);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(240, 45);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Nom";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.addQteTB);
            this.groupBox7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox7.Location = new System.Drawing.Point(3, 105);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(240, 45);
            this.groupBox7.TabIndex = 2;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Quantité";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.addPriceTB);
            this.groupBox8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox8.Location = new System.Drawing.Point(3, 156);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(240, 45);
            this.groupBox8.TabIndex = 3;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Prix";
            // 
            // addNumTB
            // 
            this.addNumTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.addNumTB.Location = new System.Drawing.Point(3, 12);
            this.addNumTB.Name = "addNumTB";
            this.addNumTB.Size = new System.Drawing.Size(234, 20);
            this.addNumTB.TabIndex = 1;
            // 
            // addNomTB
            // 
            this.addNomTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.addNomTB.Location = new System.Drawing.Point(3, 12);
            this.addNomTB.Name = "addNomTB";
            this.addNomTB.Size = new System.Drawing.Size(234, 20);
            this.addNomTB.TabIndex = 1;
            // 
            // addQteTB
            // 
            this.addQteTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.addQteTB.Location = new System.Drawing.Point(3, 12);
            this.addQteTB.Name = "addQteTB";
            this.addQteTB.Size = new System.Drawing.Size(234, 20);
            this.addQteTB.TabIndex = 1;
            // 
            // addPriceTB
            // 
            this.addPriceTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.addPriceTB.Location = new System.Drawing.Point(3, 12);
            this.addPriceTB.Name = "addPriceTB";
            this.addPriceTB.Size = new System.Drawing.Size(234, 20);
            this.addPriceTB.TabIndex = 1;
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 2;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.Controls.Add(this.addClear, 0, 0);
            this.tableLayoutPanel9.Controls.Add(this.addOK, 1, 0);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(3, 207);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 1;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(240, 46);
            this.tableLayoutPanel9.TabIndex = 4;
            // 
            // addClear
            // 
            this.addClear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addClear.Location = new System.Drawing.Point(22, 11);
            this.addClear.Name = "addClear";
            this.addClear.Size = new System.Drawing.Size(75, 23);
            this.addClear.TabIndex = 0;
            this.addClear.Text = "X";
            this.addClear.UseVisualStyleBackColor = true;
            this.addClear.Click += new System.EventHandler(this.addClear_Click);
            // 
            // addOK
            // 
            this.addOK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addOK.Location = new System.Drawing.Point(142, 11);
            this.addOK.Name = "addOK";
            this.addOK.Size = new System.Drawing.Size(75, 23);
            this.addOK.TabIndex = 1;
            this.addOK.Text = "OK";
            this.addOK.UseVisualStyleBackColor = true;
            this.addOK.Click += new System.EventHandler(this.addOK_Click);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.tableLayoutPanel10);
            this.groupBox9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox9.Location = new System.Drawing.Point(0, 0);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(252, 139);
            this.groupBox9.TabIndex = 2;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Supprimer Article";
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.ColumnCount = 1;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel10.Controls.Add(this.tableLayoutPanel11, 0, 1);
            this.tableLayoutPanel10.Controls.Add(this.groupBox10, 0, 0);
            this.tableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel10.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 2;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(246, 120);
            this.tableLayoutPanel10.TabIndex = 1;
            // 
            // tableLayoutPanel11
            // 
            this.tableLayoutPanel11.ColumnCount = 2;
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel11.Controls.Add(this.delClear, 0, 0);
            this.tableLayoutPanel11.Controls.Add(this.delOK, 1, 0);
            this.tableLayoutPanel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel11.Location = new System.Drawing.Point(3, 63);
            this.tableLayoutPanel11.Name = "tableLayoutPanel11";
            this.tableLayoutPanel11.RowCount = 1;
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel11.Size = new System.Drawing.Size(240, 54);
            this.tableLayoutPanel11.TabIndex = 1;
            // 
            // delClear
            // 
            this.delClear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.delClear.Location = new System.Drawing.Point(22, 15);
            this.delClear.Name = "delClear";
            this.delClear.Size = new System.Drawing.Size(75, 23);
            this.delClear.TabIndex = 0;
            this.delClear.Text = "X";
            this.delClear.UseVisualStyleBackColor = true;
            this.delClear.Click += new System.EventHandler(this.delClear_Click);
            // 
            // delOK
            // 
            this.delOK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.delOK.Location = new System.Drawing.Point(142, 15);
            this.delOK.Name = "delOK";
            this.delOK.Size = new System.Drawing.Size(75, 23);
            this.delOK.TabIndex = 1;
            this.delOK.Text = "OK";
            this.delOK.UseVisualStyleBackColor = true;
            this.delOK.Click += new System.EventHandler(this.delOK_Click);
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.tableLayoutPanel12);
            this.groupBox10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox10.Location = new System.Drawing.Point(3, 3);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(240, 54);
            this.groupBox10.TabIndex = 2;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Numero";
            // 
            // tableLayoutPanel12
            // 
            this.tableLayoutPanel12.ColumnCount = 1;
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel12.Controls.Add(this.delNumTB, 0, 0);
            this.tableLayoutPanel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel12.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel12.Name = "tableLayoutPanel12";
            this.tableLayoutPanel12.RowCount = 1;
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel12.Size = new System.Drawing.Size(234, 35);
            this.tableLayoutPanel12.TabIndex = 0;
            // 
            // delNumTB
            // 
            this.delNumTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.delNumTB.Location = new System.Drawing.Point(3, 7);
            this.delNumTB.Name = "delNumTB";
            this.delNumTB.Size = new System.Drawing.Size(228, 20);
            this.delNumTB.TabIndex = 2;
            // 
            // afficheList
            // 
            this.afficheList.AllowUserToAddRows = false;
            this.afficheList.AllowUserToDeleteRows = false;
            this.afficheList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.afficheList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.num,
            this.name,
            this.qte,
            this.price});
            this.afficheList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.afficheList.Location = new System.Drawing.Point(0, 0);
            this.afficheList.Name = "afficheList";
            this.afficheList.ReadOnly = true;
            this.afficheList.Size = new System.Drawing.Size(530, 450);
            this.afficheList.TabIndex = 0;
            // 
            // num
            // 
            this.num.HeaderText = "Numero";
            this.num.Name = "num";
            this.num.ReadOnly = true;
            this.num.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.HeaderText = "Nom";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // qte
            // 
            this.qte.HeaderText = "Quantite";
            this.qte.Name = "qte";
            this.qte.ReadOnly = true;
            this.qte.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // price
            // 
            this.price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.price.HeaderText = "Prix";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            this.price.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Gestion Article";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.tableLayoutPanel9.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.tableLayoutPanel10.ResumeLayout(false);
            this.tableLayoutPanel11.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.tableLayoutPanel12.ResumeLayout(false);
            this.tableLayoutPanel12.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.afficheList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button nameClear;
        private System.Windows.Forms.Button nameSearch;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TextBox numTB;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button numClear;
        private System.Windows.Forms.Button numSearch;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Button priceClear;
        private System.Windows.Forms.Button priceSearch;
        private System.Windows.Forms.TextBox minTB;
        private System.Windows.Forms.TextBox maxTB;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.Button addClear;
        private System.Windows.Forms.Button addOK;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TextBox addPriceTB;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox addQteTB;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox addNomTB;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox addNumTB;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel11;
        private System.Windows.Forms.Button delClear;
        private System.Windows.Forms.Button delOK;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel12;
        private System.Windows.Forms.TextBox delNumTB;
        private System.Windows.Forms.DataGridView afficheList;
        private System.Windows.Forms.DataGridViewTextBoxColumn num;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn qte;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
    }
}

