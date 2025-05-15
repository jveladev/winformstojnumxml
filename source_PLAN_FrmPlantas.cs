/*
* (c) IASoft Aragón S.L.
* Proyecto: General 
* Archivo: FrmPlantas.cs
* Descripción: Listado de Códigos de planta
* Historia:
*	Pablo Franco 06-07-2005	Generacion inicial
*/

using System;
using System.Data;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using IPublica.IU.Win.Base;
using IPublica.IU.Win.Base.TrueDBGrid;
using IPublica.Neg.Base;
using IPublica.Neg.Gen.General;

namespace IPublica.IU.Win.Gen.General
{
	/// <summary>
	/// Descripción breve de FrmPlantas.
	/// </summary>
	public partial class FrmPlantas : FormBase
	{
		#region Atributos
		private IPlanta mPPlanta;
		private DSBase mdsData;
		private DataView mdvGrid;
		#endregion

		#region Constructor / Destructor
		/// <summary>
		/// 
		/// </summary>
		/// <param name="tpEstiloVentana"></param>
		public FrmPlantas(TipoFormEstilo tpEstiloVentana):base(tpEstiloVentana)
		{
			InitializeComponent();
		}

		#endregion

		#region Métodos Públicos		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="parametrosBusca"></param>
		/// <param name="cargar"></param>
		/// <returns></returns>
		public override int IniciarFormulario(FiltroVal []parametrosBusca, bool cargar)
		{
			int intNumFilas=0;			
			try
			{
				
				base.NombreObjeto = "GenPlanta";
				if (PermisosBotones())
				{
					mPPlanta=(IPlanta)Factoria.GetObject(typeof(IPlanta));

                    ArrayList arrParams = new ArrayList();
                    if (parametrosBusca != null)
                    {
                        foreach (FiltroVal param in parametrosBusca)
                        {
                            arrParams.Add(param);
                        }
                    }

                    CrearFiltros();

                    FiltroVal[] parametros = null;
                    if (arrParams.Count > 0)
                    {
                        parametros = new FiltroVal[arrParams.Count];
                        arrParams.CopyTo(parametros);
                    }

					GetControlFiltros(xpGroupBoxFiltro).SetParametros(parametrosBusca);					
					this.GetControlGrid().SetConfigGrid(this.gridPlantas, this.btnAnadir, this.btnModificar, this.btnEliminar);

					if(cargar)	
					{	
						intNumFilas=Buscar(xpGroupBoxFiltro);
						xpGroupBox2.TabIndex=0;
						xpGroupBoxFiltro.TabIndex=1;
					}
					else
					{
						xpGroupBox2.TabIndex=1;
						xpGroupBoxFiltro.TabIndex=0;
						ActualizarBotones();
					}

					base.IniciarFormulario(parametrosBusca,cargar);
				}
			}
			catch (Excepcion ex)
			{
				this.GetControlExcepciones().MostrarExcepcion(ex);
			}
			return intNumFilas;
		}

		/// <summary>
		/// Este método se invoca cuando se cierra un form de edicción para actualizar
		/// el grid
		/// <param name="data">Control que lo llama</param>		
		/// </summary>	
		public override void NotifyParent(DSBase data)
		{
			try
			{
				Columna []filtrosAplicados = GetControlFiltros(xpGroupBoxFiltro).GetLastFiltros();
				//Sólamente recargamos la fila si se había realizado anteriormente una búsqueda
				if(filtrosAplicados!=null && filtrosAplicados.Length>0)
				{
					int numReg=EnlazarGrid(mPPlanta.Busca(GetControlFiltros(xpGroupBoxFiltro).GetLastFiltros(data.Tabla.FilaActual.ClavePrimaria)),false);
					GetControlGrid().SeleccionarFilaActiva(this.gridPlantas ,data.Tabla.FilaActual);
					gridPlantas.Focus();
				}
				else
				{
					EnlazarGrid(data, false);
				}
			}
			catch(Excepcion ex)
			{
				this.GetControlExcepciones().MostrarExcepcion(ex);
			}
		}

		/// <summary>
		/// Llama al metodo buscar de persistencia y el resultado lo introduce en el grid.
		/// </summary>
		/// <param name="contenedor"></param>
		/// <returns></returns>
		public override int Buscar(Control contenedor)
		{				
			this.Cursor=Cursors.WaitCursor;
            Columna[] colSuma = new Columna[] { new Columna("IdEntidad", ControlUser.IdEntidad) };

            int intNumFilas = EnlazarGrid(mPPlanta.Busca(GetControlFiltros(contenedor).GetFiltros(colSuma)), true);

			gridPlantas.Focus();
			this.Cursor=Cursors.Default;
			return intNumFilas;			
		}
        /// <summary>
        /// Devuelve el dataRow seleccionado		
        /// Puede ser que provenga de una búsqueda
        /// </summary>		
        /// <returns>El dataRow seleccionado</returns>	
        public override DRBase[] ElementosSeleccionados()
        {
            return GetControlGrid().FilasSeleccionadas(gridPlantas);
        }

