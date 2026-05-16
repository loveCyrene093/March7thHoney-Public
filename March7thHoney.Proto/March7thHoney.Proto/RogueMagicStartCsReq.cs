using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class RogueMagicStartCsReq : IMessage<RogueMagicStartCsReq>, IMessage, IEquatable<RogueMagicStartCsReq>, IDeepCloneable<RogueMagicStartCsReq>, IBufferMessage
{
	private static readonly MessageParser<RogueMagicStartCsReq> _parser = new MessageParser<RogueMagicStartCsReq>(() => new RogueMagicStartCsReq());

	private UnknownFieldSet _unknownFields;

	public const int NGDKLBHDAGGFieldNumber = 1;

	private uint nGDKLBHDAGG_;

	public const int AreaIdFieldNumber = 4;

	private uint areaId_;

	public const int OJAHMNANINLFieldNumber = 12;

	private static readonly FieldCodec<uint> _repeated_oJAHMNANINL_codec = FieldCodec.ForUInt32(98u);

	private readonly RepeatedField<uint> oJAHMNANINL_ = new RepeatedField<uint>();

	public const int BaseAvatarIdListFieldNumber = 14;

	private static readonly FieldCodec<uint> _repeated_baseAvatarIdList_codec = FieldCodec.ForUInt32(114u);

	private readonly RepeatedField<uint> baseAvatarIdList_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<RogueMagicStartCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => RogueMagicStartCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint NGDKLBHDAGG
	{
		get
		{
			return nGDKLBHDAGG_;
		}
		set
		{
			nGDKLBHDAGG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint AreaId
	{
		get
		{
			return areaId_;
		}
		set
		{
			areaId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> OJAHMNANINL => oJAHMNANINL_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> BaseAvatarIdList => baseAvatarIdList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RogueMagicStartCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RogueMagicStartCsReq(RogueMagicStartCsReq other)
		: this()
	{
		nGDKLBHDAGG_ = other.nGDKLBHDAGG_;
		areaId_ = other.areaId_;
		oJAHMNANINL_ = other.oJAHMNANINL_.Clone();
		baseAvatarIdList_ = other.baseAvatarIdList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RogueMagicStartCsReq Clone()
	{
		return new RogueMagicStartCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as RogueMagicStartCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(RogueMagicStartCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (NGDKLBHDAGG != other.NGDKLBHDAGG)
		{
			return false;
		}
		if (AreaId != other.AreaId)
		{
			return false;
		}
		if (!oJAHMNANINL_.Equals(other.oJAHMNANINL_))
		{
			return false;
		}
		if (!baseAvatarIdList_.Equals(other.baseAvatarIdList_))
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
		if (NGDKLBHDAGG != 0)
		{
			num ^= NGDKLBHDAGG.GetHashCode();
		}
		if (AreaId != 0)
		{
			num ^= AreaId.GetHashCode();
		}
		num ^= oJAHMNANINL_.GetHashCode();
		num ^= baseAvatarIdList_.GetHashCode();
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
		if (NGDKLBHDAGG != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(NGDKLBHDAGG);
		}
		if (AreaId != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(AreaId);
		}
		oJAHMNANINL_.WriteTo(ref output, _repeated_oJAHMNANINL_codec);
		baseAvatarIdList_.WriteTo(ref output, _repeated_baseAvatarIdList_codec);
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
		if (NGDKLBHDAGG != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(NGDKLBHDAGG);
		}
		if (AreaId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AreaId);
		}
		num += oJAHMNANINL_.CalculateSize(_repeated_oJAHMNANINL_codec);
		num += baseAvatarIdList_.CalculateSize(_repeated_baseAvatarIdList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(RogueMagicStartCsReq other)
	{
		if (other != null)
		{
			if (other.NGDKLBHDAGG != 0)
			{
				NGDKLBHDAGG = other.NGDKLBHDAGG;
			}
			if (other.AreaId != 0)
			{
				AreaId = other.AreaId;
			}
			oJAHMNANINL_.Add(other.oJAHMNANINL_);
			baseAvatarIdList_.Add(other.baseAvatarIdList_);
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
			case 8u:
				NGDKLBHDAGG = input.ReadUInt32();
				break;
			case 32u:
				AreaId = input.ReadUInt32();
				break;
			case 96u:
			case 98u:
				oJAHMNANINL_.AddEntriesFrom(ref input, _repeated_oJAHMNANINL_codec);
				break;
			case 112u:
			case 114u:
				baseAvatarIdList_.AddEntriesFrom(ref input, _repeated_baseAvatarIdList_codec);
				break;
			}
		}
	}
}
