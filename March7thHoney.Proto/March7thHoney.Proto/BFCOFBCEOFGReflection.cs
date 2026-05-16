using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class BFCOFBCEOFGReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static BFCOFBCEOFGReflection()
	{
		InlineArray8<string> buffer = default(InlineArray8<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 0) = "ChFCRkNPRkJDRU9GRy5wcm90byqSAgoLQkZDT0ZCQ0VPRkcSGwoXQkZDT0ZC";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 1) = "Q0VPRkdfT0hGS05ORUxCQ0IQABIbChdCRkNPRkJDRU9GR19DRk1DQ0xKQkhL";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 2) = "UBABEhsKF0JGQ09GQkNFT0ZHX09CQ0tOT0ROTUJOEAISGwoXQkZDT0ZCQ0VP";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 3) = "RkdfTU1HRU9ES0pNR0MQAxIbChdCRkNPRkJDRU9GR19HQ0ZOSk1CRUhNSRAE";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 4) = "EhsKF0JGQ09GQkNFT0ZHX05IREhJSUdESkJOEAUSGwoXQkZDT0ZCQ0VPRkdf";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 5) = "QkxFQkdDRU1DQ0EQBhIbChdCRkNPRkJDRU9GR19HSkNKUEZKRkZERhAHEhsK";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 6) = "F0JGQ09GQkNFT0ZHX05GSUNBTUVHS0JFEAhCFqoCE01hcmNoN3RoSG9uZXku";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 7) = "UHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray8<string>, string>(in buffer, 8))), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(BFCOFBCEOFG) }, null, null));
	}
}
