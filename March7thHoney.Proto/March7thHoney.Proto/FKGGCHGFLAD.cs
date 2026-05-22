using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class FKGGCHGFLAD : IMessage<FKGGCHGFLAD>, IMessage, IEquatable<FKGGCHGFLAD>, IDeepCloneable<FKGGCHGFLAD>, IBufferMessage
{
	private static readonly MessageParser<FKGGCHGFLAD> _parser = new MessageParser<FKGGCHGFLAD>(() => new FKGGCHGFLAD());

	private UnknownFieldSet _unknownFields;

	public const int AONGOEAFKOCFieldNumber = 3;

	private uint aONGOEAFKOC_;

	public const int IdFieldNumber = 7;

	private uint id_;

	public const int LMIICENMOBIFieldNumber = 10;

	private uint lMIICENMOBI_;

	public const int DHLDKLMPHNGFieldNumber = 12;

	private uint dHLDKLMPHNG_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FKGGCHGFLAD> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => FKGGCHGFLADReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint AONGOEAFKOC
	{
		get
		{
			return aONGOEAFKOC_;
		}
		set
		{
			aONGOEAFKOC_ = value;
		}
	}

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
	public uint LMIICENMOBI
	{
		get
		{
			return lMIICENMOBI_;
		}
		set
		{
			lMIICENMOBI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint DHLDKLMPHNG
	{
		get
		{
			return dHLDKLMPHNG_;
		}
		set
		{
			dHLDKLMPHNG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FKGGCHGFLAD()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FKGGCHGFLAD(FKGGCHGFLAD other)
		: this()
	{
		aONGOEAFKOC_ = other.aONGOEAFKOC_;
		id_ = other.id_;
		lMIICENMOBI_ = other.lMIICENMOBI_;
		dHLDKLMPHNG_ = other.dHLDKLMPHNG_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FKGGCHGFLAD Clone()
	{
		return new FKGGCHGFLAD(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as FKGGCHGFLAD);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FKGGCHGFLAD other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (AONGOEAFKOC != other.AONGOEAFKOC)
		{
			return false;
		}
		if (Id != other.Id)
		{
			return false;
		}
		if (LMIICENMOBI != other.LMIICENMOBI)
		{
			return false;
		}
		if (DHLDKLMPHNG != other.DHLDKLMPHNG)
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
		if (AONGOEAFKOC != 0)
		{
			num ^= AONGOEAFKOC.GetHashCode();
		}
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (LMIICENMOBI != 0)
		{
			num ^= LMIICENMOBI.GetHashCode();
		}
		if (DHLDKLMPHNG != 0)
		{
			num ^= DHLDKLMPHNG.GetHashCode();
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
		if (AONGOEAFKOC != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(AONGOEAFKOC);
		}
		if (Id != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(Id);
		}
		if (LMIICENMOBI != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(LMIICENMOBI);
		}
		if (DHLDKLMPHNG != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(DHLDKLMPHNG);
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
		if (AONGOEAFKOC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AONGOEAFKOC);
		}
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Id);
		}
		if (LMIICENMOBI != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LMIICENMOBI);
		}
		if (DHLDKLMPHNG != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DHLDKLMPHNG);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FKGGCHGFLAD other)
	{
		if (other != null)
		{
			if (other.AONGOEAFKOC != 0)
			{
				AONGOEAFKOC = other.AONGOEAFKOC;
			}
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.LMIICENMOBI != 0)
			{
				LMIICENMOBI = other.LMIICENMOBI;
			}
			if (other.DHLDKLMPHNG != 0)
			{
				DHLDKLMPHNG = other.DHLDKLMPHNG;
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
			case 24u:
				AONGOEAFKOC = input.ReadUInt32();
				break;
			case 56u:
				Id = input.ReadUInt32();
				break;
			case 80u:
				LMIICENMOBI = input.ReadUInt32();
				break;
			case 96u:
				DHLDKLMPHNG = input.ReadUInt32();
				break;
			}
		}
	}
}
