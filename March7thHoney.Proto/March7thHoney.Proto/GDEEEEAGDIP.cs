using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GDEEEEAGDIP : IMessage<GDEEEEAGDIP>, IMessage, IEquatable<GDEEEEAGDIP>, IDeepCloneable<GDEEEEAGDIP>, IBufferMessage
{
	private static readonly MessageParser<GDEEEEAGDIP> _parser = new MessageParser<GDEEEEAGDIP>(() => new GDEEEEAGDIP());

	private UnknownFieldSet _unknownFields;

	public const int PassengerIdFieldNumber = 10;

	private uint passengerId_;

	public const int IOHLDDNELBPFieldNumber = 11;

	private static readonly FieldCodec<CGLANHAMOMM> _repeated_iOHLDDNELBP_codec = FieldCodec.ForMessage(90u, CGLANHAMOMM.Parser);

	private readonly RepeatedField<CGLANHAMOMM> iOHLDDNELBP_ = new RepeatedField<CGLANHAMOMM>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GDEEEEAGDIP> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GDEEEEAGDIPReflection.Descriptor.MessageTypes[0];

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
	public RepeatedField<CGLANHAMOMM> IOHLDDNELBP => iOHLDDNELBP_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GDEEEEAGDIP()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GDEEEEAGDIP(GDEEEEAGDIP other)
		: this()
	{
		passengerId_ = other.passengerId_;
		iOHLDDNELBP_ = other.iOHLDDNELBP_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GDEEEEAGDIP Clone()
	{
		return new GDEEEEAGDIP(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GDEEEEAGDIP);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GDEEEEAGDIP other)
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
		if (!iOHLDDNELBP_.Equals(other.iOHLDDNELBP_))
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
		num ^= iOHLDDNELBP_.GetHashCode();
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
			output.WriteRawTag(80);
			output.WriteUInt32(PassengerId);
		}
		iOHLDDNELBP_.WriteTo(ref output, _repeated_iOHLDDNELBP_codec);
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
		num += iOHLDDNELBP_.CalculateSize(_repeated_iOHLDDNELBP_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GDEEEEAGDIP other)
	{
		if (other != null)
		{
			if (other.PassengerId != 0)
			{
				PassengerId = other.PassengerId;
			}
			iOHLDDNELBP_.Add(other.iOHLDDNELBP_);
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
			case 80u:
				PassengerId = input.ReadUInt32();
				break;
			case 90u:
				iOHLDDNELBP_.AddEntriesFrom(ref input, _repeated_iOHLDDNELBP_codec);
				break;
			}
		}
	}
}
