namespace TaskManager
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
            list_processes = new DataGridView();
            txtbox_processname = new TextBox();
            btn_addprocess = new Button();
            btn_removeprocess = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)list_processes).BeginInit();
            SuspendLayout();
            // 
            // list_processes
            // 
            list_processes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            list_processes.Location = new Point(22, 25);
            list_processes.Name = "list_processes";
            list_processes.RowTemplate.Height = 25;
            list_processes.Size = new Size(756, 322);
            list_processes.TabIndex = 0;
            // 
            // txtbox_processname
            // 
            txtbox_processname.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtbox_processname.Location = new Point(22, 393);
            txtbox_processname.Name = "txtbox_processname";
            txtbox_processname.Size = new Size(540, 29);
            txtbox_processname.TabIndex = 1;
            // 
            // btn_addprocess
            // 
            btn_addprocess.BackColor = Color.Green;
            btn_addprocess.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_addprocess.ForeColor = Color.White;
            btn_addprocess.Location = new Point(601, 391);
            btn_addprocess.Name = "btn_addprocess";
            btn_addprocess.Size = new Size(75, 35);
            btn_addprocess.TabIndex = 2;
            btn_addprocess.Text = "Add ";
            btn_addprocess.UseVisualStyleBackColor = false;
            btn_addprocess.Click += btn_addprocess_Click;
            // 
            // btn_removeprocess
            // 
            btn_removeprocess.BackColor = Color.Red;
            btn_removeprocess.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_removeprocess.ForeColor = Color.White;
            btn_removeprocess.Location = new Point(703, 391);
            btn_removeprocess.Name = "btn_removeprocess";
            btn_removeprocess.Size = new Size(75, 35);
            btn_removeprocess.TabIndex = 3;
            btn_removeprocess.Text = "Remove";
            btn_removeprocess.UseVisualStyleBackColor = false;
            btn_removeprocess.Click += btn_removeprocess_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(22, 370);
            label1.Name = "label1";
            label1.Size = new Size(149, 20);
            label1.TabIndex = 4;
            label1.Text = "Enter Process Name:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btn_removeprocess);
            Controls.Add(btn_addprocess);
            Controls.Add(txtbox_processname);
            Controls.Add(list_processes);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)list_processes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView list_processes;
        private TextBox txtbox_processname;
        private Button btn_addprocess;
        private Button btn_removeprocess;
        private Label label1;
    }
}