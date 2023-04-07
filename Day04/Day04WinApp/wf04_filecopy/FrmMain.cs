using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf04_filecopy
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnFindSource_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            var result = dialog.ShowDialog(); // 모달창
            if (result == DialogResult.OK)
            {
                TxtSource.Text = dialog.FileName;
            }
        }

        private void BtnFindTarget_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            var result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                TxtTarget.Text = dialog.FileName;
            }
        }

        // 일반적인 동기식 파일복사
        private void BtnSyncCopy_Click(object sender, EventArgs e)
        {
            long totalCopied = CopySync(TxtSource.Text, TxtTarget.Text);
        }

        private long CopySync(string fromFile, string toFile)
        {
            BtnAsyncCopy.Enabled = false; //비동기 복사버튼 비활성화
            long totalCopied = 0;

            using (FileStream fromStream = new FileStream(fromFile, FileMode.Open)) // 원본파일 열기
            {
                using(FileStream toStream = new FileStream(toFile, FileMode.Create)) // 타겟파일 생성
                {
                    byte[] buffer = new byte[1024 * 1024]; // 1MByte 크기의 buffer(저장공간) 만들어주는 것
                    int nRead = 0;
                    while((nRead = fromStream.Read(buffer, 0, buffer.Length)) != 0) // 0이면 읽을게 없어서 False
                    {
                        toStream.Write(buffer, 0, nRead);
                        totalCopied += nRead;

                        //프로그래스바에 진행사항 표시
                        PgbCopy.Value = (int)((double)totalCopied / (double)fromStream.Length) * PgbCopy.Maximum;
                    }
                }
            }

            BtnAsyncCopy.Enabled = true;
            return totalCopied;
        }

        // 비동기는 호출할 때 await 키워드 - 구현할 때는 async 사용
        private async Task<long> CopyAsync(string fromFile, string toFile) // async라서 그냥 long 아닌 Task<long> 해주는 것
        {
            BtnSyncCopy.Enabled = false; // 동기 복사버튼 비활성화
            long totalCopied = 0;

            using (FileStream fromStream = new FileStream(fromFile, FileMode.Open)) // 원본파일 열기
            {
                using (FileStream toStream = new FileStream(toFile, FileMode.Create)) // 타겟파일 생성
                {
                    byte[] buffer = new byte[1024 * 1024]; // 1MByte 크기의 buffer(저장공간) 만들어주는 것
                    int nRead = 0;
                    while ((nRead = await fromStream.ReadAsync(buffer, 0, buffer.Length)) != 0) // 0이면 읽을게 없어서 False
                    {
                        await toStream.WriteAsync(buffer, 0, nRead);
                        totalCopied += nRead;

                        //프로그래스바에 진행사항 표시
                        PgbCopy.Value = (int)((double)totalCopied / (double)fromStream.Length) * PgbCopy.Maximum;
                    }
                }
            }

            BtnAsyncCopy.Enabled = true;
            return totalCopied;
        }

        private async void BtnAsyncCopy_Click(object sender, EventArgs e)
        {
            long totalCopied = await CopyAsync(TxtSource.Text, TxtTarget.Text);

        }

        
    }
}
