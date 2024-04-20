namespace EFARINANGOT2.Vistas;

public partial class vLogin : ContentPage
{
    string[] user;
    string[] pass;
    public vLogin()
	{
		InitializeComponent();
	}

	public void btn_ingreso_Clicked(object sender, EventArgs e)
	{
		user = ["Carlos","Ana","Jose" ];
		pass = ["carlos123", "ana123", "jose123"];
		int encontrado = 0;
		string usuario = txtUsuario.Text;
		string contra = txtContra.Text;
		for (int i = 0;i< user.Length;i++)
		{
			if (user[i] == usuario && pass[i] == contra)
			{

                Navigation.PushAsync(new MainPage(usuario));
                encontrado = 1;
				break;
			}
		}
		if (encontrado == 0)
        {
            DisplayAlert("Alerta", "Usuario o contraseña invalidos ", "cerrar");
        }


	}
}