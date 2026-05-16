using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GDMLNIJOFEE : IMessage<GDMLNIJOFEE>, IMessage, IEquatable<GDMLNIJOFEE>, IDeepCloneable<GDMLNIJOFEE>, IBufferMessage
{
	private static readonly MessageParser<GDMLNIJOFEE> _parser = new MessageParser<GDMLNIJOFEE>(() => new GDMLNIJOFEE());

	private UnknownFieldSet _unknownFields;

	public const int FELEPKCAFPAFieldNumber = 4;

	private bool fELEPKCAFPA_;

	public const int ADKBEOPNBIOFieldNumber = 7;

	private bool aDKBEOPNBIO_;

	public const int IsTakenRewardFieldNumber = 8;

	private bool isTakenReward_;

	public const int CEBPAJAAJPPFieldNumber = 10;

	private bool cEBPAJAAJPP_;

	public const int AreaIdFieldNumber = 11;

	private uint areaId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GDMLNIJOFEE> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GDMLNIJOFEEReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool FELEPKCAFPA
	{
		get
		{
			return fELEPKCAFPA_;
		}
		set
		{
			fELEPKCAFPA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool ADKBEOPNBIO
	{
		get
		{
			return aDKBEOPNBIO_;
		}
		set
		{
			aDKBEOPNBIO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool IsTakenReward
	{
		get
		{
			return isTakenReward_;
		}
		set
		{
			isTakenReward_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool CEBPAJAAJPP
	{
		get
		{
			return cEBPAJAAJPP_;
		}
		set
		{
			cEBPAJAAJPP_ = value;
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
	public GDMLNIJOFEE()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GDMLNIJOFEE(GDMLNIJOFEE other)
		: this()
	{
		fELEPKCAFPA_ = other.fELEPKCAFPA_;
		aDKBEOPNBIO_ = other.aDKBEOPNBIO_;
		isTakenReward_ = other.isTakenReward_;
		cEBPAJAAJPP_ = other.cEBPAJAAJPP_;
		areaId_ = other.areaId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GDMLNIJOFEE Clone()
	{
		return new GDMLNIJOFEE(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GDMLNIJOFEE);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GDMLNIJOFEE other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (FELEPKCAFPA != other.FELEPKCAFPA)
		{
			return false;
		}
		if (ADKBEOPNBIO != other.ADKBEOPNBIO)
		{
			return false;
		}
		if (IsTakenReward != other.IsTakenReward)
		{
			return false;
		}
		if (CEBPAJAAJPP != other.CEBPAJAAJPP)
		{
			return false;
		}
		if (AreaId != other.AreaId)
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
		if (FELEPKCAFPA)
		{
			num ^= FELEPKCAFPA.GetHashCode();
		}
		if (ADKBEOPNBIO)
		{
			num ^= ADKBEOPNBIO.GetHashCode();
		}
		if (IsTakenReward)
		{
			num ^= IsTakenReward.GetHashCode();
		}
		if (CEBPAJAAJPP)
		{
			num ^= CEBPAJAAJPP.GetHashCode();
		}
		if (AreaId != 0)
		{
			num ^= AreaId.GetHashCode();
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
		if (FELEPKCAFPA)
		{
			output.WriteRawTag(32);
			output.WriteBool(FELEPKCAFPA);
		}
		if (ADKBEOPNBIO)
		{
			output.WriteRawTag(56);
			output.WriteBool(ADKBEOPNBIO);
		}
		if (IsTakenReward)
		{
			output.WriteRawTag(64);
			output.WriteBool(IsTakenReward);
		}
		if (CEBPAJAAJPP)
		{
			output.WriteRawTag(80);
			output.WriteBool(CEBPAJAAJPP);
		}
		if (AreaId != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(AreaId);
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
		if (FELEPKCAFPA)
		{
			num += 2;
		}
		if (ADKBEOPNBIO)
		{
			num += 2;
		}
		if (IsTakenReward)
		{
			num += 2;
		}
		if (CEBPAJAAJPP)
		{
			num += 2;
		}
		if (AreaId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AreaId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GDMLNIJOFEE other)
	{
		if (other != null)
		{
			if (other.FELEPKCAFPA)
			{
				FELEPKCAFPA = other.FELEPKCAFPA;
			}
			if (other.ADKBEOPNBIO)
			{
				ADKBEOPNBIO = other.ADKBEOPNBIO;
			}
			if (other.IsTakenReward)
			{
				IsTakenReward = other.IsTakenReward;
			}
			if (other.CEBPAJAAJPP)
			{
				CEBPAJAAJPP = other.CEBPAJAAJPP;
			}
			if (other.AreaId != 0)
			{
				AreaId = other.AreaId;
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
			case 32u:
				FELEPKCAFPA = input.ReadBool();
				break;
			case 56u:
				ADKBEOPNBIO = input.ReadBool();
				break;
			case 64u:
				IsTakenReward = input.ReadBool();
				break;
			case 80u:
				CEBPAJAAJPP = input.ReadBool();
				break;
			case 88u:
				AreaId = input.ReadUInt32();
				break;
			}
		}
	}
}
