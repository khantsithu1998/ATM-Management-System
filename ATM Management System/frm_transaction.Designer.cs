namespace ATM_Management_System
{
    partial class frm_transaction
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_accountno = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.transactionsDataGridView = new System.Windows.Forms.DataGridView();
            this.ds_transaction = new ATM_Management_System.ds_transaction();
            this.transactionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new ATM_Management_System.ds_transectionTableAdapters.TableAdapterManager();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Account_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Transaction_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_transaction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(102)))), ((int)(((byte)(128)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 434);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(704, 8);
            this.panel2.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(102)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.lbl_accountno);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(704, 81);
            this.panel1.TabIndex = 2;
            // 
            // lbl_accountno
            // 
            this.lbl_accountno.AutoSize = true;
            this.lbl_accountno.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_accountno.ForeColor = System.Drawing.Color.White;
            this.lbl_accountno.Location = new System.Drawing.Point(33, 20);
            this.lbl_accountno.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_accountno.Name = "lbl_accountno";
            this.lbl_accountno.Size = new System.Drawing.Size(120, 24);
            this.lbl_accountno.TabIndex = 11;
            this.lbl_accountno.Text = "Account No";
            this.lbl_accountno.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(194, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(327, 41);
            this.label3.TabIndex = 10;
            this.label3.Text = "Your Transactions List ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(328, 393);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 29);
            this.label8.TabIndex = 34;
            this.label8.Text = "Back";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.transactionsDataGridView);
            this.panel3.Location = new System.Drawing.Point(7, 86);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(686, 305);
            this.panel3.TabIndex = 35;
            // 
            // transactionsDataGridView
            // 
            this.transactionsDataGridView.AllowUserToAddRows = false;
            this.transactionsDataGridView.AutoGenerateColumns = false;
            this.transactionsDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.transactionsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.transactionsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.transactionsDataGridView.ColumnHeadersHeight = 40;
            this.transactionsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Transaction_ID,
            this.Account_No,
            this.FullName,
            this.Amount,
            this.Type,
            this.Date});
            this.transactionsDataGridView.DataSource = this.ds_transaction;
            this.transactionsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.transactionsDataGridView.EnableHeadersVisualStyles = false;
            this.transactionsDataGridView.GridColor = System.Drawing.Color.White;
            this.transactionsDataGridView.Location = new System.Drawing.Point(0, 0);
            this.transactionsDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.transactionsDataGridView.Name = "transactionsDataGridView";
            this.transactionsDataGridView.RowHeadersVisible = false;
            this.transactionsDataGridView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.transactionsDataGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactionsDataGridView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.transactionsDataGridView.RowTemplate.Height = 30;
            this.transactionsDataGridView.RowTemplate.ReadOnly = true;
            this.transactionsDataGridView.Size = new System.Drawing.Size(686, 305);
            this.transactionsDataGridView.TabIndex = 0;
            this.transactionsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.transectionsDataGridView_CellContentClick);
            // 
            // ds_transaction
            // 
            this.ds_transaction.DataSetName = "ds_transaction";
            this.ds_transaction.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // transactionsBindingSource
            // 
            this.transactionsBindingSource.DataMember = "transactions";
            this.transactionsBindingSource.DataSource = this.ds_transaction;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.transactionsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ATM_Management_System.ds_transectionTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "date";
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            // 
            // Type
            // 
            this.Type.DataPropertyName = "transaction_type";
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            // 
            // Amount
            // 
            this.Amount.DataPropertyName = "amount";
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            // 
            // FullName
            // 
            this.FullName.DataPropertyName = "name";
            this.FullName.HeaderText = "Name";
            this.FullName.Name = "FullName";
            // 
            // Account_No
            // 
            this.Account_No.DataPropertyName = "account_no";
            this.Account_No.HeaderText = "Account_No";
            this.Account_No.Name = "Account_No";
            // 
            // Transaction_ID
            // 
            this.Transaction_ID.DataPropertyName = "transaction_id";
            this.Transaction_ID.HeaderText = "Transaction_ID";
            this.Transaction_ID.Name = "Transaction_ID";
            this.Transaction_ID.ReadOnly = true;
            // 
            // frm_transaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(704, 442);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frm_transaction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_transaction";
            this.Load += new System.EventHandler(this.frm_transaction_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.transactionsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_transaction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel3;
        private ds_transaction ds_transaction;
        private System.Windows.Forms.BindingSource transactionsBindingSource;
        private ds_transectionTableAdapters.TableAdapterManager tableAdapterManager;
        public System.Windows.Forms.DataGridView transactionsDataGridView;
        private System.Windows.Forms.Label lbl_accountno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Transaction_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Account_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
    }
}