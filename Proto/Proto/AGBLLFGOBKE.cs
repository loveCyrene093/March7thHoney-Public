using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class AGBLLFGOBKE : IMessage<AGBLLFGOBKE>, IMessage, IEquatable<AGBLLFGOBKE>, IDeepCloneable<AGBLLFGOBKE>, IBufferMessage
{
	private static readonly MessageParser<AGBLLFGOBKE> _parser = new MessageParser<AGBLLFGOBKE>(() => new AGBLLFGOBKE());

	private UnknownFieldSet _unknownFields;

	public const int JFFIKCFLBCHFieldNumber = 2;

	private uint jFFIKCFLBCH_;

	public const int IFDKELBKILFFieldNumber = 11;

	private int iFDKELBKILF_;

	public const int ABCKMKFKAHBFieldNumber = 14;

	private uint aBCKMKFKAHB_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<AGBLLFGOBKE> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => AGBLLFGOBKEReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint JFFIKCFLBCH
	{
		get
		{
			return jFFIKCFLBCH_;
		}
		set
		{
			jFFIKCFLBCH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int IFDKELBKILF
	{
		get
		{
			return iFDKELBKILF_;
		}
		set
		{
			iFDKELBKILF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ABCKMKFKAHB
	{
		get
		{
			return aBCKMKFKAHB_;
		}
		set
		{
			aBCKMKFKAHB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AGBLLFGOBKE()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AGBLLFGOBKE(AGBLLFGOBKE other)
		: this()
	{
		jFFIKCFLBCH_ = other.jFFIKCFLBCH_;
		iFDKELBKILF_ = other.iFDKELBKILF_;
		aBCKMKFKAHB_ = other.aBCKMKFKAHB_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AGBLLFGOBKE Clone()
	{
		return new AGBLLFGOBKE(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as AGBLLFGOBKE);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(AGBLLFGOBKE other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (JFFIKCFLBCH != other.JFFIKCFLBCH)
		{
			return false;
		}
		if (IFDKELBKILF != other.IFDKELBKILF)
		{
			return false;
		}
		if (ABCKMKFKAHB != other.ABCKMKFKAHB)
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
		if (JFFIKCFLBCH != 0)
		{
			num ^= JFFIKCFLBCH.GetHashCode();
		}
		if (IFDKELBKILF != 0)
		{
			num ^= IFDKELBKILF.GetHashCode();
		}
		if (ABCKMKFKAHB != 0)
		{
			num ^= ABCKMKFKAHB.GetHashCode();
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
		if (JFFIKCFLBCH != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(JFFIKCFLBCH);
		}
		if (IFDKELBKILF != 0)
		{
			output.WriteRawTag(88);
			output.WriteInt32(IFDKELBKILF);
		}
		if (ABCKMKFKAHB != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(ABCKMKFKAHB);
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
		if (JFFIKCFLBCH != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(JFFIKCFLBCH);
		}
		if (IFDKELBKILF != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(IFDKELBKILF);
		}
		if (ABCKMKFKAHB != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ABCKMKFKAHB);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(AGBLLFGOBKE other)
	{
		if (other != null)
		{
			if (other.JFFIKCFLBCH != 0)
			{
				JFFIKCFLBCH = other.JFFIKCFLBCH;
			}
			if (other.IFDKELBKILF != 0)
			{
				IFDKELBKILF = other.IFDKELBKILF;
			}
			if (other.ABCKMKFKAHB != 0)
			{
				ABCKMKFKAHB = other.ABCKMKFKAHB;
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
			case 16u:
				JFFIKCFLBCH = input.ReadUInt32();
				break;
			case 88u:
				IFDKELBKILF = input.ReadInt32();
				break;
			case 112u:
				ABCKMKFKAHB = input.ReadUInt32();
				break;
			}
		}
	}
}
