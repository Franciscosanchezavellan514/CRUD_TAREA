using WebApplication1.Models;
//using WebApplication1.Servicios.Interfas;

namespace WebApplication1.Servicios
{
    public interface IEstudianteService
    {
        public Estudiante Add(Estudiante estudiante);

        public List<Estudiante> GetALL();

        public Estudiante GetByID(int Id);

        public void Update(Estudiante estudiante);

        public void Delete(int Id);


    }
}
