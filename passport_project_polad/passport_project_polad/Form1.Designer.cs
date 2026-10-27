namespace winform_evez
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
            grpVesiqe = new GroupBox();
            pnlCerceve = new Panel();
            pnlKart = new Panel();
            pnlKartIc = new Panel();
            picFoto = new PictureBox();
            lblFoto = new Label();
            lblKartBasliq = new Label();
            lblKartAlt = new Label();
            lblKartSoyad = new Label();
            lblSoyadK = new Label();
            xettSoyad = new Label();
            lblKartAd = new Label();
            lblAdK = new Label();
            xettAd = new Label();
            lblKartAtaAdi = new Label();
            lblAtaAdiK = new Label();
            xettAtaAdi = new Label();
            lblKartDogumTarixi = new Label();
            lblDogumTarixiK = new Label();
            xettDogumTarixi = new Label();
            lblKartDogumYeri = new Label();
            lblDogumYeriK = new Label();
            xettDogumYeri = new Label();
            lblKartCins = new Label();
            lblCinsK = new Label();
            xettCins = new Label();
            lblKartSeriya = new Label();
            lblSeriyaK = new Label();
            xettSeriya = new Label();
            lblKartFin = new Label();
            lblFinK = new Label();
            xettFin = new Label();
            lblKartAile = new Label();
            lblAileK = new Label();
            xettAile = new Label();
            lblKartVerilme = new Label();
            lblVerilmeK = new Label();
            xettVerilme = new Label();
            lblKartEtibarli = new Label();
            lblEtibarliK = new Label();
            xettEtibarli = new Label();
            lblKartOrqan = new Label();
            lblOrqanK = new Label();
            xettOrqan = new Label();
            btnSekilYukle = new Button();
            grpMelumat = new GroupBox();
            lblSeriya = new Label();
            txtSeriya = new TextBox();
            lblFin = new Label();
            txtFin = new TextBox();
            lblSoyad = new Label();
            txtSoyad = new TextBox();
            lblAd = new Label();
            txtAd = new TextBox();
            lblAtaAdi = new Label();
            txtAtaAdi = new TextBox();
            lblCins = new Label();
            txtCins = new TextBox();
            lblDogumTarixi = new Label();
            txtDogumTarixi = new TextBox();
            lblDogumYeri = new Label();
            txtDogumYeri = new TextBox();
            lblAileVeziyyeti = new Label();
            txtAileVeziyyeti = new TextBox();
            lblVerilmeTarixi = new Label();
            txtVerilmeTarixi = new TextBox();
            lblEtibarlidir = new Label();
            txtEtibarlidir = new TextBox();
            lblVerenOrqan = new Label();
            txtVerenOrqan = new TextBox();
            btnTemizle = new Button();
            btnYaddaSaxla = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            progressBar1 = new ProgressBar();
            grpVesiqe.SuspendLayout();
            pnlCerceve.SuspendLayout();
            pnlKart.SuspendLayout();
            pnlKartIc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picFoto).BeginInit();
            grpMelumat.SuspendLayout();
            SuspendLayout();
            // 
            // grpVesiqe
            // 
            grpVesiqe.Controls.Add(pnlCerceve);
            grpVesiqe.Controls.Add(btnSekilYukle);
            grpVesiqe.Location = new Point(19, 19);
            grpVesiqe.Name = "grpVesiqe";
            grpVesiqe.Size = new Size(558, 543);
            grpVesiqe.TabIndex = 0;
            grpVesiqe.TabStop = false;
            grpVesiqe.Text = "Şəxsiyyət vəsiqəsi";
            // 
            // pnlCerceve  (boz çərçivə)
            // 
            pnlCerceve.BackColor = Color.FromArgb(245, 245, 245);
            pnlCerceve.BorderStyle = BorderStyle.FixedSingle;
            pnlCerceve.Controls.Add(pnlKart);
            pnlCerceve.Location = new Point(11, 32);
            pnlCerceve.Name = "pnlCerceve";
            pnlCerceve.Size = new Size(535, 450);
            pnlCerceve.TabIndex = 0;
            // 
            // pnlKart  (kartın mavi haşiyəsi)
            // 
            pnlKart.BackColor = Color.FromArgb(70, 120, 200);
            pnlKart.Controls.Add(pnlKartIc);
            pnlKart.Location = new Point(8, 56);
            pnlKart.Name = "pnlKart";
            pnlKart.Padding = new Padding(2);
            pnlKart.Size = new Size(517, 336);
            pnlKart.TabIndex = 0;
            // 
            // pnlKartIc  (kartın içi)
            // 
            pnlKartIc.BackColor = Color.FromArgb(222, 233, 247);
            pnlKartIc.Controls.Add(picFoto);
            pnlKartIc.Controls.Add(lblFoto);
            pnlKartIc.Controls.Add(lblKartBasliq);
            pnlKartIc.Controls.Add(lblKartAlt);
            pnlKartIc.Controls.Add(lblKartSoyad);
            pnlKartIc.Controls.Add(lblSoyadK);
            pnlKartIc.Controls.Add(xettSoyad);
            pnlKartIc.Controls.Add(lblKartAd);
            pnlKartIc.Controls.Add(lblAdK);
            pnlKartIc.Controls.Add(xettAd);
            pnlKartIc.Controls.Add(lblKartAtaAdi);
            pnlKartIc.Controls.Add(lblAtaAdiK);
            pnlKartIc.Controls.Add(xettAtaAdi);
            pnlKartIc.Controls.Add(lblKartDogumTarixi);
            pnlKartIc.Controls.Add(lblDogumTarixiK);
            pnlKartIc.Controls.Add(xettDogumTarixi);
            pnlKartIc.Controls.Add(lblKartDogumYeri);
            pnlKartIc.Controls.Add(lblDogumYeriK);
            pnlKartIc.Controls.Add(xettDogumYeri);
            pnlKartIc.Controls.Add(lblKartCins);
            pnlKartIc.Controls.Add(lblCinsK);
            pnlKartIc.Controls.Add(xettCins);
            pnlKartIc.Controls.Add(lblKartSeriya);
            pnlKartIc.Controls.Add(lblSeriyaK);
            pnlKartIc.Controls.Add(xettSeriya);
            pnlKartIc.Controls.Add(lblKartFin);
            pnlKartIc.Controls.Add(lblFinK);
            pnlKartIc.Controls.Add(xettFin);
            pnlKartIc.Controls.Add(lblKartAile);
            pnlKartIc.Controls.Add(lblAileK);
            pnlKartIc.Controls.Add(xettAile);
            pnlKartIc.Controls.Add(lblKartVerilme);
            pnlKartIc.Controls.Add(lblVerilmeK);
            pnlKartIc.Controls.Add(xettVerilme);
            pnlKartIc.Controls.Add(lblKartEtibarli);
            pnlKartIc.Controls.Add(lblEtibarliK);
            pnlKartIc.Controls.Add(xettEtibarli);
            pnlKartIc.Controls.Add(lblKartOrqan);
            pnlKartIc.Controls.Add(lblOrqanK);
            pnlKartIc.Controls.Add(xettOrqan);
            pnlKartIc.Dock = DockStyle.Fill;
            pnlKartIc.Location = new Point(2, 2);
            pnlKartIc.Name = "pnlKartIc";
            pnlKartIc.Size = new Size(513, 332);
            pnlKartIc.TabIndex = 0;
            // 
            // picFoto  (yüklənən şəkil)
            // 
            picFoto.BackColor = Color.FromArgb(186, 202, 225);
            picFoto.BorderStyle = BorderStyle.FixedSingle;
            picFoto.Location = new Point(18, 72);
            picFoto.Name = "picFoto";
            picFoto.Size = new Size(112, 142);
            picFoto.SizeMode = PictureBoxSizeMode.Zoom;
            picFoto.TabIndex = 0;
            picFoto.TabStop = false;
            picFoto.Visible = false;
            // 
            // lblFoto  (şəkil yoxdursa "FOTO" yazısı)
            // 
            lblFoto.BackColor = Color.FromArgb(186, 202, 225);
            lblFoto.BorderStyle = BorderStyle.FixedSingle;
            lblFoto.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblFoto.ForeColor = Color.FromArgb(31, 58, 112);
            lblFoto.Location = new Point(18, 72);
            lblFoto.Name = "lblFoto";
            lblFoto.Size = new Size(112, 142);
            lblFoto.Text = "FOTO";
            lblFoto.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblKartBasliq
            // 
            lblKartBasliq.AutoSize = true;
            lblKartBasliq.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblKartBasliq.ForeColor = Color.FromArgb(31, 58, 112);
            lblKartBasliq.Location = new Point(16, 12);
            lblKartBasliq.Name = "lblKartBasliq";
            lblKartBasliq.Text = "AZƏRBAYCAN RESPUBLİKASI";
            // 
            // lblKartAlt
            // 
            lblKartAlt.AutoSize = true;
            lblKartAlt.Font = new Font("Segoe UI", 7.5F);
            lblKartAlt.ForeColor = Color.FromArgb(31, 58, 112);
            lblKartAlt.Location = new Point(16, 40);
            lblKartAlt.Name = "lblKartAlt";
            lblKartAlt.Text = "Şəxsiyyət vəsiqəsi";
            // 
            // lblKartSoyad
            // 
            lblKartSoyad.AutoSize = true;
            lblKartSoyad.Font = new Font("Segoe UI", 7F);
            lblKartSoyad.ForeColor = Color.FromArgb(95, 110, 140);
            lblKartSoyad.Location = new Point(146, 72);
            lblKartSoyad.Name = "lblKartSoyad";
            lblKartSoyad.Text = "Soyad:";
            // 
            // lblSoyadK
            // 
            lblSoyadK.AutoEllipsis = true;
            lblSoyadK.Font = new Font("Segoe UI", 7F, FontStyle.Bold);
            lblSoyadK.ForeColor = Color.FromArgb(31, 58, 112);
            lblSoyadK.Location = new Point(236, 70);
            lblSoyadK.Name = "lblSoyadK";
            lblSoyadK.Size = new Size(110, 20);
            // 
            // xettSoyad
            // 
            xettSoyad.BackColor = Color.FromArgb(120, 150, 205);
            xettSoyad.Location = new Point(236, 91);
            xettSoyad.Name = "xettSoyad";
            xettSoyad.Size = new Size(110, 2);
            // 
            // lblKartAd
            // 
            lblKartAd.AutoSize = true;
            lblKartAd.Font = new Font("Segoe UI", 7F);
            lblKartAd.ForeColor = Color.FromArgb(95, 110, 140);
            lblKartAd.Location = new Point(146, 98);
            lblKartAd.Name = "lblKartAd";
            lblKartAd.Text = "Ad:";
            // 
            // lblAdK
            // 
            lblAdK.AutoEllipsis = true;
            lblAdK.Font = new Font("Segoe UI", 7F, FontStyle.Bold);
            lblAdK.ForeColor = Color.FromArgb(31, 58, 112);
            lblAdK.Location = new Point(236, 96);
            lblAdK.Name = "lblAdK";
            lblAdK.Size = new Size(110, 20);
            // 
            // xettAd
            // 
            xettAd.BackColor = Color.FromArgb(120, 150, 205);
            xettAd.Location = new Point(236, 117);
            xettAd.Name = "xettAd";
            xettAd.Size = new Size(110, 2);
            // 
            // lblKartAtaAdi
            // 
            lblKartAtaAdi.AutoSize = true;
            lblKartAtaAdi.Font = new Font("Segoe UI", 7F);
            lblKartAtaAdi.ForeColor = Color.FromArgb(95, 110, 140);
            lblKartAtaAdi.Location = new Point(146, 124);
            lblKartAtaAdi.Name = "lblKartAtaAdi";
            lblKartAtaAdi.Text = "Ata adı:";
            // 
            // lblAtaAdiK
            // 
            lblAtaAdiK.AutoEllipsis = true;
            lblAtaAdiK.Font = new Font("Segoe UI", 7F, FontStyle.Bold);
            lblAtaAdiK.ForeColor = Color.FromArgb(31, 58, 112);
            lblAtaAdiK.Location = new Point(236, 122);
            lblAtaAdiK.Name = "lblAtaAdiK";
            lblAtaAdiK.Size = new Size(110, 20);
            // 
            // xettAtaAdi
            // 
            xettAtaAdi.BackColor = Color.FromArgb(120, 150, 205);
            xettAtaAdi.Location = new Point(236, 143);
            xettAtaAdi.Name = "xettAtaAdi";
            xettAtaAdi.Size = new Size(110, 2);
            // 
            // lblKartDogumTarixi
            // 
            lblKartDogumTarixi.AutoSize = true;
            lblKartDogumTarixi.Font = new Font("Segoe UI", 7F);
            lblKartDogumTarixi.ForeColor = Color.FromArgb(95, 110, 140);
            lblKartDogumTarixi.Location = new Point(146, 150);
            lblKartDogumTarixi.Name = "lblKartDogumTarixi";
            lblKartDogumTarixi.Text = "Doğum tarixi:";
            // 
            // lblDogumTarixiK
            // 
            lblDogumTarixiK.AutoEllipsis = true;
            lblDogumTarixiK.Font = new Font("Segoe UI", 7F, FontStyle.Bold);
            lblDogumTarixiK.ForeColor = Color.FromArgb(31, 58, 112);
            lblDogumTarixiK.Location = new Point(236, 148);
            lblDogumTarixiK.Name = "lblDogumTarixiK";
            lblDogumTarixiK.Size = new Size(110, 20);
            // 
            // xettDogumTarixi
            // 
            xettDogumTarixi.BackColor = Color.FromArgb(120, 150, 205);
            xettDogumTarixi.Location = new Point(236, 169);
            xettDogumTarixi.Name = "xettDogumTarixi";
            xettDogumTarixi.Size = new Size(110, 2);
            // 
            // lblKartDogumYeri
            // 
            lblKartDogumYeri.AutoSize = true;
            lblKartDogumYeri.Font = new Font("Segoe UI", 7F);
            lblKartDogumYeri.ForeColor = Color.FromArgb(95, 110, 140);
            lblKartDogumYeri.Location = new Point(146, 176);
            lblKartDogumYeri.Name = "lblKartDogumYeri";
            lblKartDogumYeri.Text = "Doğum yeri:";
            // 
            // lblDogumYeriK
            // 
            lblDogumYeriK.AutoEllipsis = true;
            lblDogumYeriK.Font = new Font("Segoe UI", 7F, FontStyle.Bold);
            lblDogumYeriK.ForeColor = Color.FromArgb(31, 58, 112);
            lblDogumYeriK.Location = new Point(236, 174);
            lblDogumYeriK.Name = "lblDogumYeriK";
            lblDogumYeriK.Size = new Size(110, 20);
            // 
            // xettDogumYeri
            // 
            xettDogumYeri.BackColor = Color.FromArgb(120, 150, 205);
            xettDogumYeri.Location = new Point(236, 195);
            xettDogumYeri.Name = "xettDogumYeri";
            xettDogumYeri.Size = new Size(110, 2);
            // 
            // lblKartCins
            // 
            lblKartCins.AutoSize = true;
            lblKartCins.Font = new Font("Segoe UI", 7F);
            lblKartCins.ForeColor = Color.FromArgb(95, 110, 140);
            lblKartCins.Location = new Point(146, 202);
            lblKartCins.Name = "lblKartCins";
            lblKartCins.Text = "Cins:";
            // 
            // lblCinsK
            // 
            lblCinsK.AutoEllipsis = true;
            lblCinsK.Font = new Font("Segoe UI", 7F, FontStyle.Bold);
            lblCinsK.ForeColor = Color.FromArgb(31, 58, 112);
            lblCinsK.Location = new Point(236, 200);
            lblCinsK.Name = "lblCinsK";
            lblCinsK.Size = new Size(110, 20);
            // 
            // xettCins
            // 
            xettCins.BackColor = Color.FromArgb(120, 150, 205);
            xettCins.Location = new Point(236, 221);
            xettCins.Name = "xettCins";
            xettCins.Size = new Size(110, 2);
            // 
            // lblKartSeriya
            // 
            lblKartSeriya.AutoSize = true;
            lblKartSeriya.Font = new Font("Segoe UI", 7F);
            lblKartSeriya.ForeColor = Color.FromArgb(95, 110, 140);
            lblKartSeriya.Location = new Point(360, 72);
            lblKartSeriya.Name = "lblKartSeriya";
            lblKartSeriya.Text = "Seriya:";
            // 
            // lblSeriyaK
            // 
            lblSeriyaK.AutoEllipsis = true;
            lblSeriyaK.Font = new Font("Segoe UI", 7F, FontStyle.Bold);
            lblSeriyaK.ForeColor = Color.FromArgb(31, 58, 112);
            lblSeriyaK.Location = new Point(430, 70);
            lblSeriyaK.Name = "lblSeriyaK";
            lblSeriyaK.Size = new Size(78, 20);
            // 
            // xettSeriya
            // 
            xettSeriya.BackColor = Color.FromArgb(120, 150, 205);
            xettSeriya.Location = new Point(430, 91);
            xettSeriya.Name = "xettSeriya";
            xettSeriya.Size = new Size(78, 2);
            // 
            // lblKartFin
            // 
            lblKartFin.AutoSize = true;
            lblKartFin.Font = new Font("Segoe UI", 7F);
            lblKartFin.ForeColor = Color.FromArgb(95, 110, 140);
            lblKartFin.Location = new Point(360, 98);
            lblKartFin.Name = "lblKartFin";
            lblKartFin.Text = "FİN:";
            // 
            // lblFinK
            // 
            lblFinK.AutoEllipsis = true;
            lblFinK.Font = new Font("Segoe UI", 7F, FontStyle.Bold);
            lblFinK.ForeColor = Color.FromArgb(31, 58, 112);
            lblFinK.Location = new Point(430, 96);
            lblFinK.Name = "lblFinK";
            lblFinK.Size = new Size(78, 20);
            // 
            // xettFin
            // 
            xettFin.BackColor = Color.FromArgb(120, 150, 205);
            xettFin.Location = new Point(430, 117);
            xettFin.Name = "xettFin";
            xettFin.Size = new Size(78, 2);
            // 
            // lblKartAile
            // 
            lblKartAile.AutoSize = true;
            lblKartAile.Font = new Font("Segoe UI", 7F);
            lblKartAile.ForeColor = Color.FromArgb(95, 110, 140);
            lblKartAile.Location = new Point(360, 124);
            lblKartAile.Name = "lblKartAile";
            lblKartAile.Text = "Ailə vəz.:";
            // 
            // lblAileK
            // 
            lblAileK.AutoEllipsis = true;
            lblAileK.Font = new Font("Segoe UI", 7F, FontStyle.Bold);
            lblAileK.ForeColor = Color.FromArgb(31, 58, 112);
            lblAileK.Location = new Point(430, 122);
            lblAileK.Name = "lblAileK";
            lblAileK.Size = new Size(78, 20);
            // 
            // xettAile
            // 
            xettAile.BackColor = Color.FromArgb(120, 150, 205);
            xettAile.Location = new Point(430, 143);
            xettAile.Name = "xettAile";
            xettAile.Size = new Size(78, 2);
            // 
            // lblKartVerilme
            // 
            lblKartVerilme.AutoSize = true;
            lblKartVerilme.Font = new Font("Segoe UI", 7F);
            lblKartVerilme.ForeColor = Color.FromArgb(95, 110, 140);
            lblKartVerilme.Location = new Point(360, 150);
            lblKartVerilme.Name = "lblKartVerilme";
            lblKartVerilme.Text = "Verilmə:";
            // 
            // lblVerilmeK
            // 
            lblVerilmeK.AutoEllipsis = true;
            lblVerilmeK.Font = new Font("Segoe UI", 7F, FontStyle.Bold);
            lblVerilmeK.ForeColor = Color.FromArgb(31, 58, 112);
            lblVerilmeK.Location = new Point(430, 148);
            lblVerilmeK.Name = "lblVerilmeK";
            lblVerilmeK.Size = new Size(78, 20);
            // 
            // xettVerilme
            // 
            xettVerilme.BackColor = Color.FromArgb(120, 150, 205);
            xettVerilme.Location = new Point(430, 169);
            xettVerilme.Name = "xettVerilme";
            xettVerilme.Size = new Size(78, 2);
            // 
            // lblKartEtibarli
            // 
            lblKartEtibarli.AutoSize = true;
            lblKartEtibarli.Font = new Font("Segoe UI", 7F);
            lblKartEtibarli.ForeColor = Color.FromArgb(95, 110, 140);
            lblKartEtibarli.Location = new Point(360, 176);
            lblKartEtibarli.Name = "lblKartEtibarli";
            lblKartEtibarli.Text = "Etibarlıdır:";
            // 
            // lblEtibarliK
            // 
            lblEtibarliK.AutoEllipsis = true;
            lblEtibarliK.Font = new Font("Segoe UI", 7F, FontStyle.Bold);
            lblEtibarliK.ForeColor = Color.FromArgb(31, 58, 112);
            lblEtibarliK.Location = new Point(430, 174);
            lblEtibarliK.Name = "lblEtibarliK";
            lblEtibarliK.Size = new Size(78, 20);
            // 
            // xettEtibarli
            // 
            xettEtibarli.BackColor = Color.FromArgb(120, 150, 205);
            xettEtibarli.Location = new Point(430, 195);
            xettEtibarli.Name = "xettEtibarli";
            xettEtibarli.Size = new Size(78, 2);
            // 
            // lblKartOrqan
            // 
            lblKartOrqan.AutoSize = true;
            lblKartOrqan.Font = new Font("Segoe UI", 7F);
            lblKartOrqan.ForeColor = Color.FromArgb(95, 110, 140);
            lblKartOrqan.Location = new Point(18, 240);
            lblKartOrqan.Name = "lblKartOrqan";
            lblKartOrqan.Text = "Verən orqan:";
            // 
            // lblOrqanK
            // 
            lblOrqanK.AutoEllipsis = true;
            lblOrqanK.Font = new Font("Segoe UI", 7F, FontStyle.Bold);
            lblOrqanK.ForeColor = Color.FromArgb(31, 58, 112);
            lblOrqanK.Location = new Point(110, 238);
            lblOrqanK.Name = "lblOrqanK";
            lblOrqanK.Size = new Size(236, 20);
            // 
            // xettOrqan
            // 
            xettOrqan.BackColor = Color.FromArgb(120, 150, 205);
            xettOrqan.Location = new Point(110, 259);
            xettOrqan.Name = "xettOrqan";
            xettOrqan.Size = new Size(236, 2);
            // 
            // btnSekilYukle
            // 
            btnSekilYukle.Location = new Point(11, 496);
            btnSekilYukle.Name = "btnSekilYukle";
            btnSekilYukle.Size = new Size(535, 35);
            btnSekilYukle.TabIndex = 1;
            btnSekilYukle.Text = "Şəkil yüklə...";
            btnSekilYukle.UseVisualStyleBackColor = true;
            btnSekilYukle.Click += btnSekilYukle_Click;
            // 
            // grpMelumat
            // 
            grpMelumat.Controls.Add(lblSeriya);
            grpMelumat.Controls.Add(txtSeriya);
            grpMelumat.Controls.Add(lblFin);
            grpMelumat.Controls.Add(txtFin);
            grpMelumat.Controls.Add(lblSoyad);
            grpMelumat.Controls.Add(txtSoyad);
            grpMelumat.Controls.Add(lblAd);
            grpMelumat.Controls.Add(txtAd);
            grpMelumat.Controls.Add(lblAtaAdi);
            grpMelumat.Controls.Add(txtAtaAdi);
            grpMelumat.Controls.Add(lblCins);
            grpMelumat.Controls.Add(txtCins);
            grpMelumat.Controls.Add(lblDogumTarixi);
            grpMelumat.Controls.Add(txtDogumTarixi);
            grpMelumat.Controls.Add(lblDogumYeri);
            grpMelumat.Controls.Add(txtDogumYeri);
            grpMelumat.Controls.Add(lblAileVeziyyeti);
            grpMelumat.Controls.Add(txtAileVeziyyeti);
            grpMelumat.Controls.Add(lblVerilmeTarixi);
            grpMelumat.Controls.Add(txtVerilmeTarixi);
            grpMelumat.Controls.Add(lblEtibarlidir);
            grpMelumat.Controls.Add(txtEtibarlidir);
            grpMelumat.Controls.Add(lblVerenOrqan);
            grpMelumat.Controls.Add(txtVerenOrqan);
            grpMelumat.Location = new Point(597, 19);
            grpMelumat.Name = "grpMelumat";
            grpMelumat.Size = new Size(588, 543);
            grpMelumat.TabIndex = 1;
            grpMelumat.TabStop = false;
            grpMelumat.Text = "Vəsiqə məlumatları";
            // 
            // lblSeriya
            // 
            lblSeriya.AutoSize = true;
            lblSeriya.Location = new Point(22, 36);
            lblSeriya.Name = "lblSeriya";
            lblSeriya.Size = new Size(156, 28);
            lblSeriya.TabIndex = 0;
            lblSeriya.Text = "Seriya və nömrə:";
            // 
            // txtSeriya
            // 
            txtSeriya.Location = new Point(234, 33);
            txtSeriya.Name = "txtSeriya";
            txtSeriya.Size = new Size(332, 34);
            txtSeriya.TabIndex = 0;
            txtSeriya.TextChanged += Melumat_TextChanged;
            // 
            // lblFin
            // 
            lblFin.AutoSize = true;
            lblFin.Location = new Point(22, 78);
            lblFin.Name = "lblFin";
            lblFin.Size = new Size(85, 28);
            lblFin.TabIndex = 1;
            lblFin.Text = "FİN kod:";
            // 
            // txtFin
            // 
            txtFin.CharacterCasing = CharacterCasing.Upper;
            txtFin.Location = new Point(234, 75);
            txtFin.MaxLength = 7;
            txtFin.Name = "txtFin";
            txtFin.Size = new Size(332, 34);
            txtFin.TabIndex = 1;
            txtFin.TextChanged += Melumat_TextChanged;
            // 
            // lblSoyad
            // 
            lblSoyad.AutoSize = true;
            lblSoyad.Location = new Point(22, 120);
            lblSoyad.Name = "lblSoyad";
            lblSoyad.Size = new Size(71, 28);
            lblSoyad.TabIndex = 2;
            lblSoyad.Text = "Soyad:";
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(234, 117);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(332, 34);
            txtSoyad.TabIndex = 2;
            txtSoyad.TextChanged += Melumat_TextChanged;
            // 
            // lblAd
            // 
            lblAd.AutoSize = true;
            lblAd.Location = new Point(22, 162);
            lblAd.Name = "lblAd";
            lblAd.Size = new Size(41, 28);
            lblAd.TabIndex = 3;
            lblAd.Text = "Ad:";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(234, 159);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(332, 34);
            txtAd.TabIndex = 3;
            txtAd.TextChanged += Melumat_TextChanged;
            // 
            // lblAtaAdi
            // 
            lblAtaAdi.AutoSize = true;
            lblAtaAdi.Location = new Point(22, 204);
            lblAtaAdi.Name = "lblAtaAdi";
            lblAtaAdi.Size = new Size(78, 28);
            lblAtaAdi.TabIndex = 4;
            lblAtaAdi.Text = "Ata adı:";
            // 
            // txtAtaAdi
            // 
            txtAtaAdi.Location = new Point(234, 201);
            txtAtaAdi.Name = "txtAtaAdi";
            txtAtaAdi.Size = new Size(332, 34);
            txtAtaAdi.TabIndex = 4;
            txtAtaAdi.TextChanged += Melumat_TextChanged;
            // 
            // lblCins
            // 
            lblCins.AutoSize = true;
            lblCins.Location = new Point(22, 246);
            lblCins.Name = "lblCins";
            lblCins.Size = new Size(52, 28);
            lblCins.TabIndex = 5;
            lblCins.Text = "Cins:";
            // 
            // txtCins
            // 
            txtCins.Location = new Point(234, 243);
            txtCins.Name = "txtCins";
            txtCins.Size = new Size(332, 34);
            txtCins.TabIndex = 5;
            txtCins.TextChanged += Melumat_TextChanged;
            // 
            // lblDogumTarixi
            // 
            lblDogumTarixi.AutoSize = true;
            lblDogumTarixi.Location = new Point(22, 288);
            lblDogumTarixi.Name = "lblDogumTarixi";
            lblDogumTarixi.Size = new Size(130, 28);
            lblDogumTarixi.TabIndex = 6;
            lblDogumTarixi.Text = "Doğum tarixi:";
            // 
            // txtDogumTarixi
            // 
            txtDogumTarixi.Location = new Point(234, 285);
            txtDogumTarixi.Name = "txtDogumTarixi";
            txtDogumTarixi.Size = new Size(332, 34);
            txtDogumTarixi.TabIndex = 6;
            txtDogumTarixi.TextChanged += Melumat_TextChanged;
            // 
            // lblDogumYeri
            // 
            lblDogumYeri.AutoSize = true;
            lblDogumYeri.Location = new Point(22, 330);
            lblDogumYeri.Name = "lblDogumYeri";
            lblDogumYeri.Size = new Size(119, 28);
            lblDogumYeri.TabIndex = 7;
            lblDogumYeri.Text = "Doğum yeri:";
            // 
            // txtDogumYeri
            // 
            txtDogumYeri.Location = new Point(234, 327);
            txtDogumYeri.Name = "txtDogumYeri";
            txtDogumYeri.Size = new Size(332, 34);
            txtDogumYeri.TabIndex = 7;
            txtDogumYeri.TextChanged += Melumat_TextChanged;
            // 
            // lblAileVeziyyeti
            // 
            lblAileVeziyyeti.AutoSize = true;
            lblAileVeziyyeti.Location = new Point(22, 372);
            lblAileVeziyyeti.Name = "lblAileVeziyyeti";
            lblAileVeziyyeti.Size = new Size(130, 28);
            lblAileVeziyyeti.TabIndex = 8;
            lblAileVeziyyeti.Text = "Ailə vəziyyəti:";
            // 
            // txtAileVeziyyeti
            // 
            txtAileVeziyyeti.Location = new Point(234, 369);
            txtAileVeziyyeti.Name = "txtAileVeziyyeti";
            txtAileVeziyyeti.Size = new Size(332, 34);
            txtAileVeziyyeti.TabIndex = 8;
            txtAileVeziyyeti.TextChanged += Melumat_TextChanged;
            // 
            // lblVerilmeTarixi
            // 
            lblVerilmeTarixi.AutoSize = true;
            lblVerilmeTarixi.Location = new Point(22, 414);
            lblVerilmeTarixi.Name = "lblVerilmeTarixi";
            lblVerilmeTarixi.Size = new Size(129, 28);
            lblVerilmeTarixi.TabIndex = 9;
            lblVerilmeTarixi.Text = "Verilmə tarixi:";
            // 
            // txtVerilmeTarixi
            // 
            txtVerilmeTarixi.Location = new Point(234, 411);
            txtVerilmeTarixi.Name = "txtVerilmeTarixi";
            txtVerilmeTarixi.Size = new Size(332, 34);
            txtVerilmeTarixi.TabIndex = 9;
            txtVerilmeTarixi.TextChanged += Melumat_TextChanged;
            // 
            // lblEtibarlidir
            // 
            lblEtibarlidir.AutoSize = true;
            lblEtibarlidir.Location = new Point(22, 456);
            lblEtibarlidir.Name = "lblEtibarlidir";
            lblEtibarlidir.Size = new Size(101, 28);
            lblEtibarlidir.TabIndex = 10;
            lblEtibarlidir.Text = "Etibarlıdır:";
            // 
            // txtEtibarlidir
            // 
            txtEtibarlidir.Location = new Point(234, 453);
            txtEtibarlidir.Name = "txtEtibarlidir";
            txtEtibarlidir.Size = new Size(332, 34);
            txtEtibarlidir.TabIndex = 10;
            txtEtibarlidir.TextChanged += Melumat_TextChanged;
            // 
            // lblVerenOrqan
            // 
            lblVerenOrqan.AutoSize = true;
            lblVerenOrqan.Location = new Point(22, 498);
            lblVerenOrqan.Name = "lblVerenOrqan";
            lblVerenOrqan.Size = new Size(122, 28);
            lblVerenOrqan.TabIndex = 11;
            lblVerenOrqan.Text = "Verən orqan:";
            // 
            // txtVerenOrqan
            // 
            txtVerenOrqan.Location = new Point(234, 495);
            txtVerenOrqan.Name = "txtVerenOrqan";
            txtVerenOrqan.Size = new Size(332, 34);
            txtVerenOrqan.TabIndex = 11;
            txtVerenOrqan.TextChanged += Melumat_TextChanged;
            // 
            // btnTemizle
            // 
            btnTemizle.Location = new Point(885, 587);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(132, 42);
            btnTemizle.TabIndex = 2;
            btnTemizle.Text = "Təmizlə";
            btnTemizle.UseVisualStyleBackColor = true;
            btnTemizle.Click += btnTemizle_Click;
            // 
            // btnYaddaSaxla
            // 
            btnYaddaSaxla.Location = new Point(1029, 587);
            btnYaddaSaxla.Name = "btnYaddaSaxla";
            btnYaddaSaxla.Size = new Size(156, 42);
            btnYaddaSaxla.TabIndex = 3;
            btnYaddaSaxla.Text = "Yadda saxla";
            btnYaddaSaxla.UseVisualStyleBackColor = true;
            btnYaddaSaxla.Click += btnYaddaSaxla_Click;
            // 
            // timer1
            // 
            timer1.Interval = 100;
            timer1.Tick += timer1_Tick;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(19, 594);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(840, 28);
            progressBar1.TabIndex = 4;
            progressBar1.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1200, 680);
            Controls.Add(grpVesiqe);
            Controls.Add(grpMelumat);
            Controls.Add(btnTemizle);
            Controls.Add(btnYaddaSaxla);
            Controls.Add(progressBar1);
            Font = new Font("Segoe UI", 10F);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Azərbaycan Şəxsiyyət Vəsiqəsi";
            grpVesiqe.ResumeLayout(false);
            pnlCerceve.ResumeLayout(false);
            pnlKart.ResumeLayout(false);
            pnlKartIc.ResumeLayout(false);
            pnlKartIc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picFoto).EndInit();
            grpMelumat.ResumeLayout(false);
            grpMelumat.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpVesiqe;
        private Panel pnlCerceve;
        private Panel pnlKart;
        private Panel pnlKartIc;
        private PictureBox picFoto;
        private Label lblFoto;
        private Label lblKartBasliq;
        private Label lblKartAlt;
        private Label lblKartSoyad;
        private Label lblSoyadK;
        private Label xettSoyad;
        private Label lblKartAd;
        private Label lblAdK;
        private Label xettAd;
        private Label lblKartAtaAdi;
        private Label lblAtaAdiK;
        private Label xettAtaAdi;
        private Label lblKartDogumTarixi;
        private Label lblDogumTarixiK;
        private Label xettDogumTarixi;
        private Label lblKartDogumYeri;
        private Label lblDogumYeriK;
        private Label xettDogumYeri;
        private Label lblKartCins;
        private Label lblCinsK;
        private Label xettCins;
        private Label lblKartSeriya;
        private Label lblSeriyaK;
        private Label xettSeriya;
        private Label lblKartFin;
        private Label lblFinK;
        private Label xettFin;
        private Label lblKartAile;
        private Label lblAileK;
        private Label xettAile;
        private Label lblKartVerilme;
        private Label lblVerilmeK;
        private Label xettVerilme;
        private Label lblKartEtibarli;
        private Label lblEtibarliK;
        private Label xettEtibarli;
        private Label lblKartOrqan;
        private Label lblOrqanK;
        private Label xettOrqan;
        private Button btnSekilYukle;
        private GroupBox grpMelumat;
        private Label lblSeriya;
        private TextBox txtSeriya;
        private Label lblFin;
        private TextBox txtFin;
        private Label lblSoyad;
        private TextBox txtSoyad;
        private Label lblAd;
        private TextBox txtAd;
        private Label lblAtaAdi;
        private TextBox txtAtaAdi;
        private Label lblCins;
        private TextBox txtCins;
        private Label lblDogumTarixi;
        private TextBox txtDogumTarixi;
        private Label lblDogumYeri;
        private TextBox txtDogumYeri;
        private Label lblAileVeziyyeti;
        private TextBox txtAileVeziyyeti;
        private Label lblVerilmeTarixi;
        private TextBox txtVerilmeTarixi;
        private Label lblEtibarlidir;
        private TextBox txtEtibarlidir;
        private Label lblVerenOrqan;
        private TextBox txtVerenOrqan;
        private Button btnTemizle;
        private Button btnYaddaSaxla;
        private System.Windows.Forms.Timer timer1;
        private ProgressBar progressBar1;
    }
}