﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MySchool
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]

        
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
         
            LoginForm frmLogin = new LoginForm();

            Application.Run(frmLogin);

        }
    }
}