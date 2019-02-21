using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Numerics;
using System.Security.Cryptography;

namespace WindowsFormsApp5
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            cbHashAlgorithm.SelectedIndex = 1;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void tbP_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || (Char.IsControl(e.KeyChar)))
                return;
            else
                e.Handled = true;
        }

        private void tbQ_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || (Char.IsControl(e.KeyChar)))
                return;
            else
                e.Handled = true;
        }

        private int gcd(int a, int b)
        {
            if (b == 0)
                return a;
            else
                return gcd(b, a % b);
        }

        private BigInteger gcd(BigInteger a, BigInteger b)
        {
            if (b == 0)
                return a;
            else
                return gcd(b, a % b);
        }

        private bool prime(int n)
        {
            for (int i = 2; i < Math.Sqrt(n); i++)
                if (n % i == 0)
                    return false;
            return true;
        }

        private int Advanced_Euclidean_Algorithm(int a,
           int b, ref int x, ref int y)
        {
            int q, r, x1, x2, y1, y2, d;
            if (b == 0)
            {
                d = a;
                x = 1;
                y = 0;
                return d;
            }
            x2 = 1;
            x1 = 0;
            y2 = 0;
            y1 = 1;
            while (b > 0)
            {
                q = a / b;
                r = a - q * b;
                x = x2 - q * x1;
                y = y2 - q * y1;
                a = b;
                b = r;
                x2 = x1;
                x1 = x;
                y2 = y1;
                y1 = y;
            }
            d = a; x = x2; y = y2;
            return d;
        }

        private BigInteger BigIntegerAdvanced_Euclidean_Algorithm(BigInteger a,
          BigInteger b, ref BigInteger x, ref BigInteger y)
        {
            BigInteger q, r, x1, x2, y1, y2, d;
            if (b == 0)
            {
                d = a;
                x = 1;
                y = 0;
                return d;
            }
            x2 = 1;
            x1 = 0;
            y2 = 0;
            y1 = 1;
            while (b > 0)
            {
                q = a / b;
                r = a - q * b;
                x = x2 - q * x1;
                y = y2 - q * y1;
                a = b;
                b = r;
                x2 = x1;
                x1 = x;
                y2 = y1;
                y1 = y;
            }
            d = a; x = x2; y = y2;
            return d;
        }


        // way with recurtion
        private ulong FastExp_Rec(int a, int n)
        {
            if (n == 0)
                return 1;
            if (n % 2 == 1)
            {
                return FastExp_Rec(a, n - 1);
            }
            else
            {
                ulong b = FastExp_Rec(a, n / 2);
                return b * b;
            }
        }

        // x = a^z mod m
        private int FastExp(int a, int z, int m)
        {
            int x = 1;
            int a1 = a, z1 = z;
            while (z1 > 0)
            {
                while (z1 % 2 == 0)
                {
                    z1 /= 2;
                    a1 = (a1 * a1) % m;
                }
                z1 -= 1;
                x = (x * a1) % m;
            }
            return x;
        }

        private BigInteger FastExp(BigInteger a, BigInteger z, BigInteger m)
        {
            BigInteger x = 1;
            BigInteger a1 = a, z1 = z;
            while (z1 > 0)
            {
                while (z1 % 2 == 0)
                {
                    z1 /= 2;
                    a1 = (a1 * a1) % m;
                }
                z1 -= 1;
                x = (x * a1) % m;
            }
            return x;
        }

        private int CalculateOpenR(int p, int q)
        {
            return p * q;
        }

        private int FindEulerFunction(int p, int q)
        {
            return (p - 1) * (q - 1);
        }

        private BigInteger BigIntegerFindEulerFunc(BigInteger p, BigInteger q)
        {
            return (p - 1) * (q - 1);
        }

        //eratosthene sieve
        private bool IsPrime_Eratosthene(int n)
        {
            bool[] primes = new bool[n + 1];
            int i;
            for (i = 0; i < n + 1; i++)
                primes[i] = true;
            primes[0] = false;
            primes[1] = false;
            for (i = 2; i < primes.Length; ++i)
            {
                if (primes[i])
                {
                    for (int j = 2; i * j < primes.Length; ++j)
                    {
                        primes[i * j] = false;
                    }
                }
            }
            return primes[n];
        }

        const int MIN_PQ = 255;
        const int MAX_PQ = 16384;

        private bool Check_PQ(int p, int q)
        {
            if ((IsPrime_Eratosthene(p)) && (IsPrime_Eratosthene(q)) && (p * q > MIN_PQ) && (p * q < MAX_PQ))
                return true;
            else
                return false;
        }


        private int FindE(int d, int phi)
        {
            int x = 0, y = 0;
            Advanced_Euclidean_Algorithm(phi, d, ref x, ref y);
            if (y < 0)
                y += phi;
            return y;
        }

        private BigInteger BigIntegerFindE(BigInteger d, BigInteger phi)
        {
            BigInteger x = 0, y = 0;
            BigIntegerAdvanced_Euclidean_Algorithm(phi, d, ref x, ref y);
            if (y < 0)
                y += phi;
            return y;
        }

        const int MAX_TEXT_LENGTH = 2048;
        private void DisplayPlaintextOnScreen(byte[] PlainText)
        {
            if (PlainText.Length >= MAX_TEXT_LENGTH)
            {
                for (int i = 0; i < MAX_TEXT_LENGTH; i++)
                {
                    rtbPlainText.Text += Convert.ToString(PlainText[i]) + " ";
                }
            }
            else
            {
                for (int i = 0; i < PlainText.Length; i++)
                {
                    rtbPlainText.Text += Convert.ToString(PlainText[i]) + " ";
                }
            }
        }


        const int Code_Space = 32;
        private int[] Encryption(byte[] PlainText, int d, int r)
        {
            int[] Cypher = new int[PlainText.Length];

            int i;
            for (i = 0; i < PlainText.Length; i++)
            {
                Cypher[i] = (int)FastExp(PlainText[i], d, r);
            }
            return Cypher;
        }

        private void DisplayCypherText(int[] Cypher)
        {
            int i;
            if (Cypher.Length >= MAX_TEXT_LENGTH)
            {
                for (i = 0; i < MAX_TEXT_LENGTH; i++)
                {
                    //  rtbCipher.Text += Convert.ToString(Cypher[i]) + " ";
                }
            }
            else
            {
                for (i = 0; i < Cypher.Length; i++)
                {
                    // rtbCipher.Text += Convert.ToString(Cypher[i]) + " ";
                }
            }
        }

        private byte[] Decryption(int[] Cypher, int e, int r)
        {
            int i;
            byte[] PlainText = new byte[Cypher.Length];
            for (i = 0; i < Cypher.Length; i++)
            {
                PlainText[i] = Convert.ToByte(FastExp(Cypher[i], e, r));
            }
            return PlainText;
        }


        private byte[] GetSignature(byte[] data)
        {
            int i, AmountBytes = 0;
            i = data.Length - 1;
            while (data[i] != Code_Space)
            {
                AmountBytes++;
                i--;
            }

            byte[] Signature = new byte[AmountBytes];
            i++;
            int j = 0;
            while (i < data.Length)
            {
                Signature[j] = data[i];
                j++;
                i++;
            }
            return Signature;
        }

        private int CalculateHash_Erud(byte[] Source, int r)
        {
            int Hash_Initial = 100;
            for (int i = 0; i < Source.Length; i++)
                Hash_Initial = FastExp(Hash_Initial + Source[i], 2, r);
            return Hash_Initial;
        }

        private int FindSignature(int Hash, int d, int r)
        {
            return FastExp(Hash, d, r);
        }

        private void DisplaySignature(int Signature)
        {
            tbDigitalSignature.Text = Convert.ToString(Signature);
        }

        private void DisplaySignature(BigInteger Signature)
        {
            tbDigitalSignature.Text = Signature.ToString();
        }

        private void DisplayMessageHash(int MessageHash)
        {
            tbMessageHash.Text = Convert.ToString(MessageHash);
            tbMessageHash_hec.Text = Convert.ToString("X");
        }



        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private uint ConvertToBigEndian(uint LittleEndian)
        {
            byte[] ConverterArray = BitConverter.GetBytes(LittleEndian);
            Array.Reverse(ConverterArray);
            uint BigEndian = BitConverter.ToUInt32(ConverterArray, 0);
            return BigEndian;
        }

        private byte[] InitializeBlocks(byte[] data)
        {
            int DefaultLength = data.Length;
            ulong DefaultBitsLength = (ulong)data.Length * 8;

            byte[] with_one = new byte[DefaultLength + 1];
            Array.Copy(data, 0, with_one, 0, DefaultLength);

            //append with 1 in the end of array
            with_one[with_one.Length - 1] = (byte)0x80;

            int NewLength = with_one.Length * 8;
            while (NewLength % 512 != 448)
            {
                NewLength += 8;
            }

            // size of blocks with appended zeros
            byte[] with_zeros = new byte[NewLength / 8];
            Array.Copy(with_one, 0, with_zeros, 0, with_one.Length);

            // add 64 bits with original length
            byte[] output = new byte[with_zeros.Length + 8];
            for (int i = 0; i < 8; i++)
            {
                output[output.Length - 1 - i] = (byte)((DefaultBitsLength >> (8 * i)) & 0xFF);
            }
            Array.Copy(with_zeros, 0, output, 0, with_zeros.Length);
            return output;
        }

        public static uint RotateLeft(uint value, int count)
        {
            return (value << count) | (value >> (32 - count));
        }

        public static uint RotateRight(uint value, int count)
        {
            return (value >> count) | (value << (32 - count));
        }

        private BigInteger Calculate_SHA1(byte[] InitializedBlocks)
        {
            uint h0 = 0x67452301;
            uint h1 = 0xEFCDAB89;
            uint h2 = 0x98BADCFE;
            uint h3 = 0x10325476;
            uint h4 = 0xC3D2E1F0;

            int AmountBlocks = InitializedBlocks.Length / 64;
            uint[] WArray = new uint[80];
            //BigInteger digest = 0;

            int j = 0;
            for (int i = 0; i < AmountBlocks; i++)
            {
                int k = 0;
                for (; k < 16; k++)
                {
                    /*  int u = (4 * k) + i * 64;
                      WArray[k] = (WArray[u + 3] & 0xFFU) | ((WArray[u + 2] & 0xFFU) << 8)
  |                       ((WArray[u + 1] & 0xFFU) << 16) | ((WArray[u + 0] & 0xFFU) << 24); */

                    WArray[k] = BitConverter.ToUInt32(InitializedBlocks, j);
                    WArray[k] = ConvertToBigEndian(WArray[k]);
                    j += 4;
                }
                for (; k < 80; k++)
                {
                    WArray[k] = RotateLeft((WArray[k - 3] ^ WArray[k - 8] ^ WArray[k - 14] ^ WArray[k - 16]), 1);
                }

                uint a = h0;
                uint b = h1;
                uint c = h2;
                uint d = h3;
                uint e = h4;
                uint f, m;

                for (k = 0; k < 20; k++)
                {
                    f = (b & c) | ((~b) & d);
                    m = 0x5A827999;
                    uint temp = RotateLeft(a, 5) + f + e + m + WArray[k];
                    e = d;
                    d = c;
                    c = RotateLeft(b, 30);
                    b = a;
                    a = temp;
                }
                for (; k < 40; k++)
                {
                    f = (b ^ c ^ d);
                    m = 0x6ED9EBA1;
                    uint temp = RotateLeft(a, 5) + f + e + m + WArray[k];
                    e = d;
                    d = c;
                    c = RotateLeft(b, 30);
                    b = a;
                    a = temp;
                }
                for (; k < 60; k++)
                {
                    f = (b & c) | (b & d) | (c & d);
                    m = 0x8F1BBCDC;
                    uint temp = RotateLeft(a, 5) + f + e + m + WArray[k];
                    e = d;
                    d = c;
                    c = RotateLeft(b, 30);
                    b = a;
                    a = temp;
                }
                for (; k < 80; k++)
                {
                    f = b ^ c ^ d;
                    m = 0xCA62C1D6;
                    uint temp = RotateLeft(a, 5) + f + e + m + WArray[k];
                    e = d;
                    d = c;
                    c = RotateLeft(b, 30);
                    b = a;
                    a = temp;
                }

                h0 = h0 + a;
                h1 = h1 + b;
                h2 = h2 + c;
                h3 = h3 + d;
                h4 = h4 + e;


                // Итоговое хеш-значение(h0, h1, h2, h3, h4 должны быть преобразованы к big - endian): 
                // digest = hash = h0 append h1 append h2 append h3 append h4
            }

            BigInteger digest = ((new BigInteger(h0) << 128) | (new BigInteger(h1) << 96) |
                    (new BigInteger(h2) << 64) | (new BigInteger(h3) << 32) | (new BigInteger(h4)));
            return digest;
        }

        private void BigIntegerDisplayMessageHash(BigInteger MessageHash)
        {
            BigInteger copy = MessageHash;
            string temp = "", NewStringWithoutZeros = "";

            tbMessageHash.Text = MessageHash.ToString();
            temp = copy.ToString("X");

            int i = 0; 
            while(temp[i] == '0')
            {
                i++;
            }
            int k = 0;
            for(int j = i; j < temp.Length; j++)
            {
                NewStringWithoutZeros += temp[j];
                k++;
            }

            tbMessageHash_hec.Text = NewStringWithoutZeros;
        }

        private BigInteger BigIntegerFindSignature(BigInteger HashValue, BigInteger d, BigInteger r)
        {
            return FastExp(HashValue, d, r);
        }

        private int GetDispalyR(int p, int q)
        {
            int r = CalculateOpenR(p, q);
            tbR.Text = Convert.ToString(r);
            return r;
        }

        //Test Rabin-Miler for finding simple numbers 
        private bool IsProbablePrime(BigInteger source, int certainty)
        {
            if (source == 2 || source == 3)
                return true;
            if (source < 2 || source % 2 == 0)
                return false;

            BigInteger d = source - 1;
            int s = 0;

            while (d % 2 == 0)
            {
                d /= 2;
                s += 1;
            }

            // There is no built-in method for generating random BigInteger values.
            // Instead, random BigIntegers are constructed from randomly generated
            // byte arrays of the same length as the source.
            RandomNumberGenerator rng = RandomNumberGenerator.Create();
            byte[] bytes = new byte[source.ToByteArray().LongLength];
            BigInteger a;

            for (int i = 0; i < certainty; i++)
            {
                do
                {
                    rng.GetBytes(bytes);
                    a = new BigInteger(bytes);
                }
                while (a < 2 || a >= source - 2);

                BigInteger x = BigInteger.ModPow(a, d, source);
                if (x == 1 || x == source - 1)
                    continue;

                for (int r = 1; r < s; r++)
                {
                    x = BigInteger.ModPow(x, 2, source);
                    if (x == 1)
                        return false;
                    if (x == source - 1)
                        break;
                }

                if (x != source - 1)
                    return false;
            }
            return true;
        }

        private bool CheckPrimeBigInteger(BigInteger p, BigInteger q)
        {
            string m = p.ToString();
            int Length_p = m.Length;
            m = q.ToString();
            int Length_q = m.Length;

            BigInteger mul = p * q;
            int LengthMul = mul.ToString().Length;

            if ((IsProbablePrime(p, 5000)) && (IsProbablePrime(q, 5000)) && (LengthMul > 20) && (p != q))
                return true;
            else
                return false;
        }

        const string NOT_DETERMINED_FIELD = "Error. Before encryption you should determint all filds.";
        const string D_REQUIREMENTS = "Error. D should satisfy: 1 < d < phi(r) and (d, phi(r)) = 1.";
        const string PQ_REQUIREMENTS = "Error. P and Q should be prime and satidfy statement: 255 <p*q< 16384.";

        const string EMPTY_FILE_MSG = "File is empty.Try another one.";
        const string FILE_NOT_CHOOSED =
            "You don't choose any file. Try again.";
        const string FILE_NAME_ENCRYPTION = "Encrypted.txt";
        const string Hash_File = "Hash.txt";
        const string Signature_File = "Signature.txt";
        const string PQ_BIG = "p and q should be prime and mutually simple, p * q should have length higher than 160 bits(20 bytes).";
        const string LONGPQ = "P and Q are too long for int type. Maybe you want to crypt with another hash function?";
        const string LONGER = "R and E are too long for int tyype. Maybe you want to ckeck with another hash function?";

        bool IsEncrypted = false;
        int SignLength = 0;


        private void DiactivateComponents()
        {
            lblGeneratedE.Text = "Open key E: ";
            lblGeneratedR.Text = "Open key R: ";
            tbE.ReadOnly = false;
            tbR.ReadOnly = false;
        }

        private void DeActivateGetSignatureComponents()
        {
            lbNewMessageHash.Visible = false;
            tbNewMessageHash.Visible = false;
            lblNewMessageHashhex.Visible = false;
            tnNewMessageHashHec.Visible = false;

            lblGeneratedE.Text = "Generated key E: ";
            lblGeneratedR.Text = "Generated key R: ";
            tbE.ReadOnly = true;
            tbR.ReadOnly = true;

            tbMessageHash.Text = "";
            tbMessageHash_hec.Text = "";
            tbDigitalSignature.Text = "";

            tbNewMessageHash.Text = "";
            tnNewMessageHashHec.Text = "";
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            DeActivateGetSignatureComponents();
            if ((tbP.Text.Length == 0) || (tbQ.Text.Length == 0)
                || (tbD.Text.Length == 0))
            {
                MessageBox.Show(NOT_DETERMINED_FIELD);
            }
            else
            {
                switch (cbHashAlgorithm.SelectedIndex)
                {
                    case 0:
                        {
                            bool PQ_Correct;
                            int p, q;
                            if ((tbP.Text.Length < 10) && (tbQ.Text.Length < 10) && (tbD.Text.Length < 10))
                            {
                                p = Int32.Parse(tbP.Text); q = Int32.Parse(tbQ.Text);
                                PQ_Correct = Check_PQ(p, q);
                                if (PQ_Correct)
                                {
                                    int r = GetDispalyR(p, q);
                                    int EulerFunctionMeaning = FindEulerFunction(p, q);
                                    int d = Int32.Parse(tbD.Text);

                                    if ((d <= 1) || (d >= EulerFunctionMeaning) || (gcd(d, EulerFunctionMeaning) != 1))
                                    {
                                        MessageBox.Show(D_REQUIREMENTS);
                                    }
                                    else
                                    {
                                        if (OpenFiledlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                                        {
                                            int E = FindE(d, EulerFunctionMeaning);
                                            tbE.Text = Convert.ToString(E);
                                            var fi = new FileInfo(OpenFiledlg.FileName);
                                            if (fi.Length != 0)
                                            {
                                                rtbPlainText.Text = "";
                                                byte[] data = File.ReadAllBytes(OpenFiledlg.FileName);
                                                int MessageHash = CalculateHash_Erud(data, r);
                                                DisplayMessageHash(MessageHash);

                                                int Sign = FindSignature(MessageHash, d, r);
                                                DisplaySignature(Sign);


                                                DisplayPlaintextOnScreen(data);
                                                byte[] SignArr = BitConverter.GetBytes(Sign);
                                                SignLength = SignArr.Length;

                                                // write sign representes as byte array to the file after source data and spacing
                                                byte[] ResArr = new byte[data.Length + 1 + SignArr.Length];
                                                for (int i = 0; i < data.Length; i++)
                                                    ResArr[i] = data[i];
                                                ResArr[data.Length] = (byte)32;
                                                int j = 0;
                                                for (int i = data.Length + 1; i < ResArr.Length; i++)
                                                {
                                                    ResArr[i] = SignArr[j];
                                                    j++;
                                                }

                                                File.WriteAllBytes(OpenFiledlg.FileName, ResArr);


                                                DiactivateComponents();
                                            }
                                            else
                                                MessageBox.Show(EMPTY_FILE_MSG);
                                            IsEncrypted = true;
                                        }
                                        else
                                            MessageBox.Show(FILE_NOT_CHOOSED);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show(PQ_REQUIREMENTS);
                                }
                            }
                            else
                                MessageBox.Show(LONGPQ);
                            break;
                        }
                    case 1:
                        {
                            BigInteger p, q;
                            p = BigInteger.Parse(tbP.Text);
                            q = BigInteger.Parse(tbQ.Text);

                            if (CheckPrimeBigInteger(p, q))
                            {
                                BigInteger r = p * q;
                                tbR.Text = r.ToString();

                                BigInteger EulerFuncBigInteger = (p - 1) * (q - 1);
                                BigInteger d = BigInteger.Parse(tbD.Text);

                                if ((d <= 1) || (d >= EulerFuncBigInteger) || (gcd(d, EulerFuncBigInteger) != 1))
                                {
                                    MessageBox.Show(D_REQUIREMENTS);
                                }
                                else
                                {
                                    if (OpenFiledlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                                    {
                                        BigInteger E = BigIntegerFindE(d, EulerFuncBigInteger);
                                        tbE.Text = Convert.ToString(E);
                                        rtbPlainText.Text = "";

                                        byte[] data = File.ReadAllBytes(OpenFiledlg.FileName);
                                        byte[] Initializedrray = InitializeBlocks(data);


                                        BigInteger MessageHash = Calculate_SHA1(Initializedrray);

                                        BigIntegerDisplayMessageHash(MessageHash);

                                        BigInteger Sign = BigIntegerFindSignature(MessageHash, d, r);
                                        DisplaySignature(Sign);


                                        DisplayPlaintextOnScreen(data);
                                        // write sign representes as byte array to the file after source data and spacing
                                        byte[] ArrSignBig = Sign.ToByteArray();
                                        SignLength = ArrSignBig.Length;

                                        byte[] ResArr = new byte[data.Length + 1 + ArrSignBig.Length];
                                        for (int i = 0; i < data.Length; i++)
                                            ResArr[i] = data[i];
                                        ResArr[data.Length] = (byte)32;
                                        int j = 0;
                                        for (int i = data.Length + 1; i < ResArr.Length; i++)
                                        {
                                            ResArr[i] = ArrSignBig[j];
                                            j++;
                                        }

                                        File.WriteAllBytes(Signature_File, ResArr);

                                        IsEncrypted = true;
                                        DiactivateComponents();

                                    }
                                    else
                                        MessageBox.Show(FILE_NOT_CHOOSED);
                                }
                            }
                            else
                                MessageBox.Show(PQ_BIG);
                            break;
                        }
                }
            }
        }

        private void DisplayComparison(int GettingHash, int MessageHash)
        {
            if (GettingHash != MessageHash)
                MessageBox.Show("Message hashes are not equal! Signature is incorrect.");
            else
                MessageBox.Show("Congratuation! Signs and hashed are equal.");
        }

        private void DisplayComparisonBigInteger(BigInteger GettingHash, BigInteger MessageHash)
        {
            if (GettingHash != MessageHash)
                MessageBox.Show("Message hashes are not equal! Signature is incorrect.");
            else
                MessageBox.Show("Congratuation! Signs and hashed are equal.");
        }

        private void ActivateGetSignatureComponents()
        {
            lbNewMessageHash.Visible = true;
            tbNewMessageHash.Visible = true;
            lblNewMessageHashhex.Visible = true;
            tnNewMessageHashHec.Visible = true;
        }

        private void BigIntegerDisplayNewMessageHashes(BigInteger MessageHash)
        {
            BigInteger copy = MessageHash;
            string NewSringWithoutZeros = "", temp = "";
            tbNewMessageHash.Text = MessageHash.ToString();
            temp  = copy.ToString("X");
            
            int i = 0; 
            while(temp[i] == '0'){
                i++;
            }
            int k = 0;
            for(int j = i; j < temp.Length; j++)
            {
                NewSringWithoutZeros += temp[j];
                k++;
            } 

            tnNewMessageHashHec.Text = NewSringWithoutZeros;
        }

        private void DiplayNewMessageHashes(int MessageHash)
        {
            tbNewMessageHash.Text = Convert.ToString(MessageHash);
            tnNewMessageHashHec.Text = MessageHash.ToString("X");
        }

        const string DeterminedER = "Fields E and R should be determined.";

        private byte[] GetSign(ref int LastWordIndex, byte[] data)
        {
            int i = data.Length - 1;
            while (data[i] != 32)
                i--;
            int j = i;
            LastWordIndex = j;

            byte[] Sign = new byte[data.Length - j - 1];
            int m = 0;
            i += 1;
            for (int k = j + 1; k < data.Length; k++)
            {
                Sign[m] = data[i];
                i++;
                m++;
            }
            return Sign;
        }

        private byte[] NewGetSign(ref int LastWordIndex, byte[] data)
        {
            int i = data.Length - SignLength;
            byte[] Sign = new byte[SignLength];

            int m = 0;
            for(int j = i; j < data.Length; j++)
            {
                Sign[m] = data[j];
                m++;
            }

            LastWordIndex = data.Length - SignLength - 1;
            return Sign;
        }

        private bool CheckRE(BigInteger R, BigInteger E)
        {
            string RString = R.ToString();
            int RLength = RString.Length;
            if ((RLength > 20) && (E > 1))
                return true;
            else
                return false;
        }

        const string ErrorRE = "Length of the R should be bigger than 160 bits. And E should be bigger than 1, if you don't want to have the same message.";
        const string SignFirst = "You firstly should sign and after that you can check signs.";

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (IsEncrypted)
            {
                ActivateGetSignatureComponents();
                if ((tbE.Text.Length == 0) || (tbR.Text.Length == 0))
                {
                    MessageBox.Show(DeterminedER);
                }
                else
                {
                    switch (cbHashAlgorithm.SelectedIndex)
                    {
                        case 0:
                            {
                                if ((tbR.Text.Length < 10) && (tbE.Text.Length < 10))
                                {
                                    int r = Int32.Parse(tbR.Text);
                                    int E = Int32.Parse(tbE.Text);
                                    if ((OpenFiledlg.ShowDialog() == System.Windows.Forms.DialogResult.OK) && (IsEncrypted))
                                    {
                                        IsEncrypted = false;
                                        var fi = new FileInfo(OpenFiledlg.FileName);

                                        if (fi.Length != 0)
                                        {
                                            rtbPlainText.Text = "";
                                            int LastWordIndex = 0;
                                            byte[] dataAndSign = File.ReadAllBytes(OpenFiledlg.FileName);
                                            byte[] FileSign = NewGetSign(ref LastWordIndex, dataAndSign);



                                            byte[] data = new byte[LastWordIndex];
                                            for (int i = 0; i < LastWordIndex; i++)
                                                data[i] = dataAndSign[i];
                                            DisplayPlaintextOnScreen(data);


                                            int MessageHash = CalculateHash_Erud(data, r);
                                            DiplayNewMessageHashes(MessageHash);

                                            int GettingSign = BitConverter.ToInt32(FileSign, 0);

                                            int GettingHash = FindSignature(GettingSign, E, r);
                                            DisplayComparison(GettingHash, MessageHash);
                                        }
                                        else
                                            MessageBox.Show(EMPTY_FILE_MSG);
                                    }
                                    else
                                        MessageBox.Show(FILE_NOT_CHOOSED);
                                }
                                else
                                    MessageBox.Show(LONGER);
                                break;
                            }
                        case 1:
                            {
                                BigInteger R = BigInteger.Parse(tbR.Text);
                                BigInteger E = BigInteger.Parse(tbE.Text);
                                if (CheckRE(R, E))
                                {
                                    if ((OpenFiledlg.ShowDialog() == System.Windows.Forms.DialogResult.OK) && (IsEncrypted))
                                    {
                                        IsEncrypted = false;
                                        rtbPlainText.Text = "";
                                        int LastWordIndex = 0;

                                        byte[] dataAndSign = File.ReadAllBytes(OpenFiledlg.FileName);

                                        byte[] FileSign = NewGetSign(ref LastWordIndex, dataAndSign);
                                        BigInteger GettingSign = new BigInteger(FileSign);


                                        byte[] data = new byte[LastWordIndex];
                                        for (int i = 0; i < LastWordIndex; i++)
                                            data[i] = dataAndSign[i];

                                        DisplayPlaintextOnScreen(data);
                                        byte[] Initializedrray = InitializeBlocks(data);

                                        BigInteger MessageHash = Calculate_SHA1(Initializedrray);

                                        BigIntegerDisplayNewMessageHashes(MessageHash);

                                        // BigInteger GetSign = BigInteger.Parse(tbDigitalSignature.Text);
                                        BigInteger GettingHash = BigIntegerFindSignature(GettingSign, E, R);

                                        DisplayComparisonBigInteger(GettingHash, MessageHash);
                                    }
                                    else
                                        MessageBox.Show(FILE_NOT_CHOOSED);
                                }
                                else
                                    MessageBox.Show(ErrorRE);
                                break;
                            }
                    }
                }
            }
            else
                MessageBox.Show(SignFirst);
        }
    }
}
