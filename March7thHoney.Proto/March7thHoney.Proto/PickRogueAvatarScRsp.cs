using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class PickRogueAvatarScRsp : IMessage<PickRogueAvatarScRsp>, IMessage, IEquatable<PickRogueAvatarScRsp>, IDeepCloneable<PickRogueAvatarScRsp>, IBufferMessage
{
	private static readonly MessageParser<PickRogueAvatarScRsp> _parser = new MessageParser<PickRogueAvatarScRsp>(() => new PickRogueAvatarScRsp());

	private UnknownFieldSet _unknownFields;

	public const int LBNHKPPAJIMFieldNumber = 6;

	private MPKGLGCLAID lBNHKPPAJIM_;

	public const int BaseAvatarIdListFieldNumber = 9;

	private static readonly FieldCodec<uint> _repeated_baseAvatarIdList_codec = FieldCodec.ForUInt32(74u);

	private readonly RepeatedField<uint> baseAvatarIdList_ = new RepeatedField<uint>();

	public const int RetcodeFieldNumber = 10;

	private uint retcode_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PickRogueAvatarScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PickRogueAvatarScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MPKGLGCLAID LBNHKPPAJIM
	{
		get
		{
			return lBNHKPPAJIM_;
		}
		set
		{
			lBNHKPPAJIM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> BaseAvatarIdList => baseAvatarIdList_;

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
	public PickRogueAvatarScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PickRogueAvatarScRsp(PickRogueAvatarScRsp other)
		: this()
	{
		lBNHKPPAJIM_ = ((other.lBNHKPPAJIM_ != null) ? other.lBNHKPPAJIM_.Clone() : null);
		baseAvatarIdList_ = other.baseAvatarIdList_.Clone();
		retcode_ = other.retcode_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PickRogueAvatarScRsp Clone()
	{
		return new PickRogueAvatarScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PickRogueAvatarScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PickRogueAvatarScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(LBNHKPPAJIM, other.LBNHKPPAJIM))
		{
			return false;
		}
		if (!baseAvatarIdList_.Equals(other.baseAvatarIdList_))
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
		if (lBNHKPPAJIM_ != null)
		{
			num ^= LBNHKPPAJIM.GetHashCode();
		}
		num ^= baseAvatarIdList_.GetHashCode();
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
		if (lBNHKPPAJIM_ != null)
		{
			output.WriteRawTag(50);
			output.WriteMessage(LBNHKPPAJIM);
		}
		baseAvatarIdList_.WriteTo(ref output, _repeated_baseAvatarIdList_codec);
		if (Retcode != 0)
		{
			output.WriteRawTag(80);
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
		if (lBNHKPPAJIM_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(LBNHKPPAJIM);
		}
		num += baseAvatarIdList_.CalculateSize(_repeated_baseAvatarIdList_codec);
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
	public void MergeFrom(PickRogueAvatarScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.lBNHKPPAJIM_ != null)
		{
			if (lBNHKPPAJIM_ == null)
			{
				LBNHKPPAJIM = new MPKGLGCLAID();
			}
			LBNHKPPAJIM.MergeFrom(other.LBNHKPPAJIM);
		}
		baseAvatarIdList_.Add(other.baseAvatarIdList_);
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
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
			case 50u:
				if (lBNHKPPAJIM_ == null)
				{
					LBNHKPPAJIM = new MPKGLGCLAID();
				}
				input.ReadMessage(LBNHKPPAJIM);
				break;
			case 72u:
			case 74u:
				baseAvatarIdList_.AddEntriesFrom(ref input, _repeated_baseAvatarIdList_codec);
				break;
			case 80u:
				Retcode = input.ReadUInt32();
				break;
			}
		}
	}
}
