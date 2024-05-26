﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Pinguino : Ave
    {
        public double Peso { get; set; }
        public string Especie { get; set; }

        public Pinguino()
        {

        }

        public Pinguino(string nombre, Habitat habitat, int edad) 
            :base(nombre, habitat, edad)
        {

        }

        public Pinguino(string nombre, Habitat habitat, int edad, double peso)
            :this(nombre, habitat, edad)
        {
            this.Peso = peso;
        }

        public Pinguino(string nombre, Habitat habitat, int edad, double peso, string especie)
            :this(nombre, habitat, edad, peso)
        {
            this.Especie = especie;
        }

        public override void Volar()
        {
            Console.WriteLine($"{this.Nombre} no puede volar.");
        }

        public void Jugar()
        {
            Console.WriteLine($"{this.Nombre} está jugando.");
        }

        public void Jugar(string nombre)
        {
            Console.WriteLine($"{this.Nombre} y {nombre} están jugando.");
        }

        public override string ToString()
        {
            return $"{base.ToString()} \nPeso: {this.Peso} \nEspecie: {this.Especie}";
        }

        public override bool Equals(object obj)
        {
            if (obj is Pinguino)
            {
                Pinguino ave = (Pinguino)obj;
                return base.Equals(ave) && this.Nombre == ave.Nombre && this.Edad == ave.Edad && this.Habitat == ave.Habitat;
            }
            return false;
        }

        public static bool operator ==(Pinguino p1, Pinguino p2)
        {
            return p1.Equals(p2);
        }

        public static bool operator !=(Pinguino p1, Pinguino p2)
        {
            return !(p1 == p2);
        }
    }
}
