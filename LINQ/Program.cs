using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using LINQ.Data;
using LINQ.Models;
using System.Linq;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            using (MySchoolDbContext Context = new MySchoolDbContext())
            {

                //LÄGGER TILL LÄRARE

                //Teacher T1 = new Teacher() { firstName = "Anas", lastName = "Alhussain" };
                //Teacher T2 = new Teacher() { firstName = "Reidar", lastName = "Svensson" };
                //Teacher T3 = new Teacher() { firstName = "Irene", lastName = "Wilson" };
                //Teacher T4 = new Teacher() { firstName = "Jessica", lastName = "Buckland" };
                //Teacher T5 = new Teacher() { firstName = "Justin", lastName = "Roberts" };
                //Teacher T6 = new Teacher() { firstName = "Sally", lastName = "McDonald" };


                //Context.Teachers.Add(T1);
                //Context.Teachers.Add(T2);
                //Context.Teachers.Add(T3);
                //Context.Teachers.Add(T4);
                //Context.Teachers.Add(T5);
                //Context.Teachers.Add(T6);
                //Context.SaveChanges();




                //LÄGGER TILL STUDENTER

                //Student S1 = new Student() { firstName = "Kylie", lastName = "Sanderson", classID = 1 };
                //Student S2 = new Student() { firstName = "Rebecca", lastName = "Brown", classID = 1 };
                //Student S3 = new Student() { firstName = "Anna", lastName = "Jones", classID = 1 };
                //Student S4 = new Student() { firstName = "Diana", lastName = "Grey", classID = 1 };
                //Student S5 = new Student() { firstName = "Connor", lastName = "Allan", classID = 1 };
                //Student S6 = new Student() { firstName = "Victor", lastName = "Short", classID = 1 };
                //Student S7 = new Student() { firstName = "Alexandra", lastName = "Mackay", classID = 1 };
                //Student S8 = new Student() { firstName = "Audrey", lastName = "Mitchell", classID = 1 };
                //Student S9 = new Student() { firstName = "Peter", lastName = "Jackson", classID = 2 };
                //Student S10 = new Student() { firstName = "Sally", lastName = "Ross", classID = 2 };
                //Student S11 = new Student() { firstName = "Brandon", lastName = "Walsh", classID = 2 };
                //Student S12 = new Student() { firstName = "Rose", lastName = "Simpson", classID = 2 };
                //Student S13 = new Student() { firstName = "Harry", lastName = "Campbell", classID = 2 };
                //Student S14 = new Student() { firstName = "Trevor", lastName = "Gray", classID = 2 };
                //Student S15 = new Student() { firstName = "Stephanie", lastName = "Hudson", classID = 2 };
                //Student S16 = new Student() { firstName = "Sebastian", lastName = "Robertson", classID = 2 };
                //Student S17 = new Student() { firstName = "Samantha", lastName = "Newman", classID = 2 };
                //Student S18 = new Student() { firstName = "Stephanie", lastName = "James", classID = 2 };
                //Student S19 = new Student() { firstName = "Carol", lastName = "North", classID = 3 };
                //Student S20 = new Student() { firstName = "Trevor", lastName = "Barker", classID = 3 };
                //Student S21 = new Student() { firstName = "Sebastian", lastName = "Scott", classID = 3 };
                //Student S22 = new Student() { firstName = "Victor", lastName = "Nash", classID = 3 };
                //Student S23 = new Student() { firstName = "Jacob", lastName = "Duncan", classID = 3 };
                //Student S24 = new Student() { firstName = "Bella", lastName = "Hamilton", classID = 3 };
                //Student S25 = new Student() { firstName = "Vanessa", lastName = "Wright", classID = 3 };
                //Student S26 = new Student() { firstName = "Ava", lastName = "Thomson", classID = 3 };
                //Student S27 = new Student() { firstName = "Megan", lastName = "Quinn", classID = 3 };
                //Student S28 = new Student() { firstName = "Allison", lastName = "Bell", classID = 3 };
                //Student S29 = new Student() { firstName = "Fiona", lastName = "Taylor", classID = 3 };
                //Student S30 = new Student() { firstName = "Hannah", lastName = "McDavid", classID = 3 };

                //Context.Students.Add(S1);
                //Context.Students.Add(S2);
                //Context.Students.Add(S3);
                //Context.Students.Add(S4);
                //Context.Students.Add(S5);
                //Context.Students.Add(S6);
                //Context.Students.Add(S7);
                //Context.Students.Add(S8);
                //Context.Students.Add(S9);
                //Context.Students.Add(S10);
                //Context.Students.Add(S11);
                //Context.Students.Add(S12);
                //Context.Students.Add(S13);
                //Context.Students.Add(S14);
                //Context.Students.Add(S15);
                //Context.Students.Add(S16);
                //Context.Students.Add(S17);
                //Context.Students.Add(S18);
                //Context.Students.Add(S19);
                //Context.Students.Add(S20);
                //Context.Students.Add(S21);
                //Context.Students.Add(S22);
                //Context.Students.Add(S23);
                //Context.Students.Add(S24);
                //Context.Students.Add(S25);
                //Context.Students.Add(S26);
                //Context.Students.Add(S27);
                //Context.Students.Add(S28);
                //Context.Students.Add(S29);
                //Context.Students.Add(S30);

                //Context.SaveChanges();


                //LÄGGER TILL KLASSER

                //Class C1 = new Class() { className = "SUT22" };
                //Class C2 = new Class() { className = "SUT21" };
                //Class C3 = new Class() { className = "SUT20" };

                //Context.Classes.Add(C1);
                //Context.Classes.Add(C2);
                //Context.Classes.Add(C3);

                //Context.SaveChanges();


                //LÄGGER TILL KURSER OCH KOPPLAR LÄRARE 

                //SchoolSubject S1 = new SchoolSubject { subjectName = "Programmering 1", teacherID = 1 };
                //SchoolSubject S2 = new SchoolSubject { subjectName = "Mattematik", teacherID = 5 };
                //SchoolSubject S3 = new SchoolSubject { subjectName = "Programmering 2", teacherID = 3 };
                //SchoolSubject S4 = new SchoolSubject { subjectName = "Databasutveckling", teacherID = 4 };
                //SchoolSubject S5 = new SchoolSubject { subjectName = "Webbutveckling", teacherID = 2 };


                //Context.SchoolSubjects.Add(S1);
                //Context.SchoolSubjects.Add(S2);
                //Context.SchoolSubjects.Add(S3);
                //Context.SchoolSubjects.Add(S4);
                //Context.SchoolSubjects.Add(S5);

                //Context.SaveChanges();


                //KOPPLINGSTABELL MELLAN STUDENTER OCH KURSER, LÄGGER TILL INFO

                //StudentSubject S1 = new StudentSubject() { studentID = 1, SchoolSubjectssubjectID = 1 };
                //StudentSubject S2 = new StudentSubject() { studentID = 2, SchoolSubjectssubjectID = 1 };
                //StudentSubject S3 = new StudentSubject() { studentID = 3, SchoolSubjectssubjectID = 1 };
                //StudentSubject S4 = new StudentSubject() { studentID = 4, SchoolSubjectssubjectID = 1 };
                //StudentSubject S5 = new StudentSubject() { studentID = 5, SchoolSubjectssubjectID = 1 };
                //StudentSubject S6 = new StudentSubject() { studentID = 6, SchoolSubjectssubjectID = 1 };
                //StudentSubject S7 = new StudentSubject() { studentID = 7, SchoolSubjectssubjectID = 1 };
                //StudentSubject S8 = new StudentSubject() { studentID = 8, SchoolSubjectssubjectID = 1 };
                //StudentSubject S9 = new StudentSubject() { studentID = 1, SchoolSubjectssubjectID = 2 };
                //StudentSubject S10 = new StudentSubject() { studentID = 2, SchoolSubjectssubjectID = 2 };
                //StudentSubject S11 = new StudentSubject() { studentID = 3, SchoolSubjectssubjectID = 2 };
                //StudentSubject S12 = new StudentSubject() { studentID = 4, SchoolSubjectssubjectID = 2 };
                //StudentSubject S13 = new StudentSubject() { studentID = 5, SchoolSubjectssubjectID = 2 };
                //StudentSubject S14 = new StudentSubject() { studentID = 6, SchoolSubjectssubjectID = 2 };
                //StudentSubject S15 = new StudentSubject() { studentID = 7, SchoolSubjectssubjectID = 2 };
                //StudentSubject S16 = new StudentSubject() { studentID = 8, SchoolSubjectssubjectID = 2 };
                //StudentSubject S17 = new StudentSubject() { studentID = 9, SchoolSubjectssubjectID = 3 };
                //StudentSubject S18 = new StudentSubject() { studentID = 10, SchoolSubjectssubjectID = 3 };
                //StudentSubject S19 = new StudentSubject() { studentID = 11, SchoolSubjectssubjectID = 3 };
                //StudentSubject S20 = new StudentSubject() { studentID = 12, SchoolSubjectssubjectID = 3 };
                //StudentSubject S21 = new StudentSubject() { studentID = 13, SchoolSubjectssubjectID = 3 };
                //StudentSubject S22 = new StudentSubject() { studentID = 14, SchoolSubjectssubjectID = 3 };
                //StudentSubject S23 = new StudentSubject() { studentID = 15, SchoolSubjectssubjectID = 3 };
                //StudentSubject S24 = new StudentSubject() { studentID = 16, SchoolSubjectssubjectID = 3 };
                //StudentSubject S25 = new StudentSubject() { studentID = 17, SchoolSubjectssubjectID = 3 };
                //StudentSubject S26 = new StudentSubject() { studentID = 18, SchoolSubjectssubjectID = 3 };
                //StudentSubject S27 = new StudentSubject() { studentID = 9, SchoolSubjectssubjectID = 2 };
                //StudentSubject S28 = new StudentSubject() { studentID = 10, SchoolSubjectssubjectID = 2 };
                //StudentSubject S29 = new StudentSubject() { studentID = 11, SchoolSubjectssubjectID = 2 };
                //StudentSubject S30 = new StudentSubject() { studentID = 12, SchoolSubjectssubjectID = 2 };
                //StudentSubject S31 = new StudentSubject() { studentID = 13, SchoolSubjectssubjectID = 2 };
                //StudentSubject S32 = new StudentSubject() { studentID = 14, SchoolSubjectssubjectID = 2 };
                //StudentSubject S33 = new StudentSubject() { studentID = 15, SchoolSubjectssubjectID = 2 };
                //StudentSubject S34 = new StudentSubject() { studentID = 16, SchoolSubjectssubjectID = 2 };
                //StudentSubject S35 = new StudentSubject() { studentID = 17, SchoolSubjectssubjectID = 2 };
                //StudentSubject S36 = new StudentSubject() { studentID = 18, SchoolSubjectssubjectID = 2 };
                //StudentSubject S37 = new StudentSubject() { studentID = 19, SchoolSubjectssubjectID = 4 };
                //StudentSubject S38 = new StudentSubject() { studentID = 20, SchoolSubjectssubjectID = 4 };
                //StudentSubject S39 = new StudentSubject() { studentID = 21, SchoolSubjectssubjectID = 4 };
                //StudentSubject S40 = new StudentSubject() { studentID = 22, SchoolSubjectssubjectID = 4 };
                //StudentSubject S41 = new StudentSubject() { studentID = 23, SchoolSubjectssubjectID = 4 };
                //StudentSubject S42 = new StudentSubject() { studentID = 24, SchoolSubjectssubjectID = 4 };
                //StudentSubject S43 = new StudentSubject() { studentID = 25, SchoolSubjectssubjectID = 4 };
                //StudentSubject S44 = new StudentSubject() { studentID = 26, SchoolSubjectssubjectID = 4 };
                //StudentSubject S45 = new StudentSubject() { studentID = 27, SchoolSubjectssubjectID = 4 };
                //StudentSubject S46 = new StudentSubject() { studentID = 28, SchoolSubjectssubjectID = 4 };
                //StudentSubject S47 = new StudentSubject() { studentID = 29, SchoolSubjectssubjectID = 4 };
                //StudentSubject S48 = new StudentSubject() { studentID = 30, SchoolSubjectssubjectID = 4 };
                //StudentSubject S50 = new StudentSubject() { studentID = 20, SchoolSubjectssubjectID = 5 };
                //StudentSubject S51 = new StudentSubject() { studentID = 21, SchoolSubjectssubjectID = 5 };
                //StudentSubject S52 = new StudentSubject() { studentID = 22, SchoolSubjectssubjectID = 5 };
                //StudentSubject S53 = new StudentSubject() { studentID = 23, SchoolSubjectssubjectID = 5 };
                //StudentSubject S54 = new StudentSubject() { studentID = 24, SchoolSubjectssubjectID = 5 };
                //StudentSubject S55 = new StudentSubject() { studentID = 25, SchoolSubjectssubjectID = 5 };
                //StudentSubject S56 = new StudentSubject() { studentID = 26, SchoolSubjectssubjectID = 5 };
                //StudentSubject S57 = new StudentSubject() { studentID = 27, SchoolSubjectssubjectID = 5 };
                //StudentSubject S58 = new StudentSubject() { studentID = 28, SchoolSubjectssubjectID = 5 };
                //StudentSubject S59 = new StudentSubject() { studentID = 29, SchoolSubjectssubjectID = 5 };
                //StudentSubject S60 = new StudentSubject() { studentID = 30, SchoolSubjectssubjectID = 5 };


                //Context.StudentSubjects.Add(S1);
                //Context.StudentSubjects.Add(S2);
                //Context.StudentSubjects.Add(S3);
                //Context.StudentSubjects.Add(S4);
                //Context.StudentSubjects.Add(S5);
                //Context.StudentSubjects.Add(S6);
                //Context.StudentSubjects.Add(S7);
                //Context.StudentSubjects.Add(S8);
                //Context.StudentSubjects.Add(S9);
                //Context.StudentSubjects.Add(S10);
                //Context.StudentSubjects.Add(S11);
                //Context.StudentSubjects.Add(S12);
                //Context.StudentSubjects.Add(S13);
                //Context.StudentSubjects.Add(S14);
                //Context.StudentSubjects.Add(S15);
                //Context.StudentSubjects.Add(S16);
                //Context.StudentSubjects.Add(S17);
                //Context.StudentSubjects.Add(S18);
                //Context.StudentSubjects.Add(S19);
                //Context.StudentSubjects.Add(S20);
                //Context.StudentSubjects.Add(S21);
                //Context.StudentSubjects.Add(S22);
                //Context.StudentSubjects.Add(S23);
                //Context.StudentSubjects.Add(S24);
                //Context.StudentSubjects.Add(S25);
                //Context.StudentSubjects.Add(S26);
                //Context.StudentSubjects.Add(S27);
                //Context.StudentSubjects.Add(S28);
                //Context.StudentSubjects.Add(S29);
                //Context.StudentSubjects.Add(S30);
                //Context.StudentSubjects.Add(S32);
                //Context.StudentSubjects.Add(S31);
                //Context.StudentSubjects.Add(S32);
                //Context.StudentSubjects.Add(S33);
                //Context.StudentSubjects.Add(S34);
                //Context.StudentSubjects.Add(S35);
                //Context.StudentSubjects.Add(S36);
                //Context.StudentSubjects.Add(S37);
                //Context.StudentSubjects.Add(S38);
                //Context.StudentSubjects.Add(S39);
                //Context.StudentSubjects.Add(S40);
                //Context.StudentSubjects.Add(S41);
                //Context.StudentSubjects.Add(S42);
                //Context.StudentSubjects.Add(S43);
                //Context.StudentSubjects.Add(S44);
                //Context.StudentSubjects.Add(S45);
                //Context.StudentSubjects.Add(S46);
                //Context.StudentSubjects.Add(S47);
                //Context.StudentSubjects.Add(S48);
                //Context.StudentSubjects.Add(S50);
                //Context.StudentSubjects.Add(S51);
                //Context.StudentSubjects.Add(S52);
                //Context.StudentSubjects.Add(S53);
                //Context.StudentSubjects.Add(S54);
                //Context.StudentSubjects.Add(S55);
                //Context.StudentSubjects.Add(S56);
                //Context.StudentSubjects.Add(S57);
                //Context.StudentSubjects.Add(S58);
                //Context.StudentSubjects.Add(S59);
                //Context.StudentSubjects.Add(S60);


                //Context.SaveChanges();

                //SKRIVA UT MATTELÄRARE

                //var queryJoin1 = (from t1 in Context.Teachers
                //                  join t2 in Context.SchoolSubjects
                //                  on t1.teacherID equals t2.teacherID
                //                  where t2.subjectID == 2
                //                  select new
                //                  {
                //                      teachFName = t1.firstName,
                //                      teachLName = t1.lastName,
                //                      subName = t2.subjectName
                //                  }).ToList();

                //foreach (var q in queryJoin1)
                //{
                //    Console.WriteLine("Mattelärare");
                //    Console.WriteLine("Teacher name: {0} {1} , subjectName : {2}", q.teachFName, q.teachLName, q.subName);

                //}
                //Console.WriteLine("---------------------------------------------");

                //SKRIVA UT ELEVER MED SINA LÄRARE

                //var queryJoin2 = (from s1 in Context.Students
                //                  join s2 in Context.StudentSubjects
                //                  on s1.studentID equals s2.studentID
                //                  join s3 in Context.SchoolSubjects
                //                  on s2.SchoolSubjectssubjectID equals s3.subjectID
                //                  join s4 in Context.Teachers
                //                  on s3.teacherID equals s4.teacherID
                //                  select new
                //                  {
                //                      stuName = s1.firstName,
                //                      subName = s3.subjectName,
                //                      teachName = s4.firstName,

                //                  }).ToList();
                //foreach (var q in queryJoin2)
                //{
                //    Console.WriteLine("Student : {0} , Subject : {1} , Teacher : {2}", q.stuName, q.subName, q.teachName);
                //}

                //Console.WriteLine("--------------------------------------------");

                ////ÄNDRA LÄRARE, ANAS TILL REIDAR

                //var queryJoin3 = (from t1 in Context.SchoolSubjects
                //                  join t2 in Context.Teachers
                //                  on t1.teacherID equals t2.teacherID
                //                  where t1.teacherID == 1
                //                  select t1);
                //foreach (SchoolSubject t1 in queryJoin3)
                //{
                //    t1.teacherID = 2;
                //}

                //try
                //{
                //    Context.SaveChanges();
                //}
                //catch (Exception ex)
                //{
                //    Console.WriteLine(ex);
                //}


                //Console.WriteLine("---------------------------------------------");

                ////ÄNDRA KURS FRÅN PROGRAMMERING 2 TILL OOP

                //var query4 = (from s1 in Context.SchoolSubjects
                //              where s1.subjectName == "OOP"
                //              select s1);
                //foreach (SchoolSubject s1 in query4)
                //{
                //    s1.subjectName = "Programmering 2";
                //}
                //try
                //{
                //    Context.SaveChanges();
                //}
                //catch (Exception ex)
                //{
                //    Console.WriteLine(ex);

                //}


                //Console.WriteLine("-------------------------------------------------");

                ////KOLLA OM ÄMNEN INNEHÅLLER PROGRAMMERING 1

                //bool ifExist = Context.SchoolSubjects.Any(o => o.subjectName == "Programmering 1");
                //if (ifExist)
                //{
                //    Console.WriteLine("Contains Subject");
                //}
                //else
                //{
                //    Console.WriteLine("Does not contain subject");
                //}










            }
        }
    }
}
