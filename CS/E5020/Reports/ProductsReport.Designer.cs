﻿namespace E5020.Reports {
    partial class ProductsReport {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.tbProductData = new DevExpress.XtraReports.UI.XRTable();
            this.trProductData = new DevExpress.XtraReports.UI.XRTableRow();
            this.tcProductName = new DevExpress.XtraReports.UI.XRTableCell();
            this.tcUnitPrice = new DevExpress.XtraReports.UI.XRTableCell();
            this.tcUnitsInStock = new DevExpress.XtraReports.UI.XRTableCell();
            this.tcUnitsOnOrder = new DevExpress.XtraReports.UI.XRTableCell();
            this.tcDiscont = new DevExpress.XtraReports.UI.XRTableCell();
            this.cbDiscont = new DevExpress.XtraReports.UI.XRCheckBox();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.nWindDataSet1 = new E5020.Models.NWindDataSet();
            this.productsTableAdapter = new E5020.Models.NWindDataSetTableAdapters.ProductsTableAdapter();
            this.GroupHeaderCategory = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.tbCategory = new DevExpress.XtraReports.UI.XRTable();
            this.trCategory = new DevExpress.XtraReports.UI.XRTableRow();
            this.tcCategory = new DevExpress.XtraReports.UI.XRTableCell();
            this.GroupHeaderTitle = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.tbProductHeader = new DevExpress.XtraReports.UI.XRTable();
            this.trProductHeader = new DevExpress.XtraReports.UI.XRTableRow();
            this.tcProductNameHeader = new DevExpress.XtraReports.UI.XRTableCell();
            this.tcUnitPriceHeader = new DevExpress.XtraReports.UI.XRTableCell();
            this.tcUnitsInStockHeader = new DevExpress.XtraReports.UI.XRTableCell();
            this.tcUnitsOnOrderHeader = new DevExpress.XtraReports.UI.XRTableCell();
            this.tcDiscontHeader = new DevExpress.XtraReports.UI.XRTableCell();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.lbHeader = new DevExpress.XtraReports.UI.XRLabel();
            ((System.ComponentModel.ISupportInitialize)(this.tbProductData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nWindDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbProductHeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.tbProductData});
            this.Detail.HeightF = 25F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.StylePriority.UseBorders = false;
            this.Detail.StylePriority.UseTextAlignment = false;
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // tbProductData
            // 
            this.tbProductData.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.tbProductData.Name = "tbProductData";
            this.tbProductData.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.trProductData});
            this.tbProductData.SizeF = new System.Drawing.SizeF(649.9999F, 25F);
            // 
            // trProductData
            // 
            this.trProductData.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tcProductName,
            this.tcUnitPrice,
            this.tcUnitsInStock,
            this.tcUnitsOnOrder,
            this.tcDiscont});
            this.trProductData.Name = "trProductData";
            this.trProductData.Weight = 1D;
            // 
            // tcProductName
            // 
            this.tcProductName.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Products.ProductName")});
            this.tcProductName.Name = "tcProductName";
            this.tcProductName.StylePriority.UseTextAlignment = false;
            this.tcProductName.Text = "tcProductName";
            this.tcProductName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.tcProductName.Weight = 1.3798077514467915D;
            // 
            // tcUnitPrice
            // 
            this.tcUnitPrice.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Products.UnitPrice", "{0:c}")});
            this.tcUnitPrice.Name = "tcUnitPrice";
            this.tcUnitPrice.StylePriority.UseTextAlignment = false;
            this.tcUnitPrice.Text = "tcUnitPrice";
            this.tcUnitPrice.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.tcUnitPrice.Weight = 0.4663461624235804D;
            // 
            // tcUnitsInStock
            // 
            this.tcUnitsInStock.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Products.UnitsInStock")});
            this.tcUnitsInStock.Name = "tcUnitsInStock";
            this.tcUnitsInStock.StylePriority.UseTextAlignment = false;
            this.tcUnitsInStock.Text = "tcUnitsInStock";
            this.tcUnitsInStock.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.tcUnitsInStock.Weight = 0.46634616242358046D;
            // 
            // tcUnitsOnOrder
            // 
            this.tcUnitsOnOrder.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Products.UnitsOnOrder")});
            this.tcUnitsOnOrder.Name = "tcUnitsOnOrder";
            this.tcUnitsOnOrder.StylePriority.UseTextAlignment = false;
            this.tcUnitsOnOrder.Text = "tcUnitsOnOrder";
            this.tcUnitsOnOrder.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.tcUnitsOnOrder.Weight = 0.44903843327809811D;
            // 
            // tcDiscont
            // 
            this.tcDiscont.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.cbDiscont});
            this.tcDiscont.Name = "tcDiscont";
            this.tcDiscont.Text = "tcDiscont";
            this.tcDiscont.Weight = 0.2384614904279494D;
            // 
            // cbDiscont
            // 
            this.cbDiscont.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.cbDiscont.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.cbDiscont.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.cbDiscont.Name = "cbDiscont";
            this.cbDiscont.SizeF = new System.Drawing.SizeF(51.66656F, 25F);
            this.cbDiscont.StylePriority.UseBorders = false;
            // 
            // TopMargin
            // 
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // nWindDataSet1
            // 
            this.nWindDataSet1.DataSetName = "NWindDataSet";
            this.nWindDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // GroupHeaderCategory
            // 
            this.GroupHeaderCategory.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.GroupHeaderCategory.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.tbCategory});
            this.GroupHeaderCategory.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("CategoryName", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeaderCategory.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeaderCategory.HeightF = 25F;
            this.GroupHeaderCategory.Name = "GroupHeaderCategory";
            this.GroupHeaderCategory.RepeatEveryPage = true;
            this.GroupHeaderCategory.StylePriority.UseBorders = false;
            this.GroupHeaderCategory.StylePriority.UseTextAlignment = false;
            this.GroupHeaderCategory.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft;
            // 
            // tbCategory
            // 
            this.tbCategory.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.tbCategory.Name = "tbCategory";
            this.tbCategory.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.trCategory});
            this.tbCategory.SizeF = new System.Drawing.SizeF(649.9999F, 25F);
            // 
            // trCategory
            // 
            this.trCategory.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tcCategory});
            this.trCategory.Name = "trCategory";
            this.trCategory.Weight = 1D;
            // 
            // tcCategory
            // 
            this.tcCategory.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.tcCategory.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Products.CategoryName")});
            this.tcCategory.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.tcCategory.Name = "tcCategory";
            this.tcCategory.StylePriority.UseBorders = false;
            this.tcCategory.StylePriority.UseFont = false;
            this.tcCategory.StylePriority.UseTextAlignment = false;
            this.tcCategory.Text = "xrTableCell2";
            this.tcCategory.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.tcCategory.Weight = 3D;
            // 
            // GroupHeaderTitle
            // 
            this.GroupHeaderTitle.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.GroupHeaderTitle.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.tbProductHeader});
            this.GroupHeaderTitle.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.GroupHeaderTitle.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeaderTitle.HeightF = 25F;
            this.GroupHeaderTitle.Level = 1;
            this.GroupHeaderTitle.Name = "GroupHeaderTitle";
            this.GroupHeaderTitle.RepeatEveryPage = true;
            this.GroupHeaderTitle.StylePriority.UseBorders = false;
            this.GroupHeaderTitle.StylePriority.UseFont = false;
            this.GroupHeaderTitle.StylePriority.UseTextAlignment = false;
            this.GroupHeaderTitle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter;
            // 
            // tbProductHeader
            // 
            this.tbProductHeader.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.tbProductHeader.Name = "tbProductHeader";
            this.tbProductHeader.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.trProductHeader});
            this.tbProductHeader.SizeF = new System.Drawing.SizeF(649.9999F, 25F);
            // 
            // trProductHeader
            // 
            this.trProductHeader.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tcProductNameHeader,
            this.tcUnitPriceHeader,
            this.tcUnitsInStockHeader,
            this.tcUnitsOnOrderHeader,
            this.tcDiscontHeader});
            this.trProductHeader.Name = "trProductHeader";
            this.trProductHeader.Weight = 1D;
            // 
            // tcProductNameHeader
            // 
            this.tcProductNameHeader.Name = "tcProductNameHeader";
            this.tcProductNameHeader.Text = "Product Name";
            this.tcProductNameHeader.Weight = 1.379807857084572D;
            // 
            // tcUnitPriceHeader
            // 
            this.tcUnitPriceHeader.Name = "tcUnitPriceHeader";
            this.tcUnitPriceHeader.Text = "Unit Price";
            this.tcUnitPriceHeader.Weight = 0.4663460215732067D;
            // 
            // tcUnitsInStockHeader
            // 
            this.tcUnitsInStockHeader.Name = "tcUnitsInStockHeader";
            this.tcUnitsInStockHeader.Text = "Units In Stock";
            this.tcUnitsInStockHeader.Weight = 0.46634598636061309D;
            // 
            // tcUnitsOnOrderHeader
            // 
            this.tcUnitsOnOrderHeader.Name = "tcUnitsOnOrderHeader";
            this.tcUnitsOnOrderHeader.Text = "Units On Order";
            this.tcUnitsOnOrderHeader.Weight = 0.44903843327809806D;
            // 
            // tcDiscontHeader
            // 
            this.tcDiscontHeader.Name = "tcDiscontHeader";
            this.tcDiscontHeader.Text = "Discont.";
            this.tcDiscontHeader.Weight = 0.23846170170351017D;
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lbHeader});
            this.ReportHeader.Name = "ReportHeader";
            // 
            // lbHeader
            // 
            this.lbHeader.Font = new System.Drawing.Font("Times New Roman", 36F);
            this.lbHeader.LocationFloat = new DevExpress.Utils.PointFloat(0F, 10F);
            this.lbHeader.Name = "lbHeader";
            this.lbHeader.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbHeader.SizeF = new System.Drawing.SizeF(650.0001F, 79.99998F);
            this.lbHeader.StylePriority.UseFont = false;
            this.lbHeader.StylePriority.UseTextAlignment = false;
            this.lbHeader.Text = "Products Report";
            this.lbHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // ProductsReport
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.GroupHeaderCategory,
            this.GroupHeaderTitle,
            this.ReportHeader});
            this.DataAdapter = this.productsTableAdapter;
            this.DataMember = "Products";
            this.DataSource = this.nWindDataSet1;
            this.Version = "13.2";
            ((System.ComponentModel.ISupportInitialize)(this.tbProductData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nWindDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbProductHeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.XRTable tbProductData;
        private DevExpress.XtraReports.UI.XRTableRow trProductData;
        private DevExpress.XtraReports.UI.XRTableCell tcProductName;
        private DevExpress.XtraReports.UI.XRTableCell tcUnitPrice;
        private DevExpress.XtraReports.UI.XRTableCell tcUnitsInStock;
        private DevExpress.XtraReports.UI.XRTableCell tcUnitsOnOrder;
        private DevExpress.XtraReports.UI.XRTableCell tcDiscont;
        private Models.NWindDataSet nWindDataSet1;
        private Models.NWindDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeaderCategory;
        private DevExpress.XtraReports.UI.XRTable tbCategory;
        private DevExpress.XtraReports.UI.XRTableRow trCategory;
        private DevExpress.XtraReports.UI.XRTableCell tcCategory;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeaderTitle;
        private DevExpress.XtraReports.UI.XRTable tbProductHeader;
        private DevExpress.XtraReports.UI.XRTableRow trProductHeader;
        private DevExpress.XtraReports.UI.XRTableCell tcProductNameHeader;
        private DevExpress.XtraReports.UI.XRTableCell tcUnitPriceHeader;
        private DevExpress.XtraReports.UI.XRTableCell tcUnitsInStockHeader;
        private DevExpress.XtraReports.UI.XRTableCell tcUnitsOnOrderHeader;
        private DevExpress.XtraReports.UI.XRTableCell tcDiscontHeader;
        private DevExpress.XtraReports.UI.XRCheckBox cbDiscont;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.XRLabel lbHeader;
    }
}
