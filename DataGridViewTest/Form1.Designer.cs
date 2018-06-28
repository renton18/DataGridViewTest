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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 21;
            this.dataGridView1.Size = new System.Drawing.Size(441, 126);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(459, 60);
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
            this.comboBox1.Location = new System.Drawing.Point(12, 164);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(168, 20);
            this.comboBox1.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(200, 164);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "データ取得ボタン";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 190);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(168, 19);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // dataPicker_btn
            // 
            this.dataPicker_btn.Location = new System.Drawing.Point(200, 190);
            this.dataPicker_btn.Name = "dataPicker_btn";
            this.dataPicker_btn.Size = new System.Drawing.Size(115, 23);
            this.dataPicker_btn.TabIndex = 5;
            this.dataPicker_btn.Text = "データ取得ボタン";
            this.dataPicker_btn.UseVisualStyleBackColor = true;
            this.dataPicker_btn.Click += new System.EventHandler(this.dataPicker_btn_Click);
            // 
            // excelOutput_btn
            // 
            this.excelOutput_btn.Location = new System.Drawing.Point(200, 219);
            this.excelOutput_btn.Name = "excelOutput_btn";
            this.excelOutput_btn.Size = new System.Drawing.Size(115, 23);
            this.excelOutput_btn.TabIndex = 6;
            this.excelOutput_btn.Text = "データ取得ボタン";
            this.excelOutput_btn.UseVisualStyleBackColor = true;
            this.excelOutput_btn.Click += new System.EventHandler(this.excelOutput_btn_Click);
            // 
            // check_btn
            // 
            this.check_btn.Location = new System.Drawing.Point(200, 248);
            this.check_btn.Name = "check_btn";
            this.check_btn.Size = new System.Drawing.Size(115, 23);
            this.check_btn.TabIndex = 7;
            this.check_btn.Text = "データ取得ボタン";
            this.check_btn.UseVisualStyleBackColor = true;
            this.check_btn.Click += new System.EventHandler(this.check_btn_Click);
            // 
            // check_txt
            // 
            this.check_txt.Location = new System.Drawing.Point(12, 248);
            this.check_txt.Name = "check_txt";
            this.check_txt.Size = new System.Drawing.Size(168, 19);
            this.check_txt.TabIndex = 8;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(12, 318);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(168, 88);
            this.checkedListBox1.TabIndex = 9;
            // 
            // CLBtest_tb
            // 
            this.CLBtest_tb.Location = new System.Drawing.Point(200, 347);
            this.CLBtest_tb.Name = "CLBtest_tb";
            this.CLBtest_tb.Size = new System.Drawing.Size(115, 23);
            this.CLBtest_tb.TabIndex = 10;
            this.CLBtest_tb.Text = "チェックリスト取得";
            this.CLBtest_tb.UseVisualStyleBackColor = true;
            this.CLBtest_tb.Click += new System.EventHandler(this.CLBtest_tb_Click);
            // 
            // CLBSet_bt
            // 
            this.CLBSet_bt.Location = new System.Drawing.Point(200, 318);
            this.CLBSet_bt.Name = "CLBSet_bt";
            this.CLBSet_bt.Size = new System.Drawing.Size(115, 23);
            this.CLBSet_bt.TabIndex = 11;
            this.CLBSet_bt.Text = "セット";
            this.CLBSet_bt.UseVisualStyleBackColor = true;
            this.CLBSet_bt.Click += new System.EventHandler(this.CLBSet_bt_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(361, 166);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 467);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.CLBSet_bt);
            this.Controls.Add(this.CLBtest_tb);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.check_txt);
            this.Controls.Add(this.check_btn);
            this.Controls.Add(this.excelOutput_btn);
            this.Controls.Add(this.dataPicker_btn);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}

