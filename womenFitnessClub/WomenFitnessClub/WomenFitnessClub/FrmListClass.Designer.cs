namespace WomenFitnessClub
{
    partial class FrmListClass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListClass));
            this.label3 = new System.Windows.Forms.Label();
            this.DtGrdSearchClass = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtCode = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCoachName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DtGrdSearchClass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label3.Location = new System.Drawing.Point(244, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(242, 37);
            this.label3.TabIndex = 15;
            this.label3.Text = "نمایش لیست کلاس ها ";
            // 
            // DtGrdSearchClass
            // 
            this.DtGrdSearchClass.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.DtGrdSearchClass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtGrdSearchClass.Location = new System.Drawing.Point(12, 221);
            this.DtGrdSearchClass.Name = "DtGrdSearchClass";
            this.DtGrdSearchClass.RowTemplate.Height = 24;
            this.DtGrdSearchClass.Size = new System.Drawing.Size(736, 336);
            this.DtGrdSearchClass.TabIndex = 19;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnSearch.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.btnSearch.Location = new System.Drawing.Point(12, 156);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(736, 48);
            this.btnSearch.TabIndex = 20;
            this.btnSearch.Text = "جست و جو";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.Location = new System.Drawing.Point(12, 10);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(49, 47);
            this.btnBack.TabIndex = 27;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtCode
            // 
            this.txtCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtCode.Location = new System.Drawing.Point(503, 96);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(139, 34);
            this.txtCode.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Nazanin", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(657, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 41);
            this.label1.TabIndex = 29;
            this.label1.Text = "کد کلاس";
            // 
            // txtCoachName
            // 
            this.txtCoachName.Font = new System.Drawing.Font("B Nazanin", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtCoachName.Location = new System.Drawing.Point(12, 90);
            this.txtCoachName.Name = "txtCoachName";
            this.txtCoachName.Size = new System.Drawing.Size(250, 42);
            this.txtCoachName.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("B Nazanin", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(307, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 41);
            this.label2.TabIndex = 31;
            this.label2.Text = "نام مربی";
            // 
            // FrmListClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 569);
            this.Controls.Add(this.txtCoachName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.DtGrdSearchClass);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmListClass";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmListClass";
            ((System.ComponentModel.ISupportInitialize)(this.DtGrdSearchClass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView DtGrdSearchClass;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.NumericUpDown txtCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCoachName;
        private System.Windows.Forms.Label label2;
    }
}