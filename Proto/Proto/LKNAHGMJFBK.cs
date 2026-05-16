using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class LKNAHGMJFBK : IMessage<LKNAHGMJFBK>, IMessage, IEquatable<LKNAHGMJFBK>, IDeepCloneable<LKNAHGMJFBK>, IBufferMessage
{
	private static readonly MessageParser<LKNAHGMJFBK> _parser = new MessageParser<LKNAHGMJFBK>(() => new LKNAHGMJFBK());

	private UnknownFieldSet _unknownFields;

	public const int NJELGEBHAOPFieldNumber = 14;

	private OBECBMMMDHC nJELGEBHAOP_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<LKNAHGMJFBK> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => LKNAHGMJFBKReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OBECBMMMDHC NJELGEBHAOP
	{
		get
		{
			return nJELGEBHAOP_;
		}
		set
		{
			nJELGEBHAOP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LKNAHGMJFBK()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LKNAHGMJFBK(LKNAHGMJFBK other)
		: this()
	{
		nJELGEBHAOP_ = ((other.nJELGEBHAOP_ != null) ? other.nJELGEBHAOP_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LKNAHGMJFBK Clone()
	{
		return new LKNAHGMJFBK(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as LKNAHGMJFBK);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(LKNAHGMJFBK other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(NJELGEBHAOP, other.NJELGEBHAOP))
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
		if (nJELGEBHAOP_ != null)
		{
			num ^= NJELGEBHAOP.GetHashCode();
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
		if (nJELGEBHAOP_ != null)
		{
			output.WriteRawTag(114);
			output.WriteMessage(NJELGEBHAOP);
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
		if (nJELGEBHAOP_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(NJELGEBHAOP);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(LKNAHGMJFBK other)
	{
		if (other == null)
		{
			return;
		}
		if (other.nJELGEBHAOP_ != null)
		{
			if (nJELGEBHAOP_ == null)
			{
				NJELGEBHAOP = new OBECBMMMDHC();
			}
			NJELGEBHAOP.MergeFrom(other.NJELGEBHAOP);
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
			if (num != 114)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				continue;
			}
			if (nJELGEBHAOP_ == null)
			{
				NJELGEBHAOP = new OBECBMMMDHC();
			}
			input.ReadMessage(NJELGEBHAOP);
		}
	}
}
