namespace winform_evez
{
    public partial class Form1 : Form
    {
        bool tamdir = true;

        public Form1()
        {
            InitializeComponent();
            progressBar1.Visible = false;
        }

        private void Melumat_TextChanged(object sender, EventArgs e)
        {
            lblSeriyaK.Text = txtSeriya.Text;
            lblFinK.Text = txtFin.Text;
            lblSoyadK.Text = txtSoyad.Text;
            lblAdK.Text = txtAd.Text;
            lblAtaAdiK.Text = txtAtaAdi.Text;
            lblCinsK.Text = txtCins.Text;
            lblDogumTarixiK.Text = txtDogumTarixi.Text;
            lblDogumYeriK.Text = txtDogumYeri.Text;
            lblAileK.Text = txtAileVeziyyeti.Text;
            lblVerilmeK.Text = txtVerilmeTarixi.Text;
            lblEtibarliK.Text = txtEtibarlidir.Text;
            lblOrqanK.Text = txtVerenOrqan.Text;
        }

        private void btnSekilYukle_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Şəkil seçin";
            ofd.Filter = "PNG şəkillər (*.png)|*.png";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                if (Path.GetExtension(ofd.FileName).ToLower() == ".png")
                {
                    picFoto.ImageLocation = ofd.FileName;
                    picFoto.Visible = true;
                }
                else
                {
                    MessageBox.Show("Yalnız PNG faylları dəstəklənir",
                        "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtSeriya.Clear();
            txtFin.Clear();
            txtSoyad.Clear();
            txtAd.Clear();
            txtAtaAdi.Clear();
            txtCins.Clear();
            txtDogumTarixi.Clear();
            txtDogumYeri.Clear();
            txtAileVeziyyeti.Clear();
            txtVerilmeTarixi.Clear();
            txtEtibarlidir.Clear();
            txtVerenOrqan.Clear();

            picFoto.ImageLocation = null;
            picFoto.Visible = false;
        }

        private void btnYaddaSaxla_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSeriya.Text) ||
                string.IsNullOrWhiteSpace(txtFin.Text) ||
                string.IsNullOrWhiteSpace(txtSoyad.Text) ||
                string.IsNullOrWhiteSpace(txtAd.Text) ||
                string.IsNullOrWhiteSpace(txtAtaAdi.Text) ||
                string.IsNullOrWhiteSpace(txtCins.Text) ||
                string.IsNullOrWhiteSpace(txtDogumTarixi.Text) ||
                string.IsNullOrWhiteSpace(txtDogumYeri.Text) ||
                string.IsNullOrWhiteSpace(txtAileVeziyyeti.Text) ||
                string.IsNullOrWhiteSpace(txtVerilmeTarixi.Text) ||
                string.IsNullOrWhiteSpace(txtEtibarlidir.Text) ||
                string.IsNullOrWhiteSpace(txtVerenOrqan.Text))
            {
                tamdir = false;
            }
            else
            {
                tamdir = true;
            }

            progressBar1.Value = 0;
            progressBar1.Visible = true;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value += 10;
            if (progressBar1.Value >= 100)
            {
                timer1.Stop();

                DialogResult d;
                if (tamdir == true)
                {
                    d = MessageBox.Show("Yadda saxlandı",
                        "Uğurlu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    d = MessageBox.Show("Məlumatlar tam daxil edilməyib",
                        "Məlumat", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }

                if (d == DialogResult.OK)
                {
                    progressBar1.Visible = false;
                }
            }
        }
    }
}