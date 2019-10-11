using System;

namespace Handshakes
{
    class Program
    {
        static void Main(string[] args)
        {
            int number_students = 30;
            int total_handshakes = 0;

            while (number_students > 0)
            {
                number_students--;
                total_handshakes = total_handshakes + number_students;

            }

            Console.WriteLine(total_handshakes);
        }
    }
}
