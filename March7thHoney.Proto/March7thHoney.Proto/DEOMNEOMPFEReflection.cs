using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DEOMNEOMPFEReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DEOMNEOMPFEReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFERU9NTkVPTVBGRS5wcm90byJaCgtERU9NTkVPTVBGRRITCgtOSktFT0dO" + "SEVOSxgEIAEoDRINCgVsZXZlbBgFIAEoDRISCgppc19wZXJmZWN0GAggASgI" + "EhMKC0lMSERCSE1BQU1PGAwgASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3Rv" + "YgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(DEOMNEOMPFE), DEOMNEOMPFE.Parser, new string[4] { "NJKEOGNHENK", "Level", "IsPerfect", "ILHDBHMAAMO" }, null, null, null, null)
		}));
	}
}
