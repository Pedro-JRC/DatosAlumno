
namespace DatosAlumno
{
    public class Alumno
    {
        // PROPIEDADES
        public string Nombre { get; set; } 
        public string Matricula { get; set; }
        public string Carrera { get; set; }
        public List<int> Calificaciones { get; set; }

        // CONSTRUCTOR
        public Alumno(string nombre, string matricula, string carrera, List<int> calificaciones)
        {
            Nombre = nombre;
            Matricula = matricula;
            Carrera = carrera;
            Calificaciones = calificaciones;
        }

        // METODO PARA CALCULAR PROMEDIO
        public double calcularPromedio()
        { 
            return Calificaciones.Average();   
        }

        // METODO PARA MOSTRAR LA INFORMACION
        public void mostrarInformacion()
        {
            Console.WriteLine($"\nNombre: {Nombre}");
            Console.WriteLine($"Matricula: {Matricula}");
            Console.WriteLine($"Carrera: {Carrera}");
            Console.WriteLine($"Promedio: {calcularPromedio()}");
        }
    }
}
