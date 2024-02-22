namespace DevTesr.PL
{
    partial class frmEmployee
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
            btn_add = new Button();
            txt_name_employee = new TextBox();
            txt_last_name_employee = new TextBox();
            txt_rfc_employee = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            cmbx_status = new ComboBox();
            datetime_borndate = new DateTimePicker();
            Query_data = new Button();
            txt_id_employee = new TextBox();
            SuspendLayout();
            // 
            // btn_add
            // 
            btn_add.Location = new Point(305, 335);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(160, 29);
            btn_add.TabIndex = 0;
            btn_add.Text = "ADD";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += button1_Click;
            // 
            // txt_name_employee
            // 
            txt_name_employee.Location = new Point(314, 24);
            txt_name_employee.Name = "txt_name_employee";
            txt_name_employee.Size = new Size(125, 27);
            txt_name_employee.TabIndex = 3;
            txt_name_employee.KeyPress += txt_name_employee_KeyPress;
            // 
            // txt_last_name_employee
            // 
            txt_last_name_employee.Location = new Point(314, 79);
            txt_last_name_employee.Name = "txt_last_name_employee";
            txt_last_name_employee.Size = new Size(125, 27);
            txt_last_name_employee.TabIndex = 4;
            txt_last_name_employee.KeyPress += txt_last_name_employee_KeyPress;
            // 
            // txt_rfc_employee
            // 
            txt_rfc_employee.Location = new Point(314, 130);
            txt_rfc_employee.Name = "txt_rfc_employee";
            txt_rfc_employee.Size = new Size(125, 27);
            txt_rfc_employee.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(225, 27);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 8;
            label1.Text = "NAME";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(204, 82);
            label2.Name = "label2";
            label2.Size = new Size(92, 20);
            label2.TabIndex = 9;
            label2.Text = "LAST NAME ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(226, 133);
            label3.Name = "label3";
            label3.Size = new Size(34, 20);
            label3.TabIndex = 10;
            label3.Text = "RFC";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(204, 175);
            label4.Name = "label4";
            label4.Size = new Size(89, 20);
            label4.TabIndex = 11;
            label4.Text = "BORN DATE";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(217, 224);
            label5.Name = "label5";
            label5.Size = new Size(59, 20);
            label5.TabIndex = 12;
            label5.Text = "STATUS";
            // 
            // cmbx_status
            // 
            cmbx_status.FormatString = "N2";
            cmbx_status.FormattingEnabled = true;
            cmbx_status.Items.AddRange(new object[] { "Not Set", "Active", "Inactive" });
            cmbx_status.Location = new Point(314, 221);
            cmbx_status.Name = "cmbx_status";
            cmbx_status.Size = new Size(151, 28);
            cmbx_status.TabIndex = 13;
            // 
            // datetime_borndate
            // 
            datetime_borndate.CustomFormat = "";
            datetime_borndate.Format = DateTimePickerFormat.Short;
            datetime_borndate.Location = new Point(314, 170);
            datetime_borndate.Name = "datetime_borndate";
            datetime_borndate.Size = new Size(290, 27);
            datetime_borndate.TabIndex = 14;
            // 
            // Query_data
            // 
            Query_data.Location = new Point(272, 399);
            Query_data.Name = "Query_data";
            Query_data.Size = new Size(223, 29);
            Query_data.TabIndex = 16;
            Query_data.Text = "QUERY DATA";
            Query_data.UseVisualStyleBackColor = true;
            Query_data.Click += Query_data_Click;
            // 
            // txt_id_employee
            // 
            txt_id_employee.Location = new Point(489, 20);
            txt_id_employee.Name = "txt_id_employee";
            txt_id_employee.Size = new Size(125, 27);
            txt_id_employee.TabIndex = 2;
            txt_id_employee.Visible = false;
            // 
            // frmEmployee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Query_data);
            Controls.Add(datetime_borndate);
            Controls.Add(cmbx_status);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_rfc_employee);
            Controls.Add(txt_last_name_employee);
            Controls.Add(txt_name_employee);
            Controls.Add(txt_id_employee);
            Controls.Add(btn_add);
            Name = "frmEmployee";
            Text = "EMPLOYEE";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_add;
        private TextBox txt_name_employee;
        private TextBox txt_last_name_employee;
        private TextBox txt_rfc_employee;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox cmbx_status;
        private DateTimePicker datetime_borndate;
        private Button Query_data;
        private TextBox txt_id_employee;
    }
}