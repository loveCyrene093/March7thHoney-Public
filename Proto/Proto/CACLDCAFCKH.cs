using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class CACLDCAFCKH : IMessage<CACLDCAFCKH>, IMessage, IEquatable<CACLDCAFCKH>, IDeepCloneable<CACLDCAFCKH>, IBufferMessage
{
	private static readonly MessageParser<CACLDCAFCKH> _parser = new MessageParser<CACLDCAFCKH>(() => new CACLDCAFCKH());

	private UnknownFieldSet _unknownFields;

	public const int FAPFKFJIELEFieldNumber = 5;

	private uint fAPFKFJIELE_;

	public const int StatusFieldNumber = 12;

	private LNNFNLKACON status_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CACLDCAFCKH> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => CACLDCAFCKHReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint FAPFKFJIELE
	{
		get
		{
			return fAPFKFJIELE_;
		}
		set
		{
			fAPFKFJIELE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LNNFNLKACON Status
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
	public CACLDCAFCKH()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CACLDCAFCKH(CACLDCAFCKH other)
		: this()
	{
		fAPFKFJIELE_ = other.fAPFKFJIELE_;
		status_ = other.status_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CACLDCAFCKH Clone()
	{
		return new CACLDCAFCKH(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as CACLDCAFCKH);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CACLDCAFCKH other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (FAPFKFJIELE != other.FAPFKFJIELE)
		{
			return false;
		}
		if (Status != other.Status)
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
		if (FAPFKFJIELE != 0)
		{
			num ^= FAPFKFJIELE.GetHashCode();
		}
		if (Status != LNNFNLKACON.Pcpdhelpkem)
		{
			num ^= Status.GetHashCode();
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
		if (FAPFKFJIELE != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(FAPFKFJIELE);
		}
		if (Status != LNNFNLKACON.Pcpdhelpkem)
		{
			output.WriteRawTag(96);
			output.WriteEnum((int)Status);
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
		if (FAPFKFJIELE != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FAPFKFJIELE);
		}
		if (Status != LNNFNLKACON.Pcpdhelpkem)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Status);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CACLDCAFCKH other)
	{
		if (other != null)
		{
			if (other.FAPFKFJIELE != 0)
			{
				FAPFKFJIELE = other.FAPFKFJIELE;
			}
			if (other.Status != LNNFNLKACON.Pcpdhelpkem)
			{
				Status = other.Status;
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
				FAPFKFJIELE = input.ReadUInt32();
				break;
			case 96u:
				Status = (LNNFNLKACON)input.ReadEnum();
				break;
			}
		}
	}
}
