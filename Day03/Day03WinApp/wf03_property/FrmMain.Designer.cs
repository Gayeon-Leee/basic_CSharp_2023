namespace wf03_property
{
    partial class FirmMain
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FirmMain));
            this.GbxMain = new System.Windows.Forms.GroupBox();
            this.RdoIndent = new System.Windows.Forms.RadioButton();
            this.RdoNomal = new System.Windows.Forms.RadioButton();
            this.CboFontFamily = new System.Windows.Forms.ComboBox();
            this.TxtResult = new System.Windows.Forms.TextBox();
            this.NudFontSize = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.ChkItalic = new System.Windows.Forms.CheckBox();
            this.ChkBold = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PgbDummy = new System.Windows.Forms.ProgressBar();
            this.TrbDummy = new System.Windows.Forms.TrackBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnMsgBox = new System.Windows.Forms.Button();
            this.BtnModaless = new System.Windows.Forms.Button();
            this.BtnModal = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BtnAddRute = new System.Windows.Forms.Button();
            this.BtnAddChild = new System.Windows.Forms.Button();
            this.LsvDummy = new System.Windows.Forms.ListView();
            this.TrvDummy = new System.Windows.Forms.TreeView();
            this.groupbox4 = new System.Windows.Forms.GroupBox();
            this.BtnLoad = new System.Windows.Forms.Button();
            this.PcbDummy = new System.Windows.Forms.PictureBox();
            this.GbxMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudFontSize)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrbDummy)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupbox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcbDummy)).BeginInit();
            this.SuspendLayout();
            // 
            // GbxMain
            // 
            this.GbxMain.Controls.Add(this.RdoIndent);
            this.GbxMain.Controls.Add(this.RdoNomal);
            this.GbxMain.Controls.Add(this.CboFontFamily);
            this.GbxMain.Controls.Add(this.TxtResult);
            this.GbxMain.Controls.Add(this.NudFontSize);
            this.GbxMain.Controls.Add(this.label2);
            this.GbxMain.Controls.Add(this.ChkItalic);
            this.GbxMain.Controls.Add(this.ChkBold);
            this.GbxMain.Controls.Add(this.label1);
            this.GbxMain.Location = new System.Drawing.Point(12, 12);
            this.GbxMain.Name = "GbxMain";
            this.GbxMain.Size = new System.Drawing.Size(359, 189);
            this.GbxMain.TabIndex = 0;
            this.GbxMain.TabStop = false;
            this.GbxMain.Text = "컨트롤 학습";
            // 
            // RdoIndent
            // 
            this.RdoIndent.AutoSize = true;
            this.RdoIndent.Location = new System.Drawing.Point(278, 54);
            this.RdoIndent.Name = "RdoIndent";
            this.RdoIndent.Size = new System.Drawing.Size(69, 18);
            this.RdoIndent.TabIndex = 4;
            this.RdoIndent.Text = "들여쓰기";
            this.RdoIndent.UseVisualStyleBackColor = true;
            this.RdoIndent.CheckedChanged += new System.EventHandler(this.RdoIndent_CheckedChanged);
            // 
            // RdoNomal
            // 
            this.RdoNomal.AutoSize = true;
            this.RdoNomal.Checked = true;
            this.RdoNomal.Location = new System.Drawing.Point(230, 54);
            this.RdoNomal.Name = "RdoNomal";
            this.RdoNomal.Size = new System.Drawing.Size(47, 18);
            this.RdoNomal.TabIndex = 4;
            this.RdoNomal.TabStop = true;
            this.RdoNomal.Text = "일반";
            this.RdoNomal.UseVisualStyleBackColor = true;
            this.RdoNomal.CheckedChanged += new System.EventHandler(this.RdoNomal_CheckedChanged);
            // 
            // CboFontFamily
            // 
            this.CboFontFamily.FormattingEnabled = true;
            this.CboFontFamily.Location = new System.Drawing.Point(91, 25);
            this.CboFontFamily.Name = "CboFontFamily";
            this.CboFontFamily.Size = new System.Drawing.Size(120, 22);
            this.CboFontFamily.TabIndex = 1;
            this.CboFontFamily.SelectedIndexChanged += new System.EventHandler(this.CboFontFamily_SelectedIndexChanged);
            // 
            // TxtResult
            // 
            this.TxtResult.Location = new System.Drawing.Point(23, 83);
            this.TxtResult.Multiline = true;
            this.TxtResult.Name = "TxtResult";
            this.TxtResult.Size = new System.Drawing.Size(308, 88);
            this.TxtResult.TabIndex = 5;
            // 
            // NudFontSize
            // 
            this.NudFontSize.Location = new System.Drawing.Point(91, 54);
            this.NudFontSize.Name = "NudFontSize";
            this.NudFontSize.Size = new System.Drawing.Size(120, 21);
            this.NudFontSize.TabIndex = 4;
            this.NudFontSize.ValueChanged += new System.EventHandler(this.NudFontSize_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 14);
            this.label2.TabIndex = 4;
            this.label2.Text = "글자크기";
            // 
            // ChkItalic
            // 
            this.ChkItalic.AutoSize = true;
            this.ChkItalic.Location = new System.Drawing.Point(278, 27);
            this.ChkItalic.Name = "ChkItalic";
            this.ChkItalic.Size = new System.Drawing.Size(59, 18);
            this.ChkItalic.TabIndex = 3;
            this.ChkItalic.Text = "이탤릭";
            this.ChkItalic.UseVisualStyleBackColor = true;
            this.ChkItalic.CheckedChanged += new System.EventHandler(this.ChkItalic_CheckedChanged);
            // 
            // ChkBold
            // 
            this.ChkBold.AutoSize = true;
            this.ChkBold.Location = new System.Drawing.Point(230, 27);
            this.ChkBold.Name = "ChkBold";
            this.ChkBold.Size = new System.Drawing.Size(48, 18);
            this.ChkBold.TabIndex = 2;
            this.ChkBold.Text = "볼드";
            this.ChkBold.UseVisualStyleBackColor = true;
            this.ChkBold.CheckedChanged += new System.EventHandler(this.ChkBold_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "글자체";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PgbDummy);
            this.groupBox1.Controls.Add(this.TrbDummy);
            this.groupBox1.Location = new System.Drawing.Point(12, 207);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(359, 115);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "트랙바 및 진행바";
            // 
            // PgbDummy
            // 
            this.PgbDummy.Location = new System.Drawing.Point(31, 71);
            this.PgbDummy.Maximum = 20;
            this.PgbDummy.Name = "PgbDummy";
            this.PgbDummy.Size = new System.Drawing.Size(293, 23);
            this.PgbDummy.TabIndex = 7;
            // 
            // TrbDummy
            // 
            this.TrbDummy.Location = new System.Drawing.Point(23, 20);
            this.TrbDummy.Maximum = 20;
            this.TrbDummy.Name = "TrbDummy";
            this.TrbDummy.Size = new System.Drawing.Size(308, 45);
            this.TrbDummy.TabIndex = 6;
            this.TrbDummy.Scroll += new System.EventHandler(this.TrbDummy_Scroll);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnMsgBox);
            this.groupBox2.Controls.Add(this.BtnModaless);
            this.groupBox2.Controls.Add(this.BtnModal);
            this.groupBox2.Location = new System.Drawing.Point(12, 328);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(359, 66);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "모달/리스와 메세지창";
            // 
            // BtnMsgBox
            // 
            this.BtnMsgBox.Location = new System.Drawing.Point(233, 21);
            this.BtnMsgBox.Name = "BtnMsgBox";
            this.BtnMsgBox.Size = new System.Drawing.Size(98, 30);
            this.BtnMsgBox.TabIndex = 10;
            this.BtnMsgBox.Text = "MessageBox";
            this.BtnMsgBox.UseVisualStyleBackColor = true;
            this.BtnMsgBox.Click += new System.EventHandler(this.BtnMsgBox_Click);
            // 
            // BtnModaless
            // 
            this.BtnModaless.Location = new System.Drawing.Point(128, 21);
            this.BtnModaless.Name = "BtnModaless";
            this.BtnModaless.Size = new System.Drawing.Size(98, 30);
            this.BtnModaless.TabIndex = 9;
            this.BtnModaless.Text = "Modaless";
            this.BtnModaless.UseVisualStyleBackColor = true;
            this.BtnModaless.Click += new System.EventHandler(this.BtnModaless_Click);
            // 
            // BtnModal
            // 
            this.BtnModal.Location = new System.Drawing.Point(23, 21);
            this.BtnModal.Name = "BtnModal";
            this.BtnModal.Size = new System.Drawing.Size(98, 30);
            this.BtnModal.TabIndex = 8;
            this.BtnModal.Text = "Modal";
            this.BtnModal.UseVisualStyleBackColor = true;
            this.BtnModal.Click += new System.EventHandler(this.BtnModal_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BtnAddRute);
            this.groupBox3.Controls.Add(this.BtnAddChild);
            this.groupBox3.Controls.Add(this.LsvDummy);
            this.groupBox3.Controls.Add(this.TrvDummy);
            this.groupBox3.Location = new System.Drawing.Point(377, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(405, 189);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "트리뷰 / 리스트뷰";
            // 
            // BtnAddRute
            // 
            this.BtnAddRute.Location = new System.Drawing.Point(44, 150);
            this.BtnAddRute.Name = "BtnAddRute";
            this.BtnAddRute.Size = new System.Drawing.Size(75, 23);
            this.BtnAddRute.TabIndex = 13;
            this.BtnAddRute.Text = "루트추가";
            this.BtnAddRute.UseVisualStyleBackColor = true;
            this.BtnAddRute.Click += new System.EventHandler(this.BtnAddRute_Click);
            // 
            // BtnAddChild
            // 
            this.BtnAddChild.Location = new System.Drawing.Point(125, 150);
            this.BtnAddChild.Name = "BtnAddChild";
            this.BtnAddChild.Size = new System.Drawing.Size(75, 23);
            this.BtnAddChild.TabIndex = 14;
            this.BtnAddChild.Text = "자식추가";
            this.BtnAddChild.UseVisualStyleBackColor = true;
            this.BtnAddChild.Click += new System.EventHandler(this.BtnAddChild_Click);
            // 
            // LsvDummy
            // 
            this.LsvDummy.HideSelection = false;
            this.LsvDummy.Location = new System.Drawing.Point(206, 20);
            this.LsvDummy.Name = "LsvDummy";
            this.LsvDummy.Size = new System.Drawing.Size(193, 124);
            this.LsvDummy.TabIndex = 12;
            this.LsvDummy.UseCompatibleStateImageBehavior = false;
            // 
            // TrvDummy
            // 
            this.TrvDummy.Location = new System.Drawing.Point(6, 20);
            this.TrvDummy.Name = "TrvDummy";
            this.TrvDummy.Size = new System.Drawing.Size(194, 124);
            this.TrvDummy.TabIndex = 11;
            // 
            // groupbox4
            // 
            this.groupbox4.Controls.Add(this.PcbDummy);
            this.groupbox4.Controls.Add(this.BtnLoad);
            this.groupbox4.Location = new System.Drawing.Point(377, 207);
            this.groupbox4.Name = "groupbox4";
            this.groupbox4.Size = new System.Drawing.Size(409, 187);
            this.groupbox4.TabIndex = 4;
            this.groupbox4.TabStop = false;
            this.groupbox4.Text = "픽쳐박스";
            // 
            // BtnLoad
            // 
            this.BtnLoad.Location = new System.Drawing.Point(345, 20);
            this.BtnLoad.Name = "BtnLoad";
            this.BtnLoad.Size = new System.Drawing.Size(54, 23);
            this.BtnLoad.TabIndex = 0;
            this.BtnLoad.Text = "로드";
            this.BtnLoad.UseVisualStyleBackColor = true;
            this.BtnLoad.Click += new System.EventHandler(this.BtnLoad_Click);
            // 
            // PcbDummy
            // 
            this.PcbDummy.BackColor = System.Drawing.SystemColors.ControlLight;
            this.PcbDummy.Location = new System.Drawing.Point(7, 20);
            this.PcbDummy.Name = "PcbDummy";
            this.PcbDummy.Size = new System.Drawing.Size(332, 152);
            this.PcbDummy.TabIndex = 1;
            this.PcbDummy.TabStop = false;
            this.PcbDummy.Click += new System.EventHandler(this.PcbCummy_Click);
            // 
            // FirmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(798, 406);
            this.Controls.Add(this.groupbox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GbxMain);
            this.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FirmMain";
            this.Text = "속성확인";
            this.Load += new System.EventHandler(this.FirmMain_Load);
            this.GbxMain.ResumeLayout(false);
            this.GbxMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudFontSize)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrbDummy)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupbox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PcbDummy)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GbxMain;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox ChkItalic;
        private System.Windows.Forms.CheckBox ChkBold;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtResult;
        private System.Windows.Forms.NumericUpDown NudFontSize;
        private System.Windows.Forms.ComboBox CboFontFamily;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ProgressBar PgbDummy;
        private System.Windows.Forms.TrackBar TrbDummy;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnModal;
        private System.Windows.Forms.Button BtnMsgBox;
        private System.Windows.Forms.Button BtnModaless;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListView LsvDummy;
        private System.Windows.Forms.TreeView TrvDummy;
        private System.Windows.Forms.Button BtnAddRute;
        private System.Windows.Forms.Button BtnAddChild;
        private System.Windows.Forms.RadioButton RdoIndent;
        private System.Windows.Forms.RadioButton RdoNomal;
        private System.Windows.Forms.GroupBox groupbox4;
        private System.Windows.Forms.PictureBox PcbDummy;
        private System.Windows.Forms.Button BtnLoad;
    }
}

