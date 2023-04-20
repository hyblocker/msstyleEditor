﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace msstyleEditor
{
    public partial class LicenseDialog : Form
    {
        public LicenseDialog()
        {
            InitializeComponent();
            lvSelection.Items[0].Selected = true;
        }

        private string[] LICENSE = new string[]
        {
            @"MIT License

Copyright (c) 2023 Jakob K.

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the ""Software""), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED ""AS IS"", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.",
        @"msstyleEditor uses Jose Menendez Poo's Ribbon control, available at
https://github.com/RibbonWinForms/RibbonWinForms

It is licensed under the ""Microsoft Public License"":
https://github.com/RibbonWinForms/RibbonWinForms/blob/master/LICENSE.
"

        };
        private void OnSelectionChanged(object sender, EventArgs e)
        {
            if(lvSelection.SelectedIndices?.Count > 0)
            {
                tbLicense.Text = LICENSE[lvSelection.SelectedIndices[0]];
            }
        }

        // Escape to close dialog
        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (keyData == Keys.Escape && Form.ModifierKeys == Keys.None)
            {
                this.Close();
                return true;
            }

            return base.ProcessDialogKey(keyData);
        }

    }
}
