
namespace Eclerx.Question2.AshutoshNayak
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
            this.lblCustomerCity = new System.Windows.Forms.Label();
            this.TxtCustomerCity = new System.Windows.Forms.TextBox();
            this.LblSearchBy = new System.Windows.Forms.Label();
            this.comboSortBy = new System.Windows.Forms.ComboBox();
            this.DataGridGetData = new System.Windows.Forms.DataGridView();
            this.btnGetData = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridGetData)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCustomerCity
            // 
            this.lblCustomerCity.AutoSize = true;
            this.lblCustomerCity.Font = new System.Drawing.Font("Bodoni MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerCity.Location = new System.Drawing.Point(21, 24);
            this.lblCustomerCity.Name = "lblCustomerCity";
            this.lblCustomerCity.Size = new System.Drawing.Size(99, 18);
            this.lblCustomerCity.TabIndex = 0;
            this.lblCustomerCity.Text = "Customer City";
            // 
            // TxtCustomerCity
            // 
            this.TxtCustomerCity.Location = new System.Drawing.Point(126, 22);
            this.TxtCustomerCity.Name = "TxtCustomerCity";
            this.TxtCustomerCity.Size = new System.Drawing.Size(149, 20);
            this.TxtCustomerCity.TabIndex = 1;
            // 
            // LblSearchBy
            // 
            this.LblSearchBy.AutoSize = true;
            this.LblSearchBy.Font = new System.Drawing.Font("Bodoni MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSearchBy.Location = new System.Drawing.Point(35, 54);
            this.LblSearchBy.Name = "LblSearchBy";
            this.LblSearchBy.Size = new System.Drawing.Size(57, 18);
            this.LblSearchBy.TabIndex = 2;
            this.LblSearchBy.Text = "Sort By";
            // 
            // comboSortBy
            // 
            this.comboSortBy.FormattingEnabled = true;
            this.comboSortBy.Items.AddRange(new object[] {
            "CreditLimit: Low To High",
            "CreditLimit: High To Low",
            "CustomerName: A to Z",
            "CustomerName: Z to A",
            ""});
            this.comboSortBy.Location = new System.Drawing.Point(126, 51);
            this.comboSortBy.Name = "comboSortBy";
            this.comboSortBy.Size = new System.Drawing.Size(149, 21);
            this.comboSortBy.TabIndex = 3;
            // 
            // DataGridGetData
            // 
            this.DataGridGetData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridGetData.Location = new System.Drawing.Point(12, 98);
            this.DataGridGetData.Name = "DataGridGetData";
            this.DataGridGetData.Size = new System.Drawing.Size(409, 260);
            this.DataGridGetData.TabIndex = 4;
            // 
            // btnGetData
            // 
            this.btnGetData.Font = new System.Drawing.Font("Bodoni MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetData.Location = new System.Drawing.Point(307, 33);
            this.btnGetData.Name = "btnGetData";
            this.btnGetData.Size = new System.Drawing.Size(75, 27);
            this.btnGetData.TabIndex = 5;
            this.btnGetData.Text = "Get Data";
            this.btnGetData.UseVisualStyleBackColor = true;
            this.btnGetData.Click += new System.EventHandler(this.btnGetData_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 370);
            this.Controls.Add(this.btnGetData);
            this.Controls.Add(this.DataGridGetData);
            this.Controls.Add(this.comboSortBy);
            this.Controls.Add(this.LblSearchBy);
            this.Controls.Add(this.TxtCustomerCity);
            this.Controls.Add(this.lblCustomerCity);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridGetData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCustomerCity;
        private System.Windows.Forms.TextBox TxtCustomerCity;
        private System.Windows.Forms.Label LblSearchBy;
        private System.Windows.Forms.ComboBox comboSortBy;
        private System.Windows.Forms.DataGridView DataGridGetData;
        private System.Windows.Forms.Button btnGetData;
    }
}

