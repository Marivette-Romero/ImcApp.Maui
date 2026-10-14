//Cambiamos el nombre de espacio en el appshell
using ImcApp.Maui.Models;
using ImcApp.Maui.ViewModels;
namespace ImcApp.Maui.Views;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        BindingContext = new MainViewModel();

    }

    //Actualizacion 14/10/26
    //private void OnCalcularButton_Clicked(object sender, EventArgs e)
    //{
    //    decimal peso;
    //    bool pesoEsValido= decimal.TryParse(PesoLabel.Text, out peso);
    //    decimal estatura;
    //    bool estaturaEsValida= decimal.TryParse(EstaturaLabel.Text, out estatura);

    //    if (pesoEsValido && estaturaEsValida)
    //    { 
    //       decimal imc = CaluladoraDeIndiceDeMasaCorporal.IndiceDeMasaCorporal(peso, estatura);
    //        IMCLabel.Text= imc.ToString("F4");
    //        SituacionNutricionalLabel.Text = CaluladoraDeIndiceDeMasaCorporal.SituacionNutricional(imc);
    //    }
    //}
    //private void OnLimpiarButton_Clicked(object sender, EventArgs e)
    //{
    //    LimpiarValores();
    //}

    //private void LimpiarValores()
    //{
    //    PesoLabel.Text = string.Empty;
    //    EstaturaLabel.Text = string.Empty;
    //    IMCLabel.Text = string.Empty;
    //    SituacionNutricionalLabel.Text = string.Empty;
    //}
}
