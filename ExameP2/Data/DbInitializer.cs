
using ExameP2.Models;
using Microsoft.AspNetCore.Identity;

namespace ExameP2.Data

{

    public class DbInitializer
    {
        private ApplicationDbContext _context;
        

        public DbInitializer(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Run()
        {
            _context.Database.EnsureCreated();

            if (_context.Noticias.Any())
            {
                return;
            }

            var ucs = new Noticia[]
            {
                new Noticia{  Titulo="Leões regressaram aos treinos este domingo",
                    Texto="A equipa principal de futebol do Sporting Clube de Portugal regressou, este domingo, aos treinos na Academia Cristiano Ronaldo, estando já com o foco no encontro contra o SC Braga para as meias-finais da Taça da Liga (terça-feira, 19h45, Estádio Dr. Magalhães Pessoa, Leiria)"},

                new Noticia{  Titulo="Cláudio Pereira é o árbitro do Benfica-Estoril",
                    Texto="Cláudio Pereira, árbitro da AF Aveiro, foi nomeado pelo Conselho de Arbitragem da Federação Portuguesa de Futebol para apitar o Benfica-Estoril, das meias-finais da Taça da Liga. O jogo disputa-se no Estádio Municipal de Leiria às 19h45 de quarta-feira, 24 de janeiro."},
                new Noticia{  Titulo="FC Porto desloca-se a Faro",
                    Texto="O plantel principal do FC Porto voltou na manhã deste domingo ao Olival para dar início à preparação da 19.ª jornada da Liga, em que tem marcada para as 18h00 de domingo (Sport TV) uma deslocação a Faro para defrontar o Farense."}
            };

            _context.Noticias.AddRange(ucs);

            _context.SaveChanges();
        }
    }

}
