/*LUG - ACTIVIDAD ITINERARIO 11 - REFACTORIZACION DEL PRIMER EXAMEN PARCIAL 
 * PROFESOR: ARIGOS GONZALO
 * ALUMNO: MONTENEGRO FERNANDO AGUSTIN
 */


using BEntity;
using BLL;
using Microsoft.VisualBasic;
using System.Windows.Forms;

namespace UI
{
    public partial class FormPartidos : Form
    {
        private List<BEPartido> listaPartidos;  //Se carga desde la BD
        private List<BEDeporte> listaDeportes;  //se carga desde la BD
        private List<BEPartido> listaPartidosBorrador; //son los partidos que estarán en memoria, no en la BD
        public FormPartidos()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            //salgo de la aplicación
            Application.Exit();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                BEPartido partido = ObtenerPartidoDesdeFormulario();

                BLLPartido.GuardarPartido(partido); //llamo al método de la BLL para guardar el partido

                ActualizarDGV();

                MessageBox.Show("Partido guardado correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private BEPartido ObtenerPartidoDesdeFormulario()
        {
            BEPartido partido = new BEPartido();
            partido.Deporte = new BEDeporte();
            partido.Deporte.IdDeporte = Convert.ToInt32(comboBoxDeporte.SelectedValue);
            partido.Deporte.Descripcion = comboBoxDeporte.Text;
            partido.EquipoLocal = txbEquipoLocal.Text;
            partido.EquipoVisitante = txbEquipoVisitante.Text;
            partido.FechaRegistro = DateTime.Now.Date; // la fecha de registro será la fecha actual (no considero la hora para que poder modificar partidos del mismo dia)
            partido.FechaPartido = Convert.ToDateTime(dateTimePickerPartido.Text).Date;  //la  fecha del partido será la elegida en el datetimepicker
            return partido;
        }

        private void FormPartidos_Load(object sender, EventArgs e)
        {
            try
            { //procedo a cargar el combo box con los datos que obtengo del listado de deportes
                listaDeportes = BLLDeporte.ObtenerListaDeportes();
                comboBoxDeporte.DataSource = listaDeportes;
                comboBoxDeporte.ValueMember = "IdDeporte";
                comboBoxDeporte.DisplayMember = "Descripcion"; //se muestra la descripcion en el combo

                listaPartidosBorrador = new List<BEPartido>(); //inicializo la lista de partidos borrador

                //actualizo el DGV (en la primer carga solo mostrara los nombres de las columnas de la tabla partidos)
                ActualizarDGV();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void ActualizarDGV()
        {
            try
            {
                listaPartidos = BLLPartido.ObtenerListaPartidos();

                dgvPartidos.DataSource = null;
                dgvPartidos.DataSource = listaPartidos;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                BLLPartido.EliminarPartido(Convert.ToInt32(txbIdEliminar.Text));
                ActualizarDGV();
                MessageBox.Show("Partido eliminado correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                //modifico el partido tomando el ID del textbox más los dos textboxs con los marcadores local y visitante

                BLLPartido.ModificarResultado(Convert.ToInt32(txbIdActualizar.Text), Convert.ToInt32(txbMarcadorLocal.Text), Convert.ToInt32(txbMarcadorVisitante.Text));
                ActualizarDGV(); //actualizo el DGV para que queden reflejados los nuevos resultados de los marcadores
                MessageBox.Show("Los marcadores han sido modificados correctamente");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAgregarPartido_Click(object sender, EventArgs e)  //boton agregado
        {
            //agrega el estudiante a la lista borrador en memoria
            try
            {
                BEPartido partido = ObtenerPartidoDesdeFormulario();
                listaPartidosBorrador.Add(partido);
                MessageBox.Show("El Partido ha sido agregado a la lista borrador (memoria)"); //no se actualiza el DGV de partidos porque está en memoria, no en la BD
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            //carga la lista de borrador de estudiantes en la BD
            try
            {
                if (listaPartidosBorrador.Count > 0)
                {
                    BLLPartido.CargarListaPartidos(listaPartidosBorrador);
                    ActualizarDGV();
                    MessageBox.Show("Lista de partidos cargada con éxito");
                    listaPartidosBorrador.Clear(); //vacío la lista ya que la que se estaba trabajando se cargó en la BD    
                }
                else MessageBox.Show("La lista borrador de partidos está vacía, complete con al menos un partido");
                
            }
            catch (Exception ex)
            {
                listaPartidosBorrador.Clear(); //vacío la lista si es que hubo un error en alguno de sus estudiantes
                MessageBox.Show(ex.Message);
            }
        }
    }
}