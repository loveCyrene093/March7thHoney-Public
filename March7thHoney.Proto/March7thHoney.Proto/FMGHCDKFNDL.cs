using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class FMGHCDKFNDL : IMessage<FMGHCDKFNDL>, IMessage, IEquatable<FMGHCDKFNDL>, IDeepCloneable<FMGHCDKFNDL>, IBufferMessage
{
	private static readonly MessageParser<FMGHCDKFNDL> _parser = new MessageParser<FMGHCDKFNDL>(() => new FMGHCDKFNDL());

	private UnknownFieldSet _unknownFields;

	public const int JKAICMMPFBBFieldNumber = 7;

	private bool jKAICMMPFBB_;

	public const int BBDOCJGAEEJFieldNumber = 14;

	private uint bBDOCJGAEEJ_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FMGHCDKFNDL> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => FMGHCDKFNDLReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool JKAICMMPFBB
	{
		get
		{
			return jKAICMMPFBB_;
		}
		set
		{
			jKAICMMPFBB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint BBDOCJGAEEJ
	{
		get
		{
			return bBDOCJGAEEJ_;
		}
		set
		{
			bBDOCJGAEEJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FMGHCDKFNDL()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FMGHCDKFNDL(FMGHCDKFNDL other)
		: this()
	{
		jKAICMMPFBB_ = other.jKAICMMPFBB_;
		bBDOCJGAEEJ_ = other.bBDOCJGAEEJ_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FMGHCDKFNDL Clone()
	{
		return new FMGHCDKFNDL(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as FMGHCDKFNDL);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FMGHCDKFNDL other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (JKAICMMPFBB != other.JKAICMMPFBB)
		{
			return false;
		}
		if (BBDOCJGAEEJ != other.BBDOCJGAEEJ)
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
		if (JKAICMMPFBB)
		{
			num ^= JKAICMMPFBB.GetHashCode();
		}
		if (BBDOCJGAEEJ != 0)
		{
			num ^= BBDOCJGAEEJ.GetHashCode();
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
		if (JKAICMMPFBB)
		{
			output.WriteRawTag(56);
			output.WriteBool(JKAICMMPFBB);
		}
		if (BBDOCJGAEEJ != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(BBDOCJGAEEJ);
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
		if (JKAICMMPFBB)
		{
			num += 2;
		}
		if (BBDOCJGAEEJ != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BBDOCJGAEEJ);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FMGHCDKFNDL other)
	{
		if (other != null)
		{
			if (other.JKAICMMPFBB)
			{
				JKAICMMPFBB = other.JKAICMMPFBB;
			}
			if (other.BBDOCJGAEEJ != 0)
			{
				BBDOCJGAEEJ = other.BBDOCJGAEEJ;
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
			case 56u:
				JKAICMMPFBB = input.ReadBool();
				break;
			case 112u:
				BBDOCJGAEEJ = input.ReadUInt32();
				break;
			}
		}
	}
}
