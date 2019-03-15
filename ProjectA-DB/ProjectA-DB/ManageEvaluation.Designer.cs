namespace ProjectA_DB
{
    partial class ManageEvaluation
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.UpdateEvaluation = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Utw = new System.Windows.Forms.TextBox();
            this.Utm = new System.Windows.Forms.TextBox();
            this.UName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Retrieve = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.Submit = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.totalweightage1 = new System.Windows.Forms.TextBox();
            this.totalmarks1 = new System.Windows.Forms.TextBox();
            this.name1 = new System.Windows.Forms.TextBox();
            this.totalweightage = new System.Windows.Forms.Label();
            this.totalMarks = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Update = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.UpdateEvaluation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.UpdateEvaluation);
            this.panel1.Controls.Add(this.Retrieve);
            this.panel1.Controls.Add(this.Clear);
            this.panel1.Controls.Add(this.Submit);
            this.panel1.Controls.Add(this.Cancel);
            this.panel1.Controls.Add(this.totalweightage1);
            this.panel1.Controls.Add(this.totalmarks1);
            this.panel1.Controls.Add(this.name1);
            this.panel1.Controls.Add(this.totalweightage);
            this.panel1.Controls.Add(this.totalMarks);
            this.panel1.Controls.Add(this.name);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(794, 444);
            this.panel1.TabIndex = 0;
            // 
            // UpdateEvaluation
            // 
            this.UpdateEvaluation.Controls.Add(this.button1);
            this.UpdateEvaluation.Controls.Add(this.button2);
            this.UpdateEvaluation.Controls.Add(this.button3);
            this.UpdateEvaluation.Controls.Add(this.Utw);
            this.UpdateEvaluation.Controls.Add(this.Utm);
            this.UpdateEvaluation.Controls.Add(this.UName);
            this.UpdateEvaluation.Controls.Add(this.label1);
            this.UpdateEvaluation.Controls.Add(this.label2);
            this.UpdateEvaluation.Controls.Add(this.label3);
            this.UpdateEvaluation.Location = new System.Drawing.Point(190, 262);
            this.UpdateEvaluation.Name = "UpdateEvaluation";
            this.UpdateEvaluation.Size = new System.Drawing.Size(424, 179);
            this.UpdateEvaluation.TabIndex = 12;
            this.UpdateEvaluation.TabStop = false;
            this.UpdateEvaluation.Text = "Update Evaluation";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(265, 150);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(184, 150);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(103, 150);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 16;
            this.button3.Text = "Clear";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Utw
            // 
            this.Utw.Location = new System.Drawing.Point(194, 113);
            this.Utw.Name = "Utw";
            this.Utw.Size = new System.Drawing.Size(166, 20);
            this.Utw.TabIndex = 15;
            // 
            // Utm
            // 
            this.Utm.Location = new System.Drawing.Point(194, 66);
            this.Utm.Name = "Utm";
            this.Utm.Size = new System.Drawing.Size(166, 20);
            this.Utm.TabIndex = 14;
            // 
            // UName
            // 
            this.UName.Location = new System.Drawing.Point(194, 21);
            this.UName.Name = "UName";
            this.UName.Size = new System.Drawing.Size(166, 20);
            this.UName.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Total Weightage";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Total Marks";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Name";
            // 
            // Retrieve
            // 
            this.Retrieve.Location = new System.Drawing.Point(465, 165);
            this.Retrieve.Name = "Retrieve";
            this.Retrieve.Size = new System.Drawing.Size(75, 23);
            this.Retrieve.TabIndex = 11;
            this.Retrieve.Text = "Retrieve";
            this.Retrieve.UseVisualStyleBackColor = true;
            this.Retrieve.Click += new System.EventHandler(this.Retrieve_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(222, 165);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(75, 23);
            this.Clear.TabIndex = 9;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click_1);
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(303, 165);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(75, 23);
            this.Submit.TabIndex = 8;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click_1);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(384, 165);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 7;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click_1);
            // 
            // totalweightage1
            // 
            this.totalweightage1.Location = new System.Drawing.Point(356, 121);
            this.totalweightage1.Name = "totalweightage1";
            this.totalweightage1.Size = new System.Drawing.Size(166, 20);
            this.totalweightage1.TabIndex = 6;
            // 
            // totalmarks1
            // 
            this.totalmarks1.Location = new System.Drawing.Point(356, 74);
            this.totalmarks1.Name = "totalmarks1";
            this.totalmarks1.Size = new System.Drawing.Size(166, 20);
            this.totalmarks1.TabIndex = 5;
            // 
            // name1
            // 
            this.name1.Location = new System.Drawing.Point(356, 29);
            this.name1.Name = "name1";
            this.name1.Size = new System.Drawing.Size(166, 20);
            this.name1.TabIndex = 4;
            // 
            // totalweightage
            // 
            this.totalweightage.AutoSize = true;
            this.totalweightage.Location = new System.Drawing.Point(230, 126);
            this.totalweightage.Name = "totalweightage";
            this.totalweightage.Size = new System.Drawing.Size(86, 13);
            this.totalweightage.TabIndex = 3;
            this.totalweightage.Text = "Total Weightage";
            // 
            // totalMarks
            // 
            this.totalMarks.AutoSize = true;
            this.totalMarks.Location = new System.Drawing.Point(230, 81);
            this.totalMarks.Name = "totalMarks";
            this.totalMarks.Size = new System.Drawing.Size(63, 13);
            this.totalMarks.TabIndex = 2;
            this.totalMarks.Text = "Total Marks";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(230, 36);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(35, 13);
            this.name.TabIndex = 1;
            this.name.Text = "Name";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Update,
            this.Delete});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 217);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(794, 227);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Update
            // 
            this.Update.HeaderText = "Update";
            this.Update.Name = "Update";
            this.Update.Text = "Update";
            this.Update.UseColumnTextForButtonValue = true;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // ManageEvaluation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ManageEvaluation";
            this.Text = "Manage Evaluation";
            this.Load += new System.EventHandler(this.ManageEvaluation_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.UpdateEvaluation.ResumeLayout(false);
            this.UpdateEvaluation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox totalweightage1;
        private System.Windows.Forms.TextBox totalmarks1;
        private System.Windows.Forms.TextBox name1;
        private System.Windows.Forms.Label totalweightage;
        private System.Windows.Forms.Label totalMarks;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Retrieve;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.GroupBox UpdateEvaluation;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox Utw;
        private System.Windows.Forms.TextBox Utm;
        private System.Windows.Forms.TextBox UName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewButtonColumn Update;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}