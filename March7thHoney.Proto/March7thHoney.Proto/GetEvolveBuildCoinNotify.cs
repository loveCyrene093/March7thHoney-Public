using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GetEvolveBuildCoinNotify : IMessage<GetEvolveBuildCoinNotify>, IMessage, IEquatable<GetEvolveBuildCoinNotify>, IDeepCloneable<GetEvolveBuildCoinNotify>, IBufferMessage
{
	private static readonly MessageParser<GetEvolveBuildCoinNotify> _parser = new MessageParser<GetEvolveBuildCoinNotify>(() => new GetEvolveBuildCoinNotify());

	private UnknownFieldSet _unknownFields;

	public const int ItemValueFieldNumber = 1;

	private uint itemValue_;

	public const int EGLCKGKECAJFieldNumber = 13;

	private GCHPNHBDCDO eGLCKGKECAJ_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GetEvolveBuildCoinNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GetEvolveBuildCoinNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ItemValue
	{
		get
		{
			return itemValue_;
		}
		set
		{
			itemValue_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GCHPNHBDCDO EGLCKGKECAJ
	{
		get
		{
			return eGLCKGKECAJ_;
		}
		set
		{
			eGLCKGKECAJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetEvolveBuildCoinNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetEvolveBuildCoinNotify(GetEvolveBuildCoinNotify other)
		: this()
	{
		itemValue_ = other.itemValue_;
		eGLCKGKECAJ_ = other.eGLCKGKECAJ_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetEvolveBuildCoinNotify Clone()
	{
		return new GetEvolveBuildCoinNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GetEvolveBuildCoinNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GetEvolveBuildCoinNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ItemValue != other.ItemValue)
		{
			return false;
		}
		if (EGLCKGKECAJ != other.EGLCKGKECAJ)
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
		if (ItemValue != 0)
		{
			num ^= ItemValue.GetHashCode();
		}
		if (EGLCKGKECAJ != GCHPNHBDCDO.Bfkfdkmglho)
		{
			num ^= EGLCKGKECAJ.GetHashCode();
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
		if (ItemValue != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(ItemValue);
		}
		if (EGLCKGKECAJ != GCHPNHBDCDO.Bfkfdkmglho)
		{
			output.WriteRawTag(104);
			output.WriteEnum((int)EGLCKGKECAJ);
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
		if (ItemValue != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ItemValue);
		}
		if (EGLCKGKECAJ != GCHPNHBDCDO.Bfkfdkmglho)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)EGLCKGKECAJ);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GetEvolveBuildCoinNotify other)
	{
		if (other != null)
		{
			if (other.ItemValue != 0)
			{
				ItemValue = other.ItemValue;
			}
			if (other.EGLCKGKECAJ != GCHPNHBDCDO.Bfkfdkmglho)
			{
				EGLCKGKECAJ = other.EGLCKGKECAJ;
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
			case 8u:
				ItemValue = input.ReadUInt32();
				break;
			case 104u:
				EGLCKGKECAJ = (GCHPNHBDCDO)input.ReadEnum();
				break;
			}
		}
	}
}
