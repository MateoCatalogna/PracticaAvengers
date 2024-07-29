using PracticaAvengers;

namespace Mateo.Catalogna.Practica
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            // AVENGERS
            Marvel.Personaje = new Avenger("AnthonyStark", new List<EHabilidades>() {
EHabilidades.InteligenciaSuperior }, EEquipamiento.Armadura);

            Marvel.Personaje = new Avenger("AnthonyStark", new List<EHabilidades>() {
EHabilidades.InteligenciaSuperior }, EEquipamiento.Armadura);
            Marvel.Personaje = new Avenger("Dr Banner", new List<EHabilidades>() {
EHabilidades.InteligenciaSuperior }, EEquipamiento.Transformacion);
            Marvel.Personaje = new Avenger("Dr Banner", new List<EHabilidades>() {
EHabilidades.InteligenciaSuperior }, EEquipamiento.Transformacion);
            Marvel.Personaje = new Avenger("NatashaRomanoff ", new List<EHabilidades>() {
EHabilidades.Sigilo, EHabilidades.Astucia }, EEquipamiento.ArtesMarciales);
            Marvel.Personaje = new Avenger("Thor", new List<EHabilidades>() {
EHabilidades.Rayos, EHabilidades.Volar }, EEquipamiento.Martillo);
            Marvel.Personaje = new Avenger("Thor", new List<EHabilidades>() {
EHabilidades.Rayos, EHabilidades.Volar }, EEquipamiento.Martillo);
            //VILLANOS
            Marvel.Personaje = new Enemigo("Thanos", new List<EHabilidades>()
{EHabilidades.SuperFuerza, EHabilidades.Astucia, EHabilidades.Resistencia}, "Obtener las infinitystones y un te de vainilla");
            Marvel.Personaje = new Enemigo("Ultron", new List<EHabilidades>()
{EHabilidades.SuperFuerza, EHabilidades.Astucia, EHabilidades.Volar}, "Exterminar a los humanos");
            Marvel.Personaje = new Enemigo("Loki", new List<EHabilidades>()
{EHabilidades.Astucia }, "Dominar los 9 reinos");
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            rtbPersonajes.Text = Marvel.MostrarInformación(); 
        }
    }
}
