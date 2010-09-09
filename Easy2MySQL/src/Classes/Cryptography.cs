
// Cryptography.cs
//
using System;
using System.IO;
using System.Text;
using System.Security.Cryptography;

namespace Easy2.src.Classes
{
	public class Cryptography
	{
		/// <summary>
		/// DES 복호화
		/// </summary>
		/// <param name="text">복호화 할 문자열</param>
		/// <returns>복호화 된 문자열</returns>
		public static string DesDecrypt(string text)
		{
			byte[] key = { 0x02, 0x00, 0x01, 0x00, 0x00, 0x03, 0x02, 0x06 };

			DESCryptoServiceProvider cryptoProvider = new DESCryptoServiceProvider();
			MemoryStream memoryStream = new MemoryStream(Convert.FromBase64String(text));
			CryptoStream cryptoStream = new CryptoStream(memoryStream, cryptoProvider.CreateDecryptor(key, key), CryptoStreamMode.Read);
			StreamReader reader = new StreamReader(cryptoStream);
			return reader.ReadToEnd();
		}

		/// <summary>
		/// DES 암호화
		/// </summary>
		/// <param name="text">암호화 할 문자열</param>
		/// <returns>암호화 된 문자열</returns>
		public static string DesEncrypt(string text)
		{
			byte[] key = { 0x02, 0x00, 0x01, 0x00, 0x00, 0x03, 0x02, 0x06 };

			DESCryptoServiceProvider cryptoProvider = new DESCryptoServiceProvider();
			MemoryStream memoryStream = new MemoryStream();
			CryptoStream cryptoStream = new CryptoStream(memoryStream, cryptoProvider.CreateEncryptor(key, key), CryptoStreamMode.Write);
			StreamWriter writer = new StreamWriter(cryptoStream);
			writer.Write(text);
			writer.Flush();
			cryptoStream.FlushFinalBlock();
			return Convert.ToBase64String(memoryStream.GetBuffer(), 0, (int)memoryStream.Length);
		}
	}
}
