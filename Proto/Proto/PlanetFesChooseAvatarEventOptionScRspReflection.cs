using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PlanetFesChooseAvatarEventOptionScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PlanetFesChooseAvatarEventOptionScRspReflection()
	{
		InlineArray7<string> buffer = default(InlineArray7<string>);
		buffer[0] = "CitQbGFuZXRGZXNDaG9vc2VBdmF0YXJFdmVudE9wdGlvblNjUnNwLnByb3Rv";
		buffer[1] = "GhFITExDREJMQ0lQSy5wcm90bxoRSklQQUNERUpLSkMucHJvdG8iuAEKJVBs";
		buffer[2] = "YW5ldEZlc0Nob29zZUF2YXRhckV2ZW50T3B0aW9uU2NSc3ASIQoLRElIRUNJ";
		buffer[3] = "SUtFTEUYBSABKAsyDC5KSVBBQ0RFSktKQxITCgtFRU1OREdJUEJJQxgGIAEo";
		buffer[4] = "DRIcCgZyZXdhcmQYCCABKAsyDC5ITExDREJMQ0lQSxIPCgdyZXRjb2RlGAsg";
		buffer[5] = "ASgNEhMKC0FBSUpLSUJPTk9PGA4gASgNEhMKC0NPS0dPUEJNTFBQGA8gASgN";
		buffer[6] = "QhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			HLLCDBLCIPKReflection.Descriptor,
			JIPACDEJKJCReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PlanetFesChooseAvatarEventOptionScRsp), PlanetFesChooseAvatarEventOptionScRsp.Parser, new string[6] { "DIHECIIKELE", "EEMNDGIPBIC", "Reward", "Retcode", "AAIJKIBONOO", "COKGOPBMLPP" }, null, null, null, null)
		}));
	}
}
