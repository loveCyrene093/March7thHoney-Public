using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class JGBLCLCHHIO : IMessage<JGBLCLCHHIO>, IMessage, IEquatable<JGBLCLCHHIO>, IDeepCloneable<JGBLCLCHHIO>, IBufferMessage
{
	private static readonly MessageParser<JGBLCLCHHIO> _parser = new MessageParser<JGBLCLCHHIO>(() => new JGBLCLCHHIO());

	private UnknownFieldSet _unknownFields;

	public const int StopDescFieldNumber = 1;

	private ChatMessageData stopDesc_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<JGBLCLCHHIO> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => JGBLCLCHHIOReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChatMessageData StopDesc
	{
		get
		{
			return stopDesc_;
		}
		set
		{
			stopDesc_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JGBLCLCHHIO()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JGBLCLCHHIO(JGBLCLCHHIO other)
		: this()
	{
		stopDesc_ = ((other.stopDesc_ != null) ? other.stopDesc_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JGBLCLCHHIO Clone()
	{
		return new JGBLCLCHHIO(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as JGBLCLCHHIO);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(JGBLCLCHHIO other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(StopDesc, other.StopDesc))
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
		if (stopDesc_ != null)
		{
			num ^= StopDesc.GetHashCode();
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
		if (stopDesc_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(StopDesc);
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
		if (stopDesc_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(StopDesc);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(JGBLCLCHHIO other)
	{
		if (other == null)
		{
			return;
		}
		if (other.stopDesc_ != null)
		{
			if (stopDesc_ == null)
			{
				StopDesc = new ChatMessageData();
			}
			StopDesc.MergeFrom(other.StopDesc);
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
			if (num != 10)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				continue;
			}
			if (stopDesc_ == null)
			{
				StopDesc = new ChatMessageData();
			}
			input.ReadMessage(StopDesc);
		}
	}
}
