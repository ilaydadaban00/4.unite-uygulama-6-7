﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4.unite_uygulama_4
{
    public partial class Form1 : Form
    {
        string[] isimler=new string[3];
        int[,] notlar = new int[3, 4];
        int index = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            isimler[index] = txtAdSoyad.Text;
            notlar[index, 0] = int.Parse(txtNot1.Text);
            notlar[index, 1] = int.Parse(txtNot2.Text);
            notlar[index, 2] = int.Parse(txtSozlu1.Text);
            notlar[index, 3] = int.Parse(txtSozlu2.Text);
            index++;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            double toplam;
            for (int x = 0; x < 3; x++)
            {
                toplam = 0;
                for (int y = 0; y < 4; y++)
                {
                    toplam += notlar[x, y];
                }
                listeleNotlar.Items.Add(isimler[x] +" =>"+toplam / 4);
            }
        }         
    }
}
