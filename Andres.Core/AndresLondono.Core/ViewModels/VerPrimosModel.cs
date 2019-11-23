using AndresLondono.Core.Services;
using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace AndresLondono.Core.ViewModels
{
    public class VerPrimosModel: MvxViewModel
    {
        private readonly ICalcularPrimosService calcularPrimosService;
        private int _cantidad;
        private string _cadena;
        public VerPrimosModel(ICalcularPrimosService calcularPrimosService)
        {
            this.calcularPrimosService = calcularPrimosService;
        }

        public int Cantidad
        {
            get => _cantidad;
                set
            {
                _cantidad = value;
                RaisePropertyChanged(() => Cantidad);


            }
        }
        public string Cadena
        {
            get => _cadena;
            set
            {
                _cadena = value;
                RaisePropertyChanged(() => Cadena);


            }
        }
    }
}
