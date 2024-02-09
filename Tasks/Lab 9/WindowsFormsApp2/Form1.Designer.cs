
namespace WindowsFormsApp2
{
    partial class Form1
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
            this.Furqandatagrid = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.del = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Furqandatagrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // Furqandatagrid
            // 
            this.Furqandatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Furqandatagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.del});
            this.Furqandatagrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Furqandatagrid.Location = new System.Drawing.Point(0, 0);
            this.Furqandatagrid.Name = "Furqandatagrid";
            this.Furqandatagrid.Size = new System.Drawing.Size(733, 519);
            this.Furqandatagrid.TabIndex = 0;
            this.Furqandatagrid.ReadOnlyChanged += new System.EventHandler(this.Furqandatagrid_ReadOnlyChanged);
            this.Furqandatagrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Furqandatagrid_CellContentClick);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // del
            // 
            this.del.HeaderText = "Delete";
            this.del.Name = "del";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 519);
            this.Controls.Add(this.Furqandatagrid);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Furqandatagrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Furqandatagrid;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn del;
    }
}

