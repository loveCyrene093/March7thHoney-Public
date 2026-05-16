using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MatchThreeLevelEndCsReq : IMessage<MatchThreeLevelEndCsReq>, IMessage, IEquatable<MatchThreeLevelEndCsReq>, IDeepCloneable<MatchThreeLevelEndCsReq>, IBufferMessage
{
	private static readonly MessageParser<MatchThreeLevelEndCsReq> _parser = new MessageParser<MatchThreeLevelEndCsReq>(() => new MatchThreeLevelEndCsReq());

	private UnknownFieldSet _unknownFields;

	public const int NLOCDHMLGJHFieldNumber = 5;

	private uint nLOCDHMLGJH_;

	public const int KIBGNJNADDHFieldNumber = 7;

	private static readonly MapField<uint, uint>.Codec _map_kIBGNJNADDH_codec = new MapField<uint, uint>.Codec(FieldCodec.ForUInt32(8u, 0u), FieldCodec.ForUInt32(16u, 0u), 58u);

	private readonly MapField<uint, uint> kIBGNJNADDH_ = new MapField<uint, uint>();

	public const int UuidFieldNumber = 8;

	private string uuid_ = "";

	public const int FDDOFFFPALCFieldNumber = 10;

	private static readonly FieldCodec<uint> _repeated_fDDOFFFPALC_codec = FieldCodec.ForUInt32(82u);

	private readonly RepeatedField<uint> fDDOFFFPALC_ = new RepeatedField<uint>();

	public const int BOFOOKJCJGGFieldNumber = 12;

	private uint bOFOOKJCJGG_;

	public const int LevelIdFieldNumber = 13;

	private uint levelId_;

	public const int DPCFBDCEKJLFieldNumber = 14;

	private uint dPCFBDCEKJL_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MatchThreeLevelEndCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MatchThreeLevelEndCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint NLOCDHMLGJH
	{
		get
		{
			return nLOCDHMLGJH_;
		}
		set
		{
			nLOCDHMLGJH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapField<uint, uint> KIBGNJNADDH => kIBGNJNADDH_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string Uuid
	{
		get
		{
			return uuid_;
		}
		set
		{
			uuid_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> FDDOFFFPALC => fDDOFFFPALC_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint BOFOOKJCJGG
	{
		get
		{
			return bOFOOKJCJGG_;
		}
		set
		{
			bOFOOKJCJGG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint LevelId
	{
		get
		{
			return levelId_;
		}
		set
		{
			levelId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint DPCFBDCEKJL
	{
		get
		{
			return dPCFBDCEKJL_;
		}
		set
		{
			dPCFBDCEKJL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MatchThreeLevelEndCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MatchThreeLevelEndCsReq(MatchThreeLevelEndCsReq other)
		: this()
	{
		nLOCDHMLGJH_ = other.nLOCDHMLGJH_;
		kIBGNJNADDH_ = other.kIBGNJNADDH_.Clone();
		uuid_ = other.uuid_;
		fDDOFFFPALC_ = other.fDDOFFFPALC_.Clone();
		bOFOOKJCJGG_ = other.bOFOOKJCJGG_;
		levelId_ = other.levelId_;
		dPCFBDCEKJL_ = other.dPCFBDCEKJL_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MatchThreeLevelEndCsReq Clone()
	{
		return new MatchThreeLevelEndCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MatchThreeLevelEndCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MatchThreeLevelEndCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (NLOCDHMLGJH != other.NLOCDHMLGJH)
		{
			return false;
		}
		if (!KIBGNJNADDH.Equals(other.KIBGNJNADDH))
		{
			return false;
		}
		if (Uuid != other.Uuid)
		{
			return false;
		}
		if (!fDDOFFFPALC_.Equals(other.fDDOFFFPALC_))
		{
			return false;
		}
		if (BOFOOKJCJGG != other.BOFOOKJCJGG)
		{
			return false;
		}
		if (LevelId != other.LevelId)
		{
			return false;
		}
		if (DPCFBDCEKJL != other.DPCFBDCEKJL)
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
		if (NLOCDHMLGJH != 0)
		{
			num ^= NLOCDHMLGJH.GetHashCode();
		}
		num ^= KIBGNJNADDH.GetHashCode();
		if (Uuid.Length != 0)
		{
			num ^= Uuid.GetHashCode();
		}
		num ^= fDDOFFFPALC_.GetHashCode();
		if (BOFOOKJCJGG != 0)
		{
			num ^= BOFOOKJCJGG.GetHashCode();
		}
		if (LevelId != 0)
		{
			num ^= LevelId.GetHashCode();
		}
		if (DPCFBDCEKJL != 0)
		{
			num ^= DPCFBDCEKJL.GetHashCode();
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
		if (NLOCDHMLGJH != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(NLOCDHMLGJH);
		}
		kIBGNJNADDH_.WriteTo(ref output, _map_kIBGNJNADDH_codec);
		if (Uuid.Length != 0)
		{
			output.WriteRawTag(66);
			output.WriteString(Uuid);
		}
		fDDOFFFPALC_.WriteTo(ref output, _repeated_fDDOFFFPALC_codec);
		if (BOFOOKJCJGG != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(BOFOOKJCJGG);
		}
		if (LevelId != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(LevelId);
		}
		if (DPCFBDCEKJL != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(DPCFBDCEKJL);
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
		if (NLOCDHMLGJH != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(NLOCDHMLGJH);
		}
		num += kIBGNJNADDH_.CalculateSize(_map_kIBGNJNADDH_codec);
		if (Uuid.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Uuid);
		}
		num += fDDOFFFPALC_.CalculateSize(_repeated_fDDOFFFPALC_codec);
		if (BOFOOKJCJGG != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BOFOOKJCJGG);
		}
		if (LevelId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LevelId);
		}
		if (DPCFBDCEKJL != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DPCFBDCEKJL);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MatchThreeLevelEndCsReq other)
	{
		if (other != null)
		{
			if (other.NLOCDHMLGJH != 0)
			{
				NLOCDHMLGJH = other.NLOCDHMLGJH;
			}
			kIBGNJNADDH_.MergeFrom(other.kIBGNJNADDH_);
			if (other.Uuid.Length != 0)
			{
				Uuid = other.Uuid;
			}
			fDDOFFFPALC_.Add(other.fDDOFFFPALC_);
			if (other.BOFOOKJCJGG != 0)
			{
				BOFOOKJCJGG = other.BOFOOKJCJGG;
			}
			if (other.LevelId != 0)
			{
				LevelId = other.LevelId;
			}
			if (other.DPCFBDCEKJL != 0)
			{
				DPCFBDCEKJL = other.DPCFBDCEKJL;
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
				NLOCDHMLGJH = input.ReadUInt32();
				break;
			case 58u:
				kIBGNJNADDH_.AddEntriesFrom(ref input, _map_kIBGNJNADDH_codec);
				break;
			case 66u:
				Uuid = input.ReadString();
				break;
			case 80u:
			case 82u:
				fDDOFFFPALC_.AddEntriesFrom(ref input, _repeated_fDDOFFFPALC_codec);
				break;
			case 96u:
				BOFOOKJCJGG = input.ReadUInt32();
				break;
			case 104u:
				LevelId = input.ReadUInt32();
				break;
			case 112u:
				DPCFBDCEKJL = input.ReadUInt32();
				break;
			}
		}
	}
}
