namespace Trivio_Learn.Forms
{
    partial class ExerPresentSimple
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExerPresentSimple));
            this.sentenceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.trivio_learnDataSet = new Trivio_Learn.trivio_learnDataSet();
            this.sentenceTableAdapter = new Trivio_Learn.trivio_learnDataSetTableAdapters.sentenceTableAdapter();
            this.bunifuFlatButton4 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panelExerPresentSimple = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.sentenceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trivio_learnDataSet)).BeginInit();
            this.panelExerPresentSimple.SuspendLayout();
            this.SuspendLayout();
            // 
            // sentenceBindingSource
            // 
            this.sentenceBindingSource.DataMember = "sentence";
            this.sentenceBindingSource.DataSource = this.trivio_learnDataSet;
            // 
            // trivio_learnDataSet
            // 
            this.trivio_learnDataSet.DataSetName = "trivio_learnDataSet";
            this.trivio_learnDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sentenceTableAdapter
            // 
            this.sentenceTableAdapter.ClearBeforeFill = true;
            // 
            // bunifuFlatButton4
            // 
            this.bunifuFlatButton4.Activecolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton4.AutoSize = true;
            this.bunifuFlatButton4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton4.BorderRadius = 7;
            this.bunifuFlatButton4.ButtonText = "result";
            this.bunifuFlatButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton4.DisabledColor = System.Drawing.Color.DimGray;
            this.bunifuFlatButton4.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton4.Iconimage = null;
            this.bunifuFlatButton4.Iconimage_right = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton4.Iconimage_right")));
            this.bunifuFlatButton4.Iconimage_right_Selected = null;
            this.bunifuFlatButton4.Iconimage_Selected = null;
            this.bunifuFlatButton4.IconMarginLeft = 0;
            this.bunifuFlatButton4.IconMarginRight = 0;
            this.bunifuFlatButton4.IconRightVisible = true;
            this.bunifuFlatButton4.IconRightZoom = 0D;
            this.bunifuFlatButton4.IconVisible = true;
            this.bunifuFlatButton4.IconZoom = 90D;
            this.bunifuFlatButton4.IsTab = false;
            this.bunifuFlatButton4.Location = new System.Drawing.Point(583, 403);
            this.bunifuFlatButton4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bunifuFlatButton4.Name = "bunifuFlatButton4";
            this.bunifuFlatButton4.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton4.OnHovercolor = System.Drawing.Color.DimGray;
            this.bunifuFlatButton4.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.bunifuFlatButton4.selected = false;
            this.bunifuFlatButton4.Size = new System.Drawing.Size(110, 49);
            this.bunifuFlatButton4.TabIndex = 86;
            this.bunifuFlatButton4.Text = "result";
            this.bunifuFlatButton4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bunifuFlatButton4.Textcolor = System.Drawing.Color.DimGray;
            this.bunifuFlatButton4.TextFont = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bunifuFlatButton4.Click += new System.EventHandler(this.bunifuFlatButton4_Click);
            // 
            // panelExerPresentSimple
            // 
            this.panelExerPresentSimple.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panelExerPresentSimple.Controls.Add(this.bunifuFlatButton4);
            this.panelExerPresentSimple.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelExerPresentSimple.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.panelExerPresentSimple.Location = new System.Drawing.Point(0, 0);
            this.panelExerPresentSimple.Name = "panelExerPresentSimple";
            this.panelExerPresentSimple.Size = new System.Drawing.Size(700, 465);
            this.panelExerPresentSimple.TabIndex = 0;
            this.panelExerPresentSimple.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // ExerPresentSimple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(700, 465);
            this.Controls.Add(this.panelExerPresentSimple);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ExerPresentSimple";
            this.Text = "ExerPresentSimple";
            this.Load += new System.EventHandler(this.ExerPresentSimple_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sentenceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trivio_learnDataSet)).EndInit();
            this.panelExerPresentSimple.ResumeLayout(false);
            this.panelExerPresentSimple.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private trivio_learnDataSet trivio_learnDataSet;
        private System.Windows.Forms.BindingSource sentenceBindingSource;
        private trivio_learnDataSetTableAdapters.sentenceTableAdapter sentenceTableAdapter;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton4;
        private System.Windows.Forms.Panel panelExerPresentSimple;
    }
}