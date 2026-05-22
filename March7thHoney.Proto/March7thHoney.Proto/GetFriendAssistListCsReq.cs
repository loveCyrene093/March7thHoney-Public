using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GetFriendAssistListCsReq : IMessage<GetFriendAssistListCsReq>, IMessage, IEquatable<GetFriendAssistListCsReq>, IDeepCloneable<GetFriendAssistListCsReq>, IBufferMessage
{
	private static readonly MessageParser<GetFriendAssistListCsReq> _parser = new MessageParser<GetFriendAssistListCsReq>(() => new GetFriendAssistListCsReq());

	private UnknownFieldSet _unknownFields;

	public const int IPMGLMJFGNPFieldNumber = 1;

	private static readonly FieldCodec<uint> _repeated_iPMGLMJFGNP_codec = FieldCodec.ForUInt32(10u);

	private readonly RepeatedField<uint> iPMGLMJFGNP_ = new RepeatedField<uint>();

	public const int NJAAPGJANCIFieldNumber = 2;

	private IPGFCGHIIKN nJAAPGJANCI_;

	public const int TargetSideFieldNumber = 7;

	private uint targetSide_;

	public const int ICHENOJECAPFieldNumber = 13;

	private bool iCHENOJECAP_;

	public const int NLEEIBAPFAAFieldNumber = 14;

	private static readonly FieldCodec<uint> _repeated_nLEEIBAPFAA_codec = FieldCodec.ForUInt32(114u);

	private readonly RepeatedField<uint> nLEEIBAPFAA_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GetFriendAssistListCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GetFriendAssistListCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> IPMGLMJFGNP => iPMGLMJFGNP_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IPGFCGHIIKN NJAAPGJANCI
	{
		get
		{
			return nJAAPGJANCI_;
		}
		set
		{
			nJAAPGJANCI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint TargetSide
	{
		get
		{
			return targetSide_;
		}
		set
		{
			targetSide_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool ICHENOJECAP
	{
		get
		{
			return iCHENOJECAP_;
		}
		set
		{
			iCHENOJECAP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> NLEEIBAPFAA => nLEEIBAPFAA_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetFriendAssistListCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetFriendAssistListCsReq(GetFriendAssistListCsReq other)
		: this()
	{
		iPMGLMJFGNP_ = other.iPMGLMJFGNP_.Clone();
		nJAAPGJANCI_ = other.nJAAPGJANCI_;
		targetSide_ = other.targetSide_;
		iCHENOJECAP_ = other.iCHENOJECAP_;
		nLEEIBAPFAA_ = other.nLEEIBAPFAA_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetFriendAssistListCsReq Clone()
	{
		return new GetFriendAssistListCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GetFriendAssistListCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GetFriendAssistListCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!iPMGLMJFGNP_.Equals(other.iPMGLMJFGNP_))
		{
			return false;
		}
		if (NJAAPGJANCI != other.NJAAPGJANCI)
		{
			return false;
		}
		if (TargetSide != other.TargetSide)
		{
			return false;
		}
		if (ICHENOJECAP != other.ICHENOJECAP)
		{
			return false;
		}
		if (!nLEEIBAPFAA_.Equals(other.nLEEIBAPFAA_))
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
		num ^= iPMGLMJFGNP_.GetHashCode();
		if (NJAAPGJANCI != IPGFCGHIIKN.Kojihmknjic)
		{
			num ^= NJAAPGJANCI.GetHashCode();
		}
		if (TargetSide != 0)
		{
			num ^= TargetSide.GetHashCode();
		}
		if (ICHENOJECAP)
		{
			num ^= ICHENOJECAP.GetHashCode();
		}
		num ^= nLEEIBAPFAA_.GetHashCode();
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
		iPMGLMJFGNP_.WriteTo(ref output, _repeated_iPMGLMJFGNP_codec);
		if (NJAAPGJANCI != IPGFCGHIIKN.Kojihmknjic)
		{
			output.WriteRawTag(16);
			output.WriteEnum((int)NJAAPGJANCI);
		}
		if (TargetSide != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(TargetSide);
		}
		if (ICHENOJECAP)
		{
			output.WriteRawTag(104);
			output.WriteBool(ICHENOJECAP);
		}
		nLEEIBAPFAA_.WriteTo(ref output, _repeated_nLEEIBAPFAA_codec);
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
		num += iPMGLMJFGNP_.CalculateSize(_repeated_iPMGLMJFGNP_codec);
		if (NJAAPGJANCI != IPGFCGHIIKN.Kojihmknjic)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)NJAAPGJANCI);
		}
		if (TargetSide != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(TargetSide);
		}
		if (ICHENOJECAP)
		{
			num += 2;
		}
		num += nLEEIBAPFAA_.CalculateSize(_repeated_nLEEIBAPFAA_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GetFriendAssistListCsReq other)
	{
		if (other != null)
		{
			iPMGLMJFGNP_.Add(other.iPMGLMJFGNP_);
			if (other.NJAAPGJANCI != IPGFCGHIIKN.Kojihmknjic)
			{
				NJAAPGJANCI = other.NJAAPGJANCI;
			}
			if (other.TargetSide != 0)
			{
				TargetSide = other.TargetSide;
			}
			if (other.ICHENOJECAP)
			{
				ICHENOJECAP = other.ICHENOJECAP;
			}
			nLEEIBAPFAA_.Add(other.nLEEIBAPFAA_);
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
			case 10u:
				iPMGLMJFGNP_.AddEntriesFrom(ref input, _repeated_iPMGLMJFGNP_codec);
				break;
			case 16u:
				NJAAPGJANCI = (IPGFCGHIIKN)input.ReadEnum();
				break;
			case 56u:
				TargetSide = input.ReadUInt32();
				break;
			case 104u:
				ICHENOJECAP = input.ReadBool();
				break;
			case 112u:
			case 114u:
				nLEEIBAPFAA_.AddEntriesFrom(ref input, _repeated_nLEEIBAPFAA_codec);
				break;
			}
		}
	}
}
