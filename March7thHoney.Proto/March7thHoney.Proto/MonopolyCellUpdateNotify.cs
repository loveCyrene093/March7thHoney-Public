using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MonopolyCellUpdateNotify : IMessage<MonopolyCellUpdateNotify>, IMessage, IEquatable<MonopolyCellUpdateNotify>, IDeepCloneable<MonopolyCellUpdateNotify>, IBufferMessage
{
	private static readonly MessageParser<MonopolyCellUpdateNotify> _parser = new MessageParser<MonopolyCellUpdateNotify>(() => new MonopolyCellUpdateNotify());

	private UnknownFieldSet _unknownFields;

	public const int LJHDOFBFNJHFieldNumber = 8;

	private AAHBECICOEN lJHDOFBFNJH_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MonopolyCellUpdateNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MonopolyCellUpdateNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AAHBECICOEN LJHDOFBFNJH
	{
		get
		{
			return lJHDOFBFNJH_;
		}
		set
		{
			lJHDOFBFNJH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MonopolyCellUpdateNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MonopolyCellUpdateNotify(MonopolyCellUpdateNotify other)
		: this()
	{
		lJHDOFBFNJH_ = ((other.lJHDOFBFNJH_ != null) ? other.lJHDOFBFNJH_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MonopolyCellUpdateNotify Clone()
	{
		return new MonopolyCellUpdateNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MonopolyCellUpdateNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MonopolyCellUpdateNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(LJHDOFBFNJH, other.LJHDOFBFNJH))
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
		if (lJHDOFBFNJH_ != null)
		{
			num ^= LJHDOFBFNJH.GetHashCode();
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
		if (lJHDOFBFNJH_ != null)
		{
			output.WriteRawTag(66);
			output.WriteMessage(LJHDOFBFNJH);
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
		if (lJHDOFBFNJH_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(LJHDOFBFNJH);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MonopolyCellUpdateNotify other)
	{
		if (other == null)
		{
			return;
		}
		if (other.lJHDOFBFNJH_ != null)
		{
			if (lJHDOFBFNJH_ == null)
			{
				LJHDOFBFNJH = new AAHBECICOEN();
			}
			LJHDOFBFNJH.MergeFrom(other.LJHDOFBFNJH);
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
			if (num != 66)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				continue;
			}
			if (lJHDOFBFNJH_ == null)
			{
				LJHDOFBFNJH = new AAHBECICOEN();
			}
			input.ReadMessage(LJHDOFBFNJH);
		}
	}
}
