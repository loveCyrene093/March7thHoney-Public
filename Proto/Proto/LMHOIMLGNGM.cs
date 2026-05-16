using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class LMHOIMLGNGM : IMessage<LMHOIMLGNGM>, IMessage, IEquatable<LMHOIMLGNGM>, IDeepCloneable<LMHOIMLGNGM>, IBufferMessage
{
	private static readonly MessageParser<LMHOIMLGNGM> _parser = new MessageParser<LMHOIMLGNGM>(() => new LMHOIMLGNGM());

	private UnknownFieldSet _unknownFields;

	public const int ALFHNEHOBJAFieldNumber = 5;

	private NHJLJBJJKFJ aLFHNEHOBJA_;

	public const int IdFieldNumber = 8;

	private uint id_;

	public const int MJLHLLMJHGJFieldNumber = 15;

	private DifficultyAdjustmentType mJLHLLMJHGJ_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<LMHOIMLGNGM> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => LMHOIMLGNGMReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NHJLJBJJKFJ ALFHNEHOBJA
	{
		get
		{
			return aLFHNEHOBJA_;
		}
		set
		{
			aLFHNEHOBJA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Id
	{
		get
		{
			return id_;
		}
		set
		{
			id_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DifficultyAdjustmentType MJLHLLMJHGJ
	{
		get
		{
			return mJLHLLMJHGJ_;
		}
		set
		{
			mJLHLLMJHGJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LMHOIMLGNGM()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LMHOIMLGNGM(LMHOIMLGNGM other)
		: this()
	{
		aLFHNEHOBJA_ = other.aLFHNEHOBJA_;
		id_ = other.id_;
		mJLHLLMJHGJ_ = other.mJLHLLMJHGJ_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LMHOIMLGNGM Clone()
	{
		return new LMHOIMLGNGM(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as LMHOIMLGNGM);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(LMHOIMLGNGM other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ALFHNEHOBJA != other.ALFHNEHOBJA)
		{
			return false;
		}
		if (Id != other.Id)
		{
			return false;
		}
		if (MJLHLLMJHGJ != other.MJLHLLMJHGJ)
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
		if (ALFHNEHOBJA != NHJLJBJJKFJ.Looneaoeiml)
		{
			num ^= ALFHNEHOBJA.GetHashCode();
		}
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (MJLHLLMJHGJ != DifficultyAdjustmentType.NjaaeoficmlCgkeiaipaek)
		{
			num ^= MJLHLLMJHGJ.GetHashCode();
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
		if (ALFHNEHOBJA != NHJLJBJJKFJ.Looneaoeiml)
		{
			output.WriteRawTag(40);
			output.WriteEnum((int)ALFHNEHOBJA);
		}
		if (Id != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(Id);
		}
		if (MJLHLLMJHGJ != DifficultyAdjustmentType.NjaaeoficmlCgkeiaipaek)
		{
			output.WriteRawTag(120);
			output.WriteEnum((int)MJLHLLMJHGJ);
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
		if (ALFHNEHOBJA != NHJLJBJJKFJ.Looneaoeiml)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)ALFHNEHOBJA);
		}
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Id);
		}
		if (MJLHLLMJHGJ != DifficultyAdjustmentType.NjaaeoficmlCgkeiaipaek)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)MJLHLLMJHGJ);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(LMHOIMLGNGM other)
	{
		if (other != null)
		{
			if (other.ALFHNEHOBJA != NHJLJBJJKFJ.Looneaoeiml)
			{
				ALFHNEHOBJA = other.ALFHNEHOBJA;
			}
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.MJLHLLMJHGJ != DifficultyAdjustmentType.NjaaeoficmlCgkeiaipaek)
			{
				MJLHLLMJHGJ = other.MJLHLLMJHGJ;
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
				ALFHNEHOBJA = (NHJLJBJJKFJ)input.ReadEnum();
				break;
			case 64u:
				Id = input.ReadUInt32();
				break;
			case 120u:
				MJLHLLMJHGJ = (DifficultyAdjustmentType)input.ReadEnum();
				break;
			}
		}
	}
}
