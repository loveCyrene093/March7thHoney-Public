using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class SpaceZooOpCatteryCsReq : IMessage<SpaceZooOpCatteryCsReq>, IMessage, IEquatable<SpaceZooOpCatteryCsReq>, IDeepCloneable<SpaceZooOpCatteryCsReq>, IBufferMessage
{
	private static readonly MessageParser<SpaceZooOpCatteryCsReq> _parser = new MessageParser<SpaceZooOpCatteryCsReq>(() => new SpaceZooOpCatteryCsReq());

	private UnknownFieldSet _unknownFields;

	public const int OpTypeFieldNumber = 3;

	private uint opType_;

	public const int IKAGBIMJPOMFieldNumber = 4;

	private uint iKAGBIMJPOM_;

	public const int BFLKIJDPPAIFieldNumber = 12;

	private uint bFLKIJDPPAI_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SpaceZooOpCatteryCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => SpaceZooOpCatteryCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint OpType
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
	public uint IKAGBIMJPOM
	{
		get
		{
			return iKAGBIMJPOM_;
		}
		set
		{
			iKAGBIMJPOM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint BFLKIJDPPAI
	{
		get
		{
			return bFLKIJDPPAI_;
		}
		set
		{
			bFLKIJDPPAI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SpaceZooOpCatteryCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SpaceZooOpCatteryCsReq(SpaceZooOpCatteryCsReq other)
		: this()
	{
		opType_ = other.opType_;
		iKAGBIMJPOM_ = other.iKAGBIMJPOM_;
		bFLKIJDPPAI_ = other.bFLKIJDPPAI_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SpaceZooOpCatteryCsReq Clone()
	{
		return new SpaceZooOpCatteryCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as SpaceZooOpCatteryCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SpaceZooOpCatteryCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (OpType != other.OpType)
		{
			return false;
		}
		if (IKAGBIMJPOM != other.IKAGBIMJPOM)
		{
			return false;
		}
		if (BFLKIJDPPAI != other.BFLKIJDPPAI)
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
		if (OpType != 0)
		{
			num ^= OpType.GetHashCode();
		}
		if (IKAGBIMJPOM != 0)
		{
			num ^= IKAGBIMJPOM.GetHashCode();
		}
		if (BFLKIJDPPAI != 0)
		{
			num ^= BFLKIJDPPAI.GetHashCode();
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
		if (OpType != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(OpType);
		}
		if (IKAGBIMJPOM != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(IKAGBIMJPOM);
		}
		if (BFLKIJDPPAI != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(BFLKIJDPPAI);
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
		if (OpType != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(OpType);
		}
		if (IKAGBIMJPOM != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(IKAGBIMJPOM);
		}
		if (BFLKIJDPPAI != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BFLKIJDPPAI);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(SpaceZooOpCatteryCsReq other)
	{
		if (other != null)
		{
			if (other.OpType != 0)
			{
				OpType = other.OpType;
			}
			if (other.IKAGBIMJPOM != 0)
			{
				IKAGBIMJPOM = other.IKAGBIMJPOM;
			}
			if (other.BFLKIJDPPAI != 0)
			{
				BFLKIJDPPAI = other.BFLKIJDPPAI;
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
				OpType = input.ReadUInt32();
				break;
			case 32u:
				IKAGBIMJPOM = input.ReadUInt32();
				break;
			case 96u:
				BFLKIJDPPAI = input.ReadUInt32();
				break;
			}
		}
	}
}
