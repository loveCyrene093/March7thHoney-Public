using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class AIPEMEEDHAK : IMessage<AIPEMEEDHAK>, IMessage, IEquatable<AIPEMEEDHAK>, IDeepCloneable<AIPEMEEDHAK>, IBufferMessage
{
	private static readonly MessageParser<AIPEMEEDHAK> _parser = new MessageParser<AIPEMEEDHAK>(() => new AIPEMEEDHAK());

	private UnknownFieldSet _unknownFields;

	public const int EPLBCNFMLILFieldNumber = 1;

	private uint ePLBCNFMLIL_;

	public const int StageIdFieldNumber = 3;

	private uint stageId_;

	public const int IsWinFieldNumber = 4;

	private bool isWin_;

	public const int JMIKPCPIFCDFieldNumber = 9;

	private static readonly FieldCodec<IFLOGJBONHI> _repeated_jMIKPCPIFCD_codec = FieldCodec.ForMessage(74u, IFLOGJBONHI.Parser);

	private readonly RepeatedField<IFLOGJBONHI> jMIKPCPIFCD_ = new RepeatedField<IFLOGJBONHI>();

	public const int ICHMKFMAIBBFieldNumber = 11;

	private static readonly FieldCodec<IAMALMLBOEI> _repeated_iCHMKFMAIBB_codec = FieldCodec.ForMessage(90u, IAMALMLBOEI.Parser);

	private readonly RepeatedField<IAMALMLBOEI> iCHMKFMAIBB_ = new RepeatedField<IAMALMLBOEI>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<AIPEMEEDHAK> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => AIPEMEEDHAKReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public uint StageId
	{
		get
		{
			return stageId_;
		}
		set
		{
			stageId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool IsWin
	{
		get
		{
			return isWin_;
		}
		set
		{
			isWin_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<IFLOGJBONHI> JMIKPCPIFCD => jMIKPCPIFCD_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<IAMALMLBOEI> ICHMKFMAIBB => iCHMKFMAIBB_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AIPEMEEDHAK()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AIPEMEEDHAK(AIPEMEEDHAK other)
		: this()
	{
		ePLBCNFMLIL_ = other.ePLBCNFMLIL_;
		stageId_ = other.stageId_;
		isWin_ = other.isWin_;
		jMIKPCPIFCD_ = other.jMIKPCPIFCD_.Clone();
		iCHMKFMAIBB_ = other.iCHMKFMAIBB_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AIPEMEEDHAK Clone()
	{
		return new AIPEMEEDHAK(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as AIPEMEEDHAK);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(AIPEMEEDHAK other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (EPLBCNFMLIL != other.EPLBCNFMLIL)
		{
			return false;
		}
		if (StageId != other.StageId)
		{
			return false;
		}
		if (IsWin != other.IsWin)
		{
			return false;
		}
		if (!jMIKPCPIFCD_.Equals(other.jMIKPCPIFCD_))
		{
			return false;
		}
		if (!iCHMKFMAIBB_.Equals(other.iCHMKFMAIBB_))
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
		if (EPLBCNFMLIL != 0)
		{
			num ^= EPLBCNFMLIL.GetHashCode();
		}
		if (StageId != 0)
		{
			num ^= StageId.GetHashCode();
		}
		if (IsWin)
		{
			num ^= IsWin.GetHashCode();
		}
		num ^= jMIKPCPIFCD_.GetHashCode();
		num ^= iCHMKFMAIBB_.GetHashCode();
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
		if (EPLBCNFMLIL != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(EPLBCNFMLIL);
		}
		if (StageId != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(StageId);
		}
		if (IsWin)
		{
			output.WriteRawTag(32);
			output.WriteBool(IsWin);
		}
		jMIKPCPIFCD_.WriteTo(ref output, _repeated_jMIKPCPIFCD_codec);
		iCHMKFMAIBB_.WriteTo(ref output, _repeated_iCHMKFMAIBB_codec);
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
		if (EPLBCNFMLIL != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EPLBCNFMLIL);
		}
		if (StageId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(StageId);
		}
		if (IsWin)
		{
			num += 2;
		}
		num += jMIKPCPIFCD_.CalculateSize(_repeated_jMIKPCPIFCD_codec);
		num += iCHMKFMAIBB_.CalculateSize(_repeated_iCHMKFMAIBB_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(AIPEMEEDHAK other)
	{
		if (other != null)
		{
			if (other.EPLBCNFMLIL != 0)
			{
				EPLBCNFMLIL = other.EPLBCNFMLIL;
			}
			if (other.StageId != 0)
			{
				StageId = other.StageId;
			}
			if (other.IsWin)
			{
				IsWin = other.IsWin;
			}
			jMIKPCPIFCD_.Add(other.jMIKPCPIFCD_);
			iCHMKFMAIBB_.Add(other.iCHMKFMAIBB_);
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
				EPLBCNFMLIL = input.ReadUInt32();
				break;
			case 24u:
				StageId = input.ReadUInt32();
				break;
			case 32u:
				IsWin = input.ReadBool();
				break;
			case 74u:
				jMIKPCPIFCD_.AddEntriesFrom(ref input, _repeated_jMIKPCPIFCD_codec);
				break;
			case 90u:
				iCHMKFMAIBB_.AddEntriesFrom(ref input, _repeated_iCHMKFMAIBB_codec);
				break;
			}
		}
	}
}
