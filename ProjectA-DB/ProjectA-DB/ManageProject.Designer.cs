namespace ProjectA_DB
{
    partial class ManageProject
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
            this.UpdateProject = new System.Windows.Forms.GroupBox();
            this.Update1 = new System.Windows.Forms.Button();
            this.Clear1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.PDescription = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.PTitle = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.Retrieve = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Update = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Submit = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ProjectDescription = new System.Windows.Forms.Button();
            this.ProjectTitle1 = new System.Windows.Forms.TextBox();
            this.ProjectTitle = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.UpdateProject.SuspendLayout();
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
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.UpdateProject);
            this.panel1.Controls.Add(this.Retrieve);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.Submit);
            this.panel1.Controls.Add(this.Clear);
            this.panel1.Controls.Add(this.cancel);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.ProjectDescription);
            this.panel1.Controls.Add(this.ProjectTitle1);
            this.panel1.Controls.Add(this.ProjectTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(794, 444);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // UpdateProject
            // 
            this.UpdateProject.Controls.Add(this.Update1);
            this.UpdateProject.Controls.Add(this.Clear1);
            this.UpdateProject.Controls.Add(this.button3);
            this.UpdateProject.Controls.Add(this.PDescription);
            this.UpdateProject.Controls.Add(this.button4);
            this.UpdateProject.Controls.Add(this.PTitle);
            this.UpdateProject.Controls.Add(this.button5);
            this.UpdateProject.Location = new System.Drawing.Point(199, 270);
            this.UpdateProject.Name = "UpdateProject";
            this.UpdateProject.Size = new System.Drawing.Size(411, 174);
            this.UpdateProject.TabIndex = 63;
            this.UpdateProject.TabStop = false;
            this.UpdateProject.Text = "Update Project";
            // 
            // Update1
            // 
            this.Update1.Location = new System.Drawing.Point(175, 142);
            this.Update1.Name = "Update1";
            this.Update1.Size = new System.Drawing.Size(75, 23);
            this.Update1.TabIndex = 66;
            this.Update1.Text = "Update";
            this.Update1.UseVisualStyleBackColor = true;
            this.Update1.Click += new System.EventHandler(this.Update1_Click);
            // 
            // Clear1
            // 
            this.Clear1.Location = new System.Drawing.Point(94, 142);
            this.Clear1.Name = "Clear1";
            this.Clear1.Size = new System.Drawing.Size(75, 23);
            this.Clear1.TabIndex = 65;
            this.Clear1.Text = "Clear";
            this.Clear1.UseVisualStyleBackColor = true;
            this.Clear1.Click += new System.EventHandler(this.Clear1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(256, 142);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 64;
            this.button3.Text = "Cancel";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // PDescription
            // 
            this.PDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PDescription.Location = new System.Drawing.Point(175, 67);
            this.PDescription.Multiline = true;
            this.PDescription.Name = "PDescription";
            this.PDescription.Size = new System.Drawing.Size(186, 55);
            this.PDescription.TabIndex = 63;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(20, 83);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(134, 23);
            this.button4.TabIndex = 62;
            this.button4.Text = "Project Description";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // PTitle
            // 
            this.PTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PTitle.Location = new System.Drawing.Point(175, 30);
            this.PTitle.Multiline = true;
            this.PTitle.Name = "PTitle";
            this.PTitle.Size = new System.Drawing.Size(186, 31);
            this.PTitle.TabIndex = 61;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(20, 30);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(103, 23);
            this.button5.TabIndex = 60;
            this.button5.Text = "Project Title";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // Retrieve
            // 
            this.Retrieve.Location = new System.Drawing.Point(490, 176);
            this.Retrieve.Name = "Retrieve";
            this.Retrieve.Size = new System.Drawing.Size(75, 23);
            this.Retrieve.TabIndex = 62;
            this.Retrieve.Text = "Retrieve";
            this.Retrieve.UseVisualStyleBackColor = true;
            this.Retrieve.Click += new System.EventHandler(this.Retrieve_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Update,
            this.Delete});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 230);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(794, 214);
            this.dataGridView1.TabIndex = 60;
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
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(328, 176);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(75, 23);
            this.Submit.TabIndex = 59;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(247, 176);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(75, 23);
            this.Clear.TabIndex = 58;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click_1);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(409, 176);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 57;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(356, 84);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(230, 68);
            this.textBox1.TabIndex = 56;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ProjectDescription
            // 
            this.ProjectDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectDescription.Location = new System.Drawing.Point(188, 99);
            this.ProjectDescription.Name = "ProjectDescription";
            this.ProjectDescription.Size = new System.Drawing.Size(134, 23);
            this.ProjectDescription.TabIndex = 55;
            this.ProjectDescription.Text = "Project Description";
            this.ProjectDescription.UseVisualStyleBackColor = true;
            this.ProjectDescription.Click += new System.EventHandler(this.ProjectDescription_Click);
            // 
            // ProjectTitle1
            // 
            this.ProjectTitle1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProjectTitle1.Location = new System.Drawing.Point(356, 23);
            this.ProjectTitle1.Multiline = true;
            this.ProjectTitle1.Name = "ProjectTitle1";
            this.ProjectTitle1.Size = new System.Drawing.Size(230, 31);
            this.ProjectTitle1.TabIndex = 54;
            this.ProjectTitle1.TextChanged += new System.EventHandler(this.ProjectTitle1_TextChanged);
            // 
            // ProjectTitle
            // 
            this.ProjectTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectTitle.Location = new System.Drawing.Point(188, 31);
            this.ProjectTitle.Name = "ProjectTitle";
            this.ProjectTitle.Size = new System.Drawing.Size(103, 23);
            this.ProjectTitle.TabIndex = 53;
            this.ProjectTitle.Text = "Project Title";
            this.ProjectTitle.UseVisualStyleBackColor = true;
            this.ProjectTitle.Click += new System.EventHandler(this.ProjectTitle_Click);
            // 
            // ManageProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ManageProject";
            this.Text = "ManageProject";
            this.Load += new System.EventHandler(this.ManageProject_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.UpdateProject.ResumeLayout(false);
            this.UpdateProject.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button ProjectDescription;
        private System.Windows.Forms.TextBox ProjectTitle1;
        private System.Windows.Forms.Button ProjectTitle;
        private System.Windows.Forms.Button Retrieve;
        private System.Windows.Forms.DataGridViewButtonColumn Update;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.GroupBox UpdateProject;
        private System.Windows.Forms.Button Update1;
        private System.Windows.Forms.Button Clear1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox PDescription;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox PTitle;
        private System.Windows.Forms.Button button5;
    }
}