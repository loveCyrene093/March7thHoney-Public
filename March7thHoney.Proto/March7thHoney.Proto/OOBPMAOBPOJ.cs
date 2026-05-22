using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class OOBPMAOBPOJ : IMessage<OOBPMAOBPOJ>, IMessage, IEquatable<OOBPMAOBPOJ>, IDeepCloneable<OOBPMAOBPOJ>, IBufferMessage
{
	private static readonly MessageParser<OOBPMAOBPOJ> _parser = new MessageParser<OOBPMAOBPOJ>(() => new OOBPMAOBPOJ());

	private UnknownFieldSet _unknownFields;

	public const int EMLIJIBPBFLFieldNumber = 5;

	private uint eMLIJIBPBFL_;

	public const int KLHDCOPPLNGFieldNumber = 10;

	private bool kLHDCOPPLNG_;

	public const int ProgressFieldNumber = 14;

	private uint progress_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<OOBPMAOBPOJ> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => OOBPMAOBPOJReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint EMLIJIBPBFL
	{
		get
		{
			return eMLIJIBPBFL_;
		}
		set
		{
			eMLIJIBPBFL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool KLHDCOPPLNG
	{
		get
		{
			return kLHDCOPPLNG_;
		}
		set
		{
			kLHDCOPPLNG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Progress
	{
		get
		{
			return progress_;
		}
		set
		{
			progress_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OOBPMAOBPOJ()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OOBPMAOBPOJ(OOBPMAOBPOJ other)
		: this()
	{
		eMLIJIBPBFL_ = other.eMLIJIBPBFL_;
		kLHDCOPPLNG_ = other.kLHDCOPPLNG_;
		progress_ = other.progress_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OOBPMAOBPOJ Clone()
	{
		return new OOBPMAOBPOJ(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as OOBPMAOBPOJ);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(OOBPMAOBPOJ other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (EMLIJIBPBFL != other.EMLIJIBPBFL)
		{
			return false;
		}
		if (KLHDCOPPLNG != other.KLHDCOPPLNG)
		{
			return false;
		}
		if (Progress != other.Progress)
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
		if (EMLIJIBPBFL != 0)
		{
			num ^= EMLIJIBPBFL.GetHashCode();
		}
		if (KLHDCOPPLNG)
		{
			num ^= KLHDCOPPLNG.GetHashCode();
		}
		if (Progress != 0)
		{
			num ^= Progress.GetHashCode();
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
		if (EMLIJIBPBFL != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(EMLIJIBPBFL);
		}
		if (KLHDCOPPLNG)
		{
			output.WriteRawTag(80);
			output.WriteBool(KLHDCOPPLNG);
		}
		if (Progress != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(Progress);
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
		if (EMLIJIBPBFL != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EMLIJIBPBFL);
		}
		if (KLHDCOPPLNG)
		{
			num += 2;
		}
		if (Progress != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Progress);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(OOBPMAOBPOJ other)
	{
		if (other != null)
		{
			if (other.EMLIJIBPBFL != 0)
			{
				EMLIJIBPBFL = other.EMLIJIBPBFL;
			}
			if (other.KLHDCOPPLNG)
			{
				KLHDCOPPLNG = other.KLHDCOPPLNG;
			}
			if (other.Progress != 0)
			{
				Progress = other.Progress;
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
			case 40u:
				EMLIJIBPBFL = input.ReadUInt32();
				break;
			case 80u:
				KLHDCOPPLNG = input.ReadBool();
				break;
			case 112u:
				Progress = input.ReadUInt32();
				break;
			}
		}
	}
}