		#endregion

		#region Métodos Privados/Protegidos

		private int EnlazarGrid(DSBase datos, bool BorrarDatos)
		{
			if (mdsData == null)
			{
				mdsData=datos;
				mdvGrid=mdsData.Tabla.DefaultView;
				this.GetControlGrid().ActualizaGrid(this.gridPlantas,mdvGrid);
			}
			else
			{
				if (BorrarDatos)
				{
					mdsData.Clear();
				}
				mdsData.Combinar(datos);
			}
			ActualizarBotones();
			return mdvGrid.Count;
		}
		#endregion

		private void ActualizarBotones()
		{
			if (GetControlGrid().FilaSeleccionada(gridPlantas)==null)
			{
				btnEliminar.Enabled=false;
				btnModificar.Enabled=false;
				btnSeleccionar.Enabled=false;
			}
			else
			{
				btnEliminar.Enabled = true;
				btnModificar.Enabled=true;
				btnSeleccionar.Enabled=true;
			}
		}

		private void CrearFiltros()
		{
			GetControlFiltros(xpGroupBoxFiltro).Init();						
			GetControlFiltros(xpGroupBoxFiltro).AddFilter(txtDescripcion ,"Descripcion",lblDescripcion);
		}

		private bool PermisosBotones()
		{
			bool bPermiso = ControlUser.GetAccesoObjeto(base.NombreObjeto);
			if (bPermiso)
			{
				if (FormEstilo==TipoFormEstilo.Grid_Seleccion)
				{
					btnSeleccionar.Visible=true;
					xpGroupBox2.TabIndex=0;
					xpGroupBoxFiltro.TabIndex=1;
				}
				if (base.GetPermisoConsultar || base.GetPermisoListar)
				{				
					btnAnadir.Visible = false;
					btnEliminar.Visible = false;
					btnModificar.Text = RComun.Instance.GetString("BotonVer");
				}				
			}
			return bPermiso;
		}

		#region Eventos de los controles

		private void btnCerrar_Click(object sender, System.EventArgs e)
		{
			Close();
		}

		private void btnAnadir_Click(object sender, System.EventArgs e)
		{
			if (!PermitirClick(btnAnadir)) return;
			
			DSPlanta dSPlanta=new DSPlanta();
            Columna[] claveprimaria = new Columna[] { new Columna("IdEntidad", ControlUser.IdEntidad) };
			dSPlanta.GenPlanta.AgregarNueva(claveprimaria);
			FrmPlantaEdit frmPlantaEdit=new FrmPlantaEdit(dSPlanta);
			frmPlantaEdit.FormAccion=TipoFormAccion.Alta;
			AbrirFormulario(frmPlantaEdit);	
		}

		private void btnEliminar_Click(object sender, System.EventArgs e)
		{
			if (!PermitirClick(btnEliminar)) return;
			if (GetControlExcepciones().MostrarExcepcion(new Excepcion("PreguntaEliminarGenerico",RComun.Instance,TipoExcepcion.Pregunta))==DialogResult.OK)
			{
                try
                {
                    Application.DoEvents();
                    mPPlanta.Borra(GetControlGrid().ClavePrimariaSeleccionada(gridPlantas));
                    gridPlantas.Delete();
                    ActualizarBotones();
                    gridPlantas.Focus();
                }
                catch (Excepcion ex)
                {
                    this.GetControlExcepciones().MostrarExcepcion(ex);
                }
			}
		}

		private void btnModificar_Click(object sender, System.EventArgs e)
		{
			if (!PermitirClick(btnModificar)) return;
			try
			{
				
				DSPlanta dSPlanta =mPPlanta.Carga(GetControlGrid().ClavePrimariaSeleccionada(gridPlantas));
				FrmPlantaEdit frmPlantaEdit= new FrmPlantaEdit(dSPlanta);
				frmPlantaEdit.FormAccion=TipoFormAccion.Modificacion;
				AbrirFormulario(frmPlantaEdit);
				
			}
			catch(Excepcion ex)
			{
				this.GetControlExcepciones().MostrarExcepcion(ex);
			}
		}
		#endregion

		private void xpGroupBox2_Enter(object sender, System.EventArgs e)
		{
			if (FormEstilo==TipoFormEstilo.Grid_Seleccion)
			{
				this.AcceptButton=btnSeleccionar;
			}
			else
			{
				this.AcceptButton=btnModificar;
			}
		}
	}
}
