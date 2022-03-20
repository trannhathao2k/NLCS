using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;
using System.Collections;

namespace NLCS_Euler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btn_themcanh.Enabled = false;
            btn_xoacanh.Enabled = true;
        }

        char[,] matrix = new char[15, 15];

        //Tạo ma trận button
        void LoadMatrix(int n)
        {
            //oldBtn để ghi lại button, dùng cho việc tạo button tiếp theo
            Button oldBtn = new Button() { Width = 0, Height = 0, Location = new Point(0, 0) };
            int t = 1;

            //Hai vòng lặp để thêm Button
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Button btn = new Button() {Width = 30, Height = 30 };
                    btn.Location = new Point(oldBtn.Location.X + oldBtn.Width, oldBtn.Location.Y);
                    if (i >= j)
                    {
                        //Hai đỉnh giống nhau sẽ thêm dấu "-"
                        btn.Text = "-";
                        matrix[i, j] = '0';
                    }
                    else
                    {
                        //Mặc định sẽ là 0
                        btn.Text = "0";
                        matrix[i, j] = '0';
                    }

                    //Đặt tên cho button theo thứ tự tăng dần
                    string str = "button" + t;
                    btn.Name = str;
                    //Bắt sự kiện cho button
                    btn.Click += new System.EventHandler(button);

                    //Thêm button mới vào ma trận
                    gbox_matran.Controls.Add(btn);

                    oldBtn = btn;
                    t++;
                }
                oldBtn = new Button() { Width = 0, Height = 0, Location = new Point(0, oldBtn.Location.Y + 30) };
            }
        }

        //Cột ngang các đỉnh của ma trận
        void LoadTextNgang(int n)
        {
            Button oldBtn = new Button() { Width = 30, Height = 30, Location = new Point(0, 0) };
            oldBtn.Text = 1.ToString();
            gbox_ngang.Controls.Add(oldBtn);
            for (int i = 2; i <= n; i++)
            {
                Button btn = new Button() { Width = 30, Height = 30 };
                btn.Location = new Point(oldBtn.Location.X + 30, oldBtn.Location.Y);
                btn.Text = i.ToString();

                gbox_ngang.Controls.Add(btn);
                oldBtn = btn;
            }
        }

        //Cột dọc các đỉnh của ma trận
        void LoadTextDoc(int n)
        {
            Button oldBtn = new Button() { Width = 30, Height = 30, Location = new Point(0, 0) };
            oldBtn.Text = 1.ToString();
            gbox_doc.Controls.Add(oldBtn);
            for (int i = 2; i <= n; i++)
            {
                Button btn = new Button() { Width = 30, Height = 30 };
                btn.Location = new Point(0, oldBtn.Location.Y + 30);
                btn.Text = i.ToString();

                gbox_doc.Controls.Add(btn);
                oldBtn = btn;
            }
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            try
            {
                //Sự kiện nhập đỉnh
                int i = int.Parse(txt_nhapdinh.Text);
                if (i > 15)
                {
                    MessageBox.Show("Số đỉnh phải nhỏ hơn hoặc bằng 15!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    gbox_matran.Controls.Clear();
                    int var;
                    var = int.Parse(txt_nhapdinh.Text);

                    LoadMatrix(var);

                    //Bỏ cột cũ và thêm cột ngang mới
                    gbox_ngang.Controls.Clear();
                    LoadTextNgang(var);
                    //Bỏ cột cũ và thêm cột dọc mới
                    gbox_doc.Controls.Clear();
                    LoadTextDoc(var);
                }
            }
            catch
            {
                MessageBox.Show("Số đã nhập không hợp lệ. Vui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //Bắt sự kiện click button
        private void button (object sender, EventArgs e)
        {
            Button btcent = (Button)sender;
            int i = 0, j = 0;//Hai cạnh của đồ thị

            int var;//Số đỉnh của đồ thị
            var = int.Parse(txt_nhapdinh.Text);
            //Chổ này chia ra để tìm x và y
            var numericPart = Regex.Match(btcent.Name, "\\d+").Value;
            int t = int.Parse(numericPart);
            // t là số thứ tự đỉnh mà ta đang click vào

            //Tìm i, j là hai cạnh của đồ thị
            if (t % var == 0)
            {
                j = t / var;
                i = t - (j - 1) * var;
            }
            else
            {
                j = t / var + 1;
                i = t - (j - 1) * var;
            }
            
            //Trường hợp Thêm cạnh
            if (btn_themcanh.Enabled == false)
            {
                if (btcent.Text == "0")
                {
                    DialogResult check_add;
                    check_add = MessageBox.Show("Bạn chắc chắn muốn thêm cạnh nối hai đỉnh " + j + " và " + i + " ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
 
                    if (check_add == DialogResult.Yes && i != j)
                    {
                        btcent.Text = "1";
                        matrix[i - 1, j - 1] = '1';
                        matrix[j - 1, i - 1] = '1';
                    }
                }
                else if (btcent.Text == "1")
                {
                    MessageBox.Show("Cạnh này đã được thêm!");
                }
                
            }
            //Trường hợp Xóa cạnh
            else if (btn_themcanh.Enabled == true){
                DialogResult check_del;
                check_del = MessageBox.Show("Bạn chắc chắn muốn xóa cạnh nối hai đỉnh " + j + " và " + i + " ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (btcent.Text == "1")
                {
                    if (check_del == DialogResult.Yes)
                    {
                        btcent.Text = "0";
                        matrix[i-1, j-1] = matrix[j-1, i-1] = '0';
                    }
                }
                else if (btcent.Text == "0"){
                    MessageBox.Show("Cạnh này chưa được thêm!");
                }
            }
        }



        private void gbox_matran_Enter(object sender, EventArgs e)
        {
            
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            btn_themcanh.Enabled = true;
            btn_xoacanh.Enabled = false;
            txt_nhapdinh.Clear();
            gbox_matran.Controls.Clear();
            gbox_ngang.Controls.Clear();
            gbox_doc.Controls.Clear();
            txt_qtr.Clear();
            txt_chutrinh.Clear();
        }

        private void bt_themcanh_Click(object sender, EventArgs e)
        {
            btn_themcanh.Enabled = false;
            btn_xoacanh.Enabled = true;
        }

        private void btn_xoacanh_Click(object sender, EventArgs e)
        {
            btn_themcanh.Enabled = true;
            btn_xoacanh.Enabled = false;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btn_timchutrinh_Click(object sender, EventArgs e)
        {
            txt_qtr.Clear();
            txt_chutrinh.Clear();
            int n = int.Parse(txt_nhapdinh.Text);
            FindEulerCircuit(n);
        }

        //-----------------------------------------------------------------------------------------------//
        //Giải thuật tìm chu trình Euler
        Stack tempPath = new Stack();
        ArrayList finalPath = new ArrayList();//để lưu trữ đường đi cuối cùng
        string[] nodeList;//để lưu trữ các nút
        int count;//đếm số đỉnh bậc lẻ

        private void GetInput(int n)
        {
            nodeList = new string[n];
            for (int i=0; i < n; i++)
            {
                nodeList[i] = (i+1).ToString();
                //i+1 là tên đỉnh của đồ thị
            }
        }

        //Hàm lấy số cạnh kết nối với đỉnh i
        private int GetDegree(int i, int n)
        {
            int j, deg = 0;
            for (j = 0; j < n; j++)
            {
                if (matrix[i, j] == '1') deg++;
            }
            return deg;
        }

        //Chỉ định root của đồ thị
        // Điều kiện 1: Nếu tất cả các nút đều có bậc chẵn thì phải có một chu trình euler
        //      Chúng ta có thể bắt đầu đường đi từ bất kỳ nút nào
        // Điều kiện 2: Nếu có đúng 2 nút có bậc lẻ,
        //      Chỉ có đường đi Euler và không có chu trình Euler.
        // Điều kiện 3: Nếu nhiều hơn 2 nút hoặc chính xác chỉ có một nút bậc lẻ
        //      Không tồn tại đường đi và chu trình Euler
        // findRoot () sẽ trả về 0 nếu không thể thực hiện được chu trình Euler
        private int FindRoot(int n)
        {
            int root = 1;
            count = 0;
            for (int i = 0; i < n; i++)
            {
                if (GetDegree(i, n) % 2 != 0)
                {
                    count++;
                    root = i;//Lưu đỉnh có bậc lẻ thành root
                }
            }
            //Nếu count không chính xác là 0 và 2 thì không tồn tại chu trình và đường đi Euler, vì vậy hãy trả về 0
            if (count != 0 && count !=2)
            {
                return 0;
            }
            else return root;//Trả về 1 trong những nút dưới dạng root, nếu không sẽ trả về mặc định là 1
        }

        //Lấy chỉ mục hiện tại của nút trong mảng nodeList [] của các nút
        private int GetIndex(string c)
        {
            int index = 0;
            while (c != nodeList[index])
                index++;
            return index;
        }

        //Để kiểm tra tất cả các đỉnh / nút lân cận có được đi qua hay không
        private Boolean AllVisited(int node, int n)
        {
            for (int l = 0; l < n; l++)
            {
                if (matrix[node, l] == '1')
                    return false;
            }
            return true;
        }

        //Tìm chu trình Euler và lưu trữ nó trong finalPath arrayList
        private void FindEuler(int root, int n)
        {
            int ind;
            tempPath.Clear();
            finalPath.Clear();
            //Đẩy root vào ngăn xếp
            string str = "Đẩy đỉnh " + (root+1) + " vào ngăn xếp.\r\n\r\nTrong khi ngăn xếp khác rỗng, thực hiện các bước:\r\n\r\n";
            txt_qtr.Text += str;
            tempPath.Push(nodeList[root]);
            while (tempPath.Count != 0)//Cho đến khi ngăn xếp rỗng
            {
                //Lấy chỉ số mảng ở trên cùng của ngăn xếp
                ind = GetIndex((string)tempPath.Peek());
                string str1 = "Lấy chỉ số mảng ở trên cùng của ngăn xếp là ";
                txt_qtr.Text += str1 + (ind+1) + ".\r\n";
                if (AllVisited(ind,n))
                {
                    //Nếu tất cả các nút liền kề đã được truy cập
                    //Xóa phần tử từ ngăn xếp và lưu trữ nó trong endpath arrayList
                    string str2 = "Tất cả các nút liền kề của " + (ind+1) + " đã được truy cập, xóa phần tử " + (ind+1) + " khỏi ngăn xếp.\r\nLưu trữ nó trong ngăn xếp chứa Chu trình, Đường đi Euler.\r\n\r\n";
                    txt_qtr.Text += str2;
                    finalPath.Add(tempPath.Pop());
                }
                else
                {
                    //Nếu có bất kỳ nút nào chưa được sử dụng, hãy đẩy nút đó vào ngăn xếp
                    //Đánh dấu cạnh đó là đã được truy cập bằng cách đánh dấu '0' trong GraphMatrix[][]
                    //Ngắt vòng lặp
                    for (int j = 0; j < n; j++)
                    {
                        if (matrix[ind, j] == '1')
                        {
                            string str3 = "Nút " + (j+1) + " chưa được sử dụng. Đẩy nó vào ngăn xếp.\r\n";
                            string str4 = "Đánh dấu cạnh nối đỉnh " + (ind+1) + " và " + (j+1) + " đã được truy cập.\r\n\r\n";
                            txt_qtr.Text += str3 + str4;
                            matrix[ind, j] = '0';
                            matrix[j, ind] = '0';
                            tempPath.Push(nodeList[j]);
                            break;
                        }
                    }
                }
            }
        }

        //Đây là chương trình chính
        public void FindEulerCircuit(int n)
        {
            //Nhận biểu diễn Đồ thị từ người dùng
            GetInput(n);
            int root = FindRoot(n);
            //findRoot() sẽ trả về 0 nếu chu trình Euler không khả thi
            //Nếu không nó sẽ trả về chỉ số mảng của đỉnh dưới dạng gốc

            txt_qtr.Text += "============================================================================================\r\n";
            string str1 = "Đề bài:\r\nTìm chu trình, đường đi Euler của đồ thị có dạng ma trận\r\n";
            txt_qtr.Text += str1;

            PrintMatrix(n);

            txt_qtr.Text += "============================================================================================\r\n";
            txt_qtr.Text += "                                             Giải                                           \r\n";
            txt_qtr.Text += "============================================================================================\r\n";

            try
            {
                if (root != 0)
                {
                    if (count != 0)
                    {
                        string str4 = "Số đỉnh bậc lẻ là 2 nên chỉ tồn tại Đường đi Euler\r\n";
                        txt_qtr.Text += str4;
                        FindEuler(root, n);
                        txt_qtr.Text += "============================================================================================\r\n";
                        string str6 = "Đường đi Euler tìm được là:\r\n";
                        txt_qtr.Text += str6;
                    }
                    else
                    {
                        string str5 = "Số đỉnh bậc lẻ là 0 nên tồn tại Chu trình Euler\r\n";
                        txt_qtr.Text += str5;
                        FindEuler(root, n);
                        txt_qtr.Text += "============================================================================================\r\n";
                        string str7 = "Chu trình Euler tìm được là:\r\n";
                        txt_qtr.Text += str7;
                    }

                    //In ra chu trình Euler
                    PrintEulerCircuit();
                }
                else
                {
                    string str3 = "Không tồn tại Chu trình Euler\r\n";
                    txt_qtr.Text += str3;
                }
            }
            catch
            {
                string str4 = "Đã xảy ra lỗi\r\n";
                txt_qtr.Text += str4;
            }       
        }

        public void PrintMatrix (int n)
        {
            string str;
            for (int i=0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    str = matrix[i, j] + " ";
                    txt_qtr.Text += str;
                }
                txt_qtr.Text += "\r\n";
            }
        }

        //In ra màn hình Chu trình Euler
        public void PrintEulerCircuit()
        {
            txt_qtr.Text += finalPath[0];
            txt_chutrinh.Text += finalPath[0];
            for (int i = 1; i < finalPath.Count; i++)
            {
                string chuoi = " -> " + finalPath[i];
                txt_qtr.Text += chuoi;
                txt_chutrinh.Text += chuoi;
            }
        }

        private void btn_dinhbd_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_inmatran_Click(object sender, EventArgs e)
        {
            
        }

        private void txt_chutrinh_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.InitialDirectory = @"C:\";
            sfd.RestoreDirectory = true;
            sfd.FileName = "*.txt";
            sfd.Filter = "txt files (*.txt)|*.txt";

            if(sfd.ShowDialog() == DialogResult.OK)
            {
                Stream fileStream = sfd.OpenFile();
                StreamWriter sw = new StreamWriter(fileStream);

                sw.Write(txt_qtr.Text);

                sw.Close();
                fileStream.Close();
            }
        }

        /*----------------------------------------------------------------------------------------------------*/
    }
}
