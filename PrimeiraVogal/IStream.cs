using System;

namespace PrimeiraVogal
{
    public interface IStream
    {

        /// <summary>
        /// Vai para o próximo caracter.
        /// </summary>
        void GetNext();

        /// <summary>
        /// Verifica se existe mais caracteres para leitura
        /// </summary>
        /// <returns></returns>
        Boolean HasNext();

    }
}
