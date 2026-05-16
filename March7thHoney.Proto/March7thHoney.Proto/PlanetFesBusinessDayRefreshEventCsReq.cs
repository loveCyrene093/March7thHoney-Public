using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class PlanetFesBusinessDayRefreshEventCsReq : IMessage<PlanetFesBusinessDayRefreshEventCsReq>, IMessage, IEquatable<PlanetFesBusinessDayRefreshEventCsReq>, IDeepCloneable<PlanetFesBusinessDayRefreshEventCsReq>, IBufferMessage
{
	private static readonly MessageParser<PlanetFesBusinessDayRefreshEventCsReq> _parser = new MessageParser<PlanetFesBusinessDayRefreshEventCsReq>(() => new PlanetFesBusinessDayRefreshEventCsReq());

	private UnknownFieldSet _unknownFields;

	public const int DGAHMJOBDNEFieldNumber = 1;

	private bool dGAHMJOBDNE_;

	public const int GAFPECGGICCFieldNumber = 5;

	private uint gAFPECGGICC_;

	public const int PHKAHAHLDAEFieldNumber = 7;

	private uint pHKAHAHLDAE_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PlanetFesBusinessDayRefreshEventCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PlanetFesBusinessDayRefreshEventCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool DGAHMJOBDNE
	{
		get
		{
			return dGAHMJOBDNE_;
		}
		set
		{
			dGAHMJOBDNE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GAFPECGGICC
	{
		get
		{
			return gAFPECGGICC_;
		}
		set
		{
			gAFPECGGICC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PHKAHAHLDAE
	{
		get
		{
			return pHKAHAHLDAE_;
		}
		set
		{
			pHKAHAHLDAE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlanetFesBusinessDayRefreshEventCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlanetFesBusinessDayRefreshEventCsReq(PlanetFesBusinessDayRefreshEventCsReq other)
		: this()
	{
		dGAHMJOBDNE_ = other.dGAHMJOBDNE_;
		gAFPECGGICC_ = other.gAFPECGGICC_;
		pHKAHAHLDAE_ = other.pHKAHAHLDAE_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlanetFesBusinessDayRefreshEventCsReq Clone()
	{
		return new PlanetFesBusinessDayRefreshEventCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PlanetFesBusinessDayRefreshEventCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PlanetFesBusinessDayRefreshEventCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (DGAHMJOBDNE != other.DGAHMJOBDNE)
		{
			return false;
		}
		if (GAFPECGGICC != other.GAFPECGGICC)
		{
			return false;
		}
		if (PHKAHAHLDAE != other.PHKAHAHLDAE)
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
		if (DGAHMJOBDNE)
		{
			num ^= DGAHMJOBDNE.GetHashCode();
		}
		if (GAFPECGGICC != 0)
		{
			num ^= GAFPECGGICC.GetHashCode();
		}
		if (PHKAHAHLDAE != 0)
		{
			num ^= PHKAHAHLDAE.GetHashCode();
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
		if (DGAHMJOBDNE)
		{
			output.WriteRawTag(8);
			output.WriteBool(DGAHMJOBDNE);
		}
		if (GAFPECGGICC != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(GAFPECGGICC);
		}
		if (PHKAHAHLDAE != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(PHKAHAHLDAE);
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
		if (DGAHMJOBDNE)
		{
			num += 2;
		}
		if (GAFPECGGICC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GAFPECGGICC);
		}
		if (PHKAHAHLDAE != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PHKAHAHLDAE);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PlanetFesBusinessDayRefreshEventCsReq other)
	{
		if (other != null)
		{
			if (other.DGAHMJOBDNE)
			{
				DGAHMJOBDNE = other.DGAHMJOBDNE;
			}
			if (other.GAFPECGGICC != 0)
			{
				GAFPECGGICC = other.GAFPECGGICC;
			}
			if (other.PHKAHAHLDAE != 0)
			{
				PHKAHAHLDAE = other.PHKAHAHLDAE;
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
			case 8u:
				DGAHMJOBDNE = input.ReadBool();
				break;
			case 40u:
				GAFPECGGICC = input.ReadUInt32();
				break;
			case 56u:
				PHKAHAHLDAE = input.ReadUInt32();
				break;
			}
		}
	}
}
