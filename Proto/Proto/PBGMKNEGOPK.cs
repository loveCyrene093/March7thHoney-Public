using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class PBGMKNEGOPK : IMessage<PBGMKNEGOPK>, IMessage, IEquatable<PBGMKNEGOPK>, IDeepCloneable<PBGMKNEGOPK>, IBufferMessage
{
	private static readonly MessageParser<PBGMKNEGOPK> _parser = new MessageParser<PBGMKNEGOPK>(() => new PBGMKNEGOPK());

	private UnknownFieldSet _unknownFields;

	public const int MJIDMBJNGEIFieldNumber = 3;

	private uint mJIDMBJNGEI_;

	public const int BKAPBDGHIABFieldNumber = 4;

	private static readonly FieldCodec<HIBBPOAMDMA> _repeated_bKAPBDGHIAB_codec = FieldCodec.ForMessage(34u, HIBBPOAMDMA.Parser);

	private readonly RepeatedField<HIBBPOAMDMA> bKAPBDGHIAB_ = new RepeatedField<HIBBPOAMDMA>();

	public const int ALHDBLAJHNNFieldNumber = 6;

	private BDEMABPLPKO aLHDBLAJHNN_;

	public const int AFDBHGCAJDBFieldNumber = 9;

	private uint aFDBHGCAJDB_;

	public const int LKBDLBEAMGPFieldNumber = 12;

	private static readonly FieldCodec<uint> _repeated_lKBDLBEAMGP_codec = FieldCodec.ForUInt32(98u);

	private readonly RepeatedField<uint> lKBDLBEAMGP_ = new RepeatedField<uint>();

	public const int BIMNCNMBOGFFieldNumber = 13;

	private static readonly FieldCodec<ONOINAHEHHB> _repeated_bIMNCNMBOGF_codec = FieldCodec.ForMessage(106u, ONOINAHEHHB.Parser);

	private readonly RepeatedField<ONOINAHEHHB> bIMNCNMBOGF_ = new RepeatedField<ONOINAHEHHB>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PBGMKNEGOPK> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PBGMKNEGOPKReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MJIDMBJNGEI
	{
		get
		{
			return mJIDMBJNGEI_;
		}
		set
		{
			mJIDMBJNGEI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<HIBBPOAMDMA> BKAPBDGHIAB => bKAPBDGHIAB_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BDEMABPLPKO ALHDBLAJHNN
	{
		get
		{
			return aLHDBLAJHNN_;
		}
		set
		{
			aLHDBLAJHNN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint AFDBHGCAJDB
	{
		get
		{
			return aFDBHGCAJDB_;
		}
		set
		{
			aFDBHGCAJDB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> LKBDLBEAMGP => lKBDLBEAMGP_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<ONOINAHEHHB> BIMNCNMBOGF => bIMNCNMBOGF_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PBGMKNEGOPK()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PBGMKNEGOPK(PBGMKNEGOPK other)
		: this()
	{
		mJIDMBJNGEI_ = other.mJIDMBJNGEI_;
		bKAPBDGHIAB_ = other.bKAPBDGHIAB_.Clone();
		aLHDBLAJHNN_ = ((other.aLHDBLAJHNN_ != null) ? other.aLHDBLAJHNN_.Clone() : null);
		aFDBHGCAJDB_ = other.aFDBHGCAJDB_;
		lKBDLBEAMGP_ = other.lKBDLBEAMGP_.Clone();
		bIMNCNMBOGF_ = other.bIMNCNMBOGF_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PBGMKNEGOPK Clone()
	{
		return new PBGMKNEGOPK(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PBGMKNEGOPK);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PBGMKNEGOPK other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (MJIDMBJNGEI != other.MJIDMBJNGEI)
		{
			return false;
		}
		if (!bKAPBDGHIAB_.Equals(other.bKAPBDGHIAB_))
		{
			return false;
		}
		if (!object.Equals(ALHDBLAJHNN, other.ALHDBLAJHNN))
		{
			return false;
		}
		if (AFDBHGCAJDB != other.AFDBHGCAJDB)
		{
			return false;
		}
		if (!lKBDLBEAMGP_.Equals(other.lKBDLBEAMGP_))
		{
			return false;
		}
		if (!bIMNCNMBOGF_.Equals(other.bIMNCNMBOGF_))
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
		if (MJIDMBJNGEI != 0)
		{
			num ^= MJIDMBJNGEI.GetHashCode();
		}
		num ^= bKAPBDGHIAB_.GetHashCode();
		if (aLHDBLAJHNN_ != null)
		{
			num ^= ALHDBLAJHNN.GetHashCode();
		}
		if (AFDBHGCAJDB != 0)
		{
			num ^= AFDBHGCAJDB.GetHashCode();
		}
		num ^= lKBDLBEAMGP_.GetHashCode();
		num ^= bIMNCNMBOGF_.GetHashCode();
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
		if (MJIDMBJNGEI != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(MJIDMBJNGEI);
		}
		bKAPBDGHIAB_.WriteTo(ref output, _repeated_bKAPBDGHIAB_codec);
		if (aLHDBLAJHNN_ != null)
		{
			output.WriteRawTag(50);
			output.WriteMessage(ALHDBLAJHNN);
		}
		if (AFDBHGCAJDB != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(AFDBHGCAJDB);
		}
		lKBDLBEAMGP_.WriteTo(ref output, _repeated_lKBDLBEAMGP_codec);
		bIMNCNMBOGF_.WriteTo(ref output, _repeated_bIMNCNMBOGF_codec);
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
		if (MJIDMBJNGEI != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MJIDMBJNGEI);
		}
		num += bKAPBDGHIAB_.CalculateSize(_repeated_bKAPBDGHIAB_codec);
		if (aLHDBLAJHNN_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ALHDBLAJHNN);
		}
		if (AFDBHGCAJDB != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AFDBHGCAJDB);
		}
		num += lKBDLBEAMGP_.CalculateSize(_repeated_lKBDLBEAMGP_codec);
		num += bIMNCNMBOGF_.CalculateSize(_repeated_bIMNCNMBOGF_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PBGMKNEGOPK other)
	{
		if (other == null)
		{
			return;
		}
		if (other.MJIDMBJNGEI != 0)
		{
			MJIDMBJNGEI = other.MJIDMBJNGEI;
		}
		bKAPBDGHIAB_.Add(other.bKAPBDGHIAB_);
		if (other.aLHDBLAJHNN_ != null)
		{
			if (aLHDBLAJHNN_ == null)
			{
				ALHDBLAJHNN = new BDEMABPLPKO();
			}
			ALHDBLAJHNN.MergeFrom(other.ALHDBLAJHNN);
		}
		if (other.AFDBHGCAJDB != 0)
		{
			AFDBHGCAJDB = other.AFDBHGCAJDB;
		}
		lKBDLBEAMGP_.Add(other.lKBDLBEAMGP_);
		bIMNCNMBOGF_.Add(other.bIMNCNMBOGF_);
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
				MJIDMBJNGEI = input.ReadUInt32();
				break;
			case 34u:
				bKAPBDGHIAB_.AddEntriesFrom(ref input, _repeated_bKAPBDGHIAB_codec);
				break;
			case 50u:
				if (aLHDBLAJHNN_ == null)
				{
					ALHDBLAJHNN = new BDEMABPLPKO();
				}
				input.ReadMessage(ALHDBLAJHNN);
				break;
			case 72u:
				AFDBHGCAJDB = input.ReadUInt32();
				break;
			case 96u:
			case 98u:
				lKBDLBEAMGP_.AddEntriesFrom(ref input, _repeated_lKBDLBEAMGP_codec);
				break;
			case 106u:
				bIMNCNMBOGF_.AddEntriesFrom(ref input, _repeated_bIMNCNMBOGF_codec);
				break;
			}
		}
	}
}
