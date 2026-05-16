using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SetTurnFoodSwitchCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SetTurnFoodSwitchCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChxTZXRUdXJuRm9vZFN3aXRjaENzUmVxLnByb3RvGhRUdXJuRm9vZFN3aXRj" + "aC5wcm90byJTChZTZXRUdXJuRm9vZFN3aXRjaENzUmVxEiQKC0VERElPSE1O" + "Tk5CGAMgASgOMg8uVHVybkZvb2RTd2l0Y2gSEwoLQU1GTE5MR0JKR0wYBiAB" + "KAhCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[1] { TurnFoodSwitchReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SetTurnFoodSwitchCsReq), SetTurnFoodSwitchCsReq.Parser, new string[2] { "EDDIOHMNNNB", "AMFLNLGBJGL" }, null, null, null, null)
		}));
	}
}
