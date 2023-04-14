﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf12_notepad
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = false; // 여러 파일 선택 안되도록 하는 것

            if ( dialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = dialog.FileName;
                TxtPath.Text = fileName;

                FileStream stream = null;
                StreamReader reader = null;

                try
                {
                    stream = new FileStream(fileName, FileMode.Open, FileAccess.Read); // FileStream 쓰면 좀 더 다양한 옵션처리 가능
                    reader = new StreamReader(stream);

                    // 전부 다 읽어오기
                    RtbEditor.Text = reader.ReadToEnd();
                }
                catch(Exception ex)
                {
                    MessageBox.Show($"오류 {ex.Message}", "심플 메모장", MessageBoxButtons.OK, MessageBoxIcon.Error );
                }
                finally
                {
                    reader.Close();
                    stream.Close(); // 오류 나든 안나든 닫아줘야함
                }
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            string fileName = TxtPath.Text;

            FileStream stream = null;
            StreamWriter writer = null;

            try
            {
                stream = new FileStream(fileName, FileMode.Truncate, FileAccess.Write); // Truncate 안쓰면 기존 저장내용 반복저장됨 
                writer = new StreamWriter(stream, Encoding.UTF8);

                writer.WriteLine(RtbEditor.Text); // 리치텍스트박스의 내용을 씀
                writer.Flush(); // 버퍼이ㅡ 데이터를 해당 스트림에 전송

                MessageBox.Show("저장되었습니다", "심플메모장", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show($"오류 {ex.Message}", "심플 메모장", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                writer.Close();
                stream.Close();
            }
        }
    }
}