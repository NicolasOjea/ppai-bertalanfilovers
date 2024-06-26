﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.ENTIDAD
{
    public class Bodega
    {
        //////////// ATRIBUTOS ////////////
        private static List<Bodega> bodegas = new List<Bodega>();
        private List<float> coordenadasUbicacion;
        private string descripcion;
        private string historia;
        private string nombre;
        private int periodoActualizacion;
        private DateTime fechaDeActualizacion;



        public Bodega(string nombre, string historia, string descripcion, int periodoActualizacion, List<float> coordenadasUbicacion, DateTime fechaDeActualizacion)
        {
            coordenadasUbicacion = new List<float>();
            this.descripcion = nombre;
            this.historia = historia;
            this.nombre = nombre;
            this.periodoActualizacion = periodoActualizacion;
            this.fechaDeActualizacion = fechaDeActualizacion;
            bodegas.Add(this);
        }

        //////////// SETS Y GETS ////////////
        public List<float> CoordenadasUbicacion
        {
            get { return coordenadasUbicacion; }
            set { coordenadasUbicacion = value; }
        }

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public string Historia
        {
            get { return historia; }
            set { historia = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int PeriodoActualizacion
        {
            get { return periodoActualizacion; }
            set { periodoActualizacion = value; }
        }


        //////////// TERMINAN SETS Y GETS ////////////

        //////////// MÉTODOS ////////////
 

 
        public string estaParaActualizar()
        {
            int dias = (DateTime.Now - this.fechaDeActualizacion).Days;
            if (dias >= (this.periodoActualizacion*30))
            {
                return getNombre();
            }
            else
            {
                return "";
            }
        }

        public string getNombre()
        {
            return nombre;
        }
        
    }
}
