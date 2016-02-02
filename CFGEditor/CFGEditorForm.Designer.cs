namespace CFGEditor
{
    partial class main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.kBind = new System.Windows.Forms.TextBox();
            this.fCam = new System.Windows.Forms.CheckBox();
            this.dConsole = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // kBind
            // 
            this.kBind.Location = new System.Drawing.Point(18, 25);
            this.kBind.Name = "kBind";
            this.kBind.Size = new System.Drawing.Size(77, 20);
            this.kBind.TabIndex = 0;
            // 
            // fCam
            // 
            this.fCam.AutoSize = true;
            this.fCam.Location = new System.Drawing.Point(18, 51);
            this.fCam.Name = "fCam";
            this.fCam.Size = new System.Drawing.Size(110, 17);
            this.fCam.TabIndex = 2;
            this.fCam.Text = "FreeCam Enabled";
            this.fCam.UseVisualStyleBackColor = true;
            // 
            // dConsole
            // 
            this.dConsole.AutoSize = true;
            this.dConsole.Location = new System.Drawing.Point(18, 74);
            this.dConsole.Name = "dConsole";
            this.dConsole.Size = new System.Drawing.Size(161, 17);
            this.dConsole.TabIndex = 3;
            this.dConsole.Text = "Debugging Console Enabled";
            this.dConsole.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Keybind for Debug Console";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(19, 109);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 28);
            this.button1.TabIndex = 5;
            this.button1.Text = "Save and Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(121, 109);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 27);
            this.button2.TabIndex = 6;
            this.button2.Text = "Exit without Saving";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 146);
            this.ControlBox = false;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dConsole);
            this.Controls.Add(this.fCam);
            this.Controls.Add(this.kBind);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Debug Console CFG Editor";
            this.Load += new System.EventHandler(this.main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox kBind;
        private System.Windows.Forms.CheckBox fCam;
        private System.Windows.Forms.CheckBox dConsole;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

