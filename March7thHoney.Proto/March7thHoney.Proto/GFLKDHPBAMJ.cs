using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GFLKDHPBAMJ : IMessage<GFLKDHPBAMJ>, IMessage, IEquatable<GFLKDHPBAMJ>, IDeepCloneable<GFLKDHPBAMJ>, IBufferMessage
{
	public enum AFLLICNCFDNOneofCase
	{
		None,
		MessageText,
		ExtraId
	}

	private static readonly MessageParser<GFLKDHPBAMJ> _parser = new MessageParser<GFLKDHPBAMJ>(() => new GFLKDHPBAMJ());

	private UnknownFieldSet _unknownFields;

	public const int MessageTextFieldNumber = 1;

	public const int ExtraIdFieldNumber = 2;

	private object aFLLICNCFDN_;

	private AFLLICNCFDNOneofCase aFLLICNCFDNCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GFLKDHPBAMJ> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GFLKDHPBAMJReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string MessageText
	{
		get
		{
			if (!HasMessageText)
			{
				return "";
			}
			return (string)aFLLICNCFDN_;
		}
		set
		{
			aFLLICNCFDN_ = ProtoPreconditions.CheckNotNull(value, "value");
			aFLLICNCFDNCase_ = AFLLICNCFDNOneofCase.MessageText;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasMessageText => aFLLICNCFDNCase_ == AFLLICNCFDNOneofCase.MessageText;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ExtraId
	{
		get
		{
			if (!HasExtraId)
			{
				return 0u;
			}
			return (uint)aFLLICNCFDN_;
		}
		set
		{
			aFLLICNCFDN_ = value;
			aFLLICNCFDNCase_ = AFLLICNCFDNOneofCase.ExtraId;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasExtraId => aFLLICNCFDNCase_ == AFLLICNCFDNOneofCase.ExtraId;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AFLLICNCFDNOneofCase AFLLICNCFDNCase => aFLLICNCFDNCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GFLKDHPBAMJ()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GFLKDHPBAMJ(GFLKDHPBAMJ other)
		: this()
	{
		switch (other.AFLLICNCFDNCase)
		{
		case AFLLICNCFDNOneofCase.MessageText:
			MessageText = other.MessageText;
			break;
		case AFLLICNCFDNOneofCase.ExtraId:
			ExtraId = other.ExtraId;
			break;
		}
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GFLKDHPBAMJ Clone()
	{
		return new GFLKDHPBAMJ(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearMessageText()
	{
		if (HasMessageText)
		{
			ClearAFLLICNCFDN();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearExtraId()
	{
		if (HasExtraId)
		{
			ClearAFLLICNCFDN();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearAFLLICNCFDN()
	{
		aFLLICNCFDNCase_ = AFLLICNCFDNOneofCase.None;
		aFLLICNCFDN_ = null;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GFLKDHPBAMJ);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GFLKDHPBAMJ other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (MessageText != other.MessageText)
		{
			return false;
		}
		if (ExtraId != other.ExtraId)
		{
			return false;
		}
		if (AFLLICNCFDNCase != other.AFLLICNCFDNCase)
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
		if (HasMessageText)
		{
			num ^= MessageText.GetHashCode();
		}
		if (HasExtraId)
		{
			num ^= ExtraId.GetHashCode();
		}
		num ^= (int)aFLLICNCFDNCase_;
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
		if (HasMessageText)
		{
			output.WriteRawTag(10);
			output.WriteString(MessageText);
		}
		if (HasExtraId)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(ExtraId);
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
		if (HasMessageText)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(MessageText);
		}
		if (HasExtraId)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ExtraId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GFLKDHPBAMJ other)
	{
		if (other != null)
		{
			switch (other.AFLLICNCFDNCase)
			{
			case AFLLICNCFDNOneofCase.MessageText:
				MessageText = other.MessageText;
				break;
			case AFLLICNCFDNOneofCase.ExtraId:
				ExtraId = other.ExtraId;
				break;
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
			switch (num)
			{
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 10u:
				MessageText = input.ReadString();
				break;
			case 16u:
				ExtraId = input.ReadUInt32();
				break;
			}
		}
	}
}
