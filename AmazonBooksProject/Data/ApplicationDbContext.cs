namespace AmazonBooksProject.Data;
using Microsoft.EntityFrameworkCore;
using AmazonBooksProject.Models;


public class ApplicationDbContext: DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options){

    }

    public DbSet<Books> AmazonBooks {get;}
    
}