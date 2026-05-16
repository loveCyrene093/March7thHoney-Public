using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class OFPGJKEDKEB : IMessage<OFPGJKEDKEB>, IMessage, IEquatable<OFPGJKEDKEB>, IDeepCloneable<OFPGJKEDKEB>, IBufferMessage
{
	public enum BGGBIMBKHEIOneofCase
	{
		None = 0,
		ANLLMAPBJFN = 781,
		DJGAPFPHFII = 1306,
		MBOGNPKAMIF = 1394,
		BDPHIHBLJON = 1672
	}

	private static readonly MessageParser<OFPGJKEDKEB> _parser = new MessageParser<OFPGJKEDKEB>(() => new OFPGJKEDKEB());

	private UnknownFieldSet _unknownFields;

	public const int QueuePositionFieldNumber = 7;

	private uint queuePosition_;

	public const int ANLLMAPBJFNFieldNumber = 781;

	public const int DJGAPFPHFIIFieldNumber = 1306;

	public const int MBOGNPKAMIFFieldNumber = 1394;

	public const int BDPHIHBLJONFieldNumber = 1672;

	private object bGGBIMBKHEI_;

	private BGGBIMBKHEIOneofCase bGGBIMBKHEICase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<OFPGJKEDKEB> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => OFPGJKEDKEBReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint QueuePosition
	{
		get
		{
			return queuePosition_;
		}
		set
		{
			queuePosition_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GDEEEEAGDIP ANLLMAPBJFN
	{
		get
		{
			if (bGGBIMBKHEICase_ != BGGBIMBKHEIOneofCase.ANLLMAPBJFN)
			{
				return null;
			}
			return (GDEEEEAGDIP)bGGBIMBKHEI_;
		}
		set
		{
			bGGBIMBKHEI_ = value;
			bGGBIMBKHEICase_ = ((value != null) ? BGGBIMBKHEIOneofCase.ANLLMAPBJFN : BGGBIMBKHEIOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CHDHAFCLEDB DJGAPFPHFII
	{
		get
		{
			if (bGGBIMBKHEICase_ != BGGBIMBKHEIOneofCase.DJGAPFPHFII)
			{
				return null;
			}
			return (CHDHAFCLEDB)bGGBIMBKHEI_;
		}
		set
		{
			bGGBIMBKHEI_ = value;
			bGGBIMBKHEICase_ = ((value != null) ? BGGBIMBKHEIOneofCase.DJGAPFPHFII : BGGBIMBKHEIOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GHNALAMKDLA MBOGNPKAMIF
	{
		get
		{
			if (bGGBIMBKHEICase_ != BGGBIMBKHEIOneofCase.MBOGNPKAMIF)
			{
				return null;
			}
			return (GHNALAMKDLA)bGGBIMBKHEI_;
		}
		set
		{
			bGGBIMBKHEI_ = value;
			bGGBIMBKHEICase_ = ((value != null) ? BGGBIMBKHEIOneofCase.MBOGNPKAMIF : BGGBIMBKHEIOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KEGJMEJBNCJ BDPHIHBLJON
	{
		get
		{
			if (bGGBIMBKHEICase_ != BGGBIMBKHEIOneofCase.BDPHIHBLJON)
			{
				return null;
			}
			return (KEGJMEJBNCJ)bGGBIMBKHEI_;
		}
		set
		{
			bGGBIMBKHEI_ = value;
			bGGBIMBKHEICase_ = ((value != null) ? BGGBIMBKHEIOneofCase.BDPHIHBLJON : BGGBIMBKHEIOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BGGBIMBKHEIOneofCase BGGBIMBKHEICase => bGGBIMBKHEICase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OFPGJKEDKEB()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OFPGJKEDKEB(OFPGJKEDKEB other)
		: this()
	{
		queuePosition_ = other.queuePosition_;
		switch (other.BGGBIMBKHEICase)
		{
		case BGGBIMBKHEIOneofCase.ANLLMAPBJFN:
			ANLLMAPBJFN = other.ANLLMAPBJFN.Clone();
			break;
		case BGGBIMBKHEIOneofCase.DJGAPFPHFII:
			DJGAPFPHFII = other.DJGAPFPHFII.Clone();
			break;
		case BGGBIMBKHEIOneofCase.MBOGNPKAMIF:
			MBOGNPKAMIF = other.MBOGNPKAMIF.Clone();
			break;
		case BGGBIMBKHEIOneofCase.BDPHIHBLJON:
			BDPHIHBLJON = other.BDPHIHBLJON.Clone();
			break;
		}
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OFPGJKEDKEB Clone()
	{
		return new OFPGJKEDKEB(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearBGGBIMBKHEI()
	{
		bGGBIMBKHEICase_ = BGGBIMBKHEIOneofCase.None;
		bGGBIMBKHEI_ = null;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as OFPGJKEDKEB);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(OFPGJKEDKEB other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (QueuePosition != other.QueuePosition)
		{
			return false;
		}
		if (!object.Equals(ANLLMAPBJFN, other.ANLLMAPBJFN))
		{
			return false;
		}
		if (!object.Equals(DJGAPFPHFII, other.DJGAPFPHFII))
		{
			return false;
		}
		if (!object.Equals(MBOGNPKAMIF, other.MBOGNPKAMIF))
		{
			return false;
		}
		if (!object.Equals(BDPHIHBLJON, other.BDPHIHBLJON))
		{
			return false;
		}
		if (BGGBIMBKHEICase != other.BGGBIMBKHEICase)
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
		if (QueuePosition != 0)
		{
			num ^= QueuePosition.GetHashCode();
		}
		if (bGGBIMBKHEICase_ == BGGBIMBKHEIOneofCase.ANLLMAPBJFN)
		{
			num ^= ANLLMAPBJFN.GetHashCode();
		}
		if (bGGBIMBKHEICase_ == BGGBIMBKHEIOneofCase.DJGAPFPHFII)
		{
			num ^= DJGAPFPHFII.GetHashCode();
		}
		if (bGGBIMBKHEICase_ == BGGBIMBKHEIOneofCase.MBOGNPKAMIF)
		{
			num ^= MBOGNPKAMIF.GetHashCode();
		}
		if (bGGBIMBKHEICase_ == BGGBIMBKHEIOneofCase.BDPHIHBLJON)
		{
			num ^= BDPHIHBLJON.GetHashCode();
		}
		num ^= (int)bGGBIMBKHEICase_;
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
		if (QueuePosition != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(QueuePosition);
		}
		if (bGGBIMBKHEICase_ == BGGBIMBKHEIOneofCase.ANLLMAPBJFN)
		{
			output.WriteRawTag(234, 48);
			output.WriteMessage(ANLLMAPBJFN);
		}
		if (bGGBIMBKHEICase_ == BGGBIMBKHEIOneofCase.DJGAPFPHFII)
		{
			output.WriteRawTag(210, 81);
			output.WriteMessage(DJGAPFPHFII);
		}
		if (bGGBIMBKHEICase_ == BGGBIMBKHEIOneofCase.MBOGNPKAMIF)
		{
			output.WriteRawTag(146, 87);
			output.WriteMessage(MBOGNPKAMIF);
		}
		if (bGGBIMBKHEICase_ == BGGBIMBKHEIOneofCase.BDPHIHBLJON)
		{
			output.WriteRawTag(194, 104);
			output.WriteMessage(BDPHIHBLJON);
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
		if (QueuePosition != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(QueuePosition);
		}
		if (bGGBIMBKHEICase_ == BGGBIMBKHEIOneofCase.ANLLMAPBJFN)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(ANLLMAPBJFN);
		}
		if (bGGBIMBKHEICase_ == BGGBIMBKHEIOneofCase.DJGAPFPHFII)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(DJGAPFPHFII);
		}
		if (bGGBIMBKHEICase_ == BGGBIMBKHEIOneofCase.MBOGNPKAMIF)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(MBOGNPKAMIF);
		}
		if (bGGBIMBKHEICase_ == BGGBIMBKHEIOneofCase.BDPHIHBLJON)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(BDPHIHBLJON);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(OFPGJKEDKEB other)
	{
		if (other == null)
		{
			return;
		}
		if (other.QueuePosition != 0)
		{
			QueuePosition = other.QueuePosition;
		}
		switch (other.BGGBIMBKHEICase)
		{
		case BGGBIMBKHEIOneofCase.ANLLMAPBJFN:
			if (ANLLMAPBJFN == null)
			{
				ANLLMAPBJFN = new GDEEEEAGDIP();
			}
			ANLLMAPBJFN.MergeFrom(other.ANLLMAPBJFN);
			break;
		case BGGBIMBKHEIOneofCase.DJGAPFPHFII:
			if (DJGAPFPHFII == null)
			{
				DJGAPFPHFII = new CHDHAFCLEDB();
			}
			DJGAPFPHFII.MergeFrom(other.DJGAPFPHFII);
			break;
		case BGGBIMBKHEIOneofCase.MBOGNPKAMIF:
			if (MBOGNPKAMIF == null)
			{
				MBOGNPKAMIF = new GHNALAMKDLA();
			}
			MBOGNPKAMIF.MergeFrom(other.MBOGNPKAMIF);
			break;
		case BGGBIMBKHEIOneofCase.BDPHIHBLJON:
			if (BDPHIHBLJON == null)
			{
				BDPHIHBLJON = new KEGJMEJBNCJ();
			}
			BDPHIHBLJON.MergeFrom(other.BDPHIHBLJON);
			break;
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
			case 56u:
				QueuePosition = input.ReadUInt32();
				break;
			case 6250u:
			{
				GDEEEEAGDIP gDEEEEAGDIP = new GDEEEEAGDIP();
				if (bGGBIMBKHEICase_ == BGGBIMBKHEIOneofCase.ANLLMAPBJFN)
				{
					gDEEEEAGDIP.MergeFrom(ANLLMAPBJFN);
				}
				input.ReadMessage(gDEEEEAGDIP);
				ANLLMAPBJFN = gDEEEEAGDIP;
				break;
			}
			case 10450u:
			{
				CHDHAFCLEDB cHDHAFCLEDB = new CHDHAFCLEDB();
				if (bGGBIMBKHEICase_ == BGGBIMBKHEIOneofCase.DJGAPFPHFII)
				{
					cHDHAFCLEDB.MergeFrom(DJGAPFPHFII);
				}
				input.ReadMessage(cHDHAFCLEDB);
				DJGAPFPHFII = cHDHAFCLEDB;
				break;
			}
			case 11154u:
			{
				GHNALAMKDLA gHNALAMKDLA = new GHNALAMKDLA();
				if (bGGBIMBKHEICase_ == BGGBIMBKHEIOneofCase.MBOGNPKAMIF)
				{
					gHNALAMKDLA.MergeFrom(MBOGNPKAMIF);
				}
				input.ReadMessage(gHNALAMKDLA);
				MBOGNPKAMIF = gHNALAMKDLA;
				break;
			}
			case 13378u:
			{
				KEGJMEJBNCJ kEGJMEJBNCJ = new KEGJMEJBNCJ();
				if (bGGBIMBKHEICase_ == BGGBIMBKHEIOneofCase.BDPHIHBLJON)
				{
					kEGJMEJBNCJ.MergeFrom(BDPHIHBLJON);
				}
				input.ReadMessage(kEGJMEJBNCJ);
				BDPHIHBLJON = kEGJMEJBNCJ;
				break;
			}
			}
		}
	}
}
