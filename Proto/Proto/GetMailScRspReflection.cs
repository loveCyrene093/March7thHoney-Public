using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetMailScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetMailScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChJHZXRNYWlsU2NSc3AucHJvdG8aEENsaWVudE1haWwucHJvdG8imAEKDEdl";
		buffer[1] = "dE1haWxTY1JzcBINCgVzdGFydBgBIAEoDRIeCgltYWlsX2xpc3QYByADKAsy";
		buffer[2] = "Cy5DbGllbnRNYWlsEhEKCXRvdGFsX251bRgIIAEoDRIOCgZpc19lbmQYCSAB";
		buffer[3] = "KAgSJQoQbm90aWNlX21haWxfbGlzdBgKIAMoCzILLkNsaWVudE1haWwSDwoH";
		buffer[4] = "cmV0Y29kZRgOIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { ClientMailReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetMailScRsp), GetMailScRsp.Parser, new string[6] { "Start", "MailList", "TotalNum", "IsEnd", "NoticeMailList", "Retcode" }, null, null, null, null)
		}));
	}
}
