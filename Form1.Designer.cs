namespace Multiformapp_chachulova
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            lblSkore = new Label();
            btnNovaHra = new Button();
            btnNastaveni = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            panelHra = new TableLayoutPanel();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // lblSkore
            // 
            lblSkore.AutoSize = true;
            lblSkore.BackColor = SystemColors.Control;
            lblSkore.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lblSkore.Location = new Point(21, 16);
            lblSkore.Name = "lblSkore";
            lblSkore.Size = new Size(65, 28);
            lblSkore.TabIndex = 0;
            lblSkore.Text = "label1";
            // 
            // btnNovaHra
            // 
            btnNovaHra.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNovaHra.BackColor = Color.Green;
            btnNovaHra.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            btnNovaHra.ForeColor = SystemColors.Window;
            btnNovaHra.Location = new Point(280, 7);
            btnNovaHra.Name = "btnNovaHra";
            btnNovaHra.Size = new Size(131, 48);
            btnNovaHra.TabIndex = 1;
            btnNovaHra.Text = "Nová hra";
            btnNovaHra.UseVisualStyleBackColor = false;
            btnNovaHra.Click += btnNovaHra_Click;
            // 
            // btnNastaveni
            // 
            btnNastaveni.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNastaveni.BackColor = SystemColors.ActiveCaption;
            btnNastaveni.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            btnNastaveni.Location = new Point(417, 7);
            btnNastaveni.Name = "btnNastaveni";
            btnNastaveni.Size = new Size(131, 48);
            btnNastaveni.TabIndex = 2;
            btnNastaveni.Text = "Nastavení";
            btnNastaveni.UseVisualStyleBackColor = false;
            btnNastaveni.Click += btnSettings_Click;
            // 
            // panelHra
            // 
            panelHra.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelHra.ColumnCount = 4;
            panelHra.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            panelHra.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            panelHra.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            panelHra.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            panelHra.Dock = DockStyle.Fill;
            panelHra.Location = new Point(0, 76);
            panelHra.Name = "panelHra";
            panelHra.RowCount = 4;
            panelHra.RowStyles.Add(new RowStyle(SizeType.Percent, 49.3917274F));
            panelHra.RowStyles.Add(new RowStyle(SizeType.Percent, 50.6082726F));
            panelHra.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            panelHra.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            panelHra.Size = new Size(561, 408);
            panelHra.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(561, 76);
            panel1.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(561, 484);
            Controls.Add(btnNastaveni);
            Controls.Add(btnNovaHra);
            Controls.Add(lblSkore);
            Controls.Add(panelHra);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSkore;
        private Button btnNovaHra;
        private Button btnNastaveni;
        private System.Windows.Forms.Timer timer1;
        private TableLayoutPanel panelHra;
        private Panel panel1;
    }
}
