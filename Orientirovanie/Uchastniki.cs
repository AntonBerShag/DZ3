using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_HW_2 {
    internal class Uchastniki {
        string Vvod(string text) {
            Console.Write(text);
            return Console.ReadLine();
            
        }

        public static int Vvod_age(string text) {
            try {
                Console.Write(text);
                return int.Parse(Console.ReadLine());
            }
            catch(Exception e) {
                Console.WriteLine(e.Message);
                Console.WriteLine("Вы ввели что-то не то, попробуйте заново.");
                return Vvod_age(text);
            }
        }

        public Uchastniki(int id, string name, int age) {
            Id = id;
            Name = name;
            Age = age;
        }

        public Uchastniki(int id) {
            Id = id;
            Name = Vvod("Введите ФИО участника: ");
            Age = Vvod_age("Введите возраст участника: ");
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public override string ToString() {
            return $"ID Участника {Id} \nФИО {Name} \nВозраст Участника {Age}";
        }
    }
}
