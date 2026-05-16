using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GIGAKCOMKOG : IMessage<GIGAKCOMKOG>, IMessage, IEquatable<GIGAKCOMKOG>, IDeepCloneable<GIGAKCOMKOG>, IBufferMessage
{
	private static readonly MessageParser<GIGAKCOMKOG> _parser = new MessageParser<GIGAKCOMKOG>(() => new GIGAKCOMKOG());

	private UnknownFieldSet _unknownFields;

	public const int RankFieldNumber = 1;

	private uint rank_;

	public const int StateFieldNumber = 9;

	private PBKPPEAPBOM state_;

	public const int JKPGACLKEECFieldNumber = 11;

	private uint jKPGACLKEEC_;

	public const int ScoreIdFieldNumber = 12;

	private uint scoreId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GIGAKCOMKOG> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GIGAKCOMKOGReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Rank
	{
		get
		{
			return rank_;
		}
		set
		{
			rank_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PBKPPEAPBOM State
	{
		get
		{
			return state_;
		}
		set
		{
			state_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint JKPGACLKEEC
	{
		get
		{
			return jKPGACLKEEC_;
		}
		set
		{
			jKPGACLKEEC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ScoreId
	{
		get
		{
			return scoreId_;
		}
		set
		{
			scoreId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GIGAKCOMKOG()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GIGAKCOMKOG(GIGAKCOMKOG other)
		: this()
	{
		rank_ = other.rank_;
		state_ = other.state_;
		jKPGACLKEEC_ = other.jKPGACLKEEC_;
		scoreId_ = other.scoreId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GIGAKCOMKOG Clone()
	{
		return new GIGAKCOMKOG(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GIGAKCOMKOG);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GIGAKCOMKOG other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Rank != other.Rank)
		{
			return false;
		}
		if (State != other.State)
		{
			return false;
		}
		if (JKPGACLKEEC != other.JKPGACLKEEC)
		{
			return false;
		}
		if (ScoreId != other.ScoreId)
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
		if (Rank != 0)
		{
			num ^= Rank.GetHashCode();
		}
		if (State != PBKPPEAPBOM.Bnjmpchfina)
		{
			num ^= State.GetHashCode();
		}
		if (JKPGACLKEEC != 0)
		{
			num ^= JKPGACLKEEC.GetHashCode();
		}
		if (ScoreId != 0)
		{
			num ^= ScoreId.GetHashCode();
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
		if (Rank != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(Rank);
		}
		if (State != PBKPPEAPBOM.Bnjmpchfina)
		{
			output.WriteRawTag(72);
			output.WriteEnum((int)State);
		}
		if (JKPGACLKEEC != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(JKPGACLKEEC);
		}
		if (ScoreId != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(ScoreId);
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
		if (Rank != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Rank);
		}
		if (State != PBKPPEAPBOM.Bnjmpchfina)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)State);
		}
		if (JKPGACLKEEC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(JKPGACLKEEC);
		}
		if (ScoreId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ScoreId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GIGAKCOMKOG other)
	{
		if (other != null)
		{
			if (other.Rank != 0)
			{
				Rank = other.Rank;
			}
			if (other.State != PBKPPEAPBOM.Bnjmpchfina)
			{
				State = other.State;
			}
			if (other.JKPGACLKEEC != 0)
			{
				JKPGACLKEEC = other.JKPGACLKEEC;
			}
			if (other.ScoreId != 0)
			{
				ScoreId = other.ScoreId;
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
				Rank = input.ReadUInt32();
				break;
			case 72u:
				State = (PBKPPEAPBOM)input.ReadEnum();
				break;
			case 88u:
				JKPGACLKEEC = input.ReadUInt32();
				break;
			case 96u:
				ScoreId = input.ReadUInt32();
				break;
			}
		}
	}
}
