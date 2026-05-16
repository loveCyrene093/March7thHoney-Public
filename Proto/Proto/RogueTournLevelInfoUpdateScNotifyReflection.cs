using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class RogueTournLevelInfoUpdateScNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static RogueTournLevelInfoUpdateScNotifyReflection()
	{
		InlineArray7<string> buffer = default(InlineArray7<string>);
		buffer[0] = "CidSb2d1ZVRvdXJuTGV2ZWxJbmZvVXBkYXRlU2NOb3RpZnkucHJvdG8aEUFQ";
		buffer[1] = "Qk9GQ1BKQ0FGLnByb3RvGhFCRVBMUEtFRkVFRC5wcm90bxobUm9ndWVUb3Vy";
		buffer[2] = "bkxldmVsU3RhdHVzLnByb3RvIqEBCiFSb2d1ZVRvdXJuTGV2ZWxJbmZvVXBk";
		buffer[3] = "YXRlU2NOb3RpZnkSIQoLRkhMSkVIREhKTEkYBiADKAsyDC5BUEJPRkNQSkNB";
		buffer[4] = "RhImCgZzdGF0dXMYByABKA4yFi5Sb2d1ZVRvdXJuTGV2ZWxTdGF0dXMSEwoL";
		buffer[5] = "QVBNSUFLRFBISkwYCyABKA0SHAoGcmVhc29uGA8gASgOMgwuQkVQTFBLRUZF";
		buffer[6] = "RURCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[3]
		{
			APBOFCPJCAFReflection.Descriptor,
			BEPLPKEFEEDReflection.Descriptor,
			RogueTournLevelStatusReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(RogueTournLevelInfoUpdateScNotify), RogueTournLevelInfoUpdateScNotify.Parser, new string[4] { "FHLJEHDHJLI", "Status", "APMIAKDPHJL", "Reason" }, null, null, null, null)
		}));
	}
}
