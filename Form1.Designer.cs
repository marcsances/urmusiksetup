namespace urMusik_Setup
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.heading = new System.Windows.Forms.Label();
            this.heading2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.disclaimer = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.cancelsetup = new System.Windows.Forms.Button();
            this.install = new System.Windows.Forms.Button();
            this.checklic = new System.Windows.Forms.CheckBox();
            this.changepath = new System.Windows.Forms.CheckBox();
            this.makedefault = new System.Windows.Forms.CheckBox();
            this.bexit = new System.Windows.Forms.Label();
            this.terror = new System.Windows.Forms.Label();
            this.derror = new System.Windows.Forms.Label();
            this.talmost = new System.Windows.Forms.Label();
            this.dalmost = new System.Windows.Forms.Label();
            this.twait = new System.Windows.Forms.Label();
            this.dwait = new System.Windows.Forms.Label();
            this.exts = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // heading
            // 
            resources.ApplyResources(this.heading, "heading");
            this.heading.BackColor = System.Drawing.Color.Transparent;
            this.heading.ForeColor = System.Drawing.Color.Black;
            this.heading.Name = "heading";
            // 
            // heading2
            // 
            resources.ApplyResources(this.heading2, "heading2");
            this.heading2.BackColor = System.Drawing.Color.Transparent;
            this.heading2.ForeColor = System.Drawing.Color.Black;
            this.heading2.Name = "heading2";
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            // 
            // disclaimer
            // 
            resources.ApplyResources(this.disclaimer, "disclaimer");
            this.disclaimer.BackColor = System.Drawing.Color.Transparent;
            this.disclaimer.ForeColor = System.Drawing.Color.Black;
            this.disclaimer.Name = "disclaimer";
            // 
            // linkLabel1
            // 
            resources.ApplyResources(this.linkLabel1, "linkLabel1");
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.TabStop = true;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel2
            // 
            resources.ApplyResources(this.linkLabel2, "linkLabel2");
            this.linkLabel2.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.TabStop = true;
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabel3
            // 
            resources.ApplyResources(this.linkLabel3, "linkLabel3");
            this.linkLabel3.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.TabStop = true;
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // cancelsetup
            // 
            resources.ApplyResources(this.cancelsetup, "cancelsetup");
            this.cancelsetup.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelsetup.Name = "cancelsetup";
            this.cancelsetup.Tag = "";
            this.cancelsetup.UseVisualStyleBackColor = true;
            this.cancelsetup.Click += new System.EventHandler(this.cancelsetup_Click);
            // 
            // install
            // 
            resources.ApplyResources(this.install, "install");
            this.install.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.install.Name = "install";
            this.install.UseVisualStyleBackColor = true;
            this.install.Click += new System.EventHandler(this.button1_Click);
            // 
            // checklic
            // 
            resources.ApplyResources(this.checklic, "checklic");
            this.checklic.BackColor = System.Drawing.Color.Transparent;
            this.checklic.Name = "checklic";
            this.checklic.UseVisualStyleBackColor = false;
            this.checklic.CheckedChanged += new System.EventHandler(this.checklic_CheckedChanged);
            // 
            // changepath
            // 
            resources.ApplyResources(this.changepath, "changepath");
            this.changepath.BackColor = System.Drawing.Color.Transparent;
            this.changepath.Name = "changepath";
            this.changepath.UseVisualStyleBackColor = false;
            // 
            // makedefault
            // 
            resources.ApplyResources(this.makedefault, "makedefault");
            this.makedefault.BackColor = System.Drawing.Color.Transparent;
            this.makedefault.Checked = true;
            this.makedefault.CheckState = System.Windows.Forms.CheckState.Checked;
            this.makedefault.Name = "makedefault";
            this.makedefault.UseVisualStyleBackColor = false;
            // 
            // bexit
            // 
            resources.ApplyResources(this.bexit, "bexit");
            this.bexit.Name = "bexit";
            // 
            // terror
            // 
            resources.ApplyResources(this.terror, "terror");
            this.terror.Name = "terror";
            // 
            // derror
            // 
            resources.ApplyResources(this.derror, "derror");
            this.derror.Name = "derror";
            // 
            // talmost
            // 
            resources.ApplyResources(this.talmost, "talmost");
            this.talmost.Name = "talmost";
            // 
            // dalmost
            // 
            resources.ApplyResources(this.dalmost, "dalmost");
            this.dalmost.Name = "dalmost";
            // 
            // twait
            // 
            resources.ApplyResources(this.twait, "twait");
            this.twait.Name = "twait";
            // 
            // dwait
            // 
            resources.ApplyResources(this.dwait, "dwait");
            this.dwait.Name = "dwait";
            // 
            // exts
            // 
            resources.ApplyResources(this.exts, "exts");
            this.exts.Name = "exts";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.exts);
            this.Controls.Add(this.dwait);
            this.Controls.Add(this.twait);
            this.Controls.Add(this.dalmost);
            this.Controls.Add(this.talmost);
            this.Controls.Add(this.derror);
            this.Controls.Add(this.terror);
            this.Controls.Add(this.bexit);
            this.Controls.Add(this.makedefault);
            this.Controls.Add(this.changepath);
            this.Controls.Add(this.checklic);
            this.Controls.Add(this.install);
            this.Controls.Add(this.cancelsetup);
            this.Controls.Add(this.linkLabel3);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.disclaimer);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.heading2);
            this.Controls.Add(this.heading);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label heading;
        private System.Windows.Forms.Label heading2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label disclaimer;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.Button cancelsetup;
        private System.Windows.Forms.Button install;
        private System.Windows.Forms.CheckBox checklic;
        private System.Windows.Forms.CheckBox changepath;
        private System.Windows.Forms.CheckBox makedefault;
        private System.Windows.Forms.Label bexit;
        private System.Windows.Forms.Label terror;
        private System.Windows.Forms.Label derror;
        private System.Windows.Forms.Label talmost;
        private System.Windows.Forms.Label dalmost;
        private System.Windows.Forms.Label twait;
        private System.Windows.Forms.Label dwait;
        private System.Windows.Forms.Label exts;
    }
}

