using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class NGDOLHONKIA : IMessage<NGDOLHONKIA>, IMessage, IEquatable<NGDOLHONKIA>, IDeepCloneable<NGDOLHONKIA>, IBufferMessage
{
	private static readonly MessageParser<NGDOLHONKIA> _parser = new MessageParser<NGDOLHONKIA>(() => new NGDOLHONKIA());

	private UnknownFieldSet _unknownFields;

	public const int ECDHLIHIPMEFieldNumber = 14;

	private uint eCDHLIHIPME_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<NGDOLHONKIA> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => NGDOLHONKIAReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ECDHLIHIPME
	{
		get
		{
			return eCDHLIHIPME_;
		}
		set
		{
			eCDHLIHIPME_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NGDOLHONKIA()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NGDOLHONKIA(NGDOLHONKIA other)
		: this()
	{
		eCDHLIHIPME_ = other.eCDHLIHIPME_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NGDOLHONKIA Clone()
	{
		return new NGDOLHONKIA(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as NGDOLHONKIA);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(NGDOLHONKIA other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ECDHLIHIPME != other.ECDHLIHIPME)
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
		if (ECDHLIHIPME != 0)
		{
			num ^= ECDHLIHIPME.GetHashCode();
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
		if (ECDHLIHIPME != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(ECDHLIHIPME);
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
		if (ECDHLIHIPME != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ECDHLIHIPME);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(NGDOLHONKIA other)
	{
		if (other != null)
		{
			if (other.ECDHLIHIPME != 0)
			{
				ECDHLIHIPME = other.ECDHLIHIPME;
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
			if (num != 112)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				ECDHLIHIPME = input.ReadUInt32();
			}
		}
	}
}
