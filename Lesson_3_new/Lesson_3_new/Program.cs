using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_3_GB //Осипенко В.О.
{
    #region Задача 1 Добавления структур и классов в Complex
    class Complex
    {
        
        #region Public Methods



        //  Пример произведения двух комплексных чисел
        public Complex Multi(Complex complex)// Задание Б
        {
            Complex c = new Complex();
            c.Re = _re * complex._im + _im * complex._re;
            c._re = _re * complex._re - _im * complex._im;
            return c;
        }
        /// <summary>
        /// Сложение комплексных чисел
        /// </summary>
        /// <param name="complex">Комплексное число</param>
        /// <returns>Результат сложения комплексных чисел</returns>
        public Complex Plus(Complex complex)
        {
            Complex c = new Complex();
            c.Re = _re + complex.Re;
            c._im = _im + complex._im;
            return c;
        }

        public Complex Minus(Complex complex)// Задание А
        {
            Complex c = new Complex();
            c.Re = _re - complex.Re;
            c._im = _im - complex._im;
            return c;
        }
        /// <summary>
        /// Перегрузка оператора +, сложение комплексных чисел
        /// </summary>
        /// <param name="complex1">Комплексное число</param>
        /// <param name="complex2">Комплексное число</param>
        /// <returns>Результат сложения комплексных чисел</returns>
        public static Complex operator +(Complex complex1, Complex complex2)
        {
            return new Complex { Re = complex1.Re + complex2.Re, Im = complex1.Im + complex2.Im };
        }
        /// <summary>
        /// Перегрузка оператора -, вычитание комплексных чисел
        /// </summary>
        /// <param name="complex1"></param>
        /// <param name="complex2"></param>
        /// <returns>Результат вычитания комплексных чисел</returns>
        public static Complex operator -(Complex complex1, Complex complex2)
        {
            return new Complex { Re = complex1.Re - complex2.Re, Im = complex1.Im - complex2.Im };
        }
        /// <summary>
        /// Перегрузка оператора *, умножение комплексных чисел. Задание Б
        /// </summary>
        /// <param name="complex1"></param>
        /// <param name="complex2"></param>
        /// <returns>Результат произведения комплексных чисел</returns>
        public static Complex operator *(Complex complex1, Complex complex2)
        {
            return new Complex { Re = complex1.Re * complex2.Re, Im = complex1.Im * complex2.Im };
        }
        public override string ToString()
        {
            return $"{_re} {_im}i";
        }

        #endregion

        #region Constructors

        public Complex() { }

        public Complex(double re, double im)
        {
            _re = re;
            this._im = im;
        }

        #endregion

        #region Fields

        private double _re;
        private double _im;

        #endregion

        #region Properties

        public double Re
        {
            get { return _re; }
            set { _re = value; }
        }

        public double Im
        {
            get { return _im; }
            set { _im = value; }
        }

        #endregion
    }
    #endregion

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("а) Дописать структуру Complex, добавив метод вычитания комплексных чисел.\n" +
                "Продемонстрировать работу структуры.\n +" +
                "б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса.\n" +
                "в) Добавить диалог с использованием switch демонстрирующий работу класса.");// еще не разобрался как работать с swich
            Complex complex1 = new Complex(5, -2);
            Complex complex2 = new Complex(-1, 3);

            Console.WriteLine($"\nРабота с комплексными числами {complex1} и {complex2}");
            Console.WriteLine($"Результат сложения комплексных чисел {complex1 + complex2}");
            Console.WriteLine($"Результат вычитания комплексных чисел {complex1 - complex2}");
            Console.WriteLine($"Результат произведения комплексных чисел {complex1 * complex2}");
            Console.ReadLine();


            #region Задача 2 Сумма нечетных чисел
            Console.WriteLine("С клавиатуры вводятся числа, пока не будет введён 0 (каждое число в новой строке).\n" +
                " Требуется подсчитать сумму всех нечётных положительных чисел.\n" +
                " Сами числа и сумму вывести на экран, используя tryParse.");
            Console.WriteLine("\nВводите любое количество чисел(Ввести 0 - выход): ");

            int summ_nechet, rezult = 0;

            do
            {
                string nechet = Console.ReadLine();
                if(int.TryParse(nechet, out summ_nechet))
                {
                    if (summ_nechet % 2 != 0)
                    {
                        rezult += summ_nechet;
                    }
                }
                else
                {
                    summ_nechet = rezult;
                }
                
            } while (summ_nechet != 0);
            Console.WriteLine($"Сумма всех нечетных чисел равна: {rezult}");
            #endregion
        }
    }
}
