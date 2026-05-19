using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;

namespace System.Text.RegularExpressions.Generated;

[GeneratedCode("System.Text.RegularExpressions.Generator", "10.0.14.23019")]
internal sealed class _003CRegexGenerator_g_003EF83F232A2D60531CA35B58C50035788F84F789613092FA791BC8525ADBE96BC0F__RegexConfig_0 : Regex
{
	private sealed class RunnerFactory : RegexRunnerFactory
	{
		private sealed class Runner : RegexRunner
		{
			protected override void Scan(ReadOnlySpan<char> inputSpan)
			{
				while (!TryMatchAtCurrentPosition(inputSpan) && runtextpos != inputSpan.Length)
				{
					runtextpos++;
					if (_003CRegexGenerator_g_003EF83F232A2D60531CA35B58C50035788F84F789613092FA791BC8525ADBE96BC0F__Utilities.s_hasTimeout)
					{
						CheckTimeout();
					}
				}
			}

			private bool TryMatchAtCurrentPosition(ReadOnlySpan<char> inputSpan)
			{
				int num = runtextpos;
				int start = num;
				int num2 = 0;
				int num3 = 0;
				int num4 = 0;
				ReadOnlySpan<char> readOnlySpan = inputSpan.Slice(num);
				readOnlySpan = inputSpan.Slice(num);
				int num5 = num;
				if (_003CRegexGenerator_g_003EF83F232A2D60531CA35B58C50035788F84F789613092FA791BC8525ADBE96BC0F__Utilities.s_hasTimeout)
				{
					CheckTimeout();
				}
				if ((uint)(num - 23) >= inputSpan.Length)
				{
					UncaptureUntil(0);
					return false;
				}
				for (int i = 0; i < 23; i++)
				{
					if (inputSpan[--num] != "Avatar_RogueBattleevent"[22 - i])
					{
						UncaptureUntil(0);
						return false;
					}
				}
				num = num5;
				readOnlySpan = inputSpan.Slice(num);
				num2 = num;
				num4 = num;
				int num6;
				while (true)
				{
					num3 = Crawlpos();
					Capture(1, num2, num);
					readOnlySpan = inputSpan.Slice(num);
					num6 = num;
					if (_003CRegexGenerator_g_003EF83F232A2D60531CA35B58C50035788F84F789613092FA791BC8525ADBE96BC0F__Utilities.s_hasTimeout)
					{
						CheckTimeout();
					}
					if ((uint)readOnlySpan.Length >= 12u && readOnlySpan.StartsWith("_Config".AsSpan()) && readOnlySpan[7] != '\n' && readOnlySpan.Slice(8).StartsWith("json".AsSpan()))
					{
						break;
					}
					UncaptureUntil(num3);
					if (_003CRegexGenerator_g_003EF83F232A2D60531CA35B58C50035788F84F789613092FA791BC8525ADBE96BC0F__Utilities.s_hasTimeout)
					{
						CheckTimeout();
					}
					num = num4;
					readOnlySpan = inputSpan.Slice(num);
					if (readOnlySpan.IsEmpty || readOnlySpan[0] == '\n')
					{
						UncaptureUntil(0);
						return false;
					}
					num++;
					readOnlySpan = inputSpan.Slice(num);
					num4 = readOnlySpan.IndexOfAny('\n', '_');
					if ((uint)num4 >= (uint)readOnlySpan.Length || readOnlySpan[num4] == '\n')
					{
						UncaptureUntil(0);
						return false;
					}
					num += num4;
					readOnlySpan = inputSpan.Slice(num);
					num4 = num;
				}
				num = num6;
				readOnlySpan = inputSpan.Slice(num);
				runtextpos = num;
				Capture(0, start, num);
				return true;
				[MethodImpl(MethodImplOptions.AggressiveInlining)]
				void UncaptureUntil(int capturePosition)
				{
					while (Crawlpos() > capturePosition)
					{
						Uncapture();
					}
				}
			}
		}

		protected override RegexRunner CreateInstance()
		{
			return new Runner();
		}
	}

	internal static readonly _003CRegexGenerator_g_003EF83F232A2D60531CA35B58C50035788F84F789613092FA791BC8525ADBE96BC0F__RegexConfig_0 Instance = new _003CRegexGenerator_g_003EF83F232A2D60531CA35B58C50035788F84F789613092FA791BC8525ADBE96BC0F__RegexConfig_0();

	private _003CRegexGenerator_g_003EF83F232A2D60531CA35B58C50035788F84F789613092FA791BC8525ADBE96BC0F__RegexConfig_0()
	{
		pattern = "(?<=Avatar_RogueBattleevent)(.*?)(?=_Config.json)";
		roptions = RegexOptions.None;
		Regex.ValidateMatchTimeout(_003CRegexGenerator_g_003EF83F232A2D60531CA35B58C50035788F84F789613092FA791BC8525ADBE96BC0F__Utilities.s_defaultTimeout);
		internalMatchTimeout = _003CRegexGenerator_g_003EF83F232A2D60531CA35B58C50035788F84F789613092FA791BC8525ADBE96BC0F__Utilities.s_defaultTimeout;
		factory = new RunnerFactory();
		capsize = 2;
	}
}
