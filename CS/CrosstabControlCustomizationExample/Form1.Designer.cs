namespace CrosstabControlCustomizationExample
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
            DevExpress.XtraEditors.TableLayout.ItemTemplateBase itemTemplateBase1 = new DevExpress.XtraEditors.TableLayout.ItemTemplateBase();
            DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition1 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
            DevExpress.XtraEditors.TableLayout.TemplatedItemElement templatedItemElement1 = new DevExpress.XtraEditors.TableLayout.TemplatedItemElement();
            DevExpress.XtraEditors.TableLayout.TemplatedItemElement templatedItemElement2 = new DevExpress.XtraEditors.TableLayout.TemplatedItemElement();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition1 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition2 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            this.htmlTemplate1 = new DevExpress.Utils.Html.HtmlTemplate();
            this.btnDesign = new DevExpress.XtraEditors.SimpleButton();
            this.listBoxControl1 = new DevExpress.XtraEditors.ListBoxControl();
            this.reportDescriptionDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportDescriptionDataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // htmlTemplate1
            // 
            this.htmlTemplate1.Name = "htmlTemplate1";
            // 
            // btnDesign
            // 
            this.btnDesign.Location = new System.Drawing.Point(1035, 708);
            this.btnDesign.Name = "btnDesign";
            this.btnDesign.Size = new System.Drawing.Size(151, 30);
            this.btnDesign.TabIndex = 1;
            this.btnDesign.Text = "Design";
            this.btnDesign.Click += new System.EventHandler(this.btnDesign_Click);
            // 
            // listBoxControl1
            // 
            this.listBoxControl1.DataSource = typeof(CrosstabControlCustomizationExample.DataItem);
            this.listBoxControl1.DisplayMember = "DisplayName";
            this.listBoxControl1.HtmlTemplates.AddRange(new DevExpress.Utils.Html.HtmlTemplate[] {
            this.htmlTemplate1});
            this.listBoxControl1.ItemAutoHeight = true;
            this.listBoxControl1.ItemHeight = 120;
            this.listBoxControl1.Location = new System.Drawing.Point(12, 12);
            this.listBoxControl1.Name = "listBoxControl1";
            this.listBoxControl1.Size = new System.Drawing.Size(1174, 654);
            this.listBoxControl1.TabIndex = 0;
            tableColumnDefinition1.Length.Value = 8D;
            tableColumnDefinition1.PaddingLeft = 10;
            itemTemplateBase1.Columns.Add(tableColumnDefinition1);
            templatedItemElement1.Appearance.Normal.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            templatedItemElement1.Appearance.Normal.Options.UseFont = true;
            templatedItemElement1.FieldName = "DisplayName";
            templatedItemElement1.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            templatedItemElement1.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            templatedItemElement1.ImageVisible = false;
            templatedItemElement1.Text = "DisplayName";
            templatedItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopLeft;
            templatedItemElement2.FieldName = "Description";
            templatedItemElement2.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            templatedItemElement2.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            templatedItemElement2.MaxLineCount = 150;
            templatedItemElement2.RowIndex = 1;
            templatedItemElement2.Text = "Description";
            templatedItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopLeft;
            itemTemplateBase1.Elements.Add(templatedItemElement1);
            itemTemplateBase1.Elements.Add(templatedItemElement2);
            itemTemplateBase1.Name = "template1";
            tableRowDefinition1.AutoHeight = true;
            tableRowDefinition1.Length.Value = 46D;
            tableRowDefinition1.PaddingBottom = 10;
            tableRowDefinition1.PaddingTop = 10;
            tableRowDefinition2.AutoHeight = true;
            tableRowDefinition2.Length.Value = 68D;
            tableRowDefinition2.PaddingBottom = 10;
            tableRowDefinition2.PaddingTop = 10;
            itemTemplateBase1.Rows.Add(tableRowDefinition1);
            itemTemplateBase1.Rows.Add(tableRowDefinition2);
            this.listBoxControl1.Templates.Add(itemTemplateBase1);
            this.listBoxControl1.ValueMember = "ReportName";
            // 
            // reportDescriptionDataBindingSource
            // 
            this.reportDescriptionDataBindingSource.DataSource = typeof(CrosstabControlCustomizationExample.ReportDescriptionData);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 760);
            this.Controls.Add(this.btnDesign);
            this.Controls.Add(this.listBoxControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Crosstab Control Customization";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportDescriptionDataBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.ListBoxControl listBoxControl1;
        private System.Windows.Forms.BindingSource reportDescriptionDataBindingSource;
        private DevExpress.Utils.Html.HtmlTemplate htmlTemplate1;
        private DevExpress.XtraEditors.SimpleButton btnDesign;
    }
}

