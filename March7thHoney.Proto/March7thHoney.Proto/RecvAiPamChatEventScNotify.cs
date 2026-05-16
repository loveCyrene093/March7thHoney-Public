using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class RecvAiPamChatEventScNotify : IMessage<RecvAiPamChatEventScNotify>, IMessage, IEquatable<RecvAiPamChatEventScNotify>, IDeepCloneable<RecvAiPamChatEventScNotify>, IBufferMessage
{
	private static readonly MessageParser<RecvAiPamChatEventScNotify> _parser = new MessageParser<RecvAiPamChatEventScNotify>(() => new RecvAiPamChatEventScNotify());

	private UnknownFieldSet _unknownFields;

	public const int GLNJOAHBBKKFieldNumber = 3;

	private MDOJCCMLKHP gLNJOAHBBKK_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<RecvAiPamChatEventScNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => RecvAiPamChatEventScNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MDOJCCMLKHP GLNJOAHBBKK
	{
		get
		{
			return gLNJOAHBBKK_;
		}
		set
		{
			gLNJOAHBBKK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RecvAiPamChatEventScNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RecvAiPamChatEventScNotify(RecvAiPamChatEventScNotify other)
		: this()
	{
		gLNJOAHBBKK_ = ((other.gLNJOAHBBKK_ != null) ? other.gLNJOAHBBKK_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RecvAiPamChatEventScNotify Clone()
	{
		return new RecvAiPamChatEventScNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as RecvAiPamChatEventScNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(RecvAiPamChatEventScNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(GLNJOAHBBKK, other.GLNJOAHBBKK))
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
		if (gLNJOAHBBKK_ != null)
		{
			num ^= GLNJOAHBBKK.GetHashCode();
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
		if (gLNJOAHBBKK_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(GLNJOAHBBKK);
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
		if (gLNJOAHBBKK_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(GLNJOAHBBKK);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(RecvAiPamChatEventScNotify other)
	{
		if (other == null)
		{
			return;
		}
		if (other.gLNJOAHBBKK_ != null)
		{
			if (gLNJOAHBBKK_ == null)
			{
				GLNJOAHBBKK = new MDOJCCMLKHP();
			}
			GLNJOAHBBKK.MergeFrom(other.GLNJOAHBBKK);
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
			if (num != 26)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				continue;
			}
			if (gLNJOAHBBKK_ == null)
			{
				GLNJOAHBBKK = new MDOJCCMLKHP();
			}
			input.ReadMessage(GLNJOAHBBKK);
		}
	}
}
