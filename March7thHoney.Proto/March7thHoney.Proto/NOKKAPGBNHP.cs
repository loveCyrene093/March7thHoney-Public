using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class NOKKAPGBNHP : IMessage<NOKKAPGBNHP>, IMessage, IEquatable<NOKKAPGBNHP>, IDeepCloneable<NOKKAPGBNHP>, IBufferMessage
{
	private static readonly MessageParser<NOKKAPGBNHP> _parser = new MessageParser<NOKKAPGBNHP>(() => new NOKKAPGBNHP());

	private UnknownFieldSet _unknownFields;

	public const int IGJKFHKMONIFieldNumber = 3;

	private uint iGJKFHKMONI_;

	public const int IHMABIPHLKNFieldNumber = 10;

	private uint iHMABIPHLKN_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<NOKKAPGBNHP> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => NOKKAPGBNHPReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint IGJKFHKMONI
	{
		get
		{
			return iGJKFHKMONI_;
		}
		set
		{
			iGJKFHKMONI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint IHMABIPHLKN
	{
		get
		{
			return iHMABIPHLKN_;
		}
		set
		{
			iHMABIPHLKN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NOKKAPGBNHP()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NOKKAPGBNHP(NOKKAPGBNHP other)
		: this()
	{
		iGJKFHKMONI_ = other.iGJKFHKMONI_;
		iHMABIPHLKN_ = other.iHMABIPHLKN_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NOKKAPGBNHP Clone()
	{
		return new NOKKAPGBNHP(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as NOKKAPGBNHP);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(NOKKAPGBNHP other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (IGJKFHKMONI != other.IGJKFHKMONI)
		{
			return false;
		}
		if (IHMABIPHLKN != other.IHMABIPHLKN)
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
		if (IGJKFHKMONI != 0)
		{
			num ^= IGJKFHKMONI.GetHashCode();
		}
		if (IHMABIPHLKN != 0)
		{
			num ^= IHMABIPHLKN.GetHashCode();
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
		if (IGJKFHKMONI != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(IGJKFHKMONI);
		}
		if (IHMABIPHLKN != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(IHMABIPHLKN);
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
		if (IGJKFHKMONI != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(IGJKFHKMONI);
		}
		if (IHMABIPHLKN != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(IHMABIPHLKN);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(NOKKAPGBNHP other)
	{
		if (other != null)
		{
			if (other.IGJKFHKMONI != 0)
			{
				IGJKFHKMONI = other.IGJKFHKMONI;
			}
			if (other.IHMABIPHLKN != 0)
			{
				IHMABIPHLKN = other.IHMABIPHLKN;
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
				IGJKFHKMONI = input.ReadUInt32();
				break;
			case 80u:
				IHMABIPHLKN = input.ReadUInt32();
				break;
			}
		}
	}
}
