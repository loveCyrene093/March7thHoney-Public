using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ChessRogueStartCsReq : IMessage<ChessRogueStartCsReq>, IMessage, IEquatable<ChessRogueStartCsReq>, IDeepCloneable<ChessRogueStartCsReq>, IBufferMessage
{
	private static readonly MessageParser<ChessRogueStartCsReq> _parser = new MessageParser<ChessRogueStartCsReq>(() => new ChessRogueStartCsReq());

	private UnknownFieldSet _unknownFields;

	public const int LGHOOKMNMCLFieldNumber = 2;

	private uint lGHOOKMNMCL_;

	public const int UnfinishedStoryLineIdListFieldNumber = 4;

	private static readonly FieldCodec<uint> _repeated_unfinishedStoryLineIdList_codec = FieldCodec.ForUInt32(34u);

	private readonly RepeatedField<uint> unfinishedStoryLineIdList_ = new RepeatedField<uint>();

	public const int IdFieldNumber = 5;

	private uint id_;

	public const int BaseAvatarIdListFieldNumber = 8;

	private static readonly FieldCodec<uint> _repeated_baseAvatarIdList_codec = FieldCodec.ForUInt32(66u);

	private readonly RepeatedField<uint> baseAvatarIdList_ = new RepeatedField<uint>();

	public const int AMHDFMFILBDFieldNumber = 9;

	private uint aMHDFMFILBD_;

	public const int KOLBLKEDOGCFieldNumber = 12;

	private static readonly FieldCodec<uint> _repeated_kOLBLKEDOGC_codec = FieldCodec.ForUInt32(98u);

	private readonly RepeatedField<uint> kOLBLKEDOGC_ = new RepeatedField<uint>();

	public const int OJAHMNANINLFieldNumber = 14;

	private static readonly FieldCodec<uint> _repeated_oJAHMNANINL_codec = FieldCodec.ForUInt32(114u);

	private readonly RepeatedField<uint> oJAHMNANINL_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ChessRogueStartCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ChessRogueStartCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint LGHOOKMNMCL
	{
		get
		{
			return lGHOOKMNMCL_;
		}
		set
		{
			lGHOOKMNMCL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> UnfinishedStoryLineIdList => unfinishedStoryLineIdList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Id
	{
		get
		{
			return id_;
		}
		set
		{
			id_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> BaseAvatarIdList => baseAvatarIdList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint AMHDFMFILBD
	{
		get
		{
			return aMHDFMFILBD_;
		}
		set
		{
			aMHDFMFILBD_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> KOLBLKEDOGC => kOLBLKEDOGC_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> OJAHMNANINL => oJAHMNANINL_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChessRogueStartCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChessRogueStartCsReq(ChessRogueStartCsReq other)
		: this()
	{
		lGHOOKMNMCL_ = other.lGHOOKMNMCL_;
		unfinishedStoryLineIdList_ = other.unfinishedStoryLineIdList_.Clone();
		id_ = other.id_;
		baseAvatarIdList_ = other.baseAvatarIdList_.Clone();
		aMHDFMFILBD_ = other.aMHDFMFILBD_;
		kOLBLKEDOGC_ = other.kOLBLKEDOGC_.Clone();
		oJAHMNANINL_ = other.oJAHMNANINL_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChessRogueStartCsReq Clone()
	{
		return new ChessRogueStartCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ChessRogueStartCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ChessRogueStartCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (LGHOOKMNMCL != other.LGHOOKMNMCL)
		{
			return false;
		}
		if (!unfinishedStoryLineIdList_.Equals(other.unfinishedStoryLineIdList_))
		{
			return false;
		}
		if (Id != other.Id)
		{
			return false;
		}
		if (!baseAvatarIdList_.Equals(other.baseAvatarIdList_))
		{
			return false;
		}
		if (AMHDFMFILBD != other.AMHDFMFILBD)
		{
			return false;
		}
		if (!kOLBLKEDOGC_.Equals(other.kOLBLKEDOGC_))
		{
			return false;
		}
		if (!oJAHMNANINL_.Equals(other.oJAHMNANINL_))
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
		if (LGHOOKMNMCL != 0)
		{
			num ^= LGHOOKMNMCL.GetHashCode();
		}
		num ^= unfinishedStoryLineIdList_.GetHashCode();
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		num ^= baseAvatarIdList_.GetHashCode();
		if (AMHDFMFILBD != 0)
		{
			num ^= AMHDFMFILBD.GetHashCode();
		}
		num ^= kOLBLKEDOGC_.GetHashCode();
		num ^= oJAHMNANINL_.GetHashCode();
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
		if (LGHOOKMNMCL != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(LGHOOKMNMCL);
		}
		unfinishedStoryLineIdList_.WriteTo(ref output, _repeated_unfinishedStoryLineIdList_codec);
		if (Id != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(Id);
		}
		baseAvatarIdList_.WriteTo(ref output, _repeated_baseAvatarIdList_codec);
		if (AMHDFMFILBD != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(AMHDFMFILBD);
		}
		kOLBLKEDOGC_.WriteTo(ref output, _repeated_kOLBLKEDOGC_codec);
		oJAHMNANINL_.WriteTo(ref output, _repeated_oJAHMNANINL_codec);
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
		if (LGHOOKMNMCL != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LGHOOKMNMCL);
		}
		num += unfinishedStoryLineIdList_.CalculateSize(_repeated_unfinishedStoryLineIdList_codec);
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Id);
		}
		num += baseAvatarIdList_.CalculateSize(_repeated_baseAvatarIdList_codec);
		if (AMHDFMFILBD != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AMHDFMFILBD);
		}
		num += kOLBLKEDOGC_.CalculateSize(_repeated_kOLBLKEDOGC_codec);
		num += oJAHMNANINL_.CalculateSize(_repeated_oJAHMNANINL_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ChessRogueStartCsReq other)
	{
		if (other != null)
		{
			if (other.LGHOOKMNMCL != 0)
			{
				LGHOOKMNMCL = other.LGHOOKMNMCL;
			}
			unfinishedStoryLineIdList_.Add(other.unfinishedStoryLineIdList_);
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			baseAvatarIdList_.Add(other.baseAvatarIdList_);
			if (other.AMHDFMFILBD != 0)
			{
				AMHDFMFILBD = other.AMHDFMFILBD;
			}
			kOLBLKEDOGC_.Add(other.kOLBLKEDOGC_);
			oJAHMNANINL_.Add(other.oJAHMNANINL_);
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
			case 16u:
				LGHOOKMNMCL = input.ReadUInt32();
				break;
			case 32u:
			case 34u:
				unfinishedStoryLineIdList_.AddEntriesFrom(ref input, _repeated_unfinishedStoryLineIdList_codec);
				break;
			case 40u:
				Id = input.ReadUInt32();
				break;
			case 64u:
			case 66u:
				baseAvatarIdList_.AddEntriesFrom(ref input, _repeated_baseAvatarIdList_codec);
				break;
			case 72u:
				AMHDFMFILBD = input.ReadUInt32();
				break;
			case 96u:
			case 98u:
				kOLBLKEDOGC_.AddEntriesFrom(ref input, _repeated_kOLBLKEDOGC_codec);
				break;
			case 112u:
			case 114u:
				oJAHMNANINL_.AddEntriesFrom(ref input, _repeated_oJAHMNANINL_codec);
				break;
			}
		}
	}
}
