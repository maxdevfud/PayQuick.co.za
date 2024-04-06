namespace PayQuick
{
    partial class frmViewTaxTables
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
            TallComponents.PDF.Navigation.BookmarkCollection bookmarkCollection4 = new TallComponents.PDF.Navigation.BookmarkCollection();
            TallComponents.PDF.Metadata.MetadataSchemaCollection metadataSchemaCollection4 = new TallComponents.PDF.Metadata.MetadataSchemaCollection();
            TallComponents.PDF.DigitalSignatures.StandardSignatureHandlerFactory standardSignatureHandlerFactory4 = new TallComponents.PDF.DigitalSignatures.StandardSignatureHandlerFactory();
            this.document1 = new TallComponents.PDF.Document(this.components);
            this.documentViewer2 = new TallComponents.Interaction.WinForms.Controls.DocumentViewer();
            this.SuspendLayout();
            // 
            // document1
            // 
            this.document1.AfterPrintAction = null;
            this.document1.AfterSaveAction = null;
            this.document1.BeforeCloseAction = null;
            this.document1.BeforePrintAction = null;
            this.document1.BeforeSaveAction = null;
            bookmarkCollection4.Open = true;
            this.document1.Bookmarks = bookmarkCollection4;
            this.document1.MetadataSchemas = metadataSchemaCollection4;
            this.document1.Security = null;
            this.document1.SignatureHandlerFactory = standardSignatureHandlerFactory4;
            this.document1.ViewerPreferences = null;
            // 
            // documentViewer2
            // 
            this.documentViewer2.CaretBlinkTime = 530;
            this.documentViewer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.documentViewer2.Document = this.document1;
            this.documentViewer2.HideHorizontalScrollbar = false;
            this.documentViewer2.HideVerticalScrollbar = false;
            this.documentViewer2.HorizontalAlignment = TallComponents.PDF.HorizontalAlignment.Left;
            this.documentViewer2.HoverCursor = null;
            this.documentViewer2.Location = new System.Drawing.Point(0, 0);
            this.documentViewer2.MaxZoom = 64D;
            this.documentViewer2.MinZoom = 0.125D;
            this.documentViewer2.Name = "documentViewer2";
            this.documentViewer2.Size = new System.Drawing.Size(622, 719);
            this.documentViewer2.TabIndex = 1;
            this.documentViewer2.Text = "documentViewer2";
            this.documentViewer2.VerticalAlignment = TallComponents.PDF.VerticalAlignment.Top;
            this.documentViewer2.VisibleLeft = 0D;
            this.documentViewer2.VisibleTop = 0D;
            this.documentViewer2.ZoomFactor = 1D;
            // 
            // frmViewTaxTables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 719);
            this.Controls.Add(this.documentViewer2);
            this.Name = "frmViewTaxTables";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View SARS Tax Tables";
            this.Load += new System.EventHandler(this.frmViewTaxTables_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private TallComponents.PDF.Document document1;
        private TallComponents.Interaction.WinForms.Controls.DocumentViewer documentViewer2;
    }
}