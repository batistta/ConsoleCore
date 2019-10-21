namespace Teste
{
    public class newclass {
        public string nome { get; set; }
        public int idade { get; set; }
        public double altura { get; set; }
        public newclass () {
            nome = "jao";
            idade = 23;
            altura = 1.65;// dale doly
        }
        public string print () {
            return "Nome: " + nome + "\nIdade: " + idade + "\nAltura: " + altura;
        }
    }
}