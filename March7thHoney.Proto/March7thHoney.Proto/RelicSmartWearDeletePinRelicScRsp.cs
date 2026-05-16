using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class RelicSmartWearDeletePinRelicScRsp : IMessage<RelicSmartWearDeletePinRelicScRsp>, IMessage, IEquatable<RelicSmartWearDeletePinRelicScRsp>, IDeepCloneable<RelicSmartWearDeletePinRelicScRsp>, IBufferMessage
{
	private static readonly MessageParser<RelicSmartWearDeletePinRelicScRsp> _parser = new MessageParser<RelicSmartWearDeletePinRelicScRsp>(() => new RelicSmartWearDeletePinRelicScRsp());

	private UnknownFieldSet _unknownFields;

	public const int DHCNMIAIBGFFieldNumber = 5;

	private static readonly FieldCodec<NHFOGDPBOHN> _repeated_dHCNMIAIBGF_codec = FieldCodec.ForMessage(42u, NHFOGDPBOHN.Parser);

	private readonly RepeatedField<NHFOGDPBOHN> dHCNMIAIBGF_ = new RepeatedField<NHFOGDPBOHN>();

	public const int AvatarIdFieldNumber = 11;

	private uint avatarId_;

	public const int RetcodeFieldNumber = 14;

	private uint retcode_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<RelicSmartWearDeletePinRelicScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => RelicSmartWearDeletePinRelicScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<NHFOGDPBOHN> DHCNMIAIBGF => dHCNMIAIBGF_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint AvatarId
	{
		get
		{
			return avatarId_;
		}
		set
		{
			avatarId_ = value;
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
	public RelicSmartWearDeletePinRelicScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RelicSmartWearDeletePinRelicScRsp(RelicSmartWearDeletePinRelicScRsp other)
		: this()
	{
		dHCNMIAIBGF_ = other.dHCNMIAIBGF_.Clone();
		avatarId_ = other.avatarId_;
		retcode_ = other.retcode_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RelicSmartWearDeletePinRelicScRsp Clone()
	{
		return new RelicSmartWearDeletePinRelicScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as RelicSmartWearDeletePinRelicScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(RelicSmartWearDeletePinRelicScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!dHCNMIAIBGF_.Equals(other.dHCNMIAIBGF_))
		{
			return false;
		}
		if (AvatarId != other.AvatarId)
		{
			return false;
		}
		if (Retcode != other.Retcode)
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
		num ^= dHCNMIAIBGF_.GetHashCode();
		if (AvatarId != 0)
		{
			num ^= AvatarId.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
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
		dHCNMIAIBGF_.WriteTo(ref output, _repeated_dHCNMIAIBGF_codec);
		if (AvatarId != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(AvatarId);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(Retcode);
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
		num += dHCNMIAIBGF_.CalculateSize(_repeated_dHCNMIAIBGF_codec);
		if (AvatarId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AvatarId);
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(RelicSmartWearDeletePinRelicScRsp other)
	{
		if (other != null)
		{
			dHCNMIAIBGF_.Add(other.dHCNMIAIBGF_);
			if (other.AvatarId != 0)
			{
				AvatarId = other.AvatarId;
			}
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
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
			case 42u:
				dHCNMIAIBGF_.AddEntriesFrom(ref input, _repeated_dHCNMIAIBGF_codec);
				break;
			case 88u:
				AvatarId = input.ReadUInt32();
				break;
			case 112u:
				Retcode = input.ReadUInt32();
				break;
			}
		}
	}
}
