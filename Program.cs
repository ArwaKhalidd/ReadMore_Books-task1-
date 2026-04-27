using ReadMore_Books_task1_;
using System;

class Program
{
    static void Main(string[] args)
    {
        using (AppDbContext dbContext=new())
        {
           
            dbContext.Database.EnsureCreated();

            Console.WriteLine("Database created successfully!");
        }
    }
}