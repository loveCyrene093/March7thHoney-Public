using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ModifyAvatarDiceRsp : IMessage<ModifyAvatarDiceRsp>, IMessage, IEquatable<ModifyAvatarDiceRsp>, IDeepCloneable<ModifyAvatarDiceRsp>, IBufferMessage
{
	private static readonly MessageParser<ModifyAvatarDiceRsp> _parser = new MessageParser<ModifyAvatarDiceRsp>(() => new ModifyAvatarDiceRsp());

	private UnknownFieldSet _unknownFields;

	public const int RetcodeFieldNumber = 1;

	private uint retcode_;

	public const int OJCBGGOEEIEFieldNumber = 12;

	private DiceCombatAvatar oJCBGGOEEIE_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ModifyAvatarDiceRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ModifyAvatarDiceRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Retcode
	{
		get
		{
			return retcode_;
		}
		set
		{
			retcode_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DiceCombatAvatar OJCBGGOEEIE
	{
		get
		{
			return oJCBGGOEEIE_;
		}
		set
		{
			oJCBGGOEEIE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ModifyAvatarDiceRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ModifyAvatarDiceRsp(ModifyAvatarDiceRsp other)
		: this()
	{
		retcode_ = other.retcode_;
		oJCBGGOEEIE_ = ((other.oJCBGGOEEIE_ != null) ? other.oJCBGGOEEIE_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ModifyAvatarDiceRsp Clone()
	{
		return new ModifyAvatarDiceRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ModifyAvatarDiceRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ModifyAvatarDiceRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (!object.Equals(OJCBGGOEEIE, other.OJCBGGOEEIE))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		int num = 1;
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (oJCBGGOEEIE_ != null)
		{
			num ^= OJCBGGOEEIE.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return JsonFormatter.ToDiagnosticString(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
		output.WriteRawMessage(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	void IBufferMessage.InternalWriteTo(ref WriteContext output)
	{
		if (Retcode != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(Retcode);
		}
		if (oJCBGGOEEIE_ != null)
		{
			output.WriteRawTag(98);
			output.WriteMessage(OJCBGGOEEIE);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(ref output);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		int num = 0;
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (oJCBGGOEEIE_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(OJCBGGOEEIE);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ModifyAvatarDiceRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
		}
		if (other.oJCBGGOEEIE_ != null)
		{
			if (oJCBGGOEEIE_ == null)
			{
				OJCBGGOEEIE = new DiceCombatAvatar();
			}
			OJCBGGOEEIE.MergeFrom(other.OJCBGGOEEIE);
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
		input.ReadRawMessage(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	void IBufferMessage.InternalMergeFrom(ref ParseContext input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0 && (num & 7) != 4)
		{
			switch (num)
			{
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 8u:
				Retcode = input.ReadUInt32();
				break;
			case 98u:
				if (oJCBGGOEEIE_ == null)
				{
					OJCBGGOEEIE = new DiceCombatAvatar();
				}
				input.ReadMessage(OJCBGGOEEIE);
				break;
			}
		}
	}
}
