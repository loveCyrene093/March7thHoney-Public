using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class SetGrowthTargetAvatarScRsp : IMessage<SetGrowthTargetAvatarScRsp>, IMessage, IEquatable<SetGrowthTargetAvatarScRsp>, IDeepCloneable<SetGrowthTargetAvatarScRsp>, IBufferMessage
{
	private static readonly MessageParser<SetGrowthTargetAvatarScRsp> _parser = new MessageParser<SetGrowthTargetAvatarScRsp>(() => new SetGrowthTargetAvatarScRsp());

	private UnknownFieldSet _unknownFields;

	public const int RetcodeFieldNumber = 5;

	private uint retcode_;

	public const int GrowthAvatarIdFieldNumber = 6;

	private uint growthAvatarId_;

	public const int DHAIJLJCJAFFieldNumber = 10;

	private static readonly FieldCodec<GrowthTartgetFuncType> _repeated_dHAIJLJCJAF_codec = FieldCodec.ForEnum(82u, (GrowthTartgetFuncType x) => (int)x, (int x) => (GrowthTartgetFuncType)x);

	private readonly RepeatedField<GrowthTartgetFuncType> dHAIJLJCJAF_ = new RepeatedField<GrowthTartgetFuncType>();

	public const int MMOPCKLPHIOFieldNumber = 15;

	private uint mMOPCKLPHIO_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SetGrowthTargetAvatarScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => SetGrowthTargetAvatarScRspReflection.Descriptor.MessageTypes[0];

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
	public RepeatedField<GrowthTartgetFuncType> DHAIJLJCJAF => dHAIJLJCJAF_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MMOPCKLPHIO
	{
		get
		{
			return mMOPCKLPHIO_;
		}
		set
		{
			mMOPCKLPHIO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SetGrowthTargetAvatarScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SetGrowthTargetAvatarScRsp(SetGrowthTargetAvatarScRsp other)
		: this()
	{
		retcode_ = other.retcode_;
		growthAvatarId_ = other.growthAvatarId_;
		dHAIJLJCJAF_ = other.dHAIJLJCJAF_.Clone();
		mMOPCKLPHIO_ = other.mMOPCKLPHIO_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SetGrowthTargetAvatarScRsp Clone()
	{
		return new SetGrowthTargetAvatarScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as SetGrowthTargetAvatarScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SetGrowthTargetAvatarScRsp other)
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
		if (GrowthAvatarId != other.GrowthAvatarId)
		{
			return false;
		}
		if (!dHAIJLJCJAF_.Equals(other.dHAIJLJCJAF_))
		{
			return false;
		}
		if (MMOPCKLPHIO != other.MMOPCKLPHIO)
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
		if (GrowthAvatarId != 0)
		{
			num ^= GrowthAvatarId.GetHashCode();
		}
		num ^= dHAIJLJCJAF_.GetHashCode();
		if (MMOPCKLPHIO != 0)
		{
			num ^= MMOPCKLPHIO.GetHashCode();
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
			output.WriteRawTag(40);
			output.WriteUInt32(Retcode);
		}
		if (GrowthAvatarId != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(GrowthAvatarId);
		}
		dHAIJLJCJAF_.WriteTo(ref output, _repeated_dHAIJLJCJAF_codec);
		if (MMOPCKLPHIO != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(MMOPCKLPHIO);
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
		if (GrowthAvatarId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GrowthAvatarId);
		}
		num += dHAIJLJCJAF_.CalculateSize(_repeated_dHAIJLJCJAF_codec);
		if (MMOPCKLPHIO != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MMOPCKLPHIO);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(SetGrowthTargetAvatarScRsp other)
	{
		if (other != null)
		{
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
			}
			if (other.GrowthAvatarId != 0)
			{
				GrowthAvatarId = other.GrowthAvatarId;
			}
			dHAIJLJCJAF_.Add(other.dHAIJLJCJAF_);
			if (other.MMOPCKLPHIO != 0)
			{
				MMOPCKLPHIO = other.MMOPCKLPHIO;
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
				Retcode = input.ReadUInt32();
				break;
			case 48u:
				GrowthAvatarId = input.ReadUInt32();
				break;
			case 80u:
			case 82u:
				dHAIJLJCJAF_.AddEntriesFrom(ref input, _repeated_dHAIJLJCJAF_codec);
				break;
			case 120u:
				MMOPCKLPHIO = input.ReadUInt32();
				break;
			}
		}
	}
}
