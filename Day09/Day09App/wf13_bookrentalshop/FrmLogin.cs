using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

// 편집 - 고급 - 문서서식 누르면 줄바꿈, 들여쓰기 등등 다 맞춰줌!!

namespace wf13_bookrentalshop
{
    public partial class FrmLogin : Form
    {
        private bool isLogined = false; // 로그인 성공했는지 물어보는 변수(bool 로 true/false 확인하는것)


        public FrmLogin()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            isLogined = LoginProcess(); // 로그인 성공해야만 true가 됨

            if (isLogined) this.Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            // Application.Exit(); 간단하지만 동작 잘 안먹힐때가 많음
            Environment.Exit(0); // 가장 완벽한 프로그램 종료 메서드
        }

        private void FrmLogin_FormClosed(object sender, FormClosedEventArgs e) // 없으면 X 버튼이나 Alt+F4 눌렀을때 메인폼 나타남
        {
            if (isLogined != true) // 로그인 안됐을 때 창 닫으면 프로그램 모두 종료
            {
                Environment.Exit(0);
            }

        }

        private void TxtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) // 엔터키를 누르면(13이 엔터키)
            {
               BtnLogin_Click(sender, e); // 버튼 클릭 이벤트 핸들러 호출
            }
        }

        // DB userTbl에서 정보 확인 후 로그인 처리
        private bool LoginProcess()
        {
            if (string.IsNullOrEmpty(TxtUserId.Text)) // Validation check(입력검증)
            {
                MessageBox.Show("유저아이디를 입력하세요", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(TxtPassword.Text)) // Validation check(입력검증)
            {
                MessageBox.Show("패스워드를 입력하세요", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            string strUserId = "";
            string strPassword = "";
            try
            {
               // string connectionString = "Server=localhost;Port=3306;Database=Bookrentalshop;Uid=root;Pwd=12345";
               // 이렇게 쓰면 일일이 바꿔줘야해서 Helpers 만든거
                
                // DB처리
                using(MySqlConnection conn = new MySqlConnection(Helpers.Commons.ConnString)) // 이렇게 쓰면 conn.Close(); 필요 없음
                {
                    conn.Open();
                    #region < DB 쿼리를 위한 구성 >
                    string selQuery = @"SELECT userId
	                                          , password
                                           FROM usertbl
                                          WHERE userID = @userID
                                            AND password = @password";
                    MySqlCommand selCmd = new MySqlCommand(selQuery, conn);

                    // @userID, @password 파라미터 할당
                    MySqlParameter prmUserID = new MySqlParameter("@userID", TxtUserId.Text);
                    MySqlParameter prmPassword = new MySqlParameter("@password", TxtPassword.Text);
                    selCmd.Parameters.Add(prmUserID);
                    selCmd.Parameters.Add(prmPassword);
                    #endregion

                    MySqlDataReader reader = selCmd.ExecuteReader(); // 실행한 다음에 userId, password 받아옴
                    if (reader.Read())
                    {
                        strUserId = reader["userId"] != null ? reader["userId"].ToString() : "-";
                        strPassword = reader["password"] != null ? reader["password"].ToString() : "--";
                        return true;
                    }
                    else
                    {
                        MessageBox.Show($"로그인 정보가 없습니다", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }

                }
                 // MessageBox.Show($"{strUserId} / {strPassword}"); 입력 제대로 받는지 확인하는거라 주석처리
            }
            catch(Exception ex)
            {
                MessageBox.Show($"비정상적 오류 : {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void TxtUserId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                TxtPassword.Focus();
            }
        }
    }
}
