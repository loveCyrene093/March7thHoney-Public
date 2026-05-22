using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class IMJMGHCHFAA : IMessage<IMJMGHCHFAA>, IMessage, IEquatable<IMJMGHCHFAA>, IDeepCloneable<IMJMGHCHFAA>, IBufferMessage
{
	private static readonly MessageParser<IMJMGHCHFAA> _parser = new MessageParser<IMJMGHCHFAA>(() => new IMJMGHCHFAA());

	private UnknownFieldSet _unknownFields;

	public const int RetcodeFieldNumber = 10;

	private uint retcode_;

	public const int INCHLHNKHCHFieldNumber = 14;

	private uint iNCHLHNKHCH_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<IMJMGHCHFAA> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => IMJMGHCHFAAReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Retcode
	{
		get
		{
			return retcode_;
		}
		set
		{
			retcode_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint INCHLHNKHCH
	{
		get
		{
			return iNCHLHNKHCH_;
		}
		set
		{
			iNCHLHNKHCH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IMJMGHCHFAA()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IMJMGHCHFAA(IMJMGHCHFAA other)
		: this()
	{
		retcode_ = other.retcode_;
		iNCHLHNKHCH_ = other.iNCHLHNKHCH_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IMJMGHCHFAA Clone()
	{
		return new IMJMGHCHFAA(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as IMJMGHCHFAA);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(IMJMGHCHFAA other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (INCHLHNKHCH != other.INCHLHNKHCH)
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
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (INCHLHNKHCH != 0)
		{
			num ^= INCHLHNKHCH.GetHashCode();
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
		if (Retcode != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(Retcode);
		}
		if (INCHLHNKHCH != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(INCHLHNKHCH);
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
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (INCHLHNKHCH != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(INCHLHNKHCH);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(IMJMGHCHFAA other)
	{
		if (other != null)
		{
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
			}
			if (other.INCHLHNKHCH != 0)
			{
				INCHLHNKHCH = other.INCHLHNKHCH;
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
			case 80u:
				Retcode = input.ReadUInt32();
				break;
			case 112u:
				INCHLHNKHCH = input.ReadUInt32();
				break;
			}
		}
	}
}
