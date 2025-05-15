using System;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System.Collections;

namespace IPublica.IU.Win.Gen.General
{
	public partial class FrmPlantas
	{
        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        protected override void Dispose(bool disposing)
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPlantas));
            this.xpGroupBoxFiltro = new IASoft.XPControls.XpGroupBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.xpGroupBox2 = new IASoft.XPControls.XpGroupBox();
            this.gridPlantas = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.btnAnadir = new IASoft.XPControls.XpButton();
            this.btnEliminar = new IASoft.XPControls.XpButton();
            this.btnModificar = new IASoft.XPControls.XpButton();
            this.btnSeleccionar = new IASoft.XPControls.XpButton();
            this.btnCerrar = new IASoft.XPControls.XpButton();
            this.localizationFilter1 = new IASoft.Localization.LocalizationFilter();
            this.xpGroupBoxFiltro.SuspendLayout();
            this.xpGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPlantas)).BeginInit();
            this.SuspendLayout();
            // 
            // xpGroupBoxFiltro
            // 
            this.xpGroupBoxFiltro.Controls.Add(this.txtDescripcion);
            this.xpGroupBoxFiltro.Controls.Add(this.lblDescripcion);
            this.xpGroupBoxFiltro.Dock = System.Windows.Forms.DockStyle.Top;
            resources.ApplyResources(this.xpGroupBoxFiltro, "xpGroupBoxFiltro");
            this.xpGroupBoxFiltro.Name = "xpGroupBoxFiltro";
            this.xpGroupBoxFiltro.TabIndex = 0;
            this.xpGroupBoxFiltro.TabStop = false;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.txtDescripcion, "txtDescripcion");
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.TabIndex = 4;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.CausesValidation = false;
            resources.ApplyResources(this.lblDescripcion, "lblDescripcion");
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.TabIndex = 3;
            // 
            // xpGroupBox2
            // 
            this.xpGroupBox2.Controls.Add(this.gridPlantas);
            this.xpGroupBox2.Controls.Add(this.btnAnadir);
            this.xpGroupBox2.Controls.Add(this.btnEliminar);
            this.xpGroupBox2.Controls.Add(this.btnModificar);
            this.xpGroupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            resources.ApplyResources(this.xpGroupBox2, "xpGroupBox2");
            this.xpGroupBox2.Name = "xpGroupBox2";
            this.xpGroupBox2.TabIndex = 1;
            this.xpGroupBox2.TabStop = false;
            this.xpGroupBox2.Enter += new System.EventHandler(this.xpGroupBox2_Enter);
            // 
            // gridPlantas
            // 
            this.gridPlantas.AllowDelete = true;
            this.gridPlantas.AllowFilter = false;
            this.gridPlantas.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.IndividualRows;
            this.gridPlantas.AllowUpdate = false;
            this.gridPlantas.AlternatingRows = true;
            this.gridPlantas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridPlantas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridPlantas.CaptionHeight = 17;
            this.gridPlantas.ExtendRightColumn = true;
            this.gridPlantas.ForeColor = System.Drawing.Color.Black;
            this.gridPlantas.GroupByCaption = "Drag a column header here to group by that column";
            this.gridPlantas.Images.Add(((System.Drawing.Image)(resources.GetObject("gridPlantas.Images"))));
            resources.ApplyResources(this.gridPlantas, "gridPlantas");
            this.gridPlantas.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.HighlightRow;
            this.gridPlantas.MultiSelect = C1.Win.C1TrueDBGrid.MultiSelectEnum.None;
            this.gridPlantas.Name = "gridPlantas";
            this.gridPlantas.PreviewInfo.Location = ((System.Drawing.Point)(resources.GetObject("gridPlantas.PreviewInfo.Location")));
            this.gridPlantas.PreviewInfo.Size = ((System.Drawing.Size)(resources.GetObject("gridPlantas.PreviewInfo.Size")));
            this.gridPlantas.PreviewInfo.ZoomFactor = ((double)(resources.GetObject("gridPlantas.PreviewInfo.ZoomFactor")));
            this.gridPlantas.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("gridPlantas.PrintInfo.PageSettings")));
            this.gridPlantas.RecordSelectors = false;
            this.gridPlantas.RowHeight = 15;
            this.gridPlantas.TabIndex = 0;
            // 
            // btnAnadir
            // 
            this.btnAnadir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnadir.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.btnAnadir, "btnAnadir");
            this.btnAnadir.Name = "btnAnadir";
            this.btnAnadir.TabIndex = 1;
            this.btnAnadir.Click += new System.EventHandler(this.btnAnadir_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.btnEliminar, "btnEliminar");
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificar.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.btnModificar, "btnModificar");
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSeleccionar.DialogResult = System.Windows.Forms.DialogResult.OK;
            resources.ApplyResources(this.btnSeleccionar, "btnSeleccionar");
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.TabIndex = 2;
            this.btnSeleccionar.Visible = false;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.btnCerrar, "btnCerrar");
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.TabIndex = 3;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // FrmPlantas
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.CancelButton = this.btnCerrar;
            this.ClientSize = new System.Drawing.Size(506, 384);
            this.Controls.Add(this.xpGroupBox2);
            this.Controls.Add(this.xpGroupBoxFiltro);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.btnCerrar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(514, 411);
            this.Name = "FrmPlantas";
            this.Padding = new System.Windows.Forms.Padding(14, 12, 14, 44);
            this.PalabraClaveAyuda = "D2H_C_digosdePlanta_C_digosdeEscalera";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            resources.ApplyResources(this, "$this");
            this.xpGroupBoxFiltro.ResumeLayout(false);
            this.xpGroupBoxFiltro.PerformLayout();
            this.xpGroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridPlantas)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		private IASoft.XPControls.XpGroupBox xpGroupBoxFiltro;
		private System.Windows.Forms.TextBox txtDescripcion;
		private System.Windows.Forms.Label lblDescripcion;
		private IASoft.XPControls.XpGroupBox xpGroupBox2;
		private IASoft.XPControls.XpButton btnAnadir;
		private IASoft.XPControls.XpButton btnEliminar;
		private IASoft.XPControls.XpButton btnModificar;
		private IASoft.XPControls.XpButton btnSeleccionar;
		private IASoft.XPControls.XpButton btnCerrar;
		private IASoft.Localization.LocalizationFilter localizationFilter1;
		private C1.Win.C1TrueDBGrid.C1TrueDBGrid gridPlantas;
		private System.ComponentModel.Container components = null;

	}
}
