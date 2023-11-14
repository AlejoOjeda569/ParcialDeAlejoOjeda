using System.Drawing;
using WinFroms.Entidades;
namespace RepoWinFroms
{
    public class RepositorioDatos
    {
        private readonly string _Archivo = Environment.CurrentDirectory + "\\Cubo.txt";
        private List<Cubo> cubos;
        public RepositorioDatos()
        {
            cubos = new List<Cubo>();
            LeerDatosArchivo();
        }

        private void LeerDatosArchivo()
        {

            if (File.Exists(_Archivo))
            {
                using (var lector = new StreamReader(_Archivo))
                {
                    while (!lector.EndOfStream)
                    {
                        var lineaLeida = lector.ReadLine();
                        var cubo = construirCubo(lineaLeida);
                        cubos.Add((Cubo)cubo);
                    }
                }
            }
        }
        public List<Cubo> GetLista() => cubos;
        private object construirCubo(string? lineaLeida)
        {
            var campos = lineaLeida.Split("|");
            var AristaCubo = int.Parse(campos[0]);
            var bordeRectangulo = (Borde)int.Parse(campos[1]);
            var rellenoRectangulo = (Relleno)int.Parse(campos[2]);
            return new Cubo
            {
                Arista=AristaCubo,
                Borde = bordeRectangulo,
                Relleno = rellenoRectangulo,

            };
        }
        public void Agregar(Cubo cubo)
        {
            using (var escribir = new StreamWriter(_Archivo, true))
            {
                string lineaEscribir = construirLinea(cubo);
                escribir.WriteLine(lineaEscribir);
            }
        }

        private string construirLinea(Cubo cubo)
        {
            return $"{cubo.Arista}|{cubo.Borde.GetHashCode()}|{cubo.Relleno.GetHashCode()}";
        }
        public void Borrar(Cubo cubo)
        {

        }
    }
}