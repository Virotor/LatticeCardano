using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatticeCardano
{
    class LatticeCardano
    {
        public int Size { get; set; }

        private int countOfDots = 0;

        private int[,] cartNormal;
        private int[,] cartLeft;
        private int[,] cartRight;
        private int[,] cartDown;

        private string fileName;
        private string fileNameOut;
        private string fileNameKey;

        public LatticeCardano(string fileName, string fileNameOut, string fileNameKey)
        {
            this.fileName = fileName;
            this.fileNameOut = fileNameOut;
            this.fileNameKey = fileNameKey;
        }

        public LatticeCardano(int size, string fileName, string fileNameOut, string fileNameKey)
        {
            Size = size;
            this.fileName = fileName;
            this.fileNameOut = fileNameOut;
            this.fileNameKey = fileNameKey;
        }


        public void InitCart(int[,] matrix)
        {
            cartNormal = matrix;
            for(int i = 0; i < Size; i++)
            {
                for(int j = 0; j < Size; j++)
                {
                    if (cartNormal[i, j] == 1)
                    {
                        countOfDots++;
                    }
                }
            }
            cartLeft = Transform(cartNormal);
            cartDown = Transform(cartLeft);
            cartRight = Transform(cartDown);
        }

        private int[,] Transform(int[,] matrix)
        {
            var temp = new int[Size, Size];
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    temp[Size - j-1, i] = matrix[i, j];
                }
            }
            return temp;
        }

        public void EncryptionFile()
        {
            using (FileStream fileStreamIn = File.OpenRead(fileName), fileStreamOut = File.OpenWrite(fileNameOut)) 
            {
                long sizeFile = fileStreamIn.Length;
                long countOfReadBytes = 0;
                int sizeBuffer = 4 * countOfDots;
                while (countOfReadBytes < sizeFile)
                {
                    byte[] buffer = new byte[sizeBuffer];
                    fileStreamIn.Read(buffer, 0, sizeBuffer);
                    var temp = CreateEncryptionSequence(buffer);
                    countOfReadBytes += sizeBuffer;
                    fileStreamOut.Write(temp,0,temp.Length);
                }
            }
        }


        public void WriteKey()
        {
            using (FileStream fileStreamOut = File.OpenWrite(fileNameKey))
            {
                string temp = "";
                for(int i = 0; i < Size; i++)
                {
                    for(int j = 0; j < Size; j++)
                    {
                        temp += cartNormal[i, j].ToString();
                    }
                }
                var c = temp.ToCharArray();
                fileStreamOut.Write(Encoding.ASCII.GetBytes(c), 0, temp.Length);
            }
        }

        public void ReadKey()
        {
            using (FileStream fileStreamIn = File.OpenRead(fileNameKey))
            {
                long sizeFile = fileStreamIn.Length;
                int sizeBuffer =Convert.ToInt32(sizeFile);
                Size =(int) Math.Sqrt(Convert.ToDouble(sizeFile));
                byte[] buffer = new byte[sizeBuffer];
                fileStreamIn.Read(buffer, 0, sizeBuffer);
                var temp = new int[Size, Size];
                for(int i = 0; i < Size; i++)
                {
                    for(int j = 0; j < Size; j++)
                    {
                        temp[i, j] =Convert.ToInt32(buffer[i * Size + j].ToString())-48;
                    }
                }
                InitCart(temp);
            }
        }

        private byte[] CreateSequnceSizeOfMatrix()
        {
            byte[] result = new byte[Size*Size];
            Random random = new Random();
            for(int i = 0; i < Size*Size; i++)
            {
               
               result[i] = Convert.ToByte(random.Next(0,1000000)%150+100);
                
            }
            return result;
        }


        private byte[,] TransformArrayToMatrix(byte[] array)
        {
            byte[,] result = new byte[Size , Size];
            Random random = new Random();
            for (int i = 0; i < Size; i++)
            {
                for(int j = 0; j < Size; j++)
                {
                    result[i,j] = array[i*Size+j];
                }            
            }
            return result;
        }


        private byte[] TransformMatrixToArray(byte[,] matrix)
        {
            byte[] result = new byte[Size * Size];
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    result[i*Size+j] = matrix[i, j];
                }
            }
            return result;
        }

        private byte[] CreateEncryptionSequence(byte[] encyptionSequence)
        {
            byte[] temp = CreateSequnceSizeOfMatrix();
            byte[,] resMatrix = TransformArrayToMatrix(temp);
            int indexResult = 0;
            SmthMagic(cartNormal,ref encyptionSequence, ref resMatrix, ref indexResult);
            SmthMagic(cartRight,ref encyptionSequence, ref resMatrix, ref indexResult);
            SmthMagic(cartDown,ref encyptionSequence, ref resMatrix, ref indexResult);
            SmthMagic(cartLeft,ref encyptionSequence, ref resMatrix, ref indexResult);
            return TransformMatrixToArray(resMatrix);
        }

        private void SmthMagic(int[,] cart ,ref byte[] sequnceForEncryption, ref byte[,] result, ref int indexResult)
        {
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    if (cart[i,j] == 1)
                    {
                        result[i,j] = sequnceForEncryption[indexResult];
                        indexResult++;
                    }
                }
            }
        }

        public void DecipherFile()
        {
            using (FileStream fileStreamIn = File.OpenRead(fileName), fileStreamOut = File.OpenWrite(fileNameOut))
            {
                long sizeFile = fileStreamIn.Length;
                long countOfReadBytes = 0;
                int sizeBuffer = Size*Size;
                while (countOfReadBytes < sizeFile)
                {
                    byte[] buffer = new byte[sizeBuffer];
                    fileStreamIn.Read(buffer, 0, sizeBuffer);
                    var temp = CreateDesipherSequence(buffer);
                    fileStreamOut.Write(temp, 0, temp.Length);
                    countOfReadBytes += sizeBuffer;
                }
            }
        }

        private byte[] TransformToNormal(byte[] inSequnce, int size)
        {
            byte[] result = new byte[size];
            for(int i = 0; i < size; i++)
            {
                result[i] = inSequnce[i];
            }
            return result;
        }

        private byte[] CreateDesipherSequence(byte[] encyptionSequence)
        {
            byte[] temp = new byte[4*countOfDots];
            byte[,] resMatrix = TransformArrayToMatrix(encyptionSequence);
            int indexResult = 0;
            SmthMagicRev(cartNormal, ref temp, ref resMatrix, ref indexResult);
            SmthMagicRev(cartRight, ref temp, ref resMatrix, ref indexResult);
            SmthMagicRev(cartDown, ref temp, ref resMatrix, ref indexResult);
            SmthMagicRev(cartLeft, ref temp, ref resMatrix, ref indexResult);
            return temp;
        }


        private void SmthMagicRev(int[,] cart, ref byte[] result, ref byte[,] matrixForDesipher, ref int indexResult)
        {
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    if (cart[i, j] == 1)
                    {
                        result[indexResult] = matrixForDesipher[i, j];
                        indexResult++;
                    }
                }
            }
        }


    }
}
