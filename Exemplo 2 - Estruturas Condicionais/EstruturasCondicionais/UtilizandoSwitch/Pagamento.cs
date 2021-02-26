using System;

namespace UtilizandoSwitch
{
    public class Pagamento
    {
        private const int _diasVencimento = 5;

        public Pagamento()
        {
            LancarVencimento();
        }

        public TipoPagamento TipoPagamento { get; set; }
        public decimal Valor { get; set; }
        public DateTime DataVencimento { get; private set; }
        public DateTime DataPagamento { get; set; }

        private void LancarVencimento()
        {
            DateTime hoje = DateTime.Now;
            DateTime vencimentoPrevisto = hoje.AddDays(_diasVencimento);

            if (vencimentoPrevisto.DayOfWeek == DayOfWeek.Saturday)
                vencimentoPrevisto = vencimentoPrevisto.AddDays(2);
            else if (vencimentoPrevisto.DayOfWeek == DayOfWeek.Sunday)
                vencimentoPrevisto = vencimentoPrevisto.AddDays(1);

            this.DataVencimento = vencimentoPrevisto;
        }
    }
}