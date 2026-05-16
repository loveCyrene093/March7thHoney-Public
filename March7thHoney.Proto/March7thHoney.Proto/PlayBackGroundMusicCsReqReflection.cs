using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PlayBackGroundMusicCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PlayBackGroundMusicCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch5QbGF5QmFja0dyb3VuZE11c2ljQ3NSZXEucHJvdG8aEU1DUFBJRUpFQkVG" + "LnByb3RvIj0KGFBsYXlCYWNrR3JvdW5kTXVzaWNDc1JlcRIhCgtETUdDSURH" + "S1BGRhgKIAEoCzIMLk1DUFBJRUpFQkVGQhaqAhNNYXJjaDd0aEhvbmV5LlBy" + "b3RvYgZwcm90bzM="), new FileDescriptor[1] { MCPPIEJEBEFReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PlayBackGroundMusicCsReq), PlayBackGroundMusicCsReq.Parser, new string[1] { "DMGCIDGKPFF" }, null, null, null, null)
		}));
	}
}
