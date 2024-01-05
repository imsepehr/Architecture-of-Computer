namespace win1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.code = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.line = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Lable = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Address = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Instruction = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Hex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.outr = new System.Windows.Forms.Label();
            this.opcode = new System.Windows.Forms.Label();
            this.inpr = new System.Windows.Forms.Label();
            this.fgo = new System.Windows.Forms.Label();
            this.fgi = new System.Windows.Forms.Label();
            this.sc = new System.Windows.Forms.Label();
            this.i = new System.Windows.Forms.Label();
            this.e = new System.Windows.Forms.Label();
            this.ien = new System.Windows.Forms.Label();
            this.decode = new System.Windows.Forms.Label();
            this.dr = new System.Windows.Forms.Label();
            this.ar = new System.Windows.Forms.Label();
            this.pc = new System.Windows.Forms.Label();
            this.ac = new System.Windows.Forms.Label();
            this.ir = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.compile = new System.Windows.Forms.Button();
            this.all = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // code
            // 
            this.code.AcceptsTab = true;
            this.code.BackColor = System.Drawing.Color.Khaki;
            this.code.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.code, "code");
            this.code.ForeColor = System.Drawing.Color.Black;
            this.code.Name = "code";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(26)))));
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(243)))), ((int)(((byte)(240)))));
            this.label1.Name = "label1";
            // 
            // line
            // 
            this.line.BackColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.line, "line");
            this.line.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.line.Name = "line";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Red;
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.Khaki;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Lable,
            this.Address,
            this.Instruction,
            this.Hex});
            this.listView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listView1.HideSelection = false;
            resources.ApplyResources(this.listView1, "listView1");
            this.listView1.Name = "listView1";
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.listView1_ColumnWidthChanging);
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Lable
            // 
            resources.ApplyResources(this.Lable, "Lable");
            // 
            // Address
            // 
            resources.ApplyResources(this.Address, "Address");
            // 
            // Instruction
            // 
            resources.ApplyResources(this.Instruction, "Instruction");
            // 
            // Hex
            // 
            resources.ApplyResources(this.Hex, "Hex");
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.BackColor = System.Drawing.Color.Silver;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label10.ForeColor = System.Drawing.Color.Teal;
            this.label10.Name = "label10";
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Tomato;
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Tomato;
            resources.ApplyResources(this.label12, "label12");
            this.label12.Name = "label12";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Tomato;
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Tomato;
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.RoyalBlue;
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.Color.RoyalBlue;
            resources.ApplyResources(this.label17, "label17");
            this.label17.Name = "label17";
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.Color.Tomato;
            resources.ApplyResources(this.label18, "label18");
            this.label18.Name = "label18";
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.RoyalBlue;
            resources.ApplyResources(this.label15, "label15");
            this.label15.Name = "label15";
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.Tomato;
            resources.ApplyResources(this.label13, "label13");
            this.label13.Name = "label13";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.RoyalBlue;
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.RoyalBlue;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(this.label5, "label5");
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Name = "label5";
            // 
            // label20
            // 
            this.label20.BackColor = System.Drawing.Color.RoyalBlue;
            resources.ApplyResources(this.label20, "label20");
            this.label20.Name = "label20";
            // 
            // label19
            // 
            this.label19.BackColor = System.Drawing.Color.Tomato;
            resources.ApplyResources(this.label19, "label19");
            this.label19.Name = "label19";
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.RoyalBlue;
            resources.ApplyResources(this.label14, "label14");
            this.label14.Name = "label14";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.RoyalBlue;
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // outr
            // 
            this.outr.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.outr, "outr");
            this.outr.ForeColor = System.Drawing.Color.Black;
            this.outr.Name = "outr";
            // 
            // opcode
            // 
            this.opcode.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.opcode, "opcode");
            this.opcode.ForeColor = System.Drawing.Color.Black;
            this.opcode.Name = "opcode";
            this.opcode.Click += new System.EventHandler(this.opcode_Click);
            // 
            // inpr
            // 
            this.inpr.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.inpr, "inpr");
            this.inpr.ForeColor = System.Drawing.Color.Black;
            this.inpr.Name = "inpr";
            this.inpr.Click += new System.EventHandler(this.inpr_Click);
            // 
            // fgo
            // 
            this.fgo.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.fgo, "fgo");
            this.fgo.ForeColor = System.Drawing.Color.Black;
            this.fgo.Name = "fgo";
            // 
            // fgi
            // 
            this.fgi.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.fgi, "fgi");
            this.fgi.ForeColor = System.Drawing.Color.Black;
            this.fgi.Name = "fgi";
            // 
            // sc
            // 
            this.sc.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.sc, "sc");
            this.sc.ForeColor = System.Drawing.Color.Black;
            this.sc.Name = "sc";
            // 
            // i
            // 
            this.i.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.i, "i");
            this.i.ForeColor = System.Drawing.Color.Black;
            this.i.Name = "i";
            // 
            // e
            // 
            this.e.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.e, "e");
            this.e.ForeColor = System.Drawing.Color.Black;
            this.e.Name = "e";
            // 
            // ien
            // 
            this.ien.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.ien, "ien");
            this.ien.ForeColor = System.Drawing.Color.Black;
            this.ien.Name = "ien";
            // 
            // decode
            // 
            this.decode.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.decode, "decode");
            this.decode.ForeColor = System.Drawing.Color.Black;
            this.decode.Name = "decode";
            // 
            // dr
            // 
            this.dr.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.dr, "dr");
            this.dr.ForeColor = System.Drawing.Color.Black;
            this.dr.Name = "dr";
            // 
            // ar
            // 
            this.ar.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.ar, "ar");
            this.ar.ForeColor = System.Drawing.Color.Black;
            this.ar.Name = "ar";
            // 
            // pc
            // 
            this.pc.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.pc, "pc");
            this.pc.ForeColor = System.Drawing.Color.Black;
            this.pc.Name = "pc";
            // 
            // ac
            // 
            this.ac.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.ac, "ac");
            this.ac.ForeColor = System.Drawing.Color.Black;
            this.ac.Name = "ac";
            // 
            // ir
            // 
            this.ir.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.ir, "ir");
            this.ir.ForeColor = System.Drawing.Color.Black;
            this.ir.Name = "ir";
            this.ir.Click += new System.EventHandler(this.ir_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Khaki;
            this.panel3.Controls.Add(this.ir);
            this.panel3.Controls.Add(this.ac);
            this.panel3.Controls.Add(this.pc);
            this.panel3.Controls.Add(this.ar);
            this.panel3.Controls.Add(this.dr);
            this.panel3.Controls.Add(this.decode);
            this.panel3.Controls.Add(this.ien);
            this.panel3.Controls.Add(this.e);
            this.panel3.Controls.Add(this.i);
            this.panel3.Controls.Add(this.sc);
            this.panel3.Controls.Add(this.fgi);
            this.panel3.Controls.Add(this.fgo);
            this.panel3.Controls.Add(this.inpr);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.opcode);
            this.panel3.Controls.Add(this.outr);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.label19);
            this.panel3.Controls.Add(this.label20);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.label18);
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label11);
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // compile
            // 
            this.compile.BackColor = System.Drawing.Color.Tomato;
            resources.ApplyResources(this.compile, "compile");
            this.compile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.compile.Name = "compile";
            this.compile.UseVisualStyleBackColor = false;
            this.compile.Click += new System.EventHandler(this.Compile_Click);
            // 
            // all
            // 
            this.all.BackColor = System.Drawing.Color.Tomato;
            resources.ApplyResources(this.all, "all");
            this.all.Cursor = System.Windows.Forms.Cursors.Hand;
            this.all.Name = "all";
            this.all.UseVisualStyleBackColor = false;
            this.all.Click += new System.EventHandler(this.All_Click);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.compile);
            this.Controls.Add(this.all);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.line);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.code);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox code;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label line;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Lable;
        private System.Windows.Forms.ColumnHeader Address;
        private System.Windows.Forms.ColumnHeader Instruction;
        private System.Windows.Forms.ColumnHeader Hex;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button compile;
        private System.Windows.Forms.Button all;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label outr;
        private System.Windows.Forms.Label opcode;
        private System.Windows.Forms.Label inpr;
        private System.Windows.Forms.Label fgo;
        private System.Windows.Forms.Label fgi;
        private System.Windows.Forms.Label sc;
        private System.Windows.Forms.Label i;
        private System.Windows.Forms.Label e;
        private System.Windows.Forms.Label ien;
        private System.Windows.Forms.Label decode;
        private System.Windows.Forms.Label dr;
        private System.Windows.Forms.Label ar;
        private System.Windows.Forms.Label pc;
        private System.Windows.Forms.Label ac;
        private System.Windows.Forms.Label ir;
        private System.Windows.Forms.Panel panel3;
        //private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

