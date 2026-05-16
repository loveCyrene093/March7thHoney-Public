using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class BJMHMKBBJGH : IMessage<BJMHMKBBJGH>, IMessage, IEquatable<BJMHMKBBJGH>, IDeepCloneable<BJMHMKBBJGH>, IBufferMessage
{
	private static readonly MessageParser<BJMHMKBBJGH> _parser = new MessageParser<BJMHMKBBJGH>(() => new BJMHMKBBJGH());

	private UnknownFieldSet _unknownFields;

	public const int PHKAHAHLDAEFieldNumber = 8;

	private uint pHKAHAHLDAE_;

	public const int NumFieldNumber = 15;

	private uint num_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<BJMHMKBBJGH> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => BJMHMKBBJGHReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PHKAHAHLDAE
	{
		get
		{
			return pHKAHAHLDAE_;
		}
		set
		{
			pHKAHAHLDAE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Num
	{
		get
		{
			return num_;
		}
		set
		{
			num_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BJMHMKBBJGH()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BJMHMKBBJGH(BJMHMKBBJGH other)
		: this()
	{
		pHKAHAHLDAE_ = other.pHKAHAHLDAE_;
		num_ = other.num_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BJMHMKBBJGH Clone()
	{
		return new BJMHMKBBJGH(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as BJMHMKBBJGH);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(BJMHMKBBJGH other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (PHKAHAHLDAE != other.PHKAHAHLDAE)
		{
			return false;
		}
		if (Num != other.Num)
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
		if (PHKAHAHLDAE != 0)
		{
			num ^= PHKAHAHLDAE.GetHashCode();
		}
		if (Num != 0)
		{
			num ^= Num.GetHashCode();
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
		if (PHKAHAHLDAE != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(PHKAHAHLDAE);
		}
		if (Num != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(Num);
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
		if (PHKAHAHLDAE != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PHKAHAHLDAE);
		}
		if (Num != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Num);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(BJMHMKBBJGH other)
	{
		if (other != null)
		{
			if (other.PHKAHAHLDAE != 0)
			{
				PHKAHAHLDAE = other.PHKAHAHLDAE;
			}
			if (other.Num != 0)
			{
				Num = other.Num;
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
			case 64u:
				PHKAHAHLDAE = input.ReadUInt32();
				break;
			case 120u:
				Num = input.ReadUInt32();
				break;
			}
		}
	}
}
