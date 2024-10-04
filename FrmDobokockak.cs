namespace WFA24100402
{
    public partial class FrmDobokockak : Form
    {
        private static Random rnd = new();

        public FrmDobokockak()
        {
            InitializeComponent();
            btnDobas.Click += BtnDobas_Click;
        }

        private void BtnDobas_Click(object? sender, EventArgs e)
        {
            rtbDobasok.Clear();
            for (int i = 0; i < nudSzam.Value; i++)
                rtbDobasok.Text += $"{rnd.Next(1, 7)} ";

            for (int i = 0; i < rtbDobasok.Text.Length; i++)
            {
                if (rtbDobasok.Text[i] == '1')
                {
                    rtbDobasok.SelectionStart = i;
                    rtbDobasok.SelectionLength = 1;
                    rtbDobasok.SelectionColor = Color.Red;
                }
                if (rtbDobasok.Text[i] == '6')
                {
                    rtbDobasok.SelectionStart = i;
                    rtbDobasok.SelectionLength = 1;
                    rtbDobasok.SelectionColor = Color.Green;
                }
            }
        }
    }
}
