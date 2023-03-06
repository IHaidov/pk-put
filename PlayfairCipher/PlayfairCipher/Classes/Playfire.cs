using PlayfairCipher.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayfairCipher.Classes
{
    internal class Playfire : IPlayfire
    {
        private static char[,] grid = new char[5,5];
        private char padChar = 'X';

        public char[,] GenerateMatrix(string key)
        {
            // Step 1: Remove duplicate characters and replace 'J' with 'I'
            string processedKey = new String(key.Distinct().ToArray()).Replace("J", "I");

            // Step 2: Add remaining alphabet characters to the key
            string alphabet = "ABCDEFGHIKLMNOPQRSTUVWXYZ";
            string remainingChars = new String(alphabet.Where(c => !processedKey.Contains(c)).ToArray());
            string keyAlphabet = processedKey + remainingChars;

            // Step 3: Initialize 5x5 matrix
            char[,] matrix = new char[5, 5];
            try
            {
                // Step 4: Populate matrix with keyAlphabet characters
                int index = 0;
                for (int row = 0; row < 5; row++)
                {
                    for (int col = 0; col < 5; col++)
                    {
                        matrix[row, col] = keyAlphabet[index];
                        index++;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            grid = matrix;
            return matrix;
        }
        private Tuple<int, int> GetPosition(char c)
        {
            // Get the position of a letter in the grid
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (grid[i, j] == c)
                    {
                        return new Tuple<int, int>(i, j);
                    }
                }
            }
            throw new Exception("Character not found in grid: " + c);
        }

        private static void FindChar(char c, char[,] matrix, out int row, out int col)
        {
            row = -1;
            col = -1;

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (matrix[i, j] == c)
                    {
                        row = i;
                        col = j;
                        return;
                    }
                }
            }
        }


        public string Decrypt(string message, string key)
        {
            message = message.ToUpper().Replace(" ", "").Replace("J", "I");
            key = key.ToUpper().Replace(" ", "").Replace("J", "I");

            string decryptedText = "";
            try
            {

                char[,] matrix = GenerateMatrix(key);

                // Perform decoding
                string decoded = "";
                for (int i = 0; i < message.Length; i += 2)
                {
                    char c1 = message[i];
                    char c2 = message[i + 1];
                    Tuple<int, int> pos1 = GetPosition(c1);
                    Tuple<int, int> pos2 = GetPosition(c2);
                    if (pos1.Item1 == pos2.Item1)
                    {
                        // Letters in the same row
                        decoded += grid[pos1.Item1, (pos1.Item2 - 1 + 5) % 5];
                        decoded += grid[pos2.Item1, (pos2.Item2 - 1 + 5) % 5];
                    }
                    else if (pos1.Item2 == pos2.Item2)
                    {
                        // Letters in the same column
                        decoded += grid[(pos1.Item1 - 1 + 5) % 5, pos1.Item2];
                        decoded += grid[(pos2.Item1 - 1 + 5) % 5, pos2.Item2];
                    }
                    else
                    {
                        // Letters in different rows and columns
                        decoded += grid[pos1.Item1, pos2.Item2];
                        decoded += grid[pos2.Item1, pos1.Item2];
                    }
                }

                // Remove "X" padding characters
                for (int i = 0; i < decoded.Length - 1; i++)
                {
                    if (decoded[i] == padChar && decoded[i + 1] == decoded[i])
                    {
                        decoded = decoded.Remove(i, 1);
                    }
                }
                if (decoded[decoded.Length - 1] == padChar)
                {
                    decoded = decoded.Substring(0, decoded.Length - 1);
                }
                return decoded.ToUpper();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return decryptedText;
        }


        public string Encrypt(string message, string key)
        {
            message = message.ToUpper().Replace(" ", "").Replace("J","I");
            key = key.ToUpper().Replace(" ", "").Replace("J", "I");

            string cipherText = "";
            try
            {

                char[,] matrix = GenerateMatrix(key);

                
                // Pad with "X" between repeated letters
                for (int i = 0; i < message.Length - 1; i += 2)
                {
                    if (message[i] == message[i + 1])
                    {
                        message = message.Substring(0, i + 1) + padChar.ToString() + message.Substring(i + 1);
                    }
                }
                if (message.Length % 2 == 1)
                {
                    message += padChar.ToString();
                }
                // Perform encoding
                string encoded = "";
                for (int i = 0; i < message.Length; i += 2)
                {
                    char c1 = message[i];
                    char c2 = message[i + 1];
                    Tuple<int, int> pos1 = GetPosition(c1);
                    Tuple<int, int> pos2 = GetPosition(c2);
                    if (pos1.Item1 == pos2.Item1)
                    {
                        // Letters in the same row
                        encoded += grid[pos1.Item1, (pos1.Item2 + 1) % 5];
                        encoded += grid[pos2.Item1, (pos2.Item2 + 1) % 5];
                    }
                    else if (pos1.Item2 == pos2.Item2)
                    {
                        // Letters in the same column
                        encoded += grid[(pos1.Item1 + 1) % 5, pos1.Item2];
                        encoded += grid[(pos2.Item1 + 1) % 5, pos2.Item2];
                    }
                    else
                    {
                        // Letters in different rows and columns
                        encoded += grid[pos1.Item1, pos2.Item2];
                        encoded += grid[pos2.Item1, pos1.Item2];
                    }
                }
                return encoded;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return "";

        }

        public void GenerateTable(string text, string key)
        {
            
        }
    }
}
