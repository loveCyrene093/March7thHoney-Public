using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class HKLKGJCJJEB : IMessage<HKLKGJCJJEB>, IMessage, IEquatable<HKLKGJCJJEB>, IDeepCloneable<HKLKGJCJJEB>, IBufferMessage
{
	private static readonly MessageParser<HKLKGJCJJEB> _parser = new MessageParser<HKLKGJCJJEB>(() => new HKLKGJCJJEB());

	private UnknownFieldSet _unknownFields;

	public const int NDHEAAKAPKKFieldNumber = 1;

	private uint nDHEAAKAPKK_;

	public const int GroupIdFieldNumber = 5;

	private uint groupId_;

	public const int OpTypeFieldNumber = 8;

	private IPEEDBPJEKE opType_;

	public const int MNPPEEGEAEJFieldNumber = 14;

	private uint mNPPEEGEAEJ_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<HKLKGJCJJEB> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => HKLKGJCJJEBReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint NDHEAAKAPKK
	{
		get
		{
			return nDHEAAKAPKK_;
		}
		set
		{
			nDHEAAKAPKK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GroupId
	{
		get
		{
			return groupId_;
		}
		set
		{
			groupId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IPEEDBPJEKE OpType
	{
		get
		{
			return opType_;
		}
		set
		{
			opType_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MNPPEEGEAEJ
	{
		get
		{
			return mNPPEEGEAEJ_;
		}
		set
		{
			mNPPEEGEAEJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HKLKGJCJJEB()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HKLKGJCJJEB(HKLKGJCJJEB other)
		: this()
	{
		nDHEAAKAPKK_ = other.nDHEAAKAPKK_;
		groupId_ = other.groupId_;
		opType_ = other.opType_;
		mNPPEEGEAEJ_ = other.mNPPEEGEAEJ_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HKLKGJCJJEB Clone()
	{
		return new HKLKGJCJJEB(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as HKLKGJCJJEB);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(HKLKGJCJJEB other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (NDHEAAKAPKK != other.NDHEAAKAPKK)
		{
			return false;
		}
		if (GroupId != other.GroupId)
		{
			return false;
		}
		if (OpType != other.OpType)
		{
			return false;
		}
		if (MNPPEEGEAEJ != other.MNPPEEGEAEJ)
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
		if (NDHEAAKAPKK != 0)
		{
			num ^= NDHEAAKAPKK.GetHashCode();
		}
		if (GroupId != 0)
		{
			num ^= GroupId.GetHashCode();
		}
		if (OpType != IPEEDBPJEKE.Pcpdhelpkem)
		{
			num ^= OpType.GetHashCode();
		}
		if (MNPPEEGEAEJ != 0)
		{
			num ^= MNPPEEGEAEJ.GetHashCode();
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
		if (NDHEAAKAPKK != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(NDHEAAKAPKK);
		}
		if (GroupId != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(GroupId);
		}
		if (OpType != IPEEDBPJEKE.Pcpdhelpkem)
		{
			output.WriteRawTag(64);
			output.WriteEnum((int)OpType);
		}
		if (MNPPEEGEAEJ != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(MNPPEEGEAEJ);
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
		if (NDHEAAKAPKK != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(NDHEAAKAPKK);
		}
		if (GroupId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GroupId);
		}
		if (OpType != IPEEDBPJEKE.Pcpdhelpkem)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)OpType);
		}
		if (MNPPEEGEAEJ != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MNPPEEGEAEJ);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(HKLKGJCJJEB other)
	{
		if (other != null)
		{
			if (other.NDHEAAKAPKK != 0)
			{
				NDHEAAKAPKK = other.NDHEAAKAPKK;
			}
			if (other.GroupId != 0)
			{
				GroupId = other.GroupId;
			}
			if (other.OpType != IPEEDBPJEKE.Pcpdhelpkem)
			{
				OpType = other.OpType;
			}
			if (other.MNPPEEGEAEJ != 0)
			{
				MNPPEEGEAEJ = other.MNPPEEGEAEJ;
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
				NDHEAAKAPKK = input.ReadUInt32();
				break;
			case 40u:
				GroupId = input.ReadUInt32();
				break;
			case 64u:
				OpType = (IPEEDBPJEKE)input.ReadEnum();
				break;
			case 112u:
				MNPPEEGEAEJ = input.ReadUInt32();
				break;
			}
		}
	}
}
