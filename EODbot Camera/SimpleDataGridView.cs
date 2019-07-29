using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EODbot_Camera {
    class SimpleDataGridView : DataGridView {

        public Action<int> SaveSelection;
        private DataGridView dataGridView1;
        public Action RestoreSelection;

        protected override void OnCellMouseDown(DataGridViewCellMouseEventArgs e) {
            if(SaveSelection != null)
                SaveSelection(e.ColumnIndex);

            base.OnCellMouseDown(e);

            if(RestoreSelection != null)
                RestoreSelection();
        }

        protected override void OnCellDoubleClick(DataGridViewCellEventArgs e) {
            if(SaveSelection != null)
                SaveSelection(e.ColumnIndex);

            base.OnCellDoubleClick(e);

            if(RestoreSelection != null)
                RestoreSelection();
        }

        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // SimpleDataGridView
            // 
            this.RowTemplate.Height = 24;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }
    }
}