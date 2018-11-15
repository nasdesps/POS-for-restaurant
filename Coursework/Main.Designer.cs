namespace Coursework
{
    partial class Main
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
            this.importBtn = new System.Windows.Forms.Button();
            this.menuGrid = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.fdname_txtbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.price_txtbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.orderGrid = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNameOrder = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPriceOrder = new System.Windows.Forms.TextBox();
            this.calculateBtn = new System.Windows.Forms.Button();
            this.txtCalculate = new System.Windows.Forms.TextBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.orderBtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtQuantityOrder = new System.Windows.Forms.TextBox();
            this.categorytxt = new System.Windows.Forms.TextBox();
            this.txtCategoryOrder = new System.Windows.Forms.TextBox();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.orderDeleteBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.sortPriceBtn = new System.Windows.Forms.Button();
            this.sortNameBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chartBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.menuGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // importBtn
            // 
            this.importBtn.BackColor = System.Drawing.Color.LightSteelBlue;
            this.importBtn.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importBtn.Location = new System.Drawing.Point(250, 19);
            this.importBtn.Name = "importBtn";
            this.importBtn.Size = new System.Drawing.Size(116, 39);
            this.importBtn.TabIndex = 1;
            this.importBtn.Text = "Import Menu";
            this.importBtn.UseVisualStyleBackColor = false;
            this.importBtn.Click += new System.EventHandler(this.importBtn_Click);
            // 
            // menuGrid
            // 
            this.menuGrid.AllowUserToAddRows = false;
            this.menuGrid.AllowUserToDeleteRows = false;
            this.menuGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menuGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.menuGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.menuGrid.GridColor = System.Drawing.SystemColors.ControlText;
            this.menuGrid.Location = new System.Drawing.Point(67, 169);
            this.menuGrid.MultiSelect = false;
            this.menuGrid.Name = "menuGrid";
            this.menuGrid.Size = new System.Drawing.Size(544, 444);
            this.menuGrid.TabIndex = 2;
            this.menuGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.menuGrid_CellDoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Food Name";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Column1.Width = 220;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Category";
            this.Column2.Name = "Column2";
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Column2.Width = 180;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Price";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Column3.Width = 101;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Food Name:";
            // 
            // fdname_txtbox
            // 
            this.fdname_txtbox.Location = new System.Drawing.Point(120, 76);
            this.fdname_txtbox.Name = "fdname_txtbox";
            this.fdname_txtbox.Size = new System.Drawing.Size(207, 20);
            this.fdname_txtbox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Price:";
            // 
            // price_txtbox
            // 
            this.price_txtbox.Location = new System.Drawing.Point(120, 118);
            this.price_txtbox.Name = "price_txtbox";
            this.price_txtbox.Size = new System.Drawing.Size(152, 20);
            this.price_txtbox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(350, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "Category:";
            // 
            // orderGrid
            // 
            this.orderGrid.AllowUserToAddRows = false;
            this.orderGrid.AllowUserToDeleteRows = false;
            this.orderGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.orderGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column5,
            this.Column8,
            this.Column6});
            this.orderGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.orderGrid.GridColor = System.Drawing.SystemColors.ControlText;
            this.orderGrid.Location = new System.Drawing.Point(688, 169);
            this.orderGrid.MultiSelect = false;
            this.orderGrid.Name = "orderGrid";
            this.orderGrid.Size = new System.Drawing.Size(552, 444);
            this.orderGrid.TabIndex = 9;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Food Name";
            this.Column4.Name = "Column4";
            this.Column4.Width = 200;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Category";
            this.Column5.Name = "Column5";
            this.Column5.Width = 150;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Quantity";
            this.Column8.Name = "Column8";
            this.Column8.Width = 59;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Price";
            this.Column6.Name = "Column6";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(685, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 21);
            this.label4.TabIndex = 10;
            this.label4.Text = "Food Name:";
            // 
            // txtNameOrder
            // 
            this.txtNameOrder.Location = new System.Drawing.Point(126, 36);
            this.txtNameOrder.Name = "txtNameOrder";
            this.txtNameOrder.Size = new System.Drawing.Size(207, 20);
            this.txtNameOrder.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(357, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 21);
            this.label5.TabIndex = 12;
            this.label5.Text = "Category:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1032, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 21);
            this.label6.TabIndex = 14;
            this.label6.Text = "Price:";
            // 
            // txtPriceOrder
            // 
            this.txtPriceOrder.Location = new System.Drawing.Point(1088, 84);
            this.txtPriceOrder.Name = "txtPriceOrder";
            this.txtPriceOrder.Size = new System.Drawing.Size(152, 20);
            this.txtPriceOrder.TabIndex = 15;
            // 
            // calculateBtn
            // 
            this.calculateBtn.BackColor = System.Drawing.Color.LightSteelBlue;
            this.calculateBtn.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateBtn.Location = new System.Drawing.Point(361, 616);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(112, 31);
            this.calculateBtn.TabIndex = 16;
            this.calculateBtn.Text = "Calculate";
            this.calculateBtn.UseVisualStyleBackColor = false;
            this.calculateBtn.Click += new System.EventHandler(this.calculateBtn_Click);
            // 
            // txtCalculate
            // 
            this.txtCalculate.Location = new System.Drawing.Point(491, 621);
            this.txtCalculate.Name = "txtCalculate";
            this.txtCalculate.Size = new System.Drawing.Size(100, 20);
            this.txtCalculate.TabIndex = 17;
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.LightSteelBlue;
            this.saveBtn.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.Location = new System.Drawing.Point(488, 111);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(89, 31);
            this.saveBtn.TabIndex = 18;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // orderBtn
            // 
            this.orderBtn.BackColor = System.Drawing.Color.LightSteelBlue;
            this.orderBtn.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderBtn.Location = new System.Drawing.Point(516, 111);
            this.orderBtn.Name = "orderBtn";
            this.orderBtn.Size = new System.Drawing.Size(75, 31);
            this.orderBtn.TabIndex = 19;
            this.orderBtn.Text = "Order";
            this.orderBtn.UseVisualStyleBackColor = false;
            this.orderBtn.Click += new System.EventHandler(this.orderBtn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(685, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 21);
            this.label8.TabIndex = 22;
            this.label8.Text = "Quantity:";
            // 
            // txtQuantityOrder
            // 
            this.txtQuantityOrder.Location = new System.Drawing.Point(126, 79);
            this.txtQuantityOrder.Name = "txtQuantityOrder";
            this.txtQuantityOrder.Size = new System.Drawing.Size(78, 20);
            this.txtQuantityOrder.TabIndex = 23;
            // 
            // categorytxt
            // 
            this.categorytxt.Location = new System.Drawing.Point(425, 76);
            this.categorytxt.Name = "categorytxt";
            this.categorytxt.Size = new System.Drawing.Size(152, 20);
            this.categorytxt.TabIndex = 26;
            // 
            // txtCategoryOrder
            // 
            this.txtCategoryOrder.Location = new System.Drawing.Point(439, 36);
            this.txtCategoryOrder.Name = "txtCategoryOrder";
            this.txtCategoryOrder.Size = new System.Drawing.Size(152, 20);
            this.txtCategoryOrder.TabIndex = 27;
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.LightSteelBlue;
            this.deleteBtn.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.Location = new System.Drawing.Point(378, 111);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(90, 31);
            this.deleteBtn.TabIndex = 28;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // orderDeleteBtn
            // 
            this.orderDeleteBtn.BackColor = System.Drawing.Color.LightSteelBlue;
            this.orderDeleteBtn.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderDeleteBtn.Location = new System.Drawing.Point(40, 111);
            this.orderDeleteBtn.Name = "orderDeleteBtn";
            this.orderDeleteBtn.Size = new System.Drawing.Size(84, 31);
            this.orderDeleteBtn.TabIndex = 29;
            this.orderDeleteBtn.Text = "Delete";
            this.orderDeleteBtn.UseVisualStyleBackColor = false;
            this.orderDeleteBtn.Click += new System.EventHandler(this.orderDeleteBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.sortPriceBtn);
            this.groupBox1.Controls.Add(this.categorytxt);
            this.groupBox1.Controls.Add(this.deleteBtn);
            this.groupBox1.Controls.Add(this.sortNameBtn);
            this.groupBox1.Controls.Add(this.saveBtn);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.importBtn);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.fdname_txtbox);
            this.groupBox1.Controls.Add(this.price_txtbox);
            this.groupBox1.Location = new System.Drawing.Point(34, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(616, 658);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menu Item";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(250, 316);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 27);
            this.button2.TabIndex = 1;
            this.button2.Text = "Sort By Name";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // sortPriceBtn
            // 
            this.sortPriceBtn.BackColor = System.Drawing.Color.LightSteelBlue;
            this.sortPriceBtn.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortPriceBtn.Location = new System.Drawing.Point(461, 614);
            this.sortPriceBtn.Name = "sortPriceBtn";
            this.sortPriceBtn.Size = new System.Drawing.Size(116, 31);
            this.sortPriceBtn.TabIndex = 0;
            this.sortPriceBtn.Text = "Sort By Price";
            this.sortPriceBtn.UseVisualStyleBackColor = false;
            this.sortPriceBtn.Click += new System.EventHandler(this.sortPriceBtn_Click);
            // 
            // sortNameBtn
            // 
            this.sortNameBtn.BackColor = System.Drawing.Color.LightSteelBlue;
            this.sortNameBtn.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortNameBtn.Location = new System.Drawing.Point(33, 616);
            this.sortNameBtn.Name = "sortNameBtn";
            this.sortNameBtn.Size = new System.Drawing.Size(116, 31);
            this.sortNameBtn.TabIndex = 0;
            this.sortNameBtn.Text = "Sort By Name";
            this.sortNameBtn.UseVisualStyleBackColor = false;
            this.sortNameBtn.Click += new System.EventHandler(this.sortNameBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.calculateBtn);
            this.groupBox2.Controls.Add(this.txtCategoryOrder);
            this.groupBox2.Controls.Add(this.orderDeleteBtn);
            this.groupBox2.Controls.Add(this.txtQuantityOrder);
            this.groupBox2.Controls.Add(this.txtCalculate);
            this.groupBox2.Controls.Add(this.orderBtn);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtNameOrder);
            this.groupBox2.Location = new System.Drawing.Point(649, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(623, 658);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Order Item";
            // 
            // chartBtn
            // 
            this.chartBtn.BackColor = System.Drawing.Color.LightSteelBlue;
            this.chartBtn.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chartBtn.Location = new System.Drawing.Point(552, 686);
            this.chartBtn.Name = "chartBtn";
            this.chartBtn.Size = new System.Drawing.Size(192, 49);
            this.chartBtn.TabIndex = 32;
            this.chartBtn.Text = "Generate Chart";
            this.chartBtn.UseVisualStyleBackColor = false;
            this.chartBtn.Click += new System.EventHandler(this.chartBtn_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1311, 754);
            this.Controls.Add(this.chartBtn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtPriceOrder);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.orderGrid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuGrid);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Point of Sale";
            ((System.ComponentModel.ISupportInitialize)(this.menuGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button importBtn;
        private System.Windows.Forms.DataGridView menuGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fdname_txtbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox price_txtbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView orderGrid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNameOrder;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPriceOrder;
        private System.Windows.Forms.Button calculateBtn;
        private System.Windows.Forms.TextBox txtCalculate;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button orderBtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtQuantityOrder;
        private System.Windows.Forms.TextBox categorytxt;
        private System.Windows.Forms.TextBox txtCategoryOrder;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button orderDeleteBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button chartBtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button sortPriceBtn;
        private System.Windows.Forms.Button sortNameBtn;
    }
}

