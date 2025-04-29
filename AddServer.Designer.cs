namespace Breaworlds_PrivateServerManager
{
    partial class AddServer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddServer));
            label1 = new Label();
            txt_serverCode = new RichTextBox();
            btn_add = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 0;
            label1.Text = "Server Code";
            // 
            // txt_serverCode
            // 
            txt_serverCode.Location = new Point(12, 27);
            txt_serverCode.Name = "txt_serverCode";
            txt_serverCode.Size = new Size(344, 96);
            txt_serverCode.TabIndex = 1;
            txt_serverCode.Text = "";
            // 
            // btn_add
            // 
            btn_add.Location = new Point(12, 129);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(344, 23);
            btn_add.TabIndex = 2;
            btn_add.Text = "Add Server to List";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += button1_Click;
            // 
            // AddServer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(364, 164);
            Controls.Add(btn_add);
            Controls.Add(txt_serverCode);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AddServer";
            Text = "Add Server";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RichTextBox txt_serverCode;
        private Button btn_add;
    }
}