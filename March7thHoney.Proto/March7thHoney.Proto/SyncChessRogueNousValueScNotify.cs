using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class SyncChessRogueNousValueScNotify : IMessage<SyncChessRogueNousValueScNotify>, IMessage, IEquatable<SyncChessRogueNousValueScNotify>, IDeepCloneable<SyncChessRogueNousValueScNotify>, IBufferMessage
{
	private static readonly MessageParser<SyncChessRogueNousValueScNotify> _parser = new MessageParser<SyncChessRogueNousValueScNotify>(() => new SyncChessRogueNousValueScNotify());

	private UnknownFieldSet _unknownFields;

	public const int BHOOLFGEIAAFieldNumber = 1;

	private NAMGFEONKFK bHOOLFGEIAA_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SyncChessRogueNousValueScNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => SyncChessRogueNousValueScNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NAMGFEONKFK BHOOLFGEIAA
	{
		get
		{
			return bHOOLFGEIAA_;
		}
		set
		{
			bHOOLFGEIAA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SyncChessRogueNousValueScNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SyncChessRogueNousValueScNotify(SyncChessRogueNousValueScNotify other)
		: this()
	{
		bHOOLFGEIAA_ = ((other.bHOOLFGEIAA_ != null) ? other.bHOOLFGEIAA_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SyncChessRogueNousValueScNotify Clone()
	{
		return new SyncChessRogueNousValueScNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as SyncChessRogueNousValueScNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SyncChessRogueNousValueScNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(BHOOLFGEIAA, other.BHOOLFGEIAA))
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
		if (bHOOLFGEIAA_ != null)
		{
			num ^= BHOOLFGEIAA.GetHashCode();
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
		if (bHOOLFGEIAA_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(BHOOLFGEIAA);
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
		if (bHOOLFGEIAA_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(BHOOLFGEIAA);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(SyncChessRogueNousValueScNotify other)
	{
		if (other == null)
		{
			return;
		}
		if (other.bHOOLFGEIAA_ != null)
		{
			if (bHOOLFGEIAA_ == null)
			{
				BHOOLFGEIAA = new NAMGFEONKFK();
			}
			BHOOLFGEIAA.MergeFrom(other.BHOOLFGEIAA);
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
			if (bHOOLFGEIAA_ == null)
			{
				BHOOLFGEIAA = new NAMGFEONKFK();
			}
			input.ReadMessage(BHOOLFGEIAA);
		}
	}
}
