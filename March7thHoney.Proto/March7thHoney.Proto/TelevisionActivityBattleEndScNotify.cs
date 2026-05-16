using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class TelevisionActivityBattleEndScNotify : IMessage<TelevisionActivityBattleEndScNotify>, IMessage, IEquatable<TelevisionActivityBattleEndScNotify>, IDeepCloneable<TelevisionActivityBattleEndScNotify>, IBufferMessage
{
	private static readonly MessageParser<TelevisionActivityBattleEndScNotify> _parser = new MessageParser<TelevisionActivityBattleEndScNotify>(() => new TelevisionActivityBattleEndScNotify());

	private UnknownFieldSet _unknownFields;

	public const int KAEDEEMOCDAFieldNumber = 4;

	private CKFHOLKJAGC kAEDEEMOCDA_;

	public const int EPLBCNFMLILFieldNumber = 7;

	private uint ePLBCNFMLIL_;

	public const int NECABLBKHKNFieldNumber = 8;

	private uint nECABLBKHKN_;

	public const int TurnLeftFieldNumber = 10;

	private uint turnLeft_;

	public const int OLGHPOODENKFieldNumber = 13;

	private uint oLGHPOODENK_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<TelevisionActivityBattleEndScNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => TelevisionActivityBattleEndScNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CKFHOLKJAGC KAEDEEMOCDA
	{
		get
		{
			return kAEDEEMOCDA_;
		}
		set
		{
			kAEDEEMOCDA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint EPLBCNFMLIL
	{
		get
		{
			return ePLBCNFMLIL_;
		}
		set
		{
			ePLBCNFMLIL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint NECABLBKHKN
	{
		get
		{
			return nECABLBKHKN_;
		}
		set
		{
			nECABLBKHKN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint TurnLeft
	{
		get
		{
			return turnLeft_;
		}
		set
		{
			turnLeft_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint OLGHPOODENK
	{
		get
		{
			return oLGHPOODENK_;
		}
		set
		{
			oLGHPOODENK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TelevisionActivityBattleEndScNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TelevisionActivityBattleEndScNotify(TelevisionActivityBattleEndScNotify other)
		: this()
	{
		kAEDEEMOCDA_ = ((other.kAEDEEMOCDA_ != null) ? other.kAEDEEMOCDA_.Clone() : null);
		ePLBCNFMLIL_ = other.ePLBCNFMLIL_;
		nECABLBKHKN_ = other.nECABLBKHKN_;
		turnLeft_ = other.turnLeft_;
		oLGHPOODENK_ = other.oLGHPOODENK_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TelevisionActivityBattleEndScNotify Clone()
	{
		return new TelevisionActivityBattleEndScNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as TelevisionActivityBattleEndScNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(TelevisionActivityBattleEndScNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(KAEDEEMOCDA, other.KAEDEEMOCDA))
		{
			return false;
		}
		if (EPLBCNFMLIL != other.EPLBCNFMLIL)
		{
			return false;
		}
		if (NECABLBKHKN != other.NECABLBKHKN)
		{
			return false;
		}
		if (TurnLeft != other.TurnLeft)
		{
			return false;
		}
		if (OLGHPOODENK != other.OLGHPOODENK)
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
		if (kAEDEEMOCDA_ != null)
		{
			num ^= KAEDEEMOCDA.GetHashCode();
		}
		if (EPLBCNFMLIL != 0)
		{
			num ^= EPLBCNFMLIL.GetHashCode();
		}
		if (NECABLBKHKN != 0)
		{
			num ^= NECABLBKHKN.GetHashCode();
		}
		if (TurnLeft != 0)
		{
			num ^= TurnLeft.GetHashCode();
		}
		if (OLGHPOODENK != 0)
		{
			num ^= OLGHPOODENK.GetHashCode();
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
		if (kAEDEEMOCDA_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(KAEDEEMOCDA);
		}
		if (EPLBCNFMLIL != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(EPLBCNFMLIL);
		}
		if (NECABLBKHKN != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(NECABLBKHKN);
		}
		if (TurnLeft != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(TurnLeft);
		}
		if (OLGHPOODENK != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(OLGHPOODENK);
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
		if (kAEDEEMOCDA_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(KAEDEEMOCDA);
		}
		if (EPLBCNFMLIL != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EPLBCNFMLIL);
		}
		if (NECABLBKHKN != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(NECABLBKHKN);
		}
		if (TurnLeft != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(TurnLeft);
		}
		if (OLGHPOODENK != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(OLGHPOODENK);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(TelevisionActivityBattleEndScNotify other)
	{
		if (other == null)
		{
			return;
		}
		if (other.kAEDEEMOCDA_ != null)
		{
			if (kAEDEEMOCDA_ == null)
			{
				KAEDEEMOCDA = new CKFHOLKJAGC();
			}
			KAEDEEMOCDA.MergeFrom(other.KAEDEEMOCDA);
		}
		if (other.EPLBCNFMLIL != 0)
		{
			EPLBCNFMLIL = other.EPLBCNFMLIL;
		}
		if (other.NECABLBKHKN != 0)
		{
			NECABLBKHKN = other.NECABLBKHKN;
		}
		if (other.TurnLeft != 0)
		{
			TurnLeft = other.TurnLeft;
		}
		if (other.OLGHPOODENK != 0)
		{
			OLGHPOODENK = other.OLGHPOODENK;
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
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
			case 34u:
				if (kAEDEEMOCDA_ == null)
				{
					KAEDEEMOCDA = new CKFHOLKJAGC();
				}
				input.ReadMessage(KAEDEEMOCDA);
				break;
			case 56u:
				EPLBCNFMLIL = input.ReadUInt32();
				break;
			case 64u:
				NECABLBKHKN = input.ReadUInt32();
				break;
			case 80u:
				TurnLeft = input.ReadUInt32();
				break;
			case 104u:
				OLGHPOODENK = input.ReadUInt32();
				break;
			}
		}
	}
}
