using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class KIEGBDIBDCE : IMessage<KIEGBDIBDCE>, IMessage, IEquatable<KIEGBDIBDCE>, IDeepCloneable<KIEGBDIBDCE>, IBufferMessage
{
	private static readonly MessageParser<KIEGBDIBDCE> _parser = new MessageParser<KIEGBDIBDCE>(() => new KIEGBDIBDCE());

	private UnknownFieldSet _unknownFields;

	public const int EventIdFieldNumber = 7;

	private uint eventId_;

	public const int NMOECEHNLACFieldNumber = 10;

	private uint nMOECEHNLAC_;

	public const int KOEDCMICKNJFieldNumber = 11;

	private uint kOEDCMICKNJ_;

	public const int LPFDKHDHLCDFieldNumber = 12;

	private static readonly FieldCodec<uint> _repeated_lPFDKHDHLCD_codec = FieldCodec.ForUInt32(98u);

	private readonly RepeatedField<uint> lPFDKHDHLCD_ = new RepeatedField<uint>();

	public const int KEKAEPDEJJPFieldNumber = 13;

	private uint kEKAEPDEJJP_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<KIEGBDIBDCE> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => KIEGBDIBDCEReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint EventId
	{
		get
		{
			return eventId_;
		}
		set
		{
			eventId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint NMOECEHNLAC
	{
		get
		{
			return nMOECEHNLAC_;
		}
		set
		{
			nMOECEHNLAC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint KOEDCMICKNJ
	{
		get
		{
			return kOEDCMICKNJ_;
		}
		set
		{
			kOEDCMICKNJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> LPFDKHDHLCD => lPFDKHDHLCD_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint KEKAEPDEJJP
	{
		get
		{
			return kEKAEPDEJJP_;
		}
		set
		{
			kEKAEPDEJJP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KIEGBDIBDCE()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KIEGBDIBDCE(KIEGBDIBDCE other)
		: this()
	{
		eventId_ = other.eventId_;
		nMOECEHNLAC_ = other.nMOECEHNLAC_;
		kOEDCMICKNJ_ = other.kOEDCMICKNJ_;
		lPFDKHDHLCD_ = other.lPFDKHDHLCD_.Clone();
		kEKAEPDEJJP_ = other.kEKAEPDEJJP_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KIEGBDIBDCE Clone()
	{
		return new KIEGBDIBDCE(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as KIEGBDIBDCE);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(KIEGBDIBDCE other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (EventId != other.EventId)
		{
			return false;
		}
		if (NMOECEHNLAC != other.NMOECEHNLAC)
		{
			return false;
		}
		if (KOEDCMICKNJ != other.KOEDCMICKNJ)
		{
			return false;
		}
		if (!lPFDKHDHLCD_.Equals(other.lPFDKHDHLCD_))
		{
			return false;
		}
		if (KEKAEPDEJJP != other.KEKAEPDEJJP)
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
		if (EventId != 0)
		{
			num ^= EventId.GetHashCode();
		}
		if (NMOECEHNLAC != 0)
		{
			num ^= NMOECEHNLAC.GetHashCode();
		}
		if (KOEDCMICKNJ != 0)
		{
			num ^= KOEDCMICKNJ.GetHashCode();
		}
		num ^= lPFDKHDHLCD_.GetHashCode();
		if (KEKAEPDEJJP != 0)
		{
			num ^= KEKAEPDEJJP.GetHashCode();
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
		if (EventId != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(EventId);
		}
		if (NMOECEHNLAC != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(NMOECEHNLAC);
		}
		if (KOEDCMICKNJ != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(KOEDCMICKNJ);
		}
		lPFDKHDHLCD_.WriteTo(ref output, _repeated_lPFDKHDHLCD_codec);
		if (KEKAEPDEJJP != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(KEKAEPDEJJP);
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
		if (EventId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EventId);
		}
		if (NMOECEHNLAC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(NMOECEHNLAC);
		}
		if (KOEDCMICKNJ != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(KOEDCMICKNJ);
		}
		num += lPFDKHDHLCD_.CalculateSize(_repeated_lPFDKHDHLCD_codec);
		if (KEKAEPDEJJP != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(KEKAEPDEJJP);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(KIEGBDIBDCE other)
	{
		if (other != null)
		{
			if (other.EventId != 0)
			{
				EventId = other.EventId;
			}
			if (other.NMOECEHNLAC != 0)
			{
				NMOECEHNLAC = other.NMOECEHNLAC;
			}
			if (other.KOEDCMICKNJ != 0)
			{
				KOEDCMICKNJ = other.KOEDCMICKNJ;
			}
			lPFDKHDHLCD_.Add(other.lPFDKHDHLCD_);
			if (other.KEKAEPDEJJP != 0)
			{
				KEKAEPDEJJP = other.KEKAEPDEJJP;
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
			case 56u:
				EventId = input.ReadUInt32();
				break;
			case 80u:
				NMOECEHNLAC = input.ReadUInt32();
				break;
			case 88u:
				KOEDCMICKNJ = input.ReadUInt32();
				break;
			case 96u:
			case 98u:
				lPFDKHDHLCD_.AddEntriesFrom(ref input, _repeated_lPFDKHDHLCD_codec);
				break;
			case 104u:
				KEKAEPDEJJP = input.ReadUInt32();
				break;
			}
		}
	}
}
