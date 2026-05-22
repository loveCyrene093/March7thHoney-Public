using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class NNHGOBLNCIE : IMessage<NNHGOBLNCIE>, IMessage, IEquatable<NNHGOBLNCIE>, IDeepCloneable<NNHGOBLNCIE>, IBufferMessage
{
	private static readonly MessageParser<NNHGOBLNCIE> _parser = new MessageParser<NNHGOBLNCIE>(() => new NNHGOBLNCIE());

	private UnknownFieldSet _unknownFields;

	public const int ELKOCIJNABKFieldNumber = 4;

	private int eLKOCIJNABK_;

	public const int ELNCJFFJFIHFieldNumber = 8;

	private string eLNCJFFJFIH_ = "";

	public const int FNAODNGJAMMFieldNumber = 11;

	private int fNAODNGJAMM_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<NNHGOBLNCIE> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => NNHGOBLNCIEReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int ELKOCIJNABK
	{
		get
		{
			return eLKOCIJNABK_;
		}
		set
		{
			eLKOCIJNABK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string ELNCJFFJFIH
	{
		get
		{
			return eLNCJFFJFIH_;
		}
		set
		{
			eLNCJFFJFIH_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int FNAODNGJAMM
	{
		get
		{
			return fNAODNGJAMM_;
		}
		set
		{
			fNAODNGJAMM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NNHGOBLNCIE()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NNHGOBLNCIE(NNHGOBLNCIE other)
		: this()
	{
		eLKOCIJNABK_ = other.eLKOCIJNABK_;
		eLNCJFFJFIH_ = other.eLNCJFFJFIH_;
		fNAODNGJAMM_ = other.fNAODNGJAMM_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NNHGOBLNCIE Clone()
	{
		return new NNHGOBLNCIE(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as NNHGOBLNCIE);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(NNHGOBLNCIE other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ELKOCIJNABK != other.ELKOCIJNABK)
		{
			return false;
		}
		if (ELNCJFFJFIH != other.ELNCJFFJFIH)
		{
			return false;
		}
		if (FNAODNGJAMM != other.FNAODNGJAMM)
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
		if (ELKOCIJNABK != 0)
		{
			num ^= ELKOCIJNABK.GetHashCode();
		}
		if (ELNCJFFJFIH.Length != 0)
		{
			num ^= ELNCJFFJFIH.GetHashCode();
		}
		if (FNAODNGJAMM != 0)
		{
			num ^= FNAODNGJAMM.GetHashCode();
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
		if (ELKOCIJNABK != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(ELKOCIJNABK);
		}
		if (ELNCJFFJFIH.Length != 0)
		{
			output.WriteRawTag(66);
			output.WriteString(ELNCJFFJFIH);
		}
		if (FNAODNGJAMM != 0)
		{
			output.WriteRawTag(88);
			output.WriteInt32(FNAODNGJAMM);
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
		if (ELKOCIJNABK != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ELKOCIJNABK);
		}
		if (ELNCJFFJFIH.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(ELNCJFFJFIH);
		}
		if (FNAODNGJAMM != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(FNAODNGJAMM);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(NNHGOBLNCIE other)
	{
		if (other != null)
		{
			if (other.ELKOCIJNABK != 0)
			{
				ELKOCIJNABK = other.ELKOCIJNABK;
			}
			if (other.ELNCJFFJFIH.Length != 0)
			{
				ELNCJFFJFIH = other.ELNCJFFJFIH;
			}
			if (other.FNAODNGJAMM != 0)
			{
				FNAODNGJAMM = other.FNAODNGJAMM;
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
			case 32u:
				ELKOCIJNABK = input.ReadInt32();
				break;
			case 66u:
				ELNCJFFJFIH = input.ReadString();
				break;
			case 88u:
				FNAODNGJAMM = input.ReadInt32();
				break;
			}
		}
	}
}
