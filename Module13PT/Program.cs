using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Module13PT
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // example1();
            // example2();
            // example3();
            // example4();
            // example5();
            // example6();
            // example7();
            // ProcessEmployeeData();

            // MusicCdCatalog example
            var cdCatalog = new MusicCdCatalog();
            cdCatalog.AddCd("Best of 80s", new List<string> { "Song1", "Song2" });
            cdCatalog.AddSongToCd("Best of 80s", "Song3");
            cdCatalog.DisplayCatalog();
            cdCatalog.SearchArtist("Song1");
            Console.ReadKey();
        }
        static void example1()
        {
            ArrayList list = new ArrayList();

            object test = 55;//boxing
            int x = (int)test;//unboxing


            list.Add(1);
            list.Add(true);
            list.Add("Test");

            foreach (object item in list)
            {
                int xx = (int)item;
                Console.WriteLine(xx);
            }
        }

        static void example2()
        {

            //queue
            Queue qe = new Queue();

            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                qe.Enqueue(i);
            }
            //Console.WriteLine("Queue \n");
            //foreach (int item in qe)
            //{
            //    Console.WriteLine(qe.Dequeue());
            //}

            Console.WriteLine("Queue \n");
            foreach (var item in qe)
            {
                Console.WriteLine(item);
            }

        }
        static void example3()
        {
            //stack
            Stack st = new Stack();
            st.Push("1");
            st.Push("2");
            st.Push("3");
            st.Push("4");

            foreach (var item in st)
            {
                Console.WriteLine(item);
            }
        }

        static void example4()
        {
            Dictionary<int, string> dic = new Dictionary<int, string>();
            for (int i = 0; i < 10; i++)
            {
                dic.Add(i, i.ToString());
            }
            if (!dic.ContainsKey(5))
            {

            }
        }

        static void example5()
        {
            //            1.Создать коллекцию List<int>.Вывести на экран позицию и значение элемента, являющегося вторым максимальным значением в коллекции
            //            a.Удалить все нечетные элементы списка List<int>

            List<int> col1 = new List<int>();
            Random random = new Random();
            for (int i = 0; i < 100; i++) 
            {
                col1.Add(random.Next(100));
            }
            for (int i = 0; i < col1.Count; i++)
            {
                Console.WriteLine("Element: " + col1[i] + " id: " + i);
            }    
            int max1 = 0;
            int max2 = 0;
            int x = 0;
            for (int i = 0; i < col1.Count; i++)
            {
                if(col1.ElementAt(i) > max1)
                {
                    max1 = col1.ElementAt(i);
                    x = i;

                }
                //Console.WriteLine("id: " + i + "Max element value: " + max1);
            }
            col1.RemoveAt(x);
            for (int i = 0; i < col1.Count; i++)
            {
                if (col1.ElementAt(i) > max1)
                {
                    max2 = col1.ElementAt(i);
                    

                }
                //Console.WriteLine("id: " + i + "Max element value: " + max1);
            }
            Console.WriteLine();
            Console.WriteLine("id: " + x + "\nMax element value: " + max1);
            Console.WriteLine();
            Console.WriteLine("id: " + x + "\n2nd max element value: " + max2);
            for (int i = 0; i < col1.Count; i++)
            {
                if( i % 2 == 1)
                {
                    col1.RemoveAt(i);
                }
            }
            
        }

        static void example6()
        {
            //2.Дана коллекция типа List<double>.Вывести на экран элементы списка, значение которых больше среднего арифметического всех элементов коллекции.

            List<double> col1 = new List<double>();
            Random random = new Random();
            for (int i = 0; i < 100; i++)
            {
                col1.Add(random.NextDouble());
            }
            //col1.Add(0.1);
            //col1.Add(0.1);
            //col1.Add(0.1);
            //col1.Add(0.1);
            //col1.Add(0.1);
            //col1.Add(0.1);

            double sum = 0;
            for (int i = 0;i < 100; i++)
            {
                sum += col1[i];
                Console.WriteLine(col1[i]);
            }

            double average = sum / 100;

            Console.WriteLine("\nSum of numbers: " + sum + "\nAverage of numbers: " + average);
        }

        static void example7()
        {
            //3.Дан файл, в котором записан набор чисел.Переписать в другой файл все числа в обратном порядке.
            List<int> col1 = new List<int>();
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                col1.Add(random.Next(10));
            }
            Console.WriteLine("First: ");
            for (int i = 0; i < 10 ; i++)
            {
                Console.WriteLine(col1[i]);
            }
            int k = 9;
            List<int> col2 = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                col2.Add(col1[k]);
                k--;
            }
            Console.WriteLine("\nSecond: ");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(col2[i]);
            }
        }

       
    }
    class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public decimal Salary { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName} {MiddleName}, Gender: {Gender}, Age: {Age}, Salary: {Salary}";
        }
        static void ProcessEmployeeData()
        {
            
            List<Employee> employees = new List<Employee>
    {
        
        new Employee { FirstName = "John", LastName = "Price", MiddleName = "K", Gender = "M", Age = 30, Salary = 8000 },
        
    };

            var lowSalaryGroup = employees.Where(e => e.Salary < 10000);
            var highSalaryGroup = employees.Where(e => e.Salary >= 10000);

            foreach (var employee in lowSalaryGroup)
            {
                Console.WriteLine(employee);
            }

            foreach (var employee in highSalaryGroup)
            {
                Console.WriteLine(employee);
            }
        }
    }
    class MusicCdCatalog
    {
        private Hashtable catalog = new Hashtable();

        public void AddCd(string cdTitle, List<string> songs)
        {
            catalog[cdTitle] = songs;
        }

        public void RemoveCd(string cdTitle)
        {
            catalog.Remove(cdTitle);
        }

        public void AddSongToCd(string cdTitle, string song)
        {
            if (catalog.ContainsKey(cdTitle))
            {
                ((List<string>)catalog[cdTitle]).Add(song);
            }
        }

        public void RemoveSongFromCd(string cdTitle, string song)
        {
            if (catalog.ContainsKey(cdTitle))
            {
                ((List<string>)catalog[cdTitle]).Remove(song);
            }
        }

        public void DisplayCatalog()
        {
            foreach (DictionaryEntry entry in catalog)
            {
                Console.WriteLine($"CD: {entry.Key}");
                foreach (var song in (List<string>)entry.Value)
                {
                    Console.WriteLine($" - {song}");
                }
            }
        }

        public void DisplaySongsOfCd(string cdTitle)
        {
            if (catalog.ContainsKey(cdTitle))
            {
                Console.WriteLine($"CD: {cdTitle}");
                foreach (var song in (List<string>)catalog[cdTitle])
                {
                    Console.WriteLine($" - {song}");
                }
            }
        }

        public void SearchArtist(string artist)
        {
            foreach (DictionaryEntry entry in catalog)
            {
                var songs = (List<string>)entry.Value;
                if (songs.Any(song => song.Contains(artist)))
                {
                    Console.WriteLine($"Artist {artist} found in CD: {entry.Key}");
                }
            }
        }
    }

}