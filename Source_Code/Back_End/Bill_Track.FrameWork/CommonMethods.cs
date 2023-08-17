
using Bill_Track.FrameWork.Helper;
using Newtonsoft.Json;
using System.Security.Cryptography;
using System.Text;

namespace Bill_Track.FrameWork
{
	public static class CommonMethods
	{
		public static string EncryptionKey = "CMCKEY";

		public static string EncryptValue(string sEncryptionData)
		{
			string sEncryptionValue = string.Empty;
			try
			{
				byte[] clearBytes = Encoding.Unicode.GetBytes(sEncryptionData);
				using (Aes encryptor = Aes.Create())
				{
					// encryptor.Padding = PaddingMode.None;
					Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });

					// encryptor.Key = pdb.GetBytes(24);
					encryptor.Key = pdb.GetBytes(32);
					encryptor.IV = pdb.GetBytes(16);
					using (MemoryStream ms = new MemoryStream())
					{
						using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
						{
							cs.Write(clearBytes, 0, clearBytes.Length);
							cs.Close();
						}
						sEncryptionValue = Convert.ToBase64String(ms.ToArray());
						sEncryptionValue = sEncryptionValue.Replace("/", "♥");
					}
				}
			}
			catch (Exception Ex)
			{
				new ErrorLog().WriteLog(Ex);
			}
			return sEncryptionValue;
		}

		/// <summary>
		/// accepts an encrypted string and returns the string as plain text
		/// </summary>
		/// <param name="Msg"></param>
		/// <returns></returns>
		/// <remarks></remarks>
		public static string DecryptValue(string cipherText)
		{
			string sDecrpytText = "";
			try
			{
				if (cipherText != null && EncryptionKey != "" && cipherText != "")
				{
					cipherText = cipherText.Replace("♥", "/");

					cipherText = cipherText.Replace(" ", "+");// Replace the Empty string with. Becase FromBase64String won't accept the Empty string
					byte[] cipherBytes = Convert.FromBase64String(cipherText);
					using (Aes encryptor = Aes.Create())
					{
						// encryptor.Padding = PaddingMode.Zeros;
						Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
						//encryptor.Key = pdb.GetBytes(24);
						encryptor.Key = pdb.GetBytes(32);
						encryptor.IV = pdb.GetBytes(16);
						using (MemoryStream ms = new MemoryStream())
						{
							using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
							{
								cs.Write(cipherBytes, 0, cipherBytes.Length);
								cs.Close();
							}
							sDecrpytText = Encoding.Unicode.GetString(ms.ToArray());
						}
					}
				}
			}
			catch (Exception Ex)
			{
				new ErrorLog().WriteLog(Ex);
			}
			return sDecrpytText;
		}

		/// <summary>
		/// Serializes the object.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="objectValue">The object value.</param>
		/// <returns></returns>
		public static string SerializeObject<T>(T objectValue)
		{
			return JsonConvert.SerializeObject(objectValue);
		}

		/// <summary>
		/// Deserializes the string to intended object.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="objectValue">The object value.</param>
		/// <returns>Serialized target object</returns>
		public static T DeserializeObject<T>(string objectValue)
		{
			return JsonConvert.DeserializeObject<T>(objectValue);
		}

		public static string ReadFile(string path)
		{
			string fileData = string.Empty;
			try
			{
				if (File.Exists(path))
				{
					fileData = File.ReadAllText(path);
				}
			}
			catch (Exception ex)
			{
			}

			return fileData;
		}
	}
}