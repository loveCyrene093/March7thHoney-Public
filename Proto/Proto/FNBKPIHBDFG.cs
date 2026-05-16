using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class FNBKPIHBDFG : IMessage<FNBKPIHBDFG>, IMessage, IEquatable<FNBKPIHBDFG>, IDeepCloneable<FNBKPIHBDFG>, IBufferMessage
{
	private static readonly MessageParser<FNBKPIHBDFG> _parser = new MessageParser<FNBKPIHBDFG>(() => new FNBKPIHBDFG());

	private UnknownFieldSet _unknownFields;

	public const int OPHPMKFGLBAFieldNumber = 9;

	private uint oPHPMKFGLBA_;

	public const int JBCCJLLBBAKFieldNumber = 11;

	private static readonly FieldCodec<uint> _repeated_jBCCJLLBBAK_codec = FieldCodec.ForUInt32(90u);

	private readonly RepeatedField<uint> jBCCJLLBBAK_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FNBKPIHBDFG> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => FNBKPIHBDFGReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint OPHPMKFGLBA
	{
		get
		{
			return oPHPMKFGLBA_;
		}
		set
		{
			oPHPMKFGLBA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> JBCCJLLBBAK => jBCCJLLBBAK_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FNBKPIHBDFG()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FNBKPIHBDFG(FNBKPIHBDFG other)
		: this()
	{
		oPHPMKFGLBA_ = other.oPHPMKFGLBA_;
		jBCCJLLBBAK_ = other.jBCCJLLBBAK_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FNBKPIHBDFG Clone()
	{
		return new FNBKPIHBDFG(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as FNBKPIHBDFG);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FNBKPIHBDFG other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (OPHPMKFGLBA != other.OPHPMKFGLBA)
		{
			return false;
		}
		if (!jBCCJLLBBAK_.Equals(other.jBCCJLLBBAK_))
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
		if (OPHPMKFGLBA != 0)
		{
			num ^= OPHPMKFGLBA.GetHashCode();
		}
		num ^= jBCCJLLBBAK_.GetHashCode();
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
		if (OPHPMKFGLBA != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(OPHPMKFGLBA);
		}
		jBCCJLLBBAK_.WriteTo(ref output, _repeated_jBCCJLLBBAK_codec);
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
		if (OPHPMKFGLBA != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(OPHPMKFGLBA);
		}
		num += jBCCJLLBBAK_.CalculateSize(_repeated_jBCCJLLBBAK_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FNBKPIHBDFG other)
	{
		if (other != null)
		{
			if (other.OPHPMKFGLBA != 0)
			{
				OPHPMKFGLBA = other.OPHPMKFGLBA;
			}
			jBCCJLLBBAK_.Add(other.jBCCJLLBBAK_);
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
			case 72u:
				OPHPMKFGLBA = input.ReadUInt32();
				break;
			case 88u:
			case 90u:
				jBCCJLLBBAK_.AddEntriesFrom(ref input, _repeated_jBCCJLLBBAK_codec);
				break;
			}
		}
	}
}
