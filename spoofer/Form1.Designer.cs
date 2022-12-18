namespace spoofer
{
    partial class loader
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loader));
            this.spooferLaunher = new System.Windows.Forms.Button();
            this.infoLauncher = new System.Windows.Forms.Button();
            this.subKeyTextBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // spooferLaunher
            // 
            this.spooferLaunher.BackColor = System.Drawing.Color.Transparent;
            this.spooferLaunher.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.spooferLaunher.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.spooferLaunher.ForeColor = System.Drawing.Color.White;
            this.spooferLaunher.Location = new System.Drawing.Point(355, 331);
            this.spooferLaunher.Name = "spooferLaunher";
            this.spooferLaunher.Size = new System.Drawing.Size(107, 32);
            this.spooferLaunher.TabIndex = 0;
            this.spooferLaunher.Text = "Launch";
            this.spooferLaunher.UseVisualStyleBackColor = false;
            this.spooferLaunher.Click += new System.EventHandler(this.spooferLaunher_Click);
            this.spooferLaunher.MouseEnter += new System.EventHandler(this.spooferLaunher_MouseEnter);
            this.spooferLaunher.MouseLeave += new System.EventHandler(this.spooferLaunher_MouseLeave);
            // 
            // infoLauncher
            // 
            this.infoLauncher.Location = new System.Drawing.Point(673, 34);
            this.infoLauncher.Name = "infoLauncher";
            this.infoLauncher.Size = new System.Drawing.Size(115, 23);
            this.infoLauncher.TabIndex = 2;
            this.infoLauncher.Text = "Info";
            this.infoLauncher.UseVisualStyleBackColor = true;
            // 
            // subKeyTextBox1
            // 
            this.subKeyTextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.subKeyTextBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.subKeyTextBox1.Location = new System.Drawing.Point(385, 285);
            this.subKeyTextBox1.Name = "subKeyTextBox1";
            this.subKeyTextBox1.Size = new System.Drawing.Size(190, 25);
            this.subKeyTextBox1.TabIndex = 3;
            this.subKeyTextBox1.TextChanged += new System.EventHandler(this.subKeyTextBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(212, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Subscription Key";
            // 
            // loader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::spoofer.Properties.Resources.backgroundUserLogin;
            this.ClientSize = new System.Drawing.Size(800, 384);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.subKeyTextBox1);
            this.Controls.Add(this.infoLauncher);
            this.Controls.Add(this.spooferLaunher);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MdiChildrenMinimizedAnchorBottom = false;
            this.MinimizeBox = false;
            this.Name = "loader";
            this.Text = "Software Control Germany";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button spooferLaunher;
        private Button infoLauncher;
        private TextBox subKeyTextBox1;
        private Label label2;
    }
}