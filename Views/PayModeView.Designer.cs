namespace Supermarket_mvp.Views
{
    partial class PayModeView
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
            tabControl1 = new TabControl();
            PayModeList = new TabPage();
            tabPage2 = new TabPage();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            textBox1 = new TextBox();
            groupBox2 = new GroupBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            richTextBox1 = new RichTextBox();
            richTextBox2 = new RichTextBox();
            richTextBox3 = new RichTextBox();
            button5 = new Button();
            button6 = new Button();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            panel1 = new Panel();
            tabControl1.SuspendLayout();
            PayModeList.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.AccessibleName = "";
            tabControl1.Controls.Add(PayModeList);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(4, 105);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(897, 457);
            tabControl1.TabIndex = 2;
            tabControl1.Tag = "";
            // 
            // PayModeList
            // 
            PayModeList.Controls.Add(button4);
            PayModeList.Controls.Add(button3);
            PayModeList.Controls.Add(button2);
            PayModeList.Controls.Add(button1);
            PayModeList.Controls.Add(textBox1);
            PayModeList.Controls.Add(groupBox2);
            PayModeList.Controls.Add(pictureBox2);
            PayModeList.Controls.Add(label1);
            PayModeList.Location = new Point(4, 29);
            PayModeList.Name = "PayModeList";
            PayModeList.Padding = new Padding(3);
            PayModeList.Size = new Size(889, 424);
            PayModeList.TabIndex = 0;
            PayModeList.Text = "Pay Mode List";
            PayModeList.UseVisualStyleBackColor = true;
            PayModeList.Click += PayModeList_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(button5);
            tabPage2.Controls.Add(button6);
            tabPage2.Controls.Add(richTextBox3);
            tabPage2.Controls.Add(richTextBox2);
            tabPage2.Controls.Add(richTextBox1);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(label3);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(889, 424);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Pay Mode Detail";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.FlatStyle = FlatStyle.Popup;
            button4.Image = Properties.Resources.cerrar;
            button4.Location = new Point(671, 321);
            button4.Name = "button4";
            button4.Size = new Size(202, 65);
            button4.TabIndex = 15;
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.Popup;
            button3.Image = Properties.Resources.delete;
            button3.Location = new Point(671, 250);
            button3.Name = "button3";
            button3.Size = new Size(202, 65);
            button3.TabIndex = 14;
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Image = Properties.Resources.edit;
            button2.Location = new Point(671, 179);
            button2.Name = "button2";
            button2.Size = new Size(202, 65);
            button2.TabIndex = 13;
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Image = Properties.Resources._new;
            button1.Location = new Point(671, 102);
            button1.Name = "button1";
            button1.Size = new Size(202, 65);
            button1.TabIndex = 12;
            button1.TextAlign = ContentAlignment.BottomCenter;
            button1.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(16, 56);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(601, 27);
            textBox1.TabIndex = 9;
            textBox1.Text = "Data to Search";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.DimGray;
            groupBox2.Location = new Point(16, 102);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(637, 306);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.cancel;
            pictureBox2.Location = new Point(623, 53);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(30, 30);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Location = new Point(16, 17);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(122, 20);
            label1.TabIndex = 8;
            label1.Text = "Search Pay Mode";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 18);
            label3.Name = "label3";
            label3.Size = new Size(91, 20);
            label3.TabIndex = 0;
            label3.Text = "Pay Mode Id";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(44, 85);
            label4.Name = "label4";
            label4.Size = new Size(118, 20);
            label4.TabIndex = 1;
            label4.Text = "Pay Mode Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(44, 151);
            label5.Name = "label5";
            label5.Size = new Size(158, 20);
            label5.TabIndex = 2;
            label5.Text = "Pay Mode Observation";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(44, 184);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(321, 91);
            richTextBox1.TabIndex = 3;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(44, 41);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(321, 27);
            richTextBox2.TabIndex = 4;
            richTextBox2.Text = "";
            // 
            // richTextBox3
            // 
            richTextBox3.Location = new Point(44, 108);
            richTextBox3.Name = "richTextBox3";
            richTextBox3.Size = new Size(321, 28);
            richTextBox3.TabIndex = 5;
            richTextBox3.Text = "";
            // 
            // button5
            // 
            button5.FlatStyle = FlatStyle.Popup;
            button5.Image = Properties.Resources.cancel;
            button5.Location = new Point(237, 328);
            button5.Name = "button5";
            button5.Size = new Size(118, 65);
            button5.TabIndex = 17;
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.FlatStyle = FlatStyle.Popup;
            button6.Image = Properties.Resources.save;
            button6.Location = new Point(44, 328);
            button6.Name = "button6";
            button6.Size = new Size(118, 65);
            button6.TabIndex = 16;
            button6.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.buy;
            pictureBox1.Location = new Point(24, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 84);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.Location = new Point(210, 33);
            label2.Margin = new Padding(5);
            label2.MaximumSize = new Size(200, 200);
            label2.Name = "label2";
            label2.Size = new Size(189, 36);
            label2.TabIndex = 1;
            label2.Text = "PAY MODE";
            label2.Click += label2_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.AppWorkspace;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(900, 96);
            panel1.TabIndex = 3;
            // 
            // PayModeView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 564);
            Controls.Add(panel1);
            Controls.Add(tabControl1);
            Name = "PayModeView";
            Text = "Pay Mode Management";
            tabControl1.ResumeLayout(false);
            PayModeList.ResumeLayout(false);
            PayModeList.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TabControl tabControl1;
        private TabPage PayModeList;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private TextBox textBox1;
        private GroupBox groupBox2;
        private PictureBox pictureBox2;
        private Label label1;
        private TabPage tabPage2;
        private RichTextBox richTextBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private RichTextBox richTextBox3;
        private RichTextBox richTextBox2;
        private Label label2;
        private PictureBox pictureBox1;
        private Button button5;
        private Button button6;
        private Panel panel1;
    }
}