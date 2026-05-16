using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetHeartDialInfoScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetHeartDialInfoScRspReflection()
	{
		InlineArray9<string> buffer = default(InlineArray9<string>);
		buffer[0] = "ChtHZXRIZWFydERpYWxJbmZvU2NSc3AucHJvdG8aG0hlYXJ0RGlhbERpYWxv";
		buffer[1] = "Z3VlSW5mby5wcm90bxoZSGVhcnREaWFsU2NyaXB0SW5mby5wcm90bxobSGVh";
		buffer[2] = "cnREaWFsVW5sb2NrU3RhdHVzLnByb3RvGhFQSUNJTElJRktCRS5wcm90byLe";
		buffer[3] = "AQoVR2V0SGVhcnREaWFsSW5mb1NjUnNwEiEKC09PR0pBS0lQRkRKGAEgAygL";
		buffer[4] = "MgwuUElDSUxJSUZLQkUSLQoNdW5sb2NrX3N0YXR1cxgCIAEoDjIWLkhlYXJ0";
		buffer[5] = "RGlhbFVubG9ja1N0YXR1cxIuChBzY3JpcHRfaW5mb19saXN0GAMgAygLMhQu";
		buffer[6] = "SGVhcnREaWFsU2NyaXB0SW5mbxIPCgdyZXRjb2RlGAUgASgNEjIKEmRpYWxv";
		buffer[7] = "Z3VlX2luZm9fbGlzdBgIIAMoCzIWLkhlYXJ0RGlhbERpYWxvZ3VlSW5mb0IW";
		buffer[8] = "qgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[4]
		{
			HeartDialDialogueInfoReflection.Descriptor,
			HeartDialScriptInfoReflection.Descriptor,
			HeartDialUnlockStatusReflection.Descriptor,
			PICILIIFKBEReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetHeartDialInfoScRsp), GetHeartDialInfoScRsp.Parser, new string[5] { "OOGJAKIPFDJ", "UnlockStatus", "ScriptInfoList", "Retcode", "DialogueInfoList" }, null, null, null, null)
		}));
	}
}
