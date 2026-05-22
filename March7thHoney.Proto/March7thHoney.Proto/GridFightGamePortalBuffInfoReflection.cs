using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GridFightGamePortalBuffInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GridFightGamePortalBuffInfoReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiFHcmlkRmlnaHRHYW1lUG9ydGFsQnVmZkluZm8ucHJvdG8iSgobR3JpZEZp" + "Z2h0R2FtZVBvcnRhbEJ1ZmZJbmZvEhYKDnBvcnRhbF9idWZmX2lkGAcgASgN" + "EhMKC1BFT0ZQUE9GSUdJGAkgAygNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3Rv" + "YgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GridFightGamePortalBuffInfo), GridFightGamePortalBuffInfo.Parser, new string[2] { "PortalBuffId", "PEOFPPOFIGI" }, null, null, null, null)
		}));
	}
}
