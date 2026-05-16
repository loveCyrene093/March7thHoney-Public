using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PHOCECJOBHHReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PHOCECJOBHHReflection()
	{
		InlineArray7<string> buffer = default(InlineArray7<string>);
		buffer[0] = "ChFQSE9DRUNKT0JISC5wcm90bxoRR0xNQkpKT0ZQQUMucHJvdG8i0AEKC1BI";
		buffer[1] = "T0NFQ0pPQkhIEgsKA3VpZBgBIAEoDRITCgtEQUVDS0ZHQUtMRhgCIAEoDRIT";
		buffer[2] = "CgtPQU9KQUVQSkZGTxgDIAEoCBITCgtHQ01OQURBS09OShgEIAEoDRITCgty";
		buffer[3] = "ZXBsYXlfbmFtZRgFIAEoCRIhCgthdmF0YXJfbGlzdBgGIAMoCzIMLkdMTUJK";
		buffer[4] = "Sk9GUEFDEhMKC0dHSENGTU9MRE5JGAcgASgNEhMKC1BEQk5HTkFCREpJGAgg";
		buffer[5] = "ASgNEhMKC01IREpKRE5ISUxLGAkgASgNQhaqAhNNYXJjaDd0aEhvbmV5LlBy";
		buffer[6] = "b3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { GLMBJJOFPACReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PHOCECJOBHH), PHOCECJOBHH.Parser, new string[9] { "Uid", "DAECKFGAKLF", "OAOJAEPJFFO", "GCMNADAKONJ", "ReplayName", "AvatarList", "GGHCFMOLDNI", "PDBNGNABDJI", "MHDJJDNHILK" }, null, null, null, null)
		}));
	}
}
