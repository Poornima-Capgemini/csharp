namespace API_ClientDemo
{
    partial class Form2
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
            this.lblContactId = new System.Windows.Forms.Label();
            this.lblEmpno = new System.Windows.Forms.Label();
            this.lblDept = new System.Windows.Forms.Label();
            this.lblDesig = new System.Windows.Forms.Label();
            this.lblBasic = new System.Windows.Forms.Label();
            this.txtEmpno = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDept = new System.Windows.Forms.TextBox();
            this.txtDesig = new System.Windows.Forms.TextBox();
            this.txtBasic = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblContactId
            // 
            this.lblContactId.AutoSize = true;
            this.lblContactId.Location = new System.Drawing.Point(68, 44);
            this.lblContactId.Name = "lblContactId";
            this.lblContactId.Size = new System.Drawing.Size(40, 13);
            this.lblContactId.TabIndex = 0;
            this.lblContactId.Text = "Empno";
            // 
            // lblEmpno
            // 
            this.lblEmpno.AutoSize = true;
            this.lblEmpno.Location = new System.Drawing.Point(68, 79);
            this.lblEmpno.Name = "lblEmpno";
            this.lblEmpno.Size = new System.Drawing.Size(35, 13);
            this.lblEmpno.TabIndex = 1;
            this.lblEmpno.Text = "Name";
            // 
            // lblDept
            // 
            this.lblDept.AutoSize = true;
            this.lblDept.Location = new System.Drawing.Point(68, 114);
            this.lblDept.Name = "lblDept";
            this.lblDept.Size = new System.Drawing.Size(30, 13);
            this.lblDept.TabIndex = 2;
            this.lblDept.Text = "Dept";
            // 
            // lblDesig
            // 
            this.lblDesig.AutoSize = true;
            this.lblDesig.Location = new System.Drawing.Point(69, 156);
            this.lblDesig.Name = "lblDesig";
            this.lblDesig.Size = new System.Drawing.Size(34, 13);
            this.lblDesig.TabIndex = 3;
            this.lblDesig.Text = "Desig";
            // 
            // lblBasic
            // 
            this.lblBasic.AutoSize = true;
            this.lblBasic.Location = new System.Drawing.Point(69, 193);
            this.lblBasic.Name = "lblBasic";
            this.lblBasic.Size = new System.Drawing.Size(33, 13);
            this.lblBasic.TabIndex = 4;
            this.lblBasic.Text = "Basic";
            // 
            // txtEmpno
            // 
            this.txtEmpno.Location = new System.Drawing.Point(162, 44);
            this.txtEmpno.Name = "txtEmpno";
            this.txtEmpno.Size = new System.Drawing.Size(100, 20);
            this.txtEmpno.TabIndex = 5;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(162, 79);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 6;
            // 
            // txtDept
            // 
            this.txtDept.Location = new System.Drawing.Point(162, 114);
            this.txtDept.Name = "txtDept";
            this.txtDept.Size = new System.Drawing.Size(100, 20);
            this.txtDept.TabIndex = 7;
            // 
            // txtDesig
            // 
            this.txtDesig.Location = new System.Drawing.Point(162, 148);
            this.txtDesig.Name = "txtDesig";
            this.txtDesig.Size = new System.Drawing.Size(100, 20);
            this.txtDesig.TabIndex = 8;
            // 
            // txtBasic
            // 
            this.txtBasic.Location = new System.Drawing.Point(162, 185);
            this.txtBasic.Name = "txtBasic";
            this.txtBasic.Size = new System.Drawing.Size(100, 20);
            this.txtBasic.TabIndex = 9;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(27, 261);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtBasic);
            this.Controls.Add(this.txtDesig);
            this.Controls.Add(this.txtDept);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtEmpno);
            this.Controls.Add(this.lblBasic);
            this.Controls.Add(this.lblDesig);
            this.Controls.Add(this.lblDept);
            this.Controls.Add(this.lblEmpno);
            this.Controls.Add(this.lblContactId);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblContactId;
        private System.Windows.Forms.Label lblEmpno;
        private System.Windows.Forms.Label lblDept;
        private System.Windows.Forms.Label lblDesig;
        private System.Windows.Forms.Label lblBasic;
        private System.Windows.Forms.TextBox txtEmpno;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDept;
        private System.Windows.Forms.TextBox txtDesig;
        private System.Windows.Forms.TextBox txtBasic;
        private System.Windows.Forms.Button btnSearch;
    }
}