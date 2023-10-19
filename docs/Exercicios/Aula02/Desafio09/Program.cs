/*
DESAFIO 09:

Crie um algoritmo que dê um leque de opções de cursos para o usuário
escolher e qual turma ele poderá ingressar, usando o conceito
de "Switch-Case" na linguagem CSharp.
*/


using System.Text.RegularExpressions;

namespace Desafio09
{
    class Program
    {
        static void Main(string[] args)
        {
            // lista de cursos
            Course[] courseList = new Course[5];
            InitializeCourseList(courseList);

            // lista de turmas
            CourseClass[] classList = new CourseClass[10];
            InitializeClassList(classList, courseList);

            // lista de turmas matriculadas
            CourseClass[] enrollments = new CourseClass[5];

            bool newEnrollment = true;
            int registrations = 0;

            while(newEnrollment)
            {
                int classIndex = Menu(courseList, classList);

                Console.Clear();
                Console.WriteLine($"Turma escolhida: {classList[classIndex].Code} - {classList[classIndex].Course.Name}");

                Console.WriteLine("Realizar matrícula na turma selecionada? s/n");
                bool enroll = ReadYesOrNo("Realizar matrícula?");

                // registra a turma matriculada no array enrollments
                if(enroll){
                    enrollments[registrations] = classList[classIndex];
                    registrations++;
                }

                if(registrations >= 5)
                {
                    newEnrollment = false;
                    break;
                }

                Console.WriteLine("Realizar nova matrícula? s/n");
                newEnrollment = ReadYesOrNo("Realizar nova matrícula?");
            }

            PrintEnrollments(enrollments, registrations);
            GoOn();

        }


        static bool ReadYesOrNo(string message)
        {
            while(true)
            {
                string option = Console.ReadLine()?.ToLower();

                if(Regex.IsMatch(option, "^(s(im)?|n(ao|ão)|n(ao)?o?)$")) return option.StartsWith("s");

                Console.WriteLine($"Entrada inválida. {message} (s/n)");
                Console.WriteLine();
            }
        }

        // função para exibir o menu e ler uma entrada do usuário
        static int Menu(Course[] courseList, CourseClass[] classList)
        {
            Console.Clear();

            Console.WriteLine("MATRÍCULA");
            Console.WriteLine();
            Console.WriteLine("Cursos:");
            Console.WriteLine();

            foreach(var courseInList in courseList)
                Console.WriteLine($"{(courseInList.Code):D2} - {courseInList.Name}");

            int courseIndex = ReadOption(1, 5) - 1;

            Console.Clear();

            Console.WriteLine("MATRÍCULA");
            Console.WriteLine();
            Console.WriteLine("Turmas:");
            Console.WriteLine();

            var courseClasses = classList.Where(classes => classes.Course == courseList[courseIndex]);
            int classCode = 0;

            foreach(var classes in courseClasses)
            {
                classCode = classes.Code - 1;
                Console.WriteLine($"Turma {(classes.Code):D2} - {classes.Course.Name}");
            }

            int classIndex = ReadOption(classCode, classCode + 1) - 1;

            return classIndex;
        }

        // função para ler entrada do usuário que aceita um numero inteiro entre 1 e max
        static int ReadOption(int min, int max)
        {
            int option;

            while(true)
            {
                Console.WriteLine();
                Console.WriteLine("Escolha uma opção: ");

                try
                {
                    option = int.Parse(Console.ReadLine());

                    if(option < min || option > max)
                    {
                        Console.WriteLine($"Digite um número entre {min} e {max}: ");
                        Console.WriteLine();
                        continue;
                    }

                    break;
                }
                catch(FormatException)
                {
                    Console.WriteLine("Entrada inválida. Por favor, digite um número.");
                    Console.WriteLine();
                }
            }
            return option;
        }

        // inicializa valores ao vetor de cursos
        static void InitializeCourseList(Course[] courseList)
        {
            courseList[0] = new Course(1, "Programação Back End");
            courseList[1] = new Course(2, "Programação Front End");
            courseList[2] = new Course(3, "DevOps");
            courseList[3] = new Course(4, "Cyber Security");
            courseList[4] = new Course(5, "Testes e Qualidade de Software");
        }

        // inicializa valores ao vetor de turmas
        static void InitializeClassList(CourseClass[] classList, Course[] courseList)
        {
            classList[0] = new CourseClass(courseList[0], 1);
            classList[1] = new CourseClass(courseList[0], 2);
            classList[2] = new CourseClass(courseList[1], 3);
            classList[3] = new CourseClass(courseList[1], 4);
            classList[4] = new CourseClass(courseList[2], 5);
            classList[5] = new CourseClass(courseList[2], 6);
            classList[6] = new CourseClass(courseList[3], 7);
            classList[7] = new CourseClass(courseList[3], 8);
            classList[8] = new CourseClass(courseList[4], 9);
            classList[9] = new CourseClass(courseList[4], 10);
        }

        static void PrintEnrollments(CourseClass[] enrollments, int registrations)
        {
            Console.Clear();
            Console.WriteLine("Turmas matriculadas:");
            Console.WriteLine();

            for(int i = 0; i < registrations; i++)
                Console.WriteLine($"Turma {enrollments[i].Code} - {enrollments[i].Course.Name}");
        }

        static void GoOn()
        {
            Console.WriteLine();
            Console.WriteLine("Aperte qualquer tecla para continuar...");
            Console.ReadLine();
            Console.Clear();
        }
    }

    class Course
    {
        public int Code { get; set; }
        public string Name { get; set; }

        public Course(int code, string name)
        {
            Code = code;
            Name = name;
        }
    }

    class CourseClass
    {
        public Course Course { get; set; }
        public int Code { get; set; }
        public CourseClass(Course course, int code)
        {
            Course = course;
            Code = code;
        }
    }
}