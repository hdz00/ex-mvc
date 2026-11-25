namespace teste.Models
{
    public class HomeViewModel
    {
        public List<Servico> Servicos {get; set;}

        public Promocao Promocao {get; set;}

        public string Termo {get; set;}="";
    }
}