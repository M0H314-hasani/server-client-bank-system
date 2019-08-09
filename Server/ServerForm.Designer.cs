namespace Server
{
    partial class ServerForm
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
            this.serveButton = new System.Windows.Forms.Button();
            this.portTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // serveButton
            // 
            this.serveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serveButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.serveButton.Location = new System.Drawing.Point(12, 118);
            this.serveButton.Name = "serveButton";
            this.serveButton.Size = new System.Drawing.Size(288, 82);
            this.serveButton.TabIndex = 0;
            this.serveButton.Text = "Serve";
            this.serveButton.UseVisualStyleBackColor = true;
            this.serveButton.Click += new System.EventHandler(this.serveButton_Click);
            // 
            // portTextBox
            // 
            this.portTextBox.BackColor = System.Drawing.SystemColors.Menu;
            this.portTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.portTextBox.Location = new System.Drawing.Point(12, 14);
            this.portTextBox.Name = "portTextBox";
            this.portTextBox.Size = new System.Drawing.Size(288, 98);
            this.portTextBox.TabIndex = 1;
            this.portTextBox.Text = "8080";
            this.portTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ServerForm
            // 
            this.ClientSize = new System.Drawing.Size(312, 210);
            this.Controls.Add(this.portTextBox);
            this.Controls.Add(this.serveButton);
            this.Name = "ServerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_Send;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Message;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem StartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button serveButton;
        private System.Windows.Forms.TextBox portTextBox;
    }
}

