namespace CefTest {
	partial class Form1 {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.btnVersion = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnWinds = new System.Windows.Forms.Button();
			this.btnEnviro = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnVersion
			// 
			this.btnVersion.Location = new System.Drawing.Point(12, 3);
			this.btnVersion.Name = "btnVersion";
			this.btnVersion.Size = new System.Drawing.Size(75, 23);
			this.btnVersion.TabIndex = 0;
			this.btnVersion.Text = "Version";
			this.btnVersion.UseVisualStyleBackColor = true;
			this.btnVersion.Click += new System.EventHandler(this.btnVersion_Click);
			// 
			// panel1
			// 
			this.panel1.Location = new System.Drawing.Point(12, 32);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1022, 765);
			this.panel1.TabIndex = 1;
			// 
			// btnWinds
			// 
			this.btnWinds.Location = new System.Drawing.Point(93, 3);
			this.btnWinds.Name = "btnWinds";
			this.btnWinds.Size = new System.Drawing.Size(75, 23);
			this.btnWinds.TabIndex = 2;
			this.btnWinds.Text = "Winds";
			this.btnWinds.UseVisualStyleBackColor = true;
			this.btnWinds.Click += new System.EventHandler(this.btnWinds_Click);
			// 
			// btnEnviro
			// 
			this.btnEnviro.Location = new System.Drawing.Point(174, 3);
			this.btnEnviro.Name = "btnEnviro";
			this.btnEnviro.Size = new System.Drawing.Size(75, 23);
			this.btnEnviro.TabIndex = 3;
			this.btnEnviro.Text = "Enviro";
			this.btnEnviro.UseVisualStyleBackColor = true;
			this.btnEnviro.Click += new System.EventHandler(this.btnEnviro_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1037, 802);
			this.Controls.Add(this.btnEnviro);
			this.Controls.Add(this.btnWinds);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.btnVersion);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "Form1";
			this.Text = "CefTest";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnVersion;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnWinds;
		private System.Windows.Forms.Button btnEnviro;
	}
}

