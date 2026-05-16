using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class SetAvatarEnhancedIdScRsp : IMessage<SetAvatarEnhancedIdScRsp>, IMessage, IEquatable<SetAvatarEnhancedIdScRsp>, IDeepCloneable<SetAvatarEnhancedIdScRsp>, IBufferMessage
{
	private static readonly MessageParser<SetAvatarEnhancedIdScRsp> _parser = new MessageParser<SetAvatarEnhancedIdScRsp>(() => new SetAvatarEnhancedIdScRsp());

	private UnknownFieldSet _unknownFields;

	public const int GrowthAvatarIdFieldNumber = 5;

	private uint growthAvatarId_;

	public const int RetcodeFieldNumber = 6;

	private uint retcode_;

	public const int UnkEnhancedIdFieldNumber = 11;

	private uint unkEnhancedId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SetAvatarEnhancedIdScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => SetAvatarEnhancedIdScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GrowthAvatarId
	{
		get
		{
			return growthAvatarId_;
		}
		set
		{
			growthAvatarId_ = value;
		}
	}

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
	public uint UnkEnhancedId
	{
		get
		{
			return unkEnhancedId_;
		}
		set
		{
			unkEnhancedId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SetAvatarEnhancedIdScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SetAvatarEnhancedIdScRsp(SetAvatarEnhancedIdScRsp other)
		: this()
	{
		growthAvatarId_ = other.growthAvatarId_;
		retcode_ = other.retcode_;
		unkEnhancedId_ = other.unkEnhancedId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SetAvatarEnhancedIdScRsp Clone()
	{
		return new SetAvatarEnhancedIdScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as SetAvatarEnhancedIdScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SetAvatarEnhancedIdScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (GrowthAvatarId != other.GrowthAvatarId)
		{
			return false;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (UnkEnhancedId != other.UnkEnhancedId)
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
		if (GrowthAvatarId != 0)
		{
			num ^= GrowthAvatarId.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (UnkEnhancedId != 0)
		{
			num ^= UnkEnhancedId.GetHashCode();
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
		if (GrowthAvatarId != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(GrowthAvatarId);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(Retcode);
		}
		if (UnkEnhancedId != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(UnkEnhancedId);
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
		if (GrowthAvatarId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GrowthAvatarId);
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (UnkEnhancedId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(UnkEnhancedId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(SetAvatarEnhancedIdScRsp other)
	{
		if (other != null)
		{
			if (other.GrowthAvatarId != 0)
			{
				GrowthAvatarId = other.GrowthAvatarId;
			}
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
			}
			if (other.UnkEnhancedId != 0)
			{
				UnkEnhancedId = other.UnkEnhancedId;
			}
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
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
			case 40u:
				GrowthAvatarId = input.ReadUInt32();
				break;
			case 48u:
				Retcode = input.ReadUInt32();
				break;
			case 88u:
				UnkEnhancedId = input.ReadUInt32();
				break;
			}
		}
	}
}
