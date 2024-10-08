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
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            tabControl1 = new TabControl();
            tabPagePayModeList = new TabPage();
            tabPageModelDetail = new TabPage();
            label2 = new Label();
            TxtSearch = new TextBox();
            BtnSearch = new Button();
            DgPayMode = new DataGridView();
            BtnNew = new Button();
            BtnEdit = new Button();
            BtnDelete = new Button();
            BtnClose = new Button();
            TxtPayModeId = new TextBox();
            TxtPayModeName = new TextBox();
            TxtPayModeObservation = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            BtnSave = new Button();
            BtnCancel = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabPagePayModeList.SuspendLayout();
            tabPageModelDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgPayMode).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.AppWorkspace;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(670, 100);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AccessibleRole = AccessibleRole.Character;
            label1.AllowDrop = true;
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Assertive;
            label1.Location = new Point(139, 40);
            label1.Name = "label1";
            label1.Size = new Size(62, 17);
            label1.TabIndex = 0;
            label1.Text = "Pay Mode";
            label1.UseMnemonic = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.buy;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(106, 74);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPagePayModeList);
            tabControl1.Controls.Add(tabPageModelDetail);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 100);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(670, 276);
            tabControl1.TabIndex = 1;
            // 
            // tabPagePayModeList
            // 
            tabPagePayModeList.Controls.Add(BtnClose);
            tabPagePayModeList.Controls.Add(BtnDelete);
            tabPagePayModeList.Controls.Add(BtnEdit);
            tabPagePayModeList.Controls.Add(BtnNew);
            tabPagePayModeList.Controls.Add(DgPayMode);
            tabPagePayModeList.Controls.Add(BtnSearch);
            tabPagePayModeList.Controls.Add(TxtSearch);
            tabPagePayModeList.Controls.Add(label2);
            tabPagePayModeList.Font = new Font("Segoe UI Semibold", 9F);
            tabPagePayModeList.Location = new Point(4, 24);
            tabPagePayModeList.Name = "tabPagePayModeList";
            tabPagePayModeList.Padding = new Padding(3);
            tabPagePayModeList.Size = new Size(662, 215);
            tabPagePayModeList.TabIndex = 0;
            tabPagePayModeList.Text = "Pay Mode List";
            // 
            // tabPageModelDetail
            // 
            tabPageModelDetail.Controls.Add(BtnCancel);
            tabPageModelDetail.Controls.Add(BtnSave);
            tabPageModelDetail.Controls.Add(label5);
            tabPageModelDetail.Controls.Add(label4);
            tabPageModelDetail.Controls.Add(label3);
            tabPageModelDetail.Controls.Add(TxtPayModeObservation);
            tabPageModelDetail.Controls.Add(TxtPayModeName);
            tabPageModelDetail.Controls.Add(TxtPayModeId);
            tabPageModelDetail.Location = new Point(4, 24);
            tabPageModelDetail.Name = "tabPageModelDetail";
            tabPageModelDetail.Padding = new Padding(3);
            tabPageModelDetail.Size = new Size(662, 248);
            tabPageModelDetail.TabIndex = 1;
            tabPageModelDetail.Text = "Pay Mode Detail";
            tabPageModelDetail.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 12);
            label2.Name = "label2";
            label2.Size = new Size(99, 15);
            label2.TabIndex = 0;
            label2.Text = "Search Pay Mode";
            // 
            // TxtSearch
            // 
            TxtSearch.Location = new Point(10, 31);
            TxtSearch.Name = "TxtSearch";
            TxtSearch.PlaceholderText = "Data to Search";
            TxtSearch.Size = new Size(428, 23);
            TxtSearch.TabIndex = 1;
            // 
            // BtnSearch
            // 
            BtnSearch.Image = Properties.Resources.cancel;
            BtnSearch.Location = new Point(456, 13);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(35, 41);
            BtnSearch.TabIndex = 2;
            BtnSearch.UseVisualStyleBackColor = true;
            // 
            // DgPayMode
            // 
            DgPayMode.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgPayMode.Location = new Point(10, 59);
            DgPayMode.Name = "DgPayMode";
            DgPayMode.Size = new Size(481, 150);
            DgPayMode.TabIndex = 3;
            // 
            // BtnNew
            // 
            BtnNew.Image = Properties.Resources._new;
            BtnNew.Location = new Point(515, 29);
            BtnNew.Name = "BtnNew";
            BtnNew.Size = new Size(139, 40);
            BtnNew.TabIndex = 4;
            BtnNew.UseVisualStyleBackColor = true;
            // 
            // BtnEdit
            // 
            BtnEdit.Image = Properties.Resources.edit;
            BtnEdit.Location = new Point(515, 75);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(139, 40);
            BtnEdit.TabIndex = 5;
            BtnEdit.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            BtnDelete.Image = Properties.Resources.delete;
            BtnDelete.Location = new Point(515, 121);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(139, 40);
            BtnDelete.TabIndex = 6;
            BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnClose
            // 
            BtnClose.Image = Properties.Resources.cerrar;
            BtnClose.Location = new Point(515, 167);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(139, 40);
            BtnClose.TabIndex = 7;
            BtnClose.UseVisualStyleBackColor = true;
            // 
            // TxtPayModeId
            // 
            TxtPayModeId.Location = new Point(14, 31);
            TxtPayModeId.Name = "TxtPayModeId";
            TxtPayModeId.Size = new Size(240, 23);
            TxtPayModeId.TabIndex = 0;
            // 
            // TxtPayModeName
            // 
            TxtPayModeName.Location = new Point(16, 77);
            TxtPayModeName.Name = "TxtPayModeName";
            TxtPayModeName.Size = new Size(238, 23);
            TxtPayModeName.TabIndex = 1;
            // 
            // TxtPayModeObservation
            // 
            TxtPayModeObservation.Location = new Point(16, 120);
            TxtPayModeObservation.Multiline = true;
            TxtPayModeObservation.Name = "TxtPayModeObservation";
            TxtPayModeObservation.Size = new Size(238, 57);
            TxtPayModeObservation.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 13);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 3;
            label3.Text = "Pay Mode Id";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 59);
            label4.Name = "label4";
            label4.Size = new Size(95, 15);
            label4.TabIndex = 4;
            label4.Text = "Pay Mode Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 102);
            label5.Name = "label5";
            label5.Size = new Size(127, 15);
            label5.TabIndex = 5;
            label5.Text = "Pay Mode Observation";
            // 
            // BtnSave
            // 
            BtnSave.Image = Properties.Resources.save;
            BtnSave.Location = new Point(45, 195);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(72, 45);
            BtnSave.TabIndex = 6;
            BtnSave.UseVisualStyleBackColor = true;
            // 
            // BtnCancel
            // 
            BtnCancel.Image = Properties.Resources.cancel;
            BtnCancel.Location = new Point(147, 195);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(72, 45);
            BtnCancel.TabIndex = 7;
            BtnCancel.UseVisualStyleBackColor = true;
            // 
            // PayModeView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(670, 376);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "PayModeView";
            Text = "PayModeView";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPagePayModeList.ResumeLayout(false);
            tabPagePayModeList.PerformLayout();
            tabPageModelDetail.ResumeLayout(false);
            tabPageModelDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgPayMode).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private TabControl tabControl1;
        private TabPage tabPagePayModeList;
        private TabPage tabPageModelDetail;
        private Label label2;
        private TextBox TxtSearch;
        private Button BtnSearch;
        private DataGridView DgPayMode;
        private Button BtnClose;
        private Button BtnDelete;
        private Button BtnEdit;
        private Button BtnNew;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox TxtPayModeObservation;
        private TextBox TxtPayModeName;
        private TextBox TxtPayModeId;
        private Button BtnCancel;
        private Button BtnSave;
    }
}