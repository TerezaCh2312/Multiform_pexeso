namespace Multiformapp_chachulova
{
    partial class Settings
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
            label1 = new Label();
            rb4x4 = new RadioButton();
            rb4x6 = new RadioButton();
            rb6x6 = new RadioButton();
            label2 = new Label();
            cmbSady = new ComboBox();
            label3 = new Label();
            btnOK = new Button();
            btnCancel = new Button();
            lblNahled = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(12, 24);
            label1.Name = "label1";
            label1.Size = new Size(191, 28);
            label1.TabIndex = 0;
            label1.Text = "Velikost hrací plochy";
            // 
            // rb4x4
            // 
            rb4x4.AutoSize = true;
            rb4x4.ForeColor = SystemColors.ControlLightLight;
            rb4x4.Location = new Point(47, 55);
            rb4x4.Name = "rb4x4";
            rb4x4.Size = new Size(117, 24);
            rb4x4.TabIndex = 1;
            rb4x4.TabStop = true;
            rb4x4.Text = "4 x 4 (8 párů)";
            rb4x4.UseVisualStyleBackColor = true;
            // 
            // rb4x6
            // 
            rb4x6.AutoSize = true;
            rb4x6.ForeColor = SystemColors.ControlLightLight;
            rb4x6.Location = new Point(47, 85);
            rb4x6.Name = "rb4x6";
            rb4x6.Size = new Size(125, 24);
            rb4x6.TabIndex = 2;
            rb4x6.TabStop = true;
            rb4x6.Text = "4 x 6 (12 párů)";
            rb4x6.UseVisualStyleBackColor = true;
            // 
            // rb6x6
            // 
            rb6x6.AutoSize = true;
            rb6x6.ForeColor = SystemColors.ControlLightLight;
            rb6x6.Location = new Point(47, 115);
            rb6x6.Name = "rb6x6";
            rb6x6.Size = new Size(125, 24);
            rb6x6.TabIndex = 3;
            rb6x6.TabStop = true;
            rb6x6.Text = "6 x 6 (18 párů)";
            rb6x6.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(12, 159);
            label2.Name = "label2";
            label2.Size = new Size(135, 28);
            label2.TabIndex = 4;
            label2.Text = "Sada symbolů";
            // 
            // cmbSady
            // 
            cmbSady.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSady.FormattingEnabled = true;
            cmbSady.Location = new Point(47, 190);
            cmbSady.Name = "cmbSady";
            cmbSady.Size = new Size(151, 28);
            cmbSady.TabIndex = 5;
            cmbSady.SelectedIndexChanged += cmbSady_Changed;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 232);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 6;
            // 
            // btnOK
            // 
            btnOK.BackColor = Color.Green;
            btnOK.Location = new Point(18, 330);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(144, 43);
            btnOK.TabIndex = 7;
            btnOK.Text = "Spustit novou hru";
            btnOK.UseVisualStyleBackColor = false;
            btnOK.Click += btnOK_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.SlateGray;
            btnCancel.Location = new Point(179, 330);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 43);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "Zrušit";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // lblNahled
            // 
            lblNahled.AutoSize = true;
            lblNahled.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lblNahled.Location = new Point(18, 232);
            lblNahled.Name = "lblNahled";
            lblNahled.Size = new Size(0, 30);
            lblNahled.TabIndex = 9;
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(315, 394);
            Controls.Add(lblNahled);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            Controls.Add(label3);
            Controls.Add(cmbSady);
            Controls.Add(label2);
            Controls.Add(rb6x6);
            Controls.Add(rb4x6);
            Controls.Add(rb4x4);
            Controls.Add(label1);
            ForeColor = SystemColors.Control;
            Name = "Settings";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Settings";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RadioButton rb4x4;
        private RadioButton rb4x6;
        private RadioButton rb6x6;
        private Label label2;
        private ComboBox cmbSady;
        private Label label3;
        private Button btnOK;
        private Button btnCancel;
        private Label lblNahled;
    }
}