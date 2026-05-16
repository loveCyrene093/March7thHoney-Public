using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GetSwordTrainingDataScRsp : IMessage<GetSwordTrainingDataScRsp>, IMessage, IEquatable<GetSwordTrainingDataScRsp>, IDeepCloneable<GetSwordTrainingDataScRsp>, IBufferMessage
{
	private static readonly MessageParser<GetSwordTrainingDataScRsp> _parser = new MessageParser<GetSwordTrainingDataScRsp>(() => new GetSwordTrainingDataScRsp());

	private UnknownFieldSet _unknownFields;

	public const int FHNPAPAMNNEFieldNumber = 3;

	private static readonly FieldCodec<uint> _repeated_fHNPAPAMNNE_codec = FieldCodec.ForUInt32(26u);

	private readonly RepeatedField<uint> fHNPAPAMNNE_ = new RepeatedField<uint>();

	public const int RetcodeFieldNumber = 6;

	private uint retcode_;

	public const int FOEKDMEALKFFieldNumber = 7;

	private static readonly FieldCodec<uint> _repeated_fOEKDMEALKF_codec = FieldCodec.ForUInt32(58u);

	private readonly RepeatedField<uint> fOEKDMEALKF_ = new RepeatedField<uint>();

	public const int HEEHPMLAHPKFieldNumber = 9;

	private static readonly FieldCodec<uint> _repeated_hEEHPMLAHPK_codec = FieldCodec.ForUInt32(74u);

	private readonly RepeatedField<uint> hEEHPMLAHPK_ = new RepeatedField<uint>();

	public const int KEAFLGNLKBOFieldNumber = 10;

	private bool kEAFLGNLKBO_;

	public const int BMKAEFAKNFJFieldNumber = 12;

	private LMBHDCFPPLL bMKAEFAKNFJ_;

	public const int GCJFLELINJOFieldNumber = 13;

	private uint gCJFLELINJO_;

	public const int FCAPBPHLNCJFieldNumber = 14;

	private LLKEGAOLGGF fCAPBPHLNCJ_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GetSwordTrainingDataScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GetSwordTrainingDataScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> FHNPAPAMNNE => fHNPAPAMNNE_;

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
	public RepeatedField<uint> FOEKDMEALKF => fOEKDMEALKF_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> HEEHPMLAHPK => hEEHPMLAHPK_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool KEAFLGNLKBO
	{
		get
		{
			return kEAFLGNLKBO_;
		}
		set
		{
			kEAFLGNLKBO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LMBHDCFPPLL BMKAEFAKNFJ
	{
		get
		{
			return bMKAEFAKNFJ_;
		}
		set
		{
			bMKAEFAKNFJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GCJFLELINJO
	{
		get
		{
			return gCJFLELINJO_;
		}
		set
		{
			gCJFLELINJO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LLKEGAOLGGF FCAPBPHLNCJ
	{
		get
		{
			return fCAPBPHLNCJ_;
		}
		set
		{
			fCAPBPHLNCJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetSwordTrainingDataScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetSwordTrainingDataScRsp(GetSwordTrainingDataScRsp other)
		: this()
	{
		fHNPAPAMNNE_ = other.fHNPAPAMNNE_.Clone();
		retcode_ = other.retcode_;
		fOEKDMEALKF_ = other.fOEKDMEALKF_.Clone();
		hEEHPMLAHPK_ = other.hEEHPMLAHPK_.Clone();
		kEAFLGNLKBO_ = other.kEAFLGNLKBO_;
		bMKAEFAKNFJ_ = ((other.bMKAEFAKNFJ_ != null) ? other.bMKAEFAKNFJ_.Clone() : null);
		gCJFLELINJO_ = other.gCJFLELINJO_;
		fCAPBPHLNCJ_ = ((other.fCAPBPHLNCJ_ != null) ? other.fCAPBPHLNCJ_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetSwordTrainingDataScRsp Clone()
	{
		return new GetSwordTrainingDataScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GetSwordTrainingDataScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GetSwordTrainingDataScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!fHNPAPAMNNE_.Equals(other.fHNPAPAMNNE_))
		{
			return false;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (!fOEKDMEALKF_.Equals(other.fOEKDMEALKF_))
		{
			return false;
		}
		if (!hEEHPMLAHPK_.Equals(other.hEEHPMLAHPK_))
		{
			return false;
		}
		if (KEAFLGNLKBO != other.KEAFLGNLKBO)
		{
			return false;
		}
		if (!object.Equals(BMKAEFAKNFJ, other.BMKAEFAKNFJ))
		{
			return false;
		}
		if (GCJFLELINJO != other.GCJFLELINJO)
		{
			return false;
		}
		if (!object.Equals(FCAPBPHLNCJ, other.FCAPBPHLNCJ))
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
		num ^= fHNPAPAMNNE_.GetHashCode();
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		num ^= fOEKDMEALKF_.GetHashCode();
		num ^= hEEHPMLAHPK_.GetHashCode();
		if (KEAFLGNLKBO)
		{
			num ^= KEAFLGNLKBO.GetHashCode();
		}
		if (bMKAEFAKNFJ_ != null)
		{
			num ^= BMKAEFAKNFJ.GetHashCode();
		}
		if (GCJFLELINJO != 0)
		{
			num ^= GCJFLELINJO.GetHashCode();
		}
		if (fCAPBPHLNCJ_ != null)
		{
			num ^= FCAPBPHLNCJ.GetHashCode();
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
		fHNPAPAMNNE_.WriteTo(ref output, _repeated_fHNPAPAMNNE_codec);
		if (Retcode != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(Retcode);
		}
		fOEKDMEALKF_.WriteTo(ref output, _repeated_fOEKDMEALKF_codec);
		hEEHPMLAHPK_.WriteTo(ref output, _repeated_hEEHPMLAHPK_codec);
		if (KEAFLGNLKBO)
		{
			output.WriteRawTag(80);
			output.WriteBool(KEAFLGNLKBO);
		}
		if (bMKAEFAKNFJ_ != null)
		{
			output.WriteRawTag(98);
			output.WriteMessage(BMKAEFAKNFJ);
		}
		if (GCJFLELINJO != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(GCJFLELINJO);
		}
		if (fCAPBPHLNCJ_ != null)
		{
			output.WriteRawTag(114);
			output.WriteMessage(FCAPBPHLNCJ);
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
		num += fHNPAPAMNNE_.CalculateSize(_repeated_fHNPAPAMNNE_codec);
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		num += fOEKDMEALKF_.CalculateSize(_repeated_fOEKDMEALKF_codec);
		num += hEEHPMLAHPK_.CalculateSize(_repeated_hEEHPMLAHPK_codec);
		if (KEAFLGNLKBO)
		{
			num += 2;
		}
		if (bMKAEFAKNFJ_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(BMKAEFAKNFJ);
		}
		if (GCJFLELINJO != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GCJFLELINJO);
		}
		if (fCAPBPHLNCJ_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(FCAPBPHLNCJ);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GetSwordTrainingDataScRsp other)
	{
		if (other == null)
		{
			return;
		}
		fHNPAPAMNNE_.Add(other.fHNPAPAMNNE_);
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
		}
		fOEKDMEALKF_.Add(other.fOEKDMEALKF_);
		hEEHPMLAHPK_.Add(other.hEEHPMLAHPK_);
		if (other.KEAFLGNLKBO)
		{
			KEAFLGNLKBO = other.KEAFLGNLKBO;
		}
		if (other.bMKAEFAKNFJ_ != null)
		{
			if (bMKAEFAKNFJ_ == null)
			{
				BMKAEFAKNFJ = new LMBHDCFPPLL();
			}
			BMKAEFAKNFJ.MergeFrom(other.BMKAEFAKNFJ);
		}
		if (other.GCJFLELINJO != 0)
		{
			GCJFLELINJO = other.GCJFLELINJO;
		}
		if (other.fCAPBPHLNCJ_ != null)
		{
			if (fCAPBPHLNCJ_ == null)
			{
				FCAPBPHLNCJ = new LLKEGAOLGGF();
			}
			FCAPBPHLNCJ.MergeFrom(other.FCAPBPHLNCJ);
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
			case 24u:
			case 26u:
				fHNPAPAMNNE_.AddEntriesFrom(ref input, _repeated_fHNPAPAMNNE_codec);
				break;
			case 48u:
				Retcode = input.ReadUInt32();
				break;
			case 56u:
			case 58u:
				fOEKDMEALKF_.AddEntriesFrom(ref input, _repeated_fOEKDMEALKF_codec);
				break;
			case 72u:
			case 74u:
				hEEHPMLAHPK_.AddEntriesFrom(ref input, _repeated_hEEHPMLAHPK_codec);
				break;
			case 80u:
				KEAFLGNLKBO = input.ReadBool();
				break;
			case 98u:
				if (bMKAEFAKNFJ_ == null)
				{
					BMKAEFAKNFJ = new LMBHDCFPPLL();
				}
				input.ReadMessage(BMKAEFAKNFJ);
				break;
			case 104u:
				GCJFLELINJO = input.ReadUInt32();
				break;
			case 114u:
				if (fCAPBPHLNCJ_ == null)
				{
					FCAPBPHLNCJ = new LLKEGAOLGGF();
				}
				input.ReadMessage(FCAPBPHLNCJ);
				break;
			}
		}
	}
}
