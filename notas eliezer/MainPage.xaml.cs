namespace notas_eliezer;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}


    private void BtnCalcularNota_Clicked(object sender, EventArgs e)
    {
        double nota1, nota2, nota3, nota4, nota5, Promedio;

        if (!string.IsNullOrEmpty(Nota1.Text)
         && !string.IsNullOrEmpty(Nota2.Text)
         && !string.IsNullOrEmpty(Nota3.Text)
         && !string.IsNullOrEmpty(Nota4.Text)
         && !string.IsNullOrEmpty(Nota5.Text))
        {
            nota1 = Convert.ToDouble(Nota1.Text);
            nota2 = Convert.ToDouble(Nota2.Text);
            nota3 = Convert.ToDouble(Nota3.Text);
            nota4 = Convert.ToDouble(Nota4.Text);
            nota5 = Convert.ToDouble(Nota5.Text);

            Promedio = (nota1 + nota2 + nota3 + nota4 + nota5) / 5;
            Prom.Text = Promedio.ToString();
        }
        else
        {
            DisplayAlert("Error", "ingrese todos los digitos", "OK");
        }
    }

    private void Cerrar_Clicked(object sender, EventArgs e) => Close();

    private void Close()
    {
        throw new NotImplementedException();
    }
}

