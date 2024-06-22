//Importan los espacios de nombres System y System.IO, que proporcionan las clases y métodos necesarios para trabajar con archivos y directorios
using System;
using System.IO;

//Se define una clase llamada Program
class Program
{
    //Este es el método principal (Main) que se ejecuta cuando se inicia el programa. Es el punto de entrada para la aplicación
    //El modificador static significa que este método pertenece a la clase Program en lugar de una instancia específica de la clase
    static void Main()
    {
        //Se declara una variable llamada filePath que almacena la ruta completa del archivo de texto que se va a leer
        //En este caso, el archivo se encuentra en la ubicación especificada
        string filePath = @"C:\Users\Fabian\Documents\UNISUR\Programación 1\Texto de prueba Try Catch.txt";

        //Comienza un bloque try, que se utiliza para manejar excepciones. El código dentro de este bloque intentará ejecutarse sin errores
        try
        {
    //Aquí se crea un objeto StreamReader para leer el contenido del archivo. El using asegura que el recurso se libere correctamente después de su uso
            using (StreamReader reader = new StreamReader(filePath))
            {
                //ee todo el contenido del archivo y lo almacena en la variable content
                string content = reader.ReadToEnd();

                //Imprime un mensaje en la consola para indicar que se mostrará el contenido del archivo.
                Console.WriteLine("Contenido del archivo:");

                //Imprime el contenido del archivo en la consola.
                Console.WriteLine(content);
            }
        }
        // Primera excepción si el archivo no se encuentra en la ruta especificada, se captura esta excepción y se muestra un mensaje de error
        catch (FileNotFoundException e)
        {
            //Imprime en la consola el mensaje: Error: El archivo no fue encontrado
            Console.WriteLine("Error: El archivo no fue encontrado.");

            //Imprime en la consola el texto Detalles: e. Message en este caso FileNotFoundException
            Console.WriteLine($"Detalles: {e.Message}");
        }
        //Segunda excepción si no tienes permiso para acceder al archivo, se captura esta excepción y se muestra un mensaje de error
        catch (UnauthorizedAccessException e)
        {
            //Imprime en la consola el mensaje: Error: No tiene permiso para acceder al archivo
            Console.WriteLine("Error: No tiene permiso para acceder al archivo.");

            //Imprime en la consola el texto Detalles: e. Message en este caso UnauthorizedAccessException
            Console.WriteLine($"Detalles: {e.Message}");
        }
        //Tercera excepción este bloque captura cualquier otra excepción no especificada anteriormente y muestra un mensaje genérico de error
        catch (Exception e)
        {
            //Imprime en la consola el mensaje: Error: Ocurrió un error al intentar abrir el archivo
            Console.WriteLine("Error: Ocurrió un error al intentar abrir el archivo.");

            //Imprime en la consola el texto Detalles: e. Message en este caso Exception
            Console.WriteLine($"Detalles: {e.Message}");
        }
    }
}