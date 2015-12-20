namespace Thawhlawm.UserControls
{
    partial class Thawhtu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Thawhtu));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.bNew = new DevExpress.XtraBars.BarButtonItem();
            this.bEdit = new DevExpress.XtraBars.BarButtonItem();
            this.bDel = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.nFirst = new DevExpress.XtraBars.BarButtonItem();
            this.nPrev = new DevExpress.XtraBars.BarButtonItem();
            this.nNext = new DevExpress.XtraBars.BarButtonItem();
            this.nLast = new DevExpress.XtraBars.BarButtonItem();
            this.nFind = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xPreview = new DevExpress.XtraBars.BarButtonItem();
            this.xExport = new DevExpress.XtraBars.BarSubItem();
            this.grd = new DevExpress.XtraGrid.GridControl();
            this.grv = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHming = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhone = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grv)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.bNew,
            this.bEdit,
            this.bDel,
            this.nFirst,
            this.nPrev,
            this.nNext,
            this.nLast,
            this.nFind,
            this.xPreview,
            this.xExport});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 11;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(735, 141);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3});
            this.ribbonPage1.MergeOrder = 0;
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Thawhtu";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.bNew);
            this.ribbonPageGroup1.ItemLinks.Add(this.bEdit);
            this.ribbonPageGroup1.ItemLinks.Add(this.bDel);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            this.ribbonPageGroup1.Text = "Management";
            // 
            // bNew
            // 
            this.bNew.Caption = "New";
            this.bNew.Glyph = ((System.Drawing.Image)(resources.GetObject("bNew.Glyph")));
            this.bNew.Id = 1;
            this.bNew.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bNew.LargeGlyph")));
            this.bNew.Name = "bNew";
            // 
            // bEdit
            // 
            this.bEdit.Caption = "Edit";
            this.bEdit.Glyph = ((System.Drawing.Image)(resources.GetObject("bEdit.Glyph")));
            this.bEdit.Id = 2;
            this.bEdit.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bEdit.LargeGlyph")));
            this.bEdit.Name = "bEdit";
            // 
            // bDel
            // 
            this.bDel.Caption = "Delete";
            this.bDel.Glyph = ((System.Drawing.Image)(resources.GetObject("bDel.Glyph")));
            this.bDel.Id = 3;
            this.bDel.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bDel.LargeGlyph")));
            this.bDel.Name = "bDel";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.nFirst);
            this.ribbonPageGroup2.ItemLinks.Add(this.nPrev);
            this.ribbonPageGroup2.ItemLinks.Add(this.nNext);
            this.ribbonPageGroup2.ItemLinks.Add(this.nLast);
            this.ribbonPageGroup2.ItemLinks.Add(this.nFind, true);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.ShowCaptionButton = false;
            this.ribbonPageGroup2.Text = "Navigation";
            // 
            // nFirst
            // 
            this.nFirst.Caption = "First";
            this.nFirst.Glyph = ((System.Drawing.Image)(resources.GetObject("nFirst.Glyph")));
            this.nFirst.Id = 4;
            this.nFirst.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("nFirst.LargeGlyph")));
            this.nFirst.Name = "nFirst";
            // 
            // nPrev
            // 
            this.nPrev.Caption = "Previous";
            this.nPrev.Glyph = ((System.Drawing.Image)(resources.GetObject("nPrev.Glyph")));
            this.nPrev.Id = 5;
            this.nPrev.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("nPrev.LargeGlyph")));
            this.nPrev.Name = "nPrev";
            // 
            // nNext
            // 
            this.nNext.Caption = "Next";
            this.nNext.Glyph = ((System.Drawing.Image)(resources.GetObject("nNext.Glyph")));
            this.nNext.Id = 6;
            this.nNext.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("nNext.LargeGlyph")));
            this.nNext.Name = "nNext";
            // 
            // nLast
            // 
            this.nLast.Caption = "Last";
            this.nLast.Glyph = ((System.Drawing.Image)(resources.GetObject("nLast.Glyph")));
            this.nLast.Id = 7;
            this.nLast.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("nLast.LargeGlyph")));
            this.nLast.Name = "nLast";
            // 
            // nFind
            // 
            this.nFind.Caption = "Find";
            this.nFind.Glyph = ((System.Drawing.Image)(resources.GetObject("nFind.Glyph")));
            this.nFind.Id = 8;
            this.nFind.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("nFind.LargeGlyph")));
            this.nFind.Name = "nFind";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.xPreview);
            this.ribbonPageGroup3.ItemLinks.Add(this.xExport);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.ShowCaptionButton = false;
            this.ribbonPageGroup3.Text = "Print && Export";
            // 
            // xPreview
            // 
            this.xPreview.Caption = "Preview";
            this.xPreview.Glyph = ((System.Drawing.Image)(resources.GetObject("xPreview.Glyph")));
            this.xPreview.Id = 9;
            this.xPreview.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("xPreview.LargeGlyph")));
            this.xPreview.Name = "xPreview";
            // 
            // xExport
            // 
            this.xExport.Caption = "Export";
            this.xExport.Glyph = ((System.Drawing.Image)(resources.GetObject("xExport.Glyph")));
            this.xExport.Id = 10;
            this.xExport.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("xExport.LargeGlyph")));
            this.xExport.Name = "xExport";
            // 
            // grd
            // 
            this.grd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd.Location = new System.Drawing.Point(0, 141);
            this.grd.MainView = this.grv;
            this.grd.MenuManager = this.ribbonControl1;
            this.grd.Name = "grd";
            this.grd.Size = new System.Drawing.Size(735, 351);
            this.grd.TabIndex = 1;
            this.grd.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grv});
            // 
            // grv
            // 
            this.grv.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colHming,
            this.colPhone});
            this.grv.GridControl = this.grd;
            this.grv.Name = "grv";
            this.grv.OptionsView.ShowGroupPanel = false;
            // 
            // colID
            // 
            this.colID.Caption = "gridColumn1";
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.OptionsColumn.AllowEdit = false;
            this.colID.OptionsColumn.AllowFocus = false;
            this.colID.OptionsColumn.ReadOnly = true;
            // 
            // colHming
            // 
            this.colHming.Caption = "Hming";
            this.colHming.FieldName = "PetuHming";
            this.colHming.Name = "colHming";
            this.colHming.OptionsColumn.AllowEdit = false;
            this.colHming.OptionsColumn.AllowFocus = false;
            this.colHming.OptionsColumn.ReadOnly = true;
            this.colHming.Visible = true;
            this.colHming.VisibleIndex = 0;
            this.colHming.Width = 373;
            // 
            // colPhone
            // 
            this.colPhone.Caption = "Phone No";
            this.colPhone.FieldName = "PhoneNo";
            this.colPhone.Name = "colPhone";
            this.colPhone.OptionsColumn.AllowEdit = false;
            this.colPhone.OptionsColumn.AllowFocus = false;
            this.colPhone.OptionsColumn.ReadOnly = true;
            this.colPhone.Visible = true;
            this.colPhone.VisibleIndex = 1;
            this.colPhone.Width = 344;
            // 
            // Thawhtu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grd);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "Thawhtu";
            this.Size = new System.Drawing.Size(735, 492);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem bNew;
        private DevExpress.XtraBars.BarButtonItem bEdit;
        private DevExpress.XtraBars.BarButtonItem bDel;
        private DevExpress.XtraBars.BarButtonItem nFirst;
        private DevExpress.XtraBars.BarButtonItem nPrev;
        private DevExpress.XtraBars.BarButtonItem nNext;
        private DevExpress.XtraBars.BarButtonItem nLast;
        private DevExpress.XtraBars.BarButtonItem nFind;
        private DevExpress.XtraBars.BarButtonItem xPreview;
        private DevExpress.XtraBars.BarSubItem xExport;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraGrid.GridControl grd;
        private DevExpress.XtraGrid.Views.Grid.GridView grv;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colHming;
        private DevExpress.XtraGrid.Columns.GridColumn colPhone;
    }
}
