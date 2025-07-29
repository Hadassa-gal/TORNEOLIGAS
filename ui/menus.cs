using System;
using System.Threading;

namespace Ui
{
    public static class Menus
    {

        public static void MostrarMenuPrincipal()
        {
            Console.Clear();
            string titulo = "✦ MENÚ PRINCIPAL ✦";
            DecoMenus.DibujarBordeSuperior(titulo);
            DecoMenus.MostrarOpcion("1) Crear Torneo");
            DecoMenus.MostrarOpcion("2) Registro de equipos");
            DecoMenus.MostrarOpcion("3) Registro de jugadores");
            DecoMenus.MostrarOpcion("4) Transferencias");
            DecoMenus.MostrarOpcion("5) Estadísticas");
            DecoMenus.MostrarOpcion("6) Salir");
            DecoMenus.DibujarBordeInferior("¡Elige una opción para continuar!");
            DecoMenus.MostrarPrompt();
        }
        public static void MostrarMenuTorneo()
        {
            Console.Clear();
            string titulo = "✦ MENÚ TORNEOS ✦";
            DecoMenus.DibujarBordeSuperior(titulo);
            DecoMenus.MostrarOpcion("1) Crear");
            DecoMenus.MostrarOpcion("2) Buscar");
            DecoMenus.MostrarOpcion("3) Eliminar");
            DecoMenus.MostrarOpcion("4) Actualizar");
            DecoMenus.MostrarOpcion("5) Regresar al main menu");
            DecoMenus.DibujarBordeInferior("¡Elige una opción para continuar!");
            DecoMenus.MostrarPrompt();
        }
        public static void MostrarMenuEquipos()
        {
            Console.Clear();
            string titulo = "✦ MENÚ EQUIPOS ✦";
            DecoMenus.DibujarBordeSuperior(titulo);
            DecoMenus.MostrarOpcion("1) Crear Equipo");
            DecoMenus.MostrarOpcion("2) Registrar cuerpo tecnico");
            DecoMenus.MostrarOpcion("3) Registrar cuerpo medico");
            DecoMenus.MostrarOpcion("4) Inscripcion a torneo");
            DecoMenus.MostrarOpcion("5) Salir de torneo");
            DecoMenus.MostrarOpcion("6) Notificacion de transferencias");
            DecoMenus.MostrarOpcion("7) Regresar al main menu");
            DecoMenus.DibujarBordeInferior("¡Elige una opción para continuar!");
            DecoMenus.MostrarPrompt();
        }
        public static void MostrarMenuJugadores()
        {
            Console.Clear();
            string titulo = "✦ MENÚ JUGADORES ✦";
            DecoMenus.DibujarBordeSuperior(titulo);
            DecoMenus.MostrarOpcion("1) Crear");
            DecoMenus.MostrarOpcion("2) Buscar");
            DecoMenus.MostrarOpcion("3) Eliminar");
            DecoMenus.MostrarOpcion("4) Actualizar");
            DecoMenus.MostrarOpcion("5) Regresar al main menu");
            DecoMenus.DibujarBordeInferior("¡Elige una opción para continuar!");
            DecoMenus.MostrarPrompt();
        }
        //faltan los menus de transferencias y estadisticas
    }
    public static class DecoMenus
    {
        private const ConsoleColor TituloColor = ConsoleColor.Magenta;
        private const ConsoleColor OpcionesColor = ConsoleColor.Red;
        private const ConsoleColor PromptColor = ConsoleColor.Yellow;
        private const ConsoleColor DecoracionColor = ConsoleColor.Cyan;
        private const int AnchoBase = 50;
        public static void DibujarBordeSuperior(string titulo)
        {
            int ancho = Math.Max(AnchoBase, titulo.Length + 10);
            Console.ForegroundColor = DecoracionColor;
            Console.WriteLine("\n 　");
            Console.WriteLine(@" (\(\  ");
            Console.WriteLine(@"（ • •）♡°");
            Console.WriteLine("┏---UU" + new string('-', ancho - 7) + "┓");
            int espacios = (ancho - titulo.Length) / 2;
            Console.WriteLine("┃" + new string(' ', espacios) + titulo + new string(' ', ancho - titulo.Length - espacios - 2) + "┃");
            Console.WriteLine("┣" + new string('━', ancho - 2) + "┫");
            Console.ResetColor();
        }
        public static void DibujarBordeInferior(string mensaje)
        {
            int ancho = AnchoBase; // O calcular dinámicamente si es necesario

            Console.ForegroundColor = DecoracionColor;
            Console.WriteLine("┣" + new string('━', ancho - 2) + "┫");

            // Mensaje centrado
            int espacios = (ancho - mensaje.Length) / 2;
            Console.WriteLine("┃" + new string(' ', espacios) + mensaje + new string(' ', ancho - mensaje.Length - espacios - 2) + "┃");

            // Arte ASCII inferior
            Console.WriteLine("┗" + new string('━', ancho - 2) + "┛");
            Console.WriteLine(@"  (´｡• ω •｡`) ♡");
            Console.WriteLine(@"    ﾟ･:.｡. .｡.:･ﾟ");
            Console.ResetColor();
        }
        public static void MostrarOpcion(string textoOpcion)
        {
            //Console.ForegroundColor = OpcionesColor;
            Console.WriteLine("  " + textoOpcion);
        }
        public static void MostrarPrompt()
        {
            Console.ForegroundColor = PromptColor;
            Console.Write("\n╰(^▽^)➝ Seleccione una opción: ");
            Console.ResetColor();
        }
    }
    public static class Animaciones
    {
        public static void MostrarAnimacionCarga(string mensaje)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Random rnd = new Random();
            int progreso = 0;
            Console.WriteLine($"\n\n  {mensaje}...\n");
            while (progreso < 100)
            {
                int incremento = rnd.Next(5, 15);
                progreso = Math.Min(progreso + incremento, 100);
                int barrasCompletas = (int)(progreso / 100.0 * 20);
                Console.Write("  [");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write(new string('█', barrasCompletas));
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write(new string(' ', 20 - barrasCompletas));
                Console.WriteLine($"] {progreso}%");
                Thread.Sleep(200);
                if (progreso < 100)
                {
                    Console.SetCursorPosition(0, Console.CursorTop - 1);
                }
            }
            Console.ResetColor();
            Console.WriteLine("\n  ¡Listo! (ﾉ◕ヮ◕)ﾉ*:･ﾟ✧");
            Thread.Sleep(500);
        }
    }
    public static class Acceptordeny
    {
        public static void MostrarError(string mensaje)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"\n  ✘ Error: {mensaje} (╥﹏╥)");
            Console.ResetColor();
            Console.WriteLine("  Presione cualquier tecla para continuar...");
            Console.ReadKey();
        }
        public static void MostrarExito(string mensaje)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\n  ✓ {mensaje} (★ω★)");
            Console.ResetColor();
            Thread.Sleep(1000);
        }
    }
}