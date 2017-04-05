namespace WebSniffer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.formAssistant1 = new DevExpress.XtraBars.FormAssistant();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel();
            this.toolboxControl1 = new DevExpress.XtraToolbox.ToolboxControl();
            this.groupNav = new DevExpress.XtraToolbox.ToolboxGroup();
            this.btNewTab = new DevExpress.XtraToolbox.ToolboxItem();
            this.btCloseTab = new DevExpress.XtraToolbox.ToolboxItem();
            this.btBack = new DevExpress.XtraToolbox.ToolboxItem();
            this.btNext = new DevExpress.XtraToolbox.ToolboxItem();
            this.btLink = new DevExpress.XtraToolbox.ToolboxItem();
            this.btRefresh = new DevExpress.XtraToolbox.ToolboxItem();
            this.toolboxGroup1 = new DevExpress.XtraToolbox.ToolboxGroup();
            this.btViewCode = new DevExpress.XtraToolbox.ToolboxItem();
            this.btSaveCode = new DevExpress.XtraToolbox.ToolboxItem();
            this.btPattern = new DevExpress.XtraToolbox.ToolboxItem();
            this.SuspendLayout();
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2016 Colorful";
            // 
            // toolboxControl1
            // 
            this.toolboxControl1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.toolboxControl1.Caption = "Terminal";
            this.toolboxControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.toolboxControl1.Groups.Add(this.groupNav);
            this.toolboxControl1.Groups.Add(this.toolboxGroup1);
            this.toolboxControl1.Location = new System.Drawing.Point(859, 0);
            this.toolboxControl1.Name = "toolboxControl1";
            this.toolboxControl1.OptionsBehavior.AllowSmoothScrolling = true;
            this.toolboxControl1.OptionsMinimizing.State = DevExpress.XtraToolbox.ToolboxState.Minimized;
            this.toolboxControl1.OptionsView.ShowToolboxCaption = true;
            this.toolboxControl1.SelectedGroup = this.groupNav;
            this.toolboxControl1.SelectedGroupIndex = 0;
            this.toolboxControl1.Size = new System.Drawing.Size(56, 450);
            this.toolboxControl1.TabIndex = 1;
            this.toolboxControl1.Text = "Terminal";
            this.toolboxControl1.ItemClick += new DevExpress.XtraToolbox.ToolboxItemClickEventHandler(this.toolboxControl1_ItemClick);
            // 
            // groupNav
            // 
            this.groupNav.BeginGroup = false;
            this.groupNav.BeginGroupCaption = "";
            this.groupNav.Caption = "Navigator";
            this.groupNav.Image = ((System.Drawing.Image)(resources.GetObject("groupNav.Image")));
            this.groupNav.Items.Add(this.btNewTab);
            this.groupNav.Items.Add(this.btCloseTab);
            this.groupNav.Items.Add(this.btBack);
            this.groupNav.Items.Add(this.btNext);
            this.groupNav.Items.Add(this.btLink);
            this.groupNav.Items.Add(this.btRefresh);
            this.groupNav.Name = "groupNav";
            // 
            // btNewTab
            // 
            this.btNewTab.BeginGroup = false;
            this.btNewTab.BeginGroupCaption = null;
            this.btNewTab.Caption = "New Tab";
            this.btNewTab.Image = ((System.Drawing.Image)(resources.GetObject("btNewTab.Image")));
            this.btNewTab.Name = "btNewTab";
            // 
            // btCloseTab
            // 
            this.btCloseTab.BeginGroup = false;
            this.btCloseTab.BeginGroupCaption = null;
            this.btCloseTab.Caption = "Close Tab";
            this.btCloseTab.Image = ((System.Drawing.Image)(resources.GetObject("btCloseTab.Image")));
            this.btCloseTab.Name = "btCloseTab";
            // 
            // btBack
            // 
            this.btBack.BeginGroup = false;
            this.btBack.BeginGroupCaption = null;
            this.btBack.Caption = "Back";
            this.btBack.Image = ((System.Drawing.Image)(resources.GetObject("btBack.Image")));
            this.btBack.Name = "btBack";
            // 
            // btNext
            // 
            this.btNext.BeginGroup = false;
            this.btNext.BeginGroupCaption = null;
            this.btNext.Caption = "Next";
            this.btNext.Image = ((System.Drawing.Image)(resources.GetObject("btNext.Image")));
            this.btNext.Name = "btNext";
            // 
            // btLink
            // 
            this.btLink.BeginGroup = false;
            this.btLink.BeginGroupCaption = null;
            this.btLink.Caption = "Link To";
            this.btLink.Image = ((System.Drawing.Image)(resources.GetObject("btLink.Image")));
            this.btLink.Name = "btLink";
            // 
            // btRefresh
            // 
            this.btRefresh.BeginGroup = false;
            this.btRefresh.BeginGroupCaption = null;
            this.btRefresh.Caption = "Refresh";
            this.btRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btRefresh.Image")));
            this.btRefresh.Name = "btRefresh";
            // 
            // toolboxGroup1
            // 
            this.toolboxGroup1.BeginGroup = false;
            this.toolboxGroup1.BeginGroupCaption = "";
            this.toolboxGroup1.Caption = "Develope";
            this.toolboxGroup1.Image = ((System.Drawing.Image)(resources.GetObject("toolboxGroup1.Image")));
            this.toolboxGroup1.Items.Add(this.btViewCode);
            this.toolboxGroup1.Items.Add(this.btSaveCode);
            this.toolboxGroup1.Items.Add(this.btPattern);
            this.toolboxGroup1.Name = "toolboxGroup1";
            // 
            // btViewCode
            // 
            this.btViewCode.BeginGroup = false;
            this.btViewCode.BeginGroupCaption = null;
            this.btViewCode.Caption = "View Code";
            this.btViewCode.Image = ((System.Drawing.Image)(resources.GetObject("btViewCode.Image")));
            this.btViewCode.Name = "btViewCode";
            // 
            // btSaveCode
            // 
            this.btSaveCode.BeginGroup = false;
            this.btSaveCode.BeginGroupCaption = null;
            this.btSaveCode.Caption = "Save Code";
            this.btSaveCode.Image = ((System.Drawing.Image)(resources.GetObject("btSaveCode.Image")));
            this.btSaveCode.Name = "btSaveCode";
            // 
            // btPattern
            // 
            this.btPattern.BeginGroup = false;
            this.btPattern.BeginGroupCaption = null;
            this.btPattern.Caption = "Matching Pattern";
            this.btPattern.Image = ((System.Drawing.Image)(resources.GetObject("btPattern.Image")));
            this.btPattern.Name = "btPattern";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 450);
            this.Controls.Add(this.toolboxControl1);
            this.Name = "Form1";
            this.Text = "NTK - Web Sniffer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.FormAssistant formAssistant1;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraToolbox.ToolboxControl toolboxControl1;
        private DevExpress.XtraToolbox.ToolboxGroup groupNav;
        private DevExpress.XtraToolbox.ToolboxItem btNewTab;
        private DevExpress.XtraToolbox.ToolboxItem btCloseTab;
        private DevExpress.XtraToolbox.ToolboxItem btBack;
        private DevExpress.XtraToolbox.ToolboxItem btNext;
        private DevExpress.XtraToolbox.ToolboxItem btLink;
        private DevExpress.XtraToolbox.ToolboxItem btRefresh;
        private DevExpress.XtraToolbox.ToolboxGroup toolboxGroup1;
        private DevExpress.XtraToolbox.ToolboxItem btViewCode;
        private DevExpress.XtraToolbox.ToolboxItem btSaveCode;
        private DevExpress.XtraToolbox.ToolboxItem btPattern;
    }
}

