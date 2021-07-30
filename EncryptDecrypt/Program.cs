using System;

namespace EncryptDecrypt
{
    class Program
    {
        static void Main(string[] args)
        {
            string textToEncrypt = "STARSARESHINNINGINTHESKYANDIAMSITTING";

            string[] encryptedResult = new string[textToEncrypt.Length];

            encryptedResult = EncryptMyText(textToEncrypt, 17);


            Console.WriteLine("Text to encrypt: " + textToEncrypt);

            Console.WriteLine("Encrypted Text: \n");


            for (int i = 0; i < encryptedResult.Length; i++)
            {

                Console.WriteLine("encryptedResult[" + i + "]" + encryptedResult[i].ToString());

            }

            Console.Write("\nFinal combined encrypted text: ");

            for (int j = 0; j < encryptedResult.Length; j++)
            {

                Console.Write(encryptedResult[j].ToString());

            }

        }

        public static string[] EncryptMyText(string text, int k)
        {
            string[] encryptArray = new string[text.Length];

            int p = 0;

            double c = 0;

            for (int i = 0; i < text.Length; i++)
            {
                encryptArray[i] = text[i].ToString();

            }

            for(int j = 0; j < text.Length; j++)
            {
                switch(encryptArray[j].ToString())
                {
                    case "A":
                        {
                            p = 0;
                            c = (p + k) % 26;
                            encryptArray[j] = c.ToString();
                            break; }

                    case "B":
                        {
                            p = 1;
                            c = (p + k) % 26;
                            encryptArray[j] = c.ToString();
                            break; }
                    case "C":
                        {
                            p = 2;
                            c = (p + k) % 26;
                            encryptArray[j] = c.ToString();
                            break;
                        }

                    case "D":
                        {
                            p = 3;
                            c = (p + k) % 26;
                            encryptArray[j] = c.ToString();
                            break;
                        }
                    case "E":
                        {
                            p = 4;
                            c = (p + k) % 26;
                            encryptArray[j] = c.ToString();
                            break;
                        }

                    case "F":
                        {
                            p = 5;
                            c = (p + k) % 26;
                            encryptArray[j] = c.ToString();
                            break;
                        }
                    case "G":
                        {
                            p = 6;
                            c = (p + k) % 26;
                            encryptArray[j] = c.ToString();
                            break;
                        }

                    case "H":
                        {
                            p = 7;
                            c = (p + k) % 26;
                            encryptArray[j] = c.ToString();
                            break;
                        }
                    case "I":
                        {
                            p = 8;
                            c = (p + k) % 26;
                            encryptArray[j] = c.ToString();
                            break;
                        }

                    case "J":
                        {
                            p = 9;
                            c = (p + k) % 26;
                            encryptArray[j] = c.ToString();
                            break;
                        }
                    case "K":
                        {
                            p = 10;
                            c = (p + k) % 26;
                            encryptArray[j] = c.ToString();
                            break;
                        }

                    case "L":
                        {
                            p = 11;
                            c = (p + k) % 26;
                            encryptArray[j] = c.ToString();
                            break;
                        }
                    case "M":
                        {
                            p = 12;
                            c = (p + k) % 26;
                            encryptArray[j] = c.ToString();
                            break;
                        }

                    case "N":
                        {
                            p = 13;
                            c = (p + k) % 26;
                            encryptArray[j] = c.ToString();
                            break;
                        }
                    case "O":
                        {
                            p = 14;
                            c = (p + k) % 26;
                            encryptArray[j] = c.ToString();
                            break;
                        }

                    case "P":
                        {
                            p = 15;
                            c = (p + k) % 26;
                            encryptArray[j] = c.ToString();
                            break;
                        }
                    case "Q":
                        {
                            p = 16;
                            c = (p + k) % 26;
                            encryptArray[j] = c.ToString();
                            break;
                        }

                    case "R":
                        {
                            p = 17;
                            c = (p + k) % 26;
                            encryptArray[j] = c.ToString();
                            break;
                        }
                    case "S":
                        {
                            p = 18;
                            c = (p + k) % 26;
                            encryptArray[j] = c.ToString();
                            break;
                        }

                    case "T":
                        {
                            p = 19;
                            c = (p + k) % 26;
                            encryptArray[j] = c.ToString();
                            break;
                        }
                    case "U":
                        {
                            p = 20;
                            c = (p + k) % 26;
                            encryptArray[j] = c.ToString();
                            break;
                        }

                    case "V":
                        {
                            p = 21;
                            c = (p + k) % 26;
                            encryptArray[j] = c.ToString();
                            break;
                        }
                    case "W":
                        {
                            p = 22;
                            c = (p + k) % 26;
                            encryptArray[j] = c.ToString();
                            break;
                        }

                    case "X":
                        {
                            p = 23;
                            c = (p + k) % 26;
                            encryptArray[j] = c.ToString();
                            break;
                        }
                    case "Y":
                        {
                            p = 24;
                            c = (p + k) % 26;
                            encryptArray[j] = c.ToString();
                            break;
                        }

                    case "Z":
                        {
                            p = 25;
                            c = (p + k) % 26;
                            encryptArray[j] = c.ToString();
                            break;
                        }
                    
                }

            }



            return encryptArray;

        }

        
    }
}
