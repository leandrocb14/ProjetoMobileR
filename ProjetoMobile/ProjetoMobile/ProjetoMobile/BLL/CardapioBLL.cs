using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoMobile.BLL
{
    public class CardapioBLL
    {
        public string AvaliaHoraDeCumprimentoUsuario(TimeSpan horarioAtual)
        {
            TimeSpan InicioHorarioManha = new TimeSpan(0, 0, 0);
            TimeSpan FimHorarioManha = new TimeSpan(12, 0, 0);
            TimeSpan InicioHorarioTarde = new TimeSpan(12, 00, 0);
            TimeSpan FimHorarioTarde = new TimeSpan(18, 0, 0);
            TimeSpan InicioHorarioNoite = new TimeSpan(18, 0, 0);
            TimeSpan FimHorarioNoite = new TimeSpan(0, 0, 0);            
            if (horarioAtual >= InicioHorarioManha && horarioAtual < FimHorarioManha)
            {
                return "Bom dia!";
            }
            else if (horarioAtual >= InicioHorarioTarde && horarioAtual < FimHorarioTarde)
            {
                return "Boa tarde!";
            }
            else
            {
                return "Boa noite!";
            }
        }
    }
}
