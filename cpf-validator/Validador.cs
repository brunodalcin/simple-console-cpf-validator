using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cpf_validator {
    public class Validador {
        public int Cpf;
        public static void validaCpf(string cpf) {
            //declaring variables for the logic
            int[] primeiraValidacao = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] segundaValidacao = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string cpf1, cpf2;
            int soma, resultado=0;

            //clearing possible formatting used
            cpf = cpf.Trim();
            cpf = cpf.Replace(".", "").Replace("-", "");

            //verifying if its the right size for a CPF
            if (cpf.Length != 11) {
                Console.WriteLine("O CPF precisa ter exatamente 11 números.");
            }
            cpf1 = cpf.Substring(0, 9);
            //logic for the 10nth digit

            soma = 0;
            for (int x = 0; x < 9; x++) {
                //passing the cpf strings for int, to do the math
                //utilizing the logic formula for cpf, with the cascating multiplications
                soma += int.Parse(cpf1[x].ToString()) * primeiraValidacao[x];
            }
            resultado = soma % 11;
            if (resultado < 2) {
                resultado = 0;
            }
            else {
                resultado = 11 - resultado;
            }


            cpf2 = resultado.ToString();//here we get the 10nth digit
            //receive 9 digits from the user + the 10nth found
            cpf1 = cpf1 + cpf2;

            soma = 0;
            for (int y = 0; y < 10; y++) {
                //passing the cpf strings for int, to do the math
                //utilizing the logic formula for cpf, with the cascating multiplications
                soma += int.Parse(cpf1[y].ToString()) * segundaValidacao[y];
            }
            resultado = soma % 11;
            if (resultado < 2) {
                resultado = 0;
            }
            else {
                resultado = 11 - resultado;
            }
            //putting the 10 cpf digits with the found 11nth digit.
            cpf1 = cpf1 + resultado.ToString();
            if (cpf1 == cpf) {
                Console.WriteLine("CPF " + cpf + " is valid.");
            }
            else {
                Console.WriteLine("CPF " + cpf + " is UNVALID.");
            }
        }
    }

}
