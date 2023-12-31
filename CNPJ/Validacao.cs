using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNPJ
{
    public class Validacao
    {
        public bool validarCnpj(string cnpj)
        {
            int[] multiplicador1 = new int[12] {5,4,3,2,9,8,7,6,5,4,3,2};
            int[] multiplicador2 = new int[13] { 6,5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int somador;
            int resto;
            string digito;
            string cnpjAux;
            //evitar alguns erros
            cnpj = cnpj.Trim(); //tira tds espaçamentos do começo e fim
            //cnpj = cnpj.Replace(",", "").Replace("/", "").Replace("-", "");//Retira os caracteres como virgula barra e traço
            if(cnpj.Length != 14)
            {
                return false;
            }
            else
            {
                cnpjAux = cnpj.Substring(0, 12);
                somador = 0;

                for (int i = 0; i < 12; i++)
                {
                    somador += Convert.ToInt16(cnpjAux[i]) * multiplicador1[i];

                }
                resto = (somador % 11);
                if(resto < 2)
                {
                    resto = 0;
                }
                else
                {
                    resto = 11 - resto;
                }
                digito = resto.ToString(); // Armazenado o primeiro digito
                cnpjAux = cnpjAux + digito;
                //  adicionado 13 numeros
                somador = 0;
                for (int i = 0; i < 13; i++)
                {
                    somador += int.Parse(cnpjAux[i].ToString()) * multiplicador2[i];
                    //anotação de erro o valor [i] e colocado como CHAR nem Conver nem Parse convertem valores CHAR para foi adicionado o ToString logo apos para assim o Parse ler ambos como String e fazer a conversão para INT
                }
                resto = (somador % 11);
                if (resto < 2)
                {
                    resto = 0;
                }
                else
                {
                    resto = 11 - resto;
                }
                digito = digito + resto.ToString(); // concatenando o primeiro com o segundo "00"
                return cnpj.EndsWith(digito); //Verifica se o final e igual digito se for verdadeiro retorna true

            }

        }
    }
}
