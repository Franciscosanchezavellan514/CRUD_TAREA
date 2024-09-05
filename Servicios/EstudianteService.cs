using WebApplication1.Models;

namespace WebApplication1.Servicios
{
    public class EstudianteService : IEstudianteService
    {
        private List<Estudiante> estudiantes;
        public EstudianteService()
        {
            estudiantes = new List<Estudiante>
            {
                new Estudiante{Id=1, Name= "pepe", State=true, DNI="6355"},
                new Estudiante{Id=2, Name= "mario", State=true, DNI="3535"},
                new Estudiante{Id=3, Name= "julio", State=true, DNI="8463"},
                new Estudiante{Id=4, Name= "luis", State=true, DNI="7353"},
            };
        }
        public Estudiante Add(Estudiante estudiante)
        {
            estudiante.Id = estudiantes.Max(p => p.Id) +1;
            return estudiante;
        }

        public void Delete(int Id)
        {
            var find = estudiantes.FirstOrDefault(p => p.Id == Id);
            if (find != null)
            {
                Console.WriteLine(find);
                estudiantes.Remove(find);
            }
        }

        public List<Estudiante> GetALL()
        {
            return estudiantes;
        }

        public Estudiante GetByID(int Id)
        {
            

            return estudiantes.FirstOrDefault(p => p.Id == Id);
        }

        public void Update(Estudiante estudiante)
        {
            var find = estudiantes.FirstOrDefault(p => p.Id == estudiante.Id);
            if (find ! == null)
            {
                find.Name = estudiante.Name;
                find.DNI = estudiante.DNI;
            }

            
        }
    }
} 
