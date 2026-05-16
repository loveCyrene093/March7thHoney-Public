using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class LogisticsInfoScNotify : IMessage<LogisticsInfoScNotify>, IMessage, IEquatable<LogisticsInfoScNotify>, IDeepCloneable<LogisticsInfoScNotify>, IBufferMessage
{
	private static readonly MessageParser<LogisticsInfoScNotify> _parser = new MessageParser<LogisticsInfoScNotify>(() => new LogisticsInfoScNotify());

	private UnknownFieldSet _unknownFields;

	public const int HBMJIGGBFKPFieldNumber = 15;

	private GEOAAAOAPGK hBMJIGGBFKP_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<LogisticsInfoScNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => LogisticsInfoScNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GEOAAAOAPGK HBMJIGGBFKP
	{
		get
		{
			return hBMJIGGBFKP_;
		}
		set
		{
			hBMJIGGBFKP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LogisticsInfoScNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LogisticsInfoScNotify(LogisticsInfoScNotify other)
		: this()
	{
		hBMJIGGBFKP_ = ((other.hBMJIGGBFKP_ != null) ? other.hBMJIGGBFKP_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LogisticsInfoScNotify Clone()
	{
		return new LogisticsInfoScNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as LogisticsInfoScNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(LogisticsInfoScNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(HBMJIGGBFKP, other.HBMJIGGBFKP))
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
		if (hBMJIGGBFKP_ != null)
		{
			num ^= HBMJIGGBFKP.GetHashCode();
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
		if (hBMJIGGBFKP_ != null)
		{
			output.WriteRawTag(122);
			output.WriteMessage(HBMJIGGBFKP);
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
		if (hBMJIGGBFKP_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(HBMJIGGBFKP);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(LogisticsInfoScNotify other)
	{
		if (other == null)
		{
			return;
		}
		if (other.hBMJIGGBFKP_ != null)
		{
			if (hBMJIGGBFKP_ == null)
			{
				HBMJIGGBFKP = new GEOAAAOAPGK();
			}
			HBMJIGGBFKP.MergeFrom(other.HBMJIGGBFKP);
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
			if (hBMJIGGBFKP_ == null)
			{
				HBMJIGGBFKP = new GEOAAAOAPGK();
			}
			input.ReadMessage(HBMJIGGBFKP);
		}
	}
}
