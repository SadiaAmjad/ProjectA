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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageProject));
            this.UpdateProject = new System.Windows.Forms.GroupBox();
            this.circularButton6 = new RoundButtonDemo.CircularButton();
            this.circularButton4 = new RoundButtonDemo.CircularButton();
            this.circularButton7 = new RoundButtonDemo.CircularButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PDescription = new System.Windows.Forms.TextBox();
            this.PTitle = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Update = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ProjectTitle1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.circularButton5 = new RoundButtonDemo.CircularButton();
            this.circularButton3 = new RoundButtonDemo.CircularButton();
            this.circularButton1 = new RoundButtonDemo.CircularButton();
            this.circularButton2 = new RoundButtonDemo.CircularButton();
            this.UpdateProject.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // UpdateProject
            // 
            this.UpdateProject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(106)))), ((int)(((byte)(93)))));
            this.UpdateProject.Controls.Add(this.circularButton6);
            this.UpdateProject.Controls.Add(this.circularButton4);
            this.UpdateProject.Controls.Add(this.circularButton7);
            this.UpdateProject.Controls.Add(this.label2);
            this.UpdateProject.Controls.Add(this.label1);
            this.UpdateProject.Controls.Add(this.PDescription);
            this.UpdateProject.Controls.Add(this.PTitle);
            this.UpdateProject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UpdateProject.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.UpdateProject.Location = new System.Drawing.Point(0, 0);
            this.UpdateProject.Name = "UpdateProject";
            this.UpdateProject.Size = new System.Drawing.Size(843, 352);
            this.UpdateProject.TabIndex = 63;
            this.UpdateProject.TabStop = false;
            this.UpdateProject.Text = "Update Project";
            // 
            // circularButton6
            // 
            this.circularButton6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(96)))), ((int)(((byte)(42)))));
            this.circularButton6.FlatAppearance.BorderSize = 0;
            this.circularButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.circularButton6.Font = new System.Drawing.Font("Blacker Text", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularButton6.ForeColor = System.Drawing.Color.White;
            this.circularButton6.Location = new System.Drawing.Point(446, 185);
            this.circularButton6.Name = "circularButton6";
            this.circularButton6.Size = new System.Drawing.Size(64, 56);
            this.circularButton6.TabIndex = 72;
            this.circularButton6.Text = "Cancel";
            this.circularButton6.UseVisualStyleBackColor = false;
            this.circularButton6.Click += new System.EventHandler(this.circularButton6_Click);
            // 
            // circularButton4
            // 
            this.circularButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(149)))), ((int)(((byte)(0)))));
            this.circularButton4.FlatAppearance.BorderSize = 0;
            this.circularButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.circularButton4.Font = new System.Drawing.Font("Blacker Text", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularButton4.ForeColor = System.Drawing.Color.White;
            this.circularButton4.Location = new System.Drawing.Point(372, 184);
            this.circularButton4.Name = "circularButton4";
            this.circularButton4.Size = new System.Drawing.Size(64, 56);
            this.circularButton4.TabIndex = 71;
            this.circularButton4.Text = "Update";
            this.circularButton4.UseVisualStyleBackColor = false;
            this.circularButton4.Click += new System.EventHandler(this.circularButton4_Click);
            // 
            // circularButton7
            // 
            this.circularButton7.BackColor = System.Drawing.Color.Crimson;
            this.circularButton7.FlatAppearance.BorderSize = 0;
            this.circularButton7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.circularButton7.Font = new System.Drawing.Font("Blacker Text", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularButton7.ForeColor = System.Drawing.Color.White;
            this.circularButton7.Location = new System.Drawing.Point(296, 184);
            this.circularButton7.Name = "circularButton7";
            this.circularButton7.Size = new System.Drawing.Size(64, 56);
            this.circularButton7.TabIndex = 70;
            this.circularButton7.Text = "Clear";
            this.circularButton7.UseVisualStyleBackColor = false;
            this.circularButton7.Click += new System.EventHandler(this.circularButton7_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(233, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 18);
            this.label2.TabIndex = 68;
            this.label2.Text = "Project Description";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(233, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 18);
            this.label1.TabIndex = 67;
            this.label1.Text = "Project Title";
            // 
            // PDescription
            // 
            this.PDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(106)))), ((int)(((byte)(93)))));
            this.PDescription.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.PDescription.Location = new System.Drawing.Point(234, 131);
            this.PDescription.Name = "PDescription";
            this.PDescription.Size = new System.Drawing.Size(379, 20);
            this.PDescription.TabIndex = 63;
            // 
            // PTitle
            // 
            this.PTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(106)))), ((int)(((byte)(93)))));
            this.PTitle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.PTitle.Location = new System.Drawing.Point(234, 78);
            this.PTitle.Name = "PTitle";
            this.PTitle.Size = new System.Drawing.Size(379, 20);
            this.PTitle.TabIndex = 61;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(96)))), ((int)(((byte)(42)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Update,
            this.Delete});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(63)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(149)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(96)))), ((int)(((byte)(42)))));
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Size = new System.Drawing.Size(843, 168);
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
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(106)))), ((int)(((byte)(93)))));
            this.textBox1.Location = new System.Drawing.Point(262, 131);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(367, 20);
            this.textBox1.TabIndex = 56;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ProjectTitle1
            // 
            this.ProjectTitle1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProjectTitle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(106)))), ((int)(((byte)(93)))));
            this.ProjectTitle1.Location = new System.Drawing.Point(262, 58);
            this.ProjectTitle1.Name = "ProjectTitle1";
            this.ProjectTitle1.Size = new System.Drawing.Size(367, 20);
            this.ProjectTitle1.TabIndex = 54;
            this.ProjectTitle1.TextChanged += new System.EventHandler(this.ProjectTitle1_TextChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(259, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 16);
            this.label4.TabIndex = 66;
            this.label4.Text = "Project Description";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(259, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 65;
            this.label3.Text = "Project Title";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 352);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(843, 168);
            this.panel1.TabIndex = 67;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.UpdateProject);
            this.panel3.Controls.Add(this.circularButton5);
            this.panel3.Controls.Add(this.circularButton3);
            this.panel3.Controls.Add(this.circularButton1);
            this.panel3.Controls.Add(this.circularButton2);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.ProjectTitle1);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(843, 352);
            this.panel3.TabIndex = 69;
            // 
            // circularButton5
            // 
            this.circularButton5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(85)))), ((int)(((byte)(106)))));
            this.circularButton5.FlatAppearance.BorderSize = 0;
            this.circularButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.circularButton5.Font = new System.Drawing.Font("Blacker Text", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularButton5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.circularButton5.Location = new System.Drawing.Point(262, 171);
            this.circularButton5.Name = "circularButton5";
            this.circularButton5.Size = new System.Drawing.Size(78, 69);
            this.circularButton5.TabIndex = 72;
            this.circularButton5.Text = "Clear";
            this.circularButton5.UseVisualStyleBackColor = false;
            this.circularButton5.Click += new System.EventHandler(this.circularButton5_Click);
            // 
            // circularButton3
            // 
            this.circularButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(85)))), ((int)(((byte)(106)))));
            this.circularButton3.FlatAppearance.BorderSize = 0;
            this.circularButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.circularButton3.Font = new System.Drawing.Font("Blacker Text", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularButton3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.circularButton3.Location = new System.Drawing.Point(508, 172);
            this.circularButton3.Name = "circularButton3";
            this.circularButton3.Size = new System.Drawing.Size(78, 69);
            this.circularButton3.TabIndex = 69;
            this.circularButton3.Text = "Cancel";
            this.circularButton3.UseVisualStyleBackColor = false;
            this.circularButton3.Click += new System.EventHandler(this.circularButton3_Click);
            // 
            // circularButton1
            // 
            this.circularButton1.BackColor = System.Drawing.Color.Crimson;
            this.circularButton1.FlatAppearance.BorderSize = 0;
            this.circularButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.circularButton1.Font = new System.Drawing.Font("Blacker Text", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularButton1.ForeColor = System.Drawing.Color.White;
            this.circularButton1.Location = new System.Drawing.Point(346, 172);
            this.circularButton1.Name = "circularButton1";
            this.circularButton1.Size = new System.Drawing.Size(76, 68);
            this.circularButton1.TabIndex = 67;
            this.circularButton1.Text = "Submit";
            this.circularButton1.UseVisualStyleBackColor = false;
            this.circularButton1.Click += new System.EventHandler(this.circularButton1_Click);
            // 
            // circularButton2
            // 
            this.circularButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(149)))), ((int)(((byte)(0)))));
            this.circularButton2.FlatAppearance.BorderSize = 0;
            this.circularButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.circularButton2.Font = new System.Drawing.Font("Blacker Text", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularButton2.ForeColor = System.Drawing.Color.White;
            this.circularButton2.Location = new System.Drawing.Point(428, 172);
            this.circularButton2.Name = "circularButton2";
            this.circularButton2.Size = new System.Drawing.Size(74, 69);
            this.circularButton2.TabIndex = 68;
            this.circularButton2.Text = "Refresh";
            this.circularButton2.UseVisualStyleBackColor = false;
            this.circularButton2.Click += new System.EventHandler(this.circularButton2_Click);
            // 
            // ManageProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 520);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManageProject";
            this.Text = "ManageProject";
            this.Load += new System.EventHandler(this.ManageProject_Load);
            this.UpdateProject.ResumeLayout(false);
            this.UpdateProject.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox ProjectTitle1;
        private System.Windows.Forms.DataGridViewButtonColumn Update;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.GroupBox UpdateProject;
        private System.Windows.Forms.TextBox PDescription;
        private System.Windows.Forms.TextBox PTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private RoundButtonDemo.CircularButton circularButton3;
        private RoundButtonDemo.CircularButton circularButton1;
        private RoundButtonDemo.CircularButton circularButton2;
        private RoundButtonDemo.CircularButton circularButton5;
        private RoundButtonDemo.CircularButton circularButton6;
        private RoundButtonDemo.CircularButton circularButton4;
        private RoundButtonDemo.CircularButton circularButton7;
    }
}