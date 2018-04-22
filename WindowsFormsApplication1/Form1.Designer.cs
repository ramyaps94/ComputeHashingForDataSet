namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.browseFilebtn = new System.Windows.Forms.Button();
            this.browseFileLbl = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.readExcelbtn = new System.Windows.Forms.Button();
            this.btnCompute = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(278, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(783, 486);
            this.dataGridView1.TabIndex = 0;
            // 
            // browseFilebtn
            // 
            this.browseFilebtn.Location = new System.Drawing.Point(53, 84);
            this.browseFilebtn.Name = "browseFilebtn";
            this.browseFilebtn.Size = new System.Drawing.Size(75, 23);
            this.browseFilebtn.TabIndex = 1;
            this.browseFilebtn.Text = "BrowseFile";
            this.browseFilebtn.UseVisualStyleBackColor = true;
            this.browseFilebtn.Click += new System.EventHandler(this.browseFilebtn_Click);
            // 
            // browseFileLbl
            // 
            this.browseFileLbl.AutoSize = true;
            this.browseFileLbl.Location = new System.Drawing.Point(50, 41);
            this.browseFileLbl.Name = "browseFileLbl";
            this.browseFileLbl.Size = new System.Drawing.Size(58, 13);
            this.browseFileLbl.TabIndex = 2;
            this.browseFileLbl.Text = "BrowseFile";
            this.browseFileLbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(114, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(158, 20);
            this.textBox1.TabIndex = 3;
            // 
            // readExcelbtn
            // 
            this.readExcelbtn.Enabled = false;
            this.readExcelbtn.Location = new System.Drawing.Point(190, 84);
            this.readExcelbtn.Name = "readExcelbtn";
            this.readExcelbtn.Size = new System.Drawing.Size(75, 23);
            this.readExcelbtn.TabIndex = 4;
            this.readExcelbtn.Text = "ReadExcel";
            this.readExcelbtn.UseVisualStyleBackColor = true;
            this.readExcelbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCompute
            // 
            this.btnCompute.Enabled = false;
            this.btnCompute.Location = new System.Drawing.Point(79, 133);
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Size = new System.Drawing.Size(139, 23);
            this.btnCompute.TabIndex = 5;
            this.btnCompute.Text = " ComputeHashing";
            this.btnCompute.UseVisualStyleBackColor = true;
            this.btnCompute.Click += new System.EventHandler(this.btnCompute_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.richTextBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(25, 213);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 215);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SearchByHashKey";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(70, 32);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(158, 20);
            this.textBox2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "HashKey";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(9, 58);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(213, 96);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 171);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "FindDetailsbyHashkey";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 521);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCompute);
            this.Controls.Add(this.readExcelbtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.browseFileLbl);
            this.Controls.Add(this.browseFilebtn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "HashingComputation";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button browseFilebtn;
        private System.Windows.Forms.Label browseFileLbl;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button readExcelbtn;
        private System.Windows.Forms.Button btnCompute;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
    }
}

