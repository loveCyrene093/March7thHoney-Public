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
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 0) = "CidSb2d1ZVRvdXJuTGV2ZWxJbmZvVXBkYXRlU2NOb3RpZnkucHJvdG8aEUFQ";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 1) = "Qk9GQ1BKQ0FGLnByb3RvGhFCRVBMUEtFRkVFRC5wcm90bxobUm9ndWVUb3Vy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 2) = "bkxldmVsU3RhdHVzLnByb3RvIqEBCiFSb2d1ZVRvdXJuTGV2ZWxJbmZvVXBk";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 3) = "YXRlU2NOb3RpZnkSIQoLRkhMSkVIREhKTEkYBiADKAsyDC5BUEJPRkNQSkNB";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 4) = "RhImCgZzdGF0dXMYByABKA4yFi5Sb2d1ZVRvdXJuTGV2ZWxTdGF0dXMSEwoL";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 5) = "QVBNSUFLRFBISkwYCyABKA0SHAoGcmVhc29uGA8gASgOMgwuQkVQTFBLRUZF";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 6) = "RURCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray7<string>, string>(in buffer, 7))), new FileDescriptor[3]
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
