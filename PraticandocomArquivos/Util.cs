using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticandocomArquivos
{
    public class Util
    {
       private static string caminhoArquivo = @"D:\C#-POO-Ralf\TreinoArq\PraticandocomArquivos\usuarios.csv";
       private static List<Usuario> user = new List<Usuario>();
        

        public static void LerDados()
        {
            if (!File.Exists(caminhoArquivo))
            {
                File.Create(caminhoArquivo).Close();
            }

            try
            {
                StreamReader sr = new StreamReader(caminhoArquivo);

                while (!sr.EndOfStream)
                {
                    string[] linha = sr.ReadLine().Split(';');
                    user.Add(new Usuario(linha[0], linha[1], linha[2]));
                }
                sr.Close();
                sr.Dispose();
            }
            catch (Exception ex) { }
        }

        public static List<Usuario> retornaDados()
        {
            return user;
        }

        public static void GravaDados(string nome, string email, string senha)
        {
            try
            {

                StreamWriter writer = new StreamWriter(caminhoArquivo,append: true ,Encoding.UTF8);
                writer.WriteLine(nome + ";" + email + ";" + senha);

                writer.Close();
                writer.Dispose();
            }catch(Exception ex) { }
        }
    }
}
