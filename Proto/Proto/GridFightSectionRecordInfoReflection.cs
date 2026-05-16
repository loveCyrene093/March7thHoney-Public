using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GridFightSectionRecordInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GridFightSectionRecordInfoReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "CiBHcmlkRmlnaHRTZWN0aW9uUmVjb3JkSW5mby5wcm90bxokR3JpZEZpZ2h0";
		buffer[1] = "U2VjdGlvbkNhbXBSZWNvcmRJbmZvLnByb3RvIpYBChpHcmlkRmlnaHRTZWN0";
		buffer[2] = "aW9uUmVjb3JkSW5mbxITCgtCTkxISU1IRkdESxgDIAEoDRISCgpzZWN0aW9u";
		buffer[3] = "X2lkGAogASgNEhMKC0RDUEtQTkxLR01NGAwgASgNEjoKEGNhbXBfcmVjb3Jk";
		buffer[4] = "X2luZm8YnAMgASgLMh8uR3JpZEZpZ2h0U2VjdGlvbkNhbXBSZWNvcmRJbmZv";
		buffer[5] = "QhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { GridFightSectionCampRecordInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GridFightSectionRecordInfo), GridFightSectionRecordInfo.Parser, new string[4] { "BNLHIMHFGDK", "SectionId", "DCPKPNLKGMM", "CampRecordInfo" }, null, null, null, null)
		}));
	}
}
