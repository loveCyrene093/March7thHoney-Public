using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class InteractPropCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static InteractPropCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChdJbnRlcmFjdFByb3BDc1JlcS5wcm90byJWChFJbnRlcmFjdFByb3BDc1Jl" + "cRIWCg5wcm9wX2VudGl0eV9pZBgIIAEoDRITCgtpbnRlcmFjdF9pZBgKIAEo" + "BBIUCgxpbnRlcmFjdF9pZDIYDyABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJv" + "dG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(InteractPropCsReq), InteractPropCsReq.Parser, new string[3] { "PropEntityId", "InteractId", "InteractId2" }, null, null, null, null)
		}));
	}
}
