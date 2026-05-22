using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class NALJFANPFMA : IMessage<NALJFANPFMA>, IMessage, IEquatable<NALJFANPFMA>, IDeepCloneable<NALJFANPFMA>, IBufferMessage
{
	private static readonly MessageParser<NALJFANPFMA> _parser = new MessageParser<NALJFANPFMA>(() => new NALJFANPFMA());

	private UnknownFieldSet _unknownFields;

	public const int MFOKBDCHBECFieldNumber = 2;

	private uint mFOKBDCHBEC_;

	public const int KMJJCKDOBMAFieldNumber = 10;

	private uint kMJJCKDOBMA_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<NALJFANPFMA> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => NALJFANPFMAReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MFOKBDCHBEC
	{
		get
		{
			return mFOKBDCHBEC_;
		}
		set
		{
			mFOKBDCHBEC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint KMJJCKDOBMA
	{
		get
		{
			return kMJJCKDOBMA_;
		}
		set
		{
			kMJJCKDOBMA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NALJFANPFMA()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NALJFANPFMA(NALJFANPFMA other)
		: this()
	{
		mFOKBDCHBEC_ = other.mFOKBDCHBEC_;
		kMJJCKDOBMA_ = other.kMJJCKDOBMA_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NALJFANPFMA Clone()
	{
		return new NALJFANPFMA(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as NALJFANPFMA);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(NALJFANPFMA other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (MFOKBDCHBEC != other.MFOKBDCHBEC)
		{
			return false;
		}
		if (KMJJCKDOBMA != other.KMJJCKDOBMA)
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
		if (MFOKBDCHBEC != 0)
		{
			num ^= MFOKBDCHBEC.GetHashCode();
		}
		if (KMJJCKDOBMA != 0)
		{
			num ^= KMJJCKDOBMA.GetHashCode();
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
		if (MFOKBDCHBEC != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(MFOKBDCHBEC);
		}
		if (KMJJCKDOBMA != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(KMJJCKDOBMA);
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
		if (MFOKBDCHBEC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MFOKBDCHBEC);
		}
		if (KMJJCKDOBMA != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(KMJJCKDOBMA);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(NALJFANPFMA other)
	{
		if (other != null)
		{
			if (other.MFOKBDCHBEC != 0)
			{
				MFOKBDCHBEC = other.MFOKBDCHBEC;
			}
			if (other.KMJJCKDOBMA != 0)
			{
				KMJJCKDOBMA = other.KMJJCKDOBMA;
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
				MFOKBDCHBEC = input.ReadUInt32();
				break;
			case 80u:
				KMJJCKDOBMA = input.ReadUInt32();
				break;
			}
		}
	}
}
