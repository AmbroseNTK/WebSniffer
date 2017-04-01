namespace WebSniffer
{
    partial class Linker
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbName = new DevExpress.DXperience.Demos.DescriptionLabel();
            this.treeListBand1 = new DevExpress.XtraTreeList.Columns.TreeListBand();
            this.treeListBand2 = new DevExpress.XtraTreeList.Columns.TreeListBand();
            this.tbLink = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.tbLink.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbName.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.lbName.LineLocation = DevExpress.XtraEditors.LineLocation.Bottom;
            this.lbName.LineVisible = true;
            this.lbName.Location = new System.Drawing.Point(3, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(51, 22);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Linker";
            // 
            // treeListBand1
            // 
            this.treeListBand1.Caption = "treeListBand1";
            this.treeListBand1.Name = "treeListBand1";
            // 
            // treeListBand2
            // 
            this.treeListBand2.Caption = "treeListBand2";
            this.treeListBand2.Name = "treeListBand2";
            // 
            // tbLink
            // 
            this.tbLink.Location = new System.Drawing.Point(3, 28);
            this.tbLink.Name = "tbLink";
            this.tbLink.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbLink.Properties.Appearance.ForeColor = System.Drawing.Color.DodgerBlue;
            this.tbLink.Properties.Appearance.Options.UseFont = true;
            this.tbLink.Properties.Appearance.Options.UseForeColor = true;
            this.tbLink.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tbLink.Size = new System.Drawing.Size(718, 24);
            this.tbLink.TabIndex = 2;
            this.tbLink.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbLink_KeyDown);
            // 
            // Linker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.tbLink);
            this.Controls.Add(this.lbName);
            this.Name = "Linker";
            this.Size = new System.Drawing.Size(724, 57);
            ((System.ComponentModel.ISupportInitialize)(this.tbLink.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.DXperience.Demos.DescriptionLabel lbName;
        private DevExpress.XtraTreeList.Columns.TreeListBand treeListBand1;
        private DevExpress.XtraTreeList.Columns.TreeListBand treeListBand2;
        private DevExpress.XtraEditors.ComboBoxEdit tbLink;
    }
}
