using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GBHHOMHNLKD : IMessage<GBHHOMHNLKD>, IMessage, IEquatable<GBHHOMHNLKD>, IDeepCloneable<GBHHOMHNLKD>, IBufferMessage
{
	private static readonly MessageParser<GBHHOMHNLKD> _parser = new MessageParser<GBHHOMHNLKD>(() => new GBHHOMHNLKD());

	private UnknownFieldSet _unknownFields;

	public const int ArgIdFieldNumber = 2;

	private uint argId_;

	public const int NIKEEDLJHPDFieldNumber = 5;

	private bool nIKEEDLJHPD_;

	public const int CHCGMAMOBMHFieldNumber = 7;

	private bool cHCGMAMOBMH_;

	public const int AMADFJNHMFFFieldNumber = 8;

	private uint aMADFJNHMFF_;

	public const int DisplayValueFieldNumber = 10;

	private JKICLFBINHN displayValue_;

	public const int KDIDNELEDJDFieldNumber = 14;

	private static readonly FieldCodec<IFJEDJAFCJN> _repeated_kDIDNELEDJD_codec = FieldCodec.ForMessage(114u, IFJEDJAFCJN.Parser);

	private readonly RepeatedField<IFJEDJAFCJN> kDIDNELEDJD_ = new RepeatedField<IFJEDJAFCJN>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GBHHOMHNLKD> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GBHHOMHNLKDReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ArgId
	{
		get
		{
			return argId_;
		}
		set
		{
			argId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool NIKEEDLJHPD
	{
		get
		{
			return nIKEEDLJHPD_;
		}
		set
		{
			nIKEEDLJHPD_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool CHCGMAMOBMH
	{
		get
		{
			return cHCGMAMOBMH_;
		}
		set
		{
			cHCGMAMOBMH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint AMADFJNHMFF
	{
		get
		{
			return aMADFJNHMFF_;
		}
		set
		{
			aMADFJNHMFF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JKICLFBINHN DisplayValue
	{
		get
		{
			return displayValue_;
		}
		set
		{
			displayValue_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<IFJEDJAFCJN> KDIDNELEDJD => kDIDNELEDJD_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GBHHOMHNLKD()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GBHHOMHNLKD(GBHHOMHNLKD other)
		: this()
	{
		argId_ = other.argId_;
		nIKEEDLJHPD_ = other.nIKEEDLJHPD_;
		cHCGMAMOBMH_ = other.cHCGMAMOBMH_;
		aMADFJNHMFF_ = other.aMADFJNHMFF_;
		displayValue_ = ((other.displayValue_ != null) ? other.displayValue_.Clone() : null);
		kDIDNELEDJD_ = other.kDIDNELEDJD_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GBHHOMHNLKD Clone()
	{
		return new GBHHOMHNLKD(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GBHHOMHNLKD);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GBHHOMHNLKD other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ArgId != other.ArgId)
		{
			return false;
		}
		if (NIKEEDLJHPD != other.NIKEEDLJHPD)
		{
			return false;
		}
		if (CHCGMAMOBMH != other.CHCGMAMOBMH)
		{
			return false;
		}
		if (AMADFJNHMFF != other.AMADFJNHMFF)
		{
			return false;
		}
		if (!object.Equals(DisplayValue, other.DisplayValue))
		{
			return false;
		}
		if (!kDIDNELEDJD_.Equals(other.kDIDNELEDJD_))
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
		if (ArgId != 0)
		{
			num ^= ArgId.GetHashCode();
		}
		if (NIKEEDLJHPD)
		{
			num ^= NIKEEDLJHPD.GetHashCode();
		}
		if (CHCGMAMOBMH)
		{
			num ^= CHCGMAMOBMH.GetHashCode();
		}
		if (AMADFJNHMFF != 0)
		{
			num ^= AMADFJNHMFF.GetHashCode();
		}
		if (displayValue_ != null)
		{
			num ^= DisplayValue.GetHashCode();
		}
		num ^= kDIDNELEDJD_.GetHashCode();
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
		if (ArgId != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(ArgId);
		}
		if (NIKEEDLJHPD)
		{
			output.WriteRawTag(40);
			output.WriteBool(NIKEEDLJHPD);
		}
		if (CHCGMAMOBMH)
		{
			output.WriteRawTag(56);
			output.WriteBool(CHCGMAMOBMH);
		}
		if (AMADFJNHMFF != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(AMADFJNHMFF);
		}
		if (displayValue_ != null)
		{
			output.WriteRawTag(82);
			output.WriteMessage(DisplayValue);
		}
		kDIDNELEDJD_.WriteTo(ref output, _repeated_kDIDNELEDJD_codec);
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
		if (ArgId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ArgId);
		}
		if (NIKEEDLJHPD)
		{
			num += 2;
		}
		if (CHCGMAMOBMH)
		{
			num += 2;
		}
		if (AMADFJNHMFF != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AMADFJNHMFF);
		}
		if (displayValue_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(DisplayValue);
		}
		num += kDIDNELEDJD_.CalculateSize(_repeated_kDIDNELEDJD_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GBHHOMHNLKD other)
	{
		if (other == null)
		{
			return;
		}
		if (other.ArgId != 0)
		{
			ArgId = other.ArgId;
		}
		if (other.NIKEEDLJHPD)
		{
			NIKEEDLJHPD = other.NIKEEDLJHPD;
		}
		if (other.CHCGMAMOBMH)
		{
			CHCGMAMOBMH = other.CHCGMAMOBMH;
		}
		if (other.AMADFJNHMFF != 0)
		{
			AMADFJNHMFF = other.AMADFJNHMFF;
		}
		if (other.displayValue_ != null)
		{
			if (displayValue_ == null)
			{
				DisplayValue = new JKICLFBINHN();
			}
			DisplayValue.MergeFrom(other.DisplayValue);
		}
		kDIDNELEDJD_.Add(other.kDIDNELEDJD_);
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
			case 16u:
				ArgId = input.ReadUInt32();
				break;
			case 40u:
				NIKEEDLJHPD = input.ReadBool();
				break;
			case 56u:
				CHCGMAMOBMH = input.ReadBool();
				break;
			case 64u:
				AMADFJNHMFF = input.ReadUInt32();
				break;
			case 82u:
				if (displayValue_ == null)
				{
					DisplayValue = new JKICLFBINHN();
				}
				input.ReadMessage(DisplayValue);
				break;
			case 114u:
				kDIDNELEDJD_.AddEntriesFrom(ref input, _repeated_kDIDNELEDJD_codec);
				break;
			}
		}
	}
}
