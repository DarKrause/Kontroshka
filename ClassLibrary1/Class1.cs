using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassLibrary1
{
    public class Study
    {
        public class Mark
        {
            public Mark(DateTime _date, string _Estimation)
            {
                this.date = _date;
                this.Estimation = _Estimation;
            }
            DateTime date { get; set; } // дата оценки
            string Estimation { get; set; } // оценнка или отметка об отсутствии
        }

        public class Student
        {
            public Student(string _FIO, int _group, int _year)
            {
                this.FIO = _FIO;
                this.group = _group;
                this.year = _year;
            }
            string FIO { get; set; } // ФИО студента
            int group { get; set; } // группа
            int year { get; set; } // год поступления

            List<Mark> marks { get; set; } //оценки студента

            public double MinAVG(string[] marks) // вычисление средней оценки
            {
                double avg = 0;
                int count = 0;
                for (int i = 0; i < marks.Length; i++)
                {
                    int num;
                    bool isNum = int.TryParse(marks[i], out num); //проверяем является ли текущая строка числом
                    if (isNum)
                    {
                        avg += Convert.ToInt32(marks[i]);
                        count++;
                    }
                }
                avg = avg / count;
                avg = avg - (avg % 1);
                return avg;
            }

            public int GetCountTruancy(List<Mark> marks) // вычисление количества прогулов
            {
                return 0;
            }
        }
    }


}