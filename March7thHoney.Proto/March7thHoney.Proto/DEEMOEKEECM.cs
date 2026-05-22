using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class DEEMOEKEECM : IMessage<DEEMOEKEECM>, IMessage, IEquatable<DEEMOEKEECM>, IDeepCloneable<DEEMOEKEECM>, IBufferMessage
{
	private static readonly MessageParser<DEEMOEKEECM> _parser = new MessageParser<DEEMOEKEECM>(() => new DEEMOEKEECM());

	private UnknownFieldSet _unknownFields;

	public const int PENLMEIJIFKFieldNumber = 1;

	private uint pENLMEIJIFK_;

	public const int EFLLPPLCKBBFieldNumber = 7;

	private ulong eFLLPPLCKBB_;

	public const int MPGFGKDBAHNFieldNumber = 12;

	private bool mPGFGKDBAHN_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<DEEMOEKEECM> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => DEEMOEKEECMReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PENLMEIJIFK
	{
		get
		{
			return pENLMEIJIFK_;
		}
		set
		{
			pENLMEIJIFK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ulong EFLLPPLCKBB
	{
		get
		{
			return eFLLPPLCKBB_;
		}
		set
		{
			eFLLPPLCKBB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool MPGFGKDBAHN
	{
		get
		{
			return mPGFGKDBAHN_;
		}
		set
		{
			mPGFGKDBAHN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DEEMOEKEECM()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DEEMOEKEECM(DEEMOEKEECM other)
		: this()
	{
		pENLMEIJIFK_ = other.pENLMEIJIFK_;
		eFLLPPLCKBB_ = other.eFLLPPLCKBB_;
		mPGFGKDBAHN_ = other.mPGFGKDBAHN_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DEEMOEKEECM Clone()
	{
		return new DEEMOEKEECM(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as DEEMOEKEECM);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(DEEMOEKEECM other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (PENLMEIJIFK != other.PENLMEIJIFK)
		{
			return false;
		}
		if (EFLLPPLCKBB != other.EFLLPPLCKBB)
		{
			return false;
		}
		if (MPGFGKDBAHN != other.MPGFGKDBAHN)
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
		if (PENLMEIJIFK != 0)
		{
			num ^= PENLMEIJIFK.GetHashCode();
		}
		if (EFLLPPLCKBB != 0L)
		{
			num ^= EFLLPPLCKBB.GetHashCode();
		}
		if (MPGFGKDBAHN)
		{
			num ^= MPGFGKDBAHN.GetHashCode();
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
		if (PENLMEIJIFK != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(PENLMEIJIFK);
		}
		if (EFLLPPLCKBB != 0L)
		{
			output.WriteRawTag(56);
			output.WriteUInt64(EFLLPPLCKBB);
		}
		if (MPGFGKDBAHN)
		{
			output.WriteRawTag(96);
			output.WriteBool(MPGFGKDBAHN);
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
		if (PENLMEIJIFK != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PENLMEIJIFK);
		}
		if (EFLLPPLCKBB != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(EFLLPPLCKBB);
		}
		if (MPGFGKDBAHN)
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
	public void MergeFrom(DEEMOEKEECM other)
	{
		if (other != null)
		{
			if (other.PENLMEIJIFK != 0)
			{
				PENLMEIJIFK = other.PENLMEIJIFK;
			}
			if (other.EFLLPPLCKBB != 0L)
			{
				EFLLPPLCKBB = other.EFLLPPLCKBB;
			}
			if (other.MPGFGKDBAHN)
			{
				MPGFGKDBAHN = other.MPGFGKDBAHN;
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
			case 8u:
				PENLMEIJIFK = input.ReadUInt32();
				break;
			case 56u:
				EFLLPPLCKBB = input.ReadUInt64();
				break;
			case 96u:
				MPGFGKDBAHN = input.ReadBool();
				break;
			}
		}
	}
}
