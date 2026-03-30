namespace MauiAppMinhasCompras.Views;

public partial class Relatorio : ContentPage
{
	public Relatorio()
	{
        InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
        DateTime inicio = (DateTime)dt_pckInicio.Date;
        DateTime fim = (DateTime)dt_pckFim.Date;

       if (inicio> fim)
        {
            await DisplayAlert("Erro", "Data inicial maior que final", "ok");
        }

        var produtos = await App.Db.GetProdutosPorPeriodo(inicio, fim);

        lst_produtos.ItemsSource = produtos;


    }
}