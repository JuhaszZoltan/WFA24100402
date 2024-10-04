namespace WFA24100402
{
    partial class FrmDobokockak
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
            nudSzam = new NumericUpDown();
            lblUI01 = new Label();
            rtbDobasok = new RichTextBox();
            btnDobas = new Button();
            ((System.ComponentModel.ISupportInitialize)nudSzam).BeginInit();
            SuspendLayout();
            // 
            // nudSzam
            // 
            nudSzam.Location = new Point(383, 26);
            nudSzam.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudSzam.Name = "nudSzam";
            nudSzam.Size = new Size(93, 43);
            nudSzam.TabIndex = 0;
            nudSzam.TextAlign = HorizontalAlignment.Right;
            nudSzam.Value = new decimal(new int[] { 64, 0, 0, 0 });
            // 
            // lblUI01
            // 
            lblUI01.AutoSize = true;
            lblUI01.Location = new Point(12, 28);
            lblUI01.Name = "lblUI01";
            lblUI01.Size = new Size(315, 37);
            lblUI01.TabIndex = 1;
            lblUI01.Text = "hány kockadobást kérsz?:";
            // 
            // rtbDobasok
            // 
            rtbDobasok.Font = new Font("Consolas", 20F, FontStyle.Bold);
            rtbDobasok.Location = new Point(12, 75);
            rtbDobasok.Name = "rtbDobasok";
            rtbDobasok.ScrollBars = RichTextBoxScrollBars.ForcedVertical;
            rtbDobasok.Size = new Size(464, 281);
            rtbDobasok.TabIndex = 2;
            rtbDobasok.Text = "";
            // 
            // btnDobas
            // 
            btnDobas.Location = new Point(12, 362);
            btnDobas.Name = "btnDobas";
            btnDobas.Size = new Size(464, 59);
            btnDobas.TabIndex = 3;
            btnDobas.Text = "Dobás!";
            btnDobas.UseVisualStyleBackColor = true;
            // 
            // FrmDobokockak
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(488, 433);
            Controls.Add(btnDobas);
            Controls.Add(rtbDobasok);
            Controls.Add(lblUI01);
            Controls.Add(nudSzam);
            Font = new Font("Segoe UI", 20F);
            Margin = new Padding(6, 7, 6, 7);
            Name = "FrmDobokockak";
            Text = "Kockadobások";
            ((System.ComponentModel.ISupportInitialize)nudSzam).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown nudSzam;
        private Label lblUI01;
        private RichTextBox rtbDobasok;
        private Button btnDobas;
    }
}
