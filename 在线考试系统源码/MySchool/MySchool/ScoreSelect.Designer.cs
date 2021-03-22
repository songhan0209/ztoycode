namespace MySchool
{
    partial class ScoreSelect
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.studeScoreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mySchoolDataSet = new MySchool.MySchoolDataSet();
            this.studeScoreTableAdapter = new MySchool.MySchoolDataSetTableAdapters.StudeScoreTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studeScoreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mySchoolDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(787, 437);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // studeScoreBindingSource
            // 
            this.studeScoreBindingSource.DataMember = "StudeScore";
            this.studeScoreBindingSource.DataSource = this.mySchoolDataSet;
            // 
            // mySchoolDataSet
            // 
            this.mySchoolDataSet.DataSetName = "MySchoolDataSet";
            this.mySchoolDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studeScoreTableAdapter
            // 
            this.studeScoreTableAdapter.ClearBeforeFill = true;
            // 
            // ScoreSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ScoreSelect";
            this.Text = "ScoreSelect";
            this.Load += new System.EventHandler(this.ScoreSelect_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studeScoreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mySchoolDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private MySchoolDataSet mySchoolDataSet;
        private System.Windows.Forms.BindingSource studeScoreBindingSource;
        private MySchoolDataSetTableAdapters.StudeScoreTableAdapter studeScoreTableAdapter;
    }
}