using System;
using System.Data;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace DataGridViewTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //initDGV1();
            initDGV2();

            comboBox1.Items.Add("コンボ1");
            comboBox1.Items.Add("コンボ2");
            comboBox1.Items.Add("コンボ3");
        }

        private void dataGridView1_SortCompare(object sender, DataGridViewSortCompareEventArgs e)
        {
            // rowIndex：ソート対象外とする行インデックス
            int rowIndex = 0;
            if ((rowIndex == e.RowIndex1) || (rowIndex == e.RowIndex2))
            {
                e.Handled = true;
            }
        }

        private void dataGridView1_Sorted(object sender, EventArgs e)
        {
            // rowIndex：ソート対象外とする行インデックス
            //DataTable dt = ((DataRowView)dataGridView1.Rows[0].DataBoundItem).DataView.Table;
            //int index = dt.Rows.IndexOf(dt.AsEnumerable().Where(a => a.Field<string>(0) == "Total").FirstOrDefault());

            //dataGridView1.Rows.InsertCopy(index, 0);
            //if ((rowIndex == e.RowIndex1) || (rowIndex == e.RowIndex2))
            //{
            //    e.Handled = true;
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.EndEdit();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                Console.WriteLine(row.Cells[0].Value + "" + "" + row.Cells[1].Value + "" + "" + row.Cells[2].Value);
            }
            //特定の値取得
            Console.WriteLine(dataGridView1.Rows[2].Cells[1].Value);
        }

        private void initDGV1()
        {
            DataTable dt = new DataTable();
            DataColumn col1 = new DataColumn("columns", typeof(string));
            DataColumn col2 = new DataColumn("04/02", typeof(int));
            DataColumn col3 = new DataColumn("04/03", typeof(int));
            dt.Columns.Add(col1);
            dt.Columns.Add(col2);
            dt.Columns.Add(col3);


            DataRow dr1 = dt.NewRow();
            DataRow dr2 = dt.NewRow();
            DataRow dr3 = dt.NewRow();
            DataRow dr4 = dt.NewRow();
            dr1[0] = "Total";
            dr1[1] = 1;
            dr1[2] = 10;
            dr2[0] = "割れ";
            dr2[1] = 5;
            dr2[2] = 5;
            dr3[0] = "へこみ";
            dr3[1] = 10;
            dr3[2] = 1;
            dr4[0] = "傷";
            dr4[1] = 15;
            dr4[2] = 8;
            dt.Rows.Add(dr1);
            dt.Rows.Add(dr2);
            dt.Rows.Add(dr3);
            dt.Rows.Add(dr4);

            dataGridView1.DataSource = dt;
        }

        private void initDGV2()
        {
            DataTable dt = new DataTable();
            DataColumn col1 = new DataColumn("columns", typeof(string));
            DataColumn col2 = new DataColumn("04/02", typeof(int));
            DataColumn col3 = new DataColumn("04/03", typeof(string));

            dt.Columns.Add(col1);
            dt.Columns.Add(col2);
            dt.Columns.Add(col3);


            DataRow dr1 = dt.NewRow();
            DataRow dr2 = dt.NewRow();
            DataRow dr3 = dt.NewRow();
            DataRow dr4 = dt.NewRow();
            dr1[0] = "Total";
            dr1[1] = 1;
            dr2[0] = "割れ";
            dr2[1] = 5;
            dr3[0] = "へこみ";
            dr3[1] = 10;
            dr4[0] = "傷";
            dr4[1] = 15;
            dt.Rows.Add(dr1);
            dt.Rows.Add(dr2);
            dt.Rows.Add(dr3);
            dt.Rows.Add(dr4);

            dataGridView1.DataSource = dt;


            DataGridViewComboBoxColumn comboboxCol = new DataGridViewComboBoxColumn();
            comboboxCol.Items.Add("コンボ1");
            comboboxCol.Items.Add("コンボ2");
            comboboxCol.Items.Add("コンボ3");
            //DataGridView1に現在存在しているWeek列と
            //　今作成したDataGridViewComboBoxColumnを入れ替える
            //表示する列の名前を設定する
            comboboxCol.DataPropertyName = dataGridView1.Columns["04/03"].DataPropertyName;
            //以下のようにしても同じ
            //column.DataPropertyName = "Week";
            //現在Week列が存在している位置に挿入する
            dataGridView1.Columns.Insert(dataGridView1.Columns["04/03"].Index, comboboxCol);
            //今までのWeek列を削除する
            dataGridView1.Columns.Remove("04/03");
            //挿入した列の名前を「Week」とする
            comboboxCol.Name = "Week";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Console.WriteLine(comboBox1.SelectedText);
            //Console.WriteLine(comboBox1.SelectedValue);
            Console.WriteLine(comboBox1.SelectedItem);

        }

        private void dataPicker_btn_Click(object sender, EventArgs e)
        {
            Console.WriteLine(dateTimePicker1.Value.ToString("yyyy-MM-ddTHH:MM:ss+8:00"));
        }

        private void excelOutput_btn_Click(object sender, EventArgs e)
        {
            string saveFolder = @"D:\90_projects\VisualStudio2017\DataGridViewTest"; 

            // Excel操作用オブジェクト
            Excel.Application excel = new Excel.Application();
            excel.Visible = false;
            Excel.Workbooks workbooks = excel.Workbooks;
            Excel.Workbook workbook = workbooks.Open(Path.GetFullPath(@"D:\90_projects\VisualStudio2017\DataGridViewTest\templeteTest.xltx"));
            Excel.Sheets sheets = workbook.Worksheets;
            Excel.Worksheet worksheet = sheets[1] as Excel.Worksheet;

            //セル代入
            worksheet.get_Range("A1").Value = 10;

            //保存
            workbook.SaveAs(saveFolder + "\\" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".xlsx");

            //終了処理
            workbook.Close();
            workbooks.Close();
            excel.Quit();
            Marshal.ReleaseComObject(excel);
            worksheet = null;
            sheets = null;
            workbook = null;
            workbooks = null;
            excel = null;            
            GC.Collect();
        }
    }
}
