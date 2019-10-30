namespace DataGridViewTest
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataPicker_btn = new System.Windows.Forms.Button();
            this.excelOutput_btn = new System.Windows.Forms.Button();
            this.check_btn = new System.Windows.Forms.Button();
            this.check_txt = new System.Windows.Forms.TextBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.CLBtest_tb = new System.Windows.Forms.Button();
            this.CLBSet_bt = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.message_txt = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.modelDataGridView = new System.Windows.Forms.DataGridView();
            this.button8 = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modelDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 21;
            this.dataGridView1.Size = new System.Drawing.Size(441, 126);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 138);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "データ取得ボタン";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 158);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(168, 20);
            this.comboBox1.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(194, 158);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "データ取得ボタン";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(6, 184);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(168, 19);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // dataPicker_btn
            // 
            this.dataPicker_btn.Location = new System.Drawing.Point(194, 184);
            this.dataPicker_btn.Name = "dataPicker_btn";
            this.dataPicker_btn.Size = new System.Drawing.Size(115, 23);
            this.dataPicker_btn.TabIndex = 5;
            this.dataPicker_btn.Text = "データ取得ボタン";
            this.dataPicker_btn.UseVisualStyleBackColor = true;
            this.dataPicker_btn.Click += new System.EventHandler(this.dataPicker_btn_Click);
            // 
            // excelOutput_btn
            // 
            this.excelOutput_btn.Location = new System.Drawing.Point(194, 213);
            this.excelOutput_btn.Name = "excelOutput_btn";
            this.excelOutput_btn.Size = new System.Drawing.Size(115, 23);
            this.excelOutput_btn.TabIndex = 6;
            this.excelOutput_btn.Text = "データ取得ボタン";
            this.excelOutput_btn.UseVisualStyleBackColor = true;
            this.excelOutput_btn.Click += new System.EventHandler(this.excelOutput_btn_Click);
            // 
            // check_btn
            // 
            this.check_btn.Location = new System.Drawing.Point(194, 242);
            this.check_btn.Name = "check_btn";
            this.check_btn.Size = new System.Drawing.Size(115, 23);
            this.check_btn.TabIndex = 7;
            this.check_btn.Text = "データ取得ボタン";
            this.check_btn.UseVisualStyleBackColor = true;
            this.check_btn.Click += new System.EventHandler(this.check_btn_Click);
            // 
            // check_txt
            // 
            this.check_txt.Location = new System.Drawing.Point(6, 242);
            this.check_txt.Name = "check_txt";
            this.check_txt.Size = new System.Drawing.Size(168, 19);
            this.check_txt.TabIndex = 8;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(6, 294);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(168, 88);
            this.checkedListBox1.TabIndex = 9;
            // 
            // CLBtest_tb
            // 
            this.CLBtest_tb.Location = new System.Drawing.Point(194, 323);
            this.CLBtest_tb.Name = "CLBtest_tb";
            this.CLBtest_tb.Size = new System.Drawing.Size(115, 23);
            this.CLBtest_tb.TabIndex = 10;
            this.CLBtest_tb.Text = "チェックリスト取得";
            this.CLBtest_tb.UseVisualStyleBackColor = true;
            this.CLBtest_tb.Click += new System.EventHandler(this.CLBtest_tb_Click);
            // 
            // CLBSet_bt
            // 
            this.CLBSet_bt.Location = new System.Drawing.Point(194, 294);
            this.CLBSet_bt.Name = "CLBSet_bt";
            this.CLBSet_bt.Size = new System.Drawing.Size(115, 23);
            this.CLBSet_bt.TabIndex = 11;
            this.CLBSet_bt.Text = "セット";
            this.CLBSet_bt.UseVisualStyleBackColor = true;
            this.CLBSet_bt.Click += new System.EventHandler(this.CLBSet_bt_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(355, 160);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(355, 189);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 13;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(355, 218);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 14;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(194, 352);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(115, 23);
            this.button6.TabIndex = 15;
            this.button6.Text = "Gmail送信";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // message_txt
            // 
            this.message_txt.Location = new System.Drawing.Point(453, 6);
            this.message_txt.Multiline = true;
            this.message_txt.Name = "message_txt";
            this.message_txt.Size = new System.Drawing.Size(198, 126);
            this.message_txt.TabIndex = 16;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(453, 160);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(107, 52);
            this.button7.TabIndex = 17;
            this.button7.Text = "チェックBOXの状態を保存する";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(984, 467);
            this.tabControl1.TabIndex = 18;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.button7);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.message_txt);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.button6);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button5);
            this.tabPage1.Controls.Add(this.dateTimePicker1);
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.dataPicker_btn);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.excelOutput_btn);
            this.tabPage1.Controls.Add(this.CLBSet_bt);
            this.tabPage1.Controls.Add(this.check_btn);
            this.tabPage1.Controls.Add(this.CLBtest_tb);
            this.tabPage1.Controls.Add(this.check_txt);
            this.tabPage1.Controls.Add(this.checkedListBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(976, 441);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button8);
            this.tabPage2.Controls.Add(this.modelDataGridView);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(976, 441);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // modelDataGridView
            // 
            this.modelDataGridView.AllowUserToDeleteRows = false;
            this.modelDataGridView.AutoGenerateColumns = false;
            this.modelDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.modelDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.modelDataGridView.DataSource = this.modelBindingSource;
            this.modelDataGridView.Location = new System.Drawing.Point(3, 6);
            this.modelDataGridView.Name = "modelDataGridView";
            this.modelDataGridView.RowTemplate.Height = 21;
            this.modelDataGridView.Size = new System.Drawing.Size(300, 220);
            this.modelDataGridView.TabIndex = 0;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(322, 15);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(107, 52);
            this.button8.TabIndex = 18;
            this.button8.Text = "チェックBOXの状態を保存する";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IsSelected";
            this.dataGridViewTextBoxColumn1.HeaderText = "選択";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn2.HeaderText = "名前";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "age";
            this.dataGridViewTextBoxColumn3.HeaderText = "年齢";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "IsDeleted";
            this.dataGridViewTextBoxColumn4.HeaderText = "削除";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // modelBindingSource
            // 
            this.modelBindingSource.DataSource = typeof(DataGridViewTest.Model);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 467);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.modelDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button dataPicker_btn;
        private System.Windows.Forms.Button excelOutput_btn;
        private System.Windows.Forms.Button check_btn;
        private System.Windows.Forms.TextBox check_txt;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button CLBtest_tb;
        private System.Windows.Forms.Button CLBSet_bt;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox message_txt;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView modelDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.BindingSource modelBindingSource;
        private System.Windows.Forms.Button button8;
    }
}

