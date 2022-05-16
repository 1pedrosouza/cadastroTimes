using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace time.Model
{
    public class Times
    {
       private static int codTimes;
       private static string nomeTimee;
       private static string logoTimes;
       private static string fraseTimes;
       private static string retorno;


        public static int CodTimes { get => codTimes; set => codTimes = value; }
        public static string NomeTimee { get => nomeTimee; set => nomeTimee = value; }
        public static string LogoTimes { get => logoTimes; set => logoTimes = value; }
        public static string FraseTimes { get => fraseTimes; set => fraseTimes = value; }
        public static string Retorno { get => retorno; set => retorno = value; }
    }
}
