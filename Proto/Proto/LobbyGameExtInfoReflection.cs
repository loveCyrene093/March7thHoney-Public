using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class LobbyGameExtInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static LobbyGameExtInfoReflection()
	{
		InlineArray11<string> buffer = default(InlineArray11<string>);
		buffer[0] = "ChZMb2JieUdhbWVFeHRJbmZvLnByb3RvGhFHQ0pBTUhFR0tHRS5wcm90bxoY";
		buffer[1] = "TG9iYnlHcmlkRmlnaHRJbmZvLnByb3RvGhVMb2JieU1hcmJsZUluZm8ucHJv";
		buffer[2] = "dG8aFExvYmJ5TWFyY2hJbmZvLnByb3RvGhFPSUZKSEVQQUZPTy5wcm90byKs";
		buffer[3] = "AgoQTG9iYnlHYW1lRXh0SW5mbxITCgtCSElMRVBHSUZORRgBIAMoCRITCgtI";
		buffer[4] = "TVBDRkpQSkRPRRgCIAEoCBIsChBsb2JieV9tYXJjaF9pbmZvGOkHIAEoCzIP";
		buffer[5] = "LkxvYmJ5TWFyY2hJbmZvSAASLgoRbG9iYnlfbWFyYmxlX2luZm8Y6gcgASgL";
		buffer[6] = "MhAuTG9iYnlNYXJibGVJbmZvSAASJAoLTklGQktLTkZLRUcY6wcgASgLMgwu";
		buffer[7] = "T0lGSkhFUEFGT09IABI1ChVsb2JieV9ncmlkX2ZpZ2h0X2luZm8Y7AcgASgL";
		buffer[8] = "MhMuTG9iYnlHcmlkRmlnaHRJbmZvSAASJAoLUENGTkpKQ09KRUQY7QcgASgL";
		buffer[9] = "MgwuR0NKQU1IRUdLR0VIAEINCgtKTkpKSkdCQ0VER0IWqgITTWFyY2g3dGhI";
		buffer[10] = "b25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[5]
		{
			GCJAMHEGKGEReflection.Descriptor,
			LobbyGridFightInfoReflection.Descriptor,
			LobbyMarbleInfoReflection.Descriptor,
			LobbyMarchInfoReflection.Descriptor,
			OIFJHEPAFOOReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(LobbyGameExtInfo), LobbyGameExtInfo.Parser, new string[7] { "BHILEPGIFNE", "HMPCFJPJDOE", "LobbyMarchInfo", "LobbyMarbleInfo", "NIFBKKNFKEG", "LobbyGridFightInfo", "PCFNJJCOJED" }, new string[1] { "JNJJJGBCEDG" }, null, null, null)
		}));
	}
}
