using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ClockParkFinishScriptScNotify : IMessage<ClockParkFinishScriptScNotify>, IMessage, IEquatable<ClockParkFinishScriptScNotify>, IDeepCloneable<ClockParkFinishScriptScNotify>, IBufferMessage
{
	private static readonly MessageParser<ClockParkFinishScriptScNotify> _parser = new MessageParser<ClockParkFinishScriptScNotify>(() => new ClockParkFinishScriptScNotify());

	private UnknownFieldSet _unknownFields;

	public const int FinishInfoFieldNumber = 15;

	private KCEHEAGEDAA finishInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ClockParkFinishScriptScNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ClockParkFinishScriptScNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KCEHEAGEDAA FinishInfo
	{
		get
		{
			return finishInfo_;
		}
		set
		{
			finishInfo_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ClockParkFinishScriptScNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ClockParkFinishScriptScNotify(ClockParkFinishScriptScNotify other)
		: this()
	{
		finishInfo_ = ((other.finishInfo_ != null) ? other.finishInfo_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ClockParkFinishScriptScNotify Clone()
	{
		return new ClockParkFinishScriptScNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ClockParkFinishScriptScNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ClockParkFinishScriptScNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(FinishInfo, other.FinishInfo))
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
		if (finishInfo_ != null)
		{
			num ^= FinishInfo.GetHashCode();
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
		if (finishInfo_ != null)
		{
			output.WriteRawTag(122);
			output.WriteMessage(FinishInfo);
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
		if (finishInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(FinishInfo);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ClockParkFinishScriptScNotify other)
	{
		if (other == null)
		{
			return;
		}
		if (other.finishInfo_ != null)
		{
			if (finishInfo_ == null)
			{
				FinishInfo = new KCEHEAGEDAA();
			}
			FinishInfo.MergeFrom(other.FinishInfo);
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
			if (num != 122)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				continue;
			}
			if (finishInfo_ == null)
			{
				FinishInfo = new KCEHEAGEDAA();
			}
			input.ReadMessage(FinishInfo);
		}
	}
}
