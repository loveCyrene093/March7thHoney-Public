using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MOEOOOMLGCGReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MOEOOOMLGCGReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "ChFNT0VPT09NTEdDRy5wcm90bxoRREZBR0tNRk9FTkIucHJvdG8aEUtDRkZP";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "SE1ESENLLnByb3RvImYKC01PRU9PT01MR0NHEiEKC0pQUEdGTEpIREhLGAEg";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "ASgLMgwuREZBR0tNRk9FTkISHAoGc291cmNlGAQgASgOMgwuS0NGRk9ITURI";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "Q0sSFgoOcXVldWVfcG9zaXRpb24YCiABKA1CFqoCE01hcmNoN3RoSG9uZXku";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "UHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[2]
		{
			DFAGKMFOENBReflection.Descriptor,
			KCFFOHMDHCKReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MOEOOOMLGCG), MOEOOOMLGCG.Parser, new string[3] { "JPPGFLJHDHK", "Source", "QueuePosition" }, null, null, null, null)
		}));
	}
}
