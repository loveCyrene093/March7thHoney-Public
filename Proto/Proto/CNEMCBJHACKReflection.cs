using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CNEMCBJHACKReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CNEMCBJHACKReflection()
	{
		InlineArray13<string> buffer = default(InlineArray13<string>);
		buffer[0] = "ChFDTkVNQ0JKSEFDSy5wcm90bxoRQUVLSVBKTU1HREUucHJvdG8aEUhITkZD";
		buffer[1] = "Q0NISERELnByb3RvGhFMREFBUEhDSkVOTC5wcm90byKuAwoLQ05FTUNCSkhB";
		buffer[2] = "Q0sSGwoTbW9uc3Rlcl9iYXR0bGVfdHlwZRgBIAEoDRITCgtHSk9KTEVPQkpG";
		buffer[3] = "ShgCIAEoBBIQCghsZXZlbF9pZBgDIAEoDRITCgtJT0pLREdDRkNHRxgEIAEo";
		buffer[4] = "DRITCgtCQ0pNT0VNREdKSxgFIAEoDRITCgtMREdKTERBTkpKTBgGIAEoDRIT";
		buffer[5] = "CgtNSkNFREZKQUdFTxgHIAEoCBIhCgtJSUxETlBJTElDTRgIIAMoCzIMLkxE";
		buffer[6] = "QUFQSENKRU5MEgwKBHJhbmsYCSABKA0SIQoLTEpMREFMRFBORk0YCiADKAsy";
		buffer[7] = "DC5MREFBUEhDSkVOTBITCgtQQk1MRE9FQkRFRxgLIAEoDRIgCgpza2lsbF9p";
		buffer[8] = "bmZvGAwgAygLMgwuQUVLSVBKTU1HREUSIQoLT0pGTkFHRVBJTUUYDSADKAsy";
		buffer[9] = "DC5ISE5GQ0NDSEhERBIhCgtFTUdGUE9JR0VMRhgOIAMoCzIMLkxEQUFQSENK";
		buffer[10] = "RU5MEiEKC0lEQUFNRE5BT0pMGA8gAygLMgwuTERBQVBIQ0pFTkwSEwoLTElI";
		buffer[11] = "Q05LSEdCSU0YECABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3Rv";
		buffer[12] = "Mw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[3]
		{
			AEKIPJMMGDEReflection.Descriptor,
			HHNFCCCHHDDReflection.Descriptor,
			LDAAPHCJENLReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(CNEMCBJHACK), CNEMCBJHACK.Parser, new string[16]
			{
				"MonsterBattleType", "GJOJLEOBJFJ", "LevelId", "IOJKDGCFCGG", "BCJMOEMDGJK", "LDGJLDANJJL", "MJCEDFJAGEO", "IILDNPILICM", "Rank", "LJLDALDPNFM",
				"PBMLDOEBDEG", "SkillInfo", "OJFNAGEPIME", "EMGFPOIGELF", "IDAAMDNAOJL", "LIHCNKHGBIM"
			}, null, null, null, null)
		}));
	}
}
