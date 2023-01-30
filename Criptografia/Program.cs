using System;
using static System.Console;

namespace Criptografia
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("----------------- UTILIZANDO CRIPTOGRAFIAS -----------------");
            WriteLine("Algoritmo AES\n");

            Simetrica s = new Simetrica();
            WriteLine("Digite uma mensagem para ser criptografada: ");
            string msg = Console.ReadLine();

            WriteLine(s.EncryptData(msg, "eyJhbGciOiJSUzI1NiIsInR5cCI6IkpXVCJ9.eyJwY3MiOiIyYWU1Yjc3NmRiYmEwYzNhMzgzMTA5NzcwNmI2Y2JiYTA0YmEyZmQ0ZGUyZWRhNWU0NTRkMjlhNjA2NjU4YTI2IiwidmlydHVhbFJvbGUiOmZhbHNlLCJyb2xlIjoiU2l0ZSBBZG1pbiIsInVzZXJfbmFtZSI6ImZzaWx2YUBjb21wdWdyYWYuY29tLmJyIiwibGFuZ3VhZ2VJZCI6MzEsImZncHQiOiIkMmEkMTAkNnBOWlJKTU5la1puU1BXU0EvR2EwdVRleTFyREYuU3liRmk4Z0JFUGhONGtKeWM2bi4wTm0iLCJzZXNzaW9uSWQiOiJhNjM4M2UwZi05ODc1LTRjMTMtOTFjNS1mZThiMmIxYWZmYzAiLCJ0ZW5hbnRHdWlkIjoiNWZhYWZmZjQtMjBjZi00MTc4LTk0Y2YtZDYyYzY1ZGJiYTFiIiwiYXV0aG9yaXRpZXMiOlsiU2l0ZSBBZG1pbiJdLCJjbGllbnRfaWQiOiJvbmV0cnVzdCIsInJ0ZWQiOjQsIm9yZ0dyb3VwSWQiOiIxIiwib3JnR3JvdXBHdWlkIjoiYmM1ZmVkNTAtMTc1MC00ZmRlLWFiNGQtMTEzMjRlNzQ4NmRlIiwicGVybWlzc2lvbnMiOiJjVW5lR3pOLy8vM3YvLy8vLy8vLy8xKzI5Nzk0dnYvK3dQejAvL2RHbjVUZGQvZS8xK3U5dFQzdS8rYnYxL3VubitMZ2QzYWZ1bWNPR2k2MXVXTDF1LzNmNy84R0F2RCtMd0RCL3YvN3YrbjkvL3ZjLzkvRy8vLy8vMDkvQUFBQUFKOTk5Lyt2UGY3NjgvLy8vdjcvLzkrdlIvLzlGOVdGOCt5Ly8vMS9BQURrLzR3WWozei9oLy8vY2ZULy83Ly9TOXAvdSsrKy8rKy8vekFBN1AvOWYvVCtnOS91cWw4ODhLUDdDOERmZnYvL24zc0FDS0QySUQ0aDMydi8vL0QvLy8rLy8vLy85ZDk3LzE3MzM3ZXBDYVRSZi8vZi8vLy8vKy9mVDczLy94dEVjQUNnQUFBQUFHRC92Ky9WNXcvYTMvNy83My83TGg3ZXg0MS8vOWV2QWc9PSIsInNjb3BlIjpbInJlYWQiXSwicm9vdCI6ImJjNWZlZDUwLTE3NTAtNGZkZS1hYjRkLTExMzI0ZTc0ODZkZSIsImF0aSI6IjFhNTc4ZTc1LTJjZTYtNDkyZC1iODljLTFmMjFhODllM2YyOSIsInRlbmFudElkIjoxMTM3LCJndWlkIjoiYzUyNTQ0YTYtNjFjOS00YzA3LWIxNmUtMmNkNDU4NTMxOTVlIiwiZG9Ob3REZWxldGUiOmZhbHNlLCJleHAiOjE2Mzg5MzE5MjIsImlhdCI6MTYzODkyODkyMiwianRpIjoiMWY4OWQ3YzAtYmY3Ni00NmNhLWJiZGYtNmFiZTYyZmI0ZTY0IiwiZW1haWwiOiJmc2lsdmFAY29tcHVncmFmLmNvbS5iciJ9.XEx4OKRm5TYtgtFHygT_graC4C19drZ_3pwVu-biC13HZ7fXf59Vsmdp9axn6_Xr2-jqBnGlwkkPgwp60GZqPsBYLdaE1vPkl_iKtDO0gfdC0zcVYrJeCF_rDaBUuSbwbJ4OBERZ1UHP9xJGG0gzhrhpmK3JdR6FvALKS3vCy8TD84uaoXHmMPzZuFBKb_ww7CPAHkcbDMXZTiGHCeUtKdV1DSf2W71Kjrqlvq4v4LWAFB-iJJmRm9HUuq6ayXbwhW_1j5XTLGLPGArwrIuuHyj5ebjUcwI5llkQpDNASZ34FTQht8w2jUHe4sSlYPiDJBlE72KkhlzbWMz-4gFDIg"));




            WriteLine("----------------- UTILIZANDO OUTRA CRIPTOGRAFIA -----------------");

        }
    }
}
