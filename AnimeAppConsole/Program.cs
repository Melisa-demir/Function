using Microsoft.EntityFrameworkCore;

namespace AnimeAppConsole;

internal class Program
{
    static void Main(string[] args)
    {
        using (var context = new AnimeAppDbContext())
        {
         // Console.WriteLine("Id bilgisini giriniz: ");
         // int gId = Convert.ToInt32(Console.ReadLine()); ;
          
            int gId = 1;
            var animeDetails = (from a in context.Animes
                join g in context.Genres on a.GenreId equals g.Id where g.Id == gId
                select new
                {
                      a.Id,
                      a.Name,
                      g.Type
                }).ToList();
            foreach (var item in animeDetails)
            {
                Console.WriteLine($"Id : {item.Id} - Anime Name : {item.Name} - Genre : {item.Type}"); 
            }
        }
    }
}
