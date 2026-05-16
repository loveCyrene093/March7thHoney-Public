using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class BenefitData : IMessage<BenefitData>, IMessage, IEquatable<BenefitData>, IDeepCloneable<BenefitData>, IBufferMessage
{
	private static readonly MessageParser<BenefitData> _parser = new MessageParser<BenefitData>(() => new BenefitData());

	private UnknownFieldSet _unknownFields;

	public const int LevelFieldNumber = 2;

	private uint level_;

	public const int ODLBOKHDANLFieldNumber = 3;

	private FHBFFIFIPOA oDLBOKHDANL_;

	public const int StatusFieldNumber = 4;

	private uint status_;

	public const int COOOFFKIDMCFieldNumber = 7;

	private uint cOOOFFKIDMC_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<BenefitData> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => BenefitDataReflection.Descriptor.MessageTypes[0];

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
	public FHBFFIFIPOA ODLBOKHDANL
	{
		get
		{
			return oDLBOKHDANL_;
		}
		set
		{
			oDLBOKHDANL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Status
	{
		get
		{
			return status_;
		}
		set
		{
			status_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint COOOFFKIDMC
	{
		get
		{
			return cOOOFFKIDMC_;
		}
		set
		{
			cOOOFFKIDMC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BenefitData()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BenefitData(BenefitData other)
		: this()
	{
		level_ = other.level_;
		oDLBOKHDANL_ = ((other.oDLBOKHDANL_ != null) ? other.oDLBOKHDANL_.Clone() : null);
		status_ = other.status_;
		cOOOFFKIDMC_ = other.cOOOFFKIDMC_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BenefitData Clone()
	{
		return new BenefitData(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as BenefitData);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(BenefitData other)
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
		if (!object.Equals(ODLBOKHDANL, other.ODLBOKHDANL))
		{
			return false;
		}
		if (Status != other.Status)
		{
			return false;
		}
		if (COOOFFKIDMC != other.COOOFFKIDMC)
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
		if (oDLBOKHDANL_ != null)
		{
			num ^= ODLBOKHDANL.GetHashCode();
		}
		if (Status != 0)
		{
			num ^= Status.GetHashCode();
		}
		if (COOOFFKIDMC != 0)
		{
			num ^= COOOFFKIDMC.GetHashCode();
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
		if (oDLBOKHDANL_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(ODLBOKHDANL);
		}
		if (Status != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(Status);
		}
		if (COOOFFKIDMC != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(COOOFFKIDMC);
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
		if (oDLBOKHDANL_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ODLBOKHDANL);
		}
		if (Status != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Status);
		}
		if (COOOFFKIDMC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(COOOFFKIDMC);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(BenefitData other)
	{
		if (other == null)
		{
			return;
		}
		if (other.Level != 0)
		{
			Level = other.Level;
		}
		if (other.oDLBOKHDANL_ != null)
		{
			if (oDLBOKHDANL_ == null)
			{
				ODLBOKHDANL = new FHBFFIFIPOA();
			}
			ODLBOKHDANL.MergeFrom(other.ODLBOKHDANL);
		}
		if (other.Status != 0)
		{
			Status = other.Status;
		}
		if (other.COOOFFKIDMC != 0)
		{
			COOOFFKIDMC = other.COOOFFKIDMC;
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
			case 16u:
				Level = input.ReadUInt32();
				break;
			case 26u:
				if (oDLBOKHDANL_ == null)
				{
					ODLBOKHDANL = new FHBFFIFIPOA();
				}
				input.ReadMessage(ODLBOKHDANL);
				break;
			case 32u:
				Status = input.ReadUInt32();
				break;
			case 56u:
				COOOFFKIDMC = input.ReadUInt32();
				break;
			}
		}
	}
}
