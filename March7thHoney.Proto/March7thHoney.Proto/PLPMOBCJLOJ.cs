using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class PLPMOBCJLOJ : IMessage<PLPMOBCJLOJ>, IMessage, IEquatable<PLPMOBCJLOJ>, IDeepCloneable<PLPMOBCJLOJ>, IBufferMessage
{
	private static readonly MessageParser<PLPMOBCJLOJ> _parser = new MessageParser<PLPMOBCJLOJ>(() => new PLPMOBCJLOJ());

	private UnknownFieldSet _unknownFields;

	public const int NLEAPFFAFEEFieldNumber = 6;

	private uint nLEAPFFAFEE_;

	public const int RetcodeFieldNumber = 7;

	private uint retcode_;

	public const int ACMGBNNEACJFieldNumber = 12;

	private bool aCMGBNNEACJ_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PLPMOBCJLOJ> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PLPMOBCJLOJReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint NLEAPFFAFEE
	{
		get
		{
			return nLEAPFFAFEE_;
		}
		set
		{
			nLEAPFFAFEE_ = value;
		}
	}

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
	public bool ACMGBNNEACJ
	{
		get
		{
			return aCMGBNNEACJ_;
		}
		set
		{
			aCMGBNNEACJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PLPMOBCJLOJ()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PLPMOBCJLOJ(PLPMOBCJLOJ other)
		: this()
	{
		nLEAPFFAFEE_ = other.nLEAPFFAFEE_;
		retcode_ = other.retcode_;
		aCMGBNNEACJ_ = other.aCMGBNNEACJ_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PLPMOBCJLOJ Clone()
	{
		return new PLPMOBCJLOJ(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PLPMOBCJLOJ);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PLPMOBCJLOJ other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (NLEAPFFAFEE != other.NLEAPFFAFEE)
		{
			return false;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (ACMGBNNEACJ != other.ACMGBNNEACJ)
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
		if (NLEAPFFAFEE != 0)
		{
			num ^= NLEAPFFAFEE.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (ACMGBNNEACJ)
		{
			num ^= ACMGBNNEACJ.GetHashCode();
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
		if (NLEAPFFAFEE != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(NLEAPFFAFEE);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(Retcode);
		}
		if (ACMGBNNEACJ)
		{
			output.WriteRawTag(96);
			output.WriteBool(ACMGBNNEACJ);
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
		if (NLEAPFFAFEE != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(NLEAPFFAFEE);
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (ACMGBNNEACJ)
		{
			num += 2;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PLPMOBCJLOJ other)
	{
		if (other != null)
		{
			if (other.NLEAPFFAFEE != 0)
			{
				NLEAPFFAFEE = other.NLEAPFFAFEE;
			}
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
			}
			if (other.ACMGBNNEACJ)
			{
				ACMGBNNEACJ = other.ACMGBNNEACJ;
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
			case 48u:
				NLEAPFFAFEE = input.ReadUInt32();
				break;
			case 56u:
				Retcode = input.ReadUInt32();
				break;
			case 96u:
				ACMGBNNEACJ = input.ReadBool();
				break;
			}
		}
	}
}
