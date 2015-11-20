using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace w12b_ComboEnlazado2
{
    class Pelicula
    {
        int id;
        String nombre;
        int duracion;
        int año;
        String director;

        public Pelicula()
        {
           
        }

        public Pelicula(int id, String nombre, int duracion, int año, String director)
        {
            this.id = id;
            this.nombre = nombre;
            this.duracion = duracion;
            this.año = año;
            this.director = director;
        }

        public Pelicula(String registro)
        {
            String[] partesRegistro = new String[5];
            partesRegistro = registro.Split(';');

            id = Convert.ToInt32(partesRegistro[0]);
            nombre = partesRegistro[1];
            duracion = Convert.ToInt32(partesRegistro[2]);
            año = Convert.ToInt32(partesRegistro[3]);
            director = partesRegistro[4];
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int Duracion
        {
            get { return duracion; }
            set { duracion = value; }
        }

        public int Año
        {
            get { return año; }
            set { año = value; }
        }

        public String Director
        {
            get { return director; }
            set { director = value; }
        }
    }
}
