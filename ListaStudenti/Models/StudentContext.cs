using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListaStudenti.Models
{
    public class StudentContext:DbContext
    {
        public StudentContext(DbContextOptions optiuni)
              : base(optiuni)
        {

            
        }

        public DbSet<student> Studenti { get; set; }
        

        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
                
            modelBuilder.Entity<student>().HasData(
                new student
                {
                    StudentID = 1,
                    Nume = "Iosif Bodnar",
                    AnStudiu = 1,
                    Nota=8
               
                    
                }, 
                new student
                {
                    StudentID=2,
                    Nume = "Carmen Tanase",
                    AnStudiu=2,
                    Nota = 7
                    
                    
                }, 
                new student
                {
                    StudentID = 3,
                    Nume = "Adela Borogean",
                    AnStudiu=3,
                    Nota = 10
                     
                    
                }
                ); 
        }
    }
}
