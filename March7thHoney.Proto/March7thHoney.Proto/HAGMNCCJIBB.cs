using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class HAGMNCCJIBB : IMessage<HAGMNCCJIBB>, IMessage, IEquatable<HAGMNCCJIBB>, IDeepCloneable<HAGMNCCJIBB>, IBufferMessage
{
	private static readonly MessageParser<HAGMNCCJIBB> _parser = new MessageParser<HAGMNCCJIBB>(() => new HAGMNCCJIBB());

	private UnknownFieldSet _unknownFields;

	public const int KickTypeFieldNumber = 4;

	private BJFJFCDPFNG kickType_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<HAGMNCCJIBB> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => HAGMNCCJIBBReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BJFJFCDPFNG KickType
	{
		get
		{
			return kickType_;
		}
		set
		{
			kickType_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HAGMNCCJIBB()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HAGMNCCJIBB(HAGMNCCJIBB other)
		: this()
	{
		kickType_ = other.kickType_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HAGMNCCJIBB Clone()
	{
		return new HAGMNCCJIBB(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as HAGMNCCJIBB);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(HAGMNCCJIBB other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (KickType != other.KickType)
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
		if (KickType != BJFJFCDPFNG.Dfnbodimigl)
		{
			num ^= KickType.GetHashCode();
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
		if (KickType != BJFJFCDPFNG.Dfnbodimigl)
		{
			output.WriteRawTag(32);
			output.WriteEnum((int)KickType);
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
		if (KickType != BJFJFCDPFNG.Dfnbodimigl)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)KickType);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(HAGMNCCJIBB other)
	{
		if (other != null)
		{
			if (other.KickType != BJFJFCDPFNG.Dfnbodimigl)
			{
				KickType = other.KickType;
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
			if (num != 32)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				KickType = (BJFJFCDPFNG)input.ReadEnum();
			}
		}
	}
}
