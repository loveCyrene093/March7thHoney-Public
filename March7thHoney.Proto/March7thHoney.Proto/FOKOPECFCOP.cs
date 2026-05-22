using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class FOKOPECFCOP : IMessage<FOKOPECFCOP>, IMessage, IEquatable<FOKOPECFCOP>, IDeepCloneable<FOKOPECFCOP>, IBufferMessage
{
	private static readonly MessageParser<FOKOPECFCOP> _parser = new MessageParser<FOKOPECFCOP>(() => new FOKOPECFCOP());

	private UnknownFieldSet _unknownFields;

	public const int LevelFieldNumber = 2;

	private uint level_;

	public const int BODAPOLFADFFieldNumber = 5;

	private static readonly FieldCodec<AEIMINCOFHF> _repeated_bODAPOLFADF_codec = FieldCodec.ForMessage(42u, AEIMINCOFHF.Parser);

	private readonly RepeatedField<AEIMINCOFHF> bODAPOLFADF_ = new RepeatedField<AEIMINCOFHF>();

	public const int ENNGNAMEBJCFieldNumber = 6;

	private uint eNNGNAMEBJC_;

	public const int KDFMIFKALKHFieldNumber = 7;

	private uint kDFMIFKALKH_;

	public const int AreaIdFieldNumber = 11;

	private uint areaId_;

	public const int GPONHJHHMBBFieldNumber = 13;

	private uint gPONHJHHMBB_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FOKOPECFCOP> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => FOKOPECFCOPReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Level
	{
		get
		{
			return level_;
		}
		set
		{
			level_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<AEIMINCOFHF> BODAPOLFADF => bODAPOLFADF_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ENNGNAMEBJC
	{
		get
		{
			return eNNGNAMEBJC_;
		}
		set
		{
			eNNGNAMEBJC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint KDFMIFKALKH
	{
		get
		{
			return kDFMIFKALKH_;
		}
		set
		{
			kDFMIFKALKH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint AreaId
	{
		get
		{
			return areaId_;
		}
		set
		{
			areaId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GPONHJHHMBB
	{
		get
		{
			return gPONHJHHMBB_;
		}
		set
		{
			gPONHJHHMBB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FOKOPECFCOP()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FOKOPECFCOP(FOKOPECFCOP other)
		: this()
	{
		level_ = other.level_;
		bODAPOLFADF_ = other.bODAPOLFADF_.Clone();
		eNNGNAMEBJC_ = other.eNNGNAMEBJC_;
		kDFMIFKALKH_ = other.kDFMIFKALKH_;
		areaId_ = other.areaId_;
		gPONHJHHMBB_ = other.gPONHJHHMBB_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FOKOPECFCOP Clone()
	{
		return new FOKOPECFCOP(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as FOKOPECFCOP);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FOKOPECFCOP other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Level != other.Level)
		{
			return false;
		}
		if (!bODAPOLFADF_.Equals(other.bODAPOLFADF_))
		{
			return false;
		}
		if (ENNGNAMEBJC != other.ENNGNAMEBJC)
		{
			return false;
		}
		if (KDFMIFKALKH != other.KDFMIFKALKH)
		{
			return false;
		}
		if (AreaId != other.AreaId)
		{
			return false;
		}
		if (GPONHJHHMBB != other.GPONHJHHMBB)
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
		if (Level != 0)
		{
			num ^= Level.GetHashCode();
		}
		num ^= bODAPOLFADF_.GetHashCode();
		if (ENNGNAMEBJC != 0)
		{
			num ^= ENNGNAMEBJC.GetHashCode();
		}
		if (KDFMIFKALKH != 0)
		{
			num ^= KDFMIFKALKH.GetHashCode();
		}
		if (AreaId != 0)
		{
			num ^= AreaId.GetHashCode();
		}
		if (GPONHJHHMBB != 0)
		{
			num ^= GPONHJHHMBB.GetHashCode();
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
		if (Level != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(Level);
		}
		bODAPOLFADF_.WriteTo(ref output, _repeated_bODAPOLFADF_codec);
		if (ENNGNAMEBJC != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(ENNGNAMEBJC);
		}
		if (KDFMIFKALKH != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(KDFMIFKALKH);
		}
		if (AreaId != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(AreaId);
		}
		if (GPONHJHHMBB != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(GPONHJHHMBB);
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
		if (Level != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Level);
		}
		num += bODAPOLFADF_.CalculateSize(_repeated_bODAPOLFADF_codec);
		if (ENNGNAMEBJC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ENNGNAMEBJC);
		}
		if (KDFMIFKALKH != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(KDFMIFKALKH);
		}
		if (AreaId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AreaId);
		}
		if (GPONHJHHMBB != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GPONHJHHMBB);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FOKOPECFCOP other)
	{
		if (other != null)
		{
			if (other.Level != 0)
			{
				Level = other.Level;
			}
			bODAPOLFADF_.Add(other.bODAPOLFADF_);
			if (other.ENNGNAMEBJC != 0)
			{
				ENNGNAMEBJC = other.ENNGNAMEBJC;
			}
			if (other.KDFMIFKALKH != 0)
			{
				KDFMIFKALKH = other.KDFMIFKALKH;
			}
			if (other.AreaId != 0)
			{
				AreaId = other.AreaId;
			}
			if (other.GPONHJHHMBB != 0)
			{
				GPONHJHHMBB = other.GPONHJHHMBB;
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
			case 16u:
				Level = input.ReadUInt32();
				break;
			case 42u:
				bODAPOLFADF_.AddEntriesFrom(ref input, _repeated_bODAPOLFADF_codec);
				break;
			case 48u:
				ENNGNAMEBJC = input.ReadUInt32();
				break;
			case 56u:
				KDFMIFKALKH = input.ReadUInt32();
				break;
			case 88u:
				AreaId = input.ReadUInt32();
				break;
			case 104u:
				GPONHJHHMBB = input.ReadUInt32();
				break;
			}
		}
	}
}
