﻿using System;

namespace BibliotecaCLases.Modelo
{
    public class Curso
    {
        private string _nombre;
        private string _codigo;
        private string _descripcion;
        private int _cupoMaximo;
        private int _cuposDisponibles;
        private int _id;
        private bool _activo;
        private static int _ultimoID = 0;

        public Curso(string nombre, string codigo, string descripcion, string cupoMaximo, int? id = null)
        {
            _nombre = nombre;
            _codigo = codigo;
            _descripcion = descripcion;

            if (int.TryParse(cupoMaximo, out int cupoMaximoValor))
            {
                _cupoMaximo = cupoMaximoValor;
            }
            else
            {
                _cupoMaximo = 0; // Valor predeterminado en caso de que la conversión falle
            }

            if (id.HasValue)
            {
                _id = id.Value;
            }
            else
            {
                _id = GenerarNuevoID(); // Generar un nuevo ID si no se proporciona uno
            }


            _cuposDisponibles = _cupoMaximo;
            _activo = true; // Por defecto, el curso está activo
        }



        public override string ToString()
        {
            return $"{Codigo,-19} {Nombre,-15} {Descripcion,-18} {CupoMaximo,9} cupos {CuposDisponibles,15} cupos disponibles";
        }

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public string Codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }

        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }

        public int CupoMaximo
        {
            get { return _cupoMaximo; }
            set { _cupoMaximo = value; }
        }

        public int CuposDisponibles
        {
            get { return _cuposDisponibles; }
            set { _cuposDisponibles = value; }
        }

        public int ID
        {
            get { return _id; }
        }

        public bool Activo
        {
            get { return _activo; }
            set { _activo = value; }
        }

        private int GenerarNuevoID()
        {
            _ultimoID++;
            return _ultimoID;
        }

        public static int GetUltimoID()
        {
            return _ultimoID;
        }

        public static void SetUltimoID(int ultimoID)
        {
            _ultimoID = ultimoID;
        }

    }
}
