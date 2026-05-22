using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class LobbyInteractTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static LobbyInteractTypeReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChdMb2JieUludGVyYWN0VHlwZS5wcm90bypNChFMb2JieUludGVyYWN0VHlw" + "ZRIbChdKQlBER0RHQUVLTF9QQ1BESEVMUEtFTRAAEhsKF0pCUERHREdBRUtM" + "X0JFTEpIS0lPSUtCEAFCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3Rv" + "Mw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(LobbyInteractType) }, null, null));
	}
}
