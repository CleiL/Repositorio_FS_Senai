using PROJETOUC12_CONTAS.Interface;
namespace PROJETOUC12_CONTAS.Classes
{
    public abstract class Pessoa : IPessoa
    {
        public string ?nome { get; set;}
        public Endereco ?endereco {get; set;}
        public float ?rendimento { get; set;}
        
        public abstract float pagarImposto(float rendimento);
        public void VerificarPastaArquivo(string caminho)
        {
            string pasta = caminho.Split("/")[0];

            if(!Directory.Exists(pasta)){
                Directory.CreateDirectory(pasta);
            }

            if(!File.Exists(caminho))
            {
                using (File.Create(caminho)){} 
            }
        }

    }
}