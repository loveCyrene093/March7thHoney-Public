using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class DOBIOOHLGAA : IMessage<DOBIOOHLGAA>, IMessage, IEquatable<DOBIOOHLGAA>, IDeepCloneable<DOBIOOHLGAA>, IBufferMessage
{
	private static readonly MessageParser<DOBIOOHLGAA> _parser = new MessageParser<DOBIOOHLGAA>(() => new DOBIOOHLGAA());

	private UnknownFieldSet _unknownFields;

	public const int PassengerIdFieldNumber = 3;

	private uint passengerId_;

	public const int DGFGNMJALGJFieldNumber = 5;

	private DKBNGDHCNCH dGFGNMJALGJ_;

	public const int IANGBIBHJDFFieldNumber = 13;

	private uint iANGBIBHJDF_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<DOBIOOHLGAA> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => DOBIOOHLGAAReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PassengerId
	{
		get
		{
			return passengerId_;
		}
		set
		{
			passengerId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DKBNGDHCNCH DGFGNMJALGJ
	{
		get
		{
			return dGFGNMJALGJ_;
		}
		set
		{
			dGFGNMJALGJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint IANGBIBHJDF
	{
		get
		{
			return iANGBIBHJDF_;
		}
		set
		{
			iANGBIBHJDF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DOBIOOHLGAA()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DOBIOOHLGAA(DOBIOOHLGAA other)
		: this()
	{
		passengerId_ = other.passengerId_;
		dGFGNMJALGJ_ = ((other.dGFGNMJALGJ_ != null) ? other.dGFGNMJALGJ_.Clone() : null);
		iANGBIBHJDF_ = other.iANGBIBHJDF_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DOBIOOHLGAA Clone()
	{
		return new DOBIOOHLGAA(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as DOBIOOHLGAA);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(DOBIOOHLGAA other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (PassengerId != other.PassengerId)
		{
			return false;
		}
		if (!object.Equals(DGFGNMJALGJ, other.DGFGNMJALGJ))
		{
			return false;
		}
		if (IANGBIBHJDF != other.IANGBIBHJDF)
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
		if (PassengerId != 0)
		{
			num ^= PassengerId.GetHashCode();
		}
		if (dGFGNMJALGJ_ != null)
		{
			num ^= DGFGNMJALGJ.GetHashCode();
		}
		if (IANGBIBHJDF != 0)
		{
			num ^= IANGBIBHJDF.GetHashCode();
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
		if (PassengerId != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(PassengerId);
		}
		if (dGFGNMJALGJ_ != null)
		{
			output.WriteRawTag(42);
			output.WriteMessage(DGFGNMJALGJ);
		}
		if (IANGBIBHJDF != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(IANGBIBHJDF);
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
		if (PassengerId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PassengerId);
		}
		if (dGFGNMJALGJ_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(DGFGNMJALGJ);
		}
		if (IANGBIBHJDF != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(IANGBIBHJDF);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(DOBIOOHLGAA other)
	{
		if (other == null)
		{
			return;
		}
		if (other.PassengerId != 0)
		{
			PassengerId = other.PassengerId;
		}
		if (other.dGFGNMJALGJ_ != null)
		{
			if (dGFGNMJALGJ_ == null)
			{
				DGFGNMJALGJ = new DKBNGDHCNCH();
			}
			DGFGNMJALGJ.MergeFrom(other.DGFGNMJALGJ);
		}
		if (other.IANGBIBHJDF != 0)
		{
			IANGBIBHJDF = other.IANGBIBHJDF;
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
			case 24u:
				PassengerId = input.ReadUInt32();
				break;
			case 42u:
				if (dGFGNMJALGJ_ == null)
				{
					DGFGNMJALGJ = new DKBNGDHCNCH();
				}
				input.ReadMessage(DGFGNMJALGJ);
				break;
			case 104u:
				IANGBIBHJDF = input.ReadUInt32();
				break;
			}
		}
	}
}
