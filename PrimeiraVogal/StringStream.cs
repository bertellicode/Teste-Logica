using System;

namespace PrimeiraVogal
{
    public class StringStream : IStream
    {

        public String stream;
        public char[] streamArray;
        public int index;
        public int[] countVowel;

        public StringStream()
        {
            this.index = 0;
            countVowel = new int[5];
        }

        public StringStream(String stream)
        {
            this.stream = stream;
            this.streamArray = stream.ToCharArray();
            this.index = 0;
            countVowel = new int[5];
        }

        /// <summary>
        /// Método resposável achar o primeiro caracter vogal da stream que não se repete após a primeira consoante.
        /// </summary>
        /// <returns></returns>
        public char FindFirstVowel()
        {
            char[] selectedVowels = new char[stream.Length];
            int count = 0;

            while (HasNext())
            {
                if (IsVowel(CharAt(count), true))
                {
                    if (count > 0 && !IsVowel(CharAt(count - 1), false))
                    {
                        selectedVowels[count] = CharAt(count);
                    }
                }
                        
                GetNext();
                count++;
            }

            return GiveResult(selectedVowels);
        }    

        public void GetNext()
        {
            if (index < (streamArray.Length))
                index++;
        }

        public bool HasNext()
        {
            return index < (streamArray.Length);
        }

        /// <summary>
        /// Pega o valor na stream de caracteres de acordo com o índice
        /// </summary>
        /// <param name="index"></param>
        /// <returns>Caracter do índice correspondente.</returns>
        public char CharAt(int index)
        {
            return streamArray[index];
        }

        /// <summary>
        /// Verifica se o caracter passado é uma vogal ou não. Também incermenta a variável countVowel.
        /// </summary>
        /// <param name="c">Caracter a ser verificado.</param>
        /// <param name="shouldCount">Flag que define se a variável countVowel será incrementada.</param>
        /// <returns>Retorna se o caracter é uma vogal ou não.</returns>
        public bool IsVowel(char c, bool shouldCount)
        {
            switch (char.ToLower(c))
            {
                case 'a':
                    {
                        if (shouldCount) countVowel[0]++;
                        return true;
                    }
                case 'e':
                    {
                        if (shouldCount) countVowel[1]++;
                        return true;
                    }
                case 'i':
                    {
                        if (shouldCount) countVowel[2]++;
                        return true;
                    }
                case 'o':
                    {
                        if (shouldCount) countVowel[3]++;
                        return true;
                    }
                case 'u':
                    {
                        if (shouldCount) countVowel[4]++;
                        return true;
                    }
                default: return false;
            }
        }

        /// <summary>
        /// Responsável por indicar a primeira vogal que não se repetiu na string.
        /// </summary>
        /// <param name="arrayVowel">Array com as vogais</param>
        /// <returns>Retorna 0 se não encontrar</returns>
        public char GiveResult(char[] arrayVowel)
        {
            for (int i = 0; i < arrayVowel.Length; i++)
            {
                switch (char.ToLower(arrayVowel[i]))
                {
                    case 'a':
                        if (countVowel[0] == 1)
                            return arrayVowel[i];
                        break;
                    case 'e':
                        if (countVowel[1] == 1)
                            return arrayVowel[i];
                        break;
                    case 'i':
                        if (countVowel[2] == 1)
                            return arrayVowel[i];
                        break;
                    case 'o':
                        if (countVowel[3] == 1)
                            return arrayVowel[i];
                        break;
                    case 'u':
                        if (countVowel[4] == 1)
                            return arrayVowel[i];
                        break;
                    default: break;
                }
            }
            return '0';
        }

    }
}
