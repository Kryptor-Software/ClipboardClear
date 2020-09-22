using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

//Clipboard Clear: Clear your clipboard with one click.
//    Copyright(C) 2020 Samuel Lucas

//    This program is free software: you can redistribute it and/or modify
//    it under the terms of the GNU General Public License as published by
//    the Free Software Foundation, either version 3 of the License, or
//    any later version.

//    This program is distributed in the hope that it will be useful,
//    but WITHOUT ANY WARRANTY; without even the implied warranty of
//    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.See the
//    GNU General Public License for more details.

//    You should have received a copy of the GNU General Public License
//    along with this program. If not, see https://www.gnu.org/licenses/.

namespace Clipboard_Clear
{
    public partial class ClipboardClear : Form
    {
        public ClipboardClear()
        {
            InitializeComponent();
        }

        private void Clipboard_Load(object sender, EventArgs e)
        {
            try
            {
                Clipboard.Clear();
            }
            catch (ExternalException)
            {
                MessageBox.Show("Error: Failed to clear clipboard because the clipboard is being used by another process.");
            }
            finally
            {
                Application.Exit();
            }
        }
    }
}
