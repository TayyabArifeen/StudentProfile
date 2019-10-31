﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentStudent
{
    class Program
    {


        
        static void Main(string[] args)
        {
            char option = 'y';
            while (option == 'y' || option == 'Y')
            {

                Console.WriteLine("1-Create a Student Profile");
                Console.WriteLine("2-Search Student");
                Console.WriteLine("3-Delete Student");
                Console.WriteLine("4-List top of 03 of class");
                Console.WriteLine("5-Mark Student Attendence");
                Console.WriteLine("6-View Attendence");
                int op, count = 0,count1=0;
                int numb ;
                int[] stdId = new int[50];
                string[] stdName = new string[50];
                string[] sem = new string[50];
                double[] cgpa = new double[50];
                string[] depart = new string[50];
                string[] uni = new string[50];
                string[] attnd = new string[50];
                //File Reading
                try
                {

                    using (StreamReader sr = new StreamReader("C:\\Users\\Arife\\Desktop\\VpClassAssign.txt"))
                    {

                        string line = "";
                        while ((line = sr.ReadLine()) != null)
                        {

                            //Console.WriteLine(line);
                                if (count == 0)
                                {
                                    stdId[count1+1] = Convert.ToInt32(line);
                                    count++;
                                }
                                else if (count == 1)
                                {
                                    stdName[count1+1] = line;
                                    count++;
                                }
                                else if (count == 2)
                                {
                                    sem[count1+1] = line;
                                    count++;
                                }
                                else if (count == 3)
                                {
                                    cgpa[count1+1] = Convert.ToDouble(line);
                                    count++;
                                }
                                else if (count == 4)
                                {
                                    depart[count1+1] = line;
                                    count++;
                                }
                                else if (count == 5)
                                {
                                    uni[count1+1] = line;
                                    count = 0;
                                    count1++;
                                }
                                

                            
                        }
                    }
                }
                catch (Exception e)
                {
                    // Let the user know what went wrong.
                    Console.WriteLine("The file could not be read:");
                    Console.WriteLine(e.Message);
                }

                op = Convert.ToInt32(Console.ReadLine());
                //Create profile condition starts
                if (op == 1)
                {
                    Console.Clear();
                    Console.WriteLine("How many student you wanna write record?");
                    numb = Convert.ToInt32(Console.ReadLine());
                    using (StreamWriter sw = new StreamWriter("C:\\Users\\Arife\\Desktop\\VpClassAssign.txt", true))
                    {
                        for (int i = count1+1; i <= count1+numb; i++)
                        {
                            {
                                Console.WriteLine();
                                int id = i;
                                string nam, seme, departm, univ;
                                double cGpa;
                                Console.WriteLine("Write name of student:");
                                nam = Console.ReadLine();
                                Console.WriteLine("Write semester:");
                                seme = Console.ReadLine();
                                Console.WriteLine("Write CGPA:");
                                cGpa = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine("Write Department:");
                                departm = Console.ReadLine();
                                Console.WriteLine("Write name of university:");
                                univ = Console.ReadLine();
                                stdId[i] = id;
                                stdName[i] = nam;
                                sem[i] = seme;
                                cgpa[i] = cGpa;
                                depart[i] = departm;
                                uni[i] = univ;
                                sw.WriteLine(id);
                                sw.WriteLine(nam);
                                sw.WriteLine(seme);
                                sw.WriteLine(cGpa);
                                sw.WriteLine(departm);
                                sw.WriteLine(univ);

                            }
                        }

                    }

                }//Create profile braces ends
                //Search student braces start
                else if (op == 2)
                {
                    Console.Clear();
                    int op1;
                    Console.WriteLine("1-To search student by id:");
                    Console.WriteLine("2-To search student by name:");
                    Console.WriteLine("3-To search all students:");
                    op1 = Convert.ToInt32(Console.ReadLine());
                    if (op1 == 1)
                    {
                        Console.Clear();
                        Console.WriteLine("Write Id of Student");
                        int id;
                        id = Convert.ToInt32(Console.ReadLine());
                        for (int i = 1; i <= count1; i++)
                        {
                            if (stdId[i] == id)
                            {
                                Console.WriteLine("Id Name        Semester CGPA Department     University");
                                Console.WriteLine(stdId[i] + " " + stdName[i] + "   " + sem[i] + "      " + cgpa[i] + "    " + depart[i] + "     " + uni[i]);
                                break;
                            }
                            //else
                            //{
                            //    Console.WriteLine("Invalid Id or Id do not exist");
                            //}
                        }
                    }
                    else if (op1 == 2)
                    {
                        Console.Clear();
                        Console.WriteLine("Write name of Student");
                        string name;
                        name = Console.ReadLine();
                        Console.WriteLine("Id Name        Semester CGPA Department     University");
                        for (int i = 1; i <= count1; i++)
                        {
                            if (stdName[i] == name)
                            {

                                Console.WriteLine(stdId[i] + " " + stdName[i] + "   " + sem[i] + "      " + cgpa[i] + "    " + depart[i] + "     " + uni[i]);
                            }
                            else
                            {
                                Console.WriteLine("Invalid name or name do not exist");
                            }
                        }

                    }
                    else if (op1 == 3)
                    {
                        Console.Clear();
                        Console.WriteLine("List Number of Students");
                        Console.WriteLine("Id Name        Semester CGPA Department     University");
                        for (int i = 1; i <= count1; i++)
                        {
                            Console.WriteLine(stdId[i] + " " + stdName[i] + "   " + sem[i] + "      " + cgpa[i] + "    " + depart[i] + "     " + uni[i]);
                        }

                    }
                    else
                    {
                        Console.WriteLine("Invalid Entry...");
                    }
                }//Search Student braces ends
                //Delete student braces starts
                else if (op == 3)
                {
                    Console.Clear();
                    Console.WriteLine("Enter id you wanna Delete Record");
                    int id;
                    id = Convert.ToInt32(Console.ReadLine());
                    for (int i = 1; i <= count1; i++)
                    {
                        if (stdId[i] == id)
                        {

                            stdId[i] = 0;
                            stdName[i] = null;
                            sem[i] = null;
                            cgpa[i] = 0;
                            depart[i] = null;
                            uni[i] = null;
                            Console.WriteLine("Deletion successfully");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Id not found..Deletion Unsuccessfully");
                        }

                    }

                }//Delete student braces ends
                //List top 3 braces starts
                else if (op == 4)
                {
                    Console.Clear();
                    Console.WriteLine("Top Three Students are: ");
                    Console.WriteLine("Id" + " Name" + "   Semester" + " CGPA" + "Department" + " University");
                    double t = 0;
                    int[] sortId=new int[50];
                    string[] sortName = new string[50];
                    string[] sortSem = new string[50];
                    double[] sortCgpa = new double[50];
                    string[] sortDepart = new string[50];
                    string[] sortUni = new string[50];
                    string[] sortAttnd = new string[50];
                    for (int i = 1; i <= count1;i++ )
                    {
                        sortId[i] = stdId[i];
                        sortName[i] = stdName[i];
                        sortSem[i] = sem[i];
                        sortCgpa[i] = cgpa[i];
                        sortDepart[i] = depart[i];
                        sortUni[i] = uni[i];
                    }
                        for (int p = 2; p <= count1 - 1; p++)
                        {
                            for (int i = 1; i <= count1 ; i++)
                            {
                                if (sortCgpa[i] < sortCgpa[i + 1])
                                {
                                    t = sortCgpa[i + 1];
                                    sortCgpa[i + 1] = sortCgpa[i];
                                    sortCgpa[i] = t;
                                }
                            }
                        }
                    for(int i=1;i<=count1;i++)
                    {
                        if(sortCgpa[1]==cgpa[i])
                        {
                            Console.WriteLine(stdId[i] + " " + stdName[i] + "   " + sem[i] + "      " + cgpa[i] + "    " + depart[i] + "     " + uni[i]);
                        }
                        else if(sortCgpa[2]==cgpa[i])
                        {
                            Console.WriteLine(stdId[i] + " " + stdName[i] + "   " + sem[i] + "      " + cgpa[i] + "    " + depart[i] + "     " + uni[i]);
                        }
                        else if(sortCgpa[3]==cgpa[i])
                        {
                            Console.WriteLine(stdId[i] + " " + stdName[i] + "   " + sem[i] + "      " + cgpa[i] + "    " + depart[i] + "     " + uni[i]);
                        }
                        else
                        {

                        }
                    }
                }//list top 3 braces ends
                //Mark attendence braces starts
                else if (op == 5)
                {
                    Console.Clear();
                    string attend;
                    Console.WriteLine("Mark attendence");
                    for (int i = 1; i <= count1; i++)
                    {
                        Console.Write("ID: " + stdId[i] + "Name: " + stdName[i] + "Mark Attendece: ");
                        attend = Console.ReadLine();
                        attnd[i] = attend;
                    }
                    using (StreamWriter sw = new StreamWriter("C:\\Users\\Arife\\Desktop\\StudentAttendence.txt"))
                    {
                        for (int i = 1; i <= count1; i++)
                        {
                            {
                                Console.WriteLine();
                                sw.WriteLine(stdId[i]);
                                sw.WriteLine(stdName[i]);
                                sw.WriteLine(attnd[i]);
                            }
                        }

                    }

                }//mark student attendence braces ends
                //View attendence braces starts
                else if (op == 6)
                {
                    Console.Clear();
                    int counta = 0, countb = 0;
                    Console.WriteLine("ID  Name    Attendence");
                    try
                    {

                        using (StreamReader sr = new StreamReader("C:\\Users\\Arife\\Desktop\\StudentAttendence.txt"))
                        {
                            
                            string line = "";
                            while ((line = sr.ReadLine()) != null)
                            {

                                //Console.WriteLine(line);
                                if (counta == 0)
                                {
                                    stdId[countb + 1] = Convert.ToInt32(line);
                                    counta++;
                                }
                                else if (counta == 1)
                                {
                                    stdName[countb + 1] = line;
                                    counta++;
                                }
                                else if(counta==2)
                                {
                                    attnd[countb + 1] = line;
                                    counta = 0;
                                    countb++;
                                }
                                
                            }
                        }
                    }
                    catch (Exception e)
                    {
                        // Let the user know what went wrong.
                        Console.WriteLine("The file could not be read:");
                        Console.WriteLine(e.Message);
                    }
                    for (int i = 1; i <= countb; i++)
                    {
                        Console.WriteLine(stdId[i] + "  " + stdName[i] + "    " + attnd[i]);
                    }
                }//view attendence braces ends
                else
                {
                    Console.WriteLine("Invalid Entry Try again");
                }
                Console.WriteLine("Press y to continue || press any key to exit..");
                option = Convert.ToChar(Console.ReadLine());
            }
            //Functions 
      
            Console.ReadKey();
        }
    }
}
