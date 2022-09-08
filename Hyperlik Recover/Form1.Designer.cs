namespace Hyperlik_Recover
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.columnRange = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.selectRangeBox = new System.Windows.Forms.TextBox();
            this.replaceHY = new System.Windows.Forms.Button();
            this.dialgBotShow = new System.Windows.Forms.Button();
            this.textPathPaste = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.SheetNoBox = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.MtoolsIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SheetNoBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MtoolsIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // columnRange
            // 
            this.columnRange.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.columnRange.ForeColor = System.Drawing.Color.DarkGreen;
            resources.ApplyResources(this.columnRange, "columnRange");
            this.columnRange.Name = "columnRange";
            this.columnRange.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            this.label2.UseCompatibleTextRendering = true;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // selectRangeBox
            // 
            this.selectRangeBox.BackColor = System.Drawing.Color.White;
            this.selectRangeBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.selectRangeBox, "selectRangeBox");
            this.selectRangeBox.ForeColor = System.Drawing.Color.DarkGreen;
            this.selectRangeBox.Name = "selectRangeBox";
            this.selectRangeBox.ReadOnly = true;
            this.selectRangeBox.TextChanged += new System.EventHandler(this.selectRange_TextChanged);
            // 
            // replaceHY
            // 
            this.replaceHY.BackColor = System.Drawing.Color.DarkGreen;
            this.replaceHY.Cursor = System.Windows.Forms.Cursors.Hand;
            this.replaceHY.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.replaceHY.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.replaceHY, "replaceHY");
            this.replaceHY.ForeColor = System.Drawing.Color.White;
            this.replaceHY.Name = "replaceHY";
            this.replaceHY.UseVisualStyleBackColor = false;
            this.replaceHY.Click += new System.EventHandler(this.replaceHY_Click);
            // 
            // dialgBotShow
            // 
            this.dialgBotShow.BackColor = System.Drawing.Color.DarkGreen;
            this.dialgBotShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dialgBotShow.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.dialgBotShow.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.dialgBotShow, "dialgBotShow");
            this.dialgBotShow.ForeColor = System.Drawing.Color.White;
            this.dialgBotShow.Name = "dialgBotShow";
            this.dialgBotShow.UseVisualStyleBackColor = false;
            this.dialgBotShow.Click += new System.EventHandler(this.dialgBotShow_Click);
            // 
            // textPathPaste
            // 
            this.textPathPaste.BackColor = System.Drawing.Color.White;
            this.textPathPaste.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textPathPaste.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.textPathPaste, "textPathPaste");
            this.textPathPaste.ForeColor = System.Drawing.Color.DarkGreen;
            this.textPathPaste.Name = "textPathPaste";
            this.textPathPaste.ReadOnly = true;
            this.textPathPaste.TextChanged += new System.EventHandler(this.textPathPaste_TextChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.ForeColor = System.Drawing.Color.DarkGreen;
            resources.ApplyResources(this.numericUpDown1, "numericUpDown1");
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AllowDrop = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.CausesValidation = false;
            this.label4.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            this.label4.UseCompatibleTextRendering = true;
            // 
            // SheetNoBox
            // 
            this.SheetNoBox.AllowDrop = true;
            this.SheetNoBox.CausesValidation = false;
            this.SheetNoBox.ForeColor = System.Drawing.Color.DarkGreen;
            resources.ApplyResources(this.SheetNoBox, "SheetNoBox");
            this.SheetNoBox.Name = "SheetNoBox";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGreen;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button1.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.button1, "button1");
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.DarkGreen;
            this.comboBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.comboBox1, "comboBox1");
            this.comboBox1.ForeColor = System.Drawing.Color.White;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Tomato;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Gold;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.button3, "button3");
            this.button3.Name = "button3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Name = "label6";
            // 
            // dataGridView2
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkGreen;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            resources.ApplyResources(this.dataGridView2, "dataGridView2");
            this.dataGridView2.Name = "dataGridView2";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkGreen;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // MtoolsIcon
            // 
            this.MtoolsIcon.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.MtoolsIcon, "MtoolsIcon");
            this.MtoolsIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MtoolsIcon.ErrorImage = global::Hyperlik_Recover.Properties.Resources.MTools_Icon;
            this.MtoolsIcon.Image = global::Hyperlik_Recover.Properties.Resources.MTools_Icon;
            this.MtoolsIcon.InitialImage = global::Hyperlik_Recover.Properties.Resources.MTools_Icon;
            this.MtoolsIcon.Name = "MtoolsIcon";
            this.MtoolsIcon.TabStop = false;
            this.MtoolsIcon.Tag = "Mtools";
            this.MtoolsIcon.Click += new System.EventHandler(this.MtoolsIcon_Click);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ControlBox = false;
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.SheetNoBox);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.dialgBotShow);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.replaceHY);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.selectRangeBox);
            this.Controls.Add(this.textPathPaste);
            this.Controls.Add(this.columnRange);
            this.Controls.Add(this.MtoolsIcon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MdiChildrenMinimizedAnchorBottom = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Opacity = 0.95D;
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyHolde);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.KeyHolde1);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SheetNoBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MtoolsIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox columnRange;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox selectRangeBox;
        private Button replaceHY;
        private Button dialgBotShow;
        private TextBox textPathPaste;
        private NumericUpDown numericUpDown1;
        private Label label4;
        private NumericUpDown SheetNoBox;
        private Button button1;
        private ComboBox comboBox1;
        private Button button2;
        private Button button3;
        private Label label5;
        private Label label6;
        private DataGridView dataGridView2;
        private PictureBox MtoolsIcon;
    }
}