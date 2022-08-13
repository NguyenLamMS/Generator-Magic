namespace Generator_Magic
{
    partial class Home
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
            this.components = new System.ComponentModel.Container();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.uiSmoothLabel1 = new Sunny.UI.UISmoothLabel();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.countData = new Sunny.UI.UIGroupBox();
            this.btnMixData = new Guna.UI2.WinForms.Guna2Button();
            this.btnRun = new Guna.UI2.WinForms.Guna2Button();
            this.txtData = new Sunny.UI.UIRichTextBox();
            this.countResult = new Sunny.UI.UIGroupBox();
            this.txtResult = new Sunny.UI.UIRichTextBox();
            this.countData.SuspendLayout();
            this.countResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 15;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.ControlBoxStyle = Guna.UI2.WinForms.Enums.ControlBoxStyle.Custom;
            this.guna2ControlBox1.FillColor = System.Drawing.SystemColors.Control;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox1.Location = new System.Drawing.Point(522, 3);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 0;
            // 
            // uiSmoothLabel1
            // 
            this.uiSmoothLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiSmoothLabel1.Location = new System.Drawing.Point(50, 3);
            this.uiSmoothLabel1.Name = "uiSmoothLabel1";
            this.uiSmoothLabel1.Size = new System.Drawing.Size(459, 102);
            this.uiSmoothLabel1.TabIndex = 1;
            this.uiSmoothLabel1.Text = "GENERATOR\r\n     MAGIC";
            this.uiSmoothLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiSmoothLabel1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.uiSmoothLabel1;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // countData
            // 
            this.countData.BackColor = System.Drawing.SystemColors.Control;
            this.countData.Controls.Add(this.btnMixData);
            this.countData.Controls.Add(this.btnRun);
            this.countData.Controls.Add(this.txtData);
            this.countData.FillColor = System.Drawing.SystemColors.Control;
            this.countData.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.countData.Location = new System.Drawing.Point(4, 112);
            this.countData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.countData.MinimumSize = new System.Drawing.Size(1, 1);
            this.countData.Name = "countData";
            this.countData.Padding = new System.Windows.Forms.Padding(10, 32, 10, 10);
            this.countData.Size = new System.Drawing.Size(565, 180);
            this.countData.Style = Sunny.UI.UIStyle.Custom;
            this.countData.TabIndex = 2;
            this.countData.Text = "Data (0)";
            this.countData.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.countData.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // btnMixData
            // 
            this.btnMixData.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMixData.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMixData.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMixData.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMixData.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnMixData.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMixData.ForeColor = System.Drawing.Color.White;
            this.btnMixData.Location = new System.Drawing.Point(362, 109);
            this.btnMixData.Name = "btnMixData";
            this.btnMixData.Size = new System.Drawing.Size(180, 45);
            this.btnMixData.TabIndex = 2;
            this.btnMixData.Text = "Mix Data";
            this.btnMixData.Click += new System.EventHandler(this.btnMixData_Click);
            // 
            // btnRun
            // 
            this.btnRun.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRun.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRun.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRun.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRun.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRun.ForeColor = System.Drawing.Color.White;
            this.btnRun.Location = new System.Drawing.Point(362, 47);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(180, 45);
            this.btnRun.TabIndex = 1;
            this.btnRun.Text = "Run";
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // txtData
            // 
            this.txtData.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtData.FillColor = System.Drawing.Color.White;
            this.txtData.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtData.Location = new System.Drawing.Point(10, 32);
            this.txtData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtData.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtData.Name = "txtData";
            this.txtData.Padding = new System.Windows.Forms.Padding(2);
            this.txtData.ShowText = false;
            this.txtData.Size = new System.Drawing.Size(326, 138);
            this.txtData.Style = Sunny.UI.UIStyle.Custom;
            this.txtData.TabIndex = 0;
            this.txtData.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtData.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.txtData.TextChanged += new System.EventHandler(this.txtData_TextChanged);
            // 
            // countResult
            // 
            this.countResult.Controls.Add(this.txtResult);
            this.countResult.FillColor = System.Drawing.SystemColors.Control;
            this.countResult.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.countResult.Location = new System.Drawing.Point(4, 302);
            this.countResult.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.countResult.MinimumSize = new System.Drawing.Size(1, 1);
            this.countResult.Name = "countResult";
            this.countResult.Padding = new System.Windows.Forms.Padding(10, 32, 10, 10);
            this.countResult.Size = new System.Drawing.Size(565, 470);
            this.countResult.Style = Sunny.UI.UIStyle.Custom;
            this.countResult.TabIndex = 3;
            this.countResult.Text = "Result";
            this.countResult.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.countResult.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // txtResult
            // 
            this.txtResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtResult.FillColor = System.Drawing.Color.White;
            this.txtResult.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtResult.Location = new System.Drawing.Point(10, 32);
            this.txtResult.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtResult.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtResult.Name = "txtResult";
            this.txtResult.Padding = new System.Windows.Forms.Padding(2);
            this.txtResult.ShowText = false;
            this.txtResult.Size = new System.Drawing.Size(545, 428);
            this.txtResult.Style = Sunny.UI.UIStyle.Custom;
            this.txtResult.TabIndex = 0;
            this.txtResult.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtResult.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.txtResult.TextChanged += new System.EventHandler(this.txtResult_TextChanged);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 777);
            this.Controls.Add(this.countResult);
            this.Controls.Add(this.countData);
            this.Controls.Add(this.uiSmoothLabel1);
            this.Controls.Add(this.guna2ControlBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.countData.ResumeLayout(false);
            this.countResult.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Sunny.UI.UISmoothLabel uiSmoothLabel1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Sunny.UI.UIGroupBox countData;
        private Sunny.UI.UIRichTextBox txtData;
        private Sunny.UI.UIGroupBox countResult;
        private Guna.UI2.WinForms.Guna2Button btnMixData;
        private Guna.UI2.WinForms.Guna2Button btnRun;
        private Sunny.UI.UIRichTextBox txtResult;
    }
}