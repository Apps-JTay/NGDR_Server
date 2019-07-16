namespace NGDR_Server.Forms
{
    partial class ConnectionString
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
            this.connectionStringManager1 = new JTay.ConnectionStringManager.ConnectionStringManager();
            this.SuspendLayout();
            // 
            // connectionStringManager1
            // 
            this.connectionStringManager1.Location = new System.Drawing.Point(2, 2);
            this.connectionStringManager1.Name = "connectionStringManager1";
            this.connectionStringManager1.Size = new System.Drawing.Size(1057, 339);
            this.connectionStringManager1.TabIndex = 0;
            // 
            // ConnectionString
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 353);
            this.Controls.Add(this.connectionStringManager1);
            this.Name = "ConnectionString";
            this.Text = "Connection String";
            this.ResumeLayout(false);

        }

        #endregion

        private JTay.ConnectionStringManager.ConnectionStringManager connectionStringManager1;
    }
}