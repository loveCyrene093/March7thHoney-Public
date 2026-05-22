using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ElfRestaurantPlantSeedScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ElfRestaurantPlantSeedScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "CiFFbGZSZXN0YXVyYW50UGxhbnRTZWVkU2NSc3AucHJvdG8aEUdLUFBESkVG";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "QlBBLnByb3RvGhFLRUhHUEhEQk9CRC5wcm90byJ0ChtFbGZSZXN0YXVyYW50";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "UGxhbnRTZWVkU2NSc3ASIQoLTUlNRk1JSUNER0wYASADKAsyDC5LRUhHUEhE";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "Qk9CRBIPCgdyZXRjb2RlGAMgASgNEiEKC0hOSkZMRlBMSU5JGAsgAygLMgwu";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "R0tQUERKRUZCUEFCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[2]
		{
			GKPPDJEFBPAReflection.Descriptor,
			KEHGPHDBOBDReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ElfRestaurantPlantSeedScRsp), ElfRestaurantPlantSeedScRsp.Parser, new string[3] { "MIMFMIICDGL", "Retcode", "HNJFLFPLINI" }, null, null, null, null)
		}));
	}
}
