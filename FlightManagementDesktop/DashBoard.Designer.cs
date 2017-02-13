namespace FlightManagementDesktop
{
    partial class DashBoard
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.DDCustomer = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DDFT = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBoxDeparture = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.TextBoxArrived = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TextBoxCompany = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DDRow = new System.Windows.Forms.ComboBox();
            this.ButtonGetValues = new System.Windows.Forms.Button();
            this.LabelResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(46, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer";
            // 
            // DDCustomer
            // 
            this.DDCustomer.FormattingEnabled = true;
            this.DDCustomer.Location = new System.Drawing.Point(12, 37);
            this.DDCustomer.Name = "DDCustomer";
            this.DDCustomer.Size = new System.Drawing.Size(146, 21);
            this.DDCustomer.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.Location = new System.Drawing.Point(239, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "ForTo";
            // 
            // DDFT
            // 
            this.DDFT.FormattingEnabled = true;
            this.DDFT.Location = new System.Drawing.Point(191, 37);
            this.DDFT.Name = "DDFT";
            this.DDFT.Size = new System.Drawing.Size(146, 21);
            this.DDFT.TabIndex = 3;
            this.DDFT.SelectedIndexChanged += new System.EventHandler(this.DDFT_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label3.Location = new System.Drawing.Point(44, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Departure";
            // 
            // TextBoxDeparture
            // 
            this.TextBoxDeparture.Location = new System.Drawing.Point(12, 96);
            this.TextBoxDeparture.Name = "TextBoxDeparture";
            this.TextBoxDeparture.Size = new System.Drawing.Size(146, 20);
            this.TextBoxDeparture.TabIndex = 5;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Label4.Location = new System.Drawing.Point(232, 72);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(60, 21);
            this.Label4.TabIndex = 6;
            this.Label4.Text = "Arrived";
            // 
            // TextBoxArrived
            // 
            this.TextBoxArrived.Location = new System.Drawing.Point(191, 96);
            this.TextBoxArrived.Name = "TextBoxArrived";
            this.TextBoxArrived.Size = new System.Drawing.Size(146, 20);
            this.TextBoxArrived.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label5.Location = new System.Drawing.Point(46, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "Company";
            // 
            // TextBoxCompany
            // 
            this.TextBoxCompany.Location = new System.Drawing.Point(12, 159);
            this.TextBoxCompany.Name = "TextBoxCompany";
            this.TextBoxCompany.Size = new System.Drawing.Size(146, 20);
            this.TextBoxCompany.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label6.Location = new System.Drawing.Point(243, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 21);
            this.label6.TabIndex = 10;
            this.label6.Text = "Seat";
            // 
            // DDRow
            // 
            this.DDRow.FormattingEnabled = true;
            this.DDRow.Location = new System.Drawing.Point(191, 159);
            this.DDRow.Name = "DDRow";
            this.DDRow.Size = new System.Drawing.Size(146, 21);
            this.DDRow.TabIndex = 11;
            // 
            // ButtonGetValues
            // 
            this.ButtonGetValues.BackColor = System.Drawing.Color.RoyalBlue;
            this.ButtonGetValues.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonGetValues.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ButtonGetValues.Location = new System.Drawing.Point(106, 223);
            this.ButtonGetValues.Name = "ButtonGetValues";
            this.ButtonGetValues.Size = new System.Drawing.Size(133, 39);
            this.ButtonGetValues.TabIndex = 12;
            this.ButtonGetValues.Text = "Buy";
            this.ButtonGetValues.UseVisualStyleBackColor = false;
            this.ButtonGetValues.Click += new System.EventHandler(this.ButtonGetValues_Click);
            // 
            // LabelResult
            // 
            this.LabelResult.AutoSize = true;
            this.LabelResult.Location = new System.Drawing.Point(13, 310);
            this.LabelResult.Name = "LabelResult";
            this.LabelResult.Size = new System.Drawing.Size(0, 13);
            this.LabelResult.TabIndex = 13;
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 301);
            this.Controls.Add(this.LabelResult);
            this.Controls.Add(this.ButtonGetValues);
            this.Controls.Add(this.DDRow);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TextBoxCompany);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TextBoxArrived);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.TextBoxDeparture);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DDFT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DDCustomer);
            this.Controls.Add(this.label1);
            this.Name = "DashBoard";
            this.Text = "Buy your ticket";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox DDCustomer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox DDFT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextBoxDeparture;
        private System.Windows.Forms.Label Label4;
        private System.Windows.Forms.TextBox TextBoxArrived;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TextBoxCompany;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox DDRow;
        private System.Windows.Forms.Button ButtonGetValues;
        private System.Windows.Forms.Label LabelResult;
    }
}

