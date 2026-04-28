using Microsoft.EntityFrameworkCore;
using ReadMore_Books_task1_;
using System;

class Program
{
    static void Main(string[] args)
    {
        using (AppDbContext dbContext=new())
        {

            dbContext.Database.MigrateAsync();
            Console.WriteLine("Database created successfully!");
        }
    }
}