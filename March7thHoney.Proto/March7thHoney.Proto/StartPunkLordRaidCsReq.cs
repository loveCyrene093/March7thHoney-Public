using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class StartPunkLordRaidCsReq : IMessage<StartPunkLordRaidCsReq>, IMessage, IEquatable<StartPunkLordRaidCsReq>, IDeepCloneable<StartPunkLordRaidCsReq>, IBufferMessage
{
	private static readonly MessageParser<StartPunkLordRaidCsReq> _parser = new MessageParser<StartPunkLordRaidCsReq>(() => new StartPunkLordRaidCsReq());

	private UnknownFieldSet _unknownFields;

	public const int UidFieldNumber = 6;

	private uint uid_;

	public const int MonsterIdFieldNumber = 7;

	private uint monsterId_;

	public const int GEALJOJCJFNFieldNumber = 12;

	private bool gEALJOJCJFN_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<StartPunkLordRaidCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => StartPunkLordRaidCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Uid
	{
		get
		{
			return uid_;
		}
		set
		{
			uid_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MonsterId
	{
		get
		{
			return monsterId_;
		}
		set
		{
			monsterId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool GEALJOJCJFN
	{
		get
		{
			return gEALJOJCJFN_;
		}
		set
		{
			gEALJOJCJFN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public StartPunkLordRaidCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public StartPunkLordRaidCsReq(StartPunkLordRaidCsReq other)
		: this()
	{
		uid_ = other.uid_;
		monsterId_ = other.monsterId_;
		gEALJOJCJFN_ = other.gEALJOJCJFN_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public StartPunkLordRaidCsReq Clone()
	{
		return new StartPunkLordRaidCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as StartPunkLordRaidCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(StartPunkLordRaidCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Uid != other.Uid)
		{
			return false;
		}
		if (MonsterId != other.MonsterId)
		{
			return false;
		}
		if (GEALJOJCJFN != other.GEALJOJCJFN)
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
		if (Uid != 0)
		{
			num ^= Uid.GetHashCode();
		}
		if (MonsterId != 0)
		{
			num ^= MonsterId.GetHashCode();
		}
		if (GEALJOJCJFN)
		{
			num ^= GEALJOJCJFN.GetHashCode();
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
		if (Uid != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(Uid);
		}
		if (MonsterId != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(MonsterId);
		}
		if (GEALJOJCJFN)
		{
			output.WriteRawTag(96);
			output.WriteBool(GEALJOJCJFN);
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
		if (Uid != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Uid);
		}
		if (MonsterId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MonsterId);
		}
		if (GEALJOJCJFN)
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
	public void MergeFrom(StartPunkLordRaidCsReq other)
	{
		if (other != null)
		{
			if (other.Uid != 0)
			{
				Uid = other.Uid;
			}
			if (other.MonsterId != 0)
			{
				MonsterId = other.MonsterId;
			}
			if (other.GEALJOJCJFN)
			{
				GEALJOJCJFN = other.GEALJOJCJFN;
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
				Uid = input.ReadUInt32();
				break;
			case 56u:
				MonsterId = input.ReadUInt32();
				break;
			case 96u:
				GEALJOJCJFN = input.ReadBool();
				break;
			}
		}
	}
}
