/*
 * This file is part of urMusik.

    urMusik is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    urMusik is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with urMusik.  If not, see <http://www.gnu.org/licenses/>.
 * */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using Microsoft.Win32;
using System.Globalization;

namespace urMusik_Setup
{
    public partial class Form1 : Form
    {
        /**
         * DEPLOYMENT INSTRUCTIONS
         * 1. Generate a deployment folder.
         * 2. Generate a MSI package for urMusik.
         * 3. Put MSI setup file inside deployment folder and with name "setup.msi".
         * 4. Put urMusik icon as icon.ico
         * 5. Change APP_VER and all product info of this setup.
         * 6. Compile this setup binary and put it insde deployment folder. Name it "setup.exe"
         * 7. Pack all in a self-extracting package.
         */
        public const string APP_VER = "2.1.5391.35123";
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void cancelsetup_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://www.apache.org/licenses/LICENSE-2.0");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://opensource.org/licenses/ms-pl.html");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://www.gnu.org/licenses/lgpl.html");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dir = "";
            if (changepath.Checked)
            {
                FolderBrowserDialog fbd = new FolderBrowserDialog();
                fbd.Description = changepath.Text;
                if (fbd.ShowDialog() == DialogResult.OK) dir = fbd.SelectedPath;
            }
            if (dir == "") dir = Environment.SpecialFolder.ProgramFiles + "\\MSS Software & Services\\urMusik\\" + APP_VER;
            if (performInstall(dir))
            {
                associateExts(dir);
                showSuccess();
            }
            else
            {
                showFailure();
            }
        }

        private void hideui()
        {
            textBox1.Visible = false;
            disclaimer.Visible = false;
            linkLabel1.Visible = false;
            linkLabel2.Visible = false;
            linkLabel3.Visible = false;
            checklic.Visible = false;
            makedefault.Visible = false;
            changepath.Visible = false;
        }

        private bool performInstall(string dir)
        {
            cancelsetup.Enabled = false;
            ControlBox = false;
            heading.Text = twait.Text;
            heading2.Text = dwait.Text;
            hideui();
            Process p = new Process();
            p.StartInfo.FileName = "msiexec";
            p.StartInfo.Arguments = "/i \"" + System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\setup.msi\" /passive";
            if (dir != "") { p.StartInfo.Arguments = p.StartInfo.Arguments + " TARGETDIR=\"" + dir + "\""; }
            p.Start();
            p.WaitForExit();
            cancelsetup.Enabled = true;
            ControlBox = true;
            if (p.ExitCode == 0)
            {
                return true;
            }
            else
            {
                Console.WriteLine("msiexec threw an error: " + p.ExitCode + "\r\nRefer to http://msdn.microsoft.com/en-us/library/aa376931(v=vs.85).aspx");
                return false;
            }
            
        }

        private string ResolveExt(int val)
        {
            return exts.Text.Split('|')[val];
        }

        private void associateExts(string dir)
        {
            if (!FileAssociation.IsAssociated(".mp3"))
            {
                FileAssociation.Associate(".mp3", "urMusik.mp3", ResolveExt(0), System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\icon.ico", dir + "\\urMusik.exe");
            }
            if (!FileAssociation.IsAssociated(".wav"))
            {
                FileAssociation.Associate(".wav", "urMusik.wav", ResolveExt(1), System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\icon.ico", dir + "\\urMusik.exe");
            }
            if (!FileAssociation.IsAssociated(".pcm"))
            {
                FileAssociation.Associate(".pcm", "urMusik.pcm", ResolveExt(2), System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\icon.ico", dir + "\\urMusik.exe");
            }
            if (!FileAssociation.IsAssociated(".aac"))
            {
                FileAssociation.Associate(".aac", "urMusik.aac", ResolveExt(3), System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\icon.ico", dir + "\\urMusik.exe");
            }
            if (!FileAssociation.IsAssociated(".m4a"))
            {
                FileAssociation.Associate(".m4a", "urMusik.m4a", ResolveExt(3), System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\icon.ico", dir + "\\urMusik.exe");
            }
            if (!FileAssociation.IsAssociated(".flac"))
            {
                FileAssociation.Associate(".flac", "urMusik.flac", ResolveExt(4), System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\icon.ico", dir + "\\urMusik.exe");
            }
        }

        private void showSuccess()
        {
            heading.Text = talmost.Text;
            heading2.Text = dalmost.Text;

        }

        private void showFailure()
        {
            heading.Text = terror.Text;
            heading2.Text = derror.Text;
        }

        private void checklic_CheckedChanged(object sender, EventArgs e)
        {
            install.Enabled = checklic.Checked;
        }

    }
}
