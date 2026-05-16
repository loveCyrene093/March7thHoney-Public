using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class CNLKOLHEJDD : IMessage<CNLKOLHEJDD>, IMessage, IEquatable<CNLKOLHEJDD>, IDeepCloneable<CNLKOLHEJDD>, IBufferMessage
{
	private static readonly MessageParser<CNLKOLHEJDD> _parser = new MessageParser<CNLKOLHEJDD>(() => new CNLKOLHEJDD());

	private UnknownFieldSet _unknownFields;

	public const int AOKDBDGDCHBFieldNumber = 2;

	private uint aOKDBDGDCHB_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CNLKOLHEJDD> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => CNLKOLHEJDDReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint AOKDBDGDCHB
	{
		get
		{
			return aOKDBDGDCHB_;
		}
		set
		{
			aOKDBDGDCHB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CNLKOLHEJDD()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CNLKOLHEJDD(CNLKOLHEJDD other)
		: this()
	{
		aOKDBDGDCHB_ = other.aOKDBDGDCHB_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CNLKOLHEJDD Clone()
	{
		return new CNLKOLHEJDD(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as CNLKOLHEJDD);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CNLKOLHEJDD other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (AOKDBDGDCHB != other.AOKDBDGDCHB)
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
		if (AOKDBDGDCHB != 0)
		{
			num ^= AOKDBDGDCHB.GetHashCode();
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
		if (AOKDBDGDCHB != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(AOKDBDGDCHB);
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
		if (AOKDBDGDCHB != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AOKDBDGDCHB);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CNLKOLHEJDD other)
	{
		if (other != null)
		{
			if (other.AOKDBDGDCHB != 0)
			{
				AOKDBDGDCHB = other.AOKDBDGDCHB;
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
			if (num != 16)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				AOKDBDGDCHB = input.ReadUInt32();
			}
		}
	}
}
