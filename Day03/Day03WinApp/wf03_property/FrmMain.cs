using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf03_property
{
    public partial class FirmMain : Form
    {
        Random rnd = new Random();

        public FirmMain()
        {
            InitializeComponent();
            // 생성자에는 되도록 설정 부분 넣지 말것
            // => Form_Load() 이벤트 핸들러에 작성
        }

        private void FirmMain_Load(object sender, EventArgs e)
        {
            GbxMain.Text = "컨트롤 학습";
            var fonts = FontFamily.Families.ToList(); // 내 OS에 있는 폰트 이름 다 가져오는 것
            foreach (var font in fonts)
            {
                CboFontFamily.Items.Add(font.Name);
            }
            // 글자 크기 최소값, 최대값 지정
            NudFontSize.Minimum = 5;
            NudFontSize.Maximum = 40;

            // 텍스트박스 초기화
            TxtResult.Text = "Hello, WinForms!!";

            NudFontSize.Value = 9; // 글자체 크기 9로 지정
        }

        /// <summary>
        /// 글자 스타일, 크기, 글자체 변경해주는 메서드
        /// </summary>
        private void ChangeFontStyle()
        {
            if (CboFontFamily.SelectedIndex < 0)
            {
                CboFontFamily.SelectedIndex = 257; // default를 257번 font로(나눔고딕)
            }

            FontStyle style = FontStyle.Regular; // 기본
            if (ChkBold.Checked == true)
            {
                style |= FontStyle.Bold; // Bit연산(or)
            }
            if (ChkItalic.Checked == true)
            {
                style |= FontStyle.Italic;
            }

            decimal fontSize = NudFontSize.Value;

            TxtResult.Font = new Font((string)CboFontFamily.SelectedItem, (float)fontSize, style);
        }
        void ChangeIndent()
        {
            if (RdoNomal.Checked) // 라디오 버튼 추가
            {
                TxtResult.Text = TxtResult.Text.Trim();
            }
            else if (RdoIndent.Checked)
            {
                TxtResult.Text = "    " + TxtResult.Text;
            }
        }

        private void CboFontFamily_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeFontStyle();
        }

        private void ChkBold_CheckedChanged(object sender, EventArgs e)
        {
            ChangeFontStyle();
        }

        private void ChkItalic_CheckedChanged(object sender, EventArgs e)
        {
            ChangeFontStyle();
        }

        private void NudFontSize_ValueChanged(object sender, EventArgs e)
        {
            ChangeFontStyle();
        }

        private void TrbDummy_Scroll(object sender, EventArgs e)
        {
            PgbDummy.Value = TrbDummy.Value;
        }

        private void BtnModal_Click(object sender, EventArgs e)
        {
            Form frm = new Form() { 
                Text = "Modal Form",
                Width = 300,
                Height = 200,
                Left = 10,
                Top = 20,
                BackColor = Color.Crimson,
                StartPosition = FormStartPosition.CenterParent
            };
            frm.ShowDialog(); // 모달 방식으로 새 창 띄우기
        }

        private void BtnModaless_Click(object sender, EventArgs e)
        {
            Form frm = new Form()
            {
                Text = "Modaless Form",
                Width = 300,
                Height = 200,
                StartPosition = FormStartPosition.CenterScreen, // 모달리스는 CenterParent 사용 안됨
                BackColor = Color.GreenYellow
            };
            frm.Show(); // 모달리스 방식으로 새 창 띄우기
        }

        private void BtnMsgBox_Click(object sender, EventArgs e)
        {
            // MessageBox.Show(TxtResult.Text); // 기본 - 메세지 박스 default는 모달임
            // MessageBox.Show(TxtResult.Text, caption: "메시지창"); // 캡션 사용
            // MessageBox.Show(TxtResult.Text, "메시지창", MessageBoxButtons.YesNoCancel); // 버튼추가(캡션은 caption: 생략가능)
            //MessageBox.Show(TxtResult.Text, "메시지창", 
            //                MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Warning);    // 아이콘 추가
            // -- 여기까지는 기본으로 많이 사용!!! 알고 있어야 함

            MessageBox.Show(TxtResult.Text, "메시지창", MessageBoxButtons.YesNo, MessageBoxIcon.Warning,
                            MessageBoxDefaultButton.Button2); // 기본 포커스 버튼 설정
            //MessageBox.Show(TxtResult.Text, "메시지창", MessageBoxButtons.YesNo, MessageBoxIcon.Warning,
            //                MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign); // 글자 오른쪽 정렬
        }

        private void BtnAddRute_Click(object sender, EventArgs e)
        {
            TrvDummy.Nodes.Add(rnd.Next(45).ToString());
        }

        private void BtnAddChild_Click(object sender, EventArgs e)
        {
            if(TrvDummy.SelectedNode != null)
            {
                TrvDummy.SelectedNode.Nodes.Add(rnd.Next(50, 100).ToString());
                TrvDummy.SelectedNode.Expand(); // 트리 노드 하위것 펼쳐주기(반대는 .Collapse)
                TreeToList();
            }
        }

        void TreeToList()
        {
            LsvDummy.Items.Clear(); // 리스트뷰, 트리뷰 모든 아이템 제거하고 초기화하는 메서드
            foreach (TreeNode item in TrvDummy.Nodes)                
            {
                TreeToList(item);
            }
        }

        private void TreeToList(TreeNode item)
        {
            LsvDummy.Items.Add(new ListViewItem(new[] { item.Text, item.FullPath.ToString() }));

            foreach (TreeNode node in item.Nodes)
            {
                TreeToList(node); //재귀호출
            }
        }

        private void RdoNomal_CheckedChanged(object sender, EventArgs e)
        {
            ChangeIndent();
        }

        private void RdoIndent_CheckedChanged(object sender, EventArgs e)
        {
            ChangeIndent();
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            PcbDummy.Image = Bitmap.FromFile("cat.png");
        }

        private void PcbCummy_Click(object sender, EventArgs e)
        {
            if (PcbDummy.SizeMode == PictureBoxSizeMode.Normal)
            {
                PcbDummy.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                PcbDummy.SizeMode = PictureBoxSizeMode.Normal;
            }
        }
    }
}
