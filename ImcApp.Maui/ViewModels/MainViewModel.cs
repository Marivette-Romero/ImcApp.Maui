using ImcApp.Maui.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;

//Actualizacion 14/10/26

namespace ImcApp.Maui.ViewModels
{
    public class MainViewModel: INotifyPropertyChanged 
    {
        private string _peso;
        private string _estatura;
        private string _imc;
        private string _situacionNutricional;
        


        public string Peso
        {
            get => _peso;
            set {
                if (_peso != value)
                {
                    _peso = value;
                    OnPropertyChanged(nameof(Peso));
                }
            }

        }
        public string Estatura
        {
            get => _estatura;
            set
            {
                if (_estatura != value)
                {
                    _estatura = value;
                    OnPropertyChanged(nameof(Estatura));
                }
            }
        }
        public string Imc
        {
            get => _imc;
            set
            {
                if (_imc != value)
                {
                    _estatura = value;
                    OnPropertyChanged(nameof(Imc));
                }
            }
        }

        public string SituacionNutricional
        {
            get => _situacionNutricional;
            set
            {
                if (_situacionNutricional != value)
                {
                    _estatura = value;
                    OnPropertyChanged(nameof(SituacionNutricional));
                }
            }
        }


        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged(string propertyname)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyname));
            }
        }
        public ICommand CalcularCommand { get; private set; }
        public ICommand LimpiarCommand { get; private set; }
        public MainViewModel()
        {
            //Peso = string.Empty;
            //Estatura = string.Empty;
            //Imc = string.Empty;
            //SituacionNutricional = string.Empty;
            LimpiarValores();
            CalcularCommand = new Command(Calcular);
            LimpiarCommand = new Command(LimpiarValores);
        }
        private void LimpiarValores()
        {
            Peso = string.Empty;
            Estatura = string.Empty;
            Imc = string.Empty;
            SituacionNutricional= string.Empty;
        }
        public void Calcular()
        {

            decimal peso;
            bool pesoEsValido = decimal.TryParse(Peso, out peso);
            decimal estatura;
            bool estaturaEsValida = decimal.TryParse(Estatura, out estatura);

            if (pesoEsValido && estaturaEsValida)
            {
                decimal imc = CaluladoraDeIndiceDeMasaCorporal.IndiceDeMasaCorporal(peso, estatura);
                Imc = imc.ToString("F4");
                SituacionNutricional = CaluladoraDeIndiceDeMasaCorporal.SituacionNutricional(imc);
            }
        }
    }
}
