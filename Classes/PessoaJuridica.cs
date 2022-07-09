using System.Text.RegularExpressions;
using CadastroPessoa.Interfaces;

namespace CadastroPessoa.Classes
{
    public class PessoaJuridica : Pessoa, IPessoaJuridica
    {

        public string? Cnpj { get; set; }

        public string? RazaoSocial { get; set; }

        public string Caminho { get;private set; } = "Database/PessoaJuridica.csv";

        public override float PagarImposto(float rendimento)
        {
            if (rendimento <= 3000)
            {
                return rendimento * .03f;

            }
            else if (rendimento <= 6000)
            {
                return rendimento * .05f;

            }
            else if (rendimento <= 10000)
            {
                return rendimento * .07f;

            }
            else
            {
                return rendimento * .09f;

            }
        }

        //XX.XXX.XXX/0001-XX ---- XXXXXXXX0001XX
        public bool ValidarCnpj(string cnpj)
        {

            bool retornoCnpjValido = Regex.IsMatch(cnpj, @"(^(\d{2}.\d{3}.\d{3}/\d{4}-\d{2})|(\d{14})$)");

            // if (Regex.IsMatch(cnpj, @"(^(\d{2}.\d{3}.\d{3}/\d{4}-\d{2})|(\d{14})$)"))
            if (retornoCnpjValido == true)
            {
                if (cnpj.Length == 18)
                {
                    string subStringCnpj = cnpj.Substring(11, 4);

                    if (subStringCnpj == "0001")
                    {
                        return true;
                    }


                }
                else if (cnpj.Length == 14)
                {
                    string subStringCnpj = cnpj.SubString(8, 4);

                    if (subStringCnpj == "0001")
                    {
                        return true;
                    }
                }
                else if (cnpj.Length == 14)
                {
                    string subStringCnpj = cnpj.Substring(8,4);

                    if (substringCnpj == "0001")
                    {
                        return true;
                    }
               }
           }

            return false;
        }


        public void Inserir(PessoJuridica pj)
        {

            Utils.VerificarPastaArquivo(Caminho);

            string[] pjStrings = {$"{pj.Nome},{pj.Cnpj}, {pj.RazaoSocial}"};

            File.AppendAllLines(Caminho, pjStrings);
        }

        public List<PessoaJuridica> LerArquivo(){

            List<PessoaJuridica> listPj = new List<PessoaJuridica>();

            string[] linhas = File.ReadAllLines(Caminho);

            //Nome Pj,000000000100,Razão Social Pj
            foreach (string cadaLinha in linhas)
            {
                string[] atributos = cadaLinha.Split(",");

                PessoaJuridica cadaPj = new PessoaJuridica();

                cadaPj.Nome = atributos[0];
                cadaPj.Cnpj = atributos[1];
                cadaPj.RazaoSocial = atributos[2];

                listaPj.Add(cadaPj);
            }

            return listaPj;
        }
    }
}