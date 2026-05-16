using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetMuseumInfoScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetMuseumInfoScRspReflection()
	{
		InlineArray11<string> buffer = default(InlineArray11<string>);
		buffer[0] = "ChhHZXRNdXNldW1JbmZvU2NSc3AucHJvdG8aEURCSFBOTEhQQ01ELnByb3Rv";
		buffer[1] = "GhFGS01LSUdGSk9ERi5wcm90bxoRRk9LT1BFQ0ZDT1AucHJvdG8aEUtOTk9E";
		buffer[2] = "QVBBS0pBLnByb3RvItsCChJHZXRNdXNldW1JbmZvU2NSc3ASEwoLQ0tEQUNI";
		buffer[3] = "UEpMSkQYASADKA0SEAoIY3VyX2Z1bmQYAyABKA0SDwoHcmV0Y29kZRgEIAEo";
		buffer[4] = "DRILCgNleHAYBSABKA0SEwoLQUFPS0ZGR05CTkUYBiADKA0SEwoLQUJJSkhL";
		buffer[5] = "TkJHSEoYByABKA0SIQoLQk9EQVBPTEZBREYYCCADKAsyDC5GS01LSUdGSk9E";
		buffer[6] = "RhIhCgtHUEVBRkFKR0NQSBgJIAEoCzIMLkRCSFBOTEhQQ01EEhMKC05PR0FC";
		buffer[7] = "REtNQUdCGAogASgNEiEKC09LTUdITkNHUE9MGAsgASgLMgwuS05OT0RBUEFL";
		buffer[8] = "SkESEwoLREpGTEhGTUpQQ0QYDCABKA0SEwoLQU5CRUhDSU5GTEQYDSABKA0S";
		buffer[9] = "HwoJYXJlYV9saXN0GA4gAygLMgwuRk9LT1BFQ0ZDT1ASDQoFbGV2ZWwYDyAB";
		buffer[10] = "KA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[4]
		{
			DBHPNLHPCMDReflection.Descriptor,
			FKMKIGFJODFReflection.Descriptor,
			FOKOPECFCOPReflection.Descriptor,
			KNNODAPAKJAReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetMuseumInfoScRsp), GetMuseumInfoScRsp.Parser, new string[14]
			{
				"CKDACHPJLJD", "CurFund", "Retcode", "Exp", "AAOKFFGNBNE", "ABIJHKNBGHJ", "BODAPOLFADF", "GPEAFAJGCPH", "NOGABDKMAGB", "OKMGHNCGPOL",
				"DJFLHFMJPCD", "ANBEHCINFLD", "AreaList", "Level"
			}, null, null, null, null)
		}));
	}
}
