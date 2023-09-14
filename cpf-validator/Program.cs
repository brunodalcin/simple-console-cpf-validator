using cpf_validator;

namespace cpf_validator {
    internal class Program {
        
        static void Main(string[] args) {
            string cpf;
            Validador validador = new Validador();
            Console.WriteLine("Insert a CPF for validation: ");
            cpf = Console.ReadLine();
            Validador.validaCpf(cpf);
        }
    }
}