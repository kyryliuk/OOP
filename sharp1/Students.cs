using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Xml;
using System.IO;
namespace Students
{
    class Student
    {
        
        private string firstName;
        private string lastName;
        private string surName;
        private int age;
        private string group;
        private int[][] mark = new int[3][];
        private int profile;
        private int n;

        public Student()
        {           
            firstName = null;
            lastName = null;
            surName = null;
            age = 0;
            group = null;
            mark[0] = new int[] { };
            mark[1] = new int[] { };
            mark[2] = new int[] { };        
    }
        public string GSfirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string GSlastname
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public string GSsurname
        {
            get { return surName; }
            set { surName = value; }
        }
        public int GSage
        {
            get { return age; }
            set { age = value; }
        }
        public int GSgroup
        {
            get { return age; }
            set { age = value; }    
        }
        public string this [int i]
        {
            get
            {
                string str=String.Empty;
                if (i >= mark.Length || i < 0)
                    throw new IndexOutOfRangeException();
                else
                {
                   
                   
                        for (int col = 0; col < mark[i].Length; col++)
                            str += String.Format("{0} ", mark[i][col]);                     
                    
                    return str;
                }                               
            }           
        }
     

        //
        public override bool Equals(Object obj)
        {
            if (obj == null || !(obj is Student))
                return false;
            else
                return n == ((Student)obj).n;
        }
             
        public override int GetHashCode()
        {
            return n;
        }
        public Student(int value)
        {
            n = value;
        }
        public override string ToString()
        {
            string markt=String.Empty;
            string tempprofile= String.Empty;
            if (profile == 1)
            {
                tempprofile="Your profile: DEVELOPER ";
                for (int i = 0; i < mark.Length; i++)
                {
                    markt+= Convert.ToString(mark[0][i]);
                }        
            }
            if (profile == 2)
            {
                tempprofile="Your profile: ADMIN ";
                for (int i = 0; i < mark.Length; i++)
                {
                    markt+= Convert.ToString(mark[1][i]);
                }
            }
            if (profile == 3)
            {
                tempprofile =  "Your profile: DESINER ";
                for (int i = 0; i < mark.Length; i++)
                {
                    markt+= Convert.ToString(mark[2][i]);
                }
            }  
                return String.Format(firstName+" "+lastName+ " " + surName + " " + age + " " + group + " " + tempprofile + " " + markt);
        }

