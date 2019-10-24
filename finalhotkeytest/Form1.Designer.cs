namespace HotkeySelection
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
            this.btnMimicSave = new System.Windows.Forms.Button();
            this.btnUnregister1 = new System.Windows.Forms.Button();
            this.btnRegister1 = new System.Windows.Forms.Button();
            this.btnUnregister2 = new System.Windows.Forms.Button();
            this.btnRegister2 = new System.Windows.Forms.Button();
            this.hotkeySelector1 = new HotkeySelection.HotkeySelector();
            this.hotkeySelector2 = new HotkeySelection.HotkeySelector();
            this.SuspendLayout();
            // 
            // btnMimicSave
            // 
            this.btnMimicSave.Location = new System.Drawing.Point(34, 287);
            this.btnMimicSave.Margin = new System.Windows.Forms.Padding(6);
            this.btnMimicSave.Name = "btnMimicSave";
            this.btnMimicSave.Size = new System.Drawing.Size(140, 48);
            this.btnMimicSave.TabIndex = 15;
            this.btnMimicSave.Text = "Mimic Save";
            this.btnMimicSave.UseVisualStyleBackColor = true;
            this.btnMimicSave.Click += new System.EventHandler(this.btnMimicSave_Click);
            // 
            // btnUnregister1
            // 
            this.btnUnregister1.Location = new System.Drawing.Point(232, 69);
            this.btnUnregister1.Margin = new System.Windows.Forms.Padding(6);
            this.btnUnregister1.Name = "btnUnregister1";
            this.btnUnregister1.Size = new System.Drawing.Size(150, 44);
            this.btnUnregister1.TabIndex = 14;
            this.btnUnregister1.Text = "Unregsiter";
            this.btnUnregister1.UseVisualStyleBackColor = true;
            this.btnUnregister1.Click += new System.EventHandler(this.btnUnregister1_Click);
            // 
            // btnRegister1
            // 
            this.btnRegister1.Location = new System.Drawing.Point(34, 69);
            this.btnRegister1.Margin = new System.Windows.Forms.Padding(6);
            this.btnRegister1.Name = "btnRegister1";
            this.btnRegister1.Size = new System.Drawing.Size(150, 44);
            this.btnRegister1.TabIndex = 13;
            this.btnRegister1.Text = "Register";
            this.btnRegister1.UseVisualStyleBackColor = true;
            this.btnRegister1.Click += new System.EventHandler(this.btnRegister1_Click);
            // 
            // btnUnregister2
            // 
            this.btnUnregister2.Location = new System.Drawing.Point(232, 207);
            this.btnUnregister2.Margin = new System.Windows.Forms.Padding(6);
            this.btnUnregister2.Name = "btnUnregister2";
            this.btnUnregister2.Size = new System.Drawing.Size(150, 44);
            this.btnUnregister2.TabIndex = 11;
            this.btnUnregister2.Text = "Unregsiter";
            this.btnUnregister2.UseVisualStyleBackColor = true;
            this.btnUnregister2.Click += new System.EventHandler(this.btnUnregister2_Click);
            // 
            // btnRegister2
            // 
            this.btnRegister2.Location = new System.Drawing.Point(34, 207);
            this.btnRegister2.Margin = new System.Windows.Forms.Padding(6);
            this.btnRegister2.Name = "btnRegister2";
            this.btnRegister2.Size = new System.Drawing.Size(150, 44);
            this.btnRegister2.TabIndex = 10;
            this.btnRegister2.Text = "Register";
            this.btnRegister2.UseVisualStyleBackColor = true;
            this.btnRegister2.Click += new System.EventHandler(this.btnRegister2_Click);
            // 
            // hotkeySelector1
            // 
            this.hotkeySelector1.Location = new System.Drawing.Point(30, 26);
            this.hotkeySelector1.Margin = new System.Windows.Forms.Padding(6);
            this.hotkeySelector1.Name = "hotkeySelector1";
            this.hotkeySelector1.Size = new System.Drawing.Size(396, 31);
            this.hotkeySelector1.TabIndex = 12;
            this.hotkeySelector1.HotKeyPressed += new System.EventHandler(this.hotkeySelector1_HotKeyPressed);
            // 
            // hotkeySelector2
            // 
            this.hotkeySelector2.Location = new System.Drawing.Point(30, 149);
            this.hotkeySelector2.Margin = new System.Windows.Forms.Padding(6);
            this.hotkeySelector2.Name = "hotkeySelector2";
            this.hotkeySelector2.Size = new System.Drawing.Size(396, 31);
            this.hotkeySelector2.TabIndex = 9;
            this.hotkeySelector2.HotKeyPressed += new System.EventHandler(this.hotkeySelector2_HotKeyPressed);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 373);
            this.Controls.Add(this.btnMimicSave);
            this.Controls.Add(this.btnUnregister1);
            this.Controls.Add(this.btnRegister1);
            this.Controls.Add(this.hotkeySelector1);
            this.Controls.Add(this.btnUnregister2);
            this.Controls.Add(this.btnRegister2);
            this.Controls.Add(this.hotkeySelector2);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Hotkey Test";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnMimicSave;
        private System.Windows.Forms.Button btnUnregister1;
        private System.Windows.Forms.Button btnRegister1;
        private HotkeySelector hotkeySelector1;
        private System.Windows.Forms.Button btnUnregister2;
        private System.Windows.Forms.Button btnRegister2;
        private HotkeySelector hotkeySelector2;
    }
}

