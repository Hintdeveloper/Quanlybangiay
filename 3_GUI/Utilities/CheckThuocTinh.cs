using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _3_GUI.Utilities
{
	public class CheckThuocTinh
	{
		public static bool IsValidEmail(string email)
		{
			if (string.IsNullOrWhiteSpace(email))
				return false;

			try
			{
				// Kiểm tra định dạng email bằng Regular Expression
				var match = Regex.Match(email,
				  @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$",
				  RegexOptions.IgnoreCase);

				return match.Success;
			}
			catch
			{
				return false;
			}
		}
		public static bool ValidatePhoneNumber(string phoneNumber)
		{
			string pattern = @"^(03|05|07|08|09)+([0-9]{8})\b";
			// Chú thích: ^: Bắt đầu chuỗi, (): Nhóm các điều kiện, \b: Kết thúc chuỗi
			// (03|05|07|08|09): Bắt đầu bằng các số điện thoại của các nhà mạng ở Việt Nam
			// ([0-9]{8}): Bao gồm 8 số
			Regex regex = new Regex(pattern);
			Match match = regex.Match(phoneNumber);
			return match.Success;
		}

		private static int counter = 0;
		public static string Generate(string str)
		{

			// Tách chuỗi thành mảng các từ
			string[] words = str.Split(' ');


			// Lấy ký tự đầu tiên của các từ sau từ cuối cùng
			string firstLettersAfterLast = "";
			for (int i = words.Length - 2; i > 0; i--)
			{
				if (words[i].Length > 0)
				{
					firstLettersAfterLast += words[i][0];
				}
			}

			// Lấy toàn bộ chữ cái của từ cuối cùng
			string lastWord = words[words.Length - 1];

			// Tạo chuỗi tự sinh
			counter++;
			string code = lastWord + firstLettersAfterLast + counter.ToString("");
			List<String> GenerateCode = new List<String>();
			while (GenerateCode.Contains(code))
			{
				code = lastWord + firstLettersAfterLast + counter.ToString("");
			}
			GenerateCode.Add(code);
			return code;
		}
	}
}
