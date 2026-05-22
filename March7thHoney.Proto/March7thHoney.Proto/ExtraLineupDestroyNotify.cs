using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ExtraLineupDestroyNotify : IMessage<ExtraLineupDestroyNotify>, IMessage, IEquatable<ExtraLineupDestroyNotify>, IDeepCloneable<ExtraLineupDestroyNotify>, IBufferMessage
{
	private static readonly MessageParser<ExtraLineupDestroyNotify> _parser = new MessageParser<ExtraLineupDestroyNotify>(() => new ExtraLineupDestroyNotify());

	private UnknownFieldSet _unknownFields;

	public const int ExtraLineupTypeFieldNumber = 5;

	private ExtraLineupType extraLineupType_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ExtraLineupDestroyNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ExtraLineupDestroyNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExtraLineupType ExtraLineupType
	{
		get
		{
			return extraLineupType_;
		}
		set
		{
			extraLineupType_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExtraLineupDestroyNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExtraLineupDestroyNotify(ExtraLineupDestroyNotify other)
		: this()
	{
		extraLineupType_ = other.extraLineupType_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExtraLineupDestroyNotify Clone()
	{
		return new ExtraLineupDestroyNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ExtraLineupDestroyNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ExtraLineupDestroyNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ExtraLineupType != other.ExtraLineupType)
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
		if (ExtraLineupType != ExtraLineupType.LineupNone)
		{
			num ^= ExtraLineupType.GetHashCode();
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
		if (ExtraLineupType != ExtraLineupType.LineupNone)
		{
			output.WriteRawTag(40);
			output.WriteEnum((int)ExtraLineupType);
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
		if (ExtraLineupType != ExtraLineupType.LineupNone)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)ExtraLineupType);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ExtraLineupDestroyNotify other)
	{
		if (other != null)
		{
			if (other.ExtraLineupType != ExtraLineupType.LineupNone)
			{
				ExtraLineupType = other.ExtraLineupType;
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
				ExtraLineupType = (ExtraLineupType)input.ReadEnum();
			}
		}
	}
}
