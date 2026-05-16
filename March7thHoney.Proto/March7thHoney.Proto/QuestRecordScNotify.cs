using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class QuestRecordScNotify : IMessage<QuestRecordScNotify>, IMessage, IEquatable<QuestRecordScNotify>, IDeepCloneable<QuestRecordScNotify>, IBufferMessage
{
	private static readonly MessageParser<QuestRecordScNotify> _parser = new MessageParser<QuestRecordScNotify>(() => new QuestRecordScNotify());

	private UnknownFieldSet _unknownFields;

	public const int MOHJDHKKIGBFieldNumber = 2;

	private JOHPGEDGJAD mOHJDHKKIGB_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<QuestRecordScNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => QuestRecordScNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JOHPGEDGJAD MOHJDHKKIGB
	{
		get
		{
			return mOHJDHKKIGB_;
		}
		set
		{
			mOHJDHKKIGB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public QuestRecordScNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public QuestRecordScNotify(QuestRecordScNotify other)
		: this()
	{
		mOHJDHKKIGB_ = ((other.mOHJDHKKIGB_ != null) ? other.mOHJDHKKIGB_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public QuestRecordScNotify Clone()
	{
		return new QuestRecordScNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as QuestRecordScNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(QuestRecordScNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(MOHJDHKKIGB, other.MOHJDHKKIGB))
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
		if (mOHJDHKKIGB_ != null)
		{
			num ^= MOHJDHKKIGB.GetHashCode();
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
		if (mOHJDHKKIGB_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(MOHJDHKKIGB);
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
		if (mOHJDHKKIGB_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(MOHJDHKKIGB);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(QuestRecordScNotify other)
	{
		if (other == null)
		{
			return;
		}
		if (other.mOHJDHKKIGB_ != null)
		{
			if (mOHJDHKKIGB_ == null)
			{
				MOHJDHKKIGB = new JOHPGEDGJAD();
			}
			MOHJDHKKIGB.MergeFrom(other.MOHJDHKKIGB);
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
			if (num != 18)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				continue;
			}
			if (mOHJDHKKIGB_ == null)
			{
				MOHJDHKKIGB = new JOHPGEDGJAD();
			}
			input.ReadMessage(MOHJDHKKIGB);
		}
	}
}
