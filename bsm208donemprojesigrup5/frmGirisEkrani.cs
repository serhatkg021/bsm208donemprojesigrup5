﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;
using MicroServices;

namespace bsm208donemprojesigrup5
{
    public partial class frmGirisEkrani : Form
    {
        public frmGirisEkrani()
        {
            InitializeComponent();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            Kullanici girisKullanici = new Kullanici();
            KullaniciServices ms = new KullaniciServices();

            girisKullanici.kullaniciAdi = tbKullaniciAd.Text;
            girisKullanici.sifre = tbSifre.Text;

            Kullanici donenKullanici = new Kullanici(); 
            donenKullanici =  ms.girisKontrol(girisKullanici);

            if (donenKullanici != null)
            {
                MessageBox.Show("Hoşgeldiniz");
            }
            else
            {
                MessageBox.Show("Hatalı Giriş Denemesi");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
