﻿using DDD.Common;
using DDD.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DDD
{
    public partial class WeathreLatestView: Form
    {

        public WeathreLatestView()
        {
            InitializeComponent();
        }

        private void LatestButton_Click(object sender, EventArgs e)
        {
            var dt = WeatherSQLite.GetLatest(Convert.ToInt32(AreaIdTextBox.Text));

            


        }


    }
}
