using System;

namespace AgendaContatos
{
    public class Contato
    {
        // Propriedades básicas
        public string Nome { get; set; }
        public string Telefone { get; set; }

        // Este método define como o contato aparece na ListBox
        public override string ToString()
        {
            // O PadRight serve para alinhar o texto em colunas
            return $"{Nome.PadRight(25)} | {Telefone}";
        }

        // Método auxiliar para converter uma linha do TXT em um objeto Contato
        public static Contato DaLinha(string linha)
        {
            try
            {
                var partes = linha.Split('|');
                if (partes.Length >= 2)
                {
                    return new Contato
                    {
                        Nome = partes[0].Trim(),
                        Telefone = partes[1].Trim()
                    };
                }
            }
            catch
            {
                // Se a linha estiver corrompida, ignora
            }
            return null;
        }
    }
}