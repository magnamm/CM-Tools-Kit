namespace CM_Booked.Views
{
    partial class WebBookingToday
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
            this.dgvSummery = new System.Windows.Forms.DataGridView();
            this.inputDate = new System.Windows.Forms.DateTimePicker();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.txbQuery = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.chkBooked = new System.Windows.Forms.CheckBox();
            this.chkSimple = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSummery)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvSummery
            // 
            this.dgvSummery.AllowUserToAddRows = false;
            this.dgvSummery.AllowUserToDeleteRows = false;
            this.dgvSummery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.dgvSummery, 2);
            this.dgvSummery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSummery.Location = new System.Drawing.Point(3, 103);
            this.dgvSummery.Name = "dgvSummery";
            this.dgvSummery.ReadOnly = true;
            this.dgvSummery.RowHeadersWidth = 62;
            this.dgvSummery.Size = new System.Drawing.Size(1108, 549);
            this.dgvSummery.TabIndex = 2;
            // 
            // inputDate
            // 
            this.inputDate.Location = new System.Drawing.Point(3, 3);
            this.inputDate.Name = "inputDate";
            this.inputDate.Size = new System.Drawing.Size(200, 26);
            this.inputDate.TabIndex = 3;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(209, 3);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(160, 33);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Refresh ";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // txbQuery
            // 
            this.txbQuery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txbQuery.Location = new System.Drawing.Point(403, 3);
            this.txbQuery.Multiline = true;
            this.txbQuery.Name = "txbQuery";
            this.txbQuery.Size = new System.Drawing.Size(708, 94);
            this.txbQuery.TabIndex = 5;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 400F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgvSummery, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txbQuery, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1114, 655);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.inputDate);
            this.flowLayoutPanel1.Controls.Add(this.btnRefresh);
            this.flowLayoutPanel1.Controls.Add(this.chkBooked);
            this.flowLayoutPanel1.Controls.Add(this.chkSimple);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(394, 94);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // chkBooked
            // 
            this.chkBooked.AutoSize = true;
            this.chkBooked.Checked = true;
            this.chkBooked.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBooked.Location = new System.Drawing.Point(3, 42);
            this.chkBooked.Name = "chkBooked";
            this.chkBooked.Size = new System.Drawing.Size(105, 24);
            this.chkBooked.TabIndex = 5;
            this.chkBooked.Text = "Plan Date";
            this.chkBooked.UseVisualStyleBackColor = true;
            // 
            // chkSimple
            // 
            this.chkSimple.AutoSize = true;
            this.chkSimple.Checked = true;
            this.chkSimple.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSimple.Location = new System.Drawing.Point(114, 42);
            this.chkSimple.Name = "chkSimple";
            this.chkSimple.Size = new System.Drawing.Size(86, 24);
            this.chkSimple.TabIndex = 6;
            this.chkSimple.Text = "Simpify";
            this.chkSimple.UseVisualStyleBackColor = true;
            // 
            // WebBookingToday
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 655);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "WebBookingToday";
            this.Text = "WebBookingToday";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSummery)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSummery;
        private System.Windows.Forms.DateTimePicker inputDate;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TextBox txbQuery;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.CheckBox chkBooked;
        private System.Windows.Forms.CheckBox chkSimple;
    }
}