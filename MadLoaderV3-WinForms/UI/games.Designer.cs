namespace MadLoaderV3_WinForms.UI
{
    partial class games
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(games));
            this.siticoneButton1 = new Siticone.UI.WinForms.SiticoneButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.siticoneButton2 = new Siticone.UI.WinForms.SiticoneButton();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // siticoneButton1
            // 
            this.siticoneButton1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.siticoneButton1.BorderRadius = 5;
            this.siticoneButton1.BorderThickness = 1;
            this.siticoneButton1.CheckedState.Parent = this.siticoneButton1;
            this.siticoneButton1.CustomImages.Parent = this.siticoneButton1;
            this.siticoneButton1.FillColor = System.Drawing.Color.Empty;
            this.siticoneButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneButton1.ForeColor = System.Drawing.Color.White;
            this.siticoneButton1.HoveredState.FillColor = System.Drawing.Color.Maroon;
            this.siticoneButton1.HoveredState.Parent = this.siticoneButton1;
            this.siticoneButton1.Image = ((System.Drawing.Image)(resources.GetObject("siticoneButton1.Image")));
            this.siticoneButton1.ImageOffset = new System.Drawing.Point(0, 50);
            this.siticoneButton1.ImageSize = new System.Drawing.Size(130, 200);
            this.siticoneButton1.Location = new System.Drawing.Point(3, 3);
            this.siticoneButton1.Name = "siticoneButton1";
            this.siticoneButton1.ShadowDecoration.Parent = this.siticoneButton1;
            this.siticoneButton1.Size = new System.Drawing.Size(135, 249);
            this.siticoneButton1.TabIndex = 0;
            this.siticoneButton1.Text = "Counter Strike: Global Offensive";
            this.siticoneButton1.TextOffset = new System.Drawing.Point(0, 30);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.siticoneButton1);
            this.flowLayoutPanel1.Controls.Add(this.siticoneButton2);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 40);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(884, 485);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // siticoneButton2
            // 
            this.siticoneButton2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.siticoneButton2.BorderRadius = 5;
            this.siticoneButton2.BorderThickness = 1;
            this.siticoneButton2.CheckedState.Parent = this.siticoneButton2;
            this.siticoneButton2.CustomImages.Parent = this.siticoneButton2;
            this.siticoneButton2.FillColor = System.Drawing.Color.Empty;
            this.siticoneButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneButton2.ForeColor = System.Drawing.Color.White;
            this.siticoneButton2.HoveredState.FillColor = System.Drawing.Color.Maroon;
            this.siticoneButton2.HoveredState.Parent = this.siticoneButton2;
            this.siticoneButton2.Image = ((System.Drawing.Image)(resources.GetObject("siticoneButton2.Image")));
            this.siticoneButton2.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.siticoneButton2.ImageOffset = new System.Drawing.Point(-7, -21);
            this.siticoneButton2.ImageSize = new System.Drawing.Size(130, 200);
            this.siticoneButton2.Location = new System.Drawing.Point(144, 3);
            this.siticoneButton2.Name = "siticoneButton2";
            this.siticoneButton2.ShadowDecoration.Parent = this.siticoneButton2;
            this.siticoneButton2.Size = new System.Drawing.Size(135, 249);
            this.siticoneButton2.TabIndex = 1;
            this.siticoneButton2.Text = "Team Fortress: 2";
            this.siticoneButton2.TextOffset = new System.Drawing.Point(0, 100);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(16, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "GAMES";
            // 
            // games
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Controls.Add(this.label2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "games";
            this.Size = new System.Drawing.Size(890, 525);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Siticone.UI.WinForms.SiticoneButton siticoneButton1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Siticone.UI.WinForms.SiticoneButton siticoneButton2;
        private System.Windows.Forms.Label label2;
    }
}