        public Student(string firstName, string lastName, string surName, int age, string group, int[][] mark)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.surName = surName;
            this.age = age;
            this.group = group;
            this.mark = mark;
        }
        //equals, gethashcode, clone, tostring+
        public void InputStudent()
        {
            //
            ConsoleKeyInfo key;

        firstnamemarc:
            Console.WriteLine("\nEnter your name: ");
            try
            {
                do
                {
                    key = Console.ReadKey(true);
                    if (key.Key == ConsoleKey.Enter) break;                  
                    if ((key.Key < ConsoleKey.A || key.Key > ConsoleKey.Z) && key.Key!=ConsoleKey.Backspace)
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                    if (key.Key == ConsoleKey.Backspace)
                    {
                        if (firstName.Length != 0)
                        {
                            firstName = firstName.Remove(firstName.Length - 1);
                            Console.Write("\b \b");
                        }
                    }
                    else
                    {
                        firstName += key.KeyChar;
                        Console.Write(key.KeyChar);
                    }
                }
                while (true);
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Неправильно ввели імя!!! ");
                goto firstnamemarc;
            }
            //
            lastNameMarc:
            Console.WriteLine("\nEnter your lastname: ");
            try
            {
                do
                {
                    key = Console.ReadKey(true);
                    if (key.Key == ConsoleKey.Enter) break;
                    if ((key.Key < ConsoleKey.A || key.Key > ConsoleKey.Z) && key.Key != ConsoleKey.Backspace)
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                    if (key.Key == ConsoleKey.Backspace)
                    {
                        if (lastName.Length != 0)
                        {
                            lastName = lastName.Remove(lastName.Length - 1);
                            Console.Write("\b \b");
                        }
                    }
                    else
                    {
                        lastName+= key.KeyChar;
                        Console.Write(key.KeyChar);
                    }
                }
                while (true);
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Неправильно ввели імя!!! ");
                goto lastNameMarc;
            }
            //
            surNameMarc:        
            Console.WriteLine("\nEnter your surname: ");
            try
            {
                do
                {
                    key = Console.ReadKey(true);
                    if (key.Key == ConsoleKey.Enter) break;
                    if ((key.Key < ConsoleKey.A || key.Key > ConsoleKey.Z) && key.Key != ConsoleKey.Backspace)
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                    if (key.Key == ConsoleKey.Backspace)
                    {
                        if (surName.Length != 0)
                        {
                           surName= surName.Remove(surName.Length - 1);
                            Console.Write("\b \b");
                        }
                    }
                    else
                    {
                        surName+= key.KeyChar;
                        Console.Write(key.KeyChar);
                    }
                }
                while (true);
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Неправильно ввели імя!!! ");
                goto surNameMarc;
            }
            //
           ageMarc:
            Console.WriteLine("\nEnter your age: ");
            string str = string.Empty;
            try
            {
               
                do
                {
                    key = Console.ReadKey(true);
                    if (key.Key == ConsoleKey.Enter) break;
                    if ((key.Key < ConsoleKey.D0 || key.Key > ConsoleKey.D9) && key.Key != ConsoleKey.Backspace)
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                    if (key.Key == ConsoleKey.Backspace)
                    {
                        if (str.Length != 0)
                        {
                           str= str.Remove(str.Length - 1);
                            Console.Write("\b \b");
                        }
                    }
                    else
                    {
                       str+= key.KeyChar;
                        Console.Write(key.KeyChar);
                    }
                }
                while (true);
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Неправильно ввели рік!!! ");
                goto ageMarc;
            }
            age = Convert.ToInt32(str);
            //
            ggwp:
            Console.WriteLine("\nEnter your group: ");
            group = Console.ReadLine();
            try
            {
                if (group.Substring(0, 1) != group.Substring(0, 1).ToUpper())
                {
                    throw new AccessViolationException();
                }
                for (int i = 1; i < group.Length - 1; i++)
                {
                    if (group[i] != '-')
                    { throw new ArgumentException(); }   //&??????????
                }
              //  for (int i = 0; i < group.Length; i++)
            //    {
           //         if (group[i+1] != '1' || group[i + 1] != '2'|| group[i + 1] != '3' || group[i + 1] != '4' || group[i + 1] != '5' || group[i + 1] != '6' || group[i + 1] != '7' || group[i + 1] != '8' || group[i + 1] != '9' || group[i + 1] != '0')                              //змына типу ынт
           //         { throw new ArgumentException(); }
           //     }
            }
            catch (AccessViolationException)
            {
                Console.WriteLine("\nException first world is not upper! ");
                goto ggwp;
            }
            catch (ArgumentException)
            {
                Console.WriteLine("\nException not - or not figures  ");
                goto ggwp;
            }
        
        //
        aaa:
        asdasd:
            Console.WriteLine("Choise your profile: ");
            Console.WriteLine("1-> DEVELOPER   2->ADMIN   3->DESINER ");

            profile = Convert.ToInt32(Console.ReadLine());
            int f = mark.Length;
            switch (profile)
            {
                case 1:
                    Console.WriteLine("Enter your marks: ");

                    try
                    {
                        string[] markSt = Console.ReadLine().Split(" ".ToCharArray());
                        mark[0] = new int[markSt.Length];

                        for (int i = 0; i < markSt.Length; i++)
                        {
                            mark[0][i] = Convert.ToInt32(markSt[i]);
                            if (mark[0][i] < 0 || mark[0][i] > 12)
                            {
                                throw new ArgumentOutOfRangeException("marks "+mark[0][i]);
                            }
                            else
                            {
                                Array.Resize(ref mark[0], markSt.Length);
                                for (int j = f; j < mark[0].Length - 1; j++)
                                {
                                    mark[0][j] = Convert.ToInt32(mark[0].Length);
                                    if (mark[0][j] < 0 || mark[0][j] > 12)
                                    {
                                        throw new ArgumentOutOfRangeException("Оцінка за межами");
                                    }
                                }
                            }

                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Неправильно ввели оцінку ");
                        goto asdasd;
                    }
                    catch (ArgumentOutOfRangeException exc)
                    {
                        Console.WriteLine(exc.Message);
                        goto asdasd;
                    }
                    break;
                case 2:
                    Console.WriteLine("Enter your marks: ");

                    try
                    {
                        string[] markSt = Console.ReadLine().Split(" ".ToCharArray());
                        mark[0] = new int[markSt.Length];

                        for (int i = 0; i < markSt.Length; i++)
                        {
                            mark[0][i] = Convert.ToInt32(markSt[i]);
                            if (mark[0][i] < 0 || mark[0][i] > 12)
                            {
                                throw new ArgumentOutOfRangeException(" ");
                            }
                            else
                            {
                                Array.Resize(ref mark[0], markSt.Length);
                                for (int j = f; j < mark[0].Length - 1; j++)
                                {
                                    mark[0][j] = Convert.ToInt32(mark[0].Length);
                                    if (mark[0][j] < 0 || mark[0][j] > 12)
                                    {
                                        throw new ArgumentOutOfRangeException("Оцінка за межами");
                                    }
                                }
                            }

                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Неправильно ввели оцінку ");
                        goto asdasd;
                    }
                    catch (ArgumentOutOfRangeException exc)
                    {
                        Console.WriteLine(exc.Message);
                        goto asdasd;
                    }
                    break;
                case 3:
                    Console.WriteLine("Enter your marks: ");

                    try
                    {
                        string[] markSt = Console.ReadLine().Split(" ".ToCharArray());
                        mark[0] = new int[markSt.Length];

                        for (int i = 0; i < markSt.Length; i++)
                        {
                            mark[0][i] = Convert.ToInt32(markSt[i]);
                            if (mark[0][i] < 0 || mark[0][i] > 12)
                            {
                                throw new ArgumentOutOfRangeException(" ");
                            }
                            else
                            {
                                Array.Resize(ref mark[0], markSt.Length);
                                for (int j = f; j < mark[0].Length - 1; j++)
                                {
                                    mark[0][j] = Convert.ToInt32(mark[0].Length);
                                    if (mark[0][j] < 0 || mark[0][j] > 12)
                                    {
                                        throw new ArgumentOutOfRangeException("Оцінка за межами");
                                    }
                                }
                            }

                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Неправильно ввели оцінку ");
                        goto asdasd;
                    }
                    catch (ArgumentOutOfRangeException exc)
                    {
                        Console.WriteLine(exc.Message);
                        goto asdasd;
                    }
                    break;
                default:
                    Console.WriteLine("Enter repeate: ");
                    goto aaa;

            }
        }
        
        public void PrintStudent()
        {
           // firstName = firstName.Substring(0, 1).ToUpper() + firstName.Remove(0, 1);
            Console.WriteLine("Your name: " + firstName);
           // lastName = lastName.Substring(0, 1).ToUpper() + lastName.Remove(0, 1);
            Console.WriteLine("Your lastname: " + lastName);
          //  surName = surName.Substring(0, 1).ToUpper() + surName.Remove(0, 1);
            Console.WriteLine("Your surname: " + surName);
            Console.WriteLine("Your age: " + age);
            Console.WriteLine("Your group: " + group);
            if (profile == 1)
            {
                Console.WriteLine("Your profile: DEVELOPER \n");
                for (int i = 0; i < mark[0].Length ; i++)
                {
                    Console.Write(mark[0][i] + " ");
                }
            }
            if (profile == 2)
            {
                Console.WriteLine("Your profile: ADMIN\n ");
                for (int i = 0; i < mark[1].Length; i++)
                {
                    Console.Write(mark[0][i] + " ");
                }
            }
            if (profile == 3)
            {
                Console.WriteLine("Your profile: DESINER\n ");
                for (int i = 0; i < mark[2].Length; i++)
                {
                    Console.Write(mark[0][i] + " ");
                }
            }
        }

        public double SerMark()//**
        {
            double ava=0;
            if (mark[0].Length != 0)
            {ava=  mark[0].Average(); }
            if (mark[1].Length != 0)
            {ava= mark[0].Average(); }
            if (mark[2].Length != 0)
            { ava=mark[0].Average(); }
            return ava;
        }

        public void InputInXml()
        {
            var xmlWriter = new XmlTextWriter("students.xml", null);
            xmlWriter.Formatting = Formatting.Indented;
            xmlWriter.IndentChar = '\t';                   
            xmlWriter.Indentation = 1;                   
            xmlWriter.QuoteChar = '\'';


            xmlWriter.WriteStartDocument();
            xmlWriter.WriteStartElement("ListOfStudents");
            xmlWriter.WriteStartElement("firstName");
            xmlWriter.WriteString(firstName);
            xmlWriter.WriteEndElement();
            xmlWriter.WriteStartElement("lastName");
            xmlWriter.WriteString(lastName);
            xmlWriter.WriteEndElement();
            xmlWriter.WriteStartElement("surName");
            xmlWriter.WriteString(surName);
            xmlWriter.WriteEndElement();
            xmlWriter.WriteStartElement("Age");
            xmlWriter.WriteString(Convert.ToString(age));
            xmlWriter.WriteEndElement();
            xmlWriter.WriteStartElement("group");
            xmlWriter.WriteString(group);
            xmlWriter.WriteEndElement();
            //
            if (profile == 1)
            {
                xmlWriter.WriteStartElement("Profile" );
                xmlWriter.WriteString("Developer");
                xmlWriter.WriteEndElement();
                xmlWriter.WriteStartElement("Marks");
                for (int i = 0; i < mark[0].Length; i++)
                {
                    xmlWriter.WriteString(mark[0][i] + " ");
                }
                xmlWriter.WriteEndElement();
            }
            if (profile == 2)
            {
                xmlWriter.WriteStartElement("Profile", "Admin");
                xmlWriter.WriteEndElement();
                for (int i = 0; i < mark[1].Length; i++)
                {
                    xmlWriter.WriteString(mark[1][i] + " ");
                    
                }xmlWriter.WriteEndElement();
            }
            if (profile == 3)
            {
                xmlWriter.WriteStartElement("Profile", "Desiner");
                xmlWriter.WriteEndElement();
                for (int i = 0; i < mark[2].Length; i++)
                {
                    xmlWriter.WriteString(mark[2][i] + "");
                   
                } xmlWriter.WriteEndElement();
            }
           
          

            xmlWriter.WriteEndElement();
            xmlWriter.Close();



        }
        public void PrintXml()
        {
            var document = new XmlDocument();
            document.Load("students.xml");
            Console.WriteLine(document.InnerXml);
            Console.WriteLine(new string('-', 20));
            Console.WriteLine(document.InnerXml);
            Console.WriteLine(new string('-', 20));
        }
        public void Print1XML()
        {
            var document = new XmlDocument();
            document.Load("students.xml");
            XmlNode root = document.DocumentElement;
            Console.WriteLine("document.DocumentElement = {0}", root.LocalName);
            foreach (XmlNode students in root.ChildNodes)
            {
                Console.WriteLine("Found:");
                Console.WriteLine("{0}\t{1}\t{2}\t{3}",
               students.NodeType,
                students.Name,
                students.Value,
                students.InnerText);
                Console.WriteLine(new string('-', 40));

            }
        }
        public Student GetXML()
        {
          
              Student sd = new Student();

            sd.InputStudent();
            FileStream stream = new FileStream("students.xml", FileMode.Open);

            XmlTextReader xmlReader=new XmlTextReader(stream);;
            xmlReader.WhitespaceHandling = WhitespaceHandling.None;
         
            // var xmlReader = new XmlDocument();
            //xmlReader.Load("students.xml");
            while (xmlReader.Read())
            {               
                   
                    if (xmlReader.Name.Equals("Age"))
                {
                    xmlReader.Read();
                    if (xmlReader.NodeType == XmlNodeType.Text)
                    {
                        sd.age = Convert.ToInt32(xmlReader.Value);
                        Console.WriteLine(sd.age);
                    }
                   //string q;
                   // q = xmlReader.Value;                   
                 //   sd.age = Convert.ToInt32(q.Split(new char[] { ' ','\n','\t','\r' }, StringSplitOptions.RemoveEmptyEntries));
                }
                if (xmlReader.Name.Equals("firstName"))
                {
                   // xmlReader.Read();
                    sd.firstName = xmlReader.Value;
                    Console.WriteLine(sd.firstName);
                }
                if (xmlReader.Name.Equals("lastName"))
                {
                    xmlReader.Read();
                    sd.lastName = xmlReader.Value;
                }
                if (xmlReader.Name.Equals("surName"))
                {
                    xmlReader.Read();
                    sd.surName = xmlReader.Value;
                }
                if (xmlReader.Name.Equals("group"))
                {
                    xmlReader.Read();
                    sd.group = xmlReader.Value;
                }
                if (xmlReader.Name.Equals("Profile"))
                {
                    xmlReader.Read();
                    if (xmlReader.Value== "Developer")
                    sd.profile = 1;
                    if (xmlReader.Value == "Admin")
                        sd.profile = 2;
                    if (xmlReader.Value == "Desiner")
                        sd.profile = 3;
                }
                if (xmlReader.Name.Equals("Marks"))
                {
                    string s;
                    xmlReader.Read();
                    s = xmlReader.Value;
                    string[] smarks= s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    if (sd.profile == 1)
                    {

                        sd.mark[0] = new int[smarks.Length];
                        for (int i = 0; i < smarks.Length; i++)
                        {
                           
                            sd.mark[0][i] =Convert.ToInt32 (smarks[i]);
                        }

                    }
                    if (sd.profile == 2)
                    {
                        sd.mark[1] = new int[smarks.Length];
                        for (int i = 0; i < smarks.Length; i++)
                        {
                                sd.mark[1][i] = Convert.ToInt32(smarks[i]);
                            }
                    }
                    if (sd.profile == 3)
                    {
                        sd.mark[2] = new int[smarks.Length];
                        for (int i = 0; i < smarks.Length; i++)
                        {
                                sd.mark[2][i] = Convert.ToInt32(smarks[i]);
                            }
                    }
                }

            }
        //    Console.WriteLine(sd.age);
            sd.InputInXml();
            xmlReader.Close();
           sd.PrintStudent();
           return  sd;
           
        }

        public void AddXML()
        {
            Student sd = new Student();
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("stusentts.xml");
            XmlElement xmlRoot = xmlDoc.DocumentElement;
            Console.WriteLine("Student Add:\t");


            XmlElement StudElem = xmlDoc.CreateElement("Student");
                        
            XmlElement firstName = xmlDoc.CreateElement("firstName");
            XmlElement lastName = xmlDoc.CreateElement("lastName");
            XmlElement surName = xmlDoc.CreateElement("surName");
            XmlElement Age = xmlDoc.CreateElement("Age");
            XmlElement group = xmlDoc.CreateElement("group");
            XmlElement profile = xmlDoc.CreateElement("Profile");
            XmlElement marks = xmlDoc.CreateElement("Marks");

            XmlText firstName1 = xmlDoc.CreateTextNode(sd.firstName);
            XmlText lastName1 = xmlDoc.CreateTextNode(sd.lastName);
            XmlText surName1 = xmlDoc.CreateTextNode(sd.surName);
            XmlText Age1 = xmlDoc.CreateTextNode(Convert.ToString(sd.age));
            XmlText group1 = xmlDoc.CreateTextNode(sd.group);
            XmlText profile1 = xmlDoc.CreateTextNode("");
            XmlText marks1 = xmlDoc.CreateTextNode("");

            if (sd.profile == 1)
            {
                profile1 = xmlDoc.CreateTextNode("Developer");
                string []temp=null;
                for (int i = 0; i < sd.mark[0].Length; i++)//!!!!!!!!!!!!!!!!!!!!!!!!
                {
                    temp[i] = Convert.ToString( sd.mark[0][i]);
                }
            }
            if (sd.profile == 2)
            {
                 profile1 = xmlDoc.CreateTextNode("Admin");
            }
            if (sd.profile == 3)
            {
                 profile1 = xmlDoc.CreateTextNode("Desiner");
            }
        
            
         

            Console.Write("input number of book:\t");
            XmlText IDText = xmlDoc.CreateTextNode(string.Format("{0}", Convert.ToInt32(Console.ReadLine())));
            Console.Write("input title of book:\t");
            XmlText titleText = xmlDoc.CreateTextNode(Console.ReadLine());
            Console.Write("input currency:\t");
            XmlText currencyText = xmlDoc.CreateTextNode(Console.ReadLine());
            Console.Write("input price of book:\t");
            XmlText priceText = xmlDoc.CreateTextNode(string.Format("{0}", Convert.ToDouble(Console.ReadLine())));
            priceElem.AppendChild(priceText);
            currencyAttr.AppendChild(currencyText);
            priceElem.Attributes.Append(currencyAttr);
            titleElem.AppendChild(titleText);
            bookElem.AppendChild(titleElem);
            bookElem.AppendChild(priceElem);
            IDAttr.AppendChild(IDText);
            bookElem.Attributes.Append(IDAttr);
            xmlRoot.AppendChild(bookElem);
            Console.WriteLine("Book added");
            xmlDoc.Save("books.xml");

        }

    }
    //struct StudentsXML
    //{
    //    public string firstName;
    //    public string lastName;
    //    public string surName;
    //    public int age;
    //    public string group;
    //    public int[][] mark = new int[3][];
    //    public mark marks;
    //    public int profile;
    //    enum mark {    }
    //}
    //
    class CSubject
    {
        public bool deferential;
        // string[] salmons = { "adminisrating", "developer", "desiner" };
        public CSubject(bool def)
        {
            this.deferential = def;
        }
    }
        delegate void CStudentmet();
    
        class CStudy
        {
            private Student[] st;

            ArrayList arr = new ArrayList();
        
            public event CStudentmet metod = null;

        }
//
        class Book:Student
    {
        private Student[] BookArray;
        private int cost;
        public Book(int size)
        {
            BookArray = new Student[size];
        }
      
        public int Length
        {
            get { return BookArray.Length; }
        }
        public Student this[int pos1]
        {
            get
            {
                if (pos1 >= BookArray.Length || pos1 < 0)
                    throw new IndexOutOfRangeException();
                else
                    return (Student)BookArray[pos1];
            }
            set
            {
                BookArray[pos1] = (Student)value;
            }
        }
    }
}
