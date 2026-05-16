using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ChessRogueCheatRollCsReq : IMessage<ChessRogueCheatRollCsReq>, IMessage, IEquatable<ChessRogueCheatRollCsReq>, IDeepCloneable<ChessRogueCheatRollCsReq>, IBufferMessage
{
	private static readonly MessageParser<ChessRogueCheatRollCsReq> _parser = new MessageParser<ChessRogueCheatRollCsReq>(() => new ChessRogueCheatRollCsReq());

	private UnknownFieldSet _unknownFields;

	public const int BGPBIMDCBBLFieldNumber = 3;

	private uint bGPBIMDCBBL_;

	public const int CCOGFKLOFKLFieldNumber = 10;

	private uint cCOGFKLOFKL_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ChessRogueCheatRollCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ChessRogueCheatRollCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint BGPBIMDCBBL
	{
		get
		{
			return bGPBIMDCBBL_;
		}
		set
		{
			bGPBIMDCBBL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CCOGFKLOFKL
	{
		get
		{
			return cCOGFKLOFKL_;
		}
		set
		{
			cCOGFKLOFKL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChessRogueCheatRollCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChessRogueCheatRollCsReq(ChessRogueCheatRollCsReq other)
		: this()
	{
		bGPBIMDCBBL_ = other.bGPBIMDCBBL_;
		cCOGFKLOFKL_ = other.cCOGFKLOFKL_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChessRogueCheatRollCsReq Clone()
	{
		return new ChessRogueCheatRollCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ChessRogueCheatRollCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ChessRogueCheatRollCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (BGPBIMDCBBL != other.BGPBIMDCBBL)
		{
			return false;
		}
		if (CCOGFKLOFKL != other.CCOGFKLOFKL)
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
		if (BGPBIMDCBBL != 0)
		{
			num ^= BGPBIMDCBBL.GetHashCode();
		}
		if (CCOGFKLOFKL != 0)
		{
			num ^= CCOGFKLOFKL.GetHashCode();
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
		if (BGPBIMDCBBL != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(BGPBIMDCBBL);
		}
		if (CCOGFKLOFKL != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(CCOGFKLOFKL);
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
		if (BGPBIMDCBBL != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BGPBIMDCBBL);
		}
		if (CCOGFKLOFKL != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CCOGFKLOFKL);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ChessRogueCheatRollCsReq other)
	{
		if (other != null)
		{
			if (other.BGPBIMDCBBL != 0)
			{
				BGPBIMDCBBL = other.BGPBIMDCBBL;
			}
			if (other.CCOGFKLOFKL != 0)
			{
				CCOGFKLOFKL = other.CCOGFKLOFKL;
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
				BGPBIMDCBBL = input.ReadUInt32();
				break;
			case 80u:
				CCOGFKLOFKL = input.ReadUInt32();
				break;
			}
		}
	}
}
