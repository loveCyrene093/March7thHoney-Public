using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class PlanetFesLargeBonusInteractCsReq : IMessage<PlanetFesLargeBonusInteractCsReq>, IMessage, IEquatable<PlanetFesLargeBonusInteractCsReq>, IDeepCloneable<PlanetFesLargeBonusInteractCsReq>, IBufferMessage
{
	private static readonly MessageParser<PlanetFesLargeBonusInteractCsReq> _parser = new MessageParser<PlanetFesLargeBonusInteractCsReq>(() => new PlanetFesLargeBonusInteractCsReq());

	private UnknownFieldSet _unknownFields;

	public const int HGIAGJMHDOBFieldNumber = 9;

	private uint hGIAGJMHDOB_;

	public const int PFOPCGAKMJPFieldNumber = 12;

	private uint pFOPCGAKMJP_;

	public const int BCOPJHFNDBFFieldNumber = 14;

	private uint bCOPJHFNDBF_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PlanetFesLargeBonusInteractCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PlanetFesLargeBonusInteractCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint HGIAGJMHDOB
	{
		get
		{
			return hGIAGJMHDOB_;
		}
		set
		{
			hGIAGJMHDOB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PFOPCGAKMJP
	{
		get
		{
			return pFOPCGAKMJP_;
		}
		set
		{
			pFOPCGAKMJP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint BCOPJHFNDBF
	{
		get
		{
			return bCOPJHFNDBF_;
		}
		set
		{
			bCOPJHFNDBF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlanetFesLargeBonusInteractCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlanetFesLargeBonusInteractCsReq(PlanetFesLargeBonusInteractCsReq other)
		: this()
	{
		hGIAGJMHDOB_ = other.hGIAGJMHDOB_;
		pFOPCGAKMJP_ = other.pFOPCGAKMJP_;
		bCOPJHFNDBF_ = other.bCOPJHFNDBF_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlanetFesLargeBonusInteractCsReq Clone()
	{
		return new PlanetFesLargeBonusInteractCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PlanetFesLargeBonusInteractCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PlanetFesLargeBonusInteractCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (HGIAGJMHDOB != other.HGIAGJMHDOB)
		{
			return false;
		}
		if (PFOPCGAKMJP != other.PFOPCGAKMJP)
		{
			return false;
		}
		if (BCOPJHFNDBF != other.BCOPJHFNDBF)
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
		if (HGIAGJMHDOB != 0)
		{
			num ^= HGIAGJMHDOB.GetHashCode();
		}
		if (PFOPCGAKMJP != 0)
		{
			num ^= PFOPCGAKMJP.GetHashCode();
		}
		if (BCOPJHFNDBF != 0)
		{
			num ^= BCOPJHFNDBF.GetHashCode();
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
		if (HGIAGJMHDOB != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(HGIAGJMHDOB);
		}
		if (PFOPCGAKMJP != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(PFOPCGAKMJP);
		}
		if (BCOPJHFNDBF != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(BCOPJHFNDBF);
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
		if (HGIAGJMHDOB != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(HGIAGJMHDOB);
		}
		if (PFOPCGAKMJP != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PFOPCGAKMJP);
		}
		if (BCOPJHFNDBF != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BCOPJHFNDBF);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PlanetFesLargeBonusInteractCsReq other)
	{
		if (other != null)
		{
			if (other.HGIAGJMHDOB != 0)
			{
				HGIAGJMHDOB = other.HGIAGJMHDOB;
			}
			if (other.PFOPCGAKMJP != 0)
			{
				PFOPCGAKMJP = other.PFOPCGAKMJP;
			}
			if (other.BCOPJHFNDBF != 0)
			{
				BCOPJHFNDBF = other.BCOPJHFNDBF;
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
			case 72u:
				HGIAGJMHDOB = input.ReadUInt32();
				break;
			case 96u:
				PFOPCGAKMJP = input.ReadUInt32();
				break;
			case 112u:
				BCOPJHFNDBF = input.ReadUInt32();
				break;
			}
		}
	}
}
