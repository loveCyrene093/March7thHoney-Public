using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SettleHipplenWorkScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SettleHipplenWorkScRspReflection()
	{
		InlineArray9<string> buffer = default(InlineArray9<string>);
		buffer[0] = "ChxTZXR0bGVIaXBwbGVuV29ya1NjUnNwLnByb3RvGhFER0tORE1BSE1BUC5w";
		buffer[1] = "cm90bxoRRUtPSUhPTUZNREUucHJvdG8aEUVPS09GRlBCSk1FLnByb3RvGhFJ";
		buffer[2] = "QU1MT0pDSUtJSC5wcm90bxoRT0VDUExEQUJBQkwucHJvdG8i6wEKFlNldHRs";
		buffer[3] = "ZUhpcHBsZW5Xb3JrU2NSc3ASIQoLTEpKQUpHRklHTk0YAyABKAsyDC5ER0tO";
		buffer[4] = "RE1BSE1BUBIhCgtHSFBJTkVMR05ORRgHIAMoCzIMLklBTUxPSkNJS0lIEiEK";
		buffer[5] = "C0NMS0FJTERDUEpDGAwgAygLMgwuRUtPSUhPTUZNREUSDwoHcmV0Y29kZRgP";
		buffer[6] = "IAEoDRIjCgtFREdPSUFPREpMSBgCIAEoCzIMLkVPS09GRlBCSk1FSAASIwoL";
		buffer[7] = "QkpHREZNSkRKTUgYDiABKAsyDC5PRUNQTERBQkFCTEgAQg0KC05QQkhKR0lF";
		buffer[8] = "REhMQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[5]
		{
			DGKNDMAHMAPReflection.Descriptor,
			EKOIHOMFMDEReflection.Descriptor,
			EOKOFFPBJMEReflection.Descriptor,
			IAMLOJCIKIHReflection.Descriptor,
			OECPLDABABLReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SettleHipplenWorkScRsp), SettleHipplenWorkScRsp.Parser, new string[6] { "LJJAJGFIGNM", "GHPINELGNNE", "CLKAILDCPJC", "Retcode", "EDGOIAODJLH", "BJGDFMJDJMH" }, new string[1] { "NPBHJGIEDHL" }, null, null, null)
		}));
	}
}
