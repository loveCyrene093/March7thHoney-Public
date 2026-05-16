using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ClockParkBuffListReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ClockParkBuffListReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChdDbG9ja1BhcmtCdWZmTGlzdC5wcm90bxoRR09OTkdNS0RPRE0ucHJvdG8i" + "NAoRQ2xvY2tQYXJrQnVmZkxpc3QSHwoJYnVmZl9saXN0GAwgAygLMgwuR09O" + "TkdNS0RPRE1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[1] { GONNGMKDODMReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ClockParkBuffList), ClockParkBuffList.Parser, new string[1] { "BuffList" }, null, null, null, null)
		}));
	}
}
