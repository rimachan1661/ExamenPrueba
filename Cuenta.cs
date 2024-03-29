﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuenta
{
    /* Clase que representa una cuenta corriente
     * Tiene el campo saldo que representa el saldo de la cuenta, en euros
     * La propiedad saldo devuelve el saldo que hay en la cuenta
     * Los metodos retirar e ingresar sirven para retirar o ingresar la cantidad indicada 
     * 
     * Este comentario se debe eliminar y usar comentarios de documentacion en su lugar
     */
    public class Cuenta
    {
        private decimal saldo;

        public decimal Saldo
        {
            get { return saldo; }
        }

        public void ingresar(decimal cantidad)
        {
            if (cantidad > 0)
                saldo = saldo + cantidad;
        }

        public decimal retirar(decimal cantidad)
        {
            decimal retirado = 0; //Cantidad que se retira
            if (cantidad > 0 && cantidad <= saldo)
            {
                retirado = cantidad;
                saldo = saldo - cantidad;
            }

            return retirado;
        }
    }
}

