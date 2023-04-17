using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Encrypt_Decrypt_File_Using_RSA_AES
{
    public partial class btn_browser : Form
    {
        public string EncryptedAes { get; set; }

        //AES - key size
        private int MinOfKeySizeAes = 128;
        private int MaxOfKeySizeAes = 256;
        //RSA - key size
        private int MinOfKeySizeRsa = 2048;
        private int MaxOfKeySizeRsa = 4096;
        public btn_browser()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int keySizeAes = MinOfKeySizeAes;
            do
            {
                cbb_KeySizeAes.Items.Add(keySizeAes.ToString());
                keySizeAes += 64;
            }
            while (keySizeAes <= MaxOfKeySizeAes);

            cbb_KeySizeAes.SelectedIndex = 0;

            int KeySizeRsa = MinOfKeySizeRsa;
            do
            {
                ccb_KeySizeRsa.Items.Add(KeySizeRsa.ToString());
                KeySizeRsa += 1024;
            } while (KeySizeRsa <= MaxOfKeySizeRsa);

            ccb_KeySizeRsa.SelectedIndex = 0;
        }
        private string GetKeyFromFile(string keyFileName)
        {
            StreamReader reader = new StreamReader(keyFileName);
            string key = "";
            key = reader.ReadToEnd();
            return key;
        }

        //AES
        private void btn_GenerateKeyAes_Click(object sender, EventArgs e)
        {
            AesCryptoServiceProvider aes = new AesCryptoServiceProvider();
            aes.GenerateKey();
            var key = Convert.ToBase64String(aes.Key);

            StreamWriter streamWriter = null;
            saveFileDialog1.Title = "Save Key AES";
            saveFileDialog1.FileName = "Key.aes";

            bool isKeySaved = false;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                streamWriter = new StreamWriter(saveFileDialog1.FileName);
                streamWriter.Write(key);
                streamWriter.Close();
                streamWriter.Dispose();
                isKeySaved = true;
            }
            else
            {
                isKeySaved = false;
            }
            String msg = "";
            if (isKeySaved)
            {
                msg += "Your Key has been saved!";
            }
            else
            {
                msg += "Your Key has NOT been saved!";
            }
            MessageBox.Show(msg);
        }
       
        private void btn_BrowerPlainFileAes_Click(object sender, EventArgs e)
        {
            var dlg = new OpenFileDialog();
            dlg.Title = "Select file";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txt_BrowerPlainFileAes.Text = dlg.FileName;
            }
        }

        private void btn_BrowserSecretKey_Click(object sender, EventArgs e)
        {
            var dlg = new OpenFileDialog();
            dlg.Title = "Select Secret Key file";
            dlg.Filter = "txt|*.txt|aes|*.aes";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txt_SecretKey.Text = dlg.FileName;
            }
        }

        private void btn_EncryptAes_Click(object sender, EventArgs e)
        {
            string key = GetKeyFromFile(txt_SecretKey.Text);
            FileEncryptAes(txt_BrowerPlainFileAes.Text, key);
        }

        private void FileEncryptAes(string inputFile, string key)
        {
            byte[] salt = new byte[32];

            FileStream fsCrypt = new FileStream(inputFile + ".aes", FileMode.Create);

            byte[] keyBytes = Encoding.UTF8.GetBytes(key);

            AesCryptoServiceProvider aes = new AesCryptoServiceProvider();
            int KeySize = int.Parse(cbb_KeySizeAes.SelectedItem.ToString());
            aes.KeySize = KeySize;
            aes.BlockSize = 128;
            aes.Padding = PaddingMode.PKCS7;
            var keyRfc = new Rfc2898DeriveBytes(keyBytes, salt, 50000);
            aes.Key = keyRfc.GetBytes(aes.KeySize / 8);
            aes.IV = keyRfc.GetBytes(aes.BlockSize / 8);

            aes.Mode = CipherMode.CBC;
            fsCrypt.Write(salt, 0, salt.Length);

            CryptoStream cs = new CryptoStream(fsCrypt, aes.CreateEncryptor(), CryptoStreamMode.Write);
            FileStream fsIn = new FileStream(inputFile, FileMode.Open);
            byte[] buffer = new byte[1024];
            int read;
            try
            {
                while ((read = fsIn.Read(buffer, 0, buffer.Length)) > 0)
                {
                    Application.DoEvents();
                    cs.Write(buffer, 0, read);
                }
                cs.Close();
                fsIn.Close();
                MessageBox.Show("Encrypt File Success!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }



        private void btn_DecryptAes_Click(object sender, EventArgs e)
        {
            string key = GetKeyFromFile(txt_SecretKey.Text);
            string outputFile = @"D:\Study\Ninja Team Training\Mr. Sinh\TestRSA_AES\AES_decryptionFile.bmp";
            FileDecryptAes(txt_BrowerPlainFileAes.Text, outputFile , key);
        }

        private void FileDecryptAes(string inputFile, string outputFile, string key)
        {
            byte[] keyBytes = Encoding.UTF8.GetBytes(key);
            byte[] salt = new byte[32];
            FileStream fsCrypt = new FileStream(inputFile, FileMode.Open);
            fsCrypt.Read(salt, 0, salt.Length);

            AesCryptoServiceProvider aes = new AesCryptoServiceProvider();
            int KeySize = int.Parse(cbb_KeySizeAes.SelectedItem.ToString());
            aes.KeySize = KeySize;
            aes.BlockSize = 128;
            var keyRfc = new Rfc2898DeriveBytes(keyBytes, salt, 50000);
            aes.Key = keyRfc.GetBytes(aes.KeySize / 8);
            aes.IV = keyRfc.GetBytes(aes.BlockSize / 8);
            aes.Padding = PaddingMode.PKCS7;
            aes.Mode = CipherMode.CBC;
            CryptoStream cs = new CryptoStream(fsCrypt, aes.CreateDecryptor(), CryptoStreamMode.Read);
            FileStream fsOut = new FileStream(outputFile, FileMode.Create);

            int read;
            byte[] buffer = new byte[1024];

            try
            {
                while ((read = cs.Read(buffer, 0, buffer.Length)) > 0)
                {
                    Application.DoEvents();
                    fsOut.Write(buffer, 0, read);
                }
                MessageBox.Show("Decrypt File Success!");
            }
            catch (CryptographicException ex_CryptographicException)
            {
                MessageBox.Show("CryptographicException error: " + ex_CryptographicException.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            try
            {
                cs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error by closing CryptoStream: " + ex.Message);
            }
            finally
            {
                fsOut.Close();
                fsCrypt.Close();
            }
        }

        //RSA
        private void btn_GenerateKeysRsa_Click(object sender, EventArgs e)
        {
            int keySize = int.Parse(ccb_KeySizeRsa.SelectedItem.ToString());
            RSACryptoServiceProvider rsaCrypto = new RSACryptoServiceProvider(keySize);

            String xmlPublicKey = rsaCrypto.ToXmlString(false);
            String xmlPrivateKey = rsaCrypto.ToXmlString(true);

            //convert from XML to Json
            var xmlDocumentPublicKey = XDocument.Parse(xmlPublicKey);

            var xmlDocumentPrivateKey = XDocument.Parse(xmlPrivateKey);

            string PublicKeyJson = JsonConvert.SerializeXNode(xmlDocumentPublicKey, Newtonsoft.Json.Formatting.Indented);
            string PrivateKeyJson = JsonConvert.SerializeXNode(xmlDocumentPrivateKey, Newtonsoft.Json.Formatting.Indented);

            // Save Keys
            StreamWriter privateKeyWriter = null;
            StreamWriter publicKeyWriter = null;

            saveFileDialog1.Title = "Save Private Key";
            saveFileDialog1.FileName = "PrivateKey.prk";

            bool isPrivateKeySaved = false;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                privateKeyWriter = new StreamWriter(saveFileDialog1.FileName);
                privateKeyWriter.Write(PrivateKeyJson);
                privateKeyWriter.Close();
                privateKeyWriter.Dispose();
                isPrivateKeySaved = true;
            }
            else
            {
                isPrivateKeySaved = false;
            }

            bool isPublicKeySaved = false;
            saveFileDialog1.Title = "Save Public Key";
            saveFileDialog1.FileName = "PublicKey.puk";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                publicKeyWriter = new StreamWriter(saveFileDialog1.FileName);
                publicKeyWriter.Write(PublicKeyJson);
                publicKeyWriter.Close();
                publicKeyWriter.Dispose();
                isPublicKeySaved = true;
            }
            else
            {
                isPublicKeySaved = false;
            }

            String msg = "";
            if (isPrivateKeySaved)
            {
                msg += "Your Private Key has been saved!";
            }
            else
            {
                msg += "Your Private Key has NOT been saved!";
            }
            if (isPublicKeySaved)
            {
                msg += "\n" + "Your Public Key has been saved!";
            }
            else
            {
                msg += "\n" + "Your Public Key has NOT been saved!";
            }
            MessageBox.Show(msg);
        }

        private void btn_BrowserPlainFileRsa_Click(object sender, EventArgs e)
        {
            var dlg = new OpenFileDialog();
            dlg.Title = "Select File";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txt_BrowserPlainFileRsa.Text = dlg.FileName;
            }
        }

        private void btn_BrowserPublicKey_Click(object sender, EventArgs e)
        {
            var dlg = new OpenFileDialog();
            dlg.Title = "Select public key file";
            dlg.Filter = "PUK Files (*.puk)|*.puk";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txt_BrowserPublicKey.Text = dlg.FileName;
            }
        }

        private void btn_BrowserPrivateKey_Click(object sender, EventArgs e)
        {
            var dlg = new OpenFileDialog();
            dlg.Title = "Select private key file";
            dlg.Filter = "PRK Files (*.prk)|*.prk";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txt_BrowserPrivateKey.Text = dlg.FileName;
            }
        }
        private void btn_EncryptRsa_Click(object sender, EventArgs e)
        {
            int keySize = int.Parse(ccb_KeySizeRsa.SelectedItem.ToString());
            RSACryptoServiceProvider rsaProvider = new RSACryptoServiceProvider(keySize);

            // Import public key and convert Json to XMl
            String jsonPublicKey = GetKeyFromFile(txt_BrowserPublicKey.Text);
            XNode xmlPublicKey = JsonConvert.DeserializeXNode(jsonPublicKey, "Root");
            string doc = xmlPublicKey.ToString();
            rsaProvider.FromXmlString(doc);

            // Get bytes data to encrypt
            byte[] toEncrypt = GetDataFromFileInByte(txt_BrowserPlainFileRsa.Text);

            // Encryption
            var encrypted = rsaProvider.Encrypt(toEncrypt, true);

            // Save encrypted data
            var str = Encoding.UTF8.GetString(encrypted);
            EncryptedAes = str;
            String outputFileName = txt_BrowserPlainFileRsa.Text +"EncrytedByRsa" + ".rsa";
            bool result = SaveOutputEncrypted(outputFileName, encrypted);

            if (result)
            {
                MessageBox.Show("Encryption process completed successful!");
            }
            else
            {
                MessageBox.Show("Encryption process fails!");
            }
        }
        private byte[] GetDataFromFileInByte(string sourcePath)
        {
            StreamReader reader = new StreamReader(sourcePath);
            String strData = reader.ReadToEnd();
            byte[] bytesData = Encoding.UTF8.GetBytes(strData);
            reader.Close();
            return bytesData;
        }
        private bool SaveOutputEncrypted(String outputFileName, byte[] encrypted)
        {
            try
            {
                FileStream fs = File.Open(outputFileName, FileMode.OpenOrCreate, FileAccess.Write);
                BinaryWriter br = new BinaryWriter(fs);
                br.Write(encrypted);

                br.Close();
                fs.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private void btn_DecryptRsa_Click(object sender, EventArgs e)
        {
            int keySize = int.Parse(ccb_KeySizeRsa.SelectedItem.ToString());
            RSACryptoServiceProvider rsaProvider = new RSACryptoServiceProvider(keySize);

            // Import private key and Convert Json to XML
            String jsonPublicKey = GetKeyFromFile(txt_BrowserPrivateKey.Text);
            XNode xmlPrivateKey = JsonConvert.DeserializeXNode(jsonPublicKey, "Root");
            string doc = xmlPrivateKey.ToString();
            rsaProvider.FromXmlString(doc);

            // Get bytes data to encrypt
            FileStream fs = File.OpenRead(txt_BrowserPlainFileRsa.Text);
            string encrytData = EncryptedAes.ToString();
            byte[] encrypted = Convert.FromBase64String(encrytData);
            //byte[] encrypted = new byte[fs.Length];
            //fs.Read(encrypted, 0, (int)fs.Length);

            // Decryption
            byte[] decrypted = rsaProvider.Decrypt(encrypted, true);

            // Save decrypted data

            String outputFileName = "";
            string[] strTemp = txt_BrowserPlainFileRsa.Text.Split('\\');
            for (int i = 0; i < strTemp.Length - 1; i++)
            {
                outputFileName += strTemp[i] + "\\";
            }
            outputFileName += Path.GetFileNameWithoutExtension(txt_BrowserPlainFileRsa.Text);
            string outputFileName_ = outputFileName + "DecryptedByRsa";

            bool result = SaveOutputDecrypted(outputFileName_, decrypted);

            if (result)
            {
                MessageBox.Show("Decryption process completed successful!");
            }
            else
            {
                MessageBox.Show("Decryption process fails!");
            }
        }
        private bool SaveOutputDecrypted(String outputFileName, byte[] Decrypted)
        {
            try
            {
                FileStream fs = File.Open(outputFileName + ".txt", FileMode.OpenOrCreate, FileAccess.Write);
                BinaryWriter br = new BinaryWriter(fs);
                br.Write(Decrypted);

                br.Close();
                fs.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private void txtPlainFileRsa(object sender, EventArgs e)
        {
            String fileName = txt_BrowserPlainFileRsa.Text;
            if (fileName != "")
            {
                String ext = Path.GetExtension(fileName);
                if (ext.Equals(".rsa"))
                {
                    btn_BrowserPrivateKey.Enabled = true;
                    btn_BrowserPublicKey.Enabled = false;
                    txt_BrowserPublicKey.Text = "";

                    btn_DecryptRsa.Enabled = true;
                    btn_EncryptRsa.Enabled = false;
                }
                else
                {
                    btn_BrowserPrivateKey.Enabled = false;
                    btn_BrowserPublicKey.Enabled = true;
                    txt_BrowserPrivateKey.Text = "";

                    btn_EncryptRsa.Enabled = true;
                    btn_DecryptRsa.Enabled = false;
                }
            }
            else
            {
                btn_BrowserPrivateKey.Enabled = false;
                btn_BrowserPublicKey.Enabled = false;
            }
        }
    }
}
