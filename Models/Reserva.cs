namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            //Implementação Kaue
            if (Suite.Capacidade >= hospedes.Count)
            {
                Hospedes = hospedes;
            }
            else
            {
                // Implentação Kaue*
                throw new Exception ("A quantidade de hóspedes não pode exceder a capacidade da suite");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            //Implementação Kaue
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            //Implementação Kaue
            decimal valor = Suite.ValorDiaria * DiasReservados;

            //Implementação Kaue
            if (DiasReservados >= 10)
            {
                valor -= valor * 10/100;//valor * (10 / 100);
                
            }
                return valor;            
        }
    }
}