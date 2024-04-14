namespace EFARINANGOT2
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void btn_calcular_Clicked(object sender, EventArgs e)
        {
            if(pkr_estudiante.SelectedIndex<0)
            {
                DisplayAlert("alert", "Seleccione un estudiante", "ok");
            }

            var nombre = pkr_estudiante.SelectedItem;
            var fecha = txtFecha.Date;

            decimal segimiento = Convert.ToDecimal(txtSeg1.Text);
            decimal examen = Convert.ToDecimal(txtExamen1.Text);
            decimal seg1 = segimiento * 0.3m;
            decimal exam = examen * 0.2m;

            var par = seg1 + exam;

            txtParcial1.Text = par.ToString();

            //--------------------calculo parcial 2----
            decimal segimiento2 = Convert.ToDecimal(txtSeg2.Text);
            decimal examen2 = Convert.ToDecimal(txtExamen2.Text);
            decimal seg2 = segimiento2 * 0.3m;
            decimal exam2 = examen2 * 0.2m;

            var par2 = seg2 + exam2;

            txtParcial2.Text = par2.ToString();

            //-------------------calculo finales-----

            var total = seg1 + exam + seg2 + exam2;
            txtfinal.Text = total.ToString();
            var mensaje = "REPROBADO";

            if (total > 7)
            {
                mensaje = "APROBADO";
            }
            else if (total >= 5 && total <= 6.9m)
            {
                mensaje = "COMPLEMENTARIO";
            }

            DisplayAlert("alert","Nombre: "+nombre+"\nFecha: "+fecha + "\nNota parcial 1: "+par+"\nNota parcial 2: " +par2 + "\nNota final: "+total+"\nEstado: " +mensaje, "ok");



        }

    }

}
