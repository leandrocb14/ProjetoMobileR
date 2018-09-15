using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoMobile.Model.DAO
{
    public class CumprimentoUsuarioDAO
    {
        public string AvaliaHoraDeCumprimentoUsuario()
        {
            TimeSpan InicioHorarioManha = new TimeSpan(0, 0, 0);
            TimeSpan FimHorarioManha = new TimeSpan(12, 0, 0);
            TimeSpan InicioHorarioTarde = new TimeSpan(12, 00, 0);
            TimeSpan FimHorarioTarde = new TimeSpan(18, 0, 0);
            TimeSpan InicioHorarioNoite = new TimeSpan(18, 0, 0);
            TimeSpan FimHorarioNoite = new TimeSpan(0, 0, 0);            
            TimeSpan HorarioAtual = new TimeSpan(DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
            if (HorarioAtual >= InicioHorarioManha && HorarioAtual < FimHorarioManha)
            {
                return "Bom dia!";
            }
            else if (HorarioAtual >= InicioHorarioTarde && HorarioAtual < FimHorarioTarde)
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
