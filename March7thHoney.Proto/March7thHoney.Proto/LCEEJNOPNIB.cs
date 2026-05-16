using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class LCEEJNOPNIB : IMessage<LCEEJNOPNIB>, IMessage, IEquatable<LCEEJNOPNIB>, IDeepCloneable<LCEEJNOPNIB>, IBufferMessage
{
	private static readonly MessageParser<LCEEJNOPNIB> _parser = new MessageParser<LCEEJNOPNIB>(() => new LCEEJNOPNIB());

	private UnknownFieldSet _unknownFields;

	public const int IGJKLCDCLIJFieldNumber = 5;

	private uint iGJKLCDCLIJ_;

	public const int NMLJHIGFKGCFieldNumber = 9;

	private uint nMLJHIGFKGC_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<LCEEJNOPNIB> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => LCEEJNOPNIBReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint IGJKLCDCLIJ
	{
		get
		{
			return iGJKLCDCLIJ_;
		}
		set
		{
			iGJKLCDCLIJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint NMLJHIGFKGC
	{
		get
		{
			return nMLJHIGFKGC_;
		}
		set
		{
			nMLJHIGFKGC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LCEEJNOPNIB()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LCEEJNOPNIB(LCEEJNOPNIB other)
		: this()
	{
		iGJKLCDCLIJ_ = other.iGJKLCDCLIJ_;
		nMLJHIGFKGC_ = other.nMLJHIGFKGC_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LCEEJNOPNIB Clone()
	{
		return new LCEEJNOPNIB(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as LCEEJNOPNIB);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(LCEEJNOPNIB other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (IGJKLCDCLIJ != other.IGJKLCDCLIJ)
		{
			return false;
		}
		if (NMLJHIGFKGC != other.NMLJHIGFKGC)
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
		if (IGJKLCDCLIJ != 0)
		{
			num ^= IGJKLCDCLIJ.GetHashCode();
		}
		if (NMLJHIGFKGC != 0)
		{
			num ^= NMLJHIGFKGC.GetHashCode();
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
		if (IGJKLCDCLIJ != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(IGJKLCDCLIJ);
		}
		if (NMLJHIGFKGC != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(NMLJHIGFKGC);
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
		if (IGJKLCDCLIJ != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(IGJKLCDCLIJ);
		}
		if (NMLJHIGFKGC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(NMLJHIGFKGC);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(LCEEJNOPNIB other)
	{
		if (other != null)
		{
			if (other.IGJKLCDCLIJ != 0)
			{
				IGJKLCDCLIJ = other.IGJKLCDCLIJ;
			}
			if (other.NMLJHIGFKGC != 0)
			{
				NMLJHIGFKGC = other.NMLJHIGFKGC;
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
				IGJKLCDCLIJ = input.ReadUInt32();
				break;
			case 72u:
				NMLJHIGFKGC = input.ReadUInt32();
				break;
			}
		}
	}
}
