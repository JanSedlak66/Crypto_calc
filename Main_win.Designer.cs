namespace Crypto_calc
{
    partial class Main_win
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_win));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.textBox_btc = new System.Windows.Forms.TextBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton_bittrex = new System.Windows.Forms.RadioButton();
            this.radioButton_bitfinex = new System.Windows.Forms.RadioButton();
            this.textBox_usd = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nastaveniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tOPWinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer2sToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sToolStripMenuItem30s = new System.Windows.Forms.ToolStripMenuItem();
            this.sToolStripMenuItem10s = new System.Windows.Forms.ToolStripMenuItem();
            this.sToolStripMenuItem5s = new System.Windows.Forms.ToolStripMenuItem();
            this.sToolStripMenuItem1s = new System.Windows.Forms.ToolStripMenuItem();
            this.chartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox_czk = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.button1, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(194, 168);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(122, 140);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(64, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 42);
            this.button1.TabIndex = 6;
            this.button1.Text = "CE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(15, 17);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(77, 17);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "blockchain";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(15, 40);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(64, 17);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.Text = "bitstamp";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 312);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(319, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(304, 17);
            this.toolStripStatusLabel1.Spring = true;
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox_btc
            // 
            this.textBox_btc.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_btc.Location = new System.Drawing.Point(67, 27);
            this.textBox_btc.Name = "textBox_btc";
            this.textBox_btc.Size = new System.Drawing.Size(238, 38);
            this.textBox_btc.TabIndex = 4;
            this.textBox_btc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(15, 63);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(64, 17);
            this.radioButton3.TabIndex = 5;
            this.radioButton3.Text = "poloniex";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_bittrex);
            this.groupBox1.Controls.Add(this.radioButton_bitfinex);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Location = new System.Drawing.Point(12, 168);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(176, 140);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Market";
            // 
            // radioButton_bittrex
            // 
            this.radioButton_bittrex.AutoSize = true;
            this.radioButton_bittrex.Location = new System.Drawing.Point(15, 109);
            this.radioButton_bittrex.Name = "radioButton_bittrex";
            this.radioButton_bittrex.Size = new System.Drawing.Size(53, 17);
            this.radioButton_bittrex.TabIndex = 7;
            this.radioButton_bittrex.Text = "bittrex";
            this.radioButton_bittrex.UseVisualStyleBackColor = true;
            this.radioButton_bittrex.CheckedChanged += new System.EventHandler(this.radioButton_bittrex_CheckedChanged);
            // 
            // radioButton_bitfinex
            // 
            this.radioButton_bitfinex.AutoSize = true;
            this.radioButton_bitfinex.Location = new System.Drawing.Point(15, 86);
            this.radioButton_bitfinex.Name = "radioButton_bitfinex";
            this.radioButton_bitfinex.Size = new System.Drawing.Size(58, 17);
            this.radioButton_bitfinex.TabIndex = 6;
            this.radioButton_bitfinex.Text = "bitfinex";
            this.radioButton_bitfinex.UseVisualStyleBackColor = true;
            this.radioButton_bitfinex.CheckedChanged += new System.EventHandler(this.radioButton_bitfinex_CheckedChanged);
            // 
            // textBox_usd
            // 
            this.textBox_usd.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_usd.Location = new System.Drawing.Point(67, 71);
            this.textBox_usd.Name = "textBox_usd";
            this.textBox_usd.Size = new System.Drawing.Size(238, 38);
            this.textBox_usd.TabIndex = 7;
            this.textBox_usd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nastaveniToolStripMenuItem,
            this.chartToolStripMenuItem,
            this.aboutToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(319, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nastaveniToolStripMenuItem
            // 
            this.nastaveniToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tOPWinToolStripMenuItem,
            this.timer2sToolStripMenuItem});
            this.nastaveniToolStripMenuItem.Name = "nastaveniToolStripMenuItem";
            this.nastaveniToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.nastaveniToolStripMenuItem.Text = "Settings";
            // 
            // tOPWinToolStripMenuItem
            // 
            this.tOPWinToolStripMenuItem.CheckOnClick = true;
            this.tOPWinToolStripMenuItem.Name = "tOPWinToolStripMenuItem";
            this.tOPWinToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.tOPWinToolStripMenuItem.Text = "Always TOP";
            this.tOPWinToolStripMenuItem.Click += new System.EventHandler(this.tOPWinToolStripMenuItem_Click);
            // 
            // timer2sToolStripMenuItem
            // 
            this.timer2sToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sToolStripMenuItem30s,
            this.sToolStripMenuItem10s,
            this.sToolStripMenuItem5s,
            this.sToolStripMenuItem1s});
            this.timer2sToolStripMenuItem.Name = "timer2sToolStripMenuItem";
            this.timer2sToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.timer2sToolStripMenuItem.Text = "Refresh rate";
            // 
            // sToolStripMenuItem30s
            // 
            this.sToolStripMenuItem30s.CheckOnClick = true;
            this.sToolStripMenuItem30s.Name = "sToolStripMenuItem30s";
            this.sToolStripMenuItem30s.Size = new System.Drawing.Size(91, 22);
            this.sToolStripMenuItem30s.Text = "30s";
            this.sToolStripMenuItem30s.Click += new System.EventHandler(this.sToolStripMenuItem30s_Click);
            // 
            // sToolStripMenuItem10s
            // 
            this.sToolStripMenuItem10s.CheckOnClick = true;
            this.sToolStripMenuItem10s.Name = "sToolStripMenuItem10s";
            this.sToolStripMenuItem10s.Size = new System.Drawing.Size(91, 22);
            this.sToolStripMenuItem10s.Text = "10s";
            this.sToolStripMenuItem10s.Click += new System.EventHandler(this.sToolStripMenuItem10s_Click);
            // 
            // sToolStripMenuItem5s
            // 
            this.sToolStripMenuItem5s.CheckOnClick = true;
            this.sToolStripMenuItem5s.Name = "sToolStripMenuItem5s";
            this.sToolStripMenuItem5s.Size = new System.Drawing.Size(91, 22);
            this.sToolStripMenuItem5s.Text = "5s";
            this.sToolStripMenuItem5s.Click += new System.EventHandler(this.sToolStripMenuItem5s_Click);
            // 
            // sToolStripMenuItem1s
            // 
            this.sToolStripMenuItem1s.CheckOnClick = true;
            this.sToolStripMenuItem1s.Name = "sToolStripMenuItem1s";
            this.sToolStripMenuItem1s.Size = new System.Drawing.Size(91, 22);
            this.sToolStripMenuItem1s.Text = "1s";
            this.sToolStripMenuItem1s.Click += new System.EventHandler(this.sToolStripMenuItem1s_Click);
            // 
            // chartToolStripMenuItem
            // 
            this.chartToolStripMenuItem.Name = "chartToolStripMenuItem";
            this.chartToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.chartToolStripMenuItem.Text = "Chart";
            this.chartToolStripMenuItem.Click += new System.EventHandler(this.chartToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem1.Text = "About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // textBox_czk
            // 
            this.textBox_czk.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_czk.Location = new System.Drawing.Point(67, 115);
            this.textBox_czk.Name = "textBox_czk";
            this.textBox_czk.Size = new System.Drawing.Size(238, 38);
            this.textBox_czk.TabIndex = 9;
            this.textBox_czk.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(7, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "BTC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(7, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "USD";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(7, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "CZK";
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Main_win
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 334);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_czk);
            this.Controls.Add(this.textBox_usd);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox_btc);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main_win";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cryptocurrency calculator";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TextBox textBox_btc;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_usd;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nastaveniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tOPWinToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox_czk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem timer2sToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem sToolStripMenuItem10s;
        private System.Windows.Forms.ToolStripMenuItem sToolStripMenuItem5s;
        private System.Windows.Forms.ToolStripMenuItem sToolStripMenuItem1s;
        private System.Windows.Forms.ToolStripMenuItem sToolStripMenuItem30s;
        private System.Windows.Forms.RadioButton radioButton_bittrex;
        private System.Windows.Forms.RadioButton radioButton_bitfinex;
        private System.Windows.Forms.ToolStripMenuItem chartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
    }
}

