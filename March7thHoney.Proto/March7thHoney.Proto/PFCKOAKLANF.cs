using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class PFCKOAKLANF : IMessage<PFCKOAKLANF>, IMessage, IEquatable<PFCKOAKLANF>, IDeepCloneable<PFCKOAKLANF>, IBufferMessage
{
	private static readonly MessageParser<PFCKOAKLANF> _parser = new MessageParser<PFCKOAKLANF>(() => new PFCKOAKLANF());

	private UnknownFieldSet _unknownFields;

	public const int AMADFJNHMFFFieldNumber = 7;

	private uint aMADFJNHMFF_;

	public const int EventIdFieldNumber = 9;

	private uint eventId_;

	public const int LPFDKHDHLCDFieldNumber = 12;

	private static readonly FieldCodec<uint> _repeated_lPFDKHDHLCD_codec = FieldCodec.ForUInt32(98u);

	private readonly RepeatedField<uint> lPFDKHDHLCD_ = new RepeatedField<uint>();

	public const int KEKAEPDEJJPFieldNumber = 14;

	private uint kEKAEPDEJJP_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PFCKOAKLANF> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PFCKOAKLANFReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public PFCKOAKLANF()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PFCKOAKLANF(PFCKOAKLANF other)
		: this()
	{
		aMADFJNHMFF_ = other.aMADFJNHMFF_;
		eventId_ = other.eventId_;
		lPFDKHDHLCD_ = other.lPFDKHDHLCD_.Clone();
		kEKAEPDEJJP_ = other.kEKAEPDEJJP_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PFCKOAKLANF Clone()
	{
		return new PFCKOAKLANF(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PFCKOAKLANF);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PFCKOAKLANF other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (AMADFJNHMFF != other.AMADFJNHMFF)
		{
			return false;
		}
		if (EventId != other.EventId)
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
		if (AMADFJNHMFF != 0)
		{
			num ^= AMADFJNHMFF.GetHashCode();
		}
		if (EventId != 0)
		{
			num ^= EventId.GetHashCode();
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
		if (AMADFJNHMFF != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(AMADFJNHMFF);
		}
		if (EventId != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(EventId);
		}
		lPFDKHDHLCD_.WriteTo(ref output, _repeated_lPFDKHDHLCD_codec);
		if (KEKAEPDEJJP != 0)
		{
			output.WriteRawTag(112);
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
		if (AMADFJNHMFF != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AMADFJNHMFF);
		}
		if (EventId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EventId);
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
	public void MergeFrom(PFCKOAKLANF other)
	{
		if (other != null)
		{
			if (other.AMADFJNHMFF != 0)
			{
				AMADFJNHMFF = other.AMADFJNHMFF;
			}
			if (other.EventId != 0)
			{
				EventId = other.EventId;
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
				AMADFJNHMFF = input.ReadUInt32();
				break;
			case 72u:
				EventId = input.ReadUInt32();
				break;
			case 96u:
			case 98u:
				lPFDKHDHLCD_.AddEntriesFrom(ref input, _repeated_lPFDKHDHLCD_codec);
				break;
			case 112u:
				KEKAEPDEJJP = input.ReadUInt32();
				break;
			}
		}
	}
}
