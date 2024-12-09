namespace DatosAlumno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {

                // VARIABLES
                string nombre;
                string matricula;
                string carrera;
                List<int> calificaciones = new List<int>();
                string cantCalifDigita;
                int cantCalificaciones;
                string calificacionesDigita;
                int calificacion;

                
                //SOLICITA EL NOMBRE
                Console.WriteLine("Favor ingrese el nombre del alumno: ");
                nombre = Console.ReadLine();

                // VALIDACIONES
                if (!int.TryParse(nombre, out _))
                {
                    // SOLICITA LA MATRICULA
                    Console.WriteLine("\nFavor ingrese la matricula: ");
                    matricula = Console.ReadLine();

                    // SOLICITA LA CARRERA
                    Console.WriteLine("\nFavor ingrese la carrera: ");
                    carrera = Console.ReadLine();

                    // VALIDACIONES
                    if (!int.TryParse(carrera, out _))
                    {
                        // SOLICITA LA CANTIDAD DE CALIFICACIONES A DIGITAR
                        Console.WriteLine("\nFavor ingrese la cantidad de calificaciones a digitar: ");
                        cantCalifDigita = Console.ReadLine();

                        // VALIDACIONES
                        if (int.TryParse(cantCalifDigita, out cantCalificaciones) && cantCalificaciones > 0)
                        {
                            // SOLICITA LAS CALIFICACIONES
                            Console.WriteLine("\nFavor ingrese las calificaciones:");

                            // ESPACIO
                            Console.WriteLine();

                            // BUCLE PARA SOLICITAR LAS NOTAS
                            for (int i = 0; i < cantCalificaciones; i++)
                            {
                                // SOLICITA LAS NOTAS
                                Console.Write($"Nota [{i + 1}]: ");
                                calificacionesDigita = Console.ReadLine();

                                // VALIDACIONES
                                if (int.TryParse(calificacionesDigita, out calificacion) && calificacion >= 0 && calificacion <= 100)
                                {
                                    // AGREGA LAS CALIFICACIONES A LA LISTA
                                    calificaciones.Add(calificacion);
                                }
                                else
                                {
                                    // MENSAJE DE ERROR
                                    Console.WriteLine("ERROR: Favor ingrese una calificacion entre 0 y 100.");
                                }
                            }
                        }
                        else
                        {
                            // MENSAJE DE ERROR
                            Console.WriteLine("ERROR: Favor ingrese datos validos.");
                        }

                    }
                    else
                    {
                        // MENSAJE DE ERROR
                        Console.WriteLine("ERROR: Favor ingrese datos validos.");
                    }

                    // OBJETO ALUMNO
                    Alumno alumno = new Alumno(nombre, matricula, carrera, calificaciones);

                    // MUESTRA LA INFORMACION DEL ALUMNO
                    Console.WriteLine("\nInformacion del alumno:");
                    alumno.mostrarInformacion();
                }
                else
                {
                    // MENSAJE DE ERROR
                    Console.WriteLine($"ERROR: Favor ingrese datos validos.");
                }


             
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ERROR: {ex.Message}");
            }
            
        }
    }
}
