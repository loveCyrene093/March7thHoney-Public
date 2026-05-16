using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class BPCGILFKCFE : IMessage<BPCGILFKCFE>, IMessage, IEquatable<BPCGILFKCFE>, IDeepCloneable<BPCGILFKCFE>, IBufferMessage
{
	private static readonly MessageParser<BPCGILFKCFE> _parser = new MessageParser<BPCGILFKCFE>(() => new BPCGILFKCFE());

	private UnknownFieldSet _unknownFields;

	public const int RetcodeFieldNumber = 1;

	private LOPDMEPEDFG retcode_;

	public const int EndStatusFieldNumber = 2;

	private BattleEndStatus endStatus_;

	public const int SttFieldNumber = 3;

	private BattleStatistics stt_;

	public const int PLIAFNPANGNFieldNumber = 4;

	private ByteString pLIAFNPANGN_ = ByteString.Empty;

	public const int JFNCMHCAGGHFieldNumber = 5;

	private static readonly MapField<string, uint>.Codec _map_jFNCMHCAGGH_codec = new MapField<string, uint>.Codec(FieldCodec.ForString(10u, ""), FieldCodec.ForUInt32(16u, 0u), 42u);

	private readonly MapField<string, uint> jFNCMHCAGGH_ = new MapField<string, uint>();

	public const int CJAJBMAJNJPFieldNumber = 6;

	private uint cJAJBMAJNJP_;

	public const int BNALACMGKFJFieldNumber = 7;

	private uint bNALACMGKFJ_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<BPCGILFKCFE> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => BPCGILFKCFEReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LOPDMEPEDFG Retcode
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
	public BattleEndStatus EndStatus
	{
		get
		{
			return endStatus_;
		}
		set
		{
			endStatus_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BattleStatistics Stt
	{
		get
		{
			return stt_;
		}
		set
		{
			stt_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ByteString PLIAFNPANGN
	{
		get
		{
			return pLIAFNPANGN_;
		}
		set
		{
			pLIAFNPANGN_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapField<string, uint> JFNCMHCAGGH => jFNCMHCAGGH_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CJAJBMAJNJP
	{
		get
		{
			return cJAJBMAJNJP_;
		}
		set
		{
			cJAJBMAJNJP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint BNALACMGKFJ
	{
		get
		{
			return bNALACMGKFJ_;
		}
		set
		{
			bNALACMGKFJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BPCGILFKCFE()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BPCGILFKCFE(BPCGILFKCFE other)
		: this()
	{
		retcode_ = other.retcode_;
		endStatus_ = other.endStatus_;
		stt_ = ((other.stt_ != null) ? other.stt_.Clone() : null);
		pLIAFNPANGN_ = other.pLIAFNPANGN_;
		jFNCMHCAGGH_ = other.jFNCMHCAGGH_.Clone();
		cJAJBMAJNJP_ = other.cJAJBMAJNJP_;
		bNALACMGKFJ_ = other.bNALACMGKFJ_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BPCGILFKCFE Clone()
	{
		return new BPCGILFKCFE(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as BPCGILFKCFE);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(BPCGILFKCFE other)
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
		if (EndStatus != other.EndStatus)
		{
			return false;
		}
		if (!object.Equals(Stt, other.Stt))
		{
			return false;
		}
		if (PLIAFNPANGN != other.PLIAFNPANGN)
		{
			return false;
		}
		if (!JFNCMHCAGGH.Equals(other.JFNCMHCAGGH))
		{
			return false;
		}
		if (CJAJBMAJNJP != other.CJAJBMAJNJP)
		{
			return false;
		}
		if (BNALACMGKFJ != other.BNALACMGKFJ)
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
		if (Retcode != LOPDMEPEDFG.Emiedpkbpki)
		{
			num ^= Retcode.GetHashCode();
		}
		if (EndStatus != BattleEndStatus.BattleEndNone)
		{
			num ^= EndStatus.GetHashCode();
		}
		if (stt_ != null)
		{
			num ^= Stt.GetHashCode();
		}
		if (PLIAFNPANGN.Length != 0)
		{
			num ^= PLIAFNPANGN.GetHashCode();
		}
		num ^= JFNCMHCAGGH.GetHashCode();
		if (CJAJBMAJNJP != 0)
		{
			num ^= CJAJBMAJNJP.GetHashCode();
		}
		if (BNALACMGKFJ != 0)
		{
			num ^= BNALACMGKFJ.GetHashCode();
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
		if (Retcode != LOPDMEPEDFG.Emiedpkbpki)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Retcode);
		}
		if (EndStatus != BattleEndStatus.BattleEndNone)
		{
			output.WriteRawTag(16);
			output.WriteEnum((int)EndStatus);
		}
		if (stt_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(Stt);
		}
		if (PLIAFNPANGN.Length != 0)
		{
			output.WriteRawTag(34);
			output.WriteBytes(PLIAFNPANGN);
		}
		jFNCMHCAGGH_.WriteTo(ref output, _map_jFNCMHCAGGH_codec);
		if (CJAJBMAJNJP != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(CJAJBMAJNJP);
		}
		if (BNALACMGKFJ != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(BNALACMGKFJ);
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
		if (Retcode != LOPDMEPEDFG.Emiedpkbpki)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Retcode);
		}
		if (EndStatus != BattleEndStatus.BattleEndNone)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)EndStatus);
		}
		if (stt_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Stt);
		}
		if (PLIAFNPANGN.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeBytesSize(PLIAFNPANGN);
		}
		num += jFNCMHCAGGH_.CalculateSize(_map_jFNCMHCAGGH_codec);
		if (CJAJBMAJNJP != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CJAJBMAJNJP);
		}
		if (BNALACMGKFJ != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BNALACMGKFJ);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(BPCGILFKCFE other)
	{
		if (other == null)
		{
			return;
		}
		if (other.Retcode != LOPDMEPEDFG.Emiedpkbpki)
		{
			Retcode = other.Retcode;
		}
		if (other.EndStatus != BattleEndStatus.BattleEndNone)
		{
			EndStatus = other.EndStatus;
		}
		if (other.stt_ != null)
		{
			if (stt_ == null)
			{
				Stt = new BattleStatistics();
			}
			Stt.MergeFrom(other.Stt);
		}
		if (other.PLIAFNPANGN.Length != 0)
		{
			PLIAFNPANGN = other.PLIAFNPANGN;
		}
		jFNCMHCAGGH_.MergeFrom(other.jFNCMHCAGGH_);
		if (other.CJAJBMAJNJP != 0)
		{
			CJAJBMAJNJP = other.CJAJBMAJNJP;
		}
		if (other.BNALACMGKFJ != 0)
		{
			BNALACMGKFJ = other.BNALACMGKFJ;
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
				Retcode = (LOPDMEPEDFG)input.ReadEnum();
				break;
			case 16u:
				EndStatus = (BattleEndStatus)input.ReadEnum();
				break;
			case 26u:
				if (stt_ == null)
				{
					Stt = new BattleStatistics();
				}
				input.ReadMessage(Stt);
				break;
			case 34u:
				PLIAFNPANGN = input.ReadBytes();
				break;
			case 42u:
				jFNCMHCAGGH_.AddEntriesFrom(ref input, _map_jFNCMHCAGGH_codec);
				break;
			case 48u:
				CJAJBMAJNJP = input.ReadUInt32();
				break;
			case 56u:
				BNALACMGKFJ = input.ReadUInt32();
				break;
			}
		}
	}
}
