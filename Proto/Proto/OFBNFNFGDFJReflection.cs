using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class OFBNFNFGDFJReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static OFBNFNFGDFJReflection()
	{
		InlineArray9<string> buffer = default(InlineArray9<string>);
		buffer[0] = "ChFPRkJORk5GR0RGSi5wcm90bxoRQ0FES0JPS0VKTUQucHJvdG8aEURFQ0FP";
		buffer[1] = "SE9OTkpHLnByb3RvGhFSb2d1ZVN0YXR1cy5wcm90byKEAgoLT0ZCTkZORkdE";
		buffer[2] = "RkoSEwoLSURGRUxOTUJEQkoYASABKA0SEwoLREdQRkdBREVCTUQYBiABKA0S";
		buffer[3] = "EwoLUEdJTkxPRktDTUQYCCABKA0SIQoLT0ZPT0RPQkpLQkoYCSABKAsyDC5D";
		buffer[4] = "QURLQk9LRUpNRBIOCgZtYXBfaWQYCiABKA0SJQoddW5maW5pc2hlZF9zdG9y";
		buffer[5] = "eV9saW5lX2lkX2xpc3QYDCADKA0SIQoLRFBDQk1KR0JNR1AYDSABKAsyDC5E";
		buffer[6] = "RUNBT0hPTk5KRxIcCgZzdGF0dXMYDiABKA4yDC5Sb2d1ZVN0YXR1cxIbChNi";
		buffer[7] = "YXNlX2F2YXRhcl9pZF9saXN0GA8gAygNQhaqAhNNYXJjaDd0aEhvbmV5LlBy";
		buffer[8] = "b3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[3]
		{
			CADKBOKEJMDReflection.Descriptor,
			DECAOHONNJGReflection.Descriptor,
			RogueStatusReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(OFBNFNFGDFJ), OFBNFNFGDFJ.Parser, new string[9] { "IDFELNMBDBJ", "DGPFGADEBMD", "PGINLOFKCMD", "OFOODOBJKBJ", "MapId", "UnfinishedStoryLineIdList", "DPCBMJGBMGP", "Status", "BaseAvatarIdList" }, null, null, null, null)
		}));
	}
}
