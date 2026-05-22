using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class JKPKDPHIPHD : IMessage<JKPKDPHIPHD>, IMessage, IEquatable<JKPKDPHIPHD>, IDeepCloneable<JKPKDPHIPHD>, IBufferMessage
{
	private static readonly MessageParser<JKPKDPHIPHD> _parser = new MessageParser<JKPKDPHIPHD>(() => new JKPKDPHIPHD());

	private UnknownFieldSet _unknownFields;

	public const int RetcodeFieldNumber = 3;

	private uint retcode_;

	public const int HEJAOOCHEFGFieldNumber = 15;

	private uint hEJAOOCHEFG_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<JKPKDPHIPHD> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => JKPKDPHIPHDReflection.Descriptor.MessageTypes[0];

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
	public uint HEJAOOCHEFG
	{
		get
		{
			return hEJAOOCHEFG_;
		}
		set
		{
			hEJAOOCHEFG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JKPKDPHIPHD()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JKPKDPHIPHD(JKPKDPHIPHD other)
		: this()
	{
		retcode_ = other.retcode_;
		hEJAOOCHEFG_ = other.hEJAOOCHEFG_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JKPKDPHIPHD Clone()
	{
		return new JKPKDPHIPHD(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as JKPKDPHIPHD);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(JKPKDPHIPHD other)
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
		if (HEJAOOCHEFG != other.HEJAOOCHEFG)
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
		if (HEJAOOCHEFG != 0)
		{
			num ^= HEJAOOCHEFG.GetHashCode();
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
			output.WriteRawTag(24);
			output.WriteUInt32(Retcode);
		}
		if (HEJAOOCHEFG != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(HEJAOOCHEFG);
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
		if (HEJAOOCHEFG != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(HEJAOOCHEFG);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(JKPKDPHIPHD other)
	{
		if (other != null)
		{
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
			}
			if (other.HEJAOOCHEFG != 0)
			{
				HEJAOOCHEFG = other.HEJAOOCHEFG;
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
				Retcode = input.ReadUInt32();
				break;
			case 120u:
				HEJAOOCHEFG = input.ReadUInt32();
				break;
			}
		}
	}
}
