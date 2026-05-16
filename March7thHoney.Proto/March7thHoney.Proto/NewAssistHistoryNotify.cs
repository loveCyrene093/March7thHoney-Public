using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class NewAssistHistoryNotify : IMessage<NewAssistHistoryNotify>, IMessage, IEquatable<NewAssistHistoryNotify>, IDeepCloneable<NewAssistHistoryNotify>, IBufferMessage
{
	private static readonly MessageParser<NewAssistHistoryNotify> _parser = new MessageParser<NewAssistHistoryNotify>(() => new NewAssistHistoryNotify());

	private UnknownFieldSet _unknownFields;

	public const int OKPBNIIDCEJFieldNumber = 5;

	private uint oKPBNIIDCEJ_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<NewAssistHistoryNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => NewAssistHistoryNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint OKPBNIIDCEJ
	{
		get
		{
			return oKPBNIIDCEJ_;
		}
		set
		{
			oKPBNIIDCEJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NewAssistHistoryNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NewAssistHistoryNotify(NewAssistHistoryNotify other)
		: this()
	{
		oKPBNIIDCEJ_ = other.oKPBNIIDCEJ_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NewAssistHistoryNotify Clone()
	{
		return new NewAssistHistoryNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as NewAssistHistoryNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(NewAssistHistoryNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (OKPBNIIDCEJ != other.OKPBNIIDCEJ)
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
		if (OKPBNIIDCEJ != 0)
		{
			num ^= OKPBNIIDCEJ.GetHashCode();
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
		if (OKPBNIIDCEJ != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(OKPBNIIDCEJ);
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
		if (OKPBNIIDCEJ != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(OKPBNIIDCEJ);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(NewAssistHistoryNotify other)
	{
		if (other != null)
		{
			if (other.OKPBNIIDCEJ != 0)
			{
				OKPBNIIDCEJ = other.OKPBNIIDCEJ;
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
			if (num != 40)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				OKPBNIIDCEJ = input.ReadUInt32();
			}
		}
	}
}
