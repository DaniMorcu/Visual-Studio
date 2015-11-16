using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComboEjercicio
{
    class Programa
    {
        private int id;
        private String nombre;
        private String companyia;
        private String fechaActualizacion;

        public Programa() { }

        public Programa(int id, String nombre, String companyia, String fechaActualizacion)
        {
            this.id = id;
            this.nombre = nombre;
            this.companyia = companyia;
            this.fechaActualizacion = fechaActualizacion;
        }

        public int Id
        {
            get { return id; }
            set { Id = value; }
        }

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public String Companyia
        {
            get { return companyia; }
            set { Companyia = value; }
        }

        public String FechaActualizacion
        {
            get { return fechaActualizacion; }
            set { FechaActualizacion = value; }
        }
    }
}
