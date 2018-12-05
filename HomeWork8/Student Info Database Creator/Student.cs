using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace Student_Info_Database_Creator
{
    [Serializable]
    public class Student
    {
        public string FIO { get; set; }

        public string Univercity { get; set; }

        public string Faculty { get; set; }

        public string Department { get; set; }

        public int Age { get; set; }

        public int Course { get; set; }

        public int Group { get; set; }

        public string City { get; set; }

        public Student()
        {

        }

        public Student(string fio, string univercity, string faculty, string department, int age, int course, int group, string city)
        {
            this.FIO = fio;
            this.Univercity = univercity;
            this.Faculty = faculty;
            this.Department = department;
            this.Age = age;
            this.Course = course;
            this.Group = group;
            this.City = city;
        }
    }

    class StudentsToXML
    {
        string fileName;
        List<Student> list;


        public List<Student> List
        {
            get { return list; }
            set { list = value; }
        }

        public string FileName
        {
            set { fileName = value; }
            get { return fileName; }
        }

        public StudentsToXML(string fileName)
        {
            this.fileName = fileName;
            list = new List<Student>();
        }
        
        public void Add(string fio, string univercity, string faculty, string department, int age, int course, int group, string city)
        {
            list.Add(new Student(fio,univercity,faculty,department,age,course,group,city));
        }

        public void Remove(int index)
        {
            if (list != null && index < list.Count && index >= 0) list.RemoveAt(index);
            else throw new IndexOutOfRangeException("Error!");
        }

        // Индексатор - свойство для доступа к закрытому объекту
        public Student this[int index]
        {
            get { return list[index]; }
            set { list[index] = value; }
        }

        public void Save()
        {
            XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Student>));
            Stream fStream = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            xmlFormat.Serialize(fStream, list);
            fStream.Close();
        }

        public void Load()
        {
            XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Student>));
            Stream fStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            list = (List<Student>)xmlFormat.Deserialize(fStream);
            fStream.Close();
        }

        public int Count
        {
            get { return list.Count; }
        }
    }
}
