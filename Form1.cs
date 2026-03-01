namespace Multiformapp_chachulova
{
    public partial class Form1 : Form
    {
        Game hra = new Game();
        Button[] karty = [];

        public Form1()
        {
            InitializeComponent(); 

            timer1.Interval = 900;
            timer1.Tick += Timer_Tick;

            hra.NovaHra(4, 4, "Zvirata");
            PostavHraciPlochu();
        }

        void PostavHraciPlochu()
        {            
            panelHra.Controls.Clear();
            panelHra.RowCount = hra.Radky;
            panelHra.ColumnCount = hra.Sloupce;
                        
            panelHra.ColumnStyles.Clear();
            panelHra.RowStyles.Clear();

            for (int i = 0; i < hra.Sloupce; i++)
            {
                panelHra.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f / hra.Sloupce));
            }

            for (int i = 0; i < hra.Radky; i++)
            {
                panelHra.RowStyles.Add(new RowStyle(SizeType.Percent, 100f / hra.Radky));
            }

            karty = new Button[hra.PocetKaret];

            
            for (int i = 0; i < hra.PocetKaret; i++)
            {
                Button btn = new Button
                {
                    Text = "?",
                    Tag = i,
                    Dock = DockStyle.Fill,
                    BackColor = Color.SteelBlue,
                    ForeColor = Color.White,
                    FlatStyle = FlatStyle.Flat,
                    Font = new Font("Segoe UI Emoji", 20f, FontStyle.Bold),
                    Margin = new Padding(3) 
                };

                btn.Click += Karta_Click;
                karty[i] = btn;
                panelHra.Controls.Add(btn);
            }
            lblSkore.Text = hra.GetSkore();
        }

        private void Karta_Click(object? sender, EventArgs e)
        {
            if (sender is not Button btn) return;

            int index = (int)btn.Tag!;
            string vysledek = hra.OtocKartu(index);

            if (vysledek == "preskoc") return;

            btn.Text = hra.GetSymbol(index);
            btn.BackColor = Color.White; btn.ForeColor = Color.Black;

            if (vysledek == "shoda")
            {
                AktualizujKarty();
                if (hra.KonecHry) MessageBox.Show("Výhra!");
            }
            else if (vysledek == "neshoda")
            {
                timer1.Start();
            }

            lblSkore.Text = hra.GetSkore();
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            timer1.Stop();

            var (a, b) = hra.SkryjNeshodu();

            karty[a].Text = karty[b].Text = "?";
            karty[a].BackColor = karty[b].BackColor = Color.SteelBlue;
            karty[a].ForeColor = karty[b].ForeColor = Color.White;

            AktualizujKarty();
        }

        void AktualizujKarty()
        {
            foreach (var k in karty)
            {
                k.Enabled = !hra.JeShodna((int)k.Tag!);
            }
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            using Settings s = new Settings(hra);

            if (s.ShowDialog(this) == DialogResult.OK)
            {
                PostavHraciPlochu();
            }
        }
        
        private void btnNovaHra_Click(object sender, EventArgs e) => PostavHraciPlochu();       
    }
}

