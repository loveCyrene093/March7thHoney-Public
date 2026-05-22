using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class JCJACKICPHN : IMessage<JCJACKICPHN>, IMessage, IEquatable<JCJACKICPHN>, IDeepCloneable<JCJACKICPHN>, IBufferMessage
{
	private static readonly MessageParser<JCJACKICPHN> _parser = new MessageParser<JCJACKICPHN>(() => new JCJACKICPHN());

	private UnknownFieldSet _unknownFields;

	public const int HasPassedFieldNumber = 9;

	private bool hasPassed_;

	public const int IdFieldNumber = 11;

	private uint id_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<JCJACKICPHN> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => JCJACKICPHNReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasPassed
	{
		get
		{
			return hasPassed_;
		}
		set
		{
			hasPassed_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Id
	{
		get
		{
			return id_;
		}
		set
		{
			id_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JCJACKICPHN()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JCJACKICPHN(JCJACKICPHN other)
		: this()
	{
		hasPassed_ = other.hasPassed_;
		id_ = other.id_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JCJACKICPHN Clone()
	{
		return new JCJACKICPHN(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as JCJACKICPHN);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(JCJACKICPHN other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (HasPassed != other.HasPassed)
		{
			return false;
		}
		if (Id != other.Id)
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
		if (HasPassed)
		{
			num ^= HasPassed.GetHashCode();
		}
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
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
		if (HasPassed)
		{
			output.WriteRawTag(72);
			output.WriteBool(HasPassed);
		}
		if (Id != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(Id);
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
		if (HasPassed)
		{
			num += 2;
		}
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Id);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(JCJACKICPHN other)
	{
		if (other != null)
		{
			if (other.HasPassed)
			{
				HasPassed = other.HasPassed;
			}
			if (other.Id != 0)
			{
				Id = other.Id;
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
			case 72u:
				HasPassed = input.ReadBool();
				break;
			case 88u:
				Id = input.ReadUInt32();
				break;
			}
		}
	}
}
