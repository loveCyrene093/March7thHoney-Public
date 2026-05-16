using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CmdRechargeGiftTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CmdRechargeGiftTypeReflection()
	{
		InlineArray10<string> buffer = default(InlineArray10<string>);
		buffer[0] = "ChlDbWRSZWNoYXJnZUdpZnRUeXBlLnByb3RvKoMDChNDbWRSZWNoYXJnZUdp";
		buffer[1] = "ZnRUeXBlEhsKF0ZLS0RMS0pEUEFMX1BDUERIRUxQS0VNEAASJwoiQ21kU3lu";
		buffer[2] = "Y1JlY2hhcmdlQmVuZWZpdEluZm9TY05vdGlmeRC2QRImCiFDbWRUYWtlUmVj";
		buffer[3] = "aGFyZ2VCZW5lZml0UmV3YXJkQ3NSZXEQuUESIwoeQ21kVGFrZVJlY2hhcmdl";
		buffer[4] = "R2lmdFJld2FyZFNjUnNwELJBEiMKHkNtZEdldFJlY2hhcmdlQmVuZWZpdElu";
		buffer[5] = "Zm9TY1JzcBCwQRIgChtDbWRHZXRSZWNoYXJnZUdpZnRJbmZvU2NSc3AQvEES";
		buffer[6] = "IwoeQ21kR2V0UmVjaGFyZ2VCZW5lZml0SW5mb0NzUmVxELdBEiAKG0NtZEdl";
		buffer[7] = "dFJlY2hhcmdlR2lmdEluZm9Dc1JlcRCpQRImCiFDbWRUYWtlUmVjaGFyZ2VC";
		buffer[8] = "ZW5lZml0UmV3YXJkU2NSc3AQr0ESIwoeQ21kVGFrZVJlY2hhcmdlR2lmdFJl";
		buffer[9] = "d2FyZENzUmVxEKpBQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(CmdRechargeGiftType) }, null, null));
	}
}
