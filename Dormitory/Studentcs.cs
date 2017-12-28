using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dormitory
{
    public class Studentcs
    {
        //Для получения места в общежитии формируется список
        // студентов, который включает Ф.И.О.студента, группу,
        //средний балл, доход на члена семьи, 
        //пол(перечисление), форма обучения(перечисление)
        public string Name { get; set;}
        public string Fulname { get; set;}
        public string Grup { get; set;}
        public int Score { get; set; }
        public int Income { get; set;}
    }
}
