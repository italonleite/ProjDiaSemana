using System;
using System.Collections.Generic;
using System.Linq;

namespace App
{
    public class DiaSemana
    {
        Dictionary<int, EnumDias> dicionario;

        public string MsgErroInvalido
        {
            get
            {
                return "Intervalo de dias inválido, favor colocar um dia que esteja a frente do dia atual!";
            }
        }

        public DiaSemana()
        {
            dicionario = CarregaDicionario();
        }

        private Dictionary<int, EnumDias> CarregaDicionario()
        {
            dicionario = new Dictionary<int, EnumDias>
            {
                { 1, EnumDias.Seg },
                { 2, EnumDias.Ter },
                { 3, EnumDias.Qua },
                { 4, EnumDias.Qui },
                { 5, EnumDias.Sex },
                { 6, EnumDias.Sab },
                { 7, EnumDias.Dom }
            };

            return dicionario;
        }

        public EnumDias BuscaDiaSemana(EnumDias dia, int intervalo)
        {
            if (intervalo < 1)
                throw new Exception(this.MsgErroInvalido);

            int posicao = (int)dia;

            int mod;
            if (intervalo > 7)
                mod = intervalo % 7;
            else
                mod = intervalo;

            int novaPosicao = mod + posicao;
            if (novaPosicao > 7)
                novaPosicao = -7;

            return dicionario.Where(x => x.Key == novaPosicao).First().Value;
        }
    }
}