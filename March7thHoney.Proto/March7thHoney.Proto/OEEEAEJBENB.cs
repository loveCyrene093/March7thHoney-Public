using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class OEEEAEJBENB : IMessage<OEEEAEJBENB>, IMessage, IEquatable<OEEEAEJBENB>, IDeepCloneable<OEEEAEJBENB>, IBufferMessage
{
	private static readonly MessageParser<OEEEAEJBENB> _parser = new MessageParser<OEEEAEJBENB>(() => new OEEEAEJBENB());

	private UnknownFieldSet _unknownFields;

	public const int JLPHFLLOEAJFieldNumber = 2;

	private bool jLPHFLLOEAJ_;

	public const int ODEJNPJBJAJFieldNumber = 6;

	private bool oDEJNPJBJAJ_;

	public const int APOFJCCELFMFieldNumber = 8;

	private uint aPOFJCCELFM_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<OEEEAEJBENB> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => OEEEAEJBENBReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool JLPHFLLOEAJ
	{
		get
		{
			return jLPHFLLOEAJ_;
		}
		set
		{
			jLPHFLLOEAJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool ODEJNPJBJAJ
	{
		get
		{
			return oDEJNPJBJAJ_;
		}
		set
		{
			oDEJNPJBJAJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint APOFJCCELFM
	{
		get
		{
			return aPOFJCCELFM_;
		}
		set
		{
			aPOFJCCELFM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OEEEAEJBENB()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OEEEAEJBENB(OEEEAEJBENB other)
		: this()
	{
		jLPHFLLOEAJ_ = other.jLPHFLLOEAJ_;
		oDEJNPJBJAJ_ = other.oDEJNPJBJAJ_;
		aPOFJCCELFM_ = other.aPOFJCCELFM_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OEEEAEJBENB Clone()
	{
		return new OEEEAEJBENB(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as OEEEAEJBENB);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(OEEEAEJBENB other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (JLPHFLLOEAJ != other.JLPHFLLOEAJ)
		{
			return false;
		}
		if (ODEJNPJBJAJ != other.ODEJNPJBJAJ)
		{
			return false;
		}
		if (APOFJCCELFM != other.APOFJCCELFM)
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
		if (JLPHFLLOEAJ)
		{
			num ^= JLPHFLLOEAJ.GetHashCode();
		}
		if (ODEJNPJBJAJ)
		{
			num ^= ODEJNPJBJAJ.GetHashCode();
		}
		if (APOFJCCELFM != 0)
		{
			num ^= APOFJCCELFM.GetHashCode();
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
		if (JLPHFLLOEAJ)
		{
			output.WriteRawTag(16);
			output.WriteBool(JLPHFLLOEAJ);
		}
		if (ODEJNPJBJAJ)
		{
			output.WriteRawTag(48);
			output.WriteBool(ODEJNPJBJAJ);
		}
		if (APOFJCCELFM != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(APOFJCCELFM);
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
		if (JLPHFLLOEAJ)
		{
			num += 2;
		}
		if (ODEJNPJBJAJ)
		{
			num += 2;
		}
		if (APOFJCCELFM != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(APOFJCCELFM);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(OEEEAEJBENB other)
	{
		if (other != null)
		{
			if (other.JLPHFLLOEAJ)
			{
				JLPHFLLOEAJ = other.JLPHFLLOEAJ;
			}
			if (other.ODEJNPJBJAJ)
			{
				ODEJNPJBJAJ = other.ODEJNPJBJAJ;
			}
			if (other.APOFJCCELFM != 0)
			{
				APOFJCCELFM = other.APOFJCCELFM;
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
				JLPHFLLOEAJ = input.ReadBool();
				break;
			case 48u:
				ODEJNPJBJAJ = input.ReadBool();
				break;
			case 64u:
				APOFJCCELFM = input.ReadUInt32();
				break;
			}
		}
	}
}
