
namespace Task_2
{
    partial class FindForm
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
            this.tlp1_Find = new System.Windows.Forms.TableLayoutPanel();
            this.btn1_find = new System.Windows.Forms.Button();
            this.tb1_find = new System.Windows.Forms.TextBox();
            this.btn2_Replace = new System.Windows.Forms.Button();
            this.tb2_replace = new System.Windows.Forms.TextBox();
            this.tlp1_Find.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlp1_Find
            // 
            this.tlp1_Find.ColumnCount = 2;
            this.tlp1_Find.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp1_Find.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp1_Find.Controls.Add(this.btn2_Replace, 0, 1);
            this.tlp1_Find.Controls.Add(this.tb2_replace, 0, 1);
            this.tlp1_Find.Controls.Add(this.btn1_find, 0, 0);
            this.tlp1_Find.Controls.Add(this.tb1_find, 1, 0);
            this.tlp1_Find.Location = new System.Drawing.Point(12, 52);
            this.tlp1_Find.Name = "tlp1_Find";
            this.tlp1_Find.RowCount = 2;
            this.tlp1_Find.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp1_Find.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp1_Find.Size = new System.Drawing.Size(776, 114);
            this.tlp1_Find.TabIndex = 0;
            // 
            // btn1_find
            // 
            this.btn1_find.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn1_find.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1_find.Location = new System.Drawing.Point(3, 3);
            this.btn1_find.Name = "btn1_find";
            this.btn1_find.Size = new System.Drawing.Size(382, 51);
            this.btn1_find.TabIndex = 0;
            this.btn1_find.Text = "Find What";
            this.btn1_find.UseVisualStyleBackColor = true;
            this.btn1_find.Click += new System.EventHandler(this.btn1_find_Click);
            // 
            // tb1_find
            // 
            this.tb1_find.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb1_find.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb1_find.Location = new System.Drawing.Point(391, 3);
            this.tb1_find.Multiline = true;
            this.tb1_find.Name = "tb1_find";
            this.tb1_find.Size = new System.Drawing.Size(382, 51);
            this.tb1_find.TabIndex = 1;
            // 
            // btn2_Replace
            // 
            this.btn2_Replace.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn2_Replace.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2_Replace.Location = new System.Drawing.Point(3, 60);
            this.btn2_Replace.Name = "btn2_Replace";
            this.btn2_Replace.Size = new System.Drawing.Size(382, 51);
            this.btn2_Replace.TabIndex = 2;
            this.btn2_Replace.Text = "Replace With";
            this.btn2_Replace.UseVisualStyleBackColor = true;
            this.btn2_Replace.Click += new System.EventHandler(this.btn2_Replace_Click);
            // 
            // tb2_replace
            // 
            this.tb2_replace.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb2_replace.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb2_replace.Location = new System.Drawing.Point(391, 60);
            this.tb2_replace.Multiline = true;
            this.tb2_replace.Name = "tb2_replace";
            this.tb2_replace.Size = new System.Drawing.Size(382, 51);
            this.tb2_replace.TabIndex = 3;
            // 
            // FindForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(800, 184);
            this.Controls.Add(this.tlp1_Find);
            this.Name = "FindForm";
            this.Text = "Find";
            this.tlp1_Find.ResumeLayout(false);
            this.tlp1_Find.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlp1_Find;
        private System.Windows.Forms.Button btn1_find;
        private System.Windows.Forms.TextBox tb1_find;
        private System.Windows.Forms.Button btn2_Replace;
        private System.Windows.Forms.TextBox tb2_replace;
    }
}