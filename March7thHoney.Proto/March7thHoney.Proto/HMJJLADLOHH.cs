using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class HMJJLADLOHH : IMessage<HMJJLADLOHH>, IMessage, IEquatable<HMJJLADLOHH>, IDeepCloneable<HMJJLADLOHH>, IBufferMessage
{
	private static readonly MessageParser<HMJJLADLOHH> _parser = new MessageParser<HMJJLADLOHH>(() => new HMJJLADLOHH());

	private UnknownFieldSet _unknownFields;

	public const int NOAOFGEJFEKFieldNumber = 3;

	private NGAIELABHPM nOAOFGEJFEK_;

	public const int DisplayValueFieldNumber = 8;

	private uint displayValue_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<HMJJLADLOHH> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => HMJJLADLOHHReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NGAIELABHPM NOAOFGEJFEK
	{
		get
		{
			return nOAOFGEJFEK_;
		}
		set
		{
			nOAOFGEJFEK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint DisplayValue
	{
		get
		{
			return displayValue_;
		}
		set
		{
			displayValue_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HMJJLADLOHH()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HMJJLADLOHH(HMJJLADLOHH other)
		: this()
	{
		nOAOFGEJFEK_ = other.nOAOFGEJFEK_;
		displayValue_ = other.displayValue_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HMJJLADLOHH Clone()
	{
		return new HMJJLADLOHH(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as HMJJLADLOHH);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(HMJJLADLOHH other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (NOAOFGEJFEK != other.NOAOFGEJFEK)
		{
			return false;
		}
		if (DisplayValue != other.DisplayValue)
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
		if (NOAOFGEJFEK != NGAIELABHPM.Pcpdhelpkem)
		{
			num ^= NOAOFGEJFEK.GetHashCode();
		}
		if (DisplayValue != 0)
		{
			num ^= DisplayValue.GetHashCode();
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
		if (NOAOFGEJFEK != NGAIELABHPM.Pcpdhelpkem)
		{
			output.WriteRawTag(24);
			output.WriteEnum((int)NOAOFGEJFEK);
		}
		if (DisplayValue != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(DisplayValue);
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
		if (NOAOFGEJFEK != NGAIELABHPM.Pcpdhelpkem)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)NOAOFGEJFEK);
		}
		if (DisplayValue != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DisplayValue);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(HMJJLADLOHH other)
	{
		if (other != null)
		{
			if (other.NOAOFGEJFEK != NGAIELABHPM.Pcpdhelpkem)
			{
				NOAOFGEJFEK = other.NOAOFGEJFEK;
			}
			if (other.DisplayValue != 0)
			{
				DisplayValue = other.DisplayValue;
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
			case 24u:
				NOAOFGEJFEK = (NGAIELABHPM)input.ReadEnum();
				break;
			case 64u:
				DisplayValue = input.ReadUInt32();
				break;
			}
		}
	}
}
