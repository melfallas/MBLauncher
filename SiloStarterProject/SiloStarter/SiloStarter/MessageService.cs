﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiloStarter
{
    class MessageService
    {
        public static DialogResult displayInfoMessage(string pMessage, string pTitle = "")
        {
            return MessageBox.Show(pMessage, pTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static DialogResult displayWarningMessage(string pMessage, string pTitle = "")
        {
            return MessageBox.Show(pMessage, pTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static DialogResult displayErrorMessage(string pMessage, string pTitle = "")
        {
            return MessageBox.Show(pMessage, pTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static DialogResult displayConfirmMessage(string pMessage, string pTitle = "")
        {
            return MessageBox.Show(pMessage, pTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
        }

        public static DialogResult displayConfirmWarningMessage(string pMessage, string pTitle = "")
        {
            return MessageBox.Show(pMessage, pTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        }
    }
}
