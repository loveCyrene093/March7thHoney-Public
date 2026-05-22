using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class EJDFGNGBNOO : IMessage<EJDFGNGBNOO>, IMessage, IEquatable<EJDFGNGBNOO>, IDeepCloneable<EJDFGNGBNOO>, IBufferMessage
{
	private static readonly MessageParser<EJDFGNGBNOO> _parser = new MessageParser<EJDFGNGBNOO>(() => new EJDFGNGBNOO());

	private UnknownFieldSet _unknownFields;

	public const int OOMACDMBOGFFieldNumber = 5;

	private uint oOMACDMBOGF_;

	public const int IDFCIBLPOKDFieldNumber = 8;

	private uint iDFCIBLPOKD_;

	public const int FCEDANNICIJFieldNumber = 12;

	private uint fCEDANNICIJ_;

	public const int RogueMoneyFieldNumber = 15;

	private uint rogueMoney_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<EJDFGNGBNOO> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => EJDFGNGBNOOReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint OOMACDMBOGF
	{
		get
		{
			return oOMACDMBOGF_;
		}
		set
		{
			oOMACDMBOGF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint IDFCIBLPOKD
	{
		get
		{
			return iDFCIBLPOKD_;
		}
		set
		{
			iDFCIBLPOKD_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint FCEDANNICIJ
	{
		get
		{
			return fCEDANNICIJ_;
		}
		set
		{
			fCEDANNICIJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint RogueMoney
	{
		get
		{
			return rogueMoney_;
		}
		set
		{
			rogueMoney_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EJDFGNGBNOO()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EJDFGNGBNOO(EJDFGNGBNOO other)
		: this()
	{
		oOMACDMBOGF_ = other.oOMACDMBOGF_;
		iDFCIBLPOKD_ = other.iDFCIBLPOKD_;
		fCEDANNICIJ_ = other.fCEDANNICIJ_;
		rogueMoney_ = other.rogueMoney_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EJDFGNGBNOO Clone()
	{
		return new EJDFGNGBNOO(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as EJDFGNGBNOO);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(EJDFGNGBNOO other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (OOMACDMBOGF != other.OOMACDMBOGF)
		{
			return false;
		}
		if (IDFCIBLPOKD != other.IDFCIBLPOKD)
		{
			return false;
		}
		if (FCEDANNICIJ != other.FCEDANNICIJ)
		{
			return false;
		}
		if (RogueMoney != other.RogueMoney)
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
		if (OOMACDMBOGF != 0)
		{
			num ^= OOMACDMBOGF.GetHashCode();
		}
		if (IDFCIBLPOKD != 0)
		{
			num ^= IDFCIBLPOKD.GetHashCode();
		}
		if (FCEDANNICIJ != 0)
		{
			num ^= FCEDANNICIJ.GetHashCode();
		}
		if (RogueMoney != 0)
		{
			num ^= RogueMoney.GetHashCode();
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
		if (OOMACDMBOGF != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(OOMACDMBOGF);
		}
		if (IDFCIBLPOKD != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(IDFCIBLPOKD);
		}
		if (FCEDANNICIJ != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(FCEDANNICIJ);
		}
		if (RogueMoney != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(RogueMoney);
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
		if (OOMACDMBOGF != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(OOMACDMBOGF);
		}
		if (IDFCIBLPOKD != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(IDFCIBLPOKD);
		}
		if (FCEDANNICIJ != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FCEDANNICIJ);
		}
		if (RogueMoney != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(RogueMoney);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(EJDFGNGBNOO other)
	{
		if (other != null)
		{
			if (other.OOMACDMBOGF != 0)
			{
				OOMACDMBOGF = other.OOMACDMBOGF;
			}
			if (other.IDFCIBLPOKD != 0)
			{
				IDFCIBLPOKD = other.IDFCIBLPOKD;
			}
			if (other.FCEDANNICIJ != 0)
			{
				FCEDANNICIJ = other.FCEDANNICIJ;
			}
			if (other.RogueMoney != 0)
			{
				RogueMoney = other.RogueMoney;
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
			case 40u:
				OOMACDMBOGF = input.ReadUInt32();
				break;
			case 64u:
				IDFCIBLPOKD = input.ReadUInt32();
				break;
			case 96u:
				FCEDANNICIJ = input.ReadUInt32();
				break;
			case 120u:
				RogueMoney = input.ReadUInt32();
				break;
			}
		}
	}
}
