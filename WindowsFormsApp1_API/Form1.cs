﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


// https://wikidocs.net/17615


namespace WindowsFormsApp1_API
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            axKHOpenAPI1.OnReceiveRealData += OnReceiveRealData;
            ConstructorA();
            ConstructorB();
        }

        public void OnEventConnect(object sender, AxKHOpenAPILib._DKHOpenAPIEvents_OnEventConnectEvent e)
        {
            OnEventConnectA(sender,e);
            OnEventConnectB(sender,e);

        }



        public void onReceiveTrData(object sender, AxKHOpenAPILib._DKHOpenAPIEvents_OnReceiveTrDataEvent e)
        {
            OnReceiveA(sender,e);
            OnReceiveB(sender,e);
        }

        public void OnReceiveRealData(object sender, AxKHOpenAPILib._DKHOpenAPIEvents_OnReceiveRealDataEvent e)
        {
            OnReceiveRealDataA(sender, e);
            OnReceiveRealDataB(sender, e);
        }
          


    }
}