using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class PNCBGGJKKAF : IMessage<PNCBGGJKKAF>, IMessage, IEquatable<PNCBGGJKKAF>, IDeepCloneable<PNCBGGJKKAF>, IBufferMessage
{
	private static readonly MessageParser<PNCBGGJKKAF> _parser = new MessageParser<PNCBGGJKKAF>(() => new PNCBGGJKKAF());

	private UnknownFieldSet _unknownFields;

	public const int EIENKJFFFJGFieldNumber = 12;

	private ILLBNKFBNBP eIENKJFFFJG_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PNCBGGJKKAF> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PNCBGGJKKAFReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ILLBNKFBNBP EIENKJFFFJG
	{
		get
		{
			return eIENKJFFFJG_;
		}
		set
		{
			eIENKJFFFJG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PNCBGGJKKAF()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PNCBGGJKKAF(PNCBGGJKKAF other)
		: this()
	{
		eIENKJFFFJG_ = ((other.eIENKJFFFJG_ != null) ? other.eIENKJFFFJG_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PNCBGGJKKAF Clone()
	{
		return new PNCBGGJKKAF(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PNCBGGJKKAF);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PNCBGGJKKAF other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(EIENKJFFFJG, other.EIENKJFFFJG))
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
		if (eIENKJFFFJG_ != null)
		{
			num ^= EIENKJFFFJG.GetHashCode();
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
		if (eIENKJFFFJG_ != null)
		{
			output.WriteRawTag(98);
			output.WriteMessage(EIENKJFFFJG);
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
		if (eIENKJFFFJG_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(EIENKJFFFJG);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PNCBGGJKKAF other)
	{
		if (other == null)
		{
			return;
		}
		if (other.eIENKJFFFJG_ != null)
		{
			if (eIENKJFFFJG_ == null)
			{
				EIENKJFFFJG = new ILLBNKFBNBP();
			}
			EIENKJFFFJG.MergeFrom(other.EIENKJFFFJG);
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
			if (num != 98)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				continue;
			}
			if (eIENKJFFFJG_ == null)
			{
				EIENKJFFFJG = new ILLBNKFBNBP();
			}
			input.ReadMessage(EIENKJFFFJG);
		}
	}
}
