using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CalcularDistancia.ViewsModels
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        private double _x1;
        [ObservableProperty]
        private double _y1;
        [ObservableProperty]
        private double _x2;
        [ObservableProperty]
        private double _y2;
        [ObservableProperty]
        private string _distancia;


        [RelayCommand]
        private void CalcularDistancia()
        {
            var distancia = Math.Sqrt(
                Math.Pow(X2 - X1, 2) +
                Math.Pow(Y2 - Y1, 2)
            );
            Distancia = distancia.ToString("F2");


        }

     
    }

}
