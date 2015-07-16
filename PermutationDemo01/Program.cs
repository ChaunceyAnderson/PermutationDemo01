﻿using System;

namespace PermutationExample {
	public class Program {
		private static void Swap(ref char a, ref char b) {
			if (a == b) return;

			a ^= b;
			b ^= a;
			a ^= b;
		}

		public static void GetPer(char[] list) {
			int x = list.Length - 1;
			GetPer(list, 0, x);
		}

		private static void GetPer(char[] list, int k, int m) {
			if (k == m) {
				//Console.Write(list);
				Console.WriteLine(list);

			} else
				for (int i = k; i <= m; i++) {
					Swap(ref list[k], ref list[i]);
					GetPer(list, k + 1, m);
					Swap(ref list[k], ref list[i]);
				}
		}

		static void Main() {
			string str = "aargen";
			char[] arr = str.ToCharArray();
			GetPer(arr);
			Console.WriteLine(Environment.NewLine);
			Console.WriteLine("Main method complete. Press Enter");
			Console.ReadLine();

		}
	}
}
