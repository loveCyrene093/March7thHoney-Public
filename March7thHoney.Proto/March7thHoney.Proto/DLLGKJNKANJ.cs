using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class DLLGKJNKANJ : IMessage<DLLGKJNKANJ>, IMessage, IEquatable<DLLGKJNKANJ>, IDeepCloneable<DLLGKJNKANJ>, IBufferMessage
{
	private static readonly MessageParser<DLLGKJNKANJ> _parser = new MessageParser<DLLGKJNKANJ>(() => new DLLGKJNKANJ());

	private UnknownFieldSet _unknownFields;

	public const int ReasonFieldNumber = 5;

	private MFJBNCDAHJK reason_;

	public const int DataFieldNumber = 8;

	private ACPMKPLOBEF data_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<DLLGKJNKANJ> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => DLLGKJNKANJReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MFJBNCDAHJK Reason
	{
		get
		{
			return reason_;
		}
		set
		{
			reason_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ACPMKPLOBEF Data
	{
		get
		{
			return data_;
		}
		set
		{
			data_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DLLGKJNKANJ()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DLLGKJNKANJ(DLLGKJNKANJ other)
		: this()
	{
		reason_ = other.reason_;
		data_ = ((other.data_ != null) ? other.data_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DLLGKJNKANJ Clone()
	{
		return new DLLGKJNKANJ(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as DLLGKJNKANJ);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(DLLGKJNKANJ other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Reason != other.Reason)
		{
			return false;
		}
		if (!object.Equals(Data, other.Data))
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
		if (Reason != MFJBNCDAHJK.Lecnfagcfnh)
		{
			num ^= Reason.GetHashCode();
		}
		if (data_ != null)
		{
			num ^= Data.GetHashCode();
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
		if (Reason != MFJBNCDAHJK.Lecnfagcfnh)
		{
			output.WriteRawTag(40);
			output.WriteEnum((int)Reason);
		}
		if (data_ != null)
		{
			output.WriteRawTag(66);
			output.WriteMessage(Data);
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
		if (Reason != MFJBNCDAHJK.Lecnfagcfnh)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Reason);
		}
		if (data_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Data);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(DLLGKJNKANJ other)
	{
		if (other == null)
		{
			return;
		}
		if (other.Reason != MFJBNCDAHJK.Lecnfagcfnh)
		{
			Reason = other.Reason;
		}
		if (other.data_ != null)
		{
			if (data_ == null)
			{
				Data = new ACPMKPLOBEF();
			}
			Data.MergeFrom(other.Data);
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
			switch (num)
			{
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 40u:
				Reason = (MFJBNCDAHJK)input.ReadEnum();
				break;
			case 66u:
				if (data_ == null)
				{
					Data = new ACPMKPLOBEF();
				}
				input.ReadMessage(Data);
				break;
			}
		}
	}
}
